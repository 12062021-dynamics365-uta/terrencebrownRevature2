/*var console = {};
console.log = function(){};
window.console = console;*/

 let GameProgression  = document.createElement('h1');
 document.body.appendChild(GameProgression);
GameProgression.innerText = 'GAME PROGRESSION';

var myInstruction = document.createElement('h3');
document.body.appendChild(myInstruction);
myInstruction.innerHTML = ' The start and stop numbers must be validated to be at least 200 apart and no more than 10,000 apart. '

let outputElement = document.createElement("input");
document.body.appendChild(outputElement);

var myListOfSteps = document.createElement('ol');
document.body.appendChild(myListOfSteps);





// btn = document.createElement("button");
// document.body.appendChild(btn);
// btn.innerText = 'PRESS ENTER';




let input = document.querySelector('input');
outputElement.addEventListener('keyup',  (e) => {
    if (e.key ==='Enter'){
        let newNum = outputElement.value;
        //document.body.innerText = newNum;
        enterFunction(newNum);
        numsOfAThousand();
        if (newNum === ""){
            alert("You must enter an number");
            return false;
            
        }
    }
});

var start = 200;


function enterFunction(myConvertNumber)
{
    
        var myConvertNumber;
        var absoluteNumber = myConvertNumber - 200;
        myListOfSteps.innerHTML = 'The user enters the number to start with. Then clicks Enter'

        if (absoluteNumber >= 0){ //&&  (10000 - absoluteNumber) >= 10000){

            
            myListOfSteps.innerHTML = 'Please enter a final number';
            
        }else{
            document.body.innerText = 'This is not a number';
        }
    
}


// btn.innerHTML = "CLICK ME";
// outputElement.type="submit";
// outputElement.name="PRESS ENTER";




var thirArr = new Array(1000);
var myVar = document.createElement('p');
    document.body.appendChild(myVar);

var myvarrr = document.createElement('p');
    document.body.appendChild(myvarrr);
 
var myVar1 = document.createElement('p');

var mytest = document.createElement('h1');
//document.body.append(mytest);
//mytest.innerHTML = "You are mines";



function numsOfAThousand()
{
    
     
    var count = 0;
    for (var i = 0; i<= thirArr.length;i++)
    {
            

        //myvarrr.innerHTML += i + " ";
        //myVar.innerHTML += i + " ";
                document.body.innerHTML += i + " ";
                    
        if(i % 3 ==0){

            //myVar.style.color += 'blue';
        // myvarrr.innerHTML += 'salty';
        // document.style.color +='red';
            document.body.innerHTML+='salty';
        }
        if(i % 5 ==0){

            //myVar.style.color+= 'red';
            //myvarrr.innerHTML +='sweet';
            document.body.innerHTML+='sweet';

        }
        if(i % 3 ==0 && i % 5 == 0){
            //myVar.style.color += 'red';
            //myVar.style.color+='green';
            //myvarrr.innerHTML+= 'sweetnSalty';
            document.body.innerHTML+='sweetnSalty';
        }
        if (i % 40 == 0){
            //myVar.innerHTML += "<br>";
            document.body.innerHTML += "<br>";
    
    }   
}

}





