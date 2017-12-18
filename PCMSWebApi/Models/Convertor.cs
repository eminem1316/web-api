using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;

namespace PCMSWebApi.Models
{
    public class Convertor
    {
        public static DataTable CreateTable<T>()
        {
            Type entType = typeof(T);                           //T –> ClassName
            DataTable tbl = new DataTable(entType.Name);        //set the datatable name as class name
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entType);    //get the property list

            foreach (PropertyDescriptor prop in properties)
                //if (prop.PropertyType.ToString().Contains("Nullable"))
                //    tbl.Columns.Add(prop.Name, typeof(string));
                //else
                //    tbl.Columns.Add(prop.Name, prop.PropertyType);  //add property as column
                tbl.Columns.Add(prop.Name);

            return tbl;
        }

        public static DataTable Generic2DataTable<T>(ObjectResult<T> result)
        {
            DataTable ldt = CreateTable<T>();
            Type entType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entType);

            foreach (T item in result.ToList())
            {
                DataRow row = ldt.NewRow();

                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item);

                ldt.Rows.Add(row);
            }

            return ldt;
        }

        public static byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        private Object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);
            return obj;
        }
    }
}