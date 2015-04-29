
using System.Collections.Generic;
using System;
using System.Reflection;
using System.Data;
using UnityEngine;
using Oxide.Core;
using Oxide.Core.Configuration;
using Oxide.Core.Logging;
using Oxide.Core.Plugins;

namespace Oxide.Plugins
{
[Info("CSharpTests", "KillParadise", "1.0.0")]
    class CSharpTests : RustPlugin
    {
    

    void OnServerInitialized()
        {
            command.AddChatCommand("cs", this.Plugin, "runTest");
        }
    void LoadDefaultConfig() { 
    		"options": { //Set options for the permission handler
                "owner": ["newOwner"], //additional owner permissions
                "mod": ["newModPerm"], //additional mod permissions
                "default": ["newDefaultPerm"], //additional default user permissions
                "admin": ["newAdminPerms"], //additional admin permissions
                "donor": ["newDonorPerm", "newSecondPerm"] // additional donor permissions
            },
            "perms": { //single perms to register for your plugin
                "newTest": "canTestNew",
                "singlePerms": "thisIsForSinglePerms"
            },
            "groups": { //groups that need created/registered for your plugin (custom only)
                "group1": { //group name
                    "permission": "customPermGroups", //group permission 
                    "default": false //is this a default group? (recommended set to false)
                }
            },
            "commands": { //Your plugins commands
                "newSingleCmd": { //Command (what is entered by the player in chat)
                    "perms": "cmdPerm" //Permissions required to use the command
                },
                "testing": {
                    "newOwner"
                },
                "newArgCmd": { //Command (what is entered by the player in chat)
                    "args": ["arg1", "arg2"], //since this is a multi argument command we need to check set args
                    "perms": ["permForArg1", "permForArg2"] //permission for each argument THIS IS BASED ON INDEX 
                } //if index 0 = arg1, then index 0 of perms should the permission for that argument
            } //This is for commands like rt from RanksAndTitles /rt set <-- set is arg1 we need a perm
        	 //And arg2 could be stats so in /rt stats <-- stats is arg1 should have a perm if not public.}
}
}