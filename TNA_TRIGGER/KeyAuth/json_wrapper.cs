using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace KeyAuth
{
	// Token: 0x0200000F RID: 15
	public class json_wrapper
	{
		// Token: 0x0600009E RID: 158 RVA: 0x0000245C File Offset: 0x0000065C
		public static bool is_serializable(Type to_check)
		{
			return Delegate145.smethod_0(to_check) || to_check.IsDefined(Delegate340.smethod_0(typeof(DataContractAttribute).TypeHandle), true);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004A64 File Offset: 0x00002C64
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = Delegate268.smethod_0(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw Delegate28.smethod_0(Delegate248.smethod_0("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004AB4 File Offset: 0x00002CB4
		public object string_to_object(string json)
		{
			object result;
			using (MemoryStream memoryStream = Delegate9.smethod_0(Delegate73.smethod_0(Delegate106.smethod_0(), json)))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002479 File Offset: 0x00000679
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000044 RID: 68
		private DataContractJsonSerializer serializer;

		// Token: 0x04000045 RID: 69
		private object current_object;
	}
}
