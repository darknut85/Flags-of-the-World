using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Flags_of_the_World
{
    public partial class Form1 : Form
    {
        Settings settings = new Settings();

        public Form1()
        {
            InitializeComponent();
        }

        #region unused buttons
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // no longer working if the tries has reached the max
            if (settings.tries < 10)
            {
                int d = settings.random;
                int t = settings.tries;
                int score = settings.score;
                if (e.KeyCode == Keys.Enter)
                {
                    #region countrytext
                    if (d == 0 && textBox1.Text == "afghanistan") { label1.Text = "correct"; }
                    else if (d == 1 && textBox1.Text == "albania") { label1.Text = "correct"; }
                    else if (d == 2 && textBox1.Text == "algeria") { label1.Text = "correct"; }
                    else if (d == 3 && textBox1.Text == "andorra") { label1.Text = "correct"; }
                    else if (d == 4 && textBox1.Text == "angola") { label1.Text = "correct"; }
                    else if (d == 5 && (textBox1.Text == "antiqua and barbuda" || textBox1.Text == "barbuda and antiqua")) { label1.Text = "correct"; }
                    else if (d == 6 && textBox1.Text == "argentina") { label1.Text = "correct"; }
                    else if (d == 7 && textBox1.Text == "armenia") { label1.Text = "correct"; }
                    else if (d == 8 && textBox1.Text == "australia") { label1.Text = "correct"; }
                    else if (d == 9 && textBox1.Text == "austria") { label1.Text = "correct"; }
                    else if (d == 10 && textBox1.Text == "azerbaijin") { label1.Text = "correct"; }
                    else if (d == 11 && textBox1.Text == "bahamas") { label1.Text = "correct"; }
                    else if (d == 12 && textBox1.Text == "bahrain") { label1.Text = "correct"; }
                    else if (d == 13 && textBox1.Text == "bangladesh") { label1.Text = "correct"; }
                    else if (d == 14 && textBox1.Text == "bardaros") { label1.Text = "correct"; }
                    else if (d == 15 && textBox1.Text == "belarus") { label1.Text = "correct"; }
                    else if (d == 16 && textBox1.Text == "belgium") { label1.Text = "correct"; }
                    else if (d == 17 && textBox1.Text == "belize") { label1.Text = "correct"; }
                    else if (d == 18 && textBox1.Text == "benin") { label1.Text = "correct"; }
                    else if (d == 19 && textBox1.Text == "bhutan") { label1.Text = "correct"; }
                    else if (d == 20 && textBox1.Text == "bolivia") { label1.Text = "correct"; }
                    else if (d == 21 && (textBox1.Text == "bosnia and herzegovina" || textBox1.Text == "herzegovina and bosnia")) { label1.Text = "correct"; }
                    else if (d == 22 && textBox1.Text == "botswana") { label1.Text = "correct"; }
                    else if (d == 23 && textBox1.Text == "brazil") { label1.Text = "correct"; }
                    else if (d == 24 && textBox1.Text == "brunei") { label1.Text = "correct"; }
                    else if (d == 25 && textBox1.Text == "bulgaria") { label1.Text = "correct"; }
                    else if (d == 26 && textBox1.Text == "burkina faso") { label1.Text = "correct"; }
                    else if (d == 27 && textBox1.Text == "burundi") { label1.Text = "correct"; }
                    else if (d == 28 && textBox1.Text == "cabo verde") { label1.Text = "correct"; }
                    else if (d == 29 && textBox1.Text == "cambodia") { label1.Text = "correct"; }
                    else if (d == 30 && textBox1.Text == "cameroon") { label1.Text = "correct"; }
                    else if (d == 31 && textBox1.Text == "canada") { label1.Text = "correct"; }
                    else if (d == 32 && textBox1.Text == "car" || textBox1.Text == "central african republic") { label1.Text = "correct"; }
                    else if (d == 33 && textBox1.Text == "chad") { label1.Text = "correct"; }
                    else if (d == 34 && textBox1.Text == "chile") { label1.Text = "correct"; }
                    else if (d == 35 && textBox1.Text == "china") { label1.Text = "correct"; }
                    else if (d == 36 && textBox1.Text == "colombia") { label1.Text = "correct"; }
                    else if (d == 37 && textBox1.Text == "comoros") { label1.Text = "correct"; }
                    else if (d == 38 && textBox1.Text == "congo") { label1.Text = "correct"; }
                    else if (d == 39 && textBox1.Text == "costa rica") { label1.Text = "correct"; }
                    else if (d == 40 && textBox1.Text == "côte d'ivoire" || textBox1.Text == "cote d'ivoire") { label1.Text = "correct"; }
                    else if (d == 41 && textBox1.Text == "croatia") { label1.Text = "correct"; }
                    else if (d == 42 && textBox1.Text == "cuba") { label1.Text = "correct"; }
                    else if (d == 43 && textBox1.Text == "cyprus") { label1.Text = "correct"; }
                    else if (d == 44 && textBox1.Text == "czechia") { label1.Text = "correct"; }
                    else if (d == 45 && textBox1.Text == "denmark") { label1.Text = "correct"; }
                    else if (d == 46 && textBox1.Text == "djibouti") { label1.Text = "correct"; }
                    else if (d == 47 && textBox1.Text == "dominica") { label1.Text = "correct"; }
                    else if (d == 48 && textBox1.Text == "dominican republic") { label1.Text = "correct"; }
                    else if (d == 49 && (textBox1.Text == "dprk" || textBox1.Text == "north korea" || textBox1.Text == "democratic people's republic of korea")) { label1.Text = "correct"; }
                    else if (d == 50 && (textBox1.Text == "drc" || textBox1.Text == "congo" || textBox1.Text == "democratic republic of congo")) { label1.Text = "correct"; }
                    else if (d == 51 && textBox1.Text == "ecuador") { label1.Text = "correct"; }
                    else if (d == 52 && textBox1.Text == "egypt") { label1.Text = "correct"; }
                    else if (d == 53 && textBox1.Text == "el salvador") { label1.Text = "correct"; }
                    else if (d == 54 && textBox1.Text == "equatorial guinea") { label1.Text = "correct"; }
                    else if (d == 55 && textBox1.Text == "eritrea") { label1.Text = "correct"; }
                    else if (d == 56 && textBox1.Text == "estonia") { label1.Text = "correct"; }
                    else if (d == 57 && textBox1.Text == "eswatini") { label1.Text = "correct"; }
                    else if (d == 58 && textBox1.Text == "ethiopia") { label1.Text = "correct"; }
                    else if (d == 59 && textBox1.Text == "fiji") { label1.Text = "correct"; }
                    else if (d == 60 && textBox1.Text == "finland") { label1.Text = "correct"; }
                    else if (d == 61 && textBox1.Text == "france") { label1.Text = "correct"; }
                    else if (d == 62 && textBox1.Text == "gabon") { label1.Text = "correct"; }
                    else if (d == 63 && textBox1.Text == "gambia") { label1.Text = "correct"; }
                    else if (d == 64 && textBox1.Text == "georgia") { label1.Text = "correct"; }
                    else if (d == 65 && textBox1.Text == "germany") { label1.Text = "correct"; }
                    else if (d == 66 && textBox1.Text == "ghana") { label1.Text = "correct"; }
                    else if (d == 67 && textBox1.Text == "greece") { label1.Text = "correct"; }
                    else if (d == 68 && textBox1.Text == "grenada") { label1.Text = "correct"; }
                    else if (d == 69 && textBox1.Text == "guatemala") { label1.Text = "correct"; }
                    else if (d == 70 && textBox1.Text == "guinea") { label1.Text = "correct"; }
                    else if (d == 71 && (textBox1.Text == "guinea-bissau" || textBox1.Text == "guinea bissau")) { label1.Text = "correct"; }
                    else if (d == 72 && textBox1.Text == "guyana") { label1.Text = "correct"; }
                    else if (d == 73 && textBox1.Text == "haiti") { label1.Text = "correct"; }
                    else if (d == 74 && textBox1.Text == "holy see") { label1.Text = "correct"; }
                    else if (d == 75 && textBox1.Text == "honduras") { label1.Text = "correct"; }
                    else if (d == 76 && textBox1.Text == "hungary") { label1.Text = "correct"; }
                    else if (d == 77 && textBox1.Text == "iceland") { label1.Text = "correct"; }
                    else if (d == 78 && textBox1.Text == "india") { label1.Text = "correct"; }
                    else if (d == 79 && textBox1.Text == "indonesia") { label1.Text = "correct"; }
                    else if (d == 80 && textBox1.Text == "iran") { label1.Text = "correct"; }
                    else if (d == 81 && textBox1.Text == "iraq") { label1.Text = "correct"; }
                    else if (d == 82 && textBox1.Text == "ireland") { label1.Text = "correct"; }
                    else if (d == 83 && textBox1.Text == "israel") { label1.Text = "correct"; }
                    else if (d == 84 && textBox1.Text == "italy") { label1.Text = "correct"; }
                    else if (d == 85 && textBox1.Text == "jamaica") { label1.Text = "correct"; }
                    else if (d == 86 && textBox1.Text == "japan") { label1.Text = "correct"; }
                    else if (d == 87 && textBox1.Text == "jordan") { label1.Text = "correct"; }
                    else if (d == 88 && textBox1.Text == "kazakhstan") { label1.Text = "correct"; }
                    else if (d == 89 && textBox1.Text == "kenya") { label1.Text = "correct"; }
                    else if (d == 90 && textBox1.Text == "kiribati") { label1.Text = "correct"; }
                    else if (d == 91 && textBox1.Text == "kuwait") { label1.Text = "correct"; }
                    else if (d == 92 && textBox1.Text == "kyrgyzstan") { label1.Text = "correct"; }
                    else if (d == 93 && textBox1.Text == "laos") { label1.Text = "correct"; }
                    else if (d == 94 && textBox1.Text == "latvia") { label1.Text = "correct"; }
                    else if (d == 95 && textBox1.Text == "lebanon") { label1.Text = "correct"; }
                    else if (d == 96 && textBox1.Text == "lesotho") { label1.Text = "correct"; }
                    else if (d == 97 && textBox1.Text == "liberia") { label1.Text = "correct"; }
                    else if (d == 98 && textBox1.Text == "libya") { label1.Text = "correct"; }
                    else if (d == 99 && textBox1.Text == "liechtenstein") { label1.Text = "correct"; }
                    else if (d == 100 && textBox1.Text == "lithuania") { label1.Text = "correct"; }
                    else if (d == 101 && textBox1.Text == "luxembourg") { label1.Text = "correct"; }
                    else if (d == 102 && textBox1.Text == "madagascar") { label1.Text = "correct"; }
                    else if (d == 103 && textBox1.Text == "malawi") { label1.Text = "correct"; }
                    else if (d == 104 && textBox1.Text == "malaysia") { label1.Text = "correct"; }
                    else if (d == 105 && textBox1.Text == "maldives") { label1.Text = "correct"; }
                    else if (d == 106 && textBox1.Text == "mali") { label1.Text = "correct"; }
                    else if (d == 107 && textBox1.Text == "malta") { label1.Text = "correct"; }
                    else if (d == 108 && textBox1.Text == "marshall islands") { label1.Text = "correct"; }
                    else if (d == 109 && textBox1.Text == "mauritania") { label1.Text = "correct"; }
                    else if (d == 110 && textBox1.Text == "mauritius") { label1.Text = "correct"; }
                    else if (d == 111 && textBox1.Text == "mexico") { label1.Text = "correct"; }
                    else if (d == 112 && textBox1.Text == "micronesia") { label1.Text = "correct"; }
                    else if (d == 113 && textBox1.Text == "moldova") { label1.Text = "correct"; }
                    else if (d == 114 && textBox1.Text == "monaco") { label1.Text = "correct"; }
                    else if (d == 115 && textBox1.Text == "mongolia") { label1.Text = "correct"; }
                    else if (d == 116 && textBox1.Text == "montenegro") { label1.Text = "correct"; }
                    else if (d == 117 && textBox1.Text == "morocco") { label1.Text = "correct"; }
                    else if (d == 118 && textBox1.Text == "mozambique") { label1.Text = "correct"; }
                    else if (d == 119 && textBox1.Text == "myanmar") { label1.Text = "correct"; }
                    else if (d == 120 && textBox1.Text == "namibia") { label1.Text = "correct"; }
                    else if (d == 121 && textBox1.Text == "nauru") { label1.Text = "correct"; }
                    else if (d == 122 && textBox1.Text == "nepal") { label1.Text = "correct"; }
                    else if (d == 123 && textBox1.Text == "netherlands") { label1.Text = "correct"; }
                    else if (d == 124 && textBox1.Text == "new zealand") { label1.Text = "correct"; }
                    else if (d == 125 && textBox1.Text == "nicaraqua") { label1.Text = "correct"; }
                    else if (d == 126 && textBox1.Text == "niger") { label1.Text = "correct"; }
                    else if (d == 127 && textBox1.Text == "nigeria") { label1.Text = "correct"; }
                    else if (d == 128 && textBox1.Text == "north macedonia") { label1.Text = "correct"; }
                    else if (d == 129 && textBox1.Text == "norway") { label1.Text = "correct"; }
                    else if (d == 130 && textBox1.Text == "oman") { label1.Text = "correct"; }
                    else if (d == 131 && textBox1.Text == "pakistan") { label1.Text = "correct"; }
                    else if (d == 132 && textBox1.Text == "palau") { label1.Text = "correct"; }
                    else if (d == 133 && textBox1.Text == "panama") { label1.Text = "correct"; }
                    else if (d == 134 && textBox1.Text == "papua new guinea") { label1.Text = "correct"; }
                    else if (d == 135 && textBox1.Text == "paraguay") { label1.Text = "correct"; }
                    else if (d == 136 && textBox1.Text == "peru") { label1.Text = "correct"; }
                    else if (d == 137 && textBox1.Text == "philippines") { label1.Text = "correct"; }
                    else if (d == 138 && textBox1.Text == "poland") { label1.Text = "correct"; }
                    else if (d == 139 && textBox1.Text == "portugal") { label1.Text = "correct"; }
                    else if (d == 140 && textBox1.Text == "qatar") { label1.Text = "correct"; }
                    else if (d == 141 && textBox1.Text == "romania") { label1.Text = "correct"; }
                    else if (d == 142 && textBox1.Text == "russia") { label1.Text = "correct"; }
                    else if (d == 143 && textBox1.Text == "rwanda") { label1.Text = "correct"; }
                    else if (d == 144 && (textBox1.Text == "saint kitts and nevis" || textBox1.Text == "nevis and saint kitts")) { label1.Text = "correct"; }
                    else if (d == 145 && textBox1.Text == "saint lucia") { label1.Text = "correct"; }
                    else if (d == 146 && textBox1.Text == "samoa") { label1.Text = "correct"; }
                    else if (d == 147 && textBox1.Text == "san marino") { label1.Text = "correct"; }
                    else if (d == 148 && (textBox1.Text == "sao tome and principe" || textBox1.Text == "principe and sao tome")) { label1.Text = "correct"; }
                    else if (d == 149 && textBox1.Text == "saudi arabia") { label1.Text = "correct"; }
                    else if (d == 150 && textBox1.Text == "senegal") { label1.Text = "correct"; }
                    else if (d == 151 && textBox1.Text == "serbia") { label1.Text = "correct"; }
                    else if (d == 152 && textBox1.Text == "seychelles") { label1.Text = "correct"; }
                    else if (d == 153 && textBox1.Text == "sierra leone") { label1.Text = "correct"; }
                    else if (d == 154 && textBox1.Text == "singapore") { label1.Text = "correct"; }
                    else if (d == 155 && textBox1.Text == "slovakia") { label1.Text = "correct"; }
                    else if (d == 156 && textBox1.Text == "slovenia") { label1.Text = "correct"; }
                    else if (d == 157 && textBox1.Text == "solomon islands") { label1.Text = "correct"; }
                    else if (d == 158 && textBox1.Text == "somalia") { label1.Text = "correct"; }
                    else if (d == 159 && textBox1.Text == "south africa") { label1.Text = "correct"; }
                    else if (d == 160 && textBox1.Text == "south korea") { label1.Text = "correct"; }
                    else if (d == 161 && textBox1.Text == "south sudan") { label1.Text = "correct"; }
                    else if (d == 162 && textBox1.Text == "spain") { label1.Text = "correct"; }
                    else if (d == 163 && textBox1.Text == "sri lanka") { label1.Text = "correct"; }
                    else if (d == 164 && (textBox1.Text == "st. vincent grenadines" || textBox1.Text == "st vincent grenadines")) { label1.Text = "correct"; }
                    else if (d == 165 && (textBox1.Text == "state of palestine" || textBox1.Text == "palestine")) { label1.Text = "correct"; }
                    else if (d == 166 && textBox1.Text == "sudan") { label1.Text = "correct"; }
                    else if (d == 167 && textBox1.Text == "suriname") { label1.Text = "correct"; }
                    else if (d == 168 && textBox1.Text == "sweden") { label1.Text = "correct"; }
                    else if (d == 169 && textBox1.Text == "switzerland") { label1.Text = "correct"; }
                    else if (d == 170 && textBox1.Text == "syria") { label1.Text = "correct"; }
                    else if (d == 171 && textBox1.Text == "tajikistan") { label1.Text = "correct"; }
                    else if (d == 172 && textBox1.Text == "tanzania") { label1.Text = "correct"; }
                    else if (d == 173 && textBox1.Text == "thailand") { label1.Text = "correct"; }
                    else if (d == 174 && (textBox1.Text == "timor-leste" || textBox1.Text == "east timor")) { label1.Text = "correct"; }
                    else if (d == 175 && textBox1.Text == "togo") { label1.Text = "correct"; }
                    else if (d == 176 && textBox1.Text == "tonga") { label1.Text = "correct"; }
                    else if (d == 177 && (textBox1.Text == "trinidad and tobago" || textBox1.Text == "tobago and trinidad")) { label1.Text = "correct"; }
                    else if (d == 178 && textBox1.Text == "tunisia") { label1.Text = "correct"; }
                    else if (d == 179 && textBox1.Text == "turkey") { label1.Text = "correct"; }
                    else if (d == 180 && textBox1.Text == "turkmenistan") { label1.Text = "correct"; }
                    else if (d == 181 && textBox1.Text == "tuvalu") { label1.Text = "correct"; }
                    else if (d == 182 && (textBox1.Text == "u.a.e" || textBox1.Text == "united arab emirates")) { label1.Text = "correct"; }
                    else if (d == 183 && (textBox1.Text == "u.k" || textBox1.Text == "united kingdom")) { label1.Text = "correct"; }
                    else if (d == 184 && (textBox1.Text == "U.S" || textBox1.Text == "united states")) { label1.Text = "correct"; }
                    else if (d == 185 && textBox1.Text == "Uganda") { label1.Text = "correct"; }
                    else if (d == 186 && textBox1.Text == "ukraine") { label1.Text = "correct"; }
                    else if (d == 187 && textBox1.Text == "uruguay") { label1.Text = "correct"; }
                    else if (d == 188 && textBox1.Text == "uzbekistan") { label1.Text = "correct"; }
                    else if (d == 189 && textBox1.Text == "vanuatu") { label1.Text = "correct"; }
                    else if (d == 190 && textBox1.Text == "venezuela") { label1.Text = "correct"; }
                    else if (d == 191 && textBox1.Text == "vietnam") { label1.Text = "correct"; }
                    else if (d == 192 && textBox1.Text == "yemen") { label1.Text = "correct"; }
                    else if (d == 193 && textBox1.Text == "zambia") { label1.Text = "correct"; }
                    else if (d == 194 && textBox1.Text == "zimbabwe") { label1.Text = "correct"; }
                    else if (d >= 0)
                    {
                        label1.Text = "incorrect";
                    }
                    #endregion
                    if (label1.Text == "correct")
                    {
                        score += 1;
                        label3.Text = score.ToString();
                        settings.score = score;
                    }
                    t += 1;
                    label5.Text = t.ToString();
                    settings.tries = t;
                    var rand = new Random();
                    int b = rand.Next(194);
                    string a = @"C:\Users\Marco\source\repos\itvitae creations\Flags of the World\Flags of the World\Flags\";
                    #region countrygifs
                    if (b <= 0) { pictureBox1.ImageLocation = a + "afghanistan.gif"; }
                    else if (b == 1) { pictureBox1.ImageLocation = a + "albania.gif"; }
                    else if (b == 2) { pictureBox1.ImageLocation = a + "algeria.gif"; }
                    else if (b == 3) { pictureBox1.ImageLocation = a + "andorra.gif"; }
                    else if (b == 4) { pictureBox1.ImageLocation = a + "angola.gif"; }
                    else if (b == 5) { pictureBox1.ImageLocation = a + "antiqua_and_Barbuda.gif"; }
                    else if (b == 6) { pictureBox1.ImageLocation = a + "argentina.gif"; }
                    else if (b == 7) { pictureBox1.ImageLocation = a + "armenia.gif"; }
                    else if (b == 8) { pictureBox1.ImageLocation = a + "australia.gif"; }
                    else if (b == 9) { pictureBox1.ImageLocation = a + "austria.gif"; }
                    else if (b == 10) { pictureBox1.ImageLocation = a + "azerbaijin.gif"; }
                    else if (b == 11) { pictureBox1.ImageLocation = a + "bahamas.gif"; }
                    else if (b == 12) { pictureBox1.ImageLocation = a + "bahrain.gif"; }
                    else if (b == 13) { pictureBox1.ImageLocation = a + "bangladesh.gif"; }
                    else if (b == 14) { pictureBox1.ImageLocation = a + "bardaros.gif"; }
                    else if (b == 15) { pictureBox1.ImageLocation = a + "belarus.gif"; }
                    else if (b == 16) { pictureBox1.ImageLocation = a + "belgium.gif"; }
                    else if (b == 17) { pictureBox1.ImageLocation = a + "belize.gif"; }
                    else if (b == 18) { pictureBox1.ImageLocation = a + "benin.gif"; }
                    else if (b == 19) { pictureBox1.ImageLocation = a + "bhutan.gif"; }
                    else if (b == 20) { pictureBox1.ImageLocation = a + "bolivia.gif"; }
                    else if (b == 21) { pictureBox1.ImageLocation = a + "bosnia_and_Herzegovina.gif"; }
                    else if (b == 22) { pictureBox1.ImageLocation = a + "botswana.gif"; }
                    else if (b == 23) { pictureBox1.ImageLocation = a + "brazil.gif"; }
                    else if (b == 24) { pictureBox1.ImageLocation = a + "brunei.gif"; }
                    else if (b == 25) { pictureBox1.ImageLocation = a + "bulgaria.gif"; }
                    else if (b == 26) { pictureBox1.ImageLocation = a + "burkina_Faso.gif"; }
                    else if (b == 27) { pictureBox1.ImageLocation = a + "burundi.gif"; }
                    else if (b == 28) { pictureBox1.ImageLocation = a + "cabo_verde.gif"; }
                    else if (b == 29) { pictureBox1.ImageLocation = a + "cambodia.gif"; }
                    else if (b == 30) { pictureBox1.ImageLocation = a + "cameroon.gif"; }
                    else if (b == 31) { pictureBox1.ImageLocation = a + "canada.gif"; }
                    else if (b == 32) { pictureBox1.ImageLocation = a + "CAR.gif"; }
                    else if (b == 33) { pictureBox1.ImageLocation = a + "chad.gif"; }
                    else if (b == 34) { pictureBox1.ImageLocation = a + "chile.gif"; }
                    else if (b == 35) { pictureBox1.ImageLocation = a + "china.gif"; }
                    else if (b == 36) { pictureBox1.ImageLocation = a + "colombia.gif"; }
                    else if (b == 37) { pictureBox1.ImageLocation = a + "comoros.gif"; }
                    else if (b == 38) { pictureBox1.ImageLocation = a + "congo.gif"; }
                    else if (b == 39) { pictureBox1.ImageLocation = a + "costa_Rica.gif"; }
                    else if (b == 40) { pictureBox1.ImageLocation = a + "côte_ d'ivoire.gif"; }
                    else if (b == 41) { pictureBox1.ImageLocation = a + "croatia.gif"; }
                    else if (b == 42) { pictureBox1.ImageLocation = a + "cuba.gif"; }
                    else if (b == 43) { pictureBox1.ImageLocation = a + "cyprus.gif"; }
                    else if (b == 44) { pictureBox1.ImageLocation = a + "czechia.gif"; }
                    else if (b == 45) { pictureBox1.ImageLocation = a + "denmark.gif"; }
                    else if (b == 46) { pictureBox1.ImageLocation = a + "djibouti.gif"; }
                    else if (b == 47) { pictureBox1.ImageLocation = a + "dominica.gif"; }
                    else if (b == 48) { pictureBox1.ImageLocation = a + "dominican_Republic.gif"; }
                    else if (b == 49) { pictureBox1.ImageLocation = a + "DPRK.gif"; }
                    else if (b == 50) { pictureBox1.ImageLocation = a + "DRC.gif"; }
                    else if (b == 51) { pictureBox1.ImageLocation = a + "ecuador.gif"; }
                    else if (b == 52) { pictureBox1.ImageLocation = a + "egypt.gif"; }
                    else if (b == 53) { pictureBox1.ImageLocation = a + "el_Salvador.gif"; }
                    else if (b == 54) { pictureBox1.ImageLocation = a + "equatorial_Guinea.gif"; }
                    else if (b == 55) { pictureBox1.ImageLocation = a + "eritrea.gif"; }
                    else if (b == 56) { pictureBox1.ImageLocation = a + "estonia.gif"; }
                    else if (b == 57) { pictureBox1.ImageLocation = a + "eswatini.gif"; }
                    else if (b == 58) { pictureBox1.ImageLocation = a + "ethiopia.gif"; }
                    else if (b == 59) { pictureBox1.ImageLocation = a + "fiji.gif"; }
                    else if (b == 60) { pictureBox1.ImageLocation = a + "finland.gif"; }
                    else if (b == 61) { pictureBox1.ImageLocation = a + "france.gif"; }
                    else if (b == 62) { pictureBox1.ImageLocation = a + "gabon.gif"; }
                    else if (b == 63) { pictureBox1.ImageLocation = a + "gambia.gif"; }
                    else if (b == 64) { pictureBox1.ImageLocation = a + "georgia.gif"; }
                    else if (b == 65) { pictureBox1.ImageLocation = a + "germany.gif"; }
                    else if (b == 66) { pictureBox1.ImageLocation = a + "ghana.gif"; }
                    else if (b == 67) { pictureBox1.ImageLocation = a + "greece.gif"; }
                    else if (b == 68) { pictureBox1.ImageLocation = a + "grenada.gif"; }
                    else if (b == 69) { pictureBox1.ImageLocation = a + "guatemala.gif"; }
                    else if (b == 70) { pictureBox1.ImageLocation = a + "guinea.gif"; }
                    else if (b == 71) { pictureBox1.ImageLocation = a + "guinea-Bissau.gif"; }
                    else if (b == 72) { pictureBox1.ImageLocation = a + "guyana.gif"; }
                    else if (b == 73) { pictureBox1.ImageLocation = a + "haiti.gif"; }
                    else if (b == 74) { pictureBox1.ImageLocation = a + "holy_See.gif"; }
                    else if (b == 75) { pictureBox1.ImageLocation = a + "honduras.gif"; }
                    else if (b == 76) { pictureBox1.ImageLocation = a + "hungary.gif"; }
                    else if (b == 77) { pictureBox1.ImageLocation = a + "iceland.gif"; }
                    else if (b == 78) { pictureBox1.ImageLocation = a + "india.gif"; }
                    else if (b == 79) { pictureBox1.ImageLocation = a + "indonesia.gif"; }
                    else if (b == 80) { pictureBox1.ImageLocation = a + "iran.gif"; }
                    else if (b == 81) { pictureBox1.ImageLocation = a + "iraq.gif"; }
                    else if (b == 82) { pictureBox1.ImageLocation = a + "ireland.gif"; }
                    else if (b == 83) { pictureBox1.ImageLocation = a + "israel.gif"; }
                    else if (b == 84) { pictureBox1.ImageLocation = a + "italy.gif"; }
                    else if (b == 85) { pictureBox1.ImageLocation = a + "jamaica.gif"; }
                    else if (b == 86) { pictureBox1.ImageLocation = a + "japan.gif"; }
                    else if (b == 87) { pictureBox1.ImageLocation = a + "jordan.gif"; }
                    else if (b == 88) { pictureBox1.ImageLocation = a + "kazakhstan.gif"; }
                    else if (b == 89) { pictureBox1.ImageLocation = a + "kenya.gif"; }
                    else if (b == 90) { pictureBox1.ImageLocation = a + "kiribati.gif"; }
                    else if (b == 91) { pictureBox1.ImageLocation = a + "kuwait.gif"; }
                    else if (b == 92) { pictureBox1.ImageLocation = a + "kyrgyzstan.gif"; }
                    else if (b == 93) { pictureBox1.ImageLocation = a + "laos.gif"; }
                    else if (b == 94) { pictureBox1.ImageLocation = a + "latvia.gif"; }
                    else if (b == 95) { pictureBox1.ImageLocation = a + "lebanon.gif"; }
                    else if (b == 96) { pictureBox1.ImageLocation = a + "lesotho.gif"; }
                    else if (b == 97) { pictureBox1.ImageLocation = a + "liberia.gif"; }
                    else if (b == 98) { pictureBox1.ImageLocation = a + "libya.gif"; }
                    else if (b == 99) { pictureBox1.ImageLocation = a + "liechtenstein.gif"; }
                    else if (b == 100) { pictureBox1.ImageLocation = a + "lithuania.gif"; }
                    else if (b == 101) { pictureBox1.ImageLocation = a + "luxembourg.gif"; }
                    else if (b == 102) { pictureBox1.ImageLocation = a + "madagascar.gif"; }
                    else if (b == 103) { pictureBox1.ImageLocation = a + "malawi.gif"; }
                    else if (b == 104) { pictureBox1.ImageLocation = a + "malaysia.gif"; }
                    else if (b == 105) { pictureBox1.ImageLocation = a + "maldives.gif"; }
                    else if (b == 106) { pictureBox1.ImageLocation = a + "mali.gif"; }
                    else if (b == 107) { pictureBox1.ImageLocation = a + "malta.gif"; }
                    else if (b == 108) { pictureBox1.ImageLocation = a + "marshall_Islands.gif"; }
                    else if (b == 109) { pictureBox1.ImageLocation = a + "mauritania.gif"; }
                    else if (b == 110) { pictureBox1.ImageLocation = a + "mauritius.gif"; }
                    else if (b == 111) { pictureBox1.ImageLocation = a + "mexico.gif"; }
                    else if (b == 112) { pictureBox1.ImageLocation = a + "micronesia.gif"; }
                    else if (b == 113) { pictureBox1.ImageLocation = a + "moldova.gif"; }
                    else if (b == 114) { pictureBox1.ImageLocation = a + "monaco.gif"; }
                    else if (b == 115) { pictureBox1.ImageLocation = a + "mongolia.gif"; }
                    else if (b == 116) { pictureBox1.ImageLocation = a + "montenegro.gif"; }
                    else if (b == 117) { pictureBox1.ImageLocation = a + "morocco.gif"; }
                    else if (b == 118) { pictureBox1.ImageLocation = a + "mozambique.gif"; }
                    else if (b == 119) { pictureBox1.ImageLocation = a + "myanmar.gif"; }
                    else if (b == 120) { pictureBox1.ImageLocation = a + "namibia.gif"; }
                    else if (b == 121) { pictureBox1.ImageLocation = a + "nauru.gif"; }
                    else if (b == 122) { pictureBox1.ImageLocation = a + "nepal.gif"; }
                    else if (b == 123) { pictureBox1.ImageLocation = a + "netherlands.gif"; }
                    else if (b == 124) { pictureBox1.ImageLocation = a + "new_Zealand.gif"; }
                    else if (b == 125) { pictureBox1.ImageLocation = a + "nicaraqua.gif"; }
                    else if (b == 126) { pictureBox1.ImageLocation = a + "niger.gif"; }
                    else if (b == 127) { pictureBox1.ImageLocation = a + "nigeria.gif"; }
                    else if (b == 128) { pictureBox1.ImageLocation = a + "north_Macedonia.gif"; }
                    else if (b == 129) { pictureBox1.ImageLocation = a + "norway.gif"; }
                    else if (b == 130) { pictureBox1.ImageLocation = a + "oman.gif"; }
                    else if (b == 131) { pictureBox1.ImageLocation = a + "pakistan.gif"; }
                    else if (b == 132) { pictureBox1.ImageLocation = a + "palau.gif"; }
                    else if (b == 133) { pictureBox1.ImageLocation = a + "panama.gif"; }
                    else if (b == 134) { pictureBox1.ImageLocation = a + "papua_New_guinea.gif"; }
                    else if (b == 135) { pictureBox1.ImageLocation = a + "paraguay.gif"; }
                    else if (b == 136) { pictureBox1.ImageLocation = a + "peru.gif"; }
                    else if (b == 137) { pictureBox1.ImageLocation = a + "philippines.gif"; }
                    else if (b == 138) { pictureBox1.ImageLocation = a + "poland.gif"; }
                    else if (b == 139) { pictureBox1.ImageLocation = a + "portugal.gif"; }
                    else if (b == 140) { pictureBox1.ImageLocation = a + "qatar.gif"; }
                    else if (b == 141) { pictureBox1.ImageLocation = a + "romania.gif"; }
                    else if (b == 142) { pictureBox1.ImageLocation = a + "russia.gif"; }
                    else if (b == 143) { pictureBox1.ImageLocation = a + "rwanda.gif"; }
                    else if (b == 144) { pictureBox1.ImageLocation = a + "saint_Kitts_and_Nevis.gif"; }
                    else if (b == 145) { pictureBox1.ImageLocation = a + "saint_Lucia.gif"; }
                    else if (b == 146) { pictureBox1.ImageLocation = a + "samoa.gif"; }
                    else if (b == 147) { pictureBox1.ImageLocation = a + "san_Marino.gif"; }
                    else if (b == 148) { pictureBox1.ImageLocation = a + "sao_Tome_and_Principe.gif"; }
                    else if (b == 149) { pictureBox1.ImageLocation = a + "saudi_Arabia.gif"; }
                    else if (b == 150) { pictureBox1.ImageLocation = a + "senegal.gif"; }
                    else if (b == 151) { pictureBox1.ImageLocation = a + "serbia.gif"; }
                    else if (b == 152) { pictureBox1.ImageLocation = a + "seychelles.gif"; }
                    else if (b == 153) { pictureBox1.ImageLocation = a + "sierra_Leone.gif"; }
                    else if (b == 154) { pictureBox1.ImageLocation = a + "singapore.gif"; }
                    else if (b == 155) { pictureBox1.ImageLocation = a + "slovakia.gif"; }
                    else if (b == 156) { pictureBox1.ImageLocation = a + "slovenia.gif"; }
                    else if (b == 157) { pictureBox1.ImageLocation = a + "solomon_Islands.gif"; }
                    else if (b == 158) { pictureBox1.ImageLocation = a + "somalia.gif"; }
                    else if (b == 159) { pictureBox1.ImageLocation = a + "south_Africa.gif"; }
                    else if (b == 160) { pictureBox1.ImageLocation = a + "south_korea.gif"; }
                    else if (b == 161) { pictureBox1.ImageLocation = a + "south_Sudan.gif"; }
                    else if (b == 162) { pictureBox1.ImageLocation = a + "spain.gif"; }
                    else if (b == 163) { pictureBox1.ImageLocation = a + "sri_Lanka.gif"; }
                    else if (b == 164) { pictureBox1.ImageLocation = a + "St_Vincent_Grenadines.gif"; }
                    else if (b == 165) { pictureBox1.ImageLocation = a + "state_of_Palestine.gif"; }
                    else if (b == 166) { pictureBox1.ImageLocation = a + "sudan.gif"; }
                    else if (b == 167) { pictureBox1.ImageLocation = a + "suriname.gif"; }
                    else if (b == 168) { pictureBox1.ImageLocation = a + "sweden.gif"; }
                    else if (b == 169) { pictureBox1.ImageLocation = a + "switzerland.gif"; }
                    else if (b == 170) { pictureBox1.ImageLocation = a + "syria.gif"; }
                    else if (b == 171) { pictureBox1.ImageLocation = a + "tajikistan.gif"; }
                    else if (b == 172) { pictureBox1.ImageLocation = a + "tanzania.gif"; }
                    else if (b == 173) { pictureBox1.ImageLocation = a + "thailand.gif"; }
                    else if (b == 174) { pictureBox1.ImageLocation = a + "timor-leste.gif"; }
                    else if (b == 175) { pictureBox1.ImageLocation = a + "togo.gif"; }
                    else if (b == 176) { pictureBox1.ImageLocation = a + "tonga.gif"; }
                    else if (b == 177) { pictureBox1.ImageLocation = a + "trinidad_and_Tobago.gif"; }
                    else if (b == 178) { pictureBox1.ImageLocation = a + "tunisia.gif"; }
                    else if (b == 179) { pictureBox1.ImageLocation = a + "turkey.gif"; }
                    else if (b == 180) { pictureBox1.ImageLocation = a + "turkmenistan.gif"; }
                    else if (b == 181) { pictureBox1.ImageLocation = a + "tuvalu.gif"; }
                    else if (b == 182) { pictureBox1.ImageLocation = a + "U.A.E.gif"; }
                    else if (b == 183) { pictureBox1.ImageLocation = a + "U.K..gif"; }
                    else if (b == 184) { pictureBox1.ImageLocation = a + "U.S..gif"; }
                    else if (b == 185) { pictureBox1.ImageLocation = a + "Uganda.gif"; }
                    else if (b == 186) { pictureBox1.ImageLocation = a + "ukraine.gif"; }
                    else if (b == 187) { pictureBox1.ImageLocation = a + "uruguay.gif"; }
                    else if (b == 188) { pictureBox1.ImageLocation = a + "uzbekistan.gif"; }
                    else if (b == 189) { pictureBox1.ImageLocation = a + "vanuatu.gif"; }
                    else if (b == 190) { pictureBox1.ImageLocation = a + "venezuela.gif"; }
                    else if (b == 191) { pictureBox1.ImageLocation = a + "vietnam.gif"; }
                    else if (b == 192) { pictureBox1.ImageLocation = a + "yemen.gif"; }
                    else if (b == 193) { pictureBox1.ImageLocation = a + "zambia.gif"; }
                    else if (b == 194) { pictureBox1.ImageLocation = a + "zimbabwe.gif"; }
                    #endregion
                    settings.random = b;
                    textBox1.Text = "";
                    if (t == 10)
                    {
                        label6.Text = "Your score is: " + score.ToString() + "/" + t.ToString();
                    }
                }
                if (e.KeyCode != Keys.Enter)
                {
                    label1.Text = "no answer";
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            int score = settings.score;
            int tries = settings.tries;

            score = 0;
            tries = 0;

            settings.score = score;
            settings.tries = tries;

            label6.Text = "";
            label5.Text = "0";
            label3.Text = "0";
            textBox1.Text = "";
        }
    }
}
