List<string> cities=new();
bool exit=false;
string resp;
while(!exit){
    Console.WriteLine("Write something to be entered into \"cities\" or write \"exit\" to exit");
    resp=Console.ReadLine().ToLower();
    if(resp=="exit"){
        exit=true;
    }
    else{
        cities.Add(resp);
        Console.Clear();
    }
}
for (int i = 0; i < cities.Count; i++){
    Console.WriteLine(cities[i]);
}
Console.ReadLine();