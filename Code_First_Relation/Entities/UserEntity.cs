namespace Code_First_Relation.Entities
{
    public class UserEntity:BaseEntity
    {
        //Bir kullanıcının birden fazla postu  ılabileceği için bura da list tanımlayacağım 
        public string Email { get; set; }
        public string UserName { get; set; }

        //Realaiton porperty

        public List<PostEntity> Posts { get; set; }

    }
}
