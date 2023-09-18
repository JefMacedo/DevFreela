using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
	public class DevFreelaDbContext
	{
		public DevFreelaDbContext()
		{
			Projects = new List<Project>
            {
                new Project("Meu Projeto AspnetCore 1", "Minha descrição do projeto 1", 1, 1, 10000),
                new Project("Meu Projeto AspnetCore 2", "Minha descrição do projeto 2", 1, 1, 20000),
                new Project("Meu Projeto AspnetCore 3", "Minha descrição do projeto 3", 1, 1, 30000),
                new Project("Meu Projeto AspnetCore 4", "Minha descrição do projeto 4", 1, 1, 40000)
            };
			Users = new List<User>
            {
                new User("Jeferson Macedo","jeferson@mail.com",new DateTime(1997, 3, 8)),
                new User("Andre Pereira","andre@mail.com",new DateTime(1997, 6, 2)),
                new User("Marina Silva","marina@mail.com",new DateTime(1979, 5, 1)),
                new User("Julia Andrade","julia@mail.com",new DateTime(1999, 11, 12)),
            };
			Skills = new List<Skill>
            {
                new Skill("AspNet Core"),
                new Skill("C#"),
                new Skill("SQL"),
                new Skill("JavaScript")
            };
		}

		public List<Project> Projects { get; set; }
		public List<User> Users { get; set; }
		public List<Skill> Skills { get; set; }

	}
}
