function solve(args) {
    var PX1 = parseInt(args[0]);
    var PY1 = parseInt(args[1]);
    var PX2 = parseInt(args[2]);
    var PY2 = parseInt(args[3]);
    var FX = parseInt(args[4]);
    var FY = parseInt(args[5]);
    var damage = 0;

    if (PX1 > PX2) {
        var temp = PX1;
        PX1 = PX2;
        PX2 = temp;
    }
    if (PY1 < PY2) {
        var temp = PY1;
        PY1 = PY2;
        PY2 = temp;
    }

    FX += parseInt(args[6]);
    if (FX == PX1 && FX == PX2 && FY == PY1 && FY == PY2) damage = 100;
    else if (FX == PX1 - 1 && FY <= PY1 && FY >= PY2) damage = 75;
    else if ((FX >= PX1 && FX <= PX2) && (FY == PY2 - 1 || FY == PY1 + 1)) damage = 50;
    else if ((FX >= PX1 && FX <= PX2 - 1) && (FY == PY2 || FY == PY1)) damage = 225;
    else if (FX == PX2 && (FY == PY1 || FY == PY2)) damage = 150;
    else if (FX == PX2 && (FY <= PY1 - 1 && FY >= PY2 + 1)) damage = 200;
    else if (FX >= PX1 && FX <= PX2 - 1 && FY <= PY1 - 1 && FY >= PY2 + 1) damage = 275;

    return damage + "%";
}