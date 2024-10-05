namespace Code_First_Relation.Entities
{
    //bir postu sadece bir kullanıcı atabileceği için burada sadece user entity tipinde tanımlıyorum 
    public class PostEntity:BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }

        //Relation Property

        public UserEntity User { get; set; }

    }
}
