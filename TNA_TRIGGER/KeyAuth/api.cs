using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace KeyAuth
{
	// Token: 0x02000002 RID: 2
	public class api
	{
		// Token: 0x06000002 RID: 2 RVA: 0x000033D8 File Offset: 0x000015D8
		public api(string name, string ownerid, string secret, string version)
		{
			if (ownerid.Length != 10 || secret.Length != 64)
			{
				Delegate47.smethod_0("https://youtube.com/watch?v=RfDTdiBq4_o");
				Delegate47.smethod_0("https://keyauth.cc/app/");
				Delegate289.smethod_0(2000);
				api.error("Application not setup correctly. Please watch the YouTube video for setup.");
				Delegate244.smethod_0(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00003488 File Offset: 0x00001688
		public void init()
		{
			string text = encryption.iv_key();
			api.enckey = Delegate147.smethod_0(text, "-", this.secret);
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "init");
			Delegate259.smethod_0(obj, "ver", this.version);
			Delegate259.smethod_0(obj, "hash", api.checksum(Delegate251.smethod_0(Delegate48.smethod_0(Delegate327.smethod_0()))));
			Delegate259.smethod_0(obj, "enckey", text);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string text2 = api.req(obj);
			if (Delegate108.smethod_0(text2, "KeyAuth_Invalid"))
			{
				api.error("Application not found");
				Delegate244.smethod_0(0);
			}
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				if (response_structure.newSession)
				{
					Delegate289.smethod_0(100);
				}
				api.sessionid = response_structure.sessionid;
				this.initialized = true;
				return;
			}
			if (Delegate108.smethod_0(response_structure.message, "invalidver"))
			{
				this.app_data.downloadLink = response_structure.download;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020A3 File Offset: 0x000002A3
		public void CheckInit()
		{
			if (!this.initialized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Delegate244.smethod_0(0);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000035A8 File Offset: 0x000017A8
		public unsafe string expirydaysleft(string Type, int subscription)
		{
			this.CheckInit();
			DateTime dateTime_;
			Delegate118.smethod_0(&dateTime_, 1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			DateTime dateTime = Delegate0.smethod_0(&dateTime_, (double)Delegate331.smethod_0(this.user_data.subscriptions[subscription].expiry));
			dateTime_ = Delegate243.smethod_0(&dateTime);
			TimeSpan timeSpan = Delegate341.smethod_0(dateTime_, Delegate102.smethod_0());
			string string_ = Type.ToLower();
			if (Delegate108.smethod_0(string_, "months"))
			{
				return Delegate258.smethod_0(Delegate335.smethod_0(&timeSpan) / 30);
			}
			if (Delegate108.smethod_0(string_, "days"))
			{
				return Delegate258.smethod_0(Delegate335.smethod_0(&timeSpan));
			}
			if (!Delegate108.smethod_0(string_, "hours"))
			{
				return null;
			}
			return Delegate258.smethod_0(Delegate238.smethod_0(&timeSpan));
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00003660 File Offset: 0x00001860
		public void register(string username, string pass, string key, string email = "")
		{
			this.CheckInit();
			string value = Delegate214.smethod_0(Delegate143.smethod_0()).Value;
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "register");
			Delegate259.smethod_0(obj, "username", username);
			Delegate259.smethod_0(obj, "pass", pass);
			Delegate259.smethod_0(obj, "key", key);
			Delegate259.smethod_0(obj, "email", email);
			Delegate259.smethod_0(obj, "hwid", value);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00003738 File Offset: 0x00001938
		public void forgot(string username, string email)
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "forgot");
			Delegate259.smethod_0(obj, "username", username);
			Delegate259.smethod_0(obj, "email", email);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000037C4 File Offset: 0x000019C4
		public void login(string username, string pass)
		{
			this.CheckInit();
			string value = Delegate214.smethod_0(Delegate143.smethod_0()).Value;
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "login");
			Delegate259.smethod_0(obj, "username", username);
			Delegate259.smethod_0(obj, "pass", pass);
			Delegate259.smethod_0(obj, "hwid", value);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00003880 File Offset: 0x00001A80
		public void logout()
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "logout");
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000038F4 File Offset: 0x00001AF4
		public void web_login()
		{
			this.CheckInit();
			string value = Delegate214.smethod_0(Delegate143.smethod_0()).Value;
			HttpListener object_;
			HttpListenerRequest object_3;
			HttpListenerResponse object_4;
			for (;;)
			{
				object_ = Delegate68.smethod_0();
				string text = "handshake";
				text = Delegate147.smethod_0("http://localhost:1337/", text, "/");
				Delegate133.smethod_0(Delegate13.smethod_0(object_), text);
				Delegate122.smethod_0(object_);
				HttpListenerContext object_2 = Delegate183.smethod_0(object_);
				object_3 = Delegate63.smethod_0(object_2);
				object_4 = Delegate85.smethod_0(object_2);
				Delegate207.smethod_0(object_4, "Access-Control-Allow-Methods", "GET, POST");
				Delegate207.smethod_0(object_4, "Access-Control-Allow-Origin", "*");
				Delegate207.smethod_0(object_4, "Via", "hugzho's big brain");
				Delegate207.smethod_0(object_4, "Location", "your kernel ;)");
				Delegate207.smethod_0(object_4, "Retry-After", "never lmao");
				Delegate132.smethod_0(Delegate302.smethod_0(object_4), "Server", "\r\n\r\n");
				if (!Delegate108.smethod_0(Delegate7.smethod_0(object_3), "OPTIONS"))
				{
					break;
				}
				Delegate119.smethod_0(object_4, 200);
				Delegate289.smethod_0(1);
				Delegate71.smethod_0(object_);
			}
			Delegate298.smethod_0(object_, AuthenticationSchemes.Negotiate);
			Delegate325.smethod_0(object_, true);
			Delegate332.smethod_0(object_, true);
			string text2 = Delegate24.smethod_0(object_3).Replace("/handshake?user=", "").Replace("&token=", " ");
			string string_ = text2.Split(Array.Empty<char>())[0];
			string string_2 = text2.Split(new char[]
			{
				' '
			})[1];
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "login");
			Delegate259.smethod_0(obj, "username", string_);
			Delegate259.smethod_0(obj, "token", string_2);
			Delegate259.smethod_0(obj, "hwid", value);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			bool flag = true;
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
				Delegate119.smethod_0(object_4, 420);
				Delegate126.smethod_0(object_4, "SHEESH");
			}
			else
			{
				Delegate254.smethod_0(response_structure.message);
				Delegate119.smethod_0(object_4, 200);
				Delegate126.smethod_0(object_4, response_structure.message);
				flag = false;
			}
			byte[] array = Delegate73.smethod_0(Delegate288.smethod_0(), "Whats up?");
			Delegate334.smethod_0(object_4, (long)array.Length);
			Delegate94.smethod_0(Delegate21.smethod_0(object_4), array, 0, array.Length);
			Delegate289.smethod_0(1);
			Delegate71.smethod_0(object_);
			if (!flag)
			{
				Delegate244.smethod_0(0);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003B80 File Offset: 0x00001D80
		public void button(string button)
		{
			this.CheckInit();
			object object_ = Delegate68.smethod_0();
			string string_ = Delegate147.smethod_0("http://localhost:1337/", button, "/");
			Delegate133.smethod_0(Delegate13.smethod_0(object_), string_);
			Delegate122.smethod_0(object_);
			HttpListenerContext object_2 = Delegate183.smethod_0(object_);
			Delegate63.smethod_0(object_2);
			HttpListenerResponse object_3 = Delegate85.smethod_0(object_2);
			Delegate207.smethod_0(object_3, "Access-Control-Allow-Methods", "GET, POST");
			Delegate207.smethod_0(object_3, "Access-Control-Allow-Origin", "*");
			Delegate207.smethod_0(object_3, "Via", "hugzho's big brain");
			Delegate207.smethod_0(object_3, "Location", "your kernel ;)");
			Delegate207.smethod_0(object_3, "Retry-After", "never lmao");
			Delegate132.smethod_0(Delegate302.smethod_0(object_3), "Server", "\r\n\r\n");
			Delegate119.smethod_0(object_3, 420);
			Delegate126.smethod_0(object_3, "SHEESH");
			Delegate298.smethod_0(object_, AuthenticationSchemes.Negotiate);
			Delegate325.smethod_0(object_, true);
			Delegate332.smethod_0(object_, true);
			Delegate71.smethod_0(object_);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003C64 File Offset: 0x00001E64
		public void upgrade(string username, string key)
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "upgrade");
			Delegate259.smethod_0(obj, "username", username);
			Delegate259.smethod_0(obj, "key", key);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			response_structure.success = false;
			this.load_response_struct(response_structure);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public void license(string key)
		{
			this.CheckInit();
			string value = Delegate214.smethod_0(Delegate143.smethod_0()).Value;
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "license");
			Delegate259.smethod_0(obj, "key", key);
			Delegate259.smethod_0(obj, "hwid", value);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003DA8 File Offset: 0x00001FA8
		public void check()
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "check");
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003E1C File Offset: 0x0000201C
		public void setvar(string var, string data)
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "setvar");
			Delegate259.smethod_0(obj, "var", var);
			Delegate259.smethod_0(obj, "data", data);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003EA8 File Offset: 0x000020A8
		public string getvar(string var)
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "getvar");
			Delegate259.smethod_0(obj, "var", var);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.response;
			}
			return null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003F38 File Offset: 0x00002138
		public void ban(string reason = null)
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "ban");
			Delegate259.smethod_0(obj, "reason", reason);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003FB8 File Offset: 0x000021B8
		public string var(string varid)
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "var");
			Delegate259.smethod_0(obj, "varid", varid);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.message;
			}
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00004048 File Offset: 0x00002248
		public List<api.users> fetchOnline()
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "fetchOnline");
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.users;
			}
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000040CC File Offset: 0x000022CC
		public void fetchStats()
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "fetchStats");
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_app_data(response_structure.appinfo);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00004154 File Offset: 0x00002354
		public List<api.msg> chatget(string channelname)
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "chatget");
			Delegate259.smethod_0(obj, "channel", channelname);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.messages;
			}
			return null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000041E4 File Offset: 0x000023E4
		public bool chatsend(string msg, string channelname)
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "chatsend");
			Delegate259.smethod_0(obj, "message", msg);
			Delegate259.smethod_0(obj, "channel", channelname);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000427C File Offset: 0x0000247C
		public bool checkblack()
		{
			this.CheckInit();
			string value = Delegate214.smethod_0(Delegate143.smethod_0()).Value;
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "checkblacklist");
			Delegate259.smethod_0(obj, "hwid", value);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004318 File Offset: 0x00002518
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "webhook");
			Delegate259.smethod_0(obj, "webid", webid);
			Delegate259.smethod_0(obj, "params", param);
			Delegate259.smethod_0(obj, "body", body);
			Delegate259.smethod_0(obj, "conttype", conttype);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.response;
			}
			return null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000043D0 File Offset: 0x000025D0
		public byte[] download(string fileid)
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "file");
			Delegate259.smethod_0(obj, "fileid", fileid);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return encryption.str_to_byte_arr(response_structure.contents);
			}
			return null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004468 File Offset: 0x00002668
		public void log(string message)
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "log");
			Delegate259.smethod_0(obj, "pcuser", Delegate223.smethod_0());
			Delegate259.smethod_0(obj, "message", message);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			api.req(obj);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000044E4 File Offset: 0x000026E4
		public void changeUsername(string username)
		{
			this.CheckInit();
			object obj = Delegate166.smethod_0();
			Delegate259.smethod_0(obj, "type", "changeUsername");
			Delegate259.smethod_0(obj, "newUsername", username);
			Delegate259.smethod_0(obj, "sessionid", api.sessionid);
			Delegate259.smethod_0(obj, "name", this.name);
			Delegate259.smethod_0(obj, "ownerid", this.ownerid);
			string json = api.req(obj);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004564 File Offset: 0x00002764
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = Delegate275.smethod_0())
			{
				using (FileStream fileStream = Delegate173.smethod_0(filename))
				{
					result = Delegate312.smethod_0(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000045D4 File Offset: 0x000027D4
		public static void error(string message)
		{
			object obj = Delegate338.smethod_0("cmd.exe", Delegate147.smethod_0("/c start cmd /C \"color b && title Error && echo ", message, " && timeout /t 5\""));
			Delegate128.smethod_0(obj, true);
			Delegate138.smethod_0(obj, true);
			Delegate208.smethod_0(obj, true);
			Delegate278.smethod_0(obj, false);
			Delegate236.smethod_0(obj);
			Delegate244.smethod_0(0);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004624 File Offset: 0x00002824
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = Delegate56.smethod_0())
				{
					Delegate240.smethod_0(webClient, null);
					Delegate29.smethod_0((RemoteCertificateValidationCallback)Delegate100.smethod_0(Delegate252.smethod_0(), Delegate205.smethod_0(null, ldftn(assertSSL))));
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					byte[] byte_ = Delegate140.smethod_0(webClient, "https://keyauth.win/api/1.2/", post_data);
					stopwatch.Stop();
					api.responseTime = stopwatch.ElapsedMilliseconds;
					RemoteCertificateValidationCallback remoteCertificateValidationCallback_;
					if ((remoteCertificateValidationCallback_ = api.<>c.<>9__42_0) == null)
					{
						remoteCertificateValidationCallback_ = (api.<>c.<>9__42_0 = Delegate205.smethod_0(api.<>c.<>9, ldftn(<req>b__42_0)));
					}
					Delegate29.smethod_0(remoteCertificateValidationCallback_);
					api.sigCheck(Delegate294.smethod_0(Delegate106.smethod_0(), byte_), Delegate157.smethod_0(Delegate329.smethod_0(webClient), "signature"), Delegate148.smethod_0(post_data, 0));
					result = Delegate294.smethod_0(Delegate106.smethod_0(), byte_);
				}
			}
			catch (WebException ex)
			{
				if (((HttpWebResponse)ex.Response).StatusCode == (HttpStatusCode)429)
				{
					api.error("You're connecting too fast to loader, slow down.");
					Delegate244.smethod_0(0);
					result = "";
				}
				else
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Delegate244.smethod_0(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000474C File Offset: 0x0000294C
		private static bool assertSSL(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			if ((!Delegate306.smethod_0(certificate).Contains("Cloudflare Inc") && !Delegate306.smethod_0(certificate).Contains("Google Trust Services") && !Delegate306.smethod_0(certificate).Contains("Let's Encrypt")) || sslPolicyErrors != SslPolicyErrors.None)
			{
				api.error("SSL assertion fail, make sure you're not debugging Network. Disable internet firewall on router if possible. & echo: & echo If not, ask the developer of the program to use custom domains to fix this.");
				return false;
			}
			return true;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000047A0 File Offset: 0x000029A0
		private static void sigCheck(string resp, string signature, string type)
		{
			if (!Delegate108.smethod_0(type, "log") && !Delegate108.smethod_0(type, "file"))
			{
				try
				{
					if (!encryption.CheckStringsFixedTime(encryption.HashHMAC(Delegate108.smethod_0(type, "init") ? api.enckey.Substring(17, 64) : api.enckey, resp), signature))
					{
						api.error(Delegate301.smethod_0("Signature checksum failed. Request was tampered with or session ended most likely. & echo: & echo Response: ", resp));
						Delegate244.smethod_0(0);
					}
				}
				catch
				{
					api.error(Delegate301.smethod_0("Signature checksum failed. Request was tampered with or session ended most likely. & echo: & echo Response: ", resp));
					Delegate244.smethod_0(0);
				}
				return;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000483C File Offset: 0x00002A3C
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000048A0 File Offset: 0x00002AA0
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020BD File Offset: 0x000002BD
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x04000001 RID: 1
		public string name;

		// Token: 0x04000002 RID: 2
		public string ownerid;

		// Token: 0x04000003 RID: 3
		public string secret;

		// Token: 0x04000004 RID: 4
		public string version;

		// Token: 0x04000005 RID: 5
		public static long responseTime;

		// Token: 0x04000006 RID: 6
		private static string sessionid;

		// Token: 0x04000007 RID: 7
		private static string enckey;

		// Token: 0x04000008 RID: 8
		private bool initialized;

		// Token: 0x04000009 RID: 9
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x0400000A RID: 10
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400000B RID: 11
		public api.Data data = new api.Data();

		// Token: 0x0400000C RID: 12
		public api.response_class response = new api.response_class();

		// Token: 0x0400000D RID: 13
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000003 RID: 3
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000024 RID: 36 RVA: 0x000020E1 File Offset: 0x000002E1
			// (set) Token: 0x06000025 RID: 37 RVA: 0x000020E9 File Offset: 0x000002E9
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000026 RID: 38 RVA: 0x000020F2 File Offset: 0x000002F2
			// (set) Token: 0x06000027 RID: 39 RVA: 0x000020FA File Offset: 0x000002FA
			[DataMember]
			public bool newSession { get; set; }

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000028 RID: 40 RVA: 0x00002103 File Offset: 0x00000303
			// (set) Token: 0x06000029 RID: 41 RVA: 0x0000210B File Offset: 0x0000030B
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600002A RID: 42 RVA: 0x00002114 File Offset: 0x00000314
			// (set) Token: 0x0600002B RID: 43 RVA: 0x0000211C File Offset: 0x0000031C
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600002C RID: 44 RVA: 0x00002125 File Offset: 0x00000325
			// (set) Token: 0x0600002D RID: 45 RVA: 0x0000212D File Offset: 0x0000032D
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600002E RID: 46 RVA: 0x00002136 File Offset: 0x00000336
			// (set) Token: 0x0600002F RID: 47 RVA: 0x0000213E File Offset: 0x0000033E
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000030 RID: 48 RVA: 0x00002147 File Offset: 0x00000347
			// (set) Token: 0x06000031 RID: 49 RVA: 0x0000214F File Offset: 0x0000034F
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000032 RID: 50 RVA: 0x00002158 File Offset: 0x00000358
			// (set) Token: 0x06000033 RID: 51 RVA: 0x00002160 File Offset: 0x00000360
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000034 RID: 52 RVA: 0x00002169 File Offset: 0x00000369
			// (set) Token: 0x06000035 RID: 53 RVA: 0x00002171 File Offset: 0x00000371
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000036 RID: 54 RVA: 0x0000217A File Offset: 0x0000037A
			// (set) Token: 0x06000037 RID: 55 RVA: 0x00002182 File Offset: 0x00000382
			[DataMember]
			public List<api.msg> messages { get; set; }

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000038 RID: 56 RVA: 0x0000218B File Offset: 0x0000038B
			// (set) Token: 0x06000039 RID: 57 RVA: 0x00002193 File Offset: 0x00000393
			[DataMember]
			public List<api.users> users { get; set; }
		}

		// Token: 0x02000004 RID: 4
		public class msg
		{
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600003B RID: 59 RVA: 0x000021A4 File Offset: 0x000003A4
			// (set) Token: 0x0600003C RID: 60 RVA: 0x000021AC File Offset: 0x000003AC
			public string message { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600003D RID: 61 RVA: 0x000021B5 File Offset: 0x000003B5
			// (set) Token: 0x0600003E RID: 62 RVA: 0x000021BD File Offset: 0x000003BD
			public string author { get; set; }

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x0600003F RID: 63 RVA: 0x000021C6 File Offset: 0x000003C6
			// (set) Token: 0x06000040 RID: 64 RVA: 0x000021CE File Offset: 0x000003CE
			public string timestamp { get; set; }
		}

		// Token: 0x02000005 RID: 5
		public class users
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000042 RID: 66 RVA: 0x000021D7 File Offset: 0x000003D7
			// (set) Token: 0x06000043 RID: 67 RVA: 0x000021DF File Offset: 0x000003DF
			public string credential { get; set; }
		}

		// Token: 0x02000006 RID: 6
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000045 RID: 69 RVA: 0x000021E8 File Offset: 0x000003E8
			// (set) Token: 0x06000046 RID: 70 RVA: 0x000021F0 File Offset: 0x000003F0
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000047 RID: 71 RVA: 0x000021F9 File Offset: 0x000003F9
			// (set) Token: 0x06000048 RID: 72 RVA: 0x00002201 File Offset: 0x00000401
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000049 RID: 73 RVA: 0x0000220A File Offset: 0x0000040A
			// (set) Token: 0x0600004A RID: 74 RVA: 0x00002212 File Offset: 0x00000412
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600004B RID: 75 RVA: 0x0000221B File Offset: 0x0000041B
			// (set) Token: 0x0600004C RID: 76 RVA: 0x00002223 File Offset: 0x00000423
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600004D RID: 77 RVA: 0x0000222C File Offset: 0x0000042C
			// (set) Token: 0x0600004E RID: 78 RVA: 0x00002234 File Offset: 0x00000434
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600004F RID: 79 RVA: 0x0000223D File Offset: 0x0000043D
			// (set) Token: 0x06000050 RID: 80 RVA: 0x00002245 File Offset: 0x00000445
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000007 RID: 7
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000052 RID: 82 RVA: 0x0000224E File Offset: 0x0000044E
			// (set) Token: 0x06000053 RID: 83 RVA: 0x00002256 File Offset: 0x00000456
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000054 RID: 84 RVA: 0x0000225F File Offset: 0x0000045F
			// (set) Token: 0x06000055 RID: 85 RVA: 0x00002267 File Offset: 0x00000467
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000056 RID: 86 RVA: 0x00002270 File Offset: 0x00000470
			// (set) Token: 0x06000057 RID: 87 RVA: 0x00002278 File Offset: 0x00000478
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000058 RID: 88 RVA: 0x00002281 File Offset: 0x00000481
			// (set) Token: 0x06000059 RID: 89 RVA: 0x00002289 File Offset: 0x00000489
			[DataMember]
			public string version { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600005A RID: 90 RVA: 0x00002292 File Offset: 0x00000492
			// (set) Token: 0x0600005B RID: 91 RVA: 0x0000229A File Offset: 0x0000049A
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600005C RID: 92 RVA: 0x000022A3 File Offset: 0x000004A3
			// (set) Token: 0x0600005D RID: 93 RVA: 0x000022AB File Offset: 0x000004AB
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x02000008 RID: 8
		public class Info
		{
			// Token: 0x1700001C RID: 28
			// (get) Token: 0x0600005F RID: 95 RVA: 0x000022B4 File Offset: 0x000004B4
			// (set) Token: 0x06000060 RID: 96 RVA: 0x000022BB File Offset: 0x000004BB
			public static string License { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000061 RID: 97 RVA: 0x000022C3 File Offset: 0x000004C3
			// (set) Token: 0x06000062 RID: 98 RVA: 0x000022CA File Offset: 0x000004CA
			public static string Expires { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000063 RID: 99 RVA: 0x000022D2 File Offset: 0x000004D2
			// (set) Token: 0x06000064 RID: 100 RVA: 0x000022D9 File Offset: 0x000004D9
			public static string IP { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000065 RID: 101 RVA: 0x000022E1 File Offset: 0x000004E1
			// (set) Token: 0x06000066 RID: 102 RVA: 0x000022E8 File Offset: 0x000004E8
			public static string Checked { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000067 RID: 103 RVA: 0x000022F0 File Offset: 0x000004F0
			// (set) Token: 0x06000068 RID: 104 RVA: 0x000022F7 File Offset: 0x000004F7
			public static string HWID { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000069 RID: 105 RVA: 0x000022FF File Offset: 0x000004FF
			// (set) Token: 0x0600006A RID: 106 RVA: 0x00002306 File Offset: 0x00000506
			public static string Username { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600006B RID: 107 RVA: 0x0000230E File Offset: 0x0000050E
			// (set) Token: 0x0600006C RID: 108 RVA: 0x00002315 File Offset: 0x00000515
			public static string Level { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x0600006D RID: 109 RVA: 0x0000231D File Offset: 0x0000051D
			// (set) Token: 0x0600006E RID: 110 RVA: 0x00002324 File Offset: 0x00000524
			public static string Debug { get; set; }
		}

		// Token: 0x02000009 RID: 9
		public class app_data_class
		{
			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000070 RID: 112 RVA: 0x0000232C File Offset: 0x0000052C
			// (set) Token: 0x06000071 RID: 113 RVA: 0x00002334 File Offset: 0x00000534
			public string numUsers { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000072 RID: 114 RVA: 0x0000233D File Offset: 0x0000053D
			// (set) Token: 0x06000073 RID: 115 RVA: 0x00002345 File Offset: 0x00000545
			public string numOnlineUsers { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000074 RID: 116 RVA: 0x0000234E File Offset: 0x0000054E
			// (set) Token: 0x06000075 RID: 117 RVA: 0x00002356 File Offset: 0x00000556
			public string numKeys { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000076 RID: 118 RVA: 0x0000235F File Offset: 0x0000055F
			// (set) Token: 0x06000077 RID: 119 RVA: 0x00002367 File Offset: 0x00000567
			public string version { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000078 RID: 120 RVA: 0x00002370 File Offset: 0x00000570
			// (set) Token: 0x06000079 RID: 121 RVA: 0x00002378 File Offset: 0x00000578
			public string customerPanelLink { get; set; }

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600007A RID: 122 RVA: 0x00002381 File Offset: 0x00000581
			// (set) Token: 0x0600007B RID: 123 RVA: 0x00002389 File Offset: 0x00000589
			public string downloadLink { get; set; }
		}

		// Token: 0x0200000A RID: 10
		public class user_data_class
		{
			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600007D RID: 125 RVA: 0x00002392 File Offset: 0x00000592
			// (set) Token: 0x0600007E RID: 126 RVA: 0x0000239A File Offset: 0x0000059A
			public string username { get; set; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600007F RID: 127 RVA: 0x000023A3 File Offset: 0x000005A3
			// (set) Token: 0x06000080 RID: 128 RVA: 0x000023AB File Offset: 0x000005AB
			public string ip { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000081 RID: 129 RVA: 0x000023B4 File Offset: 0x000005B4
			// (set) Token: 0x06000082 RID: 130 RVA: 0x000023BC File Offset: 0x000005BC
			public string hwid { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000083 RID: 131 RVA: 0x000023C5 File Offset: 0x000005C5
			// (set) Token: 0x06000084 RID: 132 RVA: 0x000023CD File Offset: 0x000005CD
			public string createdate { get; set; }

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000085 RID: 133 RVA: 0x000023D6 File Offset: 0x000005D6
			// (set) Token: 0x06000086 RID: 134 RVA: 0x000023DE File Offset: 0x000005DE
			public string lastlogin { get; set; }

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000087 RID: 135 RVA: 0x000023E7 File Offset: 0x000005E7
			// (set) Token: 0x06000088 RID: 136 RVA: 0x000023EF File Offset: 0x000005EF
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200000B RID: 11
		public class Data
		{
			// Token: 0x17000030 RID: 48
			// (get) Token: 0x0600008A RID: 138 RVA: 0x000023F8 File Offset: 0x000005F8
			// (set) Token: 0x0600008B RID: 139 RVA: 0x00002400 File Offset: 0x00000600
			public string subscription { get; set; }

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600008C RID: 140 RVA: 0x00002409 File Offset: 0x00000609
			// (set) Token: 0x0600008D RID: 141 RVA: 0x00002411 File Offset: 0x00000611
			public string expiry { get; set; }

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x0600008E RID: 142 RVA: 0x0000241A File Offset: 0x0000061A
			// (set) Token: 0x0600008F RID: 143 RVA: 0x00002422 File Offset: 0x00000622
			public string timeleft { get; set; }
		}

		// Token: 0x0200000C RID: 12
		public class response_class
		{
			// Token: 0x17000033 RID: 51
			// (get) Token: 0x06000091 RID: 145 RVA: 0x0000242B File Offset: 0x0000062B
			// (set) Token: 0x06000092 RID: 146 RVA: 0x00002433 File Offset: 0x00000633
			public bool success { get; set; }

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000093 RID: 147 RVA: 0x0000243C File Offset: 0x0000063C
			// (set) Token: 0x06000094 RID: 148 RVA: 0x00002444 File Offset: 0x00000644
			public string message { get; set; }
		}
	}
}
