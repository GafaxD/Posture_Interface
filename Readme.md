# Postures GUI
This repository contain the GUI that will allow the MCU display de settings and measurments.

## Glosary
MCU: Micro Controller Unit (Arduino)

GUI: Graphic Unit Interface

UART: Universal Asynchronous Receiver Transmitter, it the stantdard communication between the arduino and the PC
## Initial setup
1) Need to start the arduino first in order proper GUI manupulatatio.
2) No more plugins need it. All resourcer are in the repository files.

## GUI explanation
This section is for explain the basic function of the GUI
### A) MainForm

The main window display the distnace, the map scale and it cointains the buttons for start the UART, and call other windows like the UART configuration and the cammera settings

![](Images\MainForm.PNG)
### B) SerialForm
The Serial window is used to configure the UART Port and baudrate, it shows the first COM port available but if there are other ports, the user has to select which one it is going to be use it the aplication

DEFAULT VALUES ARE:

BAUDRATE: 9600

![](Images\SerialForm.PNG)
### C) CameraForm
The camera window allows the user select the camera for take the picture in the moment need it, if there are other record devices availabe, the user can select which one is going to be use in the aplication.

Aditionally, the user can test the camera before start the aplication.

![](Images\CameraForm.PNG)

## End instructions
Thats all for the moment i think 😰

Enjoy 😄