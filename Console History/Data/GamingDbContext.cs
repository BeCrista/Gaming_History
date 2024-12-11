using Microsoft.EntityFrameworkCore;
using Console_History.Models;

namespace Console_History.Data
{
    public class GamingDbContext : DbContext
    {
        public GamingDbContext(DbContextOptions<GamingDbContext> options) : base(options) 
        {
            
        }

        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<SliderGames> SliderGames { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Consoles> Consoles { get; set; }
        public DbSet<PlatformConsoles> platformConsoles { get; set; }
        public DbSet<GameAwards> GameAwards { get; set; }
        public DbSet<GameAwardsSlider> GameAwardsSliders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlatformConsoles>().HasKey(key => new
            {
                key.PlatformID,
                key.ConsoleID
            });

            modelBuilder.Entity<PlatformConsoles>().HasOne(p => p.Platform).WithMany(pc => pc.platformConsoles).HasForeignKey(p => p.PlatformID);
            modelBuilder.Entity<PlatformConsoles>().HasOne(c => c.Console).WithMany(pc => pc.platformConsoles).HasForeignKey(c => c.ConsoleID);

            modelBuilder.Entity<HomePage>().HasData(new HomePage
            {
                ID = 1,
                Introduction = "Explore a fascinante jornada da evolução dos videogames, desde os consoles clássicos que marcaram gerações até as plataformas mais inovadoras da atualidade. Descubra os marcos que transformaram o entretenimento digital e como ele moldou a cultura global.",
                Description = "Nesta plataforma, você descobrirá as histórias fascinantes por trás dos consoles mais icônicos, como PlayStation, Nintendo e Xbox, mergulhando em suas contribuições para a evolução dos videogames. Além disso, exploraremos como essas máquinas transformaram o entretenimento e criaram comunidades globais de jogadores. Não perca também nossa seção dedicada ao The Game Awards, onde destacamos os maiores lançamentos e os indicados ao tão aguardado prêmio Game of the Year deste ano."
            });

            modelBuilder.Entity<SliderGames>().HasData(new SliderGames
            {
                ID = 1,
                NameGame = "Tony Hawk's Pro Skater 2",
                ImageGame = "https://upload.wikimedia.org/wikipedia/en/4/41/Tony_Hawk%27s_Pro_Skater_2_cover.png",
                GameConsole = "https://logospng.org/download/playstation-1/ps1-playstation-1-2048.png"
            },
            new SliderGames
            {
                ID = 2,
                NameGame = "Grand Theft Auto: San Andreas",
                ImageGame = "https://i.ebayimg.com/thumbs/images/g/6MgAAOSwQQhlCFJa/s-l1200.jpg",
                GameConsole = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/PlayStation_2_logo.svg/2560px-PlayStation_2_logo.svg.png"
            },
            new SliderGames
            {
                ID = 3,
                NameGame = "God of War III",
                ImageGame = "https://static.fnac-static.com/multimedia/PT/images_produits/PT/ZoomPE/0/6/6/0711719158660/tsp20100721205356/God-of-War-III-PS3.jpg",
                GameConsole = "https://upload.wikimedia.org/wikipedia/commons/0/05/PlayStation_3_logo_%282009%29.svg"
            },
            new SliderGames
            {
                ID = 4,
                NameGame = "Red Dead Redemption 2",
                ImageGame = "https://m.media-amazon.com/images/I/71XrxGqPosL._AC_UF1000,1000_QL80_.jpg",
                GameConsole = "https://logonoid.com/images/playstation-4-logo.png"
            },
            new SliderGames
            {
                ID = 5,
                NameGame = "Elden Ring",
                ImageGame = "https://m.media-amazon.com/images/I/81h2WhI4dtL._AC_UF1000,1000_QL80_.jpg",
                GameConsole = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSqXHzZgonqBRA6YUsD7bmWoiVuMK7DSF0S1A&s"
            },
            new SliderGames
            {
                ID = 6,
                NameGame = "Super Mario Bros.",
                ImageGame = "https://upload.wikimedia.org/wikipedia/pt/0/03/Super_Mario_Bros._box.png",
                GameConsole = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/NES_logo.svg/2560px-NES_logo.svg.png"
            },
            new SliderGames
            {
                ID = 7,
                NameGame = "Super Mario World",
                ImageGame = "https://upload.wikimedia.org/wikipedia/pt/0/06/Super-Mario-World.jpg",
                GameConsole = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/SNES_logo.svg/640px-SNES_logo.svg.png"
            },
            new SliderGames
            {
                ID = 8,
                NameGame = "The Legend of Zelda: Ocarina of Time",
                ImageGame = "https://upload.wikimedia.org/wikipedia/pt/1/17/The_Legend_of_Zelda_Ocarina_of_Time_capa.png",
                GameConsole = "https://1000logos.net/wp-content/uploads/2017/07/N64-Logo.png"
            },
            new SliderGames
            {
                ID = 9,
                NameGame = "Metroid Prime",
                ImageGame = "https://upload.wikimedia.org/wikipedia/en/thumb/b/ba/MetroidPrimebox.jpg/220px-MetroidPrimebox.jpg",
                GameConsole = "https://logos-world.net/wp-content/uploads/2022/01/GameCube-Logo.png"
            },
            new SliderGames
            {
                ID = 10,
                NameGame = "Super Mario Galaxy",
                ImageGame = "https://upload.wikimedia.org/wikipedia/pt/b/b1/Super_Mario_Galaxy_capa.png",
                GameConsole = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Wii_logo.png/1200px-Wii_logo.png"
            },
            new SliderGames
            {
                ID = 11,
                NameGame = "Super Smash Bros for Wii U",
                ImageGame = "https://static.wikia.nocookie.net/ssb/images/a/a2/Super_Smash_Bros_for_Wii_U_Box_Art.png/revision/latest/scale-to-width/360?cb=20181123153911",
                GameConsole = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxcj2HRq1RSK-bAtERaRme7Wl6r7bE8TAySQ&s"
            },
            new SliderGames
            {
                ID = 12,
                NameGame = "The Legend of Zelda: Breath of the Wild",
                ImageGame = "https://cdn.europosters.eu/image/1300/telas-the-legend-of-zelda-breath-of-the-wild-sunset-i111061.jpg",
                GameConsole = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/Nintendo_Switch_logo%2C_square.png/800px-Nintendo_Switch_logo%2C_square.png"
            },
            new SliderGames
            {
                ID = 13,
                NameGame = "Halo: Combat Evolved",
                ImageGame = "https://upload.wikimedia.org/wikipedia/pt/8/80/Halo_-_Combat_Evolved_%28XBox_version_-_box_art%29.jpg",
                GameConsole = "https://static.wikia.nocookie.net/xbox/images/8/85/Xbox_logo_2.png/revision/latest?cb=20180218021155"
            },
            new SliderGames
            {
                ID = 14,
                NameGame = "BioShock",
                ImageGame = "https://upload.wikimedia.org/wikipedia/pt/thumb/6/6d/BioShock_cover.jpg/256px-BioShock_cover.jpg",
                GameConsole = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/X_Box_360_logo.svg/1280px-X_Box_360_logo.svg.png"
            },
            new SliderGames
            {
                ID = 15,
                NameGame = "Resident Evil 2",
                ImageGame = "https://store-images.s-microsoft.com/image/apps.36567.71571739681700792.c61fa2d7-3d69-4edf-8e51-accc41d47823.a8c614fc-0dcb-4788-89ed-958635753296",
                GameConsole = "https://www.cdnlogo.com/logos/x/34/xbox-one.svg"
            },
            new SliderGames
            {
                ID = 16,
                NameGame = "Baldur's Gate 3",
                ImageGame = "https://upload.wikimedia.org/wikipedia/pt/1/18/Baldur%27s_Gate_III_Larian_Studios_key_art.png",
                GameConsole = "https://i.pinimg.com/originals/55/fd/2b/55fd2b30d350b481e3a2514c3f2ce00a.png"
            });

            modelBuilder.Entity<Platform>().HasData(new Platform
            {
                ID = 1,
                Name = "Playstation",
                Description = "A PlayStation nasceu em 1994, revolucionando a indústria dos jogos com sua poderosa tecnologia de CD-ROM e foco em experiências imersivas. Pioneira em introduzir gráficos tridimensionais de alta qualidade e títulos inovadores como Final Fantasy VII e Metal Gear Solid, a plataforma rapidamente se tornou um ícone cultural. Hoje, a PlayStation continua a moldar o futuro dos jogos com exclusividades de sucesso e tecnologias avançadas, como o PS VR e o PlayStation 5, consolidando sua influência no entretenimento global.",
                ImagePlatform = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/PlayStation_logo.svg/640px-PlayStation_logo.svg.png"
            },
            new Platform
            {
                ID = 2,
                Name = "Nintendo",
                Description = "A Nintendo, fundada em 1889 como fabricante de cartas de baralho, emergiu como líder na indústria de videogames com o lançamento do Nintendo Entertainment System (NES) em 1983. Inovadora e ousada, a empresa redefiniu o mercado com franquias lendárias como Super Mario Bros., The Legend of Zelda e Pokémon. A Nintendo é conhecida por priorizar a diversão e a acessibilidade, trazendo consoles revolucionários como o Wii e o híbrido Nintendo Switch, que continuam a conquistar jogadores de todas as idades.",
                ImagePlatform = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Nintendo.svg/2560px-Nintendo.svg.png"
            },
            new Platform
            {
                ID = 3,
                Name = "Xbox",
                Description = "Lançado em 2001, o Xbox foi a entrada da Microsoft no mundo dos consoles e rapidamente marcou presença com títulos como Halo: Combat Evolved. Apostando em conectividade online, o Xbox Live transformou o cenário de multiplayer e criou uma nova era para os jogos sociais. Com iniciativas como o Game Pass e poderosos consoles como o Xbox Series X, a marca Xbox permanece na vanguarda da inovação, promovendo acessibilidade e diversidade no mundo dos jogos.",
                ImagePlatform = "https://upload.wikimedia.org/wikipedia/commons/d/d7/Xbox_logo_%282019%29.svg"
            });

            modelBuilder.Entity<Consoles>().HasData(new Consoles
            {
                ID = 1,
                NameConsole = "Playstation 1",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/9/95/PSX-Console-wController.png",
                DescriptionConsole = "Lançado em 1994, o PlayStation original foi o pioneiro da Sony no mercado de videogames e um marco na transição para gráficos 3D. Com seu leitor de CD-ROM, oferecia armazenamento superior, permitindo experiências mais longas e cinematográficas. Foi o lar de franquias icônicas como Final Fantasy, Resident Evil e Gran Turismo. A compatibilidade com memory cards também foi inovadora, permitindo salvar progresso de jogos de forma prática. O controlo com vibração e o Dual Analog Controller foram inovações que impactaram o design de controles futuros."
            },
            new Consoles
            {
                ID = 2,
                NameConsole = "Playstation 2",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/PS2-Versions.png/800px-PS2-Versions.png",
                DescriptionConsole = "O PlayStation 2 continua a ser o console mais vendido da história, com mais de 155 milhões de unidades comercializadas. Ele trouxe retrocompatibilidade com jogos do PS1, suporte a DVDs, e gráficos superiores para sua época. A sua biblioteca extensa, incluindo sucessos como Grand Theft Auto: San Andreas, Shadow of the Colossus, God of War e Kingdom Hearts, definiram uma geração. Além disso, sua capacidade de reproduzir mídias digitais fez dele uma das primeiras consolas a ser considerado um centro de entretenimento completo."
            },
            new Consoles
            {
                ID = 3,
                NameConsole = "Playstation 3",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/d/d3/Sony-PlayStation-3-2001A-wController-L.jpg",
                DescriptionConsole = "Lançado em 2006, o PlayStation 3 inovou ao adotar discos Blu-ray, oferecendo gráficos de alta definição e espaço para jogos mais detalhados. Com suporte a multiplayer online via PSN (Playstation Network) e funções multimídia, o PS3 foi um passo à frente em conectividade. Jogos exclusivos como The Last of Us, Uncharted e God of War III estabeleceram novos padrões para narrativas em videogames. A funcionalidade de armazenamento interno e a opção de retrocompatibilidade em alguns modelos iniciais tornaram o PS3 uma consola versátil. Ele também introduziu o controlo sem fio DualShock 3 com sensores de movimento."
            },
            new Consoles
            {
                ID = 4,
                NameConsole = "Playstation 4",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/7/71/Sony-PlayStation-4-PS4-wDualShock-4.jpg",
                DescriptionConsole = "Com foco em potência e simplicidade, o PlayStation 4 consolidou sua liderança na geração com mais de 116 milhões de unidades vendidas. Ele trouxe uma arquitetura amigável aos desenvolvedores e possibilitou experiências imersivas com jogos como Horizon Zero Dawn, Spider-Man e God of War. Recursos como o Share Play, transmissões ao vivo e integração social redefiniram a forma como os jogadores interagem. A consola também suportava VR com o PlayStation VR, levando a imersão a um novo nível."
            },
            new Consoles
            {
                ID = 5,
                NameConsole = "Playstation 5",
                ImageConsole = "https://www.icase.pt/1731-large_default/consola-sony-playstation-5-slim-1tb-standard-branca.jpg",
                DescriptionConsole = "O PlayStation 5 é a mais recente iteração da linha, projetado para jogos de próxima geração. Com um SSD ultrarrápido, ele reduz drasticamente os tempos de carregamento e permite mundos mais detalhados. O DualSense, seu controle revolucionário, apresenta feedback tátil e gatilhos adaptáveis que aumentam a imersão. Exclusividades como Demon’s Souls Remake e Ratchet & Clank: Rift Apart aproveitam ao máximo o hardware avançado, enquanto o suporte a 4K, ray tracing e 120fps estabelece um novo padrão para o futuro dos jogos."
            },
            new Consoles
            {
                ID = 6,
                NameConsole = "Nintendo Entertainment System (NES)",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b2/NES-Console-Set.png/1200px-NES-Console-Set.png",
                DescriptionConsole = "Lançado em 1983 no Japão como Famicom e em 1985 internacionalmente como NES, esta consola foi crucial para revitalizar a indústria dos videogames após a crise de 1983. Com gráficos 8-bit e controles simples, ele introduziu clássicos como Super Mario Bros., The Legend of Zelda e Metroid. Sua biblioteca diversificada e seu sistema de cartuchos revolucionaram a forma como os jogos eram jogados e comercializados."
            },
            new Consoles
            {
                ID = 7,
                NameConsole = "Super Nintendo Entertainment System (SNES)",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/SNES-Mod1-Console-Set.jpg/1200px-SNES-Mod1-Console-Set.jpg",
                DescriptionConsole = "Chegando ao mercado em 1990, o Super Nintendo trouxe gráficos 16-bit e som aprimorado, estabelecendo um novo padrão para jogos da consola. Títulos como Super Mario World, Chrono Trigger, Donkey Kong Country e The Legend of Zelda: A Link to the Past consolidaram a reputação da Nintendo como líder em inovação. Além disso, o uso do Mode 7 permitiu efeitos visuais de rotação e escalonamento, aprimorando a experiência visual."
            },
            new Consoles
            {
                ID = 8,
                NameConsole = "Nintendo 64 (N64)",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/0/02/N64-Console-Set.png",
                DescriptionConsole = "Lançado em 1996, o Nintendo 64 trouxe gráficos 3D de alta qualidade e foi a primeiro consola a apresentar um joystick analógico em seu controlo, essencial para movimentos precisos em ambientes tridimensionais. Jogos como Super Mario 64, The Legend of Zelda: Ocarina of Time e GoldenEye 007 definiram uma geração. Sua entrada para até quatro controles popularizou o multiplayer local."
            },
            new Consoles
            {
                ID = 9,
                NameConsole = "Nintendo GameCube",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/2/2b/GameCube-Console-Set.png",
                DescriptionConsole = "Chegando ao mercado em 2001, o GameCube marcou a transição para discos ópticos, adotando mini-DVDs para reduzir a pirataria. Apesar de não ter tantas funcionalidades multimídia quanto os concorrentes, a consola destacou-se com jogos visualmente impressionantes como Metroid Prime, Super Smash Bros. Melee e The Legend of Zelda: The Wind Waker. O controlo ergonômico e os acessórios como o adaptador Game Boy Player o tornaram único."
            },
            new Consoles
            {
                ID = 10,
                NameConsole = "Nintendo Wii",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Wii-Console.png/1200px-Wii-Console.png",
                DescriptionConsole = "Lançado em 2006, o Nintendo Wii revolucionou a forma de jogar com seus controlos sensíveis ao movimento, promovendo experiências interativas e acessíveis para toda a família. Jogos como Wii Sports, Mario Kart Wii e The Legend of Zelda: Twilight Princess tornaram-se sucessos mundiais. A consola também introduziu o Virtual Console, permitindo acesso a jogos clássicos das gerações anteriores."
            },
            new Consoles
            {
                ID = 11,
                NameConsole = "Nintendo Wii U",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Wii_U_Console_and_Gamepad.png/640px-Wii_U_Console_and_Gamepad.png",
                DescriptionConsole = "Introduzido em 2012, o Wii U foi o primeiro console da Nintendo a oferecer gráficos em HD e introduziu o GamePad, um controlo com tela sensível ao toque. Apesar de não atingir grandes vendas, ele foi pioneiro em experiências híbridas, que mais tarde influenciaram o Nintendo Switch. Jogos como Super Mario 3D World, Splatoon e Mario Kart 8 foram destaques, enquanto a consola começou a transição da Nintendo para o suporte digital e online."
            },
            new Consoles
            {
                ID = 12,
                NameConsole = "Nintendo Switch",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Nintendo-Switch-Console-Docked-wJoyConRB.jpg/1920px-Nintendo-Switch-Console-Docked-wJoyConRB.jpg",
                DescriptionConsole = "Lançado em 2017, o Nintendo Switch é uma consola híbrido que pode ser usado tanto como portátil quanto conectado à TV. Ele redefiniu a flexibilidade no mundo dos jogos, com controles Joy-Con destacáveis e uma biblioteca robusta de jogos como The Legend of Zelda: Breath of the Wild, Super Smash Bros. Ultimate e Animal Crossing: New Horizons. O Switch é um marco em inovação e acessibilidade para jogadores de todos os tipos."
            },
            new Consoles
            {
                ID = 13,
                NameConsole = "Xbox",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/c/c2/Xbox-Console-Set.png",
                DescriptionConsole = "Lançado em 2001, o Xbox foi a primeira incursão da Microsoft no mercado de consolas. Com um hardware poderoso para sua época e um disco rígido interno, ele eliminou a necessidade de memory cards. Seu maior legado foi o Xbox Live, introduzido em 2002, que revolucionou o multiplayer online. Títulos como Halo: Combat Evolved e Fable estabeleceram a marca Xbox como uma força significativa na indústria dos games."
            },
            new Consoles
            {
                ID = 14,
                NameConsole = "Xbox 360",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Microsoft-Xbox-360-E-wController.jpg/220px-Microsoft-Xbox-360-E-wController.jpg",
                DescriptionConsole = "Chegando ao mercado em 2005, o Xbox 360 foi um divisor de águas na era HD dos videogames. Ele trouxe gráficos impressionantes, conectividade robusta com o Xbox Live e uma biblioteca de jogos variados, como Gears of War, Mass Effect e Forza Motorsport. A consola também introduziu o Kinect, um sensor de movimento inovador. Apesar de problemas com o Red Ring of Death, o Xbox 360 solidificou a presença da Microsoft como líder em inovação."
            },
            new Consoles
            {
                ID = 15,
                NameConsole = "Xbox One",
                ImageConsole = "https://upload.wikimedia.org/wikipedia/commons/0/05/Microsoft-Xbox-One-Console-Set-wKinect.jpg",
                DescriptionConsole = "Lançado em 2013, o Xbox One foi concebido como um centro de entretenimento completo, combinando jogos, TV e streaming em um único dispositivo. Apesar de um início difícil devido a questões de marketing, a consola se recuperou com títulos como Halo 5: Guardians, Gears 5 e Sea of Thieves. O Xbox Game Pass, um serviço de assinatura de jogos, redefiniu o consumo de conteúdo na indústria. O suporte a retrocompatibilidade também se tornou um diferencial significativo."
            },
            new Consoles
            {
                ID = 16,
                NameConsole = "Xbox Series S",
                ImageConsole = "https://thumb.pccomponentes.com/w-530-530/articles/1076/10762131/1133-xbox-series-s-1tb-negro-carbon.jpg",
                DescriptionConsole = "Lançado em conjunto com o Series X, o Xbox Series S é uma alternativa mais acessível e compacta para jogos da nova geração. Embora menos poderoso que o Series X, ele oferece desempenho sólido, com suporte para 1440p e até 120 FPS. Projetado para jogadores digitais, o Series S é ideal para quem busca uma experiência de nova geração a um custo mais baixo, mantendo acesso ao ecossistema do Game Pass e retrocompatibilidade."
            },
            new Consoles
            {
                ID = 17,
                NameConsole = "Xbox Series X",
                ImageConsole = "https://cms-assets.xboxservices.com/assets/f0/8d/f08dfa50-f2ef-4873-bc8f-bcb6c34e48c0.png?n=642227_Hero-Gallery-0_C2_857x676.png",
                DescriptionConsole = "Lançado em 2020, o Xbox Series X é a consola mais poderoso da Microsoft até o momento. Com suporte a 4K nativo, ray tracing e um SSD ultra-rápido, ele oferece tempos de carregamento mínimos e gráficos impressionantes. Títulos como Halo Infinite e Forza Horizon 5 demonstram seu potencial. A consola também continua a oferecer integração com o Game Pass e retrocompatibilidade com jogos de gerações anteriores, criando uma experiência de jogo abrangente."
            });

            modelBuilder.Entity<PlatformConsoles>().HasData(new PlatformConsoles
            {
                PlatformID = 1,
                ConsoleID = 1
            },
            new PlatformConsoles
            {
                PlatformID = 1,
                ConsoleID = 2
            },
            new PlatformConsoles
            {
                PlatformID = 1,
                ConsoleID = 3
            },
            new PlatformConsoles
            {
                PlatformID = 1,
                ConsoleID = 4
            },
            new PlatformConsoles
            {
                PlatformID = 1,
                ConsoleID = 5
            },
            new PlatformConsoles
            {
                PlatformID = 2,
                ConsoleID = 6
            },
            new PlatformConsoles
            {
                PlatformID = 2,
                ConsoleID = 7
            },
            new PlatformConsoles
            {
                PlatformID = 2,
                ConsoleID = 8
            },
            new PlatformConsoles
            {
                PlatformID = 2,
                ConsoleID = 9
            },
            new PlatformConsoles
            {
                PlatformID = 2,
                ConsoleID = 10
            },
            new PlatformConsoles
            {
                PlatformID = 2,
                ConsoleID = 11
            },
            new PlatformConsoles
            {
                PlatformID = 2,
                ConsoleID = 12
            },
            new PlatformConsoles
            {
                PlatformID = 3,
                ConsoleID = 13
            },
            new PlatformConsoles
            {
                PlatformID = 3,
                ConsoleID = 14
            },
            new PlatformConsoles
            {
                PlatformID = 3,
                ConsoleID = 15
            },
            new PlatformConsoles
            {
                PlatformID = 3,
                ConsoleID = 16
            },
            new PlatformConsoles
            {
                PlatformID = 3,
                ConsoleID = 17
            });

            modelBuilder.Entity<GameAwards>().HasData(new GameAwards
            {
                ID = 1,
                Description = "O The Game Awards é um evento anual criado em 2014 por Geoff Keighley, um renomado jornalista e apresentador da indústria de videogames. Este espetáculo celebra os maiores sucessos do mundo dos jogos, reconhecendo a excelência em categorias que vão desde narrativa e design artístico até inovação em acessibilidade. Além de premiar os destaques do ano, o The Game Awards também serve como palco para anúncios de novos jogos e atualizações aguardadas. Com milhões de espectadores em todo o mundo, o evento tornou-se uma referência cultural que destaca o impacto dos videogames como forma de arte e meio de entretenimento, unindo jogadores, criadores e fãs em uma celebração global."
            });

            modelBuilder.Entity<GameAwardsSlider>().HasData(new GameAwardsSlider
            {
                ID = 1,
                NameGOTY = "Astro Bot",
                PublisherGOTY = "Team Asobi/SIE",
                ImageGOTY = "https://image.api.playstation.com/vulcan/ap/rnd/202406/0500/8f15268257b878597757fcc5f2c9545840867bc71fc863b1.png",
                DescriptionGOTY = "O novo título da série Astro Bot se destaca pela sua jogabilidade inovadora e acessibilidade. Este jogo mistura elementos de plataforma com experiências imersivas em realidade virtual, encantando jogadores com visuais detalhados e música envolvente. Ele é elogiado por elevar o padrão de design artístico e direção."
            },
            new GameAwardsSlider
            {
                ID = 2,
                NameGOTY = "Balatro",
                PublisherGOTY = "LocalThunk/Playstack",
                ImageGOTY = "https://upload.wikimedia.org/wikipedia/pt/a/a9/Balatro_capa_digital_Windows.png",
                DescriptionGOTY = "Este indie surpreendeu com sua abordagem inovadora e foco na inclusão. O jogo combina uma narrativa envolvente com uma estética única, oferecendo uma experiência acessível e impactante. Balatro demonstra a força dos desenvolvedores independentes em criar algo extraordinário mesmo competindo com grandes produções."
            },
            new GameAwardsSlider
            {
                ID = 3,
                NameGOTY = "Black Myth: Wukong",
                PublisherGOTY = "Game Science",
                ImageGOTY = "https://image.api.playstation.com/vulcan/ap/rnd/202405/2117/bd406f42e9352fdb398efcf21a4ffe575b2306ac40089d21.png",
                DescriptionGOTY = "Baseado na lenda chinesa do Rei Macaco, este jogo impressiona com seu combate dinâmico e arte deslumbrante. Cenários vibrantes e personagens meticulosamente detalhados fazem de Black Myth: Wukong uma experiência visual e jogável marcante."
            },
            new GameAwardsSlider
            {
                ID = 4,
                NameGOTY = "Elden Ring Shadow Of The Erdtree",
                PublisherGOTY = "FromSoftware/Bandai Namco",
                ImageGOTY = "https://image.api.playstation.com/vulcan/ap/rnd/202402/0713/d956c0df3a0cfe7c1b8e81c684ecff8a9a141c4f1f38578c.png",
                DescriptionGOTY = "A expansão de Elden Ring continua a narrativa épica do jogo original, com gráficos impressionantes e um mundo imersivo. Sua jogabilidade profunda e rica história consolidam sua posição entre os melhores jogos do ano."
            },
            new GameAwardsSlider
            {
                ID = 5,
                NameGOTY = "Final Fantasy VII Rebirth",
                PublisherGOTY = "Square Enix",
                ImageGOTY = "https://m.media-amazon.com/images/M/MV5BOGNjNTFhNmQtZGMyMS00ODgzLTg5YjAtYWQxMWUwMjNkMDVkXkEyXkFqcGc@._V1_.jpg",
                DescriptionGOTY = "Esta sequência direta do aclamado remake continua a saga de Cloud e seus amigos, oferecendo um enredo profundo, trilha sonora magistral e mecânicas de combate refinadas. O jogo é amplamente elogiado por fãs e críticos pela sua fidelidade ao material original enquanto inova em design."
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
