using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web;

namespace ParaBoLicFunc.Models
{
    [DataContract]
    public class Point
    {
        [DataMember]
        public float x {get; set;}
        [DataMember]
        public float y {get;set;}
        [Key]
        public int PointId { get; set; }

        public int ChartId { get; set; }

        public Point()
        {

        }
        public void Serializer(List<Point> massive)
        {
            string pathofDataSet = "D:/Programming/WebPage2/ParaBoLicFunc/ParaBoLicFunc/Data/DataSet.json";
            if (File.Exists(pathofDataSet))
            {
                File.WriteAllText(pathofDataSet, string.Empty);
            }           
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Point>));

            using (FileStream fs = new FileStream(pathofDataSet, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, massive);
            }
        }
    }
}