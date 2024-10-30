namespace EasyRestoBlazor.Application.Contracts.Response
{
    public class PrivilegeResponse : IEquatable<PrivilegeResponse>
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public bool Equals(PrivilegeResponse? other)
        {
            if (other == null) return false;

            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as PrivilegeResponse);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
