/*
1. Node read Line by line using readline module
https://www.w3schools.com/nodejs/ref_readline.asp

//For NaN quality, use Onject.is(xx, NaN) or isNaN()
https://stackoverflow.com/questions/8965364/comparing-nan-values-for-equality-in-javascript

flags for createWriteStream():
'r' - Open file for reading. An exception occurs if the file does not exist.
'r+' - Open file for reading and writing. An exception occurs if the file does not exist.
'w' - Open file for writing. The file is created (if it does not exist) or truncated (if it exists).
'w+' - Open file for reading and writing. The file is created (if it does not exist) or truncated (if it exists).
'a' - Open file for appending. The file is created if it does not exist.
'a+' - Open file for reading and appending. The file is created if it does not exist.


*/

var readline = require('readline');
var fs = require('fs');

var myInterface = readline.createInterface({
  input: fs.createReadStream('input.txt')
});

var logger = fs.createWriteStream('output.txt', {
    flags: 'w+' // create ifn ot existing, clear if existing
  })

var lineno = 0;
myInterface.on('line', function (line) {
  lineno++;
  console.log('Line number ' + lineno + ': ' + line);
  
  if(!isNaN(parseInt(line))){
      logger.write(line.toString() + '\n');
  }
});

// this can't be here, as the on() method is async, the file handler will close when the program ends
//logger.end()

