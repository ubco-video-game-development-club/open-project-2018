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
    1. **Sprite sheet format
        *further discussion would be required. the size and format are highly dependent on the size and the number of the assets.
        
        a) static object
            *creation of object should follow the general guide for pixel art section _.
            -dimensions of object sprite: the size of objects are determined by the size of tile. the dimension of most object should be smaller than the size of tiles/grids. if a object is larger than a tile, its dimension should be multiply of a tile.
            //insert dimension_of_object.png here
            -background of object sprite: no back ground should be included. ie. leave it as transparent. In fact, create a file with transparent background or no background.
            -sprite with muitiple state: combine them in the same .png file when exporting.

        b) animated object
            *if your software have automatic conversion, use the conversion. each frame in a animation should be kept in the same sprite sheet and arranged in the correct order. add discription and numbering of necessary. 
            -animation of player model: the creation of the player model animation should be carefully consider to ensure a responsive control and a smooth movment. follow the frame rate in animation guideline in section 4.
            -animation of enemey minion: the enemy minion animation should be limited to simple movemnt to ensure the ease of identification movment. follow the frame rate in animation guideline in section 4, use static frame if necessery.
            -animation of enemy bosses: the animation for bosses should cope well with their respective property/style. follow the frame rate in animation guideline in section 4, use static frame if necessery.
            -animation of other object: animation of small objects or fast moving objects should be avoided. 
        
        c) tile
            *it is not sure if tile would be necessery for this project. 
            *creation of tile should follow the general guide for pixel art section _.
            -dimensions of tile: TBD
            -animation of tile: follow the animation frame rate in guideline in section 4, use static frame if necessery. 
                *further discussion would be required. usage of animated tile should be careful considered as it could distract the player from following the player model.
        
        d) background/foreground
            *it is not sure if backgound and foreground would be necessery for this project.
            -dimensions of backgound: follow the game resolution in section _.
            -dimensions of foregound: size of the foreground should very according to need.
            -animation of background/foreground: follow the animation frame rate guideline in section 4, use static frame if necessery.
                *further discussion would be required. just like animated tile, it should be careful considered as it could distract the player from following the player model.

        e) particle effect
            -explosion
            -fragmentation
            -smoke
            -other
        
        f) sprite sheet
            -submission of sprite sheet: should be always be multiple of the demension of a tile. Individual submission should adjust the size according to the size of the object.ie. don't create a 1920* 1080 sprite sheet for a 8* 8 sprite. the emthod of submssion is TBD.
            -integration of sprite: communcate with other team and other artist before integrating sprites sheets. save them in .png format with an unambiguous file name. note, use "_" instead of spaces in the name. do not include symbols. Attach a file or include description of necessary. follow the coordinate system guideline in section 5, no exceptions.
        
    2. **usage of pixel art technique
        *require further disucssion.
        a) usage of pixel perfect: mandatory. do if manually if no software support.
        
        b) usage of ratio for straight line: if possible.
        
        c) usage of anti-aliasing: TBD
            *further discussion would be required, do not use them as for now. they are hard to remove but easy to add.
            
        d) usage of outlining: TBD
            *further discussion would be required. 
            
        e) usage of dithering: yes
            *further discussion would be required. a single dithering style will be selected for all assets.
            
        f) usage of alpha channel: just don't use it unless you are dealing with static reflection (which we probably won't). stop it, find some help.
            *more detail in the pixel art guide.
            
        g) usage of tiling technique: TBD
            *use tile mode if you can, use four slice technique if necessery. do not apply nine slice for now.
            
        h) usage of color harmany: yes. base on personal preference.
        
    3. **art style and color
        *this part require more information from writer team.
        
        a) player 1
            -player model: do not repersent the actual size of the hit box.
            -player wingman model: smaller than player model but follow the same color and style.
            -player projectile: must be different from the enemy projectile. should be smaller and faster moving with a less eye catching color.
            
        b) stage_1: "Contentment"
            -enemy
            -backgound
            -foreground
            -environmental
            
        c) stage_2: "Apprehension"
            -enemy
            -backgound
            -foreground
            -environmental
            
        d) stage_3: "Fear"
            -enemy
            -backgound
            -foreground
            -environmental
            
        e) stage_4: "Despair"
            -enemy
            -backgound
            -foreground
            -environmental
            
        f) stage_5: "Animosity"
            -enemy
            -backgound
            -foreground
            -environmental
            
        g) stage_5: "Pure Malevolence"
            -enemy
            -backgound
            -foreground
            -environmental
            
        h) user interface
            -UI
            -background art
            -desktop icon
             
        i) miscellaneous
            -water mark
            -club logo
            
         *color selection should follow the general guide for pixel art section _. color should be determined before creating the sprite to maintain consistency within each stages. style should be determined before creating any sprite for the project to maintain consistency within the game.

    4. **animation and particle/effect
        a) animation style: TBD
        
        b) animation frame rate: TBD
        
        c) particle/effect style: follow the style of other animated objects. TBD
        
        d) particle/effect frame rate: follow the frame rate of other animated objects. TBD. 
                
    5. **Coordinate system: use pixel as unit is recommonded, do not create a tile coordinate system. trust me, i'm an engineer.
                
    6. **Lighting channel
        *detail information would be added latter.
        *further discussion would be required. ideally, each of the direction channels should have at least five different colors representing fire different angle. ie.0, 45, 90, 135, 180 degree.
        a) vertical channel: exact color TBD. represent the vertial directions that the pixel is facing. ie. up and down. 
            -0 degree: TBD
            -45 degree: TBD
            -90 degree: TBD
            -135 degree: TBD
            -180 degree: TBD
        //insert vertical_channel.png here
        
        b) horizontal channel: exact color TBD. represent the horizontal directions that the pixel is facing. ie. left and right. 
            -0 degree: TBD
            -45 degree: TBD
            -90 degree: TBD
            -135 degree: TBD
            -180 degree: TBD
        //insert horizontal_channel.png here
        
        c) fefult color: same color as 90 degree.
        
        c) integration of the two channel: yes for submission. no for file transfer between artists.
        *more infromation in section 9.
        
        *note, the vertical and hroizontal channel should be created on two different layers. the two layer should be combined into one .png file when exporting.
        
    7. **Reflection channel
        *detail information would be added latter.
        a) material: exact color TBD. Different material have different effect of reflection. ie. metal would be more reflective than wood.
            -metal
            -galss
            
        b) no reflection: TBD
        
        *note, the reflection channel should be created on a separate layer. 
            
    8. **Scatter channel
        *detail information would be added latter.
        a) fragment: each color represent a different piece of fragment which would be lauched to a different direction when explode. note, only assign one color to one piece of fragment and do not reuse colors.
        
        b) noise: the minimal acceptable differences between two colors to be identified as different fragments. actually value TBD.
        //insert scatter_channel.png here
        
        c) no scatter: TBD
        
        d) fragment sprite: TBD
        
        *note, the scatter channel should be created on a seprate layer. the fragment sprite should be created as a seprate file.
        
    9. **File format
        a) format conversion between software: it is impossible to convert between different software format. if you must send the sprite to another artist who is using different software, try divide different layer into separate .png files and let the receiver import them into different layers.
        
        b) defult format of sprite sheet submissions: .png, all static sprite sheet should be saved as .png file. use the conversion format for animatied object.
        *further discussion would be required. depends on which way is easier for the coding team to work with. before this format is confirmed, preserve them in software format.
        
        d) animation format: TBD. save them as defult software format for now.
    
    10. **Copyright: ordinary artist borrow, great artist steal. 
        a) loyalty free assets: TBD
        *depends on funding and direction of the art style.
    
    11. **Recommonded software
        Asprite     14.99CAD        (highly recommended as a drawing tool)
        Krita       free            (highly recommended as a image processing tool)
        Piskel      free
        pyxel edit  9.00CAD         (outdated versions are free)
        Photoshop   US$29.99/mo     (just don't, unless you just happened to have a free one by accident)(additional information on how to config PS for pixel art will be added upon request)
        
    12. **the "pixel art guide": contain more detail regarding the creation of pixel art. writen based on asprite and Krita. 
    
3. Game Design/Level Creation
    1. To be added
