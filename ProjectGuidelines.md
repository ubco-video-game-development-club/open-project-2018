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
    **Part I: Basic rule of pxiel art (skip this part entirely if you are a pro)
    1. **Line and shape
        a) Line
            -curve line
                -pixel-perfect: always clean you line to make sure it have perfect strokes. 
                 Do it manually if your sofeware do not support this feature.
                //insert pixel_perfect.png here
            -straight line
                -Diagonal line: always use ratio to make sure the drawing is nice and clean.
                //insert diagonal_line_ratio.png here
                
        b) Shape
            -if generate by tool, always clean manually.
                
        c) Anti-aliasing
            *further discussion would be required, do not use them as for now. they are hard to remove but easy to add.
            //insert anti_aliasing.png here
                
        d) outlining
            *further discussion would be required. 
                
    2. **Shading and lighting
        a) contrast and value: contract should be mantained at a reasonable level where the background, foreground and player can be easily differentiated but not splitted.
        
        b) positive and negative space: a clear relationship between positive and negative space should be maintained to ensure the ease of differentiating background and object.
        
        c) dithering: yes.
            *further discussion would be required. a single style of dithering would be selected for all assets. 
            //insert dithering.png here
            
        d)shading mode: got em use em. it could save you some time, but they are not mandatory.
            
    3. **Color and texture
        a) property of colour: RGB color model is recommended for starter.
        *detail information would be added upon request, you should know these already.
            -Hue (H)
            -Saturation (S)
            -Value (V)
            
        b) alpha (A)
        *further experiment would be required. do not use for now. if you have to use this channel to get the color you want, something has gone horribly wrong. stop it, get some help.
        
        c) color theory: use RGB. it just work.
        *detail information would be added upon request.
        
        d) color harmany: use a color weel. 
            -Complementary harmony: (reduce saturation to maintain balance)
            -monochromatic harmony: (maintain contract when using this method)
            -analogous harmony
            -and more, you are a artist now, do what you want. 
            
        e) color palette
            -Hue shifting: yes. HSL color model is recommended.
            *further discussion would be required. it is not certain if this can be integrated into the lighting system, but it is a good habit to always do it.
            
        f) texture
            -creating texture
            -applying texture to object
            
        g) blend modes: got em use em. it could save you some time, not mandatory.
            
    4. **Tile
        a) tile mode
            -simple tile: add material in the side to connect nearby tile, avoid obvious pattern. 
            
        b) untiy nine slice
        *further discussion would be required. it is a simple built in tool in unity that would do the trick but it does not allow you to edit the tile on the run. 
            -draw mode
                -simple: do not use. not suitable for anything unless you purposely want to trash your texture. 
                -sliced
                    -corner section: does not change size.
                    -vertical secion: stretch horizontally.
                    -hroizontal section: stretch vertically.
                    -middle section: strech both horizontally and vertially.
                -tile
                    -corner section: does not change size.
                    -vertical secion: replicate horizontally.
                    -hroizontal section: replicate vertically.
                    -middle section: replicate both horizontally and vertially.
                    -continuous mode: allow the middle tile to replicate freely.
                    -adaptive mode: only replicate when reach streach value. (does not work well for pixel art)
                    
        c) i am poor and i use windows paint which don't have tile support
            -cutting technique: cut one tile into four part and rearrange them. ie. top left switch with bottom right, top right switch with bottom left. and add material in the middle to hide any obvious pattern.
            
    5. **Background
        *detail information would be added upon request. it is one of the most difficult part, and it it too complex to describe in words.
        -shadow
        -color
        -shape
        -adding reflection: copy the object you want to reflect and flip it in the water / mirror, reduce the opacity and add distortion effect manually. this is the only place you should be using the alpha channel.
        //insert reflection.png here
        
    6. **Character
        *further discussion would be required. a single style would be selected for all character.
    
    7. **Animation
        *further discussion would be required. 
        -onion skin
        -blue/red mode
        -frame tags
        
    8. **Miscellaneous
        -layer
        -background: object should always have a transparent background. in other words, don't draw background for objects.
        -tip and trick for asprite and Krita?
            *further discussion would be required. 
        -data recovery
            
    **Part II: Guideline and standard 
    8. **Sprite sheet standard
        *further discussion would be required. the size and format are highly dependent on the size and the number of the assets.
    
        a) size of the sprite sheet: should be always be multiple of size of the tile. Individual submission should adjust the size according to the size of the object.ie. don't create a 1920* 1080 sprite sheet for a 8* 8 sprite.
        
        b) background for object sprite: no back ground should be included. ie. leave it as transparent. In fact, create a file with transparent background or no background and dont ever add them.
        
        c) dimensions of the object sprite: the length and width of a object should be kept as close as possible to the size of tiles/grid.
        //insert dimension_of_object.png here
        
        d)tile: size of the tile is current TBD. They should be a perfect square with no transparent spots. Follow the rules in session 4 of the first part when creating tile.
        
        e) animation of object: each frame in a animation should be kept in the same sprite sheet and next to each other in the correct order. add discription and numbering if necessary. if your software have automatic conversion, use the conversion.
        //insert animation.png here
        
        f) background: size of the background should be always be multiple of size of the tile. background should not not have any spot that are transparent. Follow the rules in session 2 of the first part when creating background.
        
        g)foreground: size of the foreground should be always be multiple of size of the tile. Follow the rules in session 2 of the first part when creating foreground.
        
        h) Integration of the sprite sheets
            -submission of sprite: the submission of sprite should be in individual files of .png format with an unambiguous file name. note, use "_" instead of spaces in the name. 
            -integration of sprite: communcate with other team and other artist before do any attempt of integrating the sprites sheets. save them in .png format with an unambiguous file name. note, use "_" instead of spaces in the name. Attach a file or include description of necessary.
       
    9. **Lighting channel
        *detail information would be added latter.
        *further discussion would be required. ideally, each of the direction channels should have at least five different colors representing fire different angle. ie.0, 45, 90, 135, 180 degree.
    
        a) vertical channel: color TBD. represent the vertial directions that the pixel is facing. ie. up and down. 
        //insert vertical_channel.png here
        
        b) horizontal channel: color TBD. represent the horizontal directions that the pixel is facing. ie. left and right. 
        //insert horizontal_channel.png here
        

        
    10. **Reflection channel
    *detail information would be added latter.
        a) material: color TBD. Different material have different effect of reflection. ie. metal would be more reflective than wood.
        
    11. **Scatter channel
        *detail information would be added latter.
    
        a) fragment: each color represent a different piece of fragment which would be lauched to a different direction when explode. note, only assign one color to one piece of fragment and do not reuse colors.
        
        a) noise
        //insert scatter_channel.png here
        
    12. **File format
        a) format conversion between software: it is impossible to convert between different software format. if you must send the sprite to another artist who is using different software, try divide different layer into separate .png files and let the receiver import them into different layers.
        
        b) defult format of the project: .png, all final sprite sheet should be saved as .png file. it just work.
        
    13. **Coordinate system: use pixel as unit is recommonded, do not create a tile coordinate system. trust me, i'm an engineer.
    
    14. **General art style: TBD
        *further discussion would be required.
        //insert art_style_example_1.png here
        //insert art_style_example_2.png here
        //insert art_style_example_3.png here
        //insert art_style_example_4.png here
        //insert art_style_example_5.png here
    
    15. **Copyright: ordinary artist borrow, great artist steal. no, wait, don't.
    
    **Recommonded software
    Asprite     14.99CAD
    Krita       free
    Piskel      free
    pyxel edit  9.00CAD (outdated version are free)
    Photoshop   US$29.99/mo (just don't, unless you just happened to have a free one by accident)(additional information on how to config PS for pixel art will be added upon request)
    
3. Game Design/Level Creation
    1. To be added
