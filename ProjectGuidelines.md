**Project Guidelines**
*(click edit at the top right to edit this file)*
1. Programming
    1. Sublists can be added in markdown using 4 spaces or tabbing 2 times in front of the next number
    2. ** means bold, * means italics
    3. it's a handy format
    4. also images can be added like: "!=[Name of Image]=(link.png)" with no spaces where the equals signs are
    5. I should be charging money for this free tutorial
    6. Ok, go at it!
    
2. Art Assets
    1. **Sprite sheet format**
        * *further discussion would be required. the size and format are highly dependent on the size and the number of the assets. the actual size of the grid/tile will be determined before the project*
        1. static object
            * *creation of object should follow the general guide for pixel art section _.*
            - dimensions of object sprite: the size of objects are determined by the size of grid which is TBD at this point. the dimension of most object should be smaller than the size of grids. 
            //insert dimension_of_object.png here
            - background of object sprite: no back ground should be included. ie. leave it as transparent. In fact, create a file with transparent background or no background.
            - sprite with muitiple state: combine them in the same .png file when exporting. put each sprite in their own grid, do not put multiple objects in the same grid.
            
        2. animated object
            * *if your software have automatic conversion, use the conversion. each frame in a animation should be kept in the same sprite sheet and arranged in the correct order. add discription and numbering of necessary.*
            - animation of player model: the creation of the player model animation should be carefully consider to ensure a responsive control and a smooth movment. follow the frame rate in animation guideline in section 4.
            - animation of enemey minion: the enemy minion animation should be limited to simple movemnt to ensure the ease of identification movment. follow the frame rate in animation guideline in section 4, use static frame if necessery.
            - animation of enemy bosses: the animation for bosses should cope well with their respective property/style. follow the frame rate in animation guideline in section 4, use static frame if necessery.
            - animation of other object: animation of small objects or fast moving objects should be avoided. 
        
        3. tile/grid
            * *it is not sure if tile would be necessery for this project.*
            * *creation of tile should follow the general guide for pixel art section _.*
            - grid system: a basic system that take matrix of pixel as a unit. it will be used as a reference for all sprite size.
            - dimensions of tile: should be the same dimension of the grid which is TBD.
            - animation of tile: follow the animation frame rate in guideline in section 4, use static frame if necessery. 
                * *further discussion would be required. usage of animated tile should be careful considered as it could distract the player from following the player model.*
        
        4. background/foreground
            * *it is not sure if backgound and foreground would be necessery for this project.*
            - dimensions of backgound: follow the game resolution in section _.
            - dimensions of foregound: size of the foreground should very according to need.
            - animation of background/foreground: follow the animation frame rate guideline in section 4, use static frame if necessery.
                * *further discussion would be required. just like animated tile, it should be careful considered as it could distract the player from following the player model.*

        5. particle effect
            - explosion
            - fragmentation
            - smoke
            - other
        
        6. sprite sheet
            - submission of sprite sheet: should be always be multiple of the demension of a tile. Individual submission should adjust the size according to the size of the object.ie. don't create a 1920* 1080 sprite sheet for a 8* 8 sprite. the emthod of submssion is TBD.
            - integration of sprite: communcate with other team and other artist before integrating sprites sheets. save them in .png format with an unambiguous file name. note, use "_" instead of spaces in the name. do not include symbols. Attach a file or include description of necessary. follow the coordinate system guideline in section 5, no exceptions.
        
    2. **usage of pixel art technique**
        * *require further disucssion.*
        1. usage of pixel perfect: mandatory. do if manually if no software support.
        
        2. usage of ratio for straight line: if possible.
        
        3. usage of anti-aliasing: do not use for now.
            * *further discussion would be required, do not use them as for now. they are hard to remove but easy to add.*
            
        4. usage of outlining: do not use for now. 
            * *further discussion would be required.*
            
        5. usage of dithering: yes
            * *further discussion would be required. a single dithering style will be selected for all assets.*
            
        6. usage of alpha channel: just don't use it unless you are dealing with static reflection (which we probably won't). stop it, find some help.
            * *more detail in the pixel art guide.*
            
        7. usage of tiling technique: according to need.
            * *use tile mode if you can, use four slice technique if necessery. do not apply unity nine slice for now.*
            
        8. usage of color harmany: yes. base on personal preference.
        
    3. **art style and color**
        * *this part require more information from writer team.*
        
        1. player 1
            - player model: do not repersent the actual size of the hit box.
            - player wingman model: smaller than player model but follow the same color and style.
            - player projectile: must be different from the enemy projectile. should be smaller and faster moving with a less eye catching color.
            
        2. stage_1: "Contentment"
            - enemy
            - backgound
            - foreground
            - environmental
            
        3. stage_2: "Apprehension"
            - enemy
            - backgound
            - foreground
            - environmental
            
        4. stage_3: "Fear"
            - enemy
            - backgound
            - foreground
            - environmental
            
        5. stage_4: "Despair"
            - enemy
            - backgound
            - foreground
            - environmental
            
        6. stage_5: "Animosity"
            - enemy
            - backgound
            - foreground
            - environmental
            
        7. stage_5: "Pure Malevolence"
            - enemy
            - backgound
            - foreground
            - environmental
            
        8. user interface
            - UI
            - background art
            - desktop icon
             
        9. miscellaneous
            - water mark
            - club logo
            
         * *color selection should follow the general guide for pixel art section _. color should be determined before creating the sprite to maintain consistency within each stages. style should be determined before creating any sprite for the project to maintain consistency within the game.*

    4. **animation and particle/effect**
        1. animation style: do not add any motion blur for now.
        
        2. animation frame rate: consider 8 frame for now. all walking animation should be at least 8 frames (contact, low, passing, high, contact, low, passing, high).
        
        3. particle/effect style: follow the style of other animated objects. maintain style consistency as priority.
        
        4. particle/effect frame rate: follow the frame rate of other animated objects. maintain style consistency as priority.
                
    5. **Coordinate system: use pixel as unit is recommonded, do not create a tile coordinate system. trust me, i'm an engineer.**
                
    6. **Lighting channel**
        * *detail information would be added latter. color subject to change.*
        * *further discussion would be required. ideally, each of the direction channels should have at least five different colors representing fire different angle. ie.0, 45, 90, 135, 180 degree.*
        1. vertical channel: exact color TBD, consider these are place holder. represent the vertial directions that the pixel is facing. ie. up and down. 
            - 0 degree: none (facing up)
            - 30 degree: #FF000 
            - 60 degree: #C00000
            - 90 degree: #800000 (facing the camera)
            - 120 degree: #400000
            - 150 degree: #000000
            - 180 degree: none (facing down)
        //insert vertical_channel.png here
        
        2. horizontal channel: exact color TBD, consider these are place holder. represent the horizontal directions that the pixel is facing. ie. left and right. 
            - 0 degree: none (facing left)
            - 30 degree: #00FF00
            - 60 degree: #00C00
            - 90 degree: #008000 (facing the camera)
            - 120 degree: #004000
            - 150 degree: #000000
            - 180 degree: none (facing right)
        //insert horizontal_channel.png here
        
        3. default color: same color as 90 degree. ie. #800000 for vertical and #008000 for horizontal.
        
        4. integration of the two channel: yes for submission. no for file transfer between artists.
        * *more infromation in section 9.*
        
        * *note, the vertical and hroizontal channel should be created on two different layers. the two layer should be combined into one .png file when exporting.*
        
    7. **Reflection channel**
        * *detail information would be added latter. color subject to change.*
        1. material: exact color TBD. Different material have different effect of reflection. ie. metal would be more reflective than wood.
            - non-reflective: #00005C
            - reflective: #000080
            - recesses: #000030
            
        2. no reflection: #00005C
        
        * *note, the reflection channel should be created on a separate layer.*
            
    8. **Scatter/splinter channel**
        *detail information would be added latter.
        1. fragment: each color represent a different piece of fragment which would be lauched to a different direction when explode. note, only assign one color to one piece of fragment and do not reuse colors.
        
        2. noise: the minimal acceptable differences between two colors to be identified as different fragments. do not consider noise for now.
        //insert scatter_channel.png here
        
        3. no scatter/splinter: #FFFFFF
        
        4. fragment: any color that is not #FFFFFF
        
        * *note, the scatter/splinter channel should be created on a seprate layer. the fragment sprite should be created as a seprate file.*
        
    9. **File format**
        1. format conversion between software: it is impossible to convert between different software format. if you must send the sprite to another artist who is using different software, try divide different layer into separate .png files and let the receiver import them into different layers.
        
        2. default format of sprite sheet submissions: .png, all static sprite sheet should be saved as .png file. use the conversion format for animatied object.
        * *further discussion would be required. depends on which way is easier for the coding team to work with. before this format is confirmed, preserve them in software format.*
        
        3. animation format: save them as default software format for now.
    
    10. **Copyright: ordinary artist borrow, great artist steal.**
        1. loyalty free assets: still gonna need money... so no.
        * *depends on funding and direction of the art style.*
    
    11. **Recommonded software**
        Asprite     14.99CAD        (highly recommended as a drawing tool)
        Krita       free            (highly recommended as a image processing tool)
        Piskel      free
        pyxel edit  9.00CAD         (outdated versions are free)
        Photoshop   US$29.99/mo     (just don't, unless you just happened to have a free one by accident)(additional information on how to config PS for pixel art will be added upon request)
        
    12. **the "pixel art guide": contain more detail regarding the creation of pixel art. writen based on asprite and Krita.**
    
3. Game Design/Level Creation
    1. To be added
