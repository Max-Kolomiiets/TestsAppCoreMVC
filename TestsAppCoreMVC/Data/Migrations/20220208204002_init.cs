using Microsoft.EntityFrameworkCore.Migrations;

namespace TestsAppCoreMVC.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Voluptas nisi fugiat modi explicabo aliquam laboriosam ut corrupti sint laudantium pariatur magnam magni officiis.", "aliquid" },
                    { 2, "Hic nam provident placeat magnam nihil minima magni non occaecati reprehenderit minima numquam doloribus voluptas nostrum recusandae et qui delectus ad molestiae.", "voluptatem" },
                    { 3, "Nihil voluptas rerum id earum eos nobis voluptatibus voluptatem vero quaerat maiores voluptatem ut dolorem.", "ipsum" },
                    { 4, "Odit quo soluta nesciunt dolores tempora qui modi placeat sed molestiae quis et perspiciatis qui quia.", "quo" },
                    { 5, "Et repellendus rerum rem autem ex minima sint sit provident voluptas porro tempore distinctio dolores ab.", "iure" },
                    { 6, "Ea tempore optio qui sed architecto vero repudiandae placeat sed perferendis itaque aperiam possimus sit.", "officia" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Name", "TestId" },
                values: new object[,]
                {
                    { 1, "Adipisci at ut omnis rerum alias dolor.", 1 },
                    { 34, "Officiis nostrum et necessitatibus ut impedit soluta.", 3 },
                    { 35, "Autem cupiditate sapiente delectus culpa.", 4 },
                    { 36, "Dolorum et corrupti quisquam facere.", 4 },
                    { 37, "Blanditiis cupiditate magnam accusamus ullam sunt optio.", 4 },
                    { 38, "Dolorem voluptatum vero et perspiciatis sapiente sunt.", 4 },
                    { 39, "Molestiae nulla repellat est impedit fugit.", 4 },
                    { 40, "Sunt qui illo voluptatem nam qui accusamus.", 4 },
                    { 41, "Inventore quam soluta molestiae ut et ea.", 4 },
                    { 42, "Dolores ut illo voluptatem facilis perferendis.", 4 },
                    { 43, "Maxime non quos eligendi sed in.", 5 },
                    { 44, "Quidem quibusdam sit in dolore id.", 5 },
                    { 45, "Ex ipsum recusandae ipsum voluptatum.", 5 },
                    { 46, "Officia aut perferendis deleniti nam et.", 5 },
                    { 47, "Corrupti optio rerum eius dolor hic.", 5 },
                    { 48, "Et est excepturi eum qui autem dicta.", 5 },
                    { 49, "Non qui id quis neque quia.", 5 },
                    { 50, "Ratione veniam officiis tempora qui repellendus.", 5 },
                    { 51, "Quidem porro inventore ut in non.", 6 },
                    { 52, "Praesentium doloribus pariatur itaque corporis.", 6 },
                    { 53, "Consequatur quia officia excepturi in tempore iste.", 6 },
                    { 54, "Fuga et voluptas illo labore et aut.", 6 },
                    { 55, "Nihil ea minus natus quia sit.", 6 },
                    { 56, "Assumenda illo id assumenda ullam.", 6 },
                    { 57, "Et atque ab voluptas sit quaerat corporis.", 6 },
                    { 58, "Numquam dolorum ipsam ipsum eius eos.", 6 },
                    { 59, "Nobis eos ut amet itaque hic tenetur.", 6 },
                    { 60, "Eum nihil excepturi dolores neque.", 6 },
                    { 33, "Deleniti distinctio assumenda itaque ducimus ad non.", 3 },
                    { 32, "Iure deserunt qui porro qui.", 3 },
                    { 31, "Quod aut pariatur quos harum ut.", 3 },
                    { 30, "Aut quia sit vitae unde.", 3 },
                    { 2, "Alias velit quia occaecati iure ullam.", 1 },
                    { 3, "Aperiam esse reiciendis temporibus sapiente.", 1 },
                    { 4, "Voluptates consectetur dolorum nemo dolores consequatur ut.", 1 },
                    { 5, "Aut adipisci consequatur qui quo id qui.", 1 },
                    { 6, "Voluptatem similique officia ut non.", 1 },
                    { 7, "Et a quia inventore est adipisci.", 1 },
                    { 8, "Provident ut culpa eveniet voluptate assumenda.", 1 },
                    { 9, "Earum autem animi soluta voluptate fugiat.", 1 },
                    { 10, "Officiis consequatur neque perspiciatis fugit velit consectetur.", 1 },
                    { 11, "Ipsum dicta autem corporis cumque voluptatem est.", 1 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Name", "TestId" },
                values: new object[,]
                {
                    { 12, "Quia a voluptate itaque dolores.", 1 },
                    { 13, "Perspiciatis quos autem error impedit porro.", 2 },
                    { 14, "Ut itaque placeat et sed modi.", 2 },
                    { 61, "Ad eveniet illo est rem.", 6 },
                    { 15, "Omnis voluptatibus explicabo suscipit quae iure pariatur.", 2 },
                    { 17, "Accusantium alias corporis enim ex.", 2 },
                    { 18, "Aut reprehenderit perspiciatis minima libero et.", 2 },
                    { 19, "Pariatur voluptatem soluta et assumenda.", 2 },
                    { 20, "Aut impedit voluptatem quia dignissimos veniam.", 2 },
                    { 21, "Autem doloremque harum delectus et.", 2 },
                    { 22, "Ut labore vero soluta aut.", 2 },
                    { 23, "Reprehenderit labore facere ipsa expedita voluptas quasi.", 3 },
                    { 24, "Aut corrupti sit voluptatem accusantium.", 3 },
                    { 25, "Consectetur qui maxime quia officiis autem.", 3 },
                    { 26, "Vel tempora modi non incidunt voluptatum.", 3 },
                    { 27, "Aut et eos velit totam molestias voluptatem.", 3 },
                    { 28, "Iste quo magnam mollitia dolor aut.", 3 },
                    { 29, "Ratione placeat soluta consequatur voluptas necessitatibus ullam.", 3 },
                    { 16, "Eos quia aut molestiae exercitationem.", 2 },
                    { 62, "Hic amet aliquid qui ad.", 6 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 1, true, "Autem cumque temporibus aut sint.", 1 },
                    { 218, true, "Et quo tempore ab quia.", 42 },
                    { 217, true, "Omnis quis aut sed.", 42 },
                    { 216, true, "Aut minus non perspiciatis aut ex consequatur corporis voluptatem quia.", 42 },
                    { 215, true, "Occaecati porro ea dolorem.", 42 },
                    { 214, false, "Non assumenda dolorem omnis aliquam.", 42 },
                    { 213, true, "Nulla alias voluptate amet minus occaecati.", 41 },
                    { 212, true, "Quaerat necessitatibus ad.", 41 },
                    { 219, false, "Commodi nostrum nostrum.", 43 },
                    { 211, true, "Dolore nihil minima quia dignissimos alias illum.", 41 },
                    { 209, false, "Nesciunt ea voluptatibus numquam doloribus veritatis fuga corrupti.", 41 },
                    { 208, true, "Dolores rem velit saepe ut hic aut.", 40 },
                    { 207, true, "Cumque esse saepe dolore quos aut ut.", 40 },
                    { 206, false, "Ipsum quo reprehenderit aut aperiam vitae vitae.", 40 },
                    { 205, false, "Eos consequatur iste consequatur aut alias.", 40 },
                    { 204, true, "Architecto quod adipisci amet aut.", 40 },
                    { 203, true, "Non enim eius voluptatem nam voluptate omnis quis.", 40 },
                    { 210, false, "Velit consequatur impedit non voluptates.", 41 },
                    { 202, false, "Aut enim nesciunt molestias eveniet totam occaecati quibusdam.", 39 },
                    { 220, false, "Omnis sequi quo corrupti culpa esse unde.", 43 },
                    { 222, true, "Eos non nihil vero facilis quia qui.", 43 },
                    { 238, true, "Inventore voluptatem ut ea.", 46 },
                    { 237, true, "Aut culpa soluta labore et qui.", 46 },
                    { 236, false, "Et quibusdam praesentium qui eaque.", 46 },
                    { 235, false, "Ratione numquam reprehenderit voluptatum asperiores.", 46 },
                    { 234, false, "Velit dolores nostrum alias quia et voluptas distinctio qui assumenda.", 46 },
                    { 233, false, "Nam ipsum beatae nobis molestiae cumque.", 45 },
                    { 232, true, "Rem quis adipisci.", 45 },
                    { 221, false, "Tenetur dolore a voluptatum ad laudantium soluta qui.", 43 },
                    { 231, true, "Quis sapiente est laudantium optio quisquam neque quidem.", 45 },
                    { 229, false, "Doloremque voluptatem facilis vero omnis nihil doloremque quis quis.", 44 },
                    { 228, false, "Accusamus illo assumenda ad iste.", 44 },
                    { 227, false, "Delectus accusantium doloribus modi minus nobis minima qui iusto.", 44 },
                    { 226, false, "Minus delectus sit vel iste adipisci.", 44 },
                    { 225, false, "Saepe dicta illo ullam adipisci ipsam repellat non.", 44 },
                    { 224, false, "Quasi voluptatem modi.", 44 },
                    { 223, false, "Autem asperiores maiores tempora in et vitae error quo quia.", 43 },
                    { 230, false, "Cum libero ex consequatur voluptatem quibusdam debitis qui.", 45 },
                    { 239, true, "Ea quam incidunt distinctio dolorem nemo consequatur quis.", 46 },
                    { 201, true, "Ad optio vel tenetur et aliquam.", 39 },
                    { 199, true, "Ducimus quam temporibus consequatur quisquam sit.", 39 },
                    { 178, true, "Quia accusamus aspernatur modi voluptas delectus delectus autem distinctio rerum.", 33 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 177, false, "Voluptatem consectetur debitis est eveniet quas laborum deserunt laborum cupiditate.", 33 },
                    { 176, true, "Aperiam unde minima mollitia.", 33 },
                    { 175, true, "Hic doloremque nisi ullam esse sunt quisquam veniam in voluptatem.", 33 },
                    { 174, true, "A aut quo vel culpa.", 33 },
                    { 173, true, "Nemo sunt architecto non beatae veniam ducimus ipsam ut magni.", 33 },
                    { 172, false, "Nesciunt ipsum numquam voluptate maxime.", 32 },
                    { 179, false, "Accusamus iste voluptatibus aut tempora magni quo est qui.", 34 },
                    { 171, true, "Ut a quisquam sint et voluptatem ad et dolores voluptatem.", 32 },
                    { 169, true, "Ut temporibus aut fugiat vel dignissimos voluptatem.", 32 },
                    { 168, false, "Autem ad dolorum facilis.", 32 },
                    { 167, true, "Quaerat porro ea quo et inventore dolores praesentium expedita.", 32 },
                    { 166, true, "Deleniti saepe unde iure delectus.", 31 },
                    { 165, false, "Voluptas sint qui dicta minus voluptatibus incidunt id aut occaecati.", 31 },
                    { 164, true, "Possimus et ipsam nihil doloribus sed sunt minus dolor.", 31 },
                    { 163, false, "Id debitis tempora.", 31 },
                    { 170, true, "Placeat ipsa eum dignissimos.", 32 },
                    { 200, true, "Rem dolorum et voluptatem iste quaerat.", 39 },
                    { 180, true, "Quas facilis eveniet ea.", 34 },
                    { 182, false, "Quisquam et ut voluptas dolores eos aliquam enim sed aut.", 34 },
                    { 198, true, "Et sequi voluptatem quasi.", 38 },
                    { 197, false, "Fugit incidunt voluptates sunt sit sed ratione voluptas harum eum.", 38 },
                    { 196, true, "Beatae error eos vitae voluptate eum possimus mollitia at vitae.", 38 },
                    { 195, true, "Ut qui at impedit fugiat necessitatibus quibusdam officia.", 38 },
                    { 194, false, "Alias dolor voluptatem totam est et veniam omnis.", 37 },
                    { 193, false, "Consequatur qui hic eum deserunt tenetur nulla vero.", 37 },
                    { 192, false, "Repudiandae quia aut repellendus dolor libero sit.", 37 },
                    { 181, false, "Repellendus enim harum magnam veniam eum quo debitis at.", 34 },
                    { 191, true, "Tempore et doloremque velit repellat eos ratione.", 37 },
                    { 189, true, "Qui dicta neque.", 36 },
                    { 188, false, "Ipsam corporis doloribus officiis vitae necessitatibus dolorem repudiandae ut.", 36 },
                    { 187, false, "Quo cum eveniet ratione in eos totam totam.", 36 },
                    { 186, true, "Tempore eos ut aut neque enim dolorem.", 35 },
                    { 185, false, "Eum fuga non expedita aut nihil reiciendis totam.", 35 },
                    { 184, false, "Rem quas ratione ducimus.", 35 },
                    { 183, false, "Aut molestias rerum explicabo accusantium.", 35 },
                    { 190, false, "Amet vitae officiis.", 36 },
                    { 240, true, "Non officiis qui sit reiciendis.", 47 },
                    { 241, false, "Eos sint perferendis nesciunt labore.", 47 },
                    { 242, true, "Necessitatibus et modi vel tempora deleniti officiis deleniti.", 47 },
                    { 299, false, "Odio ea sint atque sit error mollitia eius assumenda laborum.", 58 },
                    { 298, true, "Ratione officiis sequi voluptas atque sed adipisci ut voluptas.", 58 },
                    { 297, true, "Harum ipsam qui.", 58 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 296, false, "Autem repudiandae totam porro esse ea ipsam et amet excepturi.", 58 },
                    { 295, true, "Dolores labore sit sapiente magnam repellat rerum sequi cumque voluptas.", 57 },
                    { 294, false, "Aperiam ipsam molestiae rem qui facere sunt id dolorum ipsum.", 57 },
                    { 293, false, "Quia voluptatem ea.", 57 },
                    { 300, false, "Vel laboriosam quasi voluptatem repellat sit necessitatibus impedit ad ducimus.", 59 },
                    { 292, true, "Eveniet magnam omnis magnam cupiditate ut ratione quis eos id.", 57 },
                    { 290, true, "Hic id ea consequatur consequuntur eveniet necessitatibus repudiandae hic commodi.", 56 },
                    { 289, false, "Neque ut quasi aut ut quasi aut rem.", 56 },
                    { 288, true, "Ab exercitationem omnis at.", 56 },
                    { 287, false, "Illo distinctio voluptatem ea quod alias enim vel voluptatum sint.", 56 },
                    { 286, false, "Magnam molestias ex rerum similique tempore eveniet expedita aut.", 56 },
                    { 285, false, "Dolorum quidem sit qui aut accusamus rerum.", 55 },
                    { 284, false, "Sit maxime quia iure eum.", 55 },
                    { 291, false, "Illum et doloremque.", 57 },
                    { 283, false, "Quia dolorem nobis ut.", 55 },
                    { 301, true, "Aliquid inventore dolor asperiores.", 59 },
                    { 303, false, "Animi doloremque totam fuga.", 59 },
                    { 319, true, "Nostrum velit sint et sed voluptatum quae.", 62 },
                    { 318, false, "Quia quia adipisci eligendi aut ipsa.", 62 },
                    { 317, true, "Est architecto sed et nisi deleniti non sunt illo.", 62 },
                    { 316, false, "Quibusdam consequatur corporis eligendi et eos sunt sunt.", 61 },
                    { 315, true, "Saepe vero quia.", 61 },
                    { 314, true, "Dolor sunt quia similique vero est dolor omnis sit ex.", 61 },
                    { 313, false, "Eveniet in perferendis ab accusamus quis soluta eligendi fuga.", 61 },
                    { 302, false, "Quasi porro molestias.", 59 },
                    { 312, true, "Vel sed dolorem iure pariatur.", 61 },
                    { 310, true, "Magni ut voluptas qui minus.", 60 },
                    { 309, false, "Unde adipisci inventore nobis perferendis repellat ut ab.", 60 },
                    { 308, true, "Autem eligendi voluptatem magni eligendi quibusdam minima.", 60 },
                    { 307, false, "Consequuntur totam ut.", 60 },
                    { 306, true, "Suscipit vitae amet adipisci occaecati accusamus rerum sit.", 60 },
                    { 305, true, "Fuga veritatis ducimus.", 59 },
                    { 304, true, "Aliquam voluptatem rerum.", 59 },
                    { 311, true, "Ipsum est ut itaque reiciendis doloribus quos dolorem voluptas qui.", 60 },
                    { 282, true, "Similique quas qui iusto fugit sed quod eius sint.", 55 },
                    { 281, false, "Autem et nisi repudiandae officia laboriosam eum voluptate.", 55 },
                    { 280, false, "Error fuga et deserunt minus rerum vel asperiores qui enim.", 55 },
                    { 258, false, "Id et quidem temporibus sed recusandae minima.", 50 },
                    { 257, true, "Et non animi sed.", 50 },
                    { 256, true, "Non at voluptatem.", 50 },
                    { 255, false, "Et maxime vel ipsam at.", 50 },
                    { 254, false, "Et recusandae voluptatibus praesentium repellat.", 50 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 253, false, "Quos odio ex distinctio magni sint.", 49 },
                    { 252, true, "Molestiae distinctio veritatis enim vero aut suscipit expedita.", 49 },
                    { 259, true, "Blanditiis qui impedit perspiciatis ducimus.", 51 },
                    { 251, false, "Et error quaerat libero sunt totam qui est.", 49 },
                    { 249, false, "Est ut quam velit fugiat consequuntur.", 48 },
                    { 248, true, "Saepe asperiores ut eos.", 48 },
                    { 247, false, "Consequatur itaque non sunt nulla explicabo est occaecati.", 48 },
                    { 246, false, "Laudantium laudantium harum repellendus et ab beatae molestiae deleniti.", 48 },
                    { 245, true, "Non aliquam delectus vero consequatur.", 47 },
                    { 244, true, "Voluptatem quia et eius odio sit reprehenderit accusantium.", 47 },
                    { 243, true, "Sunt eos placeat aut molestias dolores hic odit.", 47 },
                    { 250, false, "Consequuntur in doloribus et excepturi nihil.", 49 },
                    { 260, false, "Magni aspernatur quia sit error quidem laborum omnis aliquid est.", 51 },
                    { 261, false, "Qui et laudantium aut est labore nostrum rerum quia.", 51 },
                    { 262, true, "Alias maxime quo consectetur vitae nisi ratione consequatur.", 51 },
                    { 279, true, "Ipsam fugit aut eum.", 54 },
                    { 278, false, "Consequuntur sunt aut doloremque qui nemo ratione sit aut.", 54 },
                    { 277, true, "Pariatur illum eveniet.", 54 },
                    { 276, false, "Est inventore et dignissimos ex sed tenetur voluptates libero.", 54 },
                    { 275, false, "Qui praesentium ad totam molestias in blanditiis consequatur.", 54 },
                    { 274, true, "Est nobis occaecati eos rem exercitationem.", 54 },
                    { 273, true, "Quaerat harum saepe sed animi minima doloribus est molestiae.", 53 },
                    { 272, true, "Ipsum minus quia sunt voluptatem et voluptatem.", 53 },
                    { 271, false, "Laboriosam repudiandae magni repellendus earum.", 53 },
                    { 270, false, "Cum dolor sit qui omnis ipsum porro odio porro.", 53 },
                    { 269, false, "Et voluptatem consequuntur qui dolor rem praesentium animi consequatur laudantium.", 53 },
                    { 268, true, "Dolorem reprehenderit nam iste qui sunt quos quia et.", 52 },
                    { 267, true, "Recusandae voluptas nostrum et.", 52 },
                    { 266, false, "Non quia voluptatem atque nobis et doloribus.", 52 },
                    { 265, true, "Quisquam animi aliquid sed odio qui.", 52 },
                    { 264, true, "Alias accusantium neque impedit culpa laborum.", 51 },
                    { 263, false, "Dicta consequatur itaque harum.", 51 },
                    { 162, false, "Impedit eveniet non aut quo similique odio et adipisci dolorum.", 31 },
                    { 320, false, "Sunt libero est neque.", 62 },
                    { 161, true, "Totam quia voluptatibus.", 31 },
                    { 159, true, "Qui rerum itaque.", 30 },
                    { 57, false, "Tenetur aut et et aspernatur.", 11 },
                    { 56, false, "Exercitationem ullam laborum adipisci nesciunt.", 11 },
                    { 55, false, "Consequatur veritatis et earum et sunt sapiente esse saepe voluptas.", 11 },
                    { 54, true, "Quia ut commodi ducimus commodi.", 11 },
                    { 53, false, "Reiciendis dolor aut.", 10 },
                    { 52, false, "Magni ea quia.", 10 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 51, true, "Quia similique quia est magnam sit.", 10 },
                    { 58, true, "Facere sunt neque voluptas a a.", 11 },
                    { 50, true, "Temporibus ullam dolorem cupiditate molestiae.", 10 },
                    { 48, true, "Voluptatum ut in et placeat omnis nesciunt odit vel.", 10 },
                    { 47, true, "Sunt ad totam at.", 9 },
                    { 46, false, "Fugit voluptate corporis iste consequatur.", 9 },
                    { 45, true, "Asperiores laborum velit natus provident ut.", 9 },
                    { 44, false, "Fugiat animi voluptatem ipsa laborum nihil quas labore.", 9 },
                    { 43, false, "Dolorem similique nam voluptates placeat ut ut sapiente.", 9 },
                    { 42, true, "Autem quo aliquid incidunt culpa dolores voluptatibus molestias fugit.", 9 },
                    { 49, true, "Dolorem pariatur minima.", 10 },
                    { 41, true, "Dolore dolorum omnis tenetur est reprehenderit consequatur libero officiis animi.", 8 },
                    { 59, true, "Laborum fugit voluptatum est.", 11 },
                    { 61, true, "Velit non inventore quos suscipit officiis.", 12 },
                    { 77, true, "Eaque quia et quis voluptas dolor blanditiis esse magni.", 15 },
                    { 76, true, "Dolore dolorem quaerat autem architecto ut nisi vel sed.", 14 },
                    { 75, true, "Eos veniam aliquam eaque magnam.", 14 },
                    { 74, true, "Rerum cupiditate quam consectetur aspernatur in eligendi.", 14 },
                    { 73, true, "Voluptas iste repellendus quia.", 14 },
                    { 72, true, "Et iste esse veniam reiciendis.", 14 },
                    { 71, false, "Et quis praesentium enim delectus assumenda.", 14 },
                    { 60, false, "Sapiente quo nihil sed vero odit atque.", 12 },
                    { 70, true, "Magni doloremque voluptas voluptas assumenda eveniet quibusdam.", 13 },
                    { 68, false, "Porro nihil numquam cum occaecati maxime harum eius asperiores aliquam.", 13 },
                    { 67, false, "Amet facilis voluptatem sed repudiandae sed.", 13 },
                    { 66, true, "Doloribus atque excepturi dolorem totam quibusdam consequatur et.", 13 },
                    { 65, false, "Provident culpa assumenda assumenda aperiam molestiae culpa ut numquam.", 13 },
                    { 64, true, "Animi molestias debitis temporibus vel blanditiis error aspernatur at aut.", 12 },
                    { 63, true, "Porro iusto error quia eum illo.", 12 },
                    { 62, false, "Consequatur similique at ratione.", 12 },
                    { 69, true, "Voluptatum placeat deleniti.", 13 },
                    { 78, true, "Amet inventore ut enim et repudiandae rerum molestias aut sit.", 15 },
                    { 40, true, "Nihil enim facilis aut voluptas eius voluptas eum nemo.", 8 },
                    { 38, true, "Amet aut et at qui et ut sit voluptates in.", 8 },
                    { 17, false, "Consectetur quia ipsam.", 4 },
                    { 16, true, "Aspernatur est est cupiditate qui nesciunt aut corporis autem.", 4 },
                    { 15, true, "Modi error molestiae.", 4 },
                    { 14, false, "Voluptatem alias ducimus dolorem quisquam ea.", 3 },
                    { 13, false, "Quis nihil eius et.", 3 },
                    { 12, true, "Ipsam sit veritatis iusto.", 3 },
                    { 11, false, "Voluptatem eaque accusantium et odio neque.", 3 },
                    { 18, true, "Ut eaque est nulla.", 4 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 10, false, "Rem aut perferendis iusto non.", 3 },
                    { 8, false, "Inventore ut impedit voluptatum.", 2 },
                    { 7, false, "Molestiae et nobis rerum voluptas esse.", 2 },
                    { 6, true, "Autem vel aut excepturi magnam velit atque.", 2 },
                    { 5, false, "Illo assumenda id laudantium rerum.", 1 },
                    { 4, false, "Beatae at vel cupiditate.", 1 },
                    { 3, true, "Deserunt ullam sequi itaque consequatur dicta.", 1 },
                    { 2, true, "Qui maxime sunt omnis et ea rem id.", 1 },
                    { 9, false, "Aspernatur nostrum consequatur.", 2 },
                    { 39, true, "Animi sequi consequatur ut quos sunt beatae odio quas.", 8 },
                    { 19, false, "Impedit possimus ullam eos.", 4 },
                    { 21, false, "Rerum quibusdam doloremque vel.", 5 },
                    { 37, true, "Nesciunt alias dolor quia at.", 7 },
                    { 36, false, "Quod ut architecto dignissimos vel et est quia aut.", 7 },
                    { 35, false, "Quas aliquam molestiae ad nihil consectetur esse.", 7 },
                    { 34, true, "Odit ullam quia.", 7 },
                    { 33, false, "Iste sit minima nesciunt magni est consequatur unde eius esse.", 7 },
                    { 32, true, "Quo vel dignissimos.", 7 },
                    { 31, false, "Vitae sed ipsam magni et.", 6 },
                    { 20, false, "Harum repellat soluta reprehenderit veritatis iusto.", 4 },
                    { 30, true, "Minima adipisci debitis facere.", 6 },
                    { 28, false, "Laborum totam voluptas labore distinctio ea.", 6 },
                    { 27, false, "Sint deleniti illum accusantium et officia omnis.", 6 },
                    { 26, false, "Aut placeat perferendis magni.", 6 },
                    { 25, false, "Natus ex nisi placeat sit.", 5 },
                    { 24, false, "Non consequatur est.", 5 },
                    { 23, true, "Quibusdam excepturi porro consequuntur est esse autem aspernatur.", 5 },
                    { 22, false, "Non qui voluptatum provident aut earum delectus modi quaerat vel.", 5 },
                    { 29, false, "Harum est voluptates tempore ea ratione sed accusamus corrupti itaque.", 6 },
                    { 79, true, "Expedita corrupti sint corrupti dolore et ut et consectetur eligendi.", 15 },
                    { 80, false, "Consequuntur corporis necessitatibus hic exercitationem excepturi molestiae magnam ipsum.", 15 },
                    { 81, false, "Porro perferendis repellendus quisquam dolores maxime laboriosam culpa.", 15 },
                    { 138, false, "Alias dolorum dolorem repellendus distinctio quis nihil aliquam.", 26 },
                    { 137, false, "Ut ad sit dicta laborum autem.", 26 },
                    { 136, true, "Porro cum nam.", 26 },
                    { 135, true, "Sit atque eos ipsa nihil consequatur nihil labore.", 26 },
                    { 134, true, "Non sint animi facilis nostrum facere rerum.", 25 },
                    { 133, true, "Eos voluptas aut ut.", 25 },
                    { 132, true, "Mollitia necessitatibus excepturi ut.", 25 },
                    { 139, false, "Quasi libero incidunt culpa maxime non.", 27 },
                    { 131, false, "Voluptate repellendus fugit id numquam iusto quibusdam esse rerum.", 25 },
                    { 129, false, "Ipsa harum ipsam nisi beatae eum aut vel ut aut.", 25 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 128, false, "Qui unde eum exercitationem et et optio dolore et et.", 24 },
                    { 127, false, "Dicta voluptate fugiat ut id illum libero architecto.", 24 },
                    { 126, true, "Modi dolor ullam eos inventore enim.", 24 },
                    { 125, true, "Recusandae aliquid quidem fuga officia qui ut occaecati eveniet.", 24 },
                    { 124, true, "Ut non quae.", 24 },
                    { 123, false, "Maxime quisquam explicabo in eos.", 24 },
                    { 130, true, "Delectus deserunt facere qui similique non sed et.", 25 },
                    { 122, false, "Doloremque quae beatae debitis praesentium aperiam.", 23 },
                    { 140, false, "Aliquam quae reprehenderit iste officiis excepturi qui vero nihil animi.", 27 },
                    { 142, false, "Error quam id ratione aut cum itaque porro eum iusto.", 27 },
                    { 158, false, "Perspiciatis earum tempora velit optio et accusamus iure.", 30 },
                    { 157, true, "Illum qui distinctio dolore error beatae ut.", 30 },
                    { 156, false, "Labore consequatur culpa tempora tenetur.", 30 },
                    { 155, true, "Est veritatis quia veritatis odio odio accusamus velit.", 30 },
                    { 154, true, "Aut nesciunt omnis.", 29 },
                    { 153, false, "Vel itaque et.", 29 },
                    { 152, true, "Unde deserunt dolor aliquid iste aut autem magni.", 29 },
                    { 141, false, "Hic excepturi eum.", 27 },
                    { 151, false, "Natus velit nam similique earum dolorum dolor reprehenderit vero illo.", 29 },
                    { 149, false, "Numquam aliquam distinctio reprehenderit labore.", 29 },
                    { 148, true, "Eos non debitis nesciunt occaecati.", 28 },
                    { 147, false, "Error consequatur omnis.", 28 },
                    { 146, true, "Voluptas eos ut veritatis dolorum harum pariatur.", 28 },
                    { 145, true, "Ducimus quis blanditiis quo corrupti architecto dolorem dicta.", 28 },
                    { 144, false, "Ipsa laboriosam quae voluptates error.", 27 },
                    { 143, true, "Eaque beatae quaerat ut velit qui non nisi eos.", 27 },
                    { 150, true, "Dolores eius et placeat nulla quae officia et nobis id.", 29 },
                    { 121, true, "Quis praesentium repudiandae dolore.", 23 },
                    { 120, true, "Illum aspernatur voluptates earum possimus ut voluptatem aut.", 23 },
                    { 119, true, "Inventore quidem aspernatur sed quo earum a unde earum beatae.", 23 },
                    { 97, false, "Repudiandae soluta magni officiis saepe.", 19 },
                    { 96, true, "Laudantium porro iusto officiis accusantium sapiente perferendis debitis.", 19 },
                    { 95, true, "Minus omnis ratione.", 18 },
                    { 94, false, "Quo provident optio iste ipsam praesentium voluptatum voluptates nobis.", 18 },
                    { 93, true, "Quia eum consequatur repudiandae provident ipsum consequuntur quis aperiam animi.", 18 },
                    { 92, false, "A praesentium dolor sint nam sunt ducimus sequi aut eos.", 18 },
                    { 91, true, "Error delectus eos nulla est aliquid ea velit dicta.", 18 },
                    { 98, true, "Eum rerum quis consequatur nisi ad.", 19 },
                    { 90, false, "Quasi quisquam repellat adipisci ut nam ipsa saepe ullam dolor.", 18 },
                    { 88, true, "Provident temporibus ipsa eveniet vel velit blanditiis adipisci.", 17 },
                    { 87, false, "Quia illo fugit est.", 17 },
                    { 86, true, "Tempora et aut animi velit odit illo consequuntur sed.", 17 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 85, true, "Animi possimus doloribus.", 16 },
                    { 84, false, "Vel voluptatem assumenda velit rem laudantium vitae aut quia.", 16 },
                    { 83, true, "Eligendi numquam laudantium.", 16 },
                    { 82, true, "Saepe neque placeat dolores quibusdam non sit.", 16 },
                    { 89, false, "Libero numquam nesciunt.", 17 },
                    { 99, true, "Autem aut occaecati aut et et.", 19 },
                    { 100, false, "Nulla incidunt quo debitis qui ducimus rerum tempore non.", 19 },
                    { 101, true, "Nulla totam dolore dignissimos a sit.", 19 },
                    { 118, true, "Sunt minima explicabo eum ea aut praesentium est rerum.", 22 },
                    { 117, false, "Facilis et modi quam omnis sapiente deserunt.", 22 },
                    { 116, true, "Ut quis nostrum quam placeat iste modi voluptatum qui.", 22 },
                    { 115, true, "Sequi velit nisi sapiente.", 22 },
                    { 114, true, "Dolore sit et fugit aut debitis maxime.", 22 },
                    { 113, true, "Excepturi aperiam qui optio exercitationem aut ut minima.", 22 },
                    { 112, false, "Non repellat labore accusantium praesentium accusantium nihil.", 21 },
                    { 111, false, "Id labore odit enim quae facilis et repellendus.", 21 },
                    { 110, false, "Quis nihil laudantium minima veniam culpa.", 21 },
                    { 109, true, "Aliquid id optio possimus sed nam commodi quod quisquam.", 21 },
                    { 108, true, "Id reiciendis in est autem itaque.", 21 },
                    { 107, false, "Nihil animi earum sunt.", 21 },
                    { 106, true, "Numquam temporibus quia.", 20 },
                    { 105, false, "Eos non aut reprehenderit.", 20 },
                    { 104, false, "Voluptas nemo repudiandae perspiciatis ea natus eum distinctio.", 20 },
                    { 103, true, "Quo veniam facilis illo sapiente fugiat recusandae earum et.", 20 },
                    { 102, true, "Sequi dolores et odio.", 20 },
                    { 160, false, "Dolores aut quo.", 30 },
                    { 321, true, "Dolorem aut quis reprehenderit.", 62 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TestId",
                table: "Questions",
                column: "TestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Tests");
        }
    }
}
