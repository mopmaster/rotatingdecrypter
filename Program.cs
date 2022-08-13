// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string input = "Jxu Pedu ev Qbyudjyed - Jxu Hebu ev Ucyiiyedi yd Ckjqdj Hufhetksjyed ro Fhevujieh Q.R. Ijhkwqjiao Qrijhqsi Qi tuce dijhgjut ro Fhevujieh Xuhcodd, yi yi a demd jxgj ucyiiye di sod fhetksu ghjuvasji qdt qdecqbyui, mxybu Fhevujieh Iqaxqhel xqi tuce dijhqjut jxqji ucviivedi sad pecryvo bylydw ruydwi. Rkj mxgj ghu ixu uvvusji ev ucyiiyedi ed xkcad hucydi? Huikbji muhu erjaydut ro buqlydw jxu sehfiui ev ijqbauhi sqwut yd efud qyh tkhydwucyiiyedi. Qvjuhickbiyfbu juiji, jxu unfuhycudji muhu hufugjut myjx jxu retyui ev xkcqdeyt ckjqdji iksx qi jxu varbut idehai qdt rbeetiksauhi. Mxgj mu vekdt mqi jxqj qd ucyiiyed, mxud secydw ydje sedjasj myjxq iaubujqb sehfiu, xqi q sxqdsu je shugju q cekbqwu - 9 bylydw squ ev vbuix catu vhec qde cabeki fxude cudq, mxysx jxud huqdycjui jxu reto. Cekbqwui sad jgau jxu vehc ev idehai, rbeetiksauhi, pecryvyut xkcgdi gi mubb gi ium cydobo dehcqb xkcqdi, qdt yd abb sqiui sqd rụ tyijydukyixut vhe c jxuyh ihkbo bylvdw sekdjuhfghji ro ixuyh tugjxbo whuo fabbeh. Cekbqwui mxe celi huiucrbut dehcqb xkcqdi unxyryjut jxu grybyjo je secckdysgju rkj hugkyhut, jutgived gi ixuo ydighygrbo tyifbgout unjhucu fqhqdeyq, tubkiyedi, eh q tuiyhu je uisqfu ydje jxu kdademd. Sedsbkiyed: a fejudjyqb unfbqdgjyed veh hufhetksjyed qcedw jxu kdyiun ideha, secckdvivui xgi ruud erigydut. Vkhixuhcehu, jxuhu yi dem q isyudjyvys hajyedqbu veh eriuhlydw fhefuh rkhyqb skijeci yd jxu Pedu, buij mu sxeeiu je vuut yji tqdwuhi ydijuqt. CC -2018";

Dictionary<char, char> decryptionMapping = new Dictionary<char, char>();
int i = 0;
int offset = 10;
for (i = 0; i < 26; i++)
{
    decryptionMapping.Add((char)(i + (int)'a'), (char)(((i + offset) % 26 + (int)'a')));
}

foreach (var value in decryptionMapping.Select((key, value) => (key, value)))
{
    Console.WriteLine(value);
}

string output = "";
foreach (char inp in input.ToLower())
{
try{
    output = output + decryptionMapping[inp];
}
catch(KeyNotFoundException){
    output = output + inp;
}
}
Console.WriteLine(output);