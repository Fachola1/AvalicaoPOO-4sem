Questão 5 - Explique, brevemente, o que é polimorfismo e dê um exemplo modificando apenas o exercício 4. Coloque 
apena linha modificada

Polimorfismo é quando objetos diferentes podem agir igual
mesmo sendo de tipos diferentes. Isso acontece quando eles herdam de uma mesma classe ou implementam a mesma interface que no caso foi o ILog.
Por exemplo um método pode fazer coisas diferentes dependendo do tipo de objeto que chama ele.

A linha modificada:
ILog consoleLog = new ConsoleLog();
ILog consoleAndFileLog = new ConsoleAndFileLog("avaliacao1poo.txt");
