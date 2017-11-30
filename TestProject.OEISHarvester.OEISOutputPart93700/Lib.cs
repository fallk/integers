using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A113341
{
public static readonly BigInteger[] Value={ 1L,3L,12L,69L,560L,6059L,83215L,1399161L,28020221L,654110586L,17494347067L,528556017365L,17830841841940L,665126088764191L,27208111182653865L,1211942062741823574L,BigInteger.Parse("58424831462907214924"),BigInteger.Parse("3031993693950136247986") };
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
public class A113341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113341Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113341.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113341.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113341Inst Instance=new A113341Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113342
{
public static readonly BigInteger[] Value={ 1L,5L,35L,325L,3880L,57560L,1030751L,21763632L,531604250L,14789895891L,462672349092L,16100666809097L,617634167482824L,25916099832677757L,1181568927574816310L,BigInteger.Parse("58194225186901919790"),BigInteger.Parse("3080529680131892318877") };
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
public class A113342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113342Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113342.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113342.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113342Inst Instance=new A113342Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113343
{
public static readonly BigInteger[] Value={ 1L,7L,70L,889L,13853L,258146L,5633264L,141487178L,4031806898L,128792484219L,4565493788191L,178051324792642L,7583098790779316L,350435514388561567L,17474323210108996497UL,BigInteger.Parse("935597107908721785211"),BigInteger.Parse("53553176933223851350863") };
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
public class A113343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113343Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113343.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113343.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113343Inst Instance=new A113343Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113344
{
public static readonly BigInteger[] Value={ 1L,9L,117L,1881L,36051L,805875L,20661609L,599319747L,19443585048L,698723462022L,27583235473854L,1187660855613822L,55430739480692085L,2789074498460404927L,BigInteger.Parse("150571050665946174760"),BigInteger.Parse("8684625004973955639293"),BigInteger.Parse("533144024633105768180154") };
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
public class A113344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113344Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113344.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113344.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113344Inst Instance=new A113344Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113345
{
public static readonly long[] Value={ 1L,2L,1L,5L,6L,1L,19L,39L,10L,1L,113L,327L,105L,14L,1L,966L,3556L,1315L,203L,18L,1L,10958L,48659L,19875L,3367L,333L,22L,1L,156700L,812462L,357860L,64750L,6867L,495L,26L,1L,2727794L,16136404L,7547602L,1435497L,160005L,12199L,689L,30L,1L };
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
public class A113345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113345Inst : IEnumerable<long>
{
public static readonly long[] Value=A113345.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113345.Bytes);
public long this[int i]=>Value[i];

public static A113345Inst Instance=new A113345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113346
{
public static readonly BigInteger[] Value={ 1L,2L,5L,19L,113L,966L,10958L,156700L,2727794L,56306696L,1350043965L,36979531549L,1141573025172L,39272377323693L,1491452150268436L,62027842189908231L,2805631215820328992L,BigInteger.Parse("137199563717151509077"),BigInteger.Parse("7215932308408758314447") };
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
public class A113346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113346Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113346.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113346.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113346Inst Instance=new A113346Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113347
{
public static readonly BigInteger[] Value={ 1L,6L,39L,327L,3556L,48659L,812462L,16136404L,373415239L,9900007028L,296557405704L,9921937128500L,367181525916035L,14906571298831661L,659191947156441025L,BigInteger.Parse("31558799717042019635"),BigInteger.Parse("1626968083690674214906") };
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
public class A113347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113347Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113347.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113347.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113347Inst Instance=new A113347Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113348
{
public static readonly BigInteger[] Value={ 1L,10L,105L,1315L,19875L,357860L,7547602L,183518246L,5072961513L,157525315615L,5438681986872L,206954207984234L,8613936431369952L,389602050945939891L,BigInteger.Parse("19038814387466399303"),BigInteger.Parse("1000152089409979423044"),BigInteger.Parse("56229083214210734799693") };
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
public class A113348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113348Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113348.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113348.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113348Inst Instance=new A113348Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113349
{
public static readonly BigInteger[] Value={ 1L,14L,203L,3367L,64750L,1435497L,36312626L,1036877170L,33086963196L,1169366274321L,45412092740791L,1924418011638535L,88445828358934074L,4384910640997110602L,BigInteger.Parse("233384463606862044134"),BigInteger.Parse("13278878088344760573344") };
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
public class A113349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113349Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113349.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113349.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113349Inst Instance=new A113349Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113350
{
public static readonly long[] Value={ 1L,2L,1L,5L,4L,1L,19L,22L,6L,1L,113L,166L,51L,8L,1L,966L,1671L,561L,92L,10L,1L,10958L,21510L,7726L,1324L,145L,12L,1L,156700L,341463L,129406L,23010L,2575L,210L,14L,1L,2727794L,6496923L,2572892L,471724L,53935L,4434L,287L,16L,1L };
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
public class A113350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113350Inst : IEnumerable<long>
{
public static readonly long[] Value=A113350.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113350.Bytes);
public long this[int i]=>Value[i];

public static A113350Inst Instance=new A113350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113351
{
public static readonly BigInteger[] Value={ 1L,4L,22L,166L,1671L,21510L,341463L,6496923L,144856710L,3716746006L,108133664181L,3523951953981L,127331488458476L,5057405619797317L,219179491109978660L,10298771194610350427UL,BigInteger.Parse("521765883689616772731"),BigInteger.Parse("28363341834962918344084") };
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
public class A113351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113351Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113351.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113351.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113351Inst Instance=new A113351Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113352
{
public static readonly BigInteger[] Value={ 1L,6L,51L,561L,7726L,129406L,2572892L,59525136L,1576414408L,47144606666L,1574176301192L,58126182666796L,2354183194432226L,103850488571214174L,4959424774062415780L,BigInteger.Parse("255032863135423053615"),BigInteger.Parse("14056171975717324065788") };
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
public class A113352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113352.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113352Inst Instance=new A113352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113353
{
public static readonly BigInteger[] Value={ 1L,8L,92L,1324L,23010L,471724L,11198006L,303137822L,9239501237L,313689623136L,11755195387720L,482435619984340L,21537360479898341L,1039758627381190676L,BigInteger.Parse("54002918637393187687"),BigInteger.Parse("3003770445258147527669"),BigInteger.Parse("178205904321326719715551") };
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
public class A113353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113353Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113353.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113353.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113353Inst Instance=new A113353Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113354
{
public static readonly BigInteger[] Value={ 1L,10L,145L,2575L,53935L,1305070L,35924902L,1111107544L,38212134595L,1448428857802L,60055380515614L,2705916453572344L,131733359512179916L,6894586916062176161L,BigInteger.Parse("386203389346756538342"),BigInteger.Parse("23061963945353367894173") };
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
public class A113354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113354Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113354.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113354.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113354Inst Instance=new A113354Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113355
{
public static readonly long[] Value={ 1L,4L,1L,18L,8L,1L,112L,68L,12L,1L,965L,712L,150L,16L,1L,10957L,9270L,2184L,264L,20L,1L,156699L,147174L,37523L,4912L,410L,24L,1L,2727793L,2786270L,754171L,104476L,9280L,588L,28L,1L,56306695L,61662544L,17502145L,2531004L,235025L,15672L,798L,32L,1L };
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
public class A113355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113355Inst : IEnumerable<long>
{
public static readonly long[] Value=A113355.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113355.Bytes);
public long this[int i]=>Value[i];

public static A113355Inst Instance=new A113355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113356
{
public static readonly BigInteger[] Value={ 1L,4L,18L,112L,965L,10957L,156699L,2727793L,56306695L,1350043964L,36979531548L,1141573025171L,39272377323692L,1491452150268435L,62027842189908230L,2805631215820328991L,BigInteger.Parse("137199563717151509076"),BigInteger.Parse("7215932308408758314446") };
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
public class A113356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113356Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113356.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113356.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113356Inst Instance=new A113356Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113357
{
public static readonly BigInteger[] Value={ 1L,8L,68L,712L,9270L,147174L,2786270L,61662544L,1568627031L,45226595865L,1460494997316L,52298603045920L,2059014449303471L,88476000281671109L,4123177399591735062L,BigInteger.Parse("207239886694280045429"),BigInteger.Parse("11179817701706220363653") };
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
public class A113357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113357Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113357.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113357.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113357Inst Instance=new A113357Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113358
{
public static readonly BigInteger[] Value={ 1L,12L,150L,2184L,37523L,754171L,17502145L,462930509L,13792292332L,458112945183L,16812390472566L,676432435584855L,29635374525536866L,1405425902409792025L,BigInteger.Parse("71770681806834337871"),BigInteger.Parse("3928431507732054301085"),BigInteger.Parse("229528875492540329214765") };
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
public class A113358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113358Inst Instance=new A113358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113359
{
public static readonly BigInteger[] Value={ 1L,16L,264L,4912L,104476L,2531004L,69265724L,2122120824L,72160283026L,2702008172582L,110631977612048L,4922281897250776L,236665779016591350L,12236187035970192634UL,BigInteger.Parse("677311496213007409312"),BigInteger.Parse("39980910968200568816168") };
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
public class A113359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113359Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113359.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113359.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113359Inst Instance=new A113359Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113360
{
public static readonly long[] Value={ 1L,3L,1L,12L,9L,1L,69L,81L,15L,1L,560L,879L,210L,21L,1L,6059L,11739L,3285L,399L,27L,1L,83215L,190044L,59395L,8127L,648L,33L,1L,1399161L,3654814L,1241270L,184436L,16245L,957L,39L,1L,28020221L,81947221L,29720808L,4695719L,442890L,28479L,1326L,45L,1L };
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
public class A113360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113360Inst : IEnumerable<long>
{
public static readonly long[] Value=A113360.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113360.Bytes);
public long this[int i]=>Value[i];

public static A113360Inst Instance=new A113360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113361
{
public static readonly BigInteger[] Value={ 1L,9L,81L,879L,11739L,190044L,3654814L,81947221L,2107962168L,61366149296L,1998607800064L,72112467306074L,2858551691428042L,123596917897265255L,5792708223233376744L,BigInteger.Parse("292682081981049699408"),BigInteger.Parse("15865848522184194142469") };
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
public class A113361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113361Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113361.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113361.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113361Inst Instance=new A113361Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113362
{
public static readonly BigInteger[] Value={ 1L,15L,210L,3285L,59395L,1241270L,29720808L,806720492L,24568601477L,831697990069L,31036137984664L,1267376997249262L,56270606942915489L,2701018385881136958L,BigInteger.Parse("139463341982980040911"),BigInteger.Parse("7711492696761363573725") };
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
public class A113362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113362Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113362.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113362.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113362Inst Instance=new A113362Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113363
{
public static readonly BigInteger[] Value={ 1L,21L,399L,8127L,184436L,4695719L,133730310L,4234560596L,148077895854L,5680484146379L,237574859841676L,10771591113205720L,526750324271281348L,BigInteger.Parse("27655229128194306702"),BigInteger.Parse("1552379671658643163707"),BigInteger.Parse("92820542631741826797326") };
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
public class A113363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113363Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113363.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113363.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113363Inst Instance=new A113363Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113364
{
public static readonly BigInteger[] Value={ 1L,27L,648L,16245L,442890L,13269069L,437085705L,15779515035L,621549547326L,26584365342579L,1228849871633643L,61116983784901476L,3257058909552139683L,BigInteger.Parse("185287271910574343301"),BigInteger.Parse("11212875913429712533737"),BigInteger.Parse("719555515466643129103760") };
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
public class A113364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113364Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113364.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113364.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113364Inst Instance=new A113364Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113365
{
public static readonly long[] Value={ 1L,6L,1L,39L,12L,1L,327L,138L,18L,1L,3556L,1830L,297L,24L,1L,48659L,28805L,5349L,516L,30L,1L,812462L,535004L,109095L,11724L,795L,36L,1L,16136404L,11568197L,2529909L,292894L,21795L,1134L,42L,1L,373415239L,287143993L,66345668L,8117624L,643790L,36402L,1533L };
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
public class A113365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113365Inst : IEnumerable<long>
{
public static readonly long[] Value=A113365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113365.Bytes);
public long this[int i]=>Value[i];

public static A113365Inst Instance=new A113365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113366
{
public static readonly BigInteger[] Value={ 1L,12L,138L,1830L,28805L,535004L,11568197L,287143993L,8077888153L,254672147047L,8910929460415L,343135184110984L,14435616939387951L,659276261774240232L,BigInteger.Parse("32504007393860850275"),BigInteger.Parse("1721495715845423489806"),BigInteger.Parse("97516667477625085469176") };
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
public class A113366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113366Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113366.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113366Inst Instance=new A113366Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113367
{
public static readonly BigInteger[] Value={ 1L,18L,297L,5349L,109095L,2529909L,66345668L,1951815218L,63879120597L,2307569048308L,91351738972187L,3937843359099176L,183778364128820499L,9238674078250458082UL,BigInteger.Parse("497996763423626058847"),BigInteger.Parse("28666454637876852704364") };
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
public class A113367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113367Inst Instance=new A113367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113368
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,5L,4L,1L,0L,19L,22L,6L,1L,0L,113L,166L,51L,8L,1L,0L,966L,1671L,561L,92L,10L,1L,0L,10958L,21510L,7726L,1324L,145L,12L,1L,0L,156700L,341463L,129406L,23010L,2575L,210L,14L,1L,0L,2727794L,6496923L,2572892L,471724L,53935L,4434L,287L,16L,1L };
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
public class A113368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113368Inst : IEnumerable<long>
{
public static readonly long[] Value=A113368.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113368.Bytes);
public long this[int i]=>Value[i];

public static A113368Inst Instance=new A113368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113369
{
public static readonly long[] Value={ 1L,3L,1L,12L,5L,1L,69L,35L,7L,1L,560L,325L,70L,9L,1L,6059L,3880L,889L,117L,11L,1L,83215L,57560L,13853L,1881L,176L,13L,1L,1399161L,1030751L,258146L,36051L,3421L,247L,15L,1L,28020221L,21763632L,5633264L,805875L,77726L,5629L,330L,17L,1L };
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
public class A113369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113369Inst : IEnumerable<long>
{
public static readonly long[] Value=A113369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113369.Bytes);
public long this[int i]=>Value[i];

public static A113369Inst Instance=new A113369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113370
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,28L,7L,1L,1L,326L,91L,10L,1L,1L,5702L,1722L,190L,13L,1L,1L,136724L,43764L,4945L,325L,16L,1L,1L,4226334L,1415799L,163705L,10751L,496L,19L,1L,1L,161385532L,56096733L,6617605L,437723L,19896L,703L,22L,1L,1L,7378504140L,2644883675L };
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
public class A113370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113370Inst : IEnumerable<long>
{
public static readonly long[] Value=A113370.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113370.Bytes);
public long this[int i]=>Value[i];

public static A113370Inst Instance=new A113370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113371
{
public static readonly BigInteger[] Value={ 1L,4L,28L,326L,5702L,136724L,4226334L,161385532L,7378504140L,394404094270L,24193638303234L,1677962100799727L,129990908689219749L,11135889051081255518UL,BigInteger.Parse("1046032727101344902679"),BigInteger.Parse("106966601176207198837104") };
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
public class A113371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113371Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113371.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113371Inst Instance=new A113371Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113372
{
public static readonly BigInteger[] Value={ 1L,7L,91L,1722L,43764L,1415799L,56096733L,2644883675L,145131435225L,9107198292451L,644373208531066L,50814103000624929L,4423148359685316443L,BigInteger.Parse("421540670702940409866"),BigInteger.Parse("43680252604560889074884") };
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
public class A113372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113372Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113372.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113372.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113372Inst Instance=new A113372Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113373
{
public static readonly BigInteger[] Value={ 1L,10L,190L,4945L,163705L,6617605L,317416204L,17677189426L,1123660618048L,80411135580587L,6405386721320372L,562632770359355432L,BigInteger.Parse("54061761393693393203"),BigInteger.Parse("5643864294810397451552"),BigInteger.Parse("636388356169482970183598") };
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
public class A113373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113373.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113373Inst Instance=new A113373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113374
{
public static readonly long[] Value={ 1L,2L,1L,6L,8L,1L,37L,84L,14L,1L,429L,1296L,252L,20L,1L,7629L,27850L,5957L,510L,26L,1L,185776L,784146L,179270L,16180L,858L,32L,1L,5817106L,27630378L,6641502L,623115L,34125L,1296L,38L,1L,224558216L,1177691946L,294524076L,28470525L,1599091L,61952L };
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
public class A113374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113374Inst : IEnumerable<long>
{
public static readonly long[] Value=A113374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113374.Bytes);
public long this[int i]=>Value[i];

public static A113374Inst Instance=new A113374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113375
{
public static readonly BigInteger[] Value={ 1L,2L,6L,37L,429L,7629L,185776L,5817106L,224558216L,10362978307L,558458382528L,34504326965326L,2408502186081117L,187672037804601000L,16162473554575583148UL,BigInteger.Parse("1525578320627987001344"),BigInteger.Parse("156704538246796929248712") };
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
public class A113375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113375Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113375.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113375.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113375Inst Instance=new A113375Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113376
{
public static readonly BigInteger[] Value={ 1L,8L,84L,1296L,27850L,784146L,27630378L,1177691946L,59169833470L,3434258845248L,226594550768662L,16775755397765720L,1378646430074005827L,BigInteger.Parse("124636321499378130839"),BigInteger.Parse("12300850874338422058685") };
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
public class A113376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113376Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113376.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113376.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113376Inst Instance=new A113376Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113377
{
public static readonly BigInteger[] Value={ 1L,14L,252L,5957L,179270L,6641502L,294524076L,15285260326L,911664081027L,61573228385424L,4652227417900405L,389256081747220268L,BigInteger.Parse("35759870451009454561"),BigInteger.Parse("3580704593280285017869"),BigInteger.Parse("388344720309998846243731") };
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
public class A113377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113377Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113377.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113377.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113377Inst Instance=new A113377Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113378
{
public static readonly long[] Value={ 1L,3L,1L,15L,12L,1L,136L,168L,21L,1L,1998L,3190L,483L,30L,1L,41973L,80136L,13615L,960L,39L,1L,1166263L,2553162L,469476L,35785L,1599L,48L,1L,40747561L,99579994L,19419225L,1562220L,74074L,2400L,57L,1L,1726907675L,4624245724L,944233801L,79072620L };
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
public class A113378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113378Inst : IEnumerable<long>
{
public static readonly long[] Value=A113378.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113378.Bytes);
public long this[int i]=>Value[i];

public static A113378Inst Instance=new A113378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113379
{
public static readonly BigInteger[] Value={ 1L,3L,15L,136L,1998L,41973L,1166263L,40747561L,1726907675L,86421647389L,5002021986418L,329382745551946L,24351172588548270L,1999205882982496161L,BigInteger.Parse("180613538916429940159"),BigInteger.Parse("17817366508243503227269") };
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
public class A113379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113379Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113379.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113379.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113379Inst Instance=new A113379Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113380
{
public static readonly BigInteger[] Value={ 1L,12L,168L,3190L,80136L,2553162L,99579994L,4624245724L,250138459808L,15488221792442L,1082305443525010L,84364431201000877L,7264439969560330768L,BigInteger.Parse("685338322012632405151"),BigInteger.Parse("70341947440289270101707") };
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
public class A113380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113380Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113380.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113380.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113380Inst Instance=new A113380Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113381
{
public static readonly long[] Value={ 1L,2L,1L,6L,5L,1L,37L,45L,8L,1L,429L,635L,120L,11L,1L,7629L,12815L,2556L,231L,14L,1L,185776L,343815L,71548L,6556L,378L,17L,1L,5817106L,11651427L,2508528L,233706L,13391L,561L,20L,1L,224558216L,480718723L,106427700L,10069521L,579047L,23817L,780L,23L,1L };
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
public class A113381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113381Inst : IEnumerable<long>
{
public static readonly long[] Value=A113381.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113381.Bytes);
public long this[int i]=>Value[i];

public static A113381Inst Instance=new A113381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113382
{
public static readonly BigInteger[] Value={ 1L,5L,45L,635L,12815L,343815L,11651427L,480718723L,23489845779L,1330745268401L,85944092769721L,6242138253088466L,504185328302302736L,BigInteger.Parse("44867722807185829082"),BigInteger.Parse("4364538423763543903228"),BigInteger.Parse("460969199012824227856506") };
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
public class A113382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113382Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113382.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113382.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113382Inst Instance=new A113382Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113383
{
public static readonly BigInteger[] Value={ 1L,8L,120L,2556L,71548L,2508528L,106427700L,5323786728L,307710142888L,20222341451124L,1491479257952300L,122128352186849366L,11002901720698439826UL,BigInteger.Parse("1082337197005046142588"),BigInteger.Parse("115485905212456384697750") };
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
public class A113383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113383Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113383.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113383.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113383Inst Instance=new A113383Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113384
{
public static readonly long[] Value={ 1L,4L,1L,22L,10L,1L,212L,130L,16L,1L,3255L,2365L,328L,22L,1L,70777L,57695L,8640L,616L,28L,1L,2022897L,1798275L,284356L,21197L,994L,34L,1L,72375484L,68931064L,11358500L,875424L,42196L,1462L,40L,1L,3130502129L,3155772612L,537277044L,42499204L };
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
public class A113384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113384Inst : IEnumerable<long>
{
public static readonly long[] Value=A113384.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113384.Bytes);
public long this[int i]=>Value[i];

public static A113384Inst Instance=new A113384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113385
{
public static readonly BigInteger[] Value={ 1L,4L,22L,212L,3255L,70777L,2022897L,72375484L,3130502129L,159476810183L,9376968779265L,626244735454991L,46892450411406465L,3894861818247549265L,BigInteger.Parse("355651177699555693544"),BigInteger.Parse("35432761283736539730108") };
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
public class A113385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113385Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113385.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113385.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113385Inst Instance=new A113385Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113386
{
public static readonly BigInteger[] Value={ 1L,10L,130L,2365L,57695L,1798275L,68931064L,3155772612L,168671241316L,10336797449013L,715846906453760L,55355481111622706L,4732541017570608210L,BigInteger.Parse("443593124488673026361"),BigInteger.Parse("45261577596891190335258") };
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
public class A113386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113386Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113386.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113386.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113386Inst Instance=new A113386Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113387
{
public static readonly long[] Value={ 1L,6L,1L,48L,15L,1L,605L,255L,24L,1L,11196L,5630L,624L,33L,1L,280440L,159210L,19484L,1155L,42L,1L,8981460L,5584635L,731664L,46541L,1848L,51L,1L,353283128L,236051661L,32532732L,2173248L,91175L,2703L,60L,1L,16567072675L,11741443007L,1683566556L };
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
public class A113387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113387Inst : IEnumerable<long>
{
public static readonly long[] Value=A113387.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113387.Bytes);
public long this[int i]=>Value[i];

public static A113387Inst Instance=new A113387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113388
{
public static readonly BigInteger[] Value={ 1L,6L,48L,605L,11196L,280440L,8981460L,353283128L,16567072675L,905357065354L,56632746126107L,3997082539456084L,314584709388906568L,BigInteger.Parse("27340439653453247728"),BigInteger.Parse("2602372304420672868499"),BigInteger.Parse("269388182085308601450047") };
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
public class A113388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113388Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113388.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113388.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113388Inst Instance=new A113388Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113389
{
public static readonly long[] Value={ 1L,3L,1L,15L,6L,1L,136L,66L,9L,1L,1998L,1091L,153L,12L,1L,41973L,24891L,3621L,276L,15L,1L,1166263L,737061L,110637L,8482L,435L,18L,1L,40747561L,27110418L,4176549L,323874L,16430L,630L,21L,1L,1726907675L,1199197442L,188802141L,14813844L,751920L,28221L };
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
public class A113389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113389Inst : IEnumerable<long>
{
public static readonly long[] Value=A113389.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113389.Bytes);
public long this[int i]=>Value[i];

public static A113389Inst Instance=new A113389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113390
{
public static readonly BigInteger[] Value={ 1L,6L,66L,1091L,24891L,737061L,27110418L,1199197442L,62240034172L,3718021355407L,251730371459590L,19076604651022143L,1601423150451641820L,BigInteger.Parse("147628858305489901288"),BigInteger.Parse("14834881996161804192069") };
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
public class A113390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113390Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113390.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113390.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113390Inst Instance=new A113390Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113391
{
public static readonly BigInteger[] Value={ 1L,9L,153L,3621L,110637L,4176549L,188802141L,9981491997L,605817292893L,41590997891929L,3190816992548889L,270817573670371995L,BigInteger.Parse("25214094974302894695"),BigInteger.Parse("2556615042094813435491"),BigInteger.Parse("280570514270855698070535") };
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
public class A113391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113391Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113391.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113391.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113391Inst Instance=new A113391Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113392
{
public static readonly long[] Value={ 1L,6L,1L,48L,12L,1L,605L,186L,18L,1L,11196L,3892L,414L,24L,1L,280440L,106089L,12021L,732L,30L,1L,8981460L,3620379L,429345L,27152L,1140L,36L,1L,353283128L,149740555L,18386361L,1196910L,51445L,1638L,42L,1L,16567072675L,7316974618L,923656512L };
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
public class A113392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113392Inst : IEnumerable<long>
{
public static readonly long[] Value=A113392.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113392.Bytes);
public long this[int i]=>Value[i];

public static A113392Inst Instance=new A113392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113393
{
public static readonly BigInteger[] Value={ 1L,6L,48L,605L,11196L,280440L,8981460L,353283128L,16567072675L,905357065354L,56632746126107L,3997082539456084L,314584709388906568L,BigInteger.Parse("27340439653453247728"),BigInteger.Parse("2602372304420672868499"),BigInteger.Parse("269388182085308601450047") };
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
public class A113393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113393Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113393.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113393.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113393Inst Instance=new A113393Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113394
{
public static readonly long[] Value={ 1L,9L,1L,99L,18L,1L,1569L,360L,27L,1L,34344L,9051L,783L,36L,1L,980487L,284148L,26820L,1368L,45L,1L,34930455L,10865358L,1089126L,59250L,2115L,54L,1L,1502349459L,494019714L,51784137L,2946456L,110715L,3024L,63L,1L,76058669082L,26168502684L };
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
public class A113394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113394Inst : IEnumerable<long>
{
public static readonly long[] Value=A113394.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113394.Bytes);
public long this[int i]=>Value[i];

public static A113394Inst Instance=new A113394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113395
{
public static readonly BigInteger[] Value={ 1L,9L,99L,1569L,34344L,980487L,34930455L,1502349459L,76058669082L,4443563603890L,294878418586620L,21942670402467153L,1811533845177895161L,BigInteger.Parse("164451065361854357011"),BigInteger.Parse("16291788187615516225925") };
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
public class A113395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113395Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113395.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113395.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113395Inst Instance=new A113395Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113396
{
public static readonly long[] Value={ 2L,1L,3L,6L,9L,1L,15L,7L,22L,27L,1L,25L,39L,31L,17L,23L,57L,31L,55L,69L,43L,67L,53L,33L,85L,99L,91L,105L,97L,58L,115L,101L,135L,49L,147L,121L,127L,151L,137L,143L,177L,91L,189L,181L,195L,67L,79L,211L,225L,217L,203L,237L,151L };
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
public class A113396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113396Inst : IEnumerable<long>
{
public static readonly long[] Value=A113396.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113396.Bytes);
public long this[int i]=>Value[i];

public static A113396Inst Instance=new A113396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113397
{
public static readonly long[] Value={ 1L,3L,3L,6L,3L,7L,3L,7L,10L,3L,11L,7L,3L,7L,11L,11L,3L,11L,7L,3L,11L,7L,11L,15L,7L,3L,7L,3L,7L,26L,7L,11L,3L,19L,3L,11L,11L,7L,11L,11L,3L,19L,3L,7L,3L,23L,23L,7L,3L,7L,11L,3L,19L };
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
public class A113397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113397Inst : IEnumerable<long>
{
public static readonly long[] Value=A113397.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113397.Bytes);
public long this[int i]=>Value[i];

public static A113397Inst Instance=new A113397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113398
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,4L,2L,1L,5L,1L,3L,6L,4L,2L,3L,7L,4L,5L,8L,5L,6L,6L,1L,7L,9L,8L,10L,9L,1L,10L,7L,11L,1L,12L,8L,9L,11L,10L,11L,13L,2L,14L,12L,15L,1L,2L,13L,16L,14L,12L,17L,3L };
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
public class A113398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113398Inst : IEnumerable<long>
{
public static readonly long[] Value=A113398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113398.Bytes);
public long this[int i]=>Value[i];

public static A113398Inst Instance=new A113398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113399
{
public static readonly long[] Value={ 2L,3L,6L,6L,5L,6L,4L,6L,6L,8L,7L,8L,9L,5L,0L,4L,6L,3L,3L,3L,7L,8L,7L,8L,9L,5L,8L,1L,8L,2L,2L,1L,2L,0L,4L,2L,3L,1L,1L,9L,9L,0L,3L,2L,0L,5L,8L,1L,8L,2L,2L,4L,3L,0L,3L,1L,3L,7L,6L,7L,9L,0L,4L,5L,4L,8L,2L,4L,6L,4L,9L,5L,0L,6L,3L,7L,2L,3L,1L,3L,1L,1L,2L,8L,3L,0L,7L,3L,9L,6L,4L,1L,6L,2L,7L,8L,8L,8L,6L,3L,6L,8L,6L,9L,9L };
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
public class A113399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113399Inst : IEnumerable<long>
{
public static readonly long[] Value=A113399.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113399.Bytes);
public long this[int i]=>Value[i];

public static A113399Inst Instance=new A113399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113400
{
public static readonly long[] Value={ 2L,0L,2L,0L,9L,8L,3L,3L,2L,9L,2L,2L,3L,1L,8L,6L,8L,0L,5L,1L,2L,7L,8L,6L,7L,9L,7L,2L,9L,5L,8L,7L,8L,5L,9L,1L,6L,5L,4L,9L,5L,9L,5L,6L,4L,7L,0L,7L,2L,9L,3L,1L,3L,5L,9L,9L,5L,4L,0L,3L,6L,8L,2L,4L,2L,7L,5L,3L,3L,3L,6L,7L,6L,4L,1L,1L,5L,9L,3L,9L,9L,8L,0L,7L,2L,1L,1L,3L,0L,9L,6L,7L,5L,1L,8L,5L,8L,0L,7L,6L,0L,9L,1L,0L,6L };
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
public class A113400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113400Inst : IEnumerable<long>
{
public static readonly long[] Value=A113400.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113400.Bytes);
public long this[int i]=>Value[i];

public static A113400Inst Instance=new A113400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113401
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,4L,4L,8L,4L,4L,4L,8L,8L,8L,8L,16L,8L,16L,16L,16L,32L,16L,16L,16L,32L,32L,32L,32L,32L,32L,32L,64L,64L,128L,64L,64L,64L,64L,64L,64L,64L,128L,128L,128L,128L,128L,128L,256L,128L,128L,128L,256L,256L,256L,256L,512L,256L,256L,256L,256L,256L,256L,512L };
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
public class A113401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113401Inst : IEnumerable<long>
{
public static readonly long[] Value=A113401.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113401.Bytes);
public long this[int i]=>Value[i];

public static A113401Inst Instance=new A113401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113402
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,4L,4L,4L,4L,8L,8L,8L,8L,8L,16L,16L,16L,16L,16L,16L,32L,32L,32L,32L,32L,32L,32L,64L,64L,64L,64L,64L,64L,64L,64L,128L,128L,128L,128L,128L,128L,128L,128L,128L,256L,256L,256L,256L,256L,256L,256L,256L,256L,256L,512L,512L,512L,512L,512L,512L,512L,512L,512L };
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
public class A113402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113402Inst : IEnumerable<long>
{
public static readonly long[] Value=A113402.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113402.Bytes);
public long this[int i]=>Value[i];

public static A113402Inst Instance=new A113402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113403
{
public static readonly long[] Value={ 11L,101L,821L,1481L,3251L,5651L,9431L,31721L,43781L,97841L,135461L,187631L,326141L,768191L,1440581L,1508621L,3047411L,3798071L,5146481L,5610461L,9020981L,17301041L,22030271L };
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
public class A113403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113403Inst : IEnumerable<long>
{
public static readonly long[] Value=A113403.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113403.Bytes);
public long this[int i]=>Value[i];

public static A113403Inst Instance=new A113403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113404
{
public static readonly long[] Value={ 6L,90L,630L,660L,1170L,2190L,3780L,6420L,8940L,9030L,13260L,16470L,24150L,28800L,29610L,39990L,56580L,56910L,71610L,83460L,94530L,114450L,157830L,159060L,171180L,177360L,190500L,197910L,268050L,315840L,395520L,435240L,440910L,513570L,536010L,539310L,557340L,635130L };
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
public class A113404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113404Inst : IEnumerable<long>
{
public static readonly long[] Value=A113404.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113404.Bytes);
public long this[int i]=>Value[i];

public static A113404Inst Instance=new A113404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113405
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,7L,14L,28L,57L,114L,228L,455L,910L,1820L,3641L,7282L,14564L,29127L,58254L,116508L,233017L,466034L,932068L,1864135L,3728270L,7456540L,14913081L,29826162L,59652324L,119304647L,238609294L,477218588L,954437177L,1908874354L,3817748708L };
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
public class A113405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113405Inst : IEnumerable<long>
{
public static readonly long[] Value=A113405.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113405.Bytes);
public long this[int i]=>Value[i];

public static A113405Inst Instance=new A113405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113406
{
public static readonly long[] Value={ 1L,0L,0L,2L,2L,0L,0L,2L,1L,0L,0L,0L,2L,0L,0L,2L,2L,0L,0L,4L,0L,0L,0L,0L,3L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,2L,2L,0L,0L,4L,2L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,4L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,2L,4L,0L,0L,4L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,4L,1L,0L,0L,0L,4L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,6L,2L,0L,0L,4L,0L };
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
public class A113406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113406Inst : IEnumerable<long>
{
public static readonly long[] Value=A113406.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113406.Bytes);
public long this[int i]=>Value[i];

public static A113406Inst Instance=new A113406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113407
{
public static readonly long[] Value={ 1L,1L,2L,3L,0L,2L,1L,0L,4L,2L,1L,2L,2L,0L,2L,1L,0L,2L,4L,2L,0L,3L,0L,4L,2L,0L,0L,0L,3L,2L,2L,0L,2L,4L,0L,2L,3L,0L,4L,2L,0L,0L,2L,0L,2L,1L,2L,4L,0L,0L,2L,2L,0L,6L,2L,1L,2L,2L,0L,0L,4L,0L,0L,4L,0L,2L,1L,0L,4L,0L,0L,2L,2L,4L,2L,2L,0L,2L,5L,0L,2L,0L,2L,0L,2L,0L,4L,4L,0L,0L,0L,1L,0L,4L,0L,2L,2L,0L,4L,4L,2L,2L,0L,0L,2L };
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
public class A113407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113407Inst : IEnumerable<long>
{
public static readonly long[] Value=A113407.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113407.Bytes);
public long this[int i]=>Value[i];

public static A113407Inst Instance=new A113407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113408
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,2L,0L,1L,2L,0L,3L,0L,1L,0L,6L,0L,4L,0L,1L,3L,0L,12L,0L,5L,0L,1L,0L,12L,0L,20L,0L,6L,0L,1L,6L,0L,30L,0L,30L,0L,7L,0L,1L,0L,30L,0L,60L,0L,42L,0L,8L,0L,1L,10L,0L,90L,0L,105L,0L,56L,0L,9L,0L,1L,0L,60L,0L,210L,0L,168L,0L,72L,0L,10L,0L,1L,20L,0L,210L,0L,420L,0L,252L,0L,90L,0L,11L,0L,1L };
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
public class A113408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113408Inst : IEnumerable<long>
{
public static readonly long[] Value=A113408.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113408.Bytes);
public long this[int i]=>Value[i];

public static A113408Inst Instance=new A113408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113409
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,11L,21L,39L,74L,141L,271L,521L,1004L,1939L,3756L,7291L,14176L,27599L,53805L,105031L,205268L,401573L,786328L,1541037L,3022528L,5932657L,11652617L,22901865L,45037432L,88616807L,174454943L,343606183L,677074350L,1334744305L };
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
public class A113409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113409Inst : IEnumerable<long>
{
public static readonly long[] Value=A113409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113409.Bytes);
public long this[int i]=>Value[i];

public static A113409Inst Instance=new A113409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113410
{
public static readonly long[] Value={ 1L,5L,21L,23L,27L,31L,33L,37L,45L,53L,67L,70L,96L,101L,102L,128L,135L,144L,167L,178L,186L,188L,196L,197L,199L,202L,216L,219L,246L,247L,252L,255L,264L,299L,300L,341L,356L,363L,369L,381L,382L,407L,410L,426L,427L,494L,503L,506L,520L,528L,538L,550L,562L,573L,607L };
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
public class A113410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113410Inst : IEnumerable<long>
{
public static readonly long[] Value=A113410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113410.Bytes);
public long this[int i]=>Value[i];

public static A113410Inst Instance=new A113410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113411
{
public static readonly long[] Value={ 1L,2L,0L,0L,3L,2L,0L,0L,2L,2L,0L,0L,1L,4L,0L,0L,4L,0L,0L,0L,2L,2L,0L,0L,1L,4L,0L,0L,4L,2L,0L,0L,0L,2L,0L,0L,2L,2L,0L,0L,5L,2L,0L,0L,2L,0L,0L,0L,2L,6L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,3L,4L,0L,0L,4L,2L,0L,0L,2L,2L,0L,0L,0L,2L,0L,0L,6L,0L,0L,0L,0L,2L,0L,0L,1L,6L,0L,0L,4L,2L,0L,0L,0L,4L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,4L };
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
public class A113411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113411Inst : IEnumerable<long>
{
public static readonly long[] Value=A113411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113411.Bytes);
public long this[int i]=>Value[i];

public static A113411Inst Instance=new A113411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113412
{
public static readonly long[] Value={ 4L,10L,25L,58L,125L,250L,505L,1020L,2075L,4227L,8597L,17213L };
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
public class A113412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113412Inst : IEnumerable<long>
{
public static readonly long[] Value=A113412.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113412.Bytes);
public long this[int i]=>Value[i];

public static A113412Inst Instance=new A113412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113413
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,1L,2L,8L,6L,1L,2L,12L,18L,8L,1L,2L,16L,38L,32L,10L,1L,2L,20L,66L,88L,50L,12L,1L,2L,24L,102L,192L,170L,72L,14L,1L,2L,28L,146L,360L,450L,292L,98L,16L,1L,2L,32L,198L,608L,1002L,912L,462L,128L,18L,1L,2L,36L,258L,952L,1970L,2364L,1666L,688L,162L,20L,1L,2L,40L,326L };
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
public class A113413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113413Inst : IEnumerable<long>
{
public static readonly long[] Value=A113413.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113413.Bytes);
public long this[int i]=>Value[i];

public static A113413Inst Instance=new A113413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113414
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,2L,0L,1L,1L,2L,0L,2L,2L,2L,0L,1L,2L,3L,0L,2L,0L,2L,0L,2L,3L,2L,0L,2L,2L,4L,0L,1L,0L,2L,0L,3L,2L,2L,0L,2L,2L,4L,0L,2L,2L,2L,0L,2L,1L,3L,0L,2L,2L,4L,0L,2L,0L,2L,0L,4L,2L,2L,0L,1L,4L,4L,0L,2L,0L,4L,0L,3L,2L,2L,0L,2L,0L,4L,0L,2L,1L,2L,0L,4L,4L,2L,0L,2L,2L,6L,0L,2L,0L,2L,0L,2L,2L,3L,0L,3L,2L,4L,0L,2L,0L };
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
public class A113414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113414Inst : IEnumerable<long>
{
public static readonly long[] Value=A113414.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113414.Bytes);
public long this[int i]=>Value[i];

public static A113414Inst Instance=new A113414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113415
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,3L,5L,1L,8L,4L,7L,3L,8L,5L,14L,1L,10L,8L,11L,4L,18L,7L,13L,3L,17L,8L,22L,5L,16L,14L,17L,1L,26L,10L,26L,8L,20L,11L,30L,4L,22L,18L,23L,7L,42L,13L,25L,3L,30L,17L,38L,8L,28L,22L,38L,5L,42L,16L,31L,14L,32L,17L,55L,1L,44L,26L,35L,10L,50L,26L,37L,8L,38L,20L,65L,11L,50L,30L,41L };
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
public class A113415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113415Inst : IEnumerable<long>
{
public static readonly long[] Value=A113415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113415.Bytes);
public long this[int i]=>Value[i];

public static A113415Inst Instance=new A113415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113416
{
public static readonly long[] Value={ 1L,2L,-2L,-4L,-2L,-8L,4L,16L,-2L,14L,8L,-20L,4L,-24L,-16L,16L,-2L,36L,-14L,-36L,8L,-32L,20L,48L,4L,42L,24L,-40L,-16L,-56L,-16L,64L,-2L,40L,-36L,-64L,-14L,-72L,36L,48L,8L,84L,32L,-84L,20L,-56L,-48L,96L,4L,114L,-42L,-72L,24L,-104L,40L,80L,-16L,72L,56L,-116L,-16L,-120L,-64L,112L,-2L,96L,-40L,-132L,-36L,-96L,64L,144L,-14L };
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
public class A113416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113416Inst : IEnumerable<long>
{
public static readonly long[] Value=A113416.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113416.Bytes);
public long this[int i]=>Value[i];

public static A113416Inst Instance=new A113416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113417
{
public static readonly long[] Value={ 1L,-2L,-4L,8L,7L,-10L,-12L,8L,18L,-18L,-16L,24L,21L,-20L,-28L,32L,20L,-32L,-36L,24L,42L,-42L,-28L,48L,57L,-36L,-52L,40L,36L,-58L,-60L,56L,48L,-66L,-48L,72L,74L,-42L,-80L,80L,61L,-82L,-72L,56L,90L,-96L,-64L,72L,98L,-70L,-100L,104L,64L,-106L,-108L,72L,114L,-96L };
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
public class A113417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113417Inst : IEnumerable<long>
{
public static readonly long[] Value=A113417.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113417.Bytes);
public long this[int i]=>Value[i];

public static A113417Inst Instance=new A113417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113418
{
public static readonly long[] Value={ 1L,-1L,-2L,-1L,-4L,2L,8L,-1L,7L,4L,-10L,2L,-12L,-8L,8L,-1L,18L,-7L,-18L,4L,-16L,10L,24L,2L,21L,12L,-20L,-8L,-28L,-8L,32L,-1L,20L,-18L,-32L,-7L,-36L,18L,24L,4L,42L,16L,-42L,10L,-28L,-24L,48L,2L,57L,-21L,-36L,12L,-52L,20L,40L,-8L,36L,28L,-58L,-8L,-60L,-32L,56L,-1L,48L,-20L,-66L,-18L,-48L,32L,72L,-7L,74L,36L,-42L,18L,-80L,-24L };
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
public class A113418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113418Inst : IEnumerable<long>
{
public static readonly long[] Value=A113418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113418.Bytes);
public long this[int i]=>Value[i];

public static A113418Inst Instance=new A113418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113419
{
public static readonly long[] Value={ 1L,2L,-4L,-8L,7L,10L,-12L,-8L,18L,18L,-16L,-24L,21L,20L,-28L,-32L,20L,32L,-36L,-24L,42L,42L,-28L,-48L,57L,36L,-52L,-40L,36L,58L,-60L,-56L,48L,66L,-48L,-72L,74L,42L,-80L,-80L,61L,82L,-72L,-56L,90L,96L,-64L,-72L,98L,70L,-100L,-104L,64L,106L,-108L,-72L,114L,96L };
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
public class A113419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113419Inst : IEnumerable<long>
{
public static readonly long[] Value=A113419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113419.Bytes);
public long this[int i]=>Value[i];

public static A113419Inst Instance=new A113419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113420
{
public static readonly long[] Value={ 4L,10L,18L,25L,32L,42L,50L,58L,65L,72L,78L,83L,93L,106L,114L,125L,139L,143L,149L,157L,167L,176L,183L,194L,198L,209L,219L,221L,229L,237L,243L,250L,260L,270L,273L,278L,286L,294L,304L,314L,317L,323L,327L,337L,342L,352L,362L,371L,377L,394L,399L,405L,414L,420L };
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
public class A113420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113420Inst : IEnumerable<long>
{
public static readonly long[] Value=A113420.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113420.Bytes);
public long this[int i]=>Value[i];

public static A113420Inst Instance=new A113420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113421
{
public static readonly long[] Value={ 1L,-2L,-1L,4L,-4L,2L,6L,-8L,1L,8L,-12L,-4L,14L,-12L,4L,16L,-16L,-2L,18L,-16L,-6L,24L,-24L,8L,21L,-28L,-1L,24L,-28L,-8L,30L,-32L,12L,32L,-24L,4L,38L,-36L,-14L,32L,-40L,12L,42L,-48L,-4L,48L,-48L,-16L,43L,-42L,16L,56L,-52L,2L,48L,-48L,-18L,56L,-60L,16L,62L,-60L,6L,64L,-56L,-24L,66L,-64L,24L,48L,-72L,-8L,74L,-76L,-21L,72L };
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
public class A113421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113421Inst : IEnumerable<long>
{
public static readonly long[] Value=A113421.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113421.Bytes);
public long this[int i]=>Value[i];

public static A113421Inst Instance=new A113421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113422
{
public static readonly long[] Value={ 0L,2L,7L,15L,27L,42L,60L,82L,107L,135L,167L,202L,240L,282L,327L,375L,427L,482L,540L,602L,667L,735L,807L,882L,960L,1042L,1127L,1215L,1307L,1402L,1500L,1602L,1707L,1815L,1927L,2042L,2160L,2282L,2407L,2535L,2667L,2802L,2940L,3082L,3227L,3375L,3527L,3682L,3840L };
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
public class A113422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113422Inst : IEnumerable<long>
{
public static readonly long[] Value=A113422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113422.Bytes);
public long this[int i]=>Value[i];

public static A113422Inst Instance=new A113422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113423
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,-1L,0L,2L,1L,0L,2L,-2L,1L,-1L,2L,-2L,-2L,-2L,-1L,0L,2L,2L,-3L,0L,1L,1L,2L,2L,0L,2L,-2L,0L,1L,0L,-3L,2L,-2L,0L,1L,-2L,-4L,-1L,1L,2L,-4L,0L,2L,0L,0L,0L,0L,2L,3L,0L,3L,0L,2L,-2L,-1L,-2L,2L,-1L,0L,0L,7L,2L,0L,-6L,-2L,-2L,-2L,-2L,-2L,0L,-3L,0L,2L,0L,0L,4L,-2L,-2L,5L,-2L,-1L,1L,-2L,0L,1L,2L,2L,-2L,0L,2L,2L,4L,-2L,4L,0L,2L,0L,-2L,2L,0L,-3L,0L };
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
public class A113423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113423Inst : IEnumerable<long>
{
public static readonly long[] Value=A113423.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113423.Bytes);
public long this[int i]=>Value[i];

public static A113423Inst Instance=new A113423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113424
{
public static readonly BigInteger[] Value={ 1L,60L,13860L,4084080L,1338557220L,465817912560L,168470811709200L,62588625639883200L,BigInteger.Parse("23717177328413240100"),BigInteger.Parse("9124964373613212524400"),BigInteger.Parse("3553261127084984957001360"),BigInteger.Parse("1397224499394244497967972800") };
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
public class A113424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113424Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113424.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113424.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113424Inst Instance=new A113424Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113425
{
public static readonly long[] Value={ 2L,3L,7L,17L,23L,37L,47L,61L,79L,101L,127L,139L,167L,197L,223L,257L,293L,317L,359L,401L,439L,487L,523L,577L,619L,677L,727L,787L,839L,907L,967L,1021L,1087L,1153L,1223L,1297L,1367L,1447L,1523L,1601L,1669L,1759L,1847L,1933L,2027L,2113L,2207L,2309L,2399L,2503L };
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
public class A113425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113425Inst : IEnumerable<long>
{
public static readonly long[] Value=A113425.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113425.Bytes);
public long this[int i]=>Value[i];

public static A113425Inst Instance=new A113425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113426
{
public static readonly long[] Value={ 2L,5L,11L,17L,23L,37L,47L,67L,83L,101L,127L,149L,167L,197L,227L,257L,293L,331L,359L,401L,443L,487L,523L,577L,631L,677L,727L,787L,839L,907L,967L,1021L,1091L,1153L,1223L,1297L,1367L,1447L,1523L,1601L,1693L,1759L,1847L,1933L,2027L,2113L,2207L,2309L,2399L,2503L };
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
public class A113426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113426Inst : IEnumerable<long>
{
public static readonly long[] Value=A113426.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113426.Bytes);
public long this[int i]=>Value[i];

public static A113426Inst Instance=new A113426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113427
{
public static readonly long[] Value={ 1L,6L,6L,6L,6L,6L,6L,6L,14L,6L,10L,6L,6L,6L,6L,10L,6L,10L,6L,6L,6L,6L,10L,14L,14L,6L,10L,6L,6L,6L,6L,10L,10L,6L,6L,6L,6L,10L,6L,6L,6L,10L,6L,6L,6L,6L,10L,6L,6L,6L,10L,10L,6L,6L,6L,14L,10L,10L,10L,14L,14L,10L,6L,6L,14L,6L,6L,6L,6L,10L,6L,10L,10L,6L,6L,6L,6L,6L,22L,10L,10L,6L,6L,6L,6L };
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
public class A113427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113427Inst : IEnumerable<long>
{
public static readonly long[] Value=A113427.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113427.Bytes);
public long this[int i]=>Value[i];

public static A113427Inst Instance=new A113427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113428
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A113428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113428Inst : IEnumerable<long>
{
public static readonly long[] Value=A113428.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113428.Bytes);
public long this[int i]=>Value[i];

public static A113428Inst Instance=new A113428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113429
{
public static readonly long[] Value={ 1L,-1L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L };
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
public class A113429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113429Inst : IEnumerable<long>
{
public static readonly long[] Value=A113429.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113429.Bytes);
public long this[int i]=>Value[i];

public static A113429Inst Instance=new A113429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113430
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A113430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113430Inst : IEnumerable<long>
{
public static readonly long[] Value=A113430.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113430.Bytes);
public long this[int i]=>Value[i];

public static A113430Inst Instance=new A113430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113431
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A113431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113431Inst : IEnumerable<long>
{
public static readonly long[] Value=A113431.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113431.Bytes);
public long this[int i]=>Value[i];

public static A113431Inst Instance=new A113431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113432
{
public static readonly long[] Value={ 4L,9L,10L,25L,33L,49L,55L,65L,82L,129L,145L,217L,289L,649L,865L,973L,1537L,1945L,2049L,2305L,3073L,4097L,4609L,5833L,6145L,6913L,8193L,8749L,9217L,11665L,13123L,15553L,20737L,23329L,24577L,27649L,31105L,34993L,41473L,62209L,69985L,73729L,78733L };
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
public class A113432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113432Inst : IEnumerable<long>
{
public static readonly long[] Value=A113432.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113432.Bytes);
public long this[int i]=>Value[i];

public static A113432Inst Instance=new A113432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113433
{
public static readonly long[] Value={ 4L,6L,9L,10L,14L,15L,21L,25L,26L,34L,35L,38L,39L,49L,51L,57L,65L,74L,85L,91L,95L,111L,119L,133L,146L,169L,185L,194L,218L,219L,221L,247L,259L,289L,291L,323L,326L,327L,361L,365L,386L,481L,485L,489L,511L,514L,545L,579L,629L,679L,703L,763L,771L,815L,866L,949L,965L };
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
public class A113433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113433Inst : IEnumerable<long>
{
public static readonly long[] Value=A113433.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113433.Bytes);
public long this[int i]=>Value[i];

public static A113433Inst Instance=new A113433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113434
{
public static readonly long[] Value={ 4L,9L,10L,25L,49L,65L,289L };
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
public class A113434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113434Inst : IEnumerable<long>
{
public static readonly long[] Value=A113434.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113434.Bytes);
public long this[int i]=>Value[i];

public static A113434Inst Instance=new A113434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113435
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,7L,11L,16L,26L,41L,62L,98L,154L,237L,371L,581L,901L,1406L,2197L,3418L,5329L,8317L,12956L,20196L,31501L,49096L,76532L,119338L,186029L,289997L,452141L,704861L,1098826L,1713111L,2670692L,4163483L,6490879L,10119152L,15775426L };
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
public class A113435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113435Inst : IEnumerable<long>
{
public static readonly long[] Value=A113435.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113435.Bytes);
public long this[int i]=>Value[i];

public static A113435Inst Instance=new A113435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113436
{
public static readonly long[] Value={ 1L,2L,7L,26L,98L,371L,1406L,5329L,20196L,76532L,289997L,1098826L,4163483L,15775426L,59772826L,226477879L,858118966L,3251390237L,12319431012L,46677994276L,176861668393L,670124115506L,2539082288671L,9620514646154L,36451871795186L };
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
public class A113436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113436Inst : IEnumerable<long>
{
public static readonly long[] Value=A113436.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113436.Bytes);
public long this[int i]=>Value[i];

public static A113436Inst Instance=new A113436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113437
{
public static readonly long[] Value={ 1L,3L,11L,41L,154L,581L,2197L,8317L,31501L,119338L,452141L,1713111L,6490879L,24593701L,93184802L,353074657L,1337790401L,5068852073L,19205744921L,72770053106L,275723780329L,1044710007771L,3958378188707L,14998188734897L };
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
public class A113437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113437Inst : IEnumerable<long>
{
public static readonly long[] Value=A113437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113437.Bytes);
public long this[int i]=>Value[i];

public static A113437Inst Instance=new A113437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113438
{
public static readonly long[] Value={ 1L,4L,16L,62L,237L,901L,3418L,12956L,49096L,186029L,704861L,2670692L,10119152L,38341126L,145273353L,550436561L,2085588866L,7902239404L,29941371656L,113447051497L,429847830217L,1628681887876L,6171031956688L,23381874459566L,88593294803061L,335677616363629L };
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
public class A113438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113438Inst : IEnumerable<long>
{
public static readonly long[] Value=A113438.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113438.Bytes);
public long this[int i]=>Value[i];

public static A113438Inst Instance=new A113438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113439
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,8L,12L,17L,23L,34L,50L,72L,101L,146L,212L,306L,436L,627L,905L,1305L,1871L,2689L,3872L,5577L,8014L,11521L,16576L,23858L,34309L,49337L,70968L,102108L,146868L,211233L,303832L,437080L,628708L,904306L,1300737L,1871065L,2691401L };
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
public class A113439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113439Inst : IEnumerable<long>
{
public static readonly long[] Value=A113439.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113439.Bytes);
public long this[int i]=>Value[i];

public static A113439Inst Instance=new A113439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113440
{
public static readonly long[] Value={ 1L,2L,8L,34L,146L,627L,2689L,11521L,49337L,211233L,904306L,3871305L,16572812L,70947073L,303719624L,1300203634L,5566087073L,23828058969L,102006385362L,436682772844L,1869410868456L,8002827727921L,34259590954322L };
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
public class A113440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113440Inst : IEnumerable<long>
{
public static readonly long[] Value=A113440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113440.Bytes);
public long this[int i]=>Value[i];

public static A113440Inst Instance=new A113440Inst();

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