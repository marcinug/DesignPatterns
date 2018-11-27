/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package factorybetterthenbuilder.product.factory;

import factorybetterthenbuilder.abstractFactory.AbstractFactory;
import factorybetterthenbuilder.product.Dlc;
import factorybetterthenbuilder.product.Game;
import factorybetterthenbuilder.product.dlcs.Cube;
import factorybetterthenbuilder.product.dlcs.Foil;
import factorybetterthenbuilder.product.dlcs.Sticker;

/**
 *
 * @author Marcin
 */
public class DlcFactory extends AbstractFactory {
    
    @Override
    public Dlc getDlc(String productName) {
        Dlc dlc = null;
        if("Cube".equals(productName)) 
            dlc = new Cube();
        else if("Foil".equals(productName))
            dlc = new Foil();
        else if("Sticker".equals(productName)) 
            dlc = new Sticker();
        else 
            return null;
        return dlc;
    }
    
    @Override
    public Game getGame(String productName) {
        return null;
    }
    
}
