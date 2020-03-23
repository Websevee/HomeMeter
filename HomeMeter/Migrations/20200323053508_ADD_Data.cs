using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace HomeMeter.Migrations
{
    public partial class ADD_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
insert into House (Zip, Country, City, Street, Number) values ('84', 'France', 'Cergy-Pontoise', 'Toban', 164);
insert into House (Zip, Country, City, Street, Number) values ('13', 'Russia', 'Zarechnyy', 'Hoard', 112);
insert into House (Zip, Country, City, Street, Number) values ('731', 'Indonesia', 'Kasingan', '2nd', 189);
insert into House (Zip, Country, City, Street, Number) values ('463', 'Ivory Coast', 'Affery', 'Thierer', 236);
insert into House (Zip, Country, City, Street, Number) values ('88', 'Czech Republic', 'Žihle', 'Kinsman', 74);
insert into House (Zip, Country, City, Street, Number) values ('02', 'China', 'Huatanshan', 'Springs', 56);
insert into House (Zip, Country, City, Street, Number) values ('133', 'Philippines', 'Gabao', 'Corscot', 46);
insert into House (Zip, Country, City, Street, Number) values ('494', 'Greece', 'Chalandrítsa', 'School', 12);
insert into House (Zip, Country, City, Street, Number) values ('12365', 'Finland', 'Piippola', 'Butternut', 137);
insert into House (Zip, Country, City, Street, Number) values ('965', 'Canada', 'Smiths Falls', 'Anzinger', 77);
insert into House (Zip, Country, City, Street, Number) values ('03', 'Nigeria', 'Modakeke', 'Huxley', 2);
insert into House (Zip, Country, City, Street, Number) values ('05', 'Philippines', 'Cassanayan', 'Lakeland', 88);
insert into House (Zip, Country, City, Street, Number) values ('9842', 'Costa Rica', 'Juntas', 'Oakridge', 181);
insert into House (Zip, Country, City, Street, Number) values ('8', 'Russia', 'Narimanov', 'Park Meadow', 231);
insert into House (Zip, Country, City, Street, Number) values ('15', 'Dominican Republic', 'Gaspar Hernández', 'Fisk', 190);
insert into House (Zip, Country, City, Street, Number) values ('134', 'Argentina', 'Cinco Saltos', 'High Crossing', 73);
insert into House (Zip, Country, City, Street, Number) values ('155', 'Nicaragua', 'Las Sabanas', 'Elka', 181);
insert into House (Zip, Country, City, Street, Number) values ('850', 'Sweden', 'Ronneby', 'Arkansas', 278);
insert into House (Zip, Country, City, Street, Number) values ('8913', 'China', 'Sandaogou', 'Hallows', 137);
insert into House (Zip, Country, City, Street, Number) values ('161', 'Indonesia', 'Kraton', 'Porter', 213);
insert into House (Zip, Country, City, Street, Number) values ('4740', 'Croatia', 'Belišće', 'Lindbergh', 158);
insert into House (Zip, Country, City, Street, Number) values ('1632', 'China', 'Lincheng', 'Killdeer', 205);
insert into House (Zip, Country, City, Street, Number) values ('652', 'China', 'Yujiawu', 'Tomscot', 191);
insert into House (Zip, Country, City, Street, Number) values ('746', 'China', 'Shajia’ao', 'Independence', 89);
insert into House (Zip, Country, City, Street, Number) values ('69', 'Tajikistan', 'Hisor', 'Nevada', 117);
insert into House (Zip, Country, City, Street, Number) values ('1688', 'Japan', 'Tennō', 'Onsgard', 213);
insert into House (Zip, Country, City, Street, Number) values ('3', 'Indonesia', 'Caringin', 'Grasskamp', 276);
insert into House (Zip, Country, City, Street, Number) values ('8301', 'China', 'Kongtian', 'Raven', 41);
insert into House (Zip, Country, City, Street, Number) values ('37490', 'Iran', 'Sarakhs', 'New Castle', 184);
insert into House (Zip, Country, City, Street, Number) values ('43025', 'Russia', 'Zarechnyy', 'Logan', 248);
insert into House (Zip, Country, City, Street, Number) values ('5', 'Portugal', 'Várzea', 'Cherokee', 109);
insert into House (Zip, Country, City, Street, Number) values ('3802', 'Honduras', 'La Libertad', 'Hanover', 265);
insert into House (Zip, Country, City, Street, Number) values ('112', 'Indonesia', 'Sangkalputung', 'Laurel', 73);
insert into House (Zip, Country, City, Street, Number) values ('4', 'Ecuador', 'Cuenca', 'La Follette', 155);
insert into House (Zip, Country, City, Street, Number) values ('0221', 'Czech Republic', 'Znojmo', 'Hermina', 87);
insert into House (Zip, Country, City, Street, Number) values ('76228', 'Portugal', 'Parada de Pinhão', 'Mccormick', 66);
insert into House (Zip, Country, City, Street, Number) values ('37771', 'China', 'Zhongshan Donglu', 'Grover', 99);
insert into House (Zip, Country, City, Street, Number) values ('3', 'Philippines', 'Samboan', 'Pepper Wood', 38);
insert into House (Zip, Country, City, Street, Number) values ('9', 'Iraq', 'Ḩalabjah', 'Orin', 268);
insert into House (Zip, Country, City, Street, Number) values ('4', 'Kuwait', 'Salwá', 'Vahlen', 148);
insert into House (Zip, Country, City, Street, Number) values ('3808', 'Poland', 'Drohiczyn', 'Blue Bill Park', 118);
insert into House (Zip, Country, City, Street, Number) values ('87', 'Portugal', 'Portela', 'Summer Ridge', 30);
insert into House (Zip, Country, City, Street, Number) values ('19195', 'United Kingdom', 'Whitchurch', 'Killdeer', 103);
insert into House (Zip, Country, City, Street, Number) values ('147', 'Greece', 'Áyios Yeóryios', 'Spaight', 136);
insert into House (Zip, Country, City, Street, Number) values ('2', 'China', 'Guoyuan', 'Loftsgordon', 279);
insert into House (Zip, Country, City, Street, Number) values ('30', 'China', 'Pingxiang', 'Meadow Valley', 179);
insert into House (Zip, Country, City, Street, Number) values ('102', 'Colombia', 'Maicao', 'Summit', 230);
insert into House (Zip, Country, City, Street, Number) values ('56855', 'China', 'Peishe', '5th', 80);
insert into House (Zip, Country, City, Street, Number) values ('83021', 'Honduras', 'Erandique', 'Upham', 213);
insert into House (Zip, Country, City, Street, Number) values ('50738', 'France', 'Toulouse', 'Bultman', 189);
insert into House (Zip, Country, City, Street, Number) values ('550', 'Philippines', 'Loreto', 'Steensland', 279);
insert into House (Zip, Country, City, Street, Number) values ('5802', 'China', 'E’erdun Wula', 'Fieldstone', 279);
insert into House (Zip, Country, City, Street, Number) values ('8', 'Canada', 'Willowdale', 'Tomscot', 269);
insert into House (Zip, Country, City, Street, Number) values ('75', 'Bangladesh', 'Narail', 'Homewood', 215);
insert into House (Zip, Country, City, Street, Number) values ('0', 'Finland', 'Tuusula', 'Clemons', 51);
insert into House (Zip, Country, City, Street, Number) values ('23083', 'Peru', 'Tournavista', 'Manitowish', 44);
insert into House (Zip, Country, City, Street, Number) values ('12039', 'Poland', 'Baranowo', 'Talisman', 137);
insert into House (Zip, Country, City, Street, Number) values ('86778', 'Azerbaijan', 'Ağdam', 'Warrior', 18);
insert into House (Zip, Country, City, Street, Number) values ('32', 'Nigeria', 'Shani', 'Kensington', 125);
insert into House (Zip, Country, City, Street, Number) values ('52319', 'Indonesia', 'Cipadung', 'Fordem', 133);
insert into House (Zip, Country, City, Street, Number) values ('46225', 'Peru', 'Pilcuyo', 'Spaight', 68);
insert into House (Zip, Country, City, Street, Number) values ('43940', 'Indonesia', 'Oekefan', 'Butternut', 262);
insert into House (Zip, Country, City, Street, Number) values ('5269', 'China', 'Obo', 'Autumn Leaf', 147);
insert into House (Zip, Country, City, Street, Number) values ('1', 'Peru', 'Lajas', 'Sunbrook', 19);
insert into House (Zip, Country, City, Street, Number) values ('803', 'Japan', 'Ōkuchi', 'Basil', 264);
insert into House (Zip, Country, City, Street, Number) values ('78', 'China', 'Shiye', 'Miller', 241);
insert into House (Zip, Country, City, Street, Number) values ('22451', 'China', 'Tiecun', 'Knutson', 281);
insert into House (Zip, Country, City, Street, Number) values ('81379', 'Thailand', 'Nakhon Nayok', 'Lerdahl', 260);
insert into House (Zip, Country, City, Street, Number) values ('271', 'Ireland', 'Castlebellingham', 'Iowa', 248);
insert into House (Zip, Country, City, Street, Number) values ('739', 'China', 'Guzhu', 'Bayside', 127);
insert into House (Zip, Country, City, Street, Number) values ('8', 'Venezuela', 'Ciudad Bolivia', 'Warbler', 207);
insert into House (Zip, Country, City, Street, Number) values ('10175', 'Macedonia', 'Kavadarci', 'Rowland', 79);
insert into House (Zip, Country, City, Street, Number) values ('56', 'Ukraine', 'Klishkivtsi', 'Dorton', 209);
insert into House (Zip, Country, City, Street, Number) values ('4', 'Spain', 'Valladolid', 'Milwaukee', 155);
insert into House (Zip, Country, City, Street, Number) values ('34030', 'China', 'Xiaojia', 'East', 229);
insert into House (Zip, Country, City, Street, Number) values ('29', 'Philippines', 'Balogo', 'Hudson', 71);
insert into House (Zip, Country, City, Street, Number) values ('7232', 'Czech Republic', 'Žeravice', 'Sheridan', 57);
insert into House (Zip, Country, City, Street, Number) values ('388', 'Indonesia', 'Pakemitan', 'Transport', 202);
insert into House (Zip, Country, City, Street, Number) values ('63582', 'Russia', 'Pushkino', 'Warner', 270);
insert into House (Zip, Country, City, Street, Number) values ('389', 'Nepal', 'Gaur', 'Golf Course', 41);
insert into House (Zip, Country, City, Street, Number) values ('0477', 'Brazil', 'Goiânia', 'Vera', 13);
insert into House (Zip, Country, City, Street, Number) values ('38', 'Mexico', 'El Limon', 'Ridge Oak', 275);
insert into House (Zip, Country, City, Street, Number) values ('136', 'Indonesia', 'Jawatiwa', 'Dovetail', 283);
insert into House (Zip, Country, City, Street, Number) values ('8', 'Indonesia', 'Babakanloa', 'Melvin', 154);
insert into House (Zip, Country, City, Street, Number) values ('0897', 'Japan', 'Ashibetsu', 'Kim', 27);
insert into House (Zip, Country, City, Street, Number) values ('55197', 'South Africa', 'Swellendam', 'Bay', 126);
insert into House (Zip, Country, City, Street, Number) values ('3', 'China', 'Xiangxiang', 'Blaine', 46);
insert into House (Zip, Country, City, Street, Number) values ('25', 'United States', 'Columbia', 'Leroy', 147);
insert into House (Zip, Country, City, Street, Number) values ('741', 'China', 'Dingdian', 'Mosinee', 175);
insert into House (Zip, Country, City, Street, Number) values ('6', 'Iran', 'Aleshtar', 'Starling', 229);
insert into House (Zip, Country, City, Street, Number) values ('7164', 'Russia', 'Shumikhinskiy', 'Hagan', 162);
insert into House (Zip, Country, City, Street, Number) values ('858', 'Sri Lanka', 'Monaragala', 'Del Sol', 145);
insert into House (Zip, Country, City, Street, Number) values ('32165', 'Philippines', 'Malabonot', 'Menomonie', 113);
insert into House (Zip, Country, City, Street, Number) values ('985', 'Brazil', 'Dourados', 'Stone Corner', 26);
insert into House (Zip, Country, City, Street, Number) values ('646', 'United States', 'Kansas City', 'Vernon', 207);
insert into House (Zip, Country, City, Street, Number) values ('17', 'China', 'Langjun', 'Hoepker', 9);
insert into House (Zip, Country, City, Street, Number) values ('0250', 'Madagascar', 'Amparafaravola', 'Twin Pines', 97);
insert into House (Zip, Country, City, Street, Number) values ('8159', 'Indonesia', 'Babakanbandung', 'Graedel', 166);
insert into House (Zip, Country, City, Street, Number) values ('447', 'Indonesia', 'Cikupa', 'Lerdahl', 121);
insert into House (Zip, Country, City, Street, Number) values ('1224', 'Greece', 'Stratónion', 'New Castle', 123);
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[Houses]");
        }
    }
}
