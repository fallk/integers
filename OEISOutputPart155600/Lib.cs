using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198705
{
public static readonly BigInteger[] Value={ 3L,488L,95209L,30407251L,10239497407L,3588013895024L,1259339424693241L,443261846229550014L,BigInteger.Parse("156011269606577035531"),BigInteger.Parse("54921491956679070862154"),BigInteger.Parse("19333997309693254684034877"),BigInteger.Parse("6806251639074571612122108120") };
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
public class A198705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198705.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198705Inst Instance=new A198705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198706
{
public static readonly long[] Value={ 6L,3508L,2654693L,3075124662L,3588013895024L,4285681886701131L };
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
public class A198706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198706Inst : IEnumerable<long>
{
public static readonly long[] Value=A198706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198706.Bytes);
public long this[int i]=>Value[i];

public static A198706Inst Instance=new A198706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198707
{
public static readonly long[] Value={ 11L,27422L,77622801L,316137386807L,1259339424693241L };
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
public class A198707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198707Inst : IEnumerable<long>
{
public static readonly long[] Value=A198707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198707.Bytes);
public long this[int i]=>Value[i];

public static A198707Inst Instance=new A198707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198708
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,2L,14L,14L,2L,3L,76L,185L,76L,3L,6L,488L,3893L,3893L,488L,6L,11L,3508L,95209L,322230L,95209L,3508L,11L,23L,27422L,2654693L,30407251L,30407251L,2654693L,27422L,23L,47L,227045L,77622801L,3075124662L,10239497407L,3075124662L,77622801L,227045L };
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
public class A198708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198708Inst : IEnumerable<long>
{
public static readonly long[] Value=A198708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198708.Bytes);
public long this[int i]=>Value[i];

public static A198708Inst Instance=new A198708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198709
{
public static readonly BigInteger[] Value={ 1L,4L,401L,250031L,851787199L,15835552812749L,1606578861528554441L,BigInteger.Parse("889483369334451647489771"),BigInteger.Parse("2687450673445984030296455830409") };
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
public class A198709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198709Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198709.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198709.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198709Inst Instance=new A198709Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198710
{
public static readonly BigInteger[] Value={ 2L,25L,401L,6548L,107042L,1749965L,28609241L,467717288L,7646461682L,125007943505L,2043688517681L,33411178843628L,546221629207922L,8929887496964645L,145989990956749721L,2386712874803449568L,BigInteger.Parse("39019101990629849762") };
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
public class A198710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198710.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198710Inst Instance=new A198710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198711
{
public static readonly BigInteger[] Value={ 5L,172L,6548L,250031L,9548295L,364637102L,13925032958L,531779578441L,20307996787865L,775536991678112L,29616787512285048L,1131028064429979731L,BigInteger.Parse("43192546862380323515"),BigInteger.Parse("1649469330720040937602"),BigInteger.Parse("62991170251091380482818") };
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
public class A198711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198711.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198711Inst Instance=new A198711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198712
{
public static readonly BigInteger[] Value={ 14L,1201L,107042L,9548295L,851787199L,75987485516L,6778819400772L,604736581320925L,53948385378521909L,4812720805166620356L,BigInteger.Parse("429341516830025751982"),BigInteger.Parse("38301440209010857426775"),BigInteger.Parse("3416861087749979581617789") };
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
public class A198712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198712.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198712Inst Instance=new A198712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198713
{
public static readonly BigInteger[] Value={ 41L,8404L,1749965L,364637102L,75987485516L,15835552812749L,3300094936852775L,687733321797971342L,BigInteger.Parse("143322307142433346196"),BigInteger.Parse("29868095632655586533219"),BigInteger.Parse("6224454258216624967544685"),BigInteger.Parse("1297164418016611898106044912") };
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
public class A198713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198713.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198713Inst Instance=new A198713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198714
{
public static readonly BigInteger[] Value={ 122L,58825L,28609241L,13925032958L,6778819400772L,3300094936852775L,1606578861528554441L,BigInteger.Parse("782129027546108478208"),BigInteger.Parse("380763168247444298026697"),BigInteger.Parse("185366606445710896112671190"),BigInteger.Parse("90241867886483759053800200221") };
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
public class A198714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198714Inst Instance=new A198714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198715
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,5L,25L,25L,5L,14L,172L,401L,172L,14L,41L,1201L,6548L,6548L,1201L,41L,122L,8404L,107042L,250031L,107042L,8404L,122L,365L,58825L,1749965L,9548295L,9548295L,1749965L,58825L,365L,1094L,411772L,28609241L,364637102L,851787199L,364637102L };
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
public class A198715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198715Inst : IEnumerable<long>
{
public static readonly long[] Value=A198715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198715.Bytes);
public long this[int i]=>Value[i];

public static A198715Inst Instance=new A198715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198716
{
public static readonly BigInteger[] Value={ 1L,4L,2027L,173549032L,601755060211186L,BigInteger.Parse("56817439251356046537693") };
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
public class A198716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198716Inst Instance=new A198716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198717
{
public static readonly BigInteger[] Value={ 1L,4L,34L,499L,10507L,272410L,7817980L,234638905L,7176366133L,221220625936L,6841771033846L,211886983790431L,6565800345745279L,203504808219690982L,6308194354577750032L,BigInteger.Parse("195548116214389189477"),BigInteger.Parse("6061914804816147034345") };
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
public class A198717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198717.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198717Inst Instance=new A198717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198718
{
public static readonly BigInteger[] Value={ 2L,34L,2027L,232841L,34003792L,5315840795L,846047363854L,135284283124811L,21658679381667910L,3468618095206638077L,BigInteger.Parse("555543217744635684040"),BigInteger.Parse("88979288917879960297469"),BigInteger.Parse("14251565534424509235823960") };
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
public class A198718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198718.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198718Inst Instance=new A198718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198719
{
public static readonly BigInteger[] Value={ 5L,499L,232841L,173549032L,141168480719L,116492275674072L,96356630422085931L,BigInteger.Parse("79732515488691835557"),BigInteger.Parse("65980773070548173552412"),BigInteger.Parse("54601426682639992758644080"),BigInteger.Parse("45184694908666112938858073903"),BigInteger.Parse("37392013011256643009627621268829") };
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
public class A198719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198719.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198719Inst Instance=new A198719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198720
{
public static readonly BigInteger[] Value={ 15L,10507L,34003792L,141168480719L,601755060211186L,2572072097029554676L,BigInteger.Parse("10996875674843226590993"),BigInteger.Parse("47018449018254334323435148"),BigInteger.Parse("201033586140960282012089201427"),BigInteger.Parse("859545914195473034723104861028749") };
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
public class A198720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198720.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198720Inst Instance=new A198720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198721
{
public static readonly BigInteger[] Value={ 52L,272410L,5315840795L,116492275674072L,2572072097029554676L,BigInteger.Parse("56817439251356046537693"),BigInteger.Parse("1255145613308486512244031328"),BigInteger.Parse("27727293796669883715931085888092"),BigInteger.Parse("612520905593913038338760996059873808") };
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
public class A198721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198721.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198721Inst Instance=new A198721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198722
{
public static readonly BigInteger[] Value={ 203L,7817980L,846047363854L,96356630422085931L,BigInteger.Parse("10996875674843226590993"),BigInteger.Parse("1255145613308486512244031328") };
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
public class A198722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198722.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198722Inst Instance=new A198722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198723
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,5L,34L,34L,5L,15L,499L,2027L,499L,15L,52L,10507L,232841L,232841L,10507L,52L,203L,272410L,34003792L,173549032L,34003792L,272410L,203L,876L,7817980L,5315840795L,141168480719L,141168480719L,5315840795L,7817980L,876L,4111L };
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
public class A198723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198723Inst : IEnumerable<long>
{
public static readonly long[] Value=A198723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198723.Bytes);
public long this[int i]=>Value[i];

public static A198723Inst Instance=new A198723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198724
{
public static readonly long[] Value={ 2L,3L,1L,6L,4L,1L,1L,6L,3L,2L,1L,2L,2L,1L,1L,1L,2L,3L,1L,3L,1L,2L,1L,2L,6L,1L,1L,1L,4L,3L,1L,2L,2L,3L,1L,1L,5L,1L,1L,3L,1L,1L,1L,2L,3L,1L,1L,3L,1L,6L,1L,2L,2L,1L,1L,1L,4L,2L,1L,1L,1L,2L,1L,2L,2L,1L,1L,3L,2L,1L,1L,2L,2L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,3L,1L };
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
public class A198724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198724Inst : IEnumerable<long>
{
public static readonly long[] Value=A198724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198724.Bytes);
public long this[int i]=>Value[i];

public static A198724Inst Instance=new A198724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198725
{
public static readonly BigInteger[] Value={ 5L,41L,257L,1553L,15672832817L,121871948002097L,4387390128075569L,BigInteger.Parse("161656255492952812128627920091307258673"),BigInteger.Parse("34917751186477807419783630739722367873841") };
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
public class A198725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198725.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198725Inst Instance=new A198725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198726
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,4L,6L,7L,9L,11L,13L,17L,21L,24L,29L,37L,42L,49L,60L,70L,82L,96L,111L,129L,152L,173L,199L,234L,266L,302L,349L,399L,451L,515L,585L,661L,752L,847L,954L,1081L,1215L,1359L,1531L,1719L,1917L,2147L,2400L,2675L,2985L,3322L,3690L,4110L,4563L,5048L,5603L };
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
public class A198726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198726Inst : IEnumerable<long>
{
public static readonly long[] Value=A198726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198726.Bytes);
public long this[int i]=>Value[i];

public static A198726Inst Instance=new A198726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198727
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,1L,0L,2L,2L,1L,2L,2L,3L,4L,3L,2L,6L,6L,1L,5L,9L,6L,5L,9L,9L,9L,11L,8L,13L,17L,11L,12L,22L,19L,13L,23L,25L,22L,26L,28L,30L,37L,34L,31L,47L,45L,35L,50L,61L,52L,56L,69L,68L,76L,74L,72L,95L,100L,82L,100L,130L,112L,113L,139L,144L,149L,154L,156L,183L };
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
public class A198727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198727Inst : IEnumerable<long>
{
public static readonly long[] Value=A198727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198727.Bytes);
public long this[int i]=>Value[i];

public static A198727Inst Instance=new A198727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198728
{
public static readonly long[] Value={ 5L,6L,1L,5L,8L,9L,4L,2L,3L,5L,6L,5L,5L,1L,1L,3L,7L,3L,0L,4L,3L,0L,5L,1L,0L,6L,1L,3L,0L,2L,9L,7L,7L,0L,5L,2L,5L,7L,6L,8L,4L,2L,3L,2L,5L,4L,2L,6L,3L,1L,8L,2L,4L,8L,9L,8L,0L,3L,8L,4L,3L,5L,2L,7L,4L,2L,3L,0L,7L,3L,8L,9L,7L,4L,8L,5L,0L,8L,7L,6L,9L,5L,9L,2L,4L,5L,1L,2L,5L,7L,6L,5L,1L,3L,7L,6L,3L,8L,5L };
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
public class A198728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198728Inst : IEnumerable<long>
{
public static readonly long[] Value=A198728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198728.Bytes);
public long this[int i]=>Value[i];

public static A198728Inst Instance=new A198728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198729
{
public static readonly long[] Value={ 3L,2L,3L,2L,3L,8L,4L,8L,7L,1L,1L,1L,1L,4L,5L,2L,3L,3L,0L,8L,8L,4L,2L,6L,9L,5L,2L,0L,4L,9L,3L,4L,2L,8L,1L,8L,1L,4L,5L,0L,4L,2L,7L,6L,5L,6L,8L,5L,3L,3L,0L,2L,8L,0L,0L,1L,4L,8L,0L,2L,9L,6L,7L,4L,9L,4L,6L,0L,8L,0L,6L,9L,5L,9L,9L,1L,5L,5L,8L,6L,2L,9L,9L,9L,1L,3L,3L,2L,0L,8L,8L,0L,1L,3L,2L,2L,7L,4L,7L };
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
public class A198729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198729Inst : IEnumerable<long>
{
public static readonly long[] Value=A198729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198729.Bytes);
public long this[int i]=>Value[i];

public static A198729Inst Instance=new A198729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198730
{
public static readonly long[] Value={ 5L,7L,6L,4L,5L,6L,9L,4L,4L,5L,6L,1L,7L,1L,8L,1L,1L,0L,8L,6L,3L,3L,7L,9L,4L,8L,7L,6L,4L,5L,5L,7L,3L,4L,7L,7L,4L,7L,2L,5L,5L,1L,0L,6L,9L,5L,3L,9L,7L,7L,7L,6L,7L,1L,6L,4L,7L,5L,1L,4L,4L,9L,7L,9L,5L,7L,0L,5L,7L,3L,4L,3L,7L,0L,6L,2L,0L,9L,4L,3L,8L,0L,9L,8L,0L,3L,6L,9L,6L,4L,6L,4L,2L,4L,9L,8L,0L,1L,9L };
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
public class A198730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198730Inst : IEnumerable<long>
{
public static readonly long[] Value=A198730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198730.Bytes);
public long this[int i]=>Value[i];

public static A198730Inst Instance=new A198730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198731
{
public static readonly long[] Value={ 3L,9L,6L,2L,1L,7L,3L,3L,6L,3L,5L,0L,3L,2L,8L,5L,6L,0L,0L,2L,3L,1L,9L,7L,7L,9L,1L,1L,1L,0L,6L,4L,9L,0L,9L,8L,9L,8L,8L,2L,7L,1L,9L,5L,0L,9L,9L,2L,4L,0L,7L,4L,4L,3L,0L,8L,7L,2L,6L,5L,9L,3L,5L,1L,1L,7L,6L,0L,4L,3L,4L,0L,4L,7L,6L,6L,4L,8L,8L,1L,4L,0L,5L,7L,3L,4L,4L,8L,9L,3L,6L,3L,2L,2L,5L,7L,5L,5L,0L };
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
public class A198731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198731Inst : IEnumerable<long>
{
public static readonly long[] Value=A198731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198731.Bytes);
public long this[int i]=>Value[i];

public static A198731Inst Instance=new A198731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198732
{
public static readonly long[] Value={ 5L,8L,5L,9L,0L,2L,3L,1L,0L,1L,6L,8L,1L,5L,4L,2L,7L,6L,4L,1L,0L,2L,2L,6L,4L,9L,9L,7L,0L,3L,2L,3L,2L,9L,9L,9L,0L,4L,5L,6L,8L,6L,9L,0L,9L,6L,1L,3L,1L,5L,0L,2L,8L,0L,2L,8L,8L,5L,4L,4L,6L,8L,1L,5L,1L,8L,0L,7L,4L,3L,3L,6L,9L,5L,3L,5L,2L,6L,2L,8L,3L,5L,0L,7L,1L,3L,6L,9L,1L,5L,0L,6L,6L,2L,2L,6L,6L,7L,8L };
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
public class A198732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198732Inst : IEnumerable<long>
{
public static readonly long[] Value=A198732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198732.Bytes);
public long this[int i]=>Value[i];

public static A198732Inst Instance=new A198732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198733
{
public static readonly long[] Value={ 4L,6L,9L,0L,3L,6L,1L,8L,0L,3L,9L,5L,3L,9L,4L,1L,7L,1L,9L,1L,6L,9L,5L,6L,7L,7L,6L,7L,6L,7L,7L,3L,0L,7L,4L,6L,0L,8L,9L,1L,1L,5L,1L,8L,4L,1L,9L,4L,7L,9L,0L,9L,4L,7L,4L,6L,2L,8L,4L,8L,4L,5L,2L,7L,3L,5L,0L,9L,7L,4L,8L,1L,2L,8L,1L,4L,2L,9L,3L,3L,6L,6L,4L,3L,5L,8L,7L,8L,4L,2L,0L,4L,9L,5L,7L,9L,1L,4L,6L,3L,2L,7L,8L,7L,4L,7L };
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
public class A198733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198733Inst : IEnumerable<long>
{
public static readonly long[] Value=A198733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198733.Bytes);
public long this[int i]=>Value[i];

public static A198733Inst Instance=new A198733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198734
{
public static readonly long[] Value={ 5L,9L,2L,4L,3L,5L,6L,3L,8L,0L,4L,5L,6L,0L,4L,6L,8L,8L,2L,3L,5L,2L,8L,6L,2L,5L,6L,3L,3L,7L,6L,7L,6L,3L,5L,6L,7L,3L,7L,6L,5L,6L,2L,5L,0L,2L,5L,9L,9L,7L,8L,1L,6L,6L,0L,3L,4L,9L,9L,0L,5L,8L,9L,3L,0L,5L,5L,7L,5L,1L,9L,9L,6L,8L,1L,3L,8L,5L,2L,5L,9L,6L,0L,7L,7L,5L,1L,0L,2L,3L,2L,8L,1L,7L,8L,5L,3L,1L,5L };
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
public class A198734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198734Inst : IEnumerable<long>
{
public static readonly long[] Value=A198734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198734.Bytes);
public long this[int i]=>Value[i];

public static A198734Inst Instance=new A198734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198735
{
public static readonly long[] Value={ 2L,0L,9L,2L,9L,8L,6L,7L,8L,0L,2L,5L,1L,1L,0L,3L,4L,2L,5L,9L,2L,2L,6L,7L,8L,2L,0L,1L,3L,6L,9L,7L,6L,0L,4L,3L,2L,3L,7L,0L,2L,4L,5L,6L,1L,8L,8L,4L,1L,8L,6L,1L,5L,1L,3L,2L,4L,6L,3L,7L,7L,7L,7L,1L,1L,4L,9L,9L,2L,3L,4L,3L,2L,3L,2L,1L,6L,3L,6L,4L,5L,2L,0L,8L,2L,5L,7L,4L,5L,9L,9L,1L,4L,5L,2L,4L,9L,9L,5L };
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
public class A198735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198735Inst : IEnumerable<long>
{
public static readonly long[] Value=A198735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198735.Bytes);
public long this[int i]=>Value[i];

public static A198735Inst Instance=new A198735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198736
{
public static readonly long[] Value={ 4L,8L,9L,3L,1L,2L,2L,6L,7L,2L,9L,6L,3L,2L,9L,9L,0L,5L,5L,3L,9L,6L,7L,3L,1L,9L,0L,5L,8L,0L,6L,7L,4L,9L,4L,9L,7L,3L,5L,2L,8L,3L,6L,1L,7L,5L,7L,4L,1L,1L,7L,1L,1L,3L,0L,3L,7L,8L,8L,3L,6L,9L,7L,5L,9L,4L,0L,1L,7L,4L,2L,8L,7L,7L,3L,4L,3L,8L,6L,9L,8L,9L,3L,8L,3L,9L,9L,9L,5L,4L,4L,3L,0L,3L,3L,7L,8L,8L,7L };
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
public class A198736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198736Inst : IEnumerable<long>
{
public static readonly long[] Value=A198736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198736.Bytes);
public long this[int i]=>Value[i];

public static A198736Inst Instance=new A198736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198737
{
public static readonly long[] Value={ 2L,7L,5L,8L,7L,3L,1L,1L,9L,1L,6L,3L,8L,5L,5L,4L,0L,0L,1L,1L,1L,8L,9L,3L,5L,3L,5L,8L,1L,4L,9L,2L,2L,6L,6L,6L,4L,5L,6L,4L,1L,8L,2L,7L,3L,8L,4L,3L,7L,3L,5L,2L,2L,3L,5L,5L,8L,4L,2L,1L,5L,4L,1L,5L,0L,9L,2L,9L,7L,8L,4L,2L,8L,0L,2L,2L,5L,4L,2L,8L,6L,6L,6L,2L,0L,9L,6L,0L,2L,9L,3L,6L,7L,2L,6L,7L,7L,6L,1L };
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
public class A198737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198737Inst : IEnumerable<long>
{
public static readonly long[] Value=A198737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198737.Bytes);
public long this[int i]=>Value[i];

public static A198737Inst Instance=new A198737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198738
{
public static readonly long[] Value={ 5L,2L,9L,4L,4L,2L,8L,9L,4L,6L,9L,5L,2L,1L,1L,7L,6L,4L,0L,5L,6L,0L,5L,3L,3L,3L,9L,7L,0L,4L,6L,4L,5L,0L,0L,7L,5L,7L,3L,6L,7L,8L,3L,8L,6L,1L,9L,5L,4L,9L,3L,1L,8L,1L,4L,1L,4L,2L,6L,2L,3L,9L,6L,5L,8L,2L,1L,1L,4L,9L,9L,8L,0L,5L,4L,5L,8L,4L,0L,5L,7L,2L,3L,6L,3L,3L,9L,6L,8L,6L,2L,5L,9L,9L,6L,2L,8L,7L,8L };
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
public class A198738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198738Inst : IEnumerable<long>
{
public static readonly long[] Value=A198738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198738.Bytes);
public long this[int i]=>Value[i];

public static A198738Inst Instance=new A198738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198739
{
public static readonly long[] Value={ 3L,4L,1L,9L,4L,0L,6L,5L,0L,5L,7L,6L,2L,9L,4L,6L,3L,3L,2L,7L,3L,0L,4L,5L,5L,7L,1L,6L,2L,1L,1L,2L,4L,3L,2L,6L,3L,7L,2L,1L,6L,0L,1L,6L,8L,0L,2L,1L,4L,2L,7L,7L,7L,4L,7L,5L,5L,9L,4L,7L,6L,2L,5L,9L,8L,5L,6L,5L,3L,2L,2L,4L,1L,6L,3L,3L,9L,0L,0L,0L,1L,9L,2L,4L,6L,7L,4L,7L,2L,8L,0L,4L,0L,2L,4L,6L,6L,4L,1L };
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
public class A198739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198739Inst : IEnumerable<long>
{
public static readonly long[] Value=A198739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198739.Bytes);
public long this[int i]=>Value[i];

public static A198739Inst Instance=new A198739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198740
{
public static readonly long[] Value={ 5L,5L,1L,5L,4L,3L,6L,9L,7L,8L,0L,8L,2L,7L,9L,5L,0L,1L,9L,2L,4L,9L,8L,7L,5L,0L,5L,3L,4L,1L,8L,1L,1L,5L,0L,7L,5L,8L,0L,0L,0L,7L,0L,1L,4L,4L,5L,2L,7L,5L,5L,2L,0L,0L,0L,7L,1L,6L,2L,0L,8L,0L,6L,1L,7L,4L,4L,1L,4L,0L,0L,3L,1L,4L,2L,4L,4L,5L,5L,4L,5L,0L,8L,1L,4L,9L,0L,5L,7L,2L,6L,6L,5L,1L,8L,0L,7L,9L,6L };
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
public class A198740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198740Inst : IEnumerable<long>
{
public static readonly long[] Value=A198740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198740.Bytes);
public long this[int i]=>Value[i];

public static A198740Inst Instance=new A198740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198741
{
public static readonly long[] Value={ 4L,0L,7L,7L,6L,9L,7L,8L,8L,4L,8L,7L,7L,6L,9L,8L,5L,0L,3L,7L,7L,6L,4L,9L,7L,2L,1L,8L,9L,7L,2L,6L,8L,2L,9L,6L,9L,0L,7L,4L,4L,3L,8L,9L,4L,0L,7L,3L,6L,9L,1L,1L,7L,7L,8L,1L,8L,1L,6L,7L,1L,6L,2L,6L,0L,2L,2L,8L,1L,5L,7L,3L,1L,0L,0L,7L,2L,2L,9L,2L,0L,4L,5L,3L,0L,2L,7L,8L,2L,6L,8L,8L,3L,6L,0L,4L,3L,7L,0L };
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
public class A198741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198741Inst : IEnumerable<long>
{
public static readonly long[] Value=A198741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198741.Bytes);
public long this[int i]=>Value[i];

public static A198741Inst Instance=new A198741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198742
{
public static readonly long[] Value={ 5L,6L,5L,5L,5L,5L,2L,1L,5L,8L,6L,1L,7L,6L,2L,3L,0L,9L,4L,3L,2L,5L,7L,6L,2L,8L,3L,7L,4L,7L,4L,0L,3L,7L,5L,5L,8L,8L,6L,0L,7L,4L,3L,7L,7L,2L,2L,7L,9L,8L,9L,3L,8L,8L,0L,9L,7L,4L,3L,1L,5L,1L,6L,5L,6L,2L,0L,3L,9L,2L,0L,3L,2L,5L,0L,3L,8L,6L,4L,9L,0L,6L,2L,7L,7L,6L,7L,9L,5L,6L,4L,4L,1L,4L,3L,6L,4L,2L,8L };
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
public class A198742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198742Inst : IEnumerable<long>
{
public static readonly long[] Value=A198742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198742.Bytes);
public long this[int i]=>Value[i];

public static A198742Inst Instance=new A198742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198743
{
public static readonly long[] Value={ 4L,7L,3L,4L,6L,8L,7L,7L,0L,2L,7L,4L,7L,3L,6L,7L,9L,7L,1L,9L,5L,5L,2L,4L,7L,3L,4L,8L,4L,6L,5L,9L,8L,9L,7L,5L,9L,8L,7L,5L,3L,4L,1L,5L,1L,9L,3L,5L,7L,1L,7L,9L,1L,1L,8L,6L,1L,1L,4L,7L,6L,1L,9L,5L,2L,7L,1L,4L,5L,8L,1L,2L,5L,1L,6L,8L,0L,3L,0L,6L,8L,8L,4L,0L,9L,6L,3L,1L,7L,1L,6L,9L,5L,5L,7L,9L,9L,0L,6L };
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
public class A198743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198743Inst : IEnumerable<long>
{
public static readonly long[] Value=A198743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198743.Bytes);
public long this[int i]=>Value[i];

public static A198743Inst Instance=new A198743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198744
{
public static readonly long[] Value={ 5L,7L,5L,2L,3L,6L,4L,5L,3L,5L,9L,1L,3L,2L,3L,3L,6L,5L,5L,9L,1L,0L,8L,1L,0L,8L,0L,6L,9L,5L,6L,0L,3L,2L,3L,5L,4L,1L,6L,5L,2L,2L,2L,2L,8L,3L,8L,5L,2L,6L,2L,4L,8L,7L,9L,8L,1L,5L,6L,8L,9L,8L,6L,9L,3L,6L,8L,8L,5L,4L,2L,6L,2L,6L,2L,4L,2L,8L,1L,5L,7L,8L,8L,7L,8L,5L,5L,5L,3L,0L,7L,6L,7L,6L,7L,0L,5L,7L,0L };
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
public class A198744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198744Inst : IEnumerable<long>
{
public static readonly long[] Value=A198744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198744.Bytes);
public long this[int i]=>Value[i];

public static A198744Inst Instance=new A198744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198745
{
public static readonly long[] Value={ 2L,7L,4L,1L,8L,0L,1L,4L,1L,0L,8L,4L,6L,8L,0L,8L,0L,5L,1L,2L,7L,6L,0L,1L,5L,7L,1L,5L,5L,3L,2L,4L,4L,4L,6L,7L,5L,9L,5L,1L,6L,3L,5L,6L,9L,4L,6L,9L,6L,8L,6L,4L,6L,9L,9L,9L,6L,0L,8L,6L,5L,2L,2L,3L,2L,2L,5L,8L,9L,7L,1L,1L,4L,4L,0L,7L,3L,4L,3L,6L,7L,0L,4L,8L,1L,8L,1L,1L,1L,5L,2L,4L,0L,0L,5L,2L,2L,2L,4L };
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
public class A198745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198745Inst : IEnumerable<long>
{
public static readonly long[] Value=A198745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198745.Bytes);
public long this[int i]=>Value[i];

public static A198745Inst Instance=new A198745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198746
{
public static readonly long[] Value={ 5L,8L,1L,2L,7L,3L,2L,1L,6L,9L,1L,3L,7L,8L,8L,4L,4L,4L,5L,4L,9L,2L,8L,7L,1L,8L,3L,0L,0L,0L,1L,5L,4L,2L,5L,3L,1L,6L,0L,0L,3L,2L,3L,3L,4L,3L,2L,4L,5L,2L,6L,8L,6L,6L,5L,4L,9L,5L,6L,0L,4L,5L,6L,1L,4L,8L,9L,0L,5L,5L,3L,3L,6L,3L,3L,5L,5L,6L,4L,6L,8L,5L,5L,0L,2L,4L,0L,2L,3L,7L,5L,9L,9L,0L,2L,8L,8L,3L,9L };
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
public class A198746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198746Inst : IEnumerable<long>
{
public static readonly long[] Value=A198746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198746.Bytes);
public long this[int i]=>Value[i];

public static A198746Inst Instance=new A198746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198747
{
public static readonly long[] Value={ 4L,0L,5L,8L,2L,4L,4L,8L,7L,6L,4L,7L,7L,9L,7L,6L,1L,8L,3L,7L,4L,9L,9L,8L,2L,3L,6L,2L,4L,2L,3L,3L,6L,9L,4L,8L,4L,0L,9L,6L,0L,9L,6L,7L,1L,7L,8L,0L,0L,4L,7L,5L,0L,8L,1L,1L,7L,1L,9L,3L,5L,7L,3L,5L,3L,7L,4L,3L,0L,5L,3L,6L,4L,4L,1L,6L,3L,2L,2L,6L,2L,6L,5L,7L,5L,7L,0L,8L,0L,5L,3L,3L,1L,7L,3L,0L,0L,1L,8L };
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
public class A198747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198747Inst : IEnumerable<long>
{
public static readonly long[] Value=A198747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198747.Bytes);
public long this[int i]=>Value[i];

public static A198747Inst Instance=new A198747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198748
{
public static readonly long[] Value={ 5L,9L,4L,7L,3L,0L,0L,2L,9L,2L,2L,8L,2L,2L,7L,8L,3L,1L,5L,0L,1L,1L,1L,5L,0L,8L,4L,2L,6L,0L,7L,9L,7L,7L,1L,1L,8L,3L,6L,3L,3L,1L,5L,8L,8L,4L,1L,4L,9L,3L,4L,4L,9L,9L,6L,7L,6L,2L,9L,0L,9L,5L,0L,6L,2L,1L,8L,1L,7L,2L,9L,3L,0L,6L,1L,3L,8L,8L,2L,5L,5L,1L,1L,9L,0L,3L,2L,7L,0L,3L,5L,0L,4L,5L,0L,4L,6L,6L,2L };
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
public class A198748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198748Inst : IEnumerable<long>
{
public static readonly long[] Value=A198748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198748.Bytes);
public long this[int i]=>Value[i];

public static A198748Inst Instance=new A198748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198749
{
public static readonly long[] Value={ 5L,3L,7L,1L,0L,1L,6L,7L,7L,8L,2L,4L,5L,6L,8L,0L,5L,8L,5L,8L,0L,1L,2L,9L,8L,6L,6L,0L,9L,1L,4L,4L,0L,4L,4L,5L,8L,3L,3L,7L,9L,1L,9L,2L,4L,8L,6L,2L,4L,4L,2L,0L,3L,4L,4L,0L,6L,5L,5L,6L,3L,3L,9L,9L,9L,2L,1L,7L,1L,4L,2L,2L,7L,6L,1L,9L,5L,3L,1L,4L,9L,6L,7L,0L,8L,7L,2L,0L,5L,9L,1L,1L,2L,6L,3L,7L,1L,8L,8L };
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
public class A198749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198749Inst : IEnumerable<long>
{
public static readonly long[] Value=A198749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198749.Bytes);
public long this[int i]=>Value[i];

public static A198749Inst Instance=new A198749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198750
{
public static readonly long[] Value={ 6L,0L,2L,1L,9L,9L,0L,1L,9L,6L,3L,9L,7L,5L,8L,4L,0L,6L,9L,0L,5L,2L,9L,6L,4L,1L,3L,9L,4L,1L,9L,5L,9L,7L,9L,5L,1L,4L,7L,0L,1L,1L,4L,9L,4L,9L,6L,9L,3L,1L,5L,7L,6L,2L,7L,5L,3L,4L,2L,6L,2L,2L,8L,6L,3L,7L,9L,0L,1L,2L,2L,8L,4L,4L,9L,1L,0L,5L,5L,2L,6L,3L,6L,4L,4L,0L,8L,9L,7L,9L,3L,2L,1L,9L,0L,7L,3L,5L,5L };
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
public class A198750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198750Inst : IEnumerable<long>
{
public static readonly long[] Value=A198750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198750.Bytes);
public long this[int i]=>Value[i];

public static A198750Inst Instance=new A198750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198751
{
public static readonly long[] Value={ 6L,6L,8L,2L,1L,2L,6L,3L,6L,4L,8L,8L,9L,8L,1L,0L,3L,7L,0L,7L,3L,4L,2L,7L,9L,3L,3L,0L,6L,1L,0L,8L,5L,1L,5L,8L,0L,7L,7L,8L,9L,5L,6L,5L,9L,6L,5L,7L,1L,7L,7L,3L,7L,4L,3L,2L,9L,3L,6L,8L,7L,7L,5L,3L,5L,6L,9L,7L,4L,2L,4L,3L,4L,2L,0L,9L,1L,5L,3L,3L,9L,8L,1L,1L,5L,8L,0L,4L,9L,3L,2L,1L,2L,1L,8L,2L,3L,3L,9L };
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
public class A198751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198751Inst : IEnumerable<long>
{
public static readonly long[] Value=A198751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198751.Bytes);
public long this[int i]=>Value[i];

public static A198751Inst Instance=new A198751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198752
{
public static readonly long[] Value={ 6L,0L,6L,9L,5L,0L,0L,3L,9L,3L,9L,6L,7L,0L,1L,1L,0L,2L,9L,2L,9L,3L,5L,7L,6L,2L,5L,3L,8L,5L,7L,0L,4L,5L,4L,2L,3L,8L,2L,3L,1L,7L,3L,5L,9L,9L,5L,5L,3L,8L,8L,9L,6L,1L,9L,4L,8L,0L,3L,1L,2L,1L,8L,0L,4L,9L,2L,7L,4L,6L,8L,9L,2L,5L,9L,6L,9L,2L,3L,5L,2L,9L,8L,8L,5L,8L,3L,4L,4L,7L,9L,4L,1L,8L,3L,5L,3L,0L,0L,0L };
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
public class A198752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198752Inst : IEnumerable<long>
{
public static readonly long[] Value=A198752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198752.Bytes);
public long this[int i]=>Value[i];

public static A198752Inst Instance=new A198752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198753
{
public static readonly long[] Value={ 7L,9L,9L,2L,3L,4L,2L,5L,0L,7L,5L,0L,2L,6L,1L,4L,4L,5L,8L,0L,6L,5L,0L,8L,2L,7L,8L,0L,2L,4L,8L,8L,9L,6L,5L,1L,5L,3L,7L,3L,7L,5L,6L,7L,6L,9L,1L,3L,0L,9L,6L,6L,0L,5L,7L,8L,2L,0L,8L,4L,2L,3L,2L,2L,5L,6L,1L,3L,5L,9L,7L,3L,8L,6L,1L,5L,0L,9L,2L,9L,9L,1L,5L,7L,5L,4L,5L,5L,2L,0L,1L,2L,1L,1L,2L,8L,9L,5L,9L };
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
public class A198753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198753Inst : IEnumerable<long>
{
public static readonly long[] Value=A198753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198753.Bytes);
public long this[int i]=>Value[i];

public static A198753Inst Instance=new A198753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198754
{
public static readonly long[] Value={ 6L,1L,0L,2L,3L,8L,4L,8L,0L,8L,0L,5L,6L,0L,5L,8L,2L,6L,6L,4L,5L,2L,9L,0L,7L,7L,4L,8L,9L,5L,9L,2L,5L,4L,1L,7L,9L,5L,3L,7L,4L,1L,1L,9L,2L,6L,0L,9L,6L,6L,5L,6L,9L,0L,9L,0L,4L,7L,9L,5L,5L,7L,3L,6L,0L,0L,9L,0L,5L,0L,1L,4L,0L,6L,4L,1L,1L,6L,1L,2L,6L,6L,2L,6L,4L,6L,4L,6L,9L,7L,8L,1L,6L,0L,4L,8L,7L,0L,8L };
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
public class A198754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198754Inst : IEnumerable<long>
{
public static readonly long[] Value=A198754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198754.Bytes);
public long this[int i]=>Value[i];

public static A198754Inst Instance=new A198754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198755
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,2L,2L,5L,1L,8L,1L,4L,7L,5L,3L,6L,6L,2L,3L,4L,8L,3L,2L,2L,9L,0L,2L,9L,3L,8L,7L,9L,8L,7L,4L,4L,3L,3L,0L,4L,5L,4L,6L,7L,2L,5L,6L,5L,7L,6L,6L,4L,9L,5L,2L,6L,2L,7L,4L,0L,1L,8L,5L,3L,2L,0L,0L,8L,9L,5L,0L,6L,1L,6L,5L,9L,3L,0L,2L,4L,6L,5L,0L,3L,4L,1L,1L,0L,9L,7L,5L,9L,7L,7L,5L,7L,5L,6L,7L };
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
public class A198755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198755Inst : IEnumerable<long>
{
public static readonly long[] Value=A198755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198755.Bytes);
public long this[int i]=>Value[i];

public static A198755Inst Instance=new A198755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198756
{
public static readonly long[] Value={ 1L,7L,9L,5L,1L,1L,6L,6L,4L,1L,8L,2L,0L,3L,9L,9L,7L,1L,5L,6L,3L,9L,9L,3L,0L,2L,7L,6L,4L,4L,6L,7L,9L,4L,8L,8L,4L,6L,2L,2L,0L,5L,0L,5L,7L,7L,9L,6L,6L,8L,9L,8L,0L,8L,1L,3L,4L,5L,5L,3L,2L,0L,0L,6L,4L,1L,2L,2L,8L,2L,7L,0L,6L,5L,7L,0L,5L,2L,3L,9L,3L,8L,4L,8L,7L,6L,1L,5L,6L,7L,0L,2L,4L,5L,6L,0L,4L,9L,2L };
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
public class A198756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198756Inst : IEnumerable<long>
{
public static readonly long[] Value=A198756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198756.Bytes);
public long this[int i]=>Value[i];

public static A198756Inst Instance=new A198756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198757
{
public static readonly long[] Value={ 2L,1L,2L,8L,1L,2L,6L,4L,6L,5L,6L,8L,4L,9L,2L,2L,4L,8L,7L,6L,5L,2L,4L,6L,8L,7L,9L,4L,9L,8L,3L,7L,9L,9L,1L,6L,8L,7L,8L,0L,9L,2L,8L,5L,3L,5L,0L,6L,7L,8L,4L,2L,3L,6L,7L,6L,4L,1L,1L,3L,0L,9L,6L,6L,3L,2L,8L,4L,3L,7L,0L,2L,2L,9L,8L,8L,7L,0L,2L,6L,3L,1L,0L,4L,7L,9L,5L,4L,3L,3L,1L,1L,1L,5L,2L,5L,6L,1L,4L };
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
public class A198757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198757Inst : IEnumerable<long>
{
public static readonly long[] Value=A198757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198757.Bytes);
public long this[int i]=>Value[i];

public static A198757Inst Instance=new A198757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198758
{
public static readonly long[] Value={ 1L,9L,1L,8L,9L,2L,7L,8L,1L,6L,3L,3L,5L,2L,4L,4L,2L,9L,7L,2L,0L,4L,4L,7L,6L,8L,9L,0L,0L,4L,0L,2L,8L,3L,7L,0L,1L,3L,5L,4L,5L,6L,7L,7L,7L,3L,7L,9L,5L,4L,2L,6L,8L,9L,5L,0L,9L,7L,4L,0L,7L,7L,0L,7L,4L,9L,6L,0L,4L,7L,6L,7L,4L,1L,4L,5L,7L,8L,9L,0L,6L,7L,6L,8L,4L,6L,0L,3L,0L,3L,8L,8L,1L,4L,2L,9L,4L,3L,2L };
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
public class A198758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198758Inst : IEnumerable<long>
{
public static readonly long[] Value=A198758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198758.Bytes);
public long this[int i]=>Value[i];

public static A198758Inst Instance=new A198758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198759
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,15L,20L,25L,30L,36L,42L,48L,54L,60L,66L,73L,80L,87L,94L,101L,108L,115L,122L,129L,136L,143L,150L,158L,166L,174L,182L,190L,198L,206L,214L,222L,230L,238L,246L,254L,262L,270L,278L,286L,294L,302L,310L,318L,326L,334L,342L };
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
public class A198759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198759Inst : IEnumerable<long>
{
public static readonly long[] Value=A198759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198759.Bytes);
public long this[int i]=>Value[i];

public static A198759Inst Instance=new A198759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198760
{
public static readonly long[] Value={ 2L,8L,32L,136L,596L,2712L,12642L,60234L,291840L,1434184L,7130640L,35807114L,181339236L,925139186L,4750176056L,24528421712L,127294780994L,663591911824L,3473315219722L,18246162722278L,96169600405626L,508413199626078L,2695245063006696L,14324688031734740L };
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
public class A198760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198760Inst : IEnumerable<long>
{
public static readonly long[] Value=A198760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198760.Bytes);
public long this[int i]=>Value[i];

public static A198760Inst Instance=new A198760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198761
{
public static readonly long[] Value={ 2L,20L,648L,45472L,5644880L,1099056000L,310007943616L,119777421416192L };
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
public class A198761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198761Inst : IEnumerable<long>
{
public static readonly long[] Value=A198761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198761.Bytes);
public long this[int i]=>Value[i];

public static A198761Inst Instance=new A198761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198762
{
public static readonly long[] Value={ 2L,14L,74L,374L,1874L,9374L,46874L,234374L,1171874L,5859374L,29296874L,146484374L,732421874L,3662109374L,18310546874L,91552734374L,457763671874L,2288818359374L,11444091796874L,57220458984374L,286102294921874L,1430511474609374L };
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
public class A198762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198762Inst : IEnumerable<long>
{
public static readonly long[] Value=A198762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198762.Bytes);
public long this[int i]=>Value[i];

public static A198762Inst Instance=new A198762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198763
{
public static readonly long[] Value={ 3L,19L,99L,499L,2499L,12499L,62499L,312499L,1562499L,7812499L,39062499L,195312499L,976562499L,4882812499L,24414062499L,122070312499L,610351562499L,3051757812499L,15258789062499L,76293945312499L,381469726562499L,1907348632812499L };
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
public class A198763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198763Inst : IEnumerable<long>
{
public static readonly long[] Value=A198763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198763.Bytes);
public long this[int i]=>Value[i];

public static A198763Inst Instance=new A198763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198764
{
public static readonly long[] Value={ 5L,29L,149L,749L,3749L,18749L,93749L,468749L,2343749L,11718749L,58593749L,292968749L,1464843749L,7324218749L,36621093749L,183105468749L,915527343749L,4577636718749L,22888183593749L,114440917968749L,572204589843749L,2861022949218749L };
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
public class A198764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198764Inst : IEnumerable<long>
{
public static readonly long[] Value=A198764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198764.Bytes);
public long this[int i]=>Value[i];

public static A198764Inst Instance=new A198764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198765
{
public static readonly long[] Value={ 6L,34L,174L,874L,4374L,21874L,109374L,546874L,2734374L,13671874L,68359374L,341796874L,1708984374L,8544921874L,42724609374L,213623046874L,1068115234374L,5340576171874L,26702880859374L,133514404296874L };
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
public class A198765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198765Inst : IEnumerable<long>
{
public static readonly long[] Value=A198765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198765.Bytes);
public long this[int i]=>Value[i];

public static A198765Inst Instance=new A198765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198766
{
public static readonly long[] Value={ 3L,17L,87L,437L,2187L,10937L,54687L,273437L,1367187L,6835937L,34179687L,170898437L,854492187L,4272460937L,21362304687L,106811523437L,534057617187L,2670288085937L,13351440429687L,66757202148437L,333786010742187L,1668930053710937L };
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
public class A198766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198766Inst : IEnumerable<long>
{
public static readonly long[] Value=A198766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198766.Bytes);
public long this[int i]=>Value[i];

public static A198766Inst Instance=new A198766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198767
{
public static readonly long[] Value={ 7L,39L,199L,999L,4999L,24999L,124999L,624999L,3124999L,15624999L,78124999L,390624999L,1953124999L,9765624999L,48828124999L,244140624999L,1220703124999L,6103515624999L,30517578124999L,152587890624999L,762939453124999L };
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
public class A198767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198767Inst : IEnumerable<long>
{
public static readonly long[] Value=A198767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198767.Bytes);
public long this[int i]=>Value[i];

public static A198767Inst Instance=new A198767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198768
{
public static readonly long[] Value={ 8L,44L,224L,1124L,5624L,28124L,140624L,703124L,3515624L,17578124L,87890624L,439453124L,2197265624L,10986328124L,54931640624L,274658203124L,1373291015624L,6866455078124L,34332275390624L,171661376953124L,858306884765624L };
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
public class A198768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198768Inst : IEnumerable<long>
{
public static readonly long[] Value=A198768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198768.Bytes);
public long this[int i]=>Value[i];

public static A198768Inst Instance=new A198768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198769
{
public static readonly long[] Value={ 2L,11L,56L,281L,1406L,7031L,35156L,175781L,878906L,4394531L,21972656L,109863281L,549316406L,2746582031L,13732910156L,68664550781L,343322753906L,1716613769531L,8583068847656L,42915344238281L,214576721191406L,1072883605957031L };
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
public class A198769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198769Inst : IEnumerable<long>
{
public static readonly long[] Value=A198769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198769.Bytes);
public long this[int i]=>Value[i];

public static A198769Inst Instance=new A198769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198770
{
public static readonly long[] Value={ 10L,54L,274L,1374L,6874L,34374L,171874L,859374L,4296874L,21484374L,107421874L,537109374L,2685546874L,13427734374L,67138671874L,335693359374L,1678466796874L,8392333984374L,41961669921874L,209808349609374L,1049041748046874L };
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
public class A198770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198770Inst : IEnumerable<long>
{
public static readonly long[] Value=A198770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198770.Bytes);
public long this[int i]=>Value[i];

public static A198770Inst Instance=new A198770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198771
{
public static readonly long[] Value={ 5L,27L,137L,687L,3437L,17187L,85937L,429687L,2148437L,10742187L,53710937L,268554687L,1342773437L,6713867187L,33569335937L,167846679687L,839233398437L,4196166992187L,20980834960937L,104904174804687L,524520874023437L,2622604370117187L };
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
public class A198771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198771Inst : IEnumerable<long>
{
public static readonly long[] Value=A198771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198771.Bytes);
public long this[int i]=>Value[i];

public static A198771Inst Instance=new A198771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198772
{
public static readonly long[] Value={ 0L,1L,3L,4L,7L,9L,12L,13L,16L,19L,21L,25L,27L,28L,31L,36L,37L,39L,43L,48L,52L,57L,61L,63L,64L,67L,73L,75L,76L,79L,81L,84L,93L,97L,100L,103L,108L,109L,111L,112L,117L,121L,124L,127L,129L,139L,144L,148L,151L,156L,157L,163L,171L,172L,175L,181L,183L,189L,192L,193L };
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
public class A198772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198772Inst : IEnumerable<long>
{
public static readonly long[] Value=A198772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198772.Bytes);
public long this[int i]=>Value[i];

public static A198772Inst Instance=new A198772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198773
{
public static readonly long[] Value={ 49L,91L,133L,147L,169L,196L,217L,247L,259L,273L,301L,343L,361L,364L,399L,403L,427L,441L,469L,481L,507L,511L,532L,553L,559L,588L,589L,651L,676L,679L,703L,721L,741L,763L,777L,784L,793L,817L,819L,868L,871L,889L,903L,949L,961L,973L,988L,1027L,1029L,1036L,1057L,1083L,1092L,1099L,1141L,1147L };
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
public class A198773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198773Inst : IEnumerable<long>
{
public static readonly long[] Value=A198773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198773.Bytes);
public long this[int i]=>Value[i];

public static A198773Inst Instance=new A198773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198774
{
public static readonly long[] Value={ 637L,931L,1183L,1519L,1813L,1911L,2107L,2401L,2527L,2548L,2793L,2989L,3211L,3283L,3549L,3577L,3724L,3871L,4557L,4693L,4732L,4753L,5047L,5239L,5341L,5439L,5733L,6076L,6223L,6253L,6321L,6727L,6811L,7203L,7252L,7267L,7399L,7581L,7644L,7693L,7987L,8379L,8428L };
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
public class A198774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198774Inst : IEnumerable<long>
{
public static readonly long[] Value=A198774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198774.Bytes);
public long this[int i]=>Value[i];

public static A198774Inst Instance=new A198774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198775
{
public static readonly long[] Value={ 1729L,2821L,3367L,3913L,4123L,4459L,4921L,5187L,5551L,5719L,6097L,6517L,6643L,6916L,7189L,7657L,8029L,8113L,8463L,8827L,8911L,9139L,9331L,9373L,9709L,9919L,10101L,10507L,10621L,10633L,11137L,11284L,11557L,11739L,12369L,12649L,12691L,12901L,13237L,13377L };
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
public class A198775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198775Inst : IEnumerable<long>
{
public static readonly long[] Value=A198775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198775.Bytes);
public long this[int i]=>Value[i];

public static A198775Inst Instance=new A198775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198776
{
public static readonly long[] Value={ 53L,2L,43L,31L,59L,59L,23L,59L,5L,67L,23L,67L,67L,67L,47L,29L,17L,67L,31L,47L,7L,5L,83L,41L,17L,73L,97L,23L,53L,53L,3L,37L,29L,37L,73L,37L,73L,37L,67L,73L,79L,59L,47L,73L,3L,67L,53L,23L,31L,17L,61L,11L,11L,19L,7L,79L,47L,79L,37L,5L,2L,29L,13L,47L,61L,2L,29L };
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
public class A198776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198776Inst : IEnumerable<long>
{
public static readonly long[] Value=A198776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198776.Bytes);
public long this[int i]=>Value[i];

public static A198776Inst Instance=new A198776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198777
{
public static readonly long[] Value={ 577L,431L,421L,593L,359L,593L,359L,677L,677L,467L,709L,947L,467L,463L,631L,809L,401L,283L,241L,173L,739L,997L,449L,353L,3L,337L,293L,937L,373L,733L,337L,773L,673L,739L,709L,491L,853L,233L,331L,151L,661L,211L,199L,79L,479L,937L,857L,2L,29L,547L,29L,43L,421L };
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
public class A198777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198777Inst : IEnumerable<long>
{
public static readonly long[] Value=A198777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198777.Bytes);
public long this[int i]=>Value[i];

public static A198777Inst Instance=new A198777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198778
{
public static readonly long[] Value={ 577L,421L,3359L,3593L,5939L,9923L,8677L,2677L,6709L,6947L,6329L,2917L,4951L,1447L,401L,4283L,2417L,6449L,5003L,3733L,3767L,7673L,9491L,2039L,853L,5323L,6211L,4793L,7937L,857L,7057L,29L,3547L,6043L,587L,6733L,7331L,3313L,1399L,7541L,5413L,4139L,8423L,4877L,503L,8431L,3109L,1093L,9973L,3613L,8893L,8933L,17L,7247L };
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
public class A198778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198778Inst : IEnumerable<long>
{
public static readonly long[] Value=A198778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198778.Bytes);
public long this[int i]=>Value[i];

public static A198778Inst Instance=new A198778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198779
{
public static readonly long[] Value={ 64901L,59399L,48677L,77267L,26777L,66467L,36947L,6329L,32917L,17467L,49807L,24809L,92353L,50033L,74293L,42937L,37337L,33773L,79259L,24709L,70949L,9491L,16567L,70853L,53233L,33151L,31517L,28621L,62119L,79847L,98479L,84793L,50857L,29921L,14669L,96043L,35267L,52673L,40129L,12967L };
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
public class A198779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198779Inst : IEnumerable<long>
{
public static readonly long[] Value=A198779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198779.Bytes);
public long this[int i]=>Value[i];

public static A198779Inst Instance=new A198779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198780
{
public static readonly long[] Value={ 939923L,992359L,746749L,241739L,644923L,350033L,500333L,374293L,937337L,773767L,160087L,670853L,532331L,199501L,79847L,847937L,29921L,299213L,325421L,526733L,673313L,331399L,12967L,375413L,395491L,954911L,38431L,93997L,939973L,60889L,271351L,349291L,79843L,984301L,341777L };
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
public class A198780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198780Inst : IEnumerable<long>
{
public static readonly long[] Value=A198780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198780.Bytes);
public long this[int i]=>Value[i];

public static A198780Inst Instance=new A198780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198781
{
public static readonly long[] Value={ 2402431L,5933593L,8677267L,7726777L,6467093L,6709369L,6947063L,2417399L,7394279L,4709491L,9160087L,5670853L,8532331L,1528621L,7984793L,7400299L,29921L,299213L,2542151L,5190587L,3754139L,1395491L,1116851L,4234877L,1093997L,939973L,3997361L,6088933L,2676001L,7247953L };
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
public class A198781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198781Inst : IEnumerable<long>
{
public static readonly long[] Value=A198781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198781.Bytes);
public long this[int i]=>Value[i];

public static A198781Inst Instance=new A198781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198782
{
public static readonly long[] Value={ 72156649L,31042159L,35939923L,93992359L,98805767L,80576723L,77766467L,36947063L,33374293L,33742937L,42937337L,33773767L,25824709L,87352039L,8532331L,15286211L,28621199L,50798479L,7984793L,299213L,40296043L,51028079L,80798423L,84234877L,20503843L,93997361L,6088933L };
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
public class A198782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198782Inst : IEnumerable<long>
{
public static readonly long[] Value=A198782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198782.Bytes);
public long this[int i]=>Value[i];

public static A198782Inst Instance=new A198782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198783
{
public static readonly long[] Value={ 215664901L,593359399L,235988057L,362241739L,739976449L,33374293L,337429373L,733773767L,87352039L,670853233L,146694029L,151905877L,267331399L,413954911L,984234877L,384310939L,310939973L,93997361L,939973613L,306088933L,60889331L,759271351L,549570661L,789358679L };
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
public class A198783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198783Inst : IEnumerable<long>
{
public static readonly long[] Value=A198783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198783.Bytes);
public long this[int i]=>Value[i];

public static A198783Inst Instance=new A198783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198784
{
public static readonly long[] Value={ 7215664901L,1566490153L,3286060651L,6060651209L,9008240243L,4310421593L,2159335939L,9235988057L,8486772677L,8070824809L,2836224173L,3622417399L,3997644923L,33374293L,2582470949L,6008735203L,87352039L,3151776611L,5015079847L,7400299213L,3139925401L,3754139549L };
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
public class A198784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198784Inst : IEnumerable<long>
{
public static readonly long[] Value=A198784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198784.Bytes);
public long this[int i]=>Value[i];

public static A198784Inst Instance=new A198784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198785
{
public static readonly long[] Value={ 1L,1L,3L,5L,14L,28L,77L,173L,485L,1165L,3335L,8341L,24331L,62455L,184783L,483127L,1445429L,3830911L,11562247L,30969809L,94134108L,254285698L,777410651L,2114690863L,6496549393L,17774924057L,54831676621L,150766702399L,466729836290L,1288810006264L,4002059363580L };
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
public class A198785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198785Inst : IEnumerable<long>
{
public static readonly long[] Value=A198785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198785.Bytes);
public long this[int i]=>Value[i];

public static A198785Inst Instance=new A198785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198786
{
public static readonly long[] Value={ 1L,2L,4L,4L,0L,-4L,0L,8L,0L,-20L,0L,56L,0L,-168L,0L,528L,0L,-1716L,0L,5720L,0L,-19448L,0L,67184L,0L,-235144L,0L,832048L,0L,-2971600L,0L,10697760L,0L,-38779380L,0L,141430680L,0L,-518579160L,0L,1910554800L,0L,-7069052760L,0L,26256481680L,0L,-97865068080L,0L,365930254560L,0L };
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
public class A198786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198786Inst : IEnumerable<long>
{
public static readonly long[] Value=A198786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198786.Bytes);
public long this[int i]=>Value[i];

public static A198786Inst Instance=new A198786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198787
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,3L,0L,4L,5L,6L,0L,6L,8L,9L,10L,0L,9L,12L,13L,14L,15L,0L,12L,16L,18L,19L,20L,21L,0L,16L,21L,24L,25L,26L,27L,28L,0L,20L,27L,30L,32L,33L,34L,35L,36L,0L,25L,33L,37L,40L,41L,42L,43L,44L,45L,0L,30L,40L,45L,48L,50L,51L,52L,53L,54L,55L,0L,36L,48L,54L,57L,60L,61L,62L,63L,64L,65L,66L,0L,42L };
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
public class A198787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198787Inst : IEnumerable<long>
{
public static readonly long[] Value=A198787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198787.Bytes);
public long this[int i]=>Value[i];

public static A198787Inst Instance=new A198787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198788
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,4L,3L,2L,1L,5L,1L,2L,1L,1L,6L,3L,1L,2L,2L,1L,7L,5L,4L,2L,1L,1L,1L,8L,7L,1L,1L,2L,1L,2L,1L,9L,1L,4L,5L,2L,3L,3L,1L,1L,10L,3L,7L,2L,1L,4L,2L,3L,2L,1L,11L,5L,1L,6L,6L,4L,4L,3L,2L,1L,1L,12L,7L,4L,1L,3L,3L,5L,1L,3L,2L,2L,1L,13L,9L,7L,5L,8L,1L,5L,3L };
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
public class A198788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198788Inst : IEnumerable<long>
{
public static readonly long[] Value=A198788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198788.Bytes);
public long this[int i]=>Value[i];

public static A198788Inst Instance=new A198788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198789
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,2L,3L,4L,1L,1L,2L,1L,5L,1L,2L,2L,1L,3L,6L,1L,1L,1L,2L,4L,5L,7L,1L,2L,1L,2L,1L,1L,7L,8L,1L,1L,3L,3L,2L,5L,4L,1L,9L,1L,2L,3L,2L,4L,1L,2L,7L,3L,10L,1L,1L,2L,3L,4L,4L,6L,6L,1L,5L,11L,1L,2L,2L,3L,1L,5L,3L,3L,1L,4L,7L,12L,1L,1L,1L,4L,2L,3L,5L,1L };
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
public class A198789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198789Inst : IEnumerable<long>
{
public static readonly long[] Value=A198789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198789.Bytes);
public long this[int i]=>Value[i];

public static A198789Inst Instance=new A198789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198790
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,2L,2L,1L,1L,4L,1L,1L,2L,2L,3L,2L,3L,3L,4L,4L,1L,5L,3L,4L,1L,2L,4L,4L,1L,2L,4L,5L,3L,2L,5L,1L,3L,4L,1L,1L,3L,4L,1L,2L,5L,4L,2L,3L,5L,1L,3L,3L,5L,1L,3L,4L,2L,1L,4L,5L,2L,3L,5L,5L,2L,3L,5L,1L,4L,3L,1L,2L,4L,5L,2L,2L,4L,5L,2L,3L,1L,6L,5L,1L,5L,1L,4L };
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
public class A198790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198790Inst : IEnumerable<long>
{
public static readonly long[] Value=A198790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198790.Bytes);
public long this[int i]=>Value[i];

public static A198790Inst Instance=new A198790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198791
{
public static readonly long[] Value={ 1L,5L,19L,27L,87L,989L,3119L,5399L,8189L,99663L,57455L,222397L,2603047L,8476649L,117917347L,290190179L,360064247L,1344262919L,3181391639L,39179386959L,204692414215L,165424388219L,2254874520599L,2922139183443L,594630799853L };
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
public class A198791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198791Inst : IEnumerable<long>
{
public static readonly long[] Value=A198791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198791.Bytes);
public long this[int i]=>Value[i];

public static A198791Inst Instance=new A198791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198792
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,0L,4L,6L,3L,1L,0L,8L,16L,12L,4L,1L,0L,16L,40L,40L,20L,5L,1L,0L,32L,96L,120L,80L,30L,6L,1L,0L,64L,224L,336L,280L,140L,42L,7L,1L,0L,128L,512L,896L,896L,560L,224L,56L,8L,1L,0L,256L,1152L,2304L,2688L,2016L,1008L,336L,72L,9L,1L };
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
public class A198792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198792Inst : IEnumerable<long>
{
public static readonly long[] Value=A198792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198792.Bytes);
public long this[int i]=>Value[i];

public static A198792Inst Instance=new A198792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198793
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,3L,6L,4L,0L,1L,4L,12L,16L,8L,0L,1L,5L,20L,40L,40L,16L,0L,1L,6L,30L,80L,120L,96L,32L,0L,1L,7L,42L,140L,280L,336L,224L,64L,0L,1L,8L,56L,224L,560L,896L,896L,512L,128L,0L,1L,9L,72L,336L,1008L,2016L,2688L,2304L,1152L,256L,0L };
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
public class A198793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198793Inst : IEnumerable<long>
{
public static readonly long[] Value=A198793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198793.Bytes);
public long this[int i]=>Value[i];

public static A198793Inst Instance=new A198793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198794
{
public static readonly long[] Value={ 4L,29L,179L,1079L,6479L,38879L,233279L,1399679L,8398079L,50388479L,302330879L,1813985279L,10883911679L,65303470079L,391820820479L,2350924922879L,14105549537279L,84633297223679L,507799783342079L,3046798700052479L,18280792200314879L };
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
public class A198794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198794Inst : IEnumerable<long>
{
public static readonly long[] Value=A198794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198794.Bytes);
public long this[int i]=>Value[i];

public static A198794Inst Instance=new A198794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198795
{
public static readonly long[] Value={ 6L,41L,251L,1511L,9071L,54431L,326591L,1959551L,11757311L,70543871L,423263231L,2539579391L,15237476351L,91424858111L,548549148671L,3291294892031L,19747769352191L,118486616113151L,710919696678911L,4265518180073471L,25593109080440831L };
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
public class A198795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198795Inst : IEnumerable<long>
{
public static readonly long[] Value=A198795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198795.Bytes);
public long this[int i]=>Value[i];

public static A198795Inst Instance=new A198795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198796
{
public static readonly long[] Value={ 2L,17L,107L,647L,3887L,23327L,139967L,839807L,5038847L,30233087L,181398527L,1088391167L,6530347007L,39182082047L,235092492287L,1410554953727L,8463329722367L,50779978334207L,304679870005247L,1828079220031487L };
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
public class A198796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198796Inst : IEnumerable<long>
{
public static readonly long[] Value=A198796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198796.Bytes);
public long this[int i]=>Value[i];

public static A198796Inst Instance=new A198796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198797
{
public static readonly long[] Value={ 3L,23L,143L,863L,5183L,31103L,186623L,1119743L,6718463L,40310783L,241864703L,1451188223L,8707129343L,52242776063L,313456656383L,1880739938303L,11284439629823L,67706637778943L,406239826673663L,2437438960041983L,14624633760251903L };
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
public class A198797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198797Inst : IEnumerable<long>
{
public static readonly long[] Value=A198797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198797.Bytes);
public long this[int i]=>Value[i];

public static A198797Inst Instance=new A198797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198798
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,1L,5L,-1L,3L,-1L,1L,7L,-1L,1L,5L,11L,3L,5L,11L,-1L,1L,7L,11L,-1L,7L,11L,13L,17L,-1L,3L,17L,-1L,5L,7L,17L,19L,1L,7L,11L,17L,23L,-1L,9L,11L,15L,17L,1L,13L,17L,19L,23L,-1L,1L,11L,17L,23L,29L,-1L,5L,9L,11L,21L,1L,5L,7L,11L,25L,31L,5L,7L,11L,17L,25L,31L };
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
public class A198798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198798Inst : IEnumerable<long>
{
public static readonly long[] Value=A198798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198798.Bytes);
public long this[int i]=>Value[i];

public static A198798Inst Instance=new A198798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198799
{
public static readonly long[] Value={ 2L,0L,49L,637L,1729L,8281L,12103L,1529437L,53599L,157339L,593047L,19882681L,375193L,68574961L,2989441L,7709611L,1983163L,47738317081L,4877509L };
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
public class A198799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198799Inst : IEnumerable<long>
{
public static readonly long[] Value=A198799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198799.Bytes);
public long this[int i]=>Value[i];

public static A198799Inst Instance=new A198799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198800
{
public static readonly BigInteger[] Value={ 1L,0L,20L,0L,1140L,480L,102800L,151200L,12310900L,38707200L,1812247920L,9574488000L,313983978000L,2391608419200L,62051403928800L,611744666332800L,13627749414064500L,160896284989440000L,3253345101771050000L,BigInteger.Parse("43527416858084016000"),BigInteger.Parse("829176006298475046640") };
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
public class A198800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198800Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198800.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198800.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198800Inst Instance=new A198800Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198801
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,121645100408832000L,0L };
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
public class A198801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198801Inst : IEnumerable<long>
{
public static readonly long[] Value=A198801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198801.Bytes);
public long this[int i]=>Value[i];

public static A198801Inst Instance=new A198801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198802
{
public static readonly BigInteger[] Value={ 1L,0L,18L,36L,918L,5400L,82800L,801360L,10907190L,132053040L,1802041668L,24199809480L,340640607384L,4834708246368L,70229958125184L,1032223723667136L,15391538570569590L,231935110984687968L,3531542904056225916L,BigInteger.Parse("54244559313713885688"),BigInteger.Parse("839979883121036697468") };
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
public class A198802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198802Inst Instance=new A198802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198803
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,355687428096000L,0L,0L,0L };
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
public class A198803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198803Inst : IEnumerable<long>
{
public static readonly long[] Value=A198803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198803.Bytes);
public long this[int i]=>Value[i];

public static A198803Inst Instance=new A198803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198804
{
public static readonly BigInteger[] Value={ 1L,0L,16L,0L,720L,0L,50560L,0L,4649680L,0L,514031616L,0L,64941883776L,0L,9071319628800L,0L,1369263687414480L,0L,219705672931613440L,0L,BigInteger.Parse("37024402443528248320"),0L,BigInteger.Parse("6493814173413849784320"),0L,BigInteger.Parse("1177304833671218302960000"),0L,BigInteger.Parse("219456611569479963675136000"),0L };
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
public class A198804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198804.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198804Inst Instance=new A198804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}