<div align="center">

# BRW API 🎮

</div>


### Purpose 🤔

Rest API to manage championship inside a tiny group of friends, where has prizes, foreign group, different teams inside a group to different championships having n different games.

### TechStack 🧰

In this project are being used the following techs:

- C#
- .Net 6.0
- Entity FrameWork Core/Design/Tools and Postgresql
- Postgresql
- Docker
- Docker Compose
- Makefile

Is planned to use:

- Redis
- JWT
- Media Abstractions
- S3 Bucket or some AWS service that can manage file storage


### Building environment ♻️

Has you can see above, we use makefile to shell scripts, so is way more easy to mount the environment images!

- To mount API and Database you can use:
```zsh
 make -i start
```
_it's valid to remember that in linux environments the api will not works into docker if don't configure to migrate from https to http automatically when the build be made, an feature that exists in windows environments, so, windows should be the best environment to run this project._
- to unmount API and Database you can use:
```zsh
 make -i kill
```


### API endpoits 🛣️

- GET -> /api/user -> get all users;
- GET -> /api/user:{id} -> get user by id;
- POST -> /api/user: -> creates a new user;

<br/>
<br/>
<br/>

<div align="center">
  
project being made by Alan Albuquerque aka [@offpepe](https://github.com/offpepe/), having technical mentoring by Guilherme FGR aka [@Guifgr](https://github.com/Guifgr)
 <br/>
  being made by didactic purposes with the ❤️❤️❤️❤️❤️
  
</div>
