
 var thirArr = new Array(1000);
 
            
var s = '';

var count = 0;
 for (var i = 0; i< thirArr.length;i++)
 {
            
    
      console.log(i);
        
 
    if (i % 20 == 0 ){

        console.log(s + i);
    }
    if (i % 3 == 0){
        

        console.log(count);
        console.log('sweet');
        
    }
    if (i % 5 == 0){

        console.log('salty');
    }
    
    if ( i % 3 == 0 && i % 5 == 0){


          console.log('saltynSweet');

    }
   
}