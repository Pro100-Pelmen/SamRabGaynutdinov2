using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamRabGaynutdinov2.Entities;

public class UserEntity
{

    public int Id { get; set; }
    public string Fio { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }

    public List<TrainingEntity> Trainigs { get; set; } = [];

    public UserEntity()
    {
        
    }

    public UserEntity(
        string fio,
        string login,
        string password)
    {

        Fio = fio;
        Login = login;
        Password = password;

    }


}
