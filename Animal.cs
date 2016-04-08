public class Animal {
  public string animalName {get; set; }
  public bool hair {get; set;}
  public bool mammaryGlands {get; set;}
  private string _transportation = "walk";

  public string transportation {
    get {
      return _transportation;
      //  _ means private 
    }
    set {
      // SETS CONDITION THAT VALUE CANT BE EMPTY
      if (value != "")
      {
        transportation = value;
      }
    }
  }

  // FIRST METHOD ON CLASS
  public virtual string move(string transportation) {
    //sets transportation to whatever is passed in
    _transportation = "moves by " + transportation;
    return _transportation;
  }

}


class Mammal : Animal{
  public string animalName = "Mammal";
  public bool hair = true;
  public bool mammaryGlands = true;
  public string foodType {get; set;}
  public string mammalName {get; set;}
  public bool terrestial {get; set;}
  public int legs {get; set;}

  public override string move(string transportation) 
  {
    if (transportation != "fly")
    {
      base.move(transportation);
      return this.transportation;
    } 
    else {
     return "Mammals can't fly.";   
    }
  }
}



class Bear : Mammal{
  public string mammalName = "Bear";
  public string foodType = "Omnivore";
  public bool terrestial = true;
  public int legs = 4;
  public string bearName {get; set;}
  public string diet {get; set;}
  public string habitat {get; set;}
  public bool endangered {get; set;}
  public int weight {get; set;}
  public Bear (int lb) {
    weight = lb;
  }
  public override string move(string transportation)
  {
    base.move(transportation);
  }
}  
Bear Black = new Bear(240);
Black.bearName = "Black Bear";
Black.diet = "Honey, salmon, berries, small mammals";
Black.habitat = "Forests";
Black.endangered = false;

Bear Brown = new Bear(1400);
Brown.bearName = "Brown Bear";
Brown.diet = "Deer, nuts, elk, grass";
Brown.habitat = "Mountain Woodlands";
Brown.endangered = false;

Bear Polar = new Bear(990);
Polar.bearName = "Polar Bear";
Polar.diet = "Seals, walruses, bird eggs";
Polar.habitat = "Polar regions";
Polar.endangered = true;

Bear Panda = new Bear(280);
Panda.bearName = "Panda Bear";
Panda.diet = "Mostly bamboo and occasionally small rodents";
Panda.habitat = "Bamboo forests";
Panda.endangered = true;

Bear Sloth = new Bear(310);
Sloth.bearName = "Sloth Bear";
Sloth.diet = "insects(termites), fruit, and honeycombs";
Sloth.habitat = "Wet/dry forests and grasslands";
Sloth.endangered = true;


class Whale : Mammal {
  public string mammalName = "Whale";
  public string foodType = "Carnivore";
  public int legs = 0;
  public bool terrestial = false;
  public string whaleName {get; set;}
  public string diet {get; set;}
  public string habitat {get; set;}
  public bool endangered {get; set;}
  public int weight {get; set;}
  public Whale (int lb) {
    weight = lb;
  }
  public override void move(string transportation)
  {
    base.move(transportation);
  }
}  
Whale Sperm = new Whale(32000);
Sperm.whaleName = "Sperm Whale";
Sperm.diet = "Squid, fish, eels, octopus";
Sperm.habitat = "Forests";
Sperm.endangered = false;

Whale Beluga = new Whale(3000);
Beluga.whaleName = "Beluga Whale";
Beluga.diet = "Salmon, crab, squid, and shrimp";
Beluga.habitat = "Artic and sub-artic waters";
Beluga.endangered = false;

Whale Blue = new Whale(420000);
Blue.whaleName = "Blue Whale";
Blue.diet = "Small krill and squid";
Blue.habitat = "Atlantic and Pacific Ocean";
Blue.endangered = true;

Whale Gray = new Whale(79000);
Gray.whaleName = "Gray Whale";
Gray.diet = "Crabs, lobsters, crayfish, shrimp";
Gray.habitat = "North Pacific";
Blue.endangered = false;

Whale Narwhal = new Whale(3500);
Narwhal.whaleName = "Narwhal Whale";
Narwhal.diet = "Cod, halibut, squid, and shrimp";
Narwhal.habitat = "Artic, Atlantic, and Pacific Oceans";
Narwhal.endangered = true;


class Ape : Mammal {
  public string mammalName = "Ape";
  public string foodType = "Omnivore";
  public int legs = 2;
  public bool terrestial = true;
  public string apeName {get; set;}
  public string diet {get; set;}
  public string habitat {get; set;}
  public bool endangered {get; set;}
  public int weight {get; set;}
  public Ape (int lb) {
    weight = lb;
  }
  public override string move(string transportation) 
  {
    base.move(transportation);
  }
}  
Ape Gibbon = new Ape(20);
Gibbon.apeName = "Gibbon";
Gibbon.diet = "Fruit, leaves";
Gibbon.habitat = "Forests";
Gibbon.endangered = true;

Ape Orangutan = new Ape(200);
Orangutan.apeName = "Orangutan";
Orangutan.diet = "Fruit, leaves, flowers, insects";
Orangutan.habitat = "Lowland areas near river valleys";
Orangutan.endangered = true;

Ape Gorilla = new Ape(400);
Gorilla.apeName = "Gorilla";
Gorilla.diet = "Fruit, leaves, and insects";
Gorilla.habitat = "Mounains and forests";
Gorilla.endangered = true;

Ape Chimpanzee = new Ape(130);
Chimpanzee.apeName = "Chimpanzee";
Chimpanzee.diet = "Primarily herbivorous, it eats honey, insects, birds and their eggs";
Chimpanzee.habitat = "Woodlands and tropical rainforests";
Chimpanzee.endangered = true;

Ape Bonobo = new Ape(85);
Bonobo.apeName = "Bonobo";
Bonobo.diet = "Primarily fruit, but they also eat leaves, flowers, bark, stems, roots, insect";
Bonobo.habitat = "Tropical and subtropical forests";
Bonobo.endangered = true;



// class Mammal : Animal
// {
//   public bool feedsYoungWithMilk {get; set;}

//   public string food {
//     get {
//       return _food;
//       //  _ means private 
//     }
//     set {
//       if (value != "")
//       {
//           _food = value;
//       }
//     }
//   }

//   public virtual void eat(string food) 
//   {
//     _food = food;
//   }

// }


// class Firefox : Mammal 
// {
//   public double furThickness {get; set;}
//   public int cutenesslevel {get; set;}

//   public override void eat(string leaf) {
//      if (leaf == "palm" || leaf == "bamboo" || leaf == "eucalyptud || leaf == willow") {
//       food = leaf;
//       base.eat(leaf);
//      } else {
//       Console.WriteLine("Firefox can't eat that")
//      }
//   }
// }
// // Derived Class
// class Raccoon : Mammal
// {

//   private bool _washesFood = true; 
//   private bool _isMasked = true; 

//   // OVERLOAD CONSTRUCTOR
//   public Raccoon (bool washes)
//   {
//   _washesFood = washes;
//   }


//   public override void eat(string food) 
//   {
//     if (food == "garbage")
//     {
//       base.eat(food);
//     }
//   }

//   public override void eat() 
//   {
//     if (food == "")
//     {
//       Console.WriteLine("You must define a food first.")
//     }
//   }
// }

// Raccoon larry = new Raccoon();
// larry.eat("bird egg");