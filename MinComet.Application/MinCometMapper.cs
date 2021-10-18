using AutoMapper;
using MinComet.Application.UserInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinComet.Application
{
    public class MinCometMapper:Profile
    {
        public MinCometMapper() {
            CreateMap<IUserService, UserService>();
        }
    }
}
