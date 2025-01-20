using GestAct.Dto;
using GestAct.Models;

namespace GestAct.Mappers
{
    public static class UserMappers
    {
        public static UserDto UserDto(this User userModel)
        {
            //Retourne un nouvel Dto de type User
            return new UserDto
            {
                Id = userModel.Id,
                Username = userModel.Username,
                City = userModel.City,
                Municipality = userModel.Municipality,
                Email = userModel.Email,
                Phone = userModel.Phone,
                Manager = userModel.Manager,

            };
        }
    }
}
