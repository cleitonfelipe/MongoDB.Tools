using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MongoDB.Tools
{
    public class Model
    {
        //[BsonCollection("articles")]
        [BsonIgnoreExtraElements]
        public class Article
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public ObjectId Id { get; set; }

            [BsonElement("headers")]
            [JsonPropertyName("headers")]
            public string[] Headers { get; set; }

            [BsonElement("data")]
            [JsonPropertyName("data")]
            public ArticleData Data { get; set; }

            [BsonElement("status")]
            [JsonPropertyName("status")]
            public int Status { get; set; }

            [BsonElement("visibility")]
            [JsonPropertyName("visibility")]
            public int Visibility { get; set; }

            [BsonElement("articleId")]
            [JsonPropertyName("articleId")]
            public string ArticleId { get; set; }

            public class Ads
            {
                [BsonElement("footerAd")]
                [JsonPropertyName("footerAd")]
                public string FooterAd { get; set; }

                [BsonElement("rightAd")]
                [JsonPropertyName("rightAd")]
                public string RightAd { get; set; }
            }

            public class ArticleData
            {
                [BsonElement("breadcrumbs")]
                [JsonPropertyName("breadcrumbs")]
                public string[] Breadcrumbs { get; set; }

                [BsonElement("title")]
                [JsonPropertyName("title")]
                public string Title { get; set; }

                [BsonElement("slug")]
                [JsonPropertyName("slug")]
                public string Slug { get; set; }

                [BsonElement("metaDescription")]
                [JsonPropertyName("metaDescription")]
                public string MetaDescription { get; set; }

                [BsonElement("content")]
                [JsonPropertyName("content")]
                public string Content { get; set; }

                [BsonElement("blurb")]
                [JsonPropertyName("blurb")]
                public string Blurb { get; set; }

                [BsonElement("authors")]
                [JsonPropertyName("authors")]
                public ArticleAuthor[] Authors { get; set; }

                [BsonElement("primaryCategoryTaxonomy")]
                [JsonPropertyName("primaryCategoryTaxonomy")]
                public ArticleCategory PrimaryCategory;

                [BsonElement("secondaryCategoryTaxonomy")]
                [JsonPropertyName("secondaryCategoryTaxonomy")]
                public ArticleCategory SecondaryCategory;

                [BsonElement("tertiaryCategoryTaxonomy")]
                [JsonPropertyName("tertiaryCategoryTaxonomy")]
                public ArticleCategory TertiaryCategory;

                [BsonElement("trendingArticles")]
                [JsonPropertyName("trendingArticles")]
                public ArticleInfo[] TrendingArticles { get; set; }

                [BsonElement("inThisArticle")]
                [JsonPropertyName("inThisArticle")]
                public object InThisArticle { get; set; }

                [BsonElement("relatedArticles")]
                [JsonPropertyName("relatedArticles")]
                public ArticleInfo[] RelatedArticles { get; set; }

                [BsonElement("relatedBook")]
                [JsonPropertyName("relatedBook")]
                public ArticleBook RelatedBook { get; set; }

                [BsonElement("articleAds")]
                [JsonPropertyName("articleAds")]
                public Ads ArticleAds { get; set; }

                [BsonElement("articleType")]
                [JsonPropertyName("articleType")]
                public ArticleType ArticleType { get; set; }

                [BsonElement("sponsorship")]
                [JsonPropertyName("sponsorship")]
                public Sponsorship SponsorshipPage { get; set; }

                [BsonElement("lifeExpectancy")]
                [JsonPropertyName("lifeExpectancy")]
                public string LifeExpectancy { get; set; }

                [BsonElement("lifeExpectancySetFrom")]
                [JsonPropertyName("lifeExpectancySetFrom")]
                public string LifeExpectancySetFrom { get; set; }

                [BsonElement("readyForReview")]
                [JsonPropertyName("readyForReview")]
                public bool ReadyForReview { get; set; }

                [BsonElement("dummiesForKids")]
                [JsonPropertyName("dummiesForKids")]
                public bool DummiesForKids { get; set; }

                [BsonElement("imagesApprovedUseOutside")]
                [JsonPropertyName("imagesApprovedUseOutside")]
                public bool ImagesApprovedUseOutside { get; set; }

                [BsonElement("sponsoredContent")]
                [JsonPropertyName("sponsoredContent")]
                public bool SponsoredContent { get; set; }

                [BsonElement("adInfo")]
                [JsonPropertyName("adInfo")]
                public string AdInfo { get; set; }

                [BsonElement("adPairKey")]
                [JsonPropertyName("adPairKey")]
                public AdPairInfo[] AdInfoPair { get; set; }
            }

            public class ArticleAuthor
            {
                [BsonElement("authorId")]
                [JsonPropertyName("authorId")]
                public string AuthorId { get; set; }

                [BsonElement("name")]
                [JsonPropertyName("name")]
                public string Name { get; set; }

                [BsonElement("slug")]
                [JsonPropertyName("slug")]
                public string Slug { get; set; }

                [BsonElement("description")]
                [JsonPropertyName("description")]
                public string Description { get; set; }
            }

            public class ArticleCategory
            {
                [BsonElement("categoryId")]
                [JsonPropertyName("categoryId")]
                public string CategoryId { get; set; }

                [BsonElement("title")]
                [JsonPropertyName("title")]
                public string Title { get; set; }
            }

            public class ArticleBook
            {
                [BsonElement("bookId")]
                [JsonPropertyName("bookId")]
                public string BookID { get; set; }

                [BsonElement("slug")]
                [JsonPropertyName("slug")]
                public string Slug { get; set; }

                [BsonElement("amazon")]
                [JsonPropertyName("amazon")]
                public string Amazon { get; set; }

                [BsonElement("image")]
                [JsonPropertyName("image")]
                public Image Image { get; set; }

                [BsonElement("title")]
                [JsonPropertyName("title")]
                public string Title { get; set; }

                [BsonElement("testBankPinActivationLink")]
                [JsonPropertyName("testBankPinActivationLink")]
                public string TestBankPinActivationLink { get; set; }

                [BsonElement("relatedArticles")]
                [JsonPropertyName("relatedArticles")]
                public ArticleInfo[] RelatedArticles { get; set; }

                [BsonElement("bookOutOfPrint")]
                [JsonPropertyName("bookOutOfPrint")]
                public bool BookOutOfPrint { get; set; }
            }

            public class AdPairInfo
            {
                [BsonElement("adPairKey")]
                [JsonPropertyName("adPairKey")]
                public string AdPairInfoKey { get; set; }

                [BsonElement("adPairValue")]
                [JsonPropertyName("adPairValue")]
                public string AdPairInfoValue { get; set; }
            }

            public class ArticleType
            {
                [BsonElement("type")]
                [JsonPropertyName("type")]
                public string Type;

                [BsonElement("options")]
                [JsonPropertyName("options")]
                public string Options;

                [BsonElement("content")]
                [JsonPropertyName("content")]
                public ArticleTypeContent[] Content;
            }

            public class ArticleTypeContent
            {
                [BsonElement("title")]
                [JsonPropertyName("title")]
                public string Title;

                [BsonElement("thumb")]
                [JsonPropertyName("thumb")]
                public Image Thumb;

                [BsonElement("image")]
                [JsonPropertyName("image")]
                public Image Image;

                [BsonElement("content")]
                [JsonPropertyName("content")]
                public string Content;
            }

            public class Sponsorship
            {
                [BsonElement("sponsorshipPage")]
                [JsonPropertyName("sponsorshipPage")]
                public bool SponsorshipPage;

                [BsonElement("backgroundImage")]
                [JsonPropertyName("backgroundImage")]
                public Image BackgroundImage;

                [BsonElement("brandingLine")]
                [JsonPropertyName("brandingLine")]
                public string BrandingLine;

                [BsonElement("brandingLink")]
                [JsonPropertyName("brandingLink")]
                public string BrandingLink;

                [BsonElement("brandingLogo")]
                [JsonPropertyName("brandingLogo")]
                public Image BrandingLogo;
            }
        }

        public class ArticleInfo
        {
            [BsonElement("articleId")]
            [JsonPropertyName("articleId")]
            public string ArticleId { get; set; }

            [BsonElement("title")]
            [JsonPropertyName("title")]
            public string Title { get; set; }

            [BsonElement("link")]
            [JsonPropertyName("link")]
            public string Link { get; set; }
        }

        public class Image
        {
            [BsonElement("src")]
            [JsonPropertyName("src")]
            public string Src { get; set; }

            [BsonElement("width")]
            [JsonPropertyName("width")]
            public int Width { get; set; }

            [BsonElement("height")]
            [JsonPropertyName("height")]
            public int Height { get; set; }
        }
    }
}
