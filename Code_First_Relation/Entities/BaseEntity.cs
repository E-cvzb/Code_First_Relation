namespace Code_First_Relation.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool  IsDelete { get; set; }



    }
}
