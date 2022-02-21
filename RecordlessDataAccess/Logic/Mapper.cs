using RecordlessDataAccess.DbModels;
using RecordlessDomain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordlessDataAccess.Logic
{
    public class Mapper
    {

        #region --- Domain to Data Access layer ---
        // ! ***********************************
        // ! ************ Account **************
        // ! ***********************************
        public static AccountModel MapAccount(Account _account)
        {
            return new AccountModel
            { 
                Id = _account.Id,
                Address = _account.Address,
                City = _account.City,
                ZipCode = _account.ZipCode, 
                State = _account.State,
                ClientId = _account.ClientId,
                Followers = _account.Followers,
                Following = _account.Following,
                RecordlessPro  = _account.RecordlessPro,
            };
        }

        // ! ***********************************
        // ! ************ Client ***************
        // ! ***********************************
        public static ClientModel MapClient(Client _client)
        {
            return new ClientModel
            {
                Id= _client.Id,
                DateCreated = _client.DateCreated,
                FirstName = _client.FirstName,
                LastName = _client.LastName,
                Email = _client.Email,
                IsVerified = _client.IsVerified,
                MediaCount = _client.MediaCount,
                Password = _client.Password,
                ProfilePicture = _client.ProfilePicture,
            };
        }

        // ! ***********************************
        // ! ************ Content **************
        // ! ***********************************
        public static ContentModel MapContent(Content _content)
        {
            return new ContentModel
            {
                Id = _content.Id,
                DateCreated = _content.DateCreated,
                MediaContent = _content.MediaContent,
                Thumbnail = _content.Thumbnail,
                Title = _content.Title,
            };
        }

        // ! ***********************************
        // ! ************ Follower *************
        // ! ***********************************
        public static FollowerModel MapFollower(Follower _follower)
        {
            return new FollowerModel
            {
                Id=_follower.Id,
                FollowerId = _follower.FollowerId,
                UserId = _follower.UserId,
            };
        }

        // ! ***********************************
        // ! *********** Following *************
        // ! ***********************************
        public static FollowingModel MapFollowing(Following _following)
        {
            return new FollowingModel
            {
                Id = _following.Id,
                FollowingId = _following.FollowingId,
                UserId = _following.UserId,
            };
        }

        #endregion



        #region --- Data Access Layer to Domain ---
        // ! ***********************************
        // ! ************ Account **************
        // ! ***********************************
        public static Account MapAccount(AccountModel _account)
        {
            return new Account
            {
                Id = _account.Id,
                Address = _account.Address,
                City = _account.City,
                ZipCode = _account.ZipCode,
                State = _account.State,
                ClientId = _account.ClientId,
                Followers = _account.Followers,
                Following = _account.Following,
                RecordlessPro = _account.RecordlessPro,
            };
        }

        // ! ***********************************
        // ! ************ Client ***************
        // ! ***********************************
        public static Client MapClient(ClientModel _client)
        {
            return new Client
            {
                Id = _client.Id,
                DateCreated = _client.DateCreated,
                FirstName = _client.FirstName,
                LastName = _client.LastName,
                Email = _client.Email,
                IsVerified = _client.IsVerified,
                MediaCount = _client.MediaCount,
                Password = _client.Password,
                ProfilePicture = _client.ProfilePicture,
            };
        }

        // ! ***********************************
        // ! ************ Content **************
        // ! ***********************************
        public static Content MapContent(ContentModel _content)
        {
            return new Content
            {
                Id=_content.Id,
                DateCreated = _content.DateCreated,
                MediaContent = _content.MediaContent,
                Thumbnail = _content.Thumbnail,
                Title = _content.Title,
            };
        }

        // ! ***********************************
        // ! ************ Follower *************
        // ! ***********************************
        public static Follower MapFollower(FollowerModel _follower)
        {
            return new Follower
            {
                Id = _follower.Id,
                FollowerId = _follower.FollowerId,
                UserId = _follower.UserId,
            };
        }

        // ! ***********************************
        // ! *********** Following *************
        // ! ***********************************
        public static Following MapFollowing(FollowingModel _following)
        {
            return new Following
            {
                Id = _following.Id,
                FollowingId = _following.FollowingId,
                UserId = _following.UserId,
            };
        }
        #endregion
    }
}
