using System.Threading.Tasks;

class Pizzeria{
    
    public Task<Pizza> ServirPizza(string tipo){
        return new Task<Pizza>(() =>
        {
            return new Pizza(tipo);
        });
    }
}