using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//using statements for serialization
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Shipping
{
    class Serializer
    {
        public static void SerializeNow(Invoice inv)
        {
            //setup a memory stream object that is needed
            //to hold the obj in memory during the
            //format and transformation process
            MemoryStream myStream = new MemoryStream();

            //setup the binary formatting obj that
            //performs the format process
            BinaryFormatter myFormat = new BinaryFormatter();

            //we call the serailize method, passing the
            //stream so we know where to save and obj it
            //will transform
            myFormat.Serialize(myStream, inv);

            //now that the obj is serialized, covert to
            //Base64 for encoding and easy storage
            string serializedValue = Convert.ToBase64String(myStream.ToArray());

            //call the Insert method of the DA class
            DataAdapter.Insert(serializedValue);

            //close the stream
            myStream.Close();
        }
        public static Invoice DeSerializeNow(string encodedData)
        {
            //create a generic object to hold the object
            //since we don't know the type of the obj yet
            object type;

            //create a stream and binary formatter
            //to reverse the encoding and give the
            //stream the incoming data
            MemoryStream myStream = new MemoryStream(Convert.FromBase64String(encodedData));
            BinaryFormatter myFormat = new BinaryFormatter();

            //deserialize what we have in memory into
            //the generic object
            type = myFormat.Deserialize(myStream);

            //close the stream
            myStream.Close();

            //test what type of object it is
            if (type.GetType().Name == "Invoice")
            {
                //its an invoice!
                Invoice inv = (Invoice)type;

                //return the invoice
                return inv;
            }
            else
            {
                Invoice inv = new Invoice();
                return inv;
            }

        }
    }
}
