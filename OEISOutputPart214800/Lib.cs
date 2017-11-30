using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A265462
{
public static readonly BigInteger[] Value={ 2L,139L,8812L,398508L,22533687L,1509143496L,90139418667L,5406371366046L,345027685293581L,21781937201310642L,1364248599882667154L,BigInteger.Parse("86845415914930878736"),BigInteger.Parse("5551683807912172844571"),BigInteger.Parse("354345805660601775721536") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265462Inst Instance=new A265462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265463
{
public static readonly BigInteger[] Value={ 9L,765L,121819L,17481072L,2002867877L,274085245804L,40379152013237L,5373739385807564L,728581796514794423L,BigInteger.Parse("103981658100672275539"),BigInteger.Parse("14513136199063765521559"),BigInteger.Parse("2010492476119616897431520") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265463Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265463.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265463Inst Instance=new A265463Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265464
{
public static readonly BigInteger[] Value={ 29L,6221L,1630672L,593770274L,176223025171L,49094408347776L,15984824483462062L,5061676810415781351L,BigInteger.Parse("1503116899340714064889"),BigInteger.Parse("468413834308033595967513"),BigInteger.Parse("148642613025573311878074113"),BigInteger.Parse("45805757997648999357622452961") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265464Inst Instance=new A265464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265465
{
public static readonly BigInteger[] Value={ 79L,46898L,25855219L,18032679492L,14031585901207L,9188739329021395L,6109458550119472926L,BigInteger.Parse("4497609382425392134864"),BigInteger.Parse("3129522404719291576574593"),BigInteger.Parse("2108536407604745793629208440"),BigInteger.Parse("1492937943783342517758330275744") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265465Inst Instance=new A265465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265466
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,2L,26L,18L,16L,9L,139L,550L,232L,125L,29L,765L,8812L,9808L,2764L,1296L,79L,6221L,121819L,398508L,290140L,34471L,16807L,220L,46898L,1630672L,17481072L,22533687L,8526762L,448920L,262144L,673L,292690L,25855219L,593770274L,2002867877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265466Inst : IEnumerable<long>
{
public static readonly long[] Value=A265466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265466.Bytes);
public long this[int i]=>Value[i];

public static A265466Inst Instance=new A265466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265467
{
public static readonly long[] Value={ 1L,3L,26L,139L,765L,6221L,46898L,292690L,1722770L,10915890L,73213113L,480069015L,3032127834L,19084607287L,122424984026L,792495253960L,5097255978957L,32562226190102L,208268070296589L,1338186393004984L,8611472163134863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265467Inst : IEnumerable<long>
{
public static readonly long[] Value=A265467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265467.Bytes);
public long this[int i]=>Value[i];

public static A265467Inst Instance=new A265467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265468
{
public static readonly long[] Value={ 3L,18L,550L,8812L,121819L,1630672L,25855219L,424583341L,6156035722L,81100545451L,1085691306969L,15448761192453L,220590548331594L,3019299007029137L,40274017206212359L,543481982379488630L,7470599265675871603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265468Inst : IEnumerable<long>
{
public static readonly long[] Value=A265468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265468.Bytes);
public long this[int i]=>Value[i];

public static A265468Inst Instance=new A265468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265469
{
public static readonly BigInteger[] Value={ 16L,232L,9808L,398508L,17481072L,593770274L,18032679492L,582513489941L,20195132214242L,664241150437850L,19904753690273680L,578485017566375562L,17470345171228192441UL,BigInteger.Parse("541176178303872764969"),BigInteger.Parse("16319402667685554635137") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265469Inst Instance=new A265469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265470
{
public static readonly BigInteger[] Value={ 125L,2764L,290140L,22533687L,2002867877L,176223025171L,14031585901207L,982335169173608L,67632927650356131L,4930666504007626924L,BigInteger.Parse("359381248044546056906"),BigInteger.Parse("24470589601229482555646"),BigInteger.Parse("1578712921429768156705587") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265470Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265470.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265470Inst Instance=new A265470Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265471
{
public static readonly BigInteger[] Value={ 1296L,34471L,8526762L,1509143496L,274085245804L,49094408347776L,9188739329021395L,1624899736795288912L,BigInteger.Parse("260045213960744141272"),BigInteger.Parse("39463502021937022362068"),BigInteger.Parse("6138613302691608422094776") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265471Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265471.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265471Inst Instance=new A265471Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265472
{
public static readonly BigInteger[] Value={ 16807L,448920L,226627855L,90139418667L,40379152013237L,15984824483462062L,6109458550119472926L,BigInteger.Parse("2389935645198640348518"),BigInteger.Parse("930872824490636727708065"),BigInteger.Parse("338013705923361717540139746") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265472Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265472.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265472Inst Instance=new A265472Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265473
{
public static readonly BigInteger[] Value={ 1L,6L,1376L,1211112L,4131348480L,49965944917500L,2284546587678218240L,BigInteger.Parse("399352031269643676301056") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265473Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265473.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265473Inst Instance=new A265473Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265474
{
public static readonly long[] Value={ 1L,6L,36L,366L,4900L,55800L,970225L,11095448L,204833344L,1934752250L,44951208289L,364393934784L,10048532283364L,66162689956152L,2276670647380900L,12030558414011074L,521323759854121156L,2167321703073344910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265474Inst : IEnumerable<long>
{
public static readonly long[] Value=A265474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265474.Bytes);
public long this[int i]=>Value[i];

public static A265474Inst Instance=new A265474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265475
{
public static readonly BigInteger[] Value={ 3L,36L,1376L,32400L,498520L,26904969L,316565600L,26305920481L,304772051268L,27374995980544L,192909846708080L,29538240252689476L,160040330438580826L,BigInteger.Parse("32757366213429455376"),BigInteger.Parse("117782464124635833042"),BigInteger.Parse("37046871094548366652225") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265475Inst Instance=new A265475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265476
{
public static readonly BigInteger[] Value={ 16L,366L,32400L,1211112L,128323584L,3120703104L,589329511684L,6424959359808L,3010884585054784L,30416313423877920L,16127828989578410896UL,BigInteger.Parse("78450302166015801792"),BigInteger.Parse("89417580553113361553664"),BigInteger.Parse("268486460625576403793312") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265476Inst Instance=new A265476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265477
{
public static readonly BigInteger[] Value={ 125L,4900L,498520L,128323584L,4131348480L,3136398496144L,63552226862294L,83329856800206769L,483221758595102972L,BigInteger.Parse("2349207562860745230400"),BigInteger.Parse("10865276340207974040000"),BigInteger.Parse("68734768761934621856452804") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265477Inst Instance=new A265477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265478
{
public static readonly BigInteger[] Value={ 1296L,55800L,26904969L,3120703104L,3136398496144L,49965944917500L,425344798130083225L,4918894172251971312L,BigInteger.Parse("62965804516721136661761"),BigInteger.Parse("155351908647389059328938"),BigInteger.Parse("9803953386543658217431739044") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265478Inst Instance=new A265478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265479
{
public static readonly long[] Value={ 16807L,970225L,316565600L,589329511684L,63552226862294L,425344798130083225L,2284546587678218240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265479Inst : IEnumerable<long>
{
public static readonly long[] Value=A265479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265479.Bytes);
public long this[int i]=>Value[i];

public static A265479Inst Instance=new A265479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265480
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,3L,16L,36L,36L,16L,125L,366L,1376L,366L,125L,1296L,4900L,32400L,32400L,4900L,1296L,16807L,55800L,498520L,1211112L,498520L,55800L,16807L,262144L,970225L,26904969L,128323584L,128323584L,26904969L,970225L,262144L,4782969L,11095448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265480Inst : IEnumerable<long>
{
public static readonly long[] Value=A265480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265480.Bytes);
public long this[int i]=>Value[i];

public static A265480Inst Instance=new A265480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265481
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,20L,35L,36L,140L,523L,1170L,1731L,1842L,3727L,3886L,9270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265481Inst : IEnumerable<long>
{
public static readonly long[] Value=A265481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265481.Bytes);
public long this[int i]=>Value[i];

public static A265481Inst Instance=new A265481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265482
{
public static readonly long[] Value={ 1L,2L,5L,9L,19L,25L,54L,104L,112L,120L,177L,317L,504L,540L,734L,780L,1649L,1923L,2715L,4308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265482Inst : IEnumerable<long>
{
public static readonly long[] Value=A265482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265482.Bytes);
public long this[int i]=>Value[i];

public static A265482Inst Instance=new A265482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265483
{
public static readonly long[] Value={ 1L,2L,4L,15L,16L,24L,57L,206L,284L,1290L,1722L,1862L,1866L,3271L,5306L,5474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265483Inst : IEnumerable<long>
{
public static readonly long[] Value=A265483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265483.Bytes);
public long this[int i]=>Value[i];

public static A265483Inst Instance=new A265483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265484
{
public static readonly long[] Value={ 1L,2L,3L,4L,24L,63L,81L,92L,165L,232L,236L,591L,669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265484Inst : IEnumerable<long>
{
public static readonly long[] Value=A265484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265484.Bytes);
public long this[int i]=>Value[i];

public static A265484Inst Instance=new A265484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265485
{
public static readonly long[] Value={ 1L,2L,12L,14L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265485Inst : IEnumerable<long>
{
public static readonly long[] Value=A265485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265485.Bytes);
public long this[int i]=>Value[i];

public static A265485Inst Instance=new A265485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265486
{
public static readonly long[] Value={ 3L,6L,15L,19L,36L,75L,80L,118L,199L,336L,360L,520L,1282L,1810L,2872L,4870L,14467L,15102L,22499L,24675L,45615L,105648L,116432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265486Inst : IEnumerable<long>
{
public static readonly long[] Value=A265486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265486.Bytes);
public long this[int i]=>Value[i];

public static A265486Inst Instance=new A265486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265487
{
public static readonly long[] Value={ 1L,3L,10L,18L,70L,585L,921L,1943L,4635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265487Inst : IEnumerable<long>
{
public static readonly long[] Value=A265487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265487.Bytes);
public long this[int i]=>Value[i];

public static A265487Inst Instance=new A265487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265488
{
public static readonly BigInteger[] Value={ 1L,12L,1030L,298764L,83948008L,22511356876L,10087240306899L,3527678938392395L,1384849739444093464L,BigInteger.Parse("509526476766763110063"),BigInteger.Parse("197694082692466208850553"),BigInteger.Parse("132949897804861666617140704"),BigInteger.Parse("58944850608913545191419115404") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265488Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265488.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265488Inst Instance=new A265488Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265489
{
public static readonly BigInteger[] Value={ 1L,0L,36L,0L,0L,2506L,294152L,0L,19516777L,83909226L,0L,10678005713L,545032909689L,0L,102275177508104L,395694498744634L,0L,81469369938066316L,2375486573786293387L,0L,BigInteger.Parse("404350295447676882458"),BigInteger.Parse("3081651598084594364137"),0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265489Inst Instance=new A265489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265490
{
public static readonly BigInteger[] Value={ 2L,12L,0L,0L,0L,3249L,595253L,11022848L,504744595L,21040741278L,340492634409L,7110814430179L,459653526742074L,4437542161639049L,105508629834995631L,5522222536138626811L,BigInteger.Parse("126913917889878003282"),BigInteger.Parse("2918377646811870525109") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265490Inst Instance=new A265490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265491
{
public static readonly BigInteger[] Value={ 16L,0L,949287922L,1252731688676L,BigInteger.Parse("34672286157546211045"),BigInteger.Parse("34196998281381835852332"),BigInteger.Parse("68224345875172740226237806550"),BigInteger.Parse("945856026152994039469803835728611") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265491Inst Instance=new A265491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265492
{
public static readonly BigInteger[] Value={ 79L,0L,2506L,3249L,0L,7928582L,223328748L,0L,1549060833483L,39333115954893L,0L,2109288411348207682L,BigInteger.Parse("326185610259705685656"),0L,BigInteger.Parse("3328201162998337468944458"),BigInteger.Parse("312377463730842740280530334"),0L,BigInteger.Parse("2511537812294356287514629641154") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265492Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265492.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265492Inst Instance=new A265492Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265493
{
public static readonly long[] Value={ 456L,1030L,294152L,595253L,949287922L,223328748L,316185648156135L,121504746202L,15215491198062021L,145636281907673112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265493Inst : IEnumerable<long>
{
public static readonly long[] Value=A265493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265493.Bytes);
public long this[int i]=>Value[i];

public static A265493Inst Instance=new A265493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265494
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,2L,0L,0L,2L,16L,12L,36L,12L,16L,79L,0L,0L,0L,0L,79L,456L,0L,0L,0L,0L,0L,456L,2194L,1030L,2506L,0L,0L,2506L,1030L,2194L,20801L,0L,294152L,3249L,0L,3249L,294152L,0L,20801L,142675L,0L,0L,595253L,0L,0L,595253L,0L,0L,142675L,1104671L,298764L,19516777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265494Inst : IEnumerable<long>
{
public static readonly long[] Value=A265494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265494.Bytes);
public long this[int i]=>Value[i];

public static A265494Inst Instance=new A265494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265495
{
public static readonly long[] Value={ 1L,2L,7L,6L,14L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265495Inst : IEnumerable<long>
{
public static readonly long[] Value=A265495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265495.Bytes);
public long this[int i]=>Value[i];

public static A265495Inst Instance=new A265495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265496
{
public static readonly BigInteger[] Value={ 1L,2L,3L,1L,3L,3L,6L,3L,18L,6L,24L,18L,432L,24L,456L,432L,196992L,456L,197448L,196992L,38895676416L,197448L,38895873864L,38895676416L,BigInteger.Parse("1512881323731695591424"),38895873864L,BigInteger.Parse("1512881323770591465288"),BigInteger.Parse("1512881323731695591424"),BigInteger.Parse("2288809899755012359448064967916189926490112") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265496Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265496.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265496Inst Instance=new A265496Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265497
{
public static readonly long[] Value={ 1L,103L,190L,289L,460L,483L,511L,534L,651L,793L,820L,880L,901L,939L,945L,958L,1045L,1168L,1195L,1198L,1216L,1374L,1408L,1479L,1489L,1500L,1521L,1534L,1539L,1569L,1599L,1623L,1630L,1671L,1678L,1875L,1938L,1939L,1963L,1996L,2028L,2136L,2140L,2166L,2179L,2289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265497Inst : IEnumerable<long>
{
public static readonly long[] Value=A265497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265497.Bytes);
public long this[int i]=>Value[i];

public static A265497Inst Instance=new A265497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265498
{
public static readonly long[] Value={ 1L,1362L,1756L,1905L,2337L,2707L,2902L,2997L,3487L,3492L,3787L,3879L,4045L,4266L,4374L,4680L,5106L,5691L,5766L,6321L,6352L,6585L,6819L,7056L,7099L,7162L,7470L,7627L,8055L,8061L,8121L,8499L,8511L,8785L,8865L,9432L,9636L,9876L,10116L,10389L,10629L,10752L,11262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265498Inst : IEnumerable<long>
{
public static readonly long[] Value=A265498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265498.Bytes);
public long this[int i]=>Value[i];

public static A265498Inst Instance=new A265498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265499
{
public static readonly long[] Value={ 1L,226L,273L,544L,675L,961L,1380L,1968L,2155L,2193L,2596L,3481L,3774L,4074L,4513L,4674L,4866L,4899L,5004L,5418L,5421L,5536L,5815L,5949L,6159L,6249L,6390L,6523L,6526L,6543L,7230L,7281L,7645L,7699L,7968L,8473L,8518L,8724L,8763L,8871L,9519L,9780L,9805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265499Inst : IEnumerable<long>
{
public static readonly long[] Value=A265499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265499.Bytes);
public long this[int i]=>Value[i];

public static A265499Inst Instance=new A265499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265500
{
public static readonly long[] Value={ 1L,2L,7L,21L,52L,167L,501L,1503L,4509L,13527L,40581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265500Inst : IEnumerable<long>
{
public static readonly long[] Value=A265500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265500.Bytes);
public long this[int i]=>Value[i];

public static A265500Inst Instance=new A265500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265501
{
public static readonly long[] Value={ 1L,2L,6L,30L,42L,66L,78L,210L,330L,390L,462L,510L,546L,570L,690L,714L,798L,858L,870L,930L,966L,1110L,1122L,1218L,1230L,1254L,1290L,1302L,1326L,1410L,1482L,1518L,1554L,1590L,1722L,1770L,1794L,1806L,1830L,1914L,1974L,2010L,2046L,2130L,2190L,2226L,2262L,2310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265501Inst : IEnumerable<long>
{
public static readonly long[] Value=A265501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265501.Bytes);
public long this[int i]=>Value[i];

public static A265501Inst Instance=new A265501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265502
{
public static readonly long[] Value={ 1L,139L,433L,1563L,2095L,2254L,2871L,3751L,4003L,4338L,4843L,6015L,6331L,6933L,7324L,7345L,7485L,7719L,7836L,8070L,8413L,9018L,9840L,9898L,9915L,9931L,10611L,11215L,11356L,11418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265502Inst : IEnumerable<long>
{
public static readonly long[] Value=A265502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265502.Bytes);
public long this[int i]=>Value[i];

public static A265502Inst Instance=new A265502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265503
{
public static readonly long[] Value={ 1L,13L,553L,861L,1983L,2065L,2403L,4371L,6226L,6553L,6580L,10128L,10998L,11193L,12411L,12598L,12909L,13056L,13194L,13399L,14589L,15829L,18429L,18436L,19315L,19900L,21574L,23599L,24006L,24024L,24415L,25704L,27225L,27651L,28689L,29461L,29805L,29868L,31143L,31186L,32674L,33706L,34306L,35016L,36118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265503Inst : IEnumerable<long>
{
public static readonly long[] Value=A265503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265503.Bytes);
public long this[int i]=>Value[i];

public static A265503Inst Instance=new A265503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265504
{
public static readonly long[] Value={ 1L,1144L,4027L,7485L,9039L,9940L,11286L,11781L,13095L,13236L,13869L,14124L,14764L,16630L,18075L,18795L,19284L,20797L,21436L,22696L,23904L,25297L,25419L,27391L,27564L,28146L,28392L,29865L,30624L,31087L,31137L,31369L,33286L,33724L,33741L,34609L,34837L,35034L,37047L,37075L,39564L,39910L,41181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265504Inst : IEnumerable<long>
{
public static readonly long[] Value=A265504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265504.Bytes);
public long this[int i]=>Value[i];

public static A265504Inst Instance=new A265504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265505
{
public static readonly long[] Value={ 1L,25L,36L,81L,246L,273L,358L,378L,595L,658L,684L,703L,706L,739L,759L,883L,909L,958L,963L,970L,991L,1014L,1054L,1138L,1189L,1200L,1209L,1356L,1359L,1476L,1488L,1534L,1554L,1590L,1594L,1684L,1695L,1719L,1785L,1791L,1858L,1929L,2008L,2094L,2103L,2115L,2146L,2224L,2229L,2266L,2278L,2283L,2313L,2325L,2380L,2388L,2401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265505Inst : IEnumerable<long>
{
public static readonly long[] Value=A265505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265505.Bytes);
public long this[int i]=>Value[i];

public static A265505Inst Instance=new A265505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265506
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,6L,10L,15L,21L,35L,54L,75L,115L,161L,238L,349L,486L,673L,972L,1323L,1840L,2562L,3478L,4711L,6407L,8624L,11533L,15502L,20574L,27194L,36030L,47320L,61833L,81139L,105286L,136845L,177369L,228563L,293787L,377803L,483090L,616546L,785925L,997987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265506Inst : IEnumerable<long>
{
public static readonly long[] Value=A265506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265506.Bytes);
public long this[int i]=>Value[i];

public static A265506Inst Instance=new A265506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265507
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,0L,1L,0L,5L,0L,0L,2L,0L,4L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,8L,0L,1L,0L,9L,0L,10L,0L,2L,0L,8L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,13L,0L,0L,1L,0L,13L,0L,36L,0L,0L,3L,0L,23L,0L,24L,0L,0L,3L,0L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265507Inst : IEnumerable<long>
{
public static readonly long[] Value=A265507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265507.Bytes);
public long this[int i]=>Value[i];

public static A265507Inst Instance=new A265507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265508
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,3L,5L,10L,15L,29L,42L,68L,109L,162L,240L,364L,527L,749L,1096L,1529L,2162L,3026L,4179L,5702L,7926L,10650L,14412L,19437L,26042L,34560L,46077L,60617L,79893L,104850L,136851L,177884L,231526L,298868L,385221L,496159L,635725L,812342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265508Inst : IEnumerable<long>
{
public static readonly long[] Value=A265508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265508.Bytes);
public long this[int i]=>Value[i];

public static A265508Inst Instance=new A265508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265509
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,9L,9L,15L,17L,17L,21L,21L,17L,27L,21L,31L,33L,33L,33L,33L,33L,33L,45L,45L,33L,51L,33L,51L,33L,51L,45L,63L,65L,65L,65L,65L,73L,73L,73L,73L,65L,65L,85L,85L,73L,73L,93L,93L,65L,99L,65L,99L,73L,107L,73L,107L,65L,99L,85L,119L,73L,107L,93L,127L,129L,129L,129L,129L,129L,129L,129L,129L,129L,129L,129L,129L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265509Inst : IEnumerable<long>
{
public static readonly long[] Value=A265509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265509.Bytes);
public long this[int i]=>Value[i];

public static A265509Inst Instance=new A265509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265510
{
public static readonly long[] Value={ 1L,11L,101L,111L,1001L,1001L,1001L,1111L,10001L,10001L,10101L,10101L,10001L,11011L,10101L,11111L,100001L,100001L,100001L,100001L,100001L,100001L,101101L,101101L,100001L,110011L,100001L,110011L,100001L,110011L,101101L,111111L,1000001L,1000001L,1000001L,1000001L,1001001L,1001001L,1001001L,1001001L,1000001L,1000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265510Inst : IEnumerable<long>
{
public static readonly long[] Value=A265510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265510.Bytes);
public long this[int i]=>Value[i];

public static A265510Inst Instance=new A265510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265511
{
public static readonly long[] Value={ 0L,1L,2L,0L,4L,4L,0L,4L,8L,0L,10L,10L,0L,13L,13L,0L,16L,16L,0L,10L,20L,0L,13L,23L,0L,16L,26L,0L,28L,28L,0L,28L,28L,0L,28L,28L,0L,28L,28L,0L,40L,40L,0L,40L,40L,0L,28L,28L,0L,40L,40L,0L,52L,52L,0L,28L,56L,0L,28L,56L,0L,28L,56L,0L,28L,56L,0L,40L,68L,0L,40L,68L,0L,28L,56L,0L,40L,68L,0L,52L,80L,0L,82L,82L,0L,82L,82L,0L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265511Inst : IEnumerable<long>
{
public static readonly long[] Value=A265511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265511.Bytes);
public long this[int i]=>Value[i];

public static A265511Inst Instance=new A265511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265512
{
public static readonly long[] Value={ 0L,1L,2L,0L,11L,11L,0L,11L,22L,0L,101L,101L,0L,111L,111L,0L,121L,121L,0L,101L,202L,0L,111L,212L,0L,121L,222L,0L,1001L,1001L,0L,1001L,1001L,0L,1001L,1001L,0L,1001L,1001L,0L,1111L,1111L,0L,1111L,1111L,0L,1001L,1001L,0L,1111L,1111L,0L,1221L,1221L,0L,1001L,2002L,0L,1001L,2002L,0L,1001L,2002L,0L,1001L,2002L,0L,1111L,2112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265512Inst : IEnumerable<long>
{
public static readonly long[] Value=A265512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265512.Bytes);
public long this[int i]=>Value[i];

public static A265512Inst Instance=new A265512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265513
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,5L,5L,5L,0L,5L,10L,10L,0L,5L,10L,15L,0L,17L,17L,17L,0L,21L,21L,21L,0L,25L,25L,25L,0L,29L,29L,29L,0L,17L,34L,34L,0L,21L,38L,38L,0L,25L,42L,42L,0L,29L,46L,46L,0L,17L,34L,51L,0L,21L,38L,55L,0L,25L,42L,59L,0L,29L,46L,63L,0L,65L,65L,65L,0L,65L,65L,65L,0L,65L,65L,65L,0L,65L,65L,65L,0L,65L,65L,65L,0L,85L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265513Inst : IEnumerable<long>
{
public static readonly long[] Value=A265513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265513.Bytes);
public long this[int i]=>Value[i];

public static A265513Inst Instance=new A265513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265514
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,11L,11L,11L,0L,11L,22L,22L,0L,11L,22L,33L,0L,101L,101L,101L,0L,111L,111L,111L,0L,121L,121L,121L,0L,131L,131L,131L,0L,101L,202L,202L,0L,111L,212L,212L,0L,121L,222L,222L,0L,131L,232L,232L,0L,101L,202L,303L,0L,111L,212L,313L,0L,121L,222L,323L,0L,131L,232L,333L,0L,1001L,1001L,1001L,0L,1001L,1001L,1001L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265514Inst : IEnumerable<long>
{
public static readonly long[] Value=A265514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265514.Bytes);
public long this[int i]=>Value[i];

public static A265514Inst Instance=new A265514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265515
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,0L,6L,6L,6L,6L,0L,6L,12L,12L,12L,0L,6L,12L,18L,18L,0L,6L,12L,18L,24L,0L,26L,26L,26L,26L,0L,31L,31L,31L,31L,0L,36L,36L,36L,36L,0L,41L,41L,41L,41L,0L,46L,46L,46L,46L,0L,26L,52L,52L,52L,0L,31L,57L,57L,57L,0L,36L,62L,62L,62L,0L,41L,67L,67L,67L,0L,46L,72L,72L,72L,0L,26L,52L,78L,78L,0L,31L,57L,83L,83L,0L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265515Inst : IEnumerable<long>
{
public static readonly long[] Value=A265515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265515.Bytes);
public long this[int i]=>Value[i];

public static A265515Inst Instance=new A265515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265516
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,0L,11L,11L,11L,11L,0L,11L,22L,22L,22L,0L,11L,22L,33L,33L,0L,11L,22L,33L,44L,0L,101L,101L,101L,101L,0L,111L,111L,111L,111L,0L,121L,121L,121L,121L,0L,131L,131L,131L,131L,0L,141L,141L,141L,141L,0L,101L,202L,202L,202L,0L,111L,212L,212L,212L,0L,121L,222L,222L,222L,0L,131L,232L,232L,232L,0L,141L,242L,242L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265516Inst : IEnumerable<long>
{
public static readonly long[] Value=A265516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265516.Bytes);
public long this[int i]=>Value[i];

public static A265516Inst Instance=new A265516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265517
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,0L,7L,7L,7L,7L,7L,0L,7L,14L,14L,14L,14L,0L,7L,14L,21L,21L,21L,0L,7L,14L,21L,28L,28L,0L,7L,14L,21L,28L,35L,0L,37L,37L,37L,37L,37L,0L,43L,43L,43L,43L,43L,0L,49L,49L,49L,49L,49L,0L,55L,55L,55L,55L,55L,0L,61L,61L,61L,61L,61L,0L,67L,67L,67L,67L,67L,0L,37L,74L,74L,74L,74L,0L,43L,80L,80L,80L,80L,0L,49L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265517Inst : IEnumerable<long>
{
public static readonly long[] Value=A265517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265517.Bytes);
public long this[int i]=>Value[i];

public static A265517Inst Instance=new A265517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265518
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,0L,11L,11L,11L,11L,11L,0L,11L,22L,22L,22L,22L,0L,11L,22L,33L,33L,33L,0L,11L,22L,33L,44L,44L,0L,11L,22L,33L,44L,55L,0L,101L,101L,101L,101L,101L,0L,111L,111L,111L,111L,111L,0L,121L,121L,121L,121L,121L,0L,131L,131L,131L,131L,131L,0L,141L,141L,141L,141L,141L,0L,151L,151L,151L,151L,151L,0L,101L,202L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265518Inst : IEnumerable<long>
{
public static readonly long[] Value=A265518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265518.Bytes);
public long this[int i]=>Value[i];

public static A265518Inst Instance=new A265518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265519
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,0L,8L,8L,8L,8L,8L,8L,0L,8L,16L,16L,16L,16L,16L,0L,8L,16L,24L,24L,24L,24L,0L,8L,16L,24L,32L,32L,32L,0L,8L,16L,24L,32L,40L,40L,0L,8L,16L,24L,32L,40L,48L,0L,50L,50L,50L,50L,50L,50L,0L,57L,57L,57L,57L,57L,57L,0L,64L,64L,64L,64L,64L,64L,0L,71L,71L,71L,71L,71L,71L,0L,78L,78L,78L,78L,78L,78L,0L,85L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265519Inst : IEnumerable<long>
{
public static readonly long[] Value=A265519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265519.Bytes);
public long this[int i]=>Value[i];

public static A265519Inst Instance=new A265519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265520
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,0L,11L,11L,11L,11L,11L,11L,0L,11L,22L,22L,22L,22L,22L,0L,11L,22L,33L,33L,33L,33L,0L,11L,22L,33L,44L,44L,44L,0L,11L,22L,33L,44L,55L,55L,0L,11L,22L,33L,44L,55L,66L,0L,101L,101L,101L,101L,101L,101L,0L,111L,111L,111L,111L,111L,111L,0L,121L,121L,121L,121L,121L,121L,0L,131L,131L,131L,131L,131L,131L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265520Inst : IEnumerable<long>
{
public static readonly long[] Value=A265520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265520.Bytes);
public long this[int i]=>Value[i];

public static A265520Inst Instance=new A265520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265521
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,0L,9L,9L,9L,9L,9L,9L,9L,0L,9L,18L,18L,18L,18L,18L,18L,0L,9L,18L,27L,27L,27L,27L,27L,0L,9L,18L,27L,36L,36L,36L,36L,0L,9L,18L,27L,36L,45L,45L,45L,0L,9L,18L,27L,36L,45L,54L,54L,0L,9L,18L,27L,36L,45L,54L,63L,0L,65L,65L,65L,65L,65L,65L,65L,0L,73L,73L,73L,73L,73L,73L,73L,0L,81L,81L,81L,81L,81L,81L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265521Inst : IEnumerable<long>
{
public static readonly long[] Value=A265521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265521.Bytes);
public long this[int i]=>Value[i];

public static A265521Inst Instance=new A265521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265522
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,0L,11L,11L,11L,11L,11L,11L,11L,0L,11L,22L,22L,22L,22L,22L,22L,0L,11L,22L,33L,33L,33L,33L,33L,0L,11L,22L,33L,44L,44L,44L,44L,0L,11L,22L,33L,44L,55L,55L,55L,0L,11L,22L,33L,44L,55L,66L,66L,0L,11L,22L,33L,44L,55L,66L,77L,0L,101L,101L,101L,101L,101L,101L,101L,0L,111L,111L,111L,111L,111L,111L,111L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265522Inst : IEnumerable<long>
{
public static readonly long[] Value=A265522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265522.Bytes);
public long this[int i]=>Value[i];

public static A265522Inst Instance=new A265522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265523
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,10L,10L,10L,10L,10L,10L,10L,10L,0L,10L,20L,20L,20L,20L,20L,20L,20L,0L,10L,20L,30L,30L,30L,30L,30L,30L,0L,10L,20L,30L,40L,40L,40L,40L,40L,0L,10L,20L,30L,40L,50L,50L,50L,50L,0L,10L,20L,30L,40L,50L,60L,60L,60L,0L,10L,20L,30L,40L,50L,60L,70L,70L,0L,10L,20L,30L,40L,50L,60L,70L,80L,0L,82L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265523Inst : IEnumerable<long>
{
public static readonly long[] Value=A265523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265523.Bytes);
public long this[int i]=>Value[i];

public static A265523Inst Instance=new A265523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265524
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,11L,11L,11L,11L,11L,11L,11L,11L,0L,11L,22L,22L,22L,22L,22L,22L,22L,0L,11L,22L,33L,33L,33L,33L,33L,33L,0L,11L,22L,33L,44L,44L,44L,44L,44L,0L,11L,22L,33L,44L,55L,55L,55L,55L,0L,11L,22L,33L,44L,55L,66L,66L,66L,0L,11L,22L,33L,44L,55L,66L,77L,77L,0L,11L,22L,33L,44L,55L,66L,77L,88L,0L,101L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265524Inst : IEnumerable<long>
{
public static readonly long[] Value=A265524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265524.Bytes);
public long this[int i]=>Value[i];

public static A265524Inst Instance=new A265524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265525
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,11L,11L,11L,11L,11L,11L,11L,11L,11L,0L,11L,22L,22L,22L,22L,22L,22L,22L,22L,0L,11L,22L,33L,33L,33L,33L,33L,33L,33L,0L,11L,22L,33L,44L,44L,44L,44L,44L,44L,0L,11L,22L,33L,44L,55L,55L,55L,55L,55L,0L,11L,22L,33L,44L,55L,66L,66L,66L,66L,0L,11L,22L,33L,44L,55L,66L,77L,77L,77L,0L,11L,22L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265525Inst : IEnumerable<long>
{
public static readonly long[] Value=A265525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265525.Bytes);
public long this[int i]=>Value[i];

public static A265525Inst Instance=new A265525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265526
{
public static readonly long[] Value={ 0L,1L,1L,11L,11L,101L,101L,111L,111L,1001L,1001L,1001L,1001L,1001L,1001L,1111L,1111L,10001L,10001L,10001L,10001L,10101L,10101L,10101L,10101L,10101L,10101L,11011L,11011L,11011L,11011L,11111L,11111L,100001L,100001L,100001L,100001L,100001L,100001L,100001L,100001L,100001L,100001L,100001L,100001L,101101L,101101L,101101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265526Inst : IEnumerable<long>
{
public static readonly long[] Value=A265526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265526.Bytes);
public long this[int i]=>Value[i];

public static A265526Inst Instance=new A265526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265527
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,9L,9L,9L,15L,17L,17L,21L,21L,21L,27L,27L,31L,33L,33L,33L,33L,33L,33L,45L,45L,45L,51L,51L,51L,51L,51L,51L,63L,65L,65L,65L,65L,73L,73L,73L,73L,73L,73L,85L,85L,85L,85L,93L,93L,93L,99L,99L,99L,99L,107L,107L,107L,107L,107L,107L,119L,119L,119L,119L,127L,129L,129L,129L,129L,129L,129L,129L,129L,129L,129L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265527Inst : IEnumerable<long>
{
public static readonly long[] Value=A265527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265527.Bytes);
public long this[int i]=>Value[i];

public static A265527Inst Instance=new A265527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265528
{
public static readonly long[] Value={ 0L,1L,11L,101L,111L,1001L,1001L,1001L,1111L,10001L,10001L,10101L,10101L,10101L,11011L,11011L,11111L,100001L,100001L,100001L,100001L,100001L,100001L,101101L,101101L,101101L,110011L,110011L,110011L,110011L,110011L,110011L,111111L,1000001L,1000001L,1000001L,1000001L,1001001L,1001001L,1001001L,1001001L,1001001L,1001001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265528Inst : IEnumerable<long>
{
public static readonly long[] Value=A265528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265528.Bytes);
public long this[int i]=>Value[i];

public static A265528Inst Instance=new A265528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265529
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,4L,4L,4L,8L,8L,10L,10L,10L,13L,13L,13L,16L,16L,16L,16L,20L,20L,20L,23L,23L,23L,26L,26L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,52L,52L,52L,52L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,68L,68L,68L,68L,68L,68L,68L,68L,68L,68L,68L,68L,80L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265529Inst : IEnumerable<long>
{
public static readonly long[] Value=A265529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265529.Bytes);
public long this[int i]=>Value[i];

public static A265529Inst Instance=new A265529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265530
{
public static readonly long[] Value={ 0L,1L,2L,2L,11L,11L,11L,11L,22L,22L,101L,101L,101L,111L,111L,111L,121L,121L,121L,121L,202L,202L,202L,212L,212L,212L,222L,222L,1001L,1001L,1001L,1001L,1001L,1001L,1001L,1001L,1001L,1001L,1001L,1001L,1111L,1111L,1111L,1111L,1111L,1111L,1111L,1111L,1111L,1111L,1111L,1111L,1221L,1221L,1221L,1221L,2002L,2002L,2002L,2002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265530Inst : IEnumerable<long>
{
public static readonly long[] Value=A265530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265530.Bytes);
public long this[int i]=>Value[i];

public static A265530Inst Instance=new A265530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265531
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,5L,5L,5L,5L,5L,10L,10L,10L,10L,10L,15L,15L,17L,17L,17L,17L,21L,21L,21L,21L,25L,25L,25L,25L,29L,29L,29L,29L,29L,34L,34L,34L,34L,38L,38L,38L,38L,42L,42L,42L,42L,46L,46L,46L,46L,46L,51L,51L,51L,51L,55L,55L,55L,55L,59L,59L,59L,59L,63L,63L,65L,65L,65L,65L,65L,65L,65L,65L,65L,65L,65L,65L,65L,65L,65L,65L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265531Inst : IEnumerable<long>
{
public static readonly long[] Value=A265531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265531.Bytes);
public long this[int i]=>Value[i];

public static A265531Inst Instance=new A265531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265532
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,11L,11L,11L,11L,11L,22L,22L,22L,22L,22L,33L,33L,101L,101L,101L,101L,111L,111L,111L,111L,121L,121L,121L,121L,131L,131L,131L,131L,131L,202L,202L,202L,202L,212L,212L,212L,212L,222L,222L,222L,222L,232L,232L,232L,232L,232L,303L,303L,303L,303L,313L,313L,313L,313L,323L,323L,323L,323L,333L,333L,1001L,1001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265532Inst : IEnumerable<long>
{
public static readonly long[] Value=A265532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265532.Bytes);
public long this[int i]=>Value[i];

public static A265532Inst Instance=new A265532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265533
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,6L,6L,6L,6L,6L,6L,12L,12L,12L,12L,12L,12L,18L,18L,18L,18L,18L,18L,24L,24L,26L,26L,26L,26L,26L,31L,31L,31L,31L,31L,36L,36L,36L,36L,36L,41L,41L,41L,41L,41L,46L,46L,46L,46L,46L,46L,52L,52L,52L,52L,52L,57L,57L,57L,57L,57L,62L,62L,62L,62L,62L,67L,67L,67L,67L,67L,72L,72L,72L,72L,72L,72L,78L,78L,78L,78L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265533Inst : IEnumerable<long>
{
public static readonly long[] Value=A265533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265533.Bytes);
public long this[int i]=>Value[i];

public static A265533Inst Instance=new A265533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265534
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,11L,11L,11L,11L,11L,11L,22L,22L,22L,22L,22L,22L,33L,33L,33L,33L,33L,33L,44L,44L,101L,101L,101L,101L,101L,111L,111L,111L,111L,111L,121L,121L,121L,121L,121L,131L,131L,131L,131L,131L,141L,141L,141L,141L,141L,141L,202L,202L,202L,202L,202L,212L,212L,212L,212L,212L,222L,222L,222L,222L,222L,232L,232L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265534Inst : IEnumerable<long>
{
public static readonly long[] Value=A265534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265534.Bytes);
public long this[int i]=>Value[i];

public static A265534Inst Instance=new A265534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265535
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,5L,7L,7L,7L,7L,7L,7L,7L,14L,14L,14L,14L,14L,14L,14L,21L,21L,21L,21L,21L,21L,21L,28L,28L,28L,28L,28L,28L,28L,35L,35L,37L,37L,37L,37L,37L,37L,43L,43L,43L,43L,43L,43L,49L,49L,49L,49L,49L,49L,55L,55L,55L,55L,55L,55L,61L,61L,61L,61L,61L,61L,67L,67L,67L,67L,67L,67L,67L,74L,74L,74L,74L,74L,74L,80L,80L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265535Inst : IEnumerable<long>
{
public static readonly long[] Value=A265535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265535.Bytes);
public long this[int i]=>Value[i];

public static A265535Inst Instance=new A265535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265536
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,5L,11L,11L,11L,11L,11L,11L,11L,22L,22L,22L,22L,22L,22L,22L,33L,33L,33L,33L,33L,33L,33L,44L,44L,44L,44L,44L,44L,44L,55L,55L,101L,101L,101L,101L,101L,101L,111L,111L,111L,111L,111L,111L,121L,121L,121L,121L,121L,121L,131L,131L,131L,131L,131L,131L,141L,141L,141L,141L,141L,141L,151L,151L,151L,151L,151L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265536Inst : IEnumerable<long>
{
public static readonly long[] Value=A265536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265536.Bytes);
public long this[int i]=>Value[i];

public static A265536Inst Instance=new A265536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265537
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,6L,8L,8L,8L,8L,8L,8L,8L,8L,16L,16L,16L,16L,16L,16L,16L,16L,24L,24L,24L,24L,24L,24L,24L,24L,32L,32L,32L,32L,32L,32L,32L,32L,40L,40L,40L,40L,40L,40L,40L,40L,48L,48L,50L,50L,50L,50L,50L,50L,50L,57L,57L,57L,57L,57L,57L,57L,64L,64L,64L,64L,64L,64L,64L,71L,71L,71L,71L,71L,71L,71L,78L,78L,78L,78L,78L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265537Inst : IEnumerable<long>
{
public static readonly long[] Value=A265537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265537.Bytes);
public long this[int i]=>Value[i];

public static A265537Inst Instance=new A265537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265538
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,6L,11L,11L,11L,11L,11L,11L,11L,11L,22L,22L,22L,22L,22L,22L,22L,22L,33L,33L,33L,33L,33L,33L,33L,33L,44L,44L,44L,44L,44L,44L,44L,44L,55L,55L,55L,55L,55L,55L,55L,55L,66L,66L,101L,101L,101L,101L,101L,101L,101L,111L,111L,111L,111L,111L,111L,111L,121L,121L,121L,121L,121L,121L,121L,131L,131L,131L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265538Inst : IEnumerable<long>
{
public static readonly long[] Value=A265538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265538.Bytes);
public long this[int i]=>Value[i];

public static A265538Inst Instance=new A265538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265539
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,7L,9L,9L,9L,9L,9L,9L,9L,9L,9L,18L,18L,18L,18L,18L,18L,18L,18L,18L,27L,27L,27L,27L,27L,27L,27L,27L,27L,36L,36L,36L,36L,36L,36L,36L,36L,36L,45L,45L,45L,45L,45L,45L,45L,45L,45L,54L,54L,54L,54L,54L,54L,54L,54L,54L,63L,63L,65L,65L,65L,65L,65L,65L,65L,65L,73L,73L,73L,73L,73L,73L,73L,73L,81L,81L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265539Inst : IEnumerable<long>
{
public static readonly long[] Value=A265539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265539.Bytes);
public long this[int i]=>Value[i];

public static A265539Inst Instance=new A265539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265540
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,7L,11L,11L,11L,11L,11L,11L,11L,11L,11L,22L,22L,22L,22L,22L,22L,22L,22L,22L,33L,33L,33L,33L,33L,33L,33L,33L,33L,44L,44L,44L,44L,44L,44L,44L,44L,44L,55L,55L,55L,55L,55L,55L,55L,55L,55L,66L,66L,66L,66L,66L,66L,66L,66L,66L,77L,77L,101L,101L,101L,101L,101L,101L,101L,101L,111L,111L,111L,111L,111L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265540Inst : IEnumerable<long>
{
public static readonly long[] Value=A265540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265540.Bytes);
public long this[int i]=>Value[i];

public static A265540Inst Instance=new A265540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265541
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,8L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,70L,70L,70L,70L,70L,70L,70L,70L,70L,70L,80L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265541Inst : IEnumerable<long>
{
public static readonly long[] Value=A265541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265541.Bytes);
public long this[int i]=>Value[i];

public static A265541Inst Instance=new A265541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265542
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,8L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,33L,33L,33L,33L,33L,33L,33L,33L,33L,33L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,66L,66L,66L,66L,66L,66L,66L,66L,66L,66L,77L,77L,77L,77L,77L,77L,77L,77L,77L,77L,88L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265542Inst : IEnumerable<long>
{
public static readonly long[] Value=A265542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265542.Bytes);
public long this[int i]=>Value[i];

public static A265542Inst Instance=new A265542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265543
{
public static readonly long[] Value={ 0L,1L,11L,11L,101L,101L,111L,111L,1001L,1001L,1111L,1111L,1111L,1111L,1111L,1111L,10001L,10001L,11011L,11011L,10101L,10101L,11111L,11111L,11011L,11011L,11011L,11011L,11111L,11111L,11111L,11111L,100001L,100001L,110011L,110011L,101101L,101101L,111111L,111111L,101101L,101101L,111111L,111111L,101101L,101101L,111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265543Inst : IEnumerable<long>
{
public static readonly long[] Value=A265543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265543.Bytes);
public long this[int i]=>Value[i];

public static A265543Inst Instance=new A265543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265544
{
public static readonly long[] Value={ 0L,1L,2L,4L,4L,8L,8L,8L,8L,10L,10L,20L,13L,13L,23L,16L,16L,26L,20L,20L,20L,23L,23L,23L,26L,26L,26L,28L,28L,56L,40L,40L,68L,52L,52L,80L,40L,40L,68L,40L,40L,68L,52L,52L,80L,52L,52L,80L,52L,52L,80L,52L,52L,80L,56L,56L,56L,68L,68L,68L,80L,80L,80L,68L,68L,68L,68L,68L,68L,80L,80L,80L,80L,80L,80L,80L,80L,80L,80L,80L,80L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265544Inst : IEnumerable<long>
{
public static readonly long[] Value=A265544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265544.Bytes);
public long this[int i]=>Value[i];

public static A265544Inst Instance=new A265544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265545
{
public static readonly long[] Value={ 0L,1L,2L,11L,11L,22L,22L,22L,22L,101L,101L,202L,111L,111L,212L,121L,121L,222L,202L,202L,202L,212L,212L,212L,222L,222L,222L,1001L,1001L,2002L,1111L,1111L,2112L,1221L,1221L,2222L,1111L,1111L,2112L,1111L,1111L,2112L,1221L,1221L,2222L,1221L,1221L,2222L,1221L,1221L,2222L,1221L,1221L,2222L,2002L,2002L,2002L,2112L,2112L,2112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265545Inst : IEnumerable<long>
{
public static readonly long[] Value=A265545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265545.Bytes);
public long this[int i]=>Value[i];

public static A265545Inst Instance=new A265545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265546
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,5L,10L,15L,10L,10L,10L,15L,15L,15L,15L,15L,17L,17L,34L,51L,21L,21L,38L,55L,25L,25L,42L,59L,29L,29L,46L,63L,34L,34L,34L,51L,38L,38L,38L,55L,42L,42L,42L,59L,46L,46L,46L,63L,51L,51L,51L,51L,55L,55L,55L,55L,59L,59L,59L,59L,63L,63L,63L,63L,65L,65L,130L,195L,85L,85L,150L,215L,105L,105L,170L,235L,125L,125L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265546Inst : IEnumerable<long>
{
public static readonly long[] Value=A265546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265546.Bytes);
public long this[int i]=>Value[i];

public static A265546Inst Instance=new A265546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265547
{
public static readonly long[] Value={ 0L,1L,2L,3L,11L,11L,22L,33L,22L,22L,22L,33L,33L,33L,33L,33L,101L,101L,202L,303L,111L,111L,212L,313L,121L,121L,222L,323L,131L,131L,232L,333L,202L,202L,202L,303L,212L,212L,212L,313L,222L,222L,222L,323L,232L,232L,232L,333L,303L,303L,303L,303L,313L,313L,313L,313L,323L,323L,323L,323L,333L,333L,333L,333L,1001L,1001L,2002L,3003L,1111L,1111L,2112L,3113L,1221L,1221L,2222L,3223L,1331L,1331L,2332L,3333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265547Inst : IEnumerable<long>
{
public static readonly long[] Value=A265547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265547.Bytes);
public long this[int i]=>Value[i];

public static A265547Inst Instance=new A265547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265548
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,6L,12L,18L,24L,12L,12L,12L,18L,24L,18L,18L,18L,18L,24L,24L,24L,24L,24L,24L,26L,26L,52L,78L,104L,31L,31L,57L,83L,109L,36L,36L,62L,88L,114L,41L,41L,67L,93L,119L,46L,46L,72L,98L,124L,52L,52L,52L,78L,104L,57L,57L,57L,83L,109L,62L,62L,62L,88L,114L,67L,67L,67L,93L,119L,72L,72L,72L,98L,124L,78L,78L,78L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265548Inst : IEnumerable<long>
{
public static readonly long[] Value=A265548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265548.Bytes);
public long this[int i]=>Value[i];

public static A265548Inst Instance=new A265548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265549
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,11L,11L,22L,33L,44L,22L,22L,22L,33L,44L,33L,33L,33L,33L,44L,44L,44L,44L,44L,44L,101L,101L,202L,303L,404L,111L,111L,212L,313L,414L,121L,121L,222L,323L,424L,131L,131L,232L,333L,434L,141L,141L,242L,343L,444L,202L,202L,202L,303L,404L,212L,212L,212L,313L,414L,222L,222L,222L,323L,424L,232L,232L,232L,333L,434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265549Inst : IEnumerable<long>
{
public static readonly long[] Value=A265549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265549.Bytes);
public long this[int i]=>Value[i];

public static A265549Inst Instance=new A265549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265550
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,7L,14L,21L,28L,35L,14L,14L,14L,21L,28L,35L,21L,21L,21L,21L,28L,35L,28L,28L,28L,28L,28L,35L,35L,35L,35L,35L,35L,35L,37L,37L,74L,111L,148L,185L,43L,43L,80L,117L,154L,191L,49L,49L,86L,123L,160L,197L,55L,55L,92L,129L,166L,203L,61L,61L,98L,135L,172L,209L,67L,67L,104L,141L,178L,215L,74L,74L,74L,111L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265550Inst : IEnumerable<long>
{
public static readonly long[] Value=A265550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265550.Bytes);
public long this[int i]=>Value[i];

public static A265550Inst Instance=new A265550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265551
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,11L,11L,22L,33L,44L,55L,22L,22L,22L,33L,44L,55L,33L,33L,33L,33L,44L,55L,44L,44L,44L,44L,44L,55L,55L,55L,55L,55L,55L,55L,101L,101L,202L,303L,404L,505L,111L,111L,212L,313L,414L,515L,121L,121L,222L,323L,424L,525L,131L,131L,232L,333L,434L,535L,141L,141L,242L,343L,444L,545L,151L,151L,252L,353L,454L,555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265551Inst : IEnumerable<long>
{
public static readonly long[] Value=A265551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265551.Bytes);
public long this[int i]=>Value[i];

public static A265551Inst Instance=new A265551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265552
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,8L,16L,24L,32L,40L,48L,16L,16L,16L,24L,32L,40L,48L,24L,24L,24L,24L,32L,40L,48L,32L,32L,32L,32L,32L,40L,48L,40L,40L,40L,40L,40L,40L,48L,48L,48L,48L,48L,48L,48L,48L,50L,50L,100L,150L,200L,250L,300L,57L,57L,107L,157L,207L,257L,307L,64L,64L,114L,164L,214L,264L,314L,71L,71L,121L,171L,221L,271L,321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265552Inst : IEnumerable<long>
{
public static readonly long[] Value=A265552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265552.Bytes);
public long this[int i]=>Value[i];

public static A265552Inst Instance=new A265552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265553
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,11L,11L,22L,33L,44L,55L,66L,22L,22L,22L,33L,44L,55L,66L,33L,33L,33L,33L,44L,55L,66L,44L,44L,44L,44L,44L,55L,66L,55L,55L,55L,55L,55L,55L,66L,66L,66L,66L,66L,66L,66L,66L,101L,101L,202L,303L,404L,505L,606L,111L,111L,212L,313L,414L,515L,616L,121L,121L,222L,323L,424L,525L,626L,131L,131L,232L,333L,434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265553Inst : IEnumerable<long>
{
public static readonly long[] Value=A265553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265553.Bytes);
public long this[int i]=>Value[i];

public static A265553Inst Instance=new A265553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265554
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,9L,18L,27L,36L,45L,54L,63L,18L,18L,18L,27L,36L,45L,54L,63L,27L,27L,27L,27L,36L,45L,54L,63L,36L,36L,36L,36L,36L,45L,54L,63L,45L,45L,45L,45L,45L,45L,54L,63L,54L,54L,54L,54L,54L,54L,54L,63L,63L,63L,63L,63L,63L,63L,63L,63L,65L,65L,130L,195L,260L,325L,390L,455L,73L,73L,138L,203L,268L,333L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265554Inst : IEnumerable<long>
{
public static readonly long[] Value=A265554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265554.Bytes);
public long this[int i]=>Value[i];

public static A265554Inst Instance=new A265554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265555
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,11L,11L,22L,33L,44L,55L,66L,77L,22L,22L,22L,33L,44L,55L,66L,77L,33L,33L,33L,33L,44L,55L,66L,77L,44L,44L,44L,44L,44L,55L,66L,77L,55L,55L,55L,55L,55L,55L,66L,77L,66L,66L,66L,66L,66L,66L,66L,77L,77L,77L,77L,77L,77L,77L,77L,77L,101L,101L,202L,303L,404L,505L,606L,707L,111L,111L,212L,313L,414L,515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265555Inst : IEnumerable<long>
{
public static readonly long[] Value=A265555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265555.Bytes);
public long this[int i]=>Value[i];

public static A265555Inst Instance=new A265555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265556
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,10L,10L,20L,30L,40L,50L,60L,70L,80L,20L,20L,20L,30L,40L,50L,60L,70L,80L,30L,30L,30L,30L,40L,50L,60L,70L,80L,40L,40L,40L,40L,40L,50L,60L,70L,80L,50L,50L,50L,50L,50L,50L,60L,70L,80L,60L,60L,60L,60L,60L,60L,60L,70L,80L,70L,70L,70L,70L,70L,70L,70L,70L,80L,80L,80L,80L,80L,80L,80L,80L,80L,80L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265556Inst : IEnumerable<long>
{
public static readonly long[] Value=A265556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265556.Bytes);
public long this[int i]=>Value[i];

public static A265556Inst Instance=new A265556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265557
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,11L,11L,22L,33L,44L,55L,66L,77L,88L,22L,22L,22L,33L,44L,55L,66L,77L,88L,33L,33L,33L,33L,44L,55L,66L,77L,88L,44L,44L,44L,44L,44L,55L,66L,77L,88L,55L,55L,55L,55L,55L,55L,66L,77L,88L,66L,66L,66L,66L,66L,66L,66L,77L,88L,77L,77L,77L,77L,77L,77L,77L,77L,88L,88L,88L,88L,88L,88L,88L,88L,88L,88L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265557Inst : IEnumerable<long>
{
public static readonly long[] Value=A265557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265557.Bytes);
public long this[int i]=>Value[i];

public static A265557Inst Instance=new A265557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265558
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,11L,22L,33L,44L,55L,66L,77L,88L,99L,22L,22L,22L,33L,44L,55L,66L,77L,88L,99L,33L,33L,33L,33L,44L,55L,66L,77L,88L,99L,44L,44L,44L,44L,44L,55L,66L,77L,88L,99L,55L,55L,55L,55L,55L,55L,66L,77L,88L,99L,66L,66L,66L,66L,66L,66L,66L,77L,88L,99L,77L,77L,77L,77L,77L,77L,77L,77L,88L,99L,88L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265558Inst : IEnumerable<long>
{
public static readonly long[] Value=A265558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265558.Bytes);
public long this[int i]=>Value[i];

public static A265558Inst Instance=new A265558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265559
{
public static readonly long[] Value={ 0L,1L,11L,11L,101L,101L,111L,111L,1001L,1001L,1111L,1111L,1111L,1111L,1111L,1111L,10001L,10001L,10101L,10101L,10101L,10101L,11011L,11011L,11011L,11011L,11011L,11011L,11111L,11111L,11111L,11111L,100001L,100001L,101101L,101101L,101101L,101101L,101101L,101101L,101101L,101101L,101101L,101101L,101101L,101101L,110011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265559Inst : IEnumerable<long>
{
public static readonly long[] Value=A265559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265559.Bytes);
public long this[int i]=>Value[i];

public static A265559Inst Instance=new A265559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265560
{
public static readonly long[] Value={ 0L,1L,2L,4L,4L,8L,8L,8L,8L,10L,10L,13L,13L,13L,16L,16L,16L,20L,20L,20L,20L,23L,23L,23L,26L,26L,26L,28L,28L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,56L,56L,56L,56L,68L,68L,68L,68L,68L,68L,68L,68L,68L,68L,68L,68L,80L,80L,80L,80L,80L,80L,80L,80L,80L,80L,80L,80L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265560Inst : IEnumerable<long>
{
public static readonly long[] Value=A265560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265560.Bytes);
public long this[int i]=>Value[i];

public static A265560Inst Instance=new A265560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265561
{
public static readonly long[] Value={ 0L,1L,2L,11L,11L,22L,22L,22L,22L,101L,101L,111L,111L,111L,121L,121L,121L,202L,202L,202L,202L,212L,212L,212L,222L,222L,222L,1001L,1001L,1111L,1111L,1111L,1111L,1111L,1111L,1111L,1111L,1111L,1111L,1111L,1111L,1221L,1221L,1221L,1221L,1221L,1221L,1221L,1221L,1221L,1221L,1221L,1221L,2002L,2002L,2002L,2002L,2112L,2112L,2112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265561Inst : IEnumerable<long>
{
public static readonly long[] Value=A265561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265561.Bytes);
public long this[int i]=>Value[i];

public static A265561Inst Instance=new A265561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}