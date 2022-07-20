using MTech_Test1.classes;

//Instancia de ShoppingCart
ShoppingCart shoppingCart = new ShoppingCart();

//Instancia de Item
Item ps5 = new Item("PS5", 1, 14999.99);
Item alexa = new Item("Alexa", 3, 499.99);

//Se añaden al Carrito
shoppingCart.agregarItem(ps5);
shoppingCart.agregarItem(alexa);

//Se efectúa la Compra
shoppingCart.comprar();