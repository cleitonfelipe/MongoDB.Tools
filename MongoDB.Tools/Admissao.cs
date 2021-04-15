using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDB.Tools
{
    public class Admissao
    {
        [BsonId()]
        public ObjectId Id { get; set; }

        [BsonElement("coop_location")]
        public string coop_location { get; set; }

        [BsonElement("cpf")]
        public string cpf { get; set; }

        [BsonElement("phone")]
        public string phone { get; set; }

        [BsonElement("social_name")]
        public string social_name { get; set; }

        [BsonElement("birth_date")]
        public string birth_date { get; set; }

        [BsonElement("full_name")]
        public string full_name { get; set; }

        [BsonElement("document_kind")]
        public string document_kind { get; set; }

        [BsonElement("document_number'")]
        public string document_number { get; set; }

        [BsonElement("document_issue_date")]
        public string document_issue_date { get; set; }

        [BsonElement("document_issue_entity")]
        public string document_issue_entity { get; set; }

        [BsonElement("document_issue_uf")]
        public string document_issue_uf { get; set; }

        [BsonElement("citizenship")]
        public string citizenship { get; set; }

        [BsonElement("birth_city")]
        public string birth_city { get; set; }

        [BsonElement("birth_uf ")]
        public string birth_uf { get; set; }

        [BsonElement("mother_name")]
        public string mother_name { get; set; }

        [BsonElement("address_cep")]
        public string address_cep { get; set; }

        [BsonElement("address_street")]
        public string address_street { get; set; }

        [BsonElement("address_number")]
        public string address_number { get; set; }

        [BsonElement("address_complement")]
        public string address_complement { get; set; }

        [BsonElement("address_district")]
        public string address_district { get; set; }

        [BsonElement("address_city")]
        public string address_city { get; set; }

        [BsonElement("address_uf")]
        public string address_uf { get; set; }

        [BsonElement("email")]
        public string email { get; set; }

        [BsonElement("income")]
        public string income { get; set; }

        [BsonElement("terms")]
        public bool terms { get; set; }

        [BsonElement("left_selfie")]
        public string left_selfie { get; set; }

        [BsonElement("right_selfie")]
        public string right_selfie { get; set; }

        [BsonElement("front_selfie")]
        public string front_selfie { get; set; }

        [BsonElement("document_front")]
        public string document_front { get; set; }

        [BsonElement("document_back")]
        public string document_back { get; set; }

        [BsonElement("address_proof")]
        public string address_proof { get; set; }

        [BsonElement("interests")]
        public string interests { get; set; }

        [BsonElement("status_code")]
        public string status_code { get; set; }

        [BsonElement("status")]
        public string status { get; set; }

        [BsonElement("description")]
        public string description { get; set; }

        [BsonElement("process_number")]
        public string process_number { get; set; }

        [BsonElement("sms_code")]
        public int sms_code { get; set; }

        [BsonElement("sms_valid")]
        public bool sms_valid { get; set; }

        [BsonElement("cooperative")]
        public string cooperative { get; set; }

        [BsonElement("agency")]
        public string agency { get; set; }

        [BsonElement("account")]
        public string account { get; set; }

        [BsonElement("date_creation")]
        public string date_creation { get; set; }

        [BsonElement("last_user")]
        public string last_user { get; set; }

        [BsonElement("comments")]
        public List<Comments> comments { get; set; }
    }

    public class Comments
    {
        [BsonElement("user")]
        public string user { get; set; }

        [BsonElement("date_comments")]
        public string date_comments { get; set; }

        [BsonElement("comments")]
        public string comments { get; set; }
    }
}
