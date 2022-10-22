using Customer.Domain.Cadastro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Customer.Repository.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Empresa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Endereco).IsRequired();

            builder.OwnsOne(x => x.Cpf,
                ba =>
                {
                    ba.Property(a => a.Number);
                }).Navigation(x => x.Cpf);

            builder.OwnsOne(x => x.Endereco,
                ba =>
                {
                    ba.Property(a => a.NomeEndereco);

                    ba.Property(a => a.Cidade);

                    ba.Property(a => a.Estado);
                }).Navigation(x => x.Endereco);
        }
    }
}
