"use strict";

class ModMain {
    constructor() {
        const mod = require("./package.json");
        this.modName = `${mod.author}-${mod.name}`;
        
        Logger.info(`Loading: ${this.modName} : ${mod.version}`);
    }
}

module.exports = new ModMain();