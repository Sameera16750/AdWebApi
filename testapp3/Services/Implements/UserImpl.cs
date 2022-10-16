using System;
using System.Collections.Generic;
using testapp3.Modals.Entity;
using testapp3.Payloads;
using testapp3.Repositories.Interfaces;
using testapp3.Services.InterFaces;

namespace testapp3.Services.Implements
{
    public class UserImpl : IUser
    {
        IUserRepo userRepo;
        ITeam team;
        ITeamRepo teamRepo;
        EUserTypes eUserTypes = new EUserTypes();
        EUser user = new EUser();
        EInsideUser insideUser = new EInsideUser();
        ETeamOwner eTeamOwner=new ETeamOwner();
        EPlayer ePlayer=new EPlayer();
        DefaultResponse defaultResponse=new DefaultResponse();
        UserTypePayload uTypePayload=new UserTypePayload();
        LoginResponse loginResponse=new LoginResponse();

        public UserImpl(IUserRepo userRepo,ITeam team,ITeamRepo teamRepo)
        {
            this.userRepo = userRepo;
            this.team = team;
            this.teamRepo=teamRepo;
        }

        public DefaultResponse addInternalUser(InternalUserPayload internalUser)
        {
            long savedId=userRepo.AddInternalUser(insideUser.setEInsideUser(internalUser,userRepo.GetUserById(addUserDetails(internalUser.user).id)));
            if (savedId > 0)
            {
                return defaultResponse.setResponse(savedId,"User Save Success 🎉🎉🎉🎉",true);
            }
            else
            {
                return defaultResponse.setResponse(0, "<server side error> user not saved , please try again later ", false);
            }
        }

        public DefaultResponse addPleyer(PlayerPayload player)
        {
            long savedUserId = addUserDetails(player.user).id;
            if (savedUserId > 0)
            {
                long savedPlayerId=userRepo.AddPlayer(ePlayer.setPlayerDetails(player, userRepo.GetUserById(savedUserId)));
                if(savedPlayerId > 0)
                {
                    return defaultResponse.setResponse(savedPlayerId,"Player Saved Success 🎉🎉🎉",true);
                }
                else
                {
                    return defaultResponse.setResponse(0,"<Internal Server Error >player not saved, Somthing Went Wrong Please Try Agin later",false);
                }
            }
            else
            {
                return defaultResponse.setResponse(0, "<Internal Server Error >user not saved, Somthing Went Wrong Please Try Agin later", false);
            }
            
        }

        public DefaultResponse addTeamOwner(TeamOwnerPayload teamOwner)
        {
            long savedTeamId = team.AddTeam(teamOwner.team).id;
            if ( savedTeamId> 0)
            {
                long savedUserId = addUserDetails(teamOwner.user).id;
                if (savedUserId> 0)
                {
                    long savedOwner = userRepo.AddTeamOwner(eTeamOwner.setTeamOwnerDetails(teamOwner, teamRepo.GetTeamById(savedTeamId), userRepo.GetUserById(savedUserId)));
                    if(savedOwner> 0)
                    {
                        return defaultResponse.setResponse(savedOwner, "Team Owner Saved Success 🎉🎉🎉", true);
                    }
                    else
                    {
                        return defaultResponse.setResponse(0, "<Internal Server Error > Team Owner Was Not Saved, Somthing went wrong, pleas try again later", false);
                    }
                }
                else
                {
                    return defaultResponse.setResponse(0, "<Internal Server Error > User Was Not Saved, Somthing went wrong, pleas try again later", false);
                }
            }
            else
            {
                return defaultResponse.setResponse(0, "<Internal Server Error > Team Was Not Saved, Somthing went wrong, pleas try again later", false);
            }
        }

        public DefaultResponse addUserDetails(UserPayload userDetails)
        {
            EUserTypes types = userRepo.getUsertypeById(userDetails.uTypeId);
            if (types != null)
            {
                long savedId = userRepo.AddUser(user.setUserDetails(userDetails, types));
                if (savedId!>0 && savedId!=null)
                {
                    return defaultResponse.setResponse(savedId,"User saved Succes 🎉🎉🎉🎉",true);
                }
                else
                {
                    return defaultResponse.setResponse(0, "<server side error> user not saved , please try again later ", false);
                }
            }
            else
            {
                return defaultResponse.setResponse(0, "usertype not found", false);
            }
        }

        public DefaultResponse addUserType(UserTypePayload userType)
        {
            long id= userRepo.AddCategory(eUserTypes.setUserTypes(userType));
            if (id != 0)
            {
                return defaultResponse.setResponse(id, "New User type Saved 🎉🎉", true);
            }
            else
            {
                return defaultResponse.setResponse(0, "< This ServerSide error > something went wrong please try again later", true);
            }
        }

        public List<UserTypePayload> getAllActiveUserTypes()
        {
            List<EUserTypes> eUserTypeList = userRepo.GetAllActiveUserTypes();
            if (eUserTypeList.Count > 0)
            {
                return uTypePayload.setUserTypeList(eUserTypeList);
            }
            else
            {
                return null;
            }
        }

        public LoginResponse login(LoginRequest request)
        {
            EUser user = userRepo.UserDetails(request.UserName, request.Password);
            if( user!= null)
            {
                return loginResponse.setLoginResponse(defaultResponse.setResponse(user.id,user.name,true),uTypePayload.setUserTypeDetail(user.type));
            }
            else
            {
                return loginResponse.setLoginResponse(defaultResponse.
                    setResponse(0,"Incorrect User name Or Password Please Check User Name Or password",false),null);
            }
        }
    }
}
