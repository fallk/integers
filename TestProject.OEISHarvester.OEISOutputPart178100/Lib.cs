using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A208557
{
public static readonly long[] Value={ 12L,144L,420L,2508L,10080L,50052L,221340L,1042416L,4742628L,21989868L,100900800L,465657348L,2142175548L,9872120016L,45450619620L,209366048652L,964140982560L,4440671206788L,20451041895900L,94190120555184L,433792784654052L };
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
public class A208557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208557Inst : IEnumerable<long>
{
public static readonly long[] Value=A208557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208557.Bytes);
public long this[int i]=>Value[i];

public static A208557Inst Instance=new A208557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208558
{
public static readonly long[] Value={ 16L,256L,784L,5776L,25600L,150544L,753424L,4129024L,21492496L,115175824L,607129600L,3230330896L,17097131536L,90759997696L,480986635024L,2551443960976L,13527095526400L,71739070491664L,380392441337104L,2017207032035584L };
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
public class A208558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208558Inst : IEnumerable<long>
{
public static readonly long[] Value=A208558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208558.Bytes);
public long this[int i]=>Value[i];

public static A208558Inst Instance=new A208558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208559
{
public static readonly long[] Value={ 20L,400L,1260L,11020L,52000L,351140L,1913940L,11836400L,67894220L,407225740L,2378376000L,14112662980L,82952260180L,490344818000L,2888730695340L,17052623706380L,100542287612000L,593228737061860L,3498693917381460L };
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
public class A208559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208559Inst : IEnumerable<long>
{
public static readonly long[] Value=A208559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208559.Bytes);
public long this[int i]=>Value[i];

public static A208559Inst Instance=new A208559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208560
{
public static readonly BigInteger[] Value={ 1L,10L,1059L,600426L,1820627588L,29489112993258L,2550050797214882163L,BigInteger.Parse("1177059517691274455925664"),BigInteger.Parse("2899898779178057927709489333244"),BigInteger.Parse("38132339745477816025554449167624111270") };
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
public class A208560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208560Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208560.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208560.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208560Inst Instance=new A208560Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208561
{
public static readonly long[] Value={ 2L,10L,68L,464L,3168L,21632L,147712L,1008640L,6887424L,47030272L,321142784L,2192900096L,14974058496L,102249267200L,698201669632L,4767619219456L,32555340398592L,222301769433088L,1517971432275968L,10365357302743040L };
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
public class A208561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208561Inst : IEnumerable<long>
{
public static readonly long[] Value=A208561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208561.Bytes);
public long this[int i]=>Value[i];

public static A208561Inst Instance=new A208561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208562
{
public static readonly long[] Value={ 5L,68L,1059L,16608L,260856L,4098492L,64398564L,1011891888L,15899856696L,249834571632L,3925652965344L,61683823050048L,969238512405216L,15229654196873472L,239303704937730624L,3760181449823927808L };
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
public class A208562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208562Inst : IEnumerable<long>
{
public static readonly long[] Value=A208562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208562.Bytes);
public long this[int i]=>Value[i];

public static A208562Inst Instance=new A208562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208563
{
public static readonly BigInteger[] Value={ 14L,464L,16608L,600426L,21758476L,788922798L,28608436530L,1037446303548L,37621813069386L,1364314106628550L,49475379592575628L,1794171379245008334L,BigInteger.Parse("65063694331223004978"),BigInteger.Parse("2359464864203438340188"),BigInteger.Parse("85563454475454135771530") };
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
public class A208563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208563Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208563.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208563.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208563Inst Instance=new A208563Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208564
{
public static readonly BigInteger[] Value={ 41L,3168L,260856L,21758476L,1820627588L,152454784170L,12768454002596L,1069433026366756L,89572151753280992L,7502281578834477922L,BigInteger.Parse("628367800932102007424"),BigInteger.Parse("52630140708145183027180"),BigInteger.Parse("4408137671151078527664476") };
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
public class A208564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208564Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208564.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208564.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208564Inst Instance=new A208564Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208565
{
public static readonly BigInteger[] Value={ 122L,21632L,4098492L,788922798L,152454784170L,29489112993258L,5705351522369620L,1103893186338679596L,BigInteger.Parse("213588257890227210061"),BigInteger.Parse("41326538036950203061147"),BigInteger.Parse("7996150994528203520921414") };
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
public class A208565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208565Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208565.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208565.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208565Inst Instance=new A208565Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208566
{
public static readonly BigInteger[] Value={ 365L,147712L,64398564L,28608436530L,12768454002596L,5705351522369620L,2550050797214882163L,BigInteger.Parse("1139842898451065324460"),BigInteger.Parse("509504876709198501073884"),BigInteger.Parse("227747392766431290996397763"),BigInteger.Parse("101802605180267043224102094118") };
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
public class A208566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208566Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208566.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208566.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208566Inst Instance=new A208566Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208567
{
public static readonly long[] Value={ 1L,2L,2L,5L,10L,5L,14L,68L,68L,14L,41L,464L,1059L,464L,41L,122L,3168L,16608L,16608L,3168L,122L,365L,21632L,260856L,600426L,260856L,21632L,365L,1094L,147712L,4098492L,21758476L,21758476L,4098492L,147712L,1094L,3281L,1008640L,64398564L,788922798L };
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
public class A208567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208567Inst : IEnumerable<long>
{
public static readonly long[] Value=A208567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208567.Bytes);
public long this[int i]=>Value[i];

public static A208567Inst Instance=new A208567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208568
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,2L,2L,1L,0L,1L,2L,1L,0L,0L,1L,1L,2L,0L,1L,0L,0L,0L,0L,0L,1L,1L };
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
public class A208568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208568Inst : IEnumerable<long>
{
public static readonly long[] Value=A208568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208568.Bytes);
public long this[int i]=>Value[i];

public static A208568Inst Instance=new A208568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208569
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,3L,1L,8L,4L,5L,2L,7L,3L,6L,1L,16L,8L,9L,4L,13L,5L,12L,2L,15L,7L,10L,3L,14L,6L,11L,1L,32L,16L,17L,8L,25L,9L,24L,4L,29L,13L,20L,5L,28L,12L,21L,2L,31L,15L,18L,7L,26L,10L,23L,3L,30L,14L,19L,6L,27L,11L,22L,1L,64L,32L,33L,16L,49L,17L,48L,8L,57L };
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
public class A208569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208569Inst : IEnumerable<long>
{
public static readonly long[] Value=A208569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208569.Bytes);
public long this[int i]=>Value[i];

public static A208569Inst Instance=new A208569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208570
{
public static readonly long[] Value={ 2L,6L,6L,12L,10L,12L,14L,24L,18L,30L,22L,60L,26L,42L,30L,48L,34L,36L,38L,60L,42L,66L,46L,120L,50L,78L,54L,84L,58L,60L,62L,96L,66L,102L,70L,180L,74L,114L,78L,120L,82L,84L,86L,132L,90L,138L,94L,240L,98L,150L,102L,156L,106L,108L,110L,168L,114L,174L,118L,420L,122L };
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
public class A208570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208570Inst : IEnumerable<long>
{
public static readonly long[] Value=A208570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208570.Bytes);
public long this[int i]=>Value[i];

public static A208570Inst Instance=new A208570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208571
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,0L,4L,2L,6L,2L,8L,5L,11L,0L,10L,4L,14L,4L,18L,10L,24L,6L,26L,14L,34L,16L,42L,27L,53L,0L,36L,10L,46L,8L,54L,22L,68L,12L,72L,30L,90L,32L,106L,56L,130L,26L,120L,52L,146L,54L,168L,88L,202L,80L,220L,122L,262L,134L,300L,187L,353L,0L,202L,36L,238L,20L,258L,66L,304L,24L,308L,78L,362L,68L,398L,136L,466L,52L,442L,124L,514L,112L,562L,202L,652L,160L,684L,266L,790L,272L,870L,402L,1000L,166L,858L,286L,978L,270L,1056L };
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
public class A208571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208571Inst : IEnumerable<long>
{
public static readonly long[] Value=A208571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208571.Bytes);
public long this[int i]=>Value[i];

public static A208571Inst Instance=new A208571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208572
{
public static readonly long[] Value={ 3L,5L,11L,17L,41L,71L,137L,269L,521L,1031L,2081L,4127L,8219L,16451L,32801L,65537L,131111L,262151L,524351L,1048889L,2097257L,4194581L,8388617L,16777289L,33554501L,67109321L,134217779L,268435577L,536871017L,1073741831L,2147483867L,4294967387L };
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
public class A208572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208572Inst : IEnumerable<long>
{
public static readonly long[] Value=A208572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208572.Bytes);
public long this[int i]=>Value[i];

public static A208572Inst Instance=new A208572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208573
{
public static readonly long[] Value={ 11L,17L,29L,59L,101L,197L,419L,809L,1607L,3119L,6197L,12377L,24917L,49169L,98321L,196661L,393299L,786551L,1572869L,3145739L,6292007L,12582917L,25166129L,50331707L,100663427L,201327011L,402653411L,805306457L,1610613929L,3221225549L };
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
public class A208573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208573Inst : IEnumerable<long>
{
public static readonly long[] Value=A208573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208573.Bytes);
public long this[int i]=>Value[i];

public static A208573Inst Instance=new A208573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208574
{
public static readonly long[] Value={ 3L,5L,11L,17L,29L,41L,59L,71L,101L,137L,197L,269L,419L,521L,809L,1031L,1607L,2081L,3119L,4127L,6197L,8219L,12377L,16451L,24917L,32801L,49169L,65537L,98321L,131111L,196661L,262151L,393299L,524351L,786551L,1048889L,1572869L,2097257L,3145739L,4194581L,6292007L };
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
public class A208574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208574Inst : IEnumerable<long>
{
public static readonly long[] Value=A208574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208574.Bytes);
public long this[int i]=>Value[i];

public static A208574Inst Instance=new A208574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208575
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,2L,0L,0L,0L,1L,0L,2L,0L,0L,0L,2L,0L,4L,0L,0L,0L,3L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,2L,0L,4L,0L,0L,0L,3L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,4L,0L,0L,0L,4L,0L,8L,0L,0L,0L,6L,0L,12L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,6L,0L,0L,0L,6L,0L,12L,0L,0L,0L,9L,0L,18L };
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
public class A208575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208575Inst : IEnumerable<long>
{
public static readonly long[] Value=A208575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208575.Bytes);
public long this[int i]=>Value[i];

public static A208575Inst Instance=new A208575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208576
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L };
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
public class A208576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208576Inst : IEnumerable<long>
{
public static readonly long[] Value=A208576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208576.Bytes);
public long this[int i]=>Value[i];

public static A208576Inst Instance=new A208576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208577
{
public static readonly BigInteger[] Value={ 2L,12L,159L,3233L,90863L,3319375L,151329962L,8361244271L,547602710174L,41777867546601L,3661037447467531L,364246254286662678L,BigInteger.Parse("40745454539546524768"),BigInteger.Parse("5082061117905260420201"),BigInteger.Parse("701704324509709771589604") };
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
public class A208577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208577.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208577Inst Instance=new A208577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208578
{
public static readonly BigInteger[] Value={ 5L,152L,15215L,3012383L,992352688L,493060277544L,346279494967526L,328147828693412793L,BigInteger.Parse("405140655255049613481"),BigInteger.Parse("634030553946045902705124"),BigInteger.Parse("1230184720940057735002661377"),BigInteger.Parse("2905785104106201330409269721974") };
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
public class A208578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208578.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208578Inst Instance=new A208578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208579
{
public static readonly BigInteger[] Value={ 15L,3024L,2946848L,7289707650L,36182978136598L,314946169382603268L,BigInteger.Parse("4397499594659018513529"),BigInteger.Parse("92408426611916813238982284"),BigInteger.Parse("2785236864744413991459135045397"),BigInteger.Parse("115957546355673301589831649844689014") };
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
public class A208579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208579Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208579.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208579.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208579Inst Instance=new A208579Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208580
{
public static readonly BigInteger[] Value={ 52L,84124L,960563033L,35787552851324L,3233126493451564482L,BigInteger.Parse("596705277048973363385024"),BigInteger.Parse("200823740464350277512414467867") };
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
public class A208580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208580Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208580.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208580.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208580Inst Instance=new A208580Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208581
{
public static readonly long[] Value={ 1L,2L,2L,5L,12L,5L,15L,152L,159L,15L,52L,3024L,15215L,3233L,52L,203L,84124L,2946848L,3012383L,90863L,203L,877L,3057664L,960563033L,7289707650L,992352688L,3319375L,877L,4140L,139056380L,474608323506L,35787552851324L,36182978136598L };
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
public class A208581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208581Inst : IEnumerable<long>
{
public static readonly long[] Value=A208581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208581.Bytes);
public long this[int i]=>Value[i];

public static A208581Inst Instance=new A208581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208582
{
public static readonly BigInteger[] Value={ 2L,12L,152L,3024L,84124L,3057664L,139056380L,7675358704L,502604958608L,38359095933912L,3363791582993716L,334974400169588800L,BigInteger.Parse("37509570331200251508"),BigInteger.Parse("4683620100177290725336"),BigInteger.Parse("647429265450114057846496") };
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
public class A208582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208582Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208582.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208582.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208582Inst Instance=new A208582Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208583
{
public static readonly BigInteger[] Value={ 5L,159L,15215L,2946848L,960563033L,474608323506L,332296957718504L,314368829216470278L,BigInteger.Parse("387798647378880473938"),BigInteger.Parse("606687187218093234631931") };
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
public class A208583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208583.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208583Inst Instance=new A208583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208584
{
public static readonly long[] Value={ 15L,3233L,3012383L,7289707650L,35787552851324L,309603034324088207L };
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
public class A208584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208584Inst : IEnumerable<long>
{
public static readonly long[] Value=A208584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208584.Bytes);
public long this[int i]=>Value[i];

public static A208584Inst Instance=new A208584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208585
{
public static readonly long[] Value={ 52L,90863L,992352688L,36182978136598L,3233126493451564482L };
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
public class A208585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208585Inst : IEnumerable<long>
{
public static readonly long[] Value=A208585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208585.Bytes);
public long this[int i]=>Value[i];

public static A208585Inst Instance=new A208585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208586
{
public static readonly BigInteger[] Value={ 203L,3319375L,493060277544L,314946169382603268L,BigInteger.Parse("596705277048973363385024") };
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
public class A208586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208586Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208586.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208586.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208586Inst Instance=new A208586Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208587
{
public static readonly BigInteger[] Value={ 877L,151329962L,346279494967526L,BigInteger.Parse("4397499594659018513529"),BigInteger.Parse("200823740464350277512414467867") };
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
public class A208587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208587Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208587.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208587.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208587Inst Instance=new A208587Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208588
{
public static readonly BigInteger[] Value={ 1L,5L,65L,979L,15345L,247535L,4069155L,67773805L,1139789185L,19311870095L,329149434263L,5637030686105L,96925730626035L,1672193347218577L,28932082285914005L,501821453320612915L,8722842168045249345L,BigInteger.Parse("151912536408383664095"),BigInteger.Parse("2650102280875677625415") };
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
public class A208588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208588.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208588Inst Instance=new A208588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208589
{
public static readonly long[] Value={ 1L,2L,0L,0L,1L,-2L,0L,0L,-1L,4L,0L,0L,0L,-6L,0L,0L,1L,8L,0L,0L,0L,-12L,0L,0L,-1L,18L,0L,0L,-1L,-24L,0L,0L,2L,32L,0L,0L,1L,-44L,0L,0L,-2L,58L,0L,0L,-1L,-76L,0L,0L,2L,100L,0L,0L,1L,-128L,0L,0L,-3L,164L,0L,0L,-1L,-210L,0L,0L,4L,264L,0L,0L,2L,-332L,0L,0L,-5L,416L };
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
public class A208589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208589Inst : IEnumerable<long>
{
public static readonly long[] Value=A208589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208589.Bytes);
public long this[int i]=>Value[i];

public static A208589Inst Instance=new A208589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208590
{
public static readonly BigInteger[] Value={ 1L,3L,13L,125L,1761L,34153L,833253L,24627705L,855798877L,34223775091L,1549090700059L,78325577416281L,4376902102440375L,267933660979057571L,17834397187887850661UL,BigInteger.Parse("1282662234529669344753"),BigInteger.Parse("99133711906097886767313"),BigInteger.Parse("8194555387462964814207631") };
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
public class A208590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208590Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208590.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208590.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208590Inst Instance=new A208590Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208591
{
public static readonly long[] Value={ 1L,3L,7L,23L,77L,297L,1163L,4783L,20041L,85735L,371955L,1634429L,7254547L,32486709L,146576693L,665720447L,3041096613L,13963651875L,64410421307L,298331882891L,1386933722321L,6469566027565L,30271114380919L,142037330038069L,668187211909327L };
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
public class A208591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208591Inst : IEnumerable<long>
{
public static readonly long[] Value=A208591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208591.Bytes);
public long this[int i]=>Value[i];

public static A208591Inst Instance=new A208591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208592
{
public static readonly long[] Value={ 1L,4L,13L,60L,291L,1564L,8671L,49852L,292927L,1753964L,10656757L,65549844L,407347747L,2553684852L,16130539053L,102563204892L,655918173287L,4216358457772L,27227967629683L,176554882805940L,1149099219084877L,7504110622072860L,49155856119036993L,322903351882566436L };
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
public class A208592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208592Inst : IEnumerable<long>
{
public static readonly long[] Value=A208592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208592.Bytes);
public long this[int i]=>Value[i];

public static A208592Inst Instance=new A208592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208593
{
public static readonly long[] Value={ 1L,5L,21L,125L,791L,5457L,39019L,288317L,2178929L,16773395L,131034839L,1036252649L,8279446917L,66733111919L,541954722471L,4430427981533L,36428763143945L,301074015186469L,2499725665085301L,20840038803521835L,174388665638906551L,1464205768804076875L };
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
public class A208593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208593Inst : IEnumerable<long>
{
public static readonly long[] Value=A208593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208593.Bytes);
public long this[int i]=>Value[i];

public static A208593Inst Instance=new A208593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208594
{
public static readonly BigInteger[] Value={ 1L,6L,31L,226L,1761L,14838L,129823L,1172298L,10829443L,101888166L,972840341L,9402986626L,91822503449L,904557886854L,8978540544171L,89709076112442L,901536608361003L,9106692124614666L,92411996211470633L,941636535001651066L,9630568821834643189UL,BigInteger.Parse("98829095219423607906") };
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
public class A208594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208594.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208594Inst Instance=new A208594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208595
{
public static readonly BigInteger[] Value={ 1L,7L,43L,371L,3431L,34153L,353333L,3770475L,41165305L,457714497L,5164908167L,58997692301L,680874861687L,7926902673655L,92986983743513L,1097999648804923L,13040634990748733L,155677447454317639L,1866995100779692627L,BigInteger.Parse("22482675584863229261") };
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
public class A208595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208595.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208595Inst Instance=new A208595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208596
{
public static readonly BigInteger[] Value={ 1L,8L,57L,568L,6077L,69784L,833253L,10259448L,129245091L,1658145128L,21589248803L,284548542120L,3789094334455L,50900085245304L,688944374917247L,9386664978851448L,128633790260673263L,1771859642698543096L,BigInteger.Parse("24518513933529549357"),BigInteger.Parse("340679786167936420216") };
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
public class A208596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208596.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208596Inst Instance=new A208596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208597
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,4L,7L,6L,1L,5L,13L,23L,11L,1L,6L,21L,60L,77L,26L,1L,7L,31L,125L,291L,297L,57L,1L,8L,43L,226L,791L,1564L,1163L,142L,1L,9L,57L,371L,1761L,5457L,8671L,4783L,351L,1L,10L,73L,568L,3431L,14838L,39019L,49852L,20041L,902L,1L,11L,91L,825L,6077L,34153L,129823L };
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
public class A208597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208597Inst : IEnumerable<long>
{
public static readonly long[] Value=A208597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208597.Bytes);
public long this[int i]=>Value[i];

public static A208597Inst Instance=new A208597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208598
{
public static readonly long[] Value={ 6L,23L,60L,125L,226L,371L,568L,825L,1150L,1551L,2036L,2613L,3290L,4075L,4976L,6001L,7158L,8455L,9900L,11501L,13266L,15203L,17320L,19625L,22126L,24831L,27748L,30885L,34250L,37851L,41696L,45793L,50150L,54775L,59676L,64861L,70338L,76115L,82200L,88601L };
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
public class A208598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208598Inst : IEnumerable<long>
{
public static readonly long[] Value=A208598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208598.Bytes);
public long this[int i]=>Value[i];

public static A208598Inst Instance=new A208598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208599
{
public static readonly long[] Value={ 11L,77L,291L,791L,1761L,3431L,6077L,10021L,15631L,23321L,33551L,46827L,63701L,84771L,110681L,142121L,179827L,224581L,277211L,338591L,409641L,491327L,584661L,690701L,810551L,945361L,1096327L,1264691L,1451741L,1658811L,1887281L,2138577L,2414171L };
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
public class A208599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208599Inst : IEnumerable<long>
{
public static readonly long[] Value=A208599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208599.Bytes);
public long this[int i]=>Value[i];

public static A208599Inst Instance=new A208599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208600
{
public static readonly long[] Value={ 26L,297L,1564L,5457L,14838L,34153L,69784L,130401L,227314L,374825L,590580L,895921L,1316238L,1881321L,2625712L,3589057L,4816458L,6358825L,8273228L,10623249L,13479334L,16919145L,21027912L,25898785L,31633186L,38341161L,46141732L,55163249L };
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
public class A208600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208600Inst : IEnumerable<long>
{
public static readonly long[] Value=A208600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208600.Bytes);
public long this[int i]=>Value[i];

public static A208600Inst Instance=new A208600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208601
{
public static readonly long[] Value={ 57L,1163L,8671L,39019L,129823L,353333L,833253L,1764925L,3438877L,6267735L,10816499L,17836183L,28300819L,43447825L,64821737L,94321305L,134249953L,187369603L,256957863L,346868579L,461595751L,606340813L,787083277L,1010654741L };
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
public class A208601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208601Inst : IEnumerable<long>
{
public static readonly long[] Value=A208601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208601.Bytes);
public long this[int i]=>Value[i];

public static A208601Inst Instance=new A208601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208602
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,26L,57L,142L,351L,902L,2333L,6166L,16381L,44046L,119183L,324862L,890291L,2453126L,6789309L,18869426L,52635789L,147325510L,413618615L,1164517198L,3287073461L,9300516890L,26372968983L,74937177538L,213333642443L,608400919106L,1737954608281L };
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
public class A208602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208602Inst : IEnumerable<long>
{
public static readonly long[] Value=A208602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208602.Bytes);
public long this[int i]=>Value[i];

public static A208602Inst Instance=new A208602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208603
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,0L,0L,0L,-1L,0L,0L,0L,-2L,0L,0L,0L,3L,0L,0L,0L,2L,0L,0L,0L,-4L,0L,0L,0L,-4L,0L,0L,0L,5L,0L,0L,0L,8L,0L,0L,0L,-8L,0L,0L,0L,-10L,0L,0L,0L,11L,0L,0L,0L,12L,0L,0L,0L,-15L,0L,0L,0L,-18L,0L,0L,0L,22L,0L,0L,0L,26L,0L,0L,0L,-29L,0L,0L,0L,-34L,0L,0L,0L };
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
public class A208603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208603Inst : IEnumerable<long>
{
public static readonly long[] Value=A208603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208603.Bytes);
public long this[int i]=>Value[i];

public static A208603Inst Instance=new A208603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208604
{
public static readonly long[] Value={ 1L,-2L,0L,0L,0L,4L,0L,0L,0L,-10L,0L,0L,0L,20L,0L,0L,0L,-36L,0L,0L,0L,64L,0L,0L,0L,-110L,0L,0L,0L,180L,0L,0L,0L,-288L,0L,0L,0L,452L,0L,0L,0L,-692L,0L,0L,0L,1044L,0L,0L,0L,-1554L,0L,0L,0L,2276L,0L,0L,0L,-3296L,0L,0L,0L,4724L,0L,0L,0L,-6696L,0L,0L,0L,9408L,0L,0L };
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
public class A208604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208604Inst : IEnumerable<long>
{
public static readonly long[] Value=A208604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208604.Bytes);
public long this[int i]=>Value[i];

public static A208604Inst Instance=new A208604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208605
{
public static readonly long[] Value={ 1L,-2L,4L,-8L,14L,-24L,40L,-64L,101L,-156L,236L,-352L,518L,-752L,1080L,-1536L,2162L,-3018L,4180L,-5744L,7840L,-10632L,14328L,-19200L,25591L,-33932L,44776L,-58816L,76918L,-100176L,129952L,-167936L,216240L,-277476L,354864L,-452392L,574958L,-728568L,920600L };
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
public class A208605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208605Inst : IEnumerable<long>
{
public static readonly long[] Value=A208605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208605.Bytes);
public long this[int i]=>Value[i];

public static A208605Inst Instance=new A208605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208606
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,9L,4L,1L,1L,16L,12L,7L,1L,1L,25L,30L,26L,7L,1L,1L,36L,65L,73L,32L,10L,1L,1L,49L,126L,175L,113L,52L,10L,1L,1L,64L,224L,378L,332L,199L,61L,13L,1L,1L,81L,372L,756L,852L,634L,277L,87L,13L,1L,1L,100L,585L,1422L,1974L,1779L,1024L,421L,99L,16L,1L,1L,1L };
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
public class A208606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208606Inst : IEnumerable<long>
{
public static readonly long[] Value=A208606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208606.Bytes);
public long this[int i]=>Value[i];

public static A208606Inst Instance=new A208606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208607
{
public static readonly long[] Value={ 1L,3L,1L,5L,3L,1L,7L,8L,6L,1L,9L,18L,19L,6L,1L,11L,35L,47L,25L,9L,1L,13L,61L,102L,81L,42L,9L,1L,15L,98L,203L,219L,147L,51L,12L,1L,17L,148L,378L,520L,435L,216L,74L,12L,1L,19L,213L,666L,1122L,1145L,747L,334L,86L,15L,1L,21L,295L,1119L,2250L,2753L,2233L,1245L,450L };
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
public class A208607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208607Inst : IEnumerable<long>
{
public static readonly long[] Value=A208607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208607.Bytes);
public long this[int i]=>Value[i];

public static A208607Inst Instance=new A208607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208608
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,5L,6L,3L,1L,7L,12L,12L,5L,1L,9L,20L,29L,23L,8L,1L,11L,30L,56L,64L,43L,13L,1L,13L,42L,95L,140L,136L,79L,21L,1L,15L,56L,148L,265L,332L,279L,143L,34L,1L,17L,72L,217L,455L,692L,751L,558L,256L,55L,1L,19L,90L,304L,728L,1295L,1708L,1641L,1093L,454L };
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
public class A208608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208608Inst : IEnumerable<long>
{
public static readonly long[] Value=A208608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208608.Bytes);
public long this[int i]=>Value[i];

public static A208608Inst Instance=new A208608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208609
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,3L,2L,6L,9L,5L,2L,8L,17L,18L,8L,2L,10L,27L,41L,35L,13L,2L,12L,39L,76L,93L,66L,21L,2L,14L,53L,125L,196L,200L,122L,34L,2L,16L,69L,190L,360L,472L,415L,222L,55L,2L,18L,87L,273L,603L,957L,1083L,837L,399L,89L,2L,20L,107L,376L,945L,1750L,2400L,2392L };
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
public class A208609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208609Inst : IEnumerable<long>
{
public static readonly long[] Value=A208609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208609.Bytes);
public long this[int i]=>Value[i];

public static A208609Inst Instance=new A208609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208610
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,1L,5L,9L,7L,1L,7L,17L,25L,17L,1L,9L,27L,55L,69L,41L,1L,11L,39L,99L,171L,187L,99L,1L,13L,53L,159L,341L,515L,501L,239L,1L,15L,69L,237L,599L,1125L,1515L,1329L,577L,1L,17L,87L,335L,967L,2141L,3591L,4373L,3497L,1393L,1L,19L,107L,455L,1469L,3713L };
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
public class A208610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208610Inst : IEnumerable<long>
{
public static readonly long[] Value=A208610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208610.Bytes);
public long this[int i]=>Value[i];

public static A208610Inst Instance=new A208610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208611
{
public static readonly long[] Value={ 1L,2L,3L,2L,6L,7L,2L,8L,18L,17L,2L,10L,30L,52L,41L,2L,12L,44L,102L,146L,99L,2L,14L,60L,170L,328L,402L,239L,2L,16L,78L,258L,610L,1014L,1090L,577L,2L,18L,98L,368L,1016L,2076L,3044L,2920L,1393L,2L,20L,120L,502L,1572L,3756L,6792L,8932L,7746L,3363L,2L,22L,144L };
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
public class A208611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208611Inst : IEnumerable<long>
{
public static readonly long[] Value=A208611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208611.Bytes);
public long this[int i]=>Value[i];

public static A208611Inst Instance=new A208611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208612
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,2L,1L,9L,9L,3L,1L,16L,26L,19L,5L,1L,25L,60L,70L,38L,8L,1L,36L,120L,197L,167L,73L,13L,1L,49L,217L,469L,553L,375L,137L,21L,1L,64L,364L,994L,1528L,1427L,803L,252L,34L,1L,81L,576L,1932L,3714L,4476L,3449L,1661L,457L,55L,1L,100L,870L,3510L,8196L };
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
public class A208612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208612Inst : IEnumerable<long>
{
public static readonly long[] Value=A208612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208612.Bytes);
public long this[int i]=>Value[i];

public static A208612Inst Instance=new A208612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208613
{
public static readonly long[] Value={ 1L,3L,2L,5L,7L,3L,7L,17L,16L,5L,9L,34L,51L,33L,8L,11L,60L,127L,129L,65L,13L,13L,97L,272L,386L,302L,124L,21L,15L,147L,525L,975L,1052L,666L,231L,34L,17L,212L,938L,2186L,3049L,2646L,1409L,423L,55L,19L,294L,1578L,4482L,7757L,8650L,6285L,2887L,764L,89L,21L };
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
public class A208613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208613Inst : IEnumerable<long>
{
public static readonly long[] Value=A208613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208613.Bytes);
public long this[int i]=>Value[i];

public static A208613Inst Instance=new A208613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208614
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,3L,1L,4L,2L,1L,1L,1L,3L,2L,1L,1L,3L,1L,1L,2L,3L,1L,2L,1L,3L,4L,2L,1L,5L,9L,6L,5L,4L,1L,6L,6L,7L,4L,3L,1L,4L,1L,4L,9L,20L,7L,3L,1L,7L,8L,6L,1L,15L,1L,5L,19L,11L,13L,9L,1L,21L,52L,7L,1L };
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
public class A208614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208614Inst : IEnumerable<long>
{
public static readonly long[] Value=A208614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208614.Bytes);
public long this[int i]=>Value[i];

public static A208614Inst Instance=new A208614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208615
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,6L,10L,1L,1L,1L,1L,15L,53L,35L,1L,1L,1L,1L,43L,491L,587L,126L,1L,1L,1L,1L,133L,6091L,25187L,7572L,462L,1L,1L,1L,1L,430L,87781L,1676707L,1725819L,109027L,1716L,1L,1L,1L,1L,1431L,1386529L,140422657L,705002611L,144558247L,1705249L,6435L,1L,1L };
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
public class A208615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208615Inst : IEnumerable<long>
{
public static readonly long[] Value=A208615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208615.Bytes);
public long this[int i]=>Value[i];

public static A208615Inst Instance=new A208615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208616
{
public static readonly BigInteger[] Value={ 1L,1L,10L,53L,491L,6091L,87781L,1386529L,23374495L,414325055L,7646034683L,145862292213L,2861143072425L,57468095412921L,1178095930854841L,24584089994286121L,521086299342539671L,11198784502153759831UL,BigInteger.Parse("243661974373753909051"),BigInteger.Parse("5360563436205104422681") };
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
public class A208616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208616Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208616.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208616.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208616Inst Instance=new A208616Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208617
{
public static readonly BigInteger[] Value={ 1L,1L,35L,587L,25187L,1676707L,140422657L,13675362559L,1489926719139L,177296325559211L,22661600612752505L,3073259866183533755L,BigInteger.Parse("438091469007903238421"),BigInteger.Parse("65166105272787401522141"),BigInteger.Parse("10056663348255976399237441"),BigInteger.Parse("1602608180008201242503733271") };
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
public class A208617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208617Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208617.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208617.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208617Inst Instance=new A208617Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208618
{
public static readonly BigInteger[] Value={ 1L,1L,126L,7572L,1725819L,705002611L,396803649991L,278635710716650L,231474950997766763L,BigInteger.Parse("219738417947792525211"),BigInteger.Parse("232553597317851557785623"),BigInteger.Parse("269396684883944249352055973"),BigInteger.Parse("336839101974197524267892335361"),BigInteger.Parse("449620757900366812848744648452561") };
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
public class A208618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208618Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208618.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208618.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208618Inst Instance=new A208618Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208619
{
public static readonly BigInteger[] Value={ 1L,1L,462L,109027L,144558247L,398084427253L,1672481205752413L,9490918987253894191UL,BigInteger.Parse("67868136936393109678363"),BigInteger.Parse("583693245266271046705306483"),BigInteger.Parse("5838544884938502473966453328313"),BigInteger.Parse("66244125517281822956796820132971163"),BigInteger.Parse("836288765056123179126895804194418164733") };
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
public class A208619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208619Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208619.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208619.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208619Inst Instance=new A208619Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208620
{
public static readonly BigInteger[] Value={ 1L,1L,1716L,1705249L,14029729645L,279481714446151L,9493821912766657291UL,BigInteger.Parse("475092942773985252468181"),BigInteger.Parse("32103240681864904236146331299"),BigInteger.Parse("2760173043757661872972723537937635"),BigInteger.Parse("289232902027154515366683463668541370431"),BigInteger.Parse("35764586048631587795405572631302247852797701") };
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
public class A208620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208620Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208620.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208620.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208620Inst Instance=new A208620Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208621
{
public static readonly BigInteger[] Value={ 1L,1L,6435L,28440320L,1523926182363L,232075055225078521L,BigInteger.Parse("67887185669916054862201"),BigInteger.Parse("32104063492616280061833179530"),BigInteger.Parse("22081439406257212482754663652213531"),BigInteger.Parse("20535540740510211632088991774438342144131"),BigInteger.Parse("24486820402563168156475227361324722817780058649") };
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
public class A208621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208621Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208621.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208621.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208621Inst Instance=new A208621Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208622
{
public static readonly BigInteger[] Value={ 1L,1L,24310L,499208817L,180929760551225L,BigInteger.Parse("220232478504498403075"),BigInteger.Parse("583831478578178958083979415"),BigInteger.Parse("2760236523281606433215665762615849"),BigInteger.Parse("20535579472799243918667089350306950940643"),BigInteger.Parse("220381419513554767061883905294847700173775763891") };
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
public class A208622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208622.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208622Inst Instance=new A208622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208623
{
public static readonly BigInteger[] Value={ 1L,1L,92378L,9134237407L,23086562828397479L,BigInteger.Parse("233018419345522155335125"),BigInteger.Parse("5839732221336989894541552143065"),BigInteger.Parse("289238439981484950348089838682686986479"),BigInteger.Parse("24486860959943276912563736137263132718929372619"),BigInteger.Parse("3201253130570381677843084208123022632287481960289725603") };
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
public class A208623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208623Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208623.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208623.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208623Inst Instance=new A208623Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208624
{
public static readonly BigInteger[] Value={ 1L,1L,15L,491L,25187L,1725819L,144558247L,14029729645L,1523926182363L,180929760551225L,23086562828397479L,3126799551978895629L,BigInteger.Parse("445266632168280620515"),BigInteger.Parse("66178991463387525289801"),BigInteger.Parse("10206120232877820185701707"),BigInteger.Parse("1625518539321873371313790283") };
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
public class A208624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208624Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208624.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208624.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208624Inst Instance=new A208624Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208625
{
public static readonly BigInteger[] Value={ 1L,1L,43L,6091L,1676707L,705002611L,398084427253L,279481714446151L,232075055225078521L,BigInteger.Parse("220232478504498403075"),BigInteger.Parse("233018419345522155335125"),BigInteger.Parse("269885243445946300409146375"),BigInteger.Parse("337402154959503679430701458829"),BigInteger.Parse("450322016526620687787013813440439") };
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
public class A208625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208625Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208625.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208625.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208625Inst Instance=new A208625Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208626
{
public static readonly BigInteger[] Value={ 1L,1L,133L,87781L,140422657L,396803649991L,1672481205752413L,9493821912766657291UL,BigInteger.Parse("67887185669916054862201"),BigInteger.Parse("583831478578178958083979415"),BigInteger.Parse("5839732221336989894541552143065"),BigInteger.Parse("66255973840780250383847420304675775"),BigInteger.Parse("836422943559727759153797800333684916889") };
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
public class A208626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208626Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208626.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208626.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208626Inst Instance=new A208626Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208627
{
public static readonly BigInteger[] Value={ 1L,1L,430L,1386529L,13675362559L,278635710716650L,9490918987253894191UL,BigInteger.Parse("475092942773985252468181"),BigInteger.Parse("32104063492616280061833179530"),BigInteger.Parse("2760236523281606433215665762615849"),BigInteger.Parse("289238439981484950348089838682686986479"),BigInteger.Parse("35765166865735043765208026468482106363863090") };
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
public class A208627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208627.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208627Inst Instance=new A208627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208628
{
public static readonly BigInteger[] Value={ 1L,1L,1431L,23374495L,1489926719139L,231474950997766763L,BigInteger.Parse("67868136936393109678363"),BigInteger.Parse("32103240681864904236146331299"),BigInteger.Parse("22081439406257212482754663652213531"),BigInteger.Parse("20535579472799243918667089350306950940643"),BigInteger.Parse("24486860959943276912563736137263132718929372619") };
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
public class A208628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208628Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208628.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208628.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208628Inst Instance=new A208628Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208629
{
public static readonly BigInteger[] Value={ 1L,1L,4863L,414325055L,177296325559211L,BigInteger.Parse("219738417947792525211"),BigInteger.Parse("583693245266271046705306483"),BigInteger.Parse("2760173043757661872972723537937635"),BigInteger.Parse("20535540740510211632088991774438342144131"),BigInteger.Parse("220381419513554767061883905294847700173775763891") };
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
public class A208629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208629Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208629.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208629.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208629Inst Instance=new A208629Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208630
{
public static readonly BigInteger[] Value={ 1L,1L,16797L,7646034683L,22661600612752505L,BigInteger.Parse("232553597317851557785623"),BigInteger.Parse("5838544884938502473966453328313"),BigInteger.Parse("289232902027154515366683463668541370431"),BigInteger.Parse("24486820402563168156475227361324722817780058649"),BigInteger.Parse("3201252738588789444808668395737343564339694511133453855") };
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
public class A208630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208630Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208630.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208630.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208630Inst Instance=new A208630Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208631
{
public static readonly BigInteger[] Value={ 1L,1L,3L,53L,25187L,705002611L,1672481205752413L,BigInteger.Parse("475092942773985252468181"),BigInteger.Parse("22081439406257212482754663652213531"),BigInteger.Parse("220381419513554767061883905294847700173775763891"),BigInteger.Parse("599868749018773480515945947095662848011697924400242771204050409") };
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
public class A208631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208631Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208631.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208631.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208631Inst Instance=new A208631Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208632
{
public static readonly long[] Value={ 1L,5L,32L,225L,1652L,12404L,94320L,722733L,5565560L,43005391L,333132384L,2585476348L,20097106512L,156418938680L,1218807197408L,9506457334965L,74216779041840L,579903491112365L,4534776883051800L,35488119754971345L };
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
public class A208632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208632Inst : IEnumerable<long>
{
public static readonly long[] Value=A208632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208632.Bytes);
public long this[int i]=>Value[i];

public static A208632Inst Instance=new A208632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208633
{
public static readonly long[] Value={ 8L,23L,71L,225L,722L,2331L,7548L,24476L,79423L,257807L,836973L,2717446L,8823199L,28648292L,93019712L,302032007L,980690055L,3184277945L,10339281402L,33571429395L,109005736508L,353939387572L,1149233948207L,3731539152111L };
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
public class A208633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208633Inst : IEnumerable<long>
{
public static readonly long[] Value=A208633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208633.Bytes);
public long this[int i]=>Value[i];

public static A208633Inst Instance=new A208633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208634
{
public static readonly long[] Value={ 16L,47L,150L,494L,1652L,5572L,18888L,64216L,218704L,745616L,2543520L,8679776L,29625920L,101131840L,345250944L,1178690944L,4024163584L,13739075840L,46907582976L,160151393792L,546788836352L,1866849412096L,6373813684224L };
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
public class A208634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208634Inst : IEnumerable<long>
{
public static readonly long[] Value=A208634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208634.Bytes);
public long this[int i]=>Value[i];

public static A208634Inst Instance=new A208634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208635
{
public static readonly long[] Value={ 32L,95L,309L,1042L,3577L,12404L,43284L,151656L,532795L,1875161L,6607478L,23301225L,82215220L,290187784L,1024490960L,3617470935L,12774594765L,45114821146L,159335044937L,562751474084L,1987608261228L,7020221345560L,24795605196403L };
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
public class A208635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208635Inst : IEnumerable<long>
{
public static readonly long[] Value=A208635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208635.Bytes);
public long this[int i]=>Value[i];

public static A208635Inst Instance=new A208635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208636
{
public static readonly long[] Value={ 64L,191L,628L,2149L,7504L,26508L,94320L,337227L,1209736L,4349981L,15668332L,56505640L,203961088L,736686999L,2662084284L,9622940853L,34793691400L,125826023972L,455089068016L,1646125164451L,5954682909712L,21541486064685L };
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
public class A208636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208636Inst : IEnumerable<long>
{
public static readonly long[] Value=A208636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208636.Bytes);
public long this[int i]=>Value[i];

public static A208636Inst Instance=new A208636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208637
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,4L,8L,11L,13L,8L,16L,23L,32L,34L,16L,32L,47L,71L,95L,89L,32L,64L,95L,150L,225L,284L,233L,64L,128L,191L,309L,494L,722L,851L,610L,128L,256L,383L,628L,1042L,1652L,2331L,2552L,1597L,256L,512L,767L,1267L,2149L,3577L,5572L,7548L,7655L,4181L,512L,1024L,1535L };
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
public class A208637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208637Inst : IEnumerable<long>
{
public static readonly long[] Value=A208637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208637.Bytes);
public long this[int i]=>Value[i];

public static A208637Inst Instance=new A208637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208638
{
public static readonly long[] Value={ 4L,13L,32L,71L,150L,309L,628L,1267L,2546L,5105L,10224L,20463L,40942L,81901L,163820L,327659L,655338L,1310697L,2621416L,5242855L,10485734L,20971493L,41943012L,83886051L,167772130L,335544289L,671088608L,1342177247L,2684354526L,5368709085L };
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
public class A208638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208638Inst : IEnumerable<long>
{
public static readonly long[] Value=A208638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208638.Bytes);
public long this[int i]=>Value[i];

public static A208638Inst Instance=new A208638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208639
{
public static readonly long[] Value={ 8L,34L,95L,225L,494L,1042L,2149L,4375L,8840L,17784L,35687L,71509L,143170L,286510L,573209L,1146627L,2293484L,4587220L,9174715L,18349729L,36699782L,73399914L,146800205L,293600815L,587202064L,1174404592L,2348809679L,4697619885L };
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
public class A208639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208639Inst : IEnumerable<long>
{
public static readonly long[] Value=A208639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208639.Bytes);
public long this[int i]=>Value[i];

public static A208639Inst Instance=new A208639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208640
{
public static readonly long[] Value={ 16L,89L,284L,722L,1652L,3577L,7504L,15448L,31440L,63543L,127884L,256718L,514556L,1030421L,2062360L,4126468L,8254936L,16512147L,33026868L,66056634L,132116516L,264236657L,528477344L,1056959152L,2113923232L,4227851887L,8455709724L };
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
public class A208640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208640Inst : IEnumerable<long>
{
public static readonly long[] Value=A208640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208640.Bytes);
public long this[int i]=>Value[i];

public static A208640Inst Instance=new A208640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208641
{
public static readonly long[] Value={ 32L,233L,851L,2331L,5572L,12404L,26508L,55260L,113427L,230559L,465773L,937321L,1881726L,3772054L,7554458L,15121266L,30257157L,60531513L,121083123L,242189591L,484406152L,968843304L,1937722072L,3875484536L,7751014887L,15502081539L };
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
public class A208641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208641Inst : IEnumerable<long>
{
public static readonly long[] Value=A208641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208641.Bytes);
public long this[int i]=>Value[i];

public static A208641Inst Instance=new A208641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208642
{
public static readonly long[] Value={ 64L,610L,2552L,7548L,18888L,43284L,94320L,199299L,412962L,844943L,1714680L,3461238L,6962956L,13976742L,28016664L,56111133L,112317270L,224749641L,449637728L,899440872L,1799078160L,3598388200L,7197048672L,14394415431L,28789200714L };
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
public class A208642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208642Inst : IEnumerable<long>
{
public static readonly long[] Value=A208642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208642.Bytes);
public long this[int i]=>Value[i];

public static A208642Inst Instance=new A208642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208643
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,11L,13L,16L,17L,19L,23L,23L,29L,29L,29L,31L,37L,37L,37L,41L,41L,43L,47L,47L,53L,53L,53L,59L,59L,59L,61L,64L,67L,67L,71L,71L,73L,79L,79L,79L,83L,83L,89L,89L,89L,97L,97L,97L,97L,101L,101L,103L,107L,107L,109L,113L,113L,127L,127L,127L };
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
public class A208643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208643Inst : IEnumerable<long>
{
public static readonly long[] Value=A208643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208643.Bytes);
public long this[int i]=>Value[i];

public static A208643Inst Instance=new A208643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208644
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,2L,3L,5L,11L,6L,13L,7L,15L,2L,17L,6L,19L,5L,7L,11L,23L,6L,5L,13L,3L,7L,29L,30L,31L,2L,11L,17L,35L,6L,37L,19L,13L,5L,41L,6L,43L,11L,15L,23L,47L,6L,7L,5L,17L,13L,53L,6L,11L,7L,19L,29L,59L,30L,61L,31L,7L,2L,13L,6L,67L,17L,23L,35L,71L,6L,73L };
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
public class A208644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208644Inst : IEnumerable<long>
{
public static readonly long[] Value=A208644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208644.Bytes);
public long this[int i]=>Value[i];

public static A208644Inst Instance=new A208644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208645
{
public static readonly long[] Value={ 2L,4L,1L,2L,1L,4L,1L,1L,1L,2L,1L,10L,1L,1L,1L,2L,1L,16L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,4L,1L,1L,1L,2L,1L,40L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,6L,1L,1L,1L,2L,1L,1L,1L,1L };
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
public class A208645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208645Inst : IEnumerable<long>
{
public static readonly long[] Value=A208645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208645.Bytes);
public long this[int i]=>Value[i];

public static A208645Inst Instance=new A208645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208646
{
public static readonly long[] Value={ 9861L,-1986L,9681L,-1896L,8961L,-1968L,8691L,-1698L };
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
public class A208646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208646Inst : IEnumerable<long>
{
public static readonly long[] Value=A208646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208646.Bytes);
public long this[int i]=>Value[i];

public static A208646Inst Instance=new A208646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208647
{
public static readonly long[] Value={ 1L,1L,1L,7L,2L,2L,17L,3L,3L,31L,4L,4L,49L,5L,5L,71L };
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
public class A208647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208647Inst : IEnumerable<long>
{
public static readonly long[] Value=A208647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208647.Bytes);
public long this[int i]=>Value[i];

public static A208647Inst Instance=new A208647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208648
{
public static readonly long[] Value={ 2L,1L,1L,4L,1L,1L,6L,1L,1L,8L,1L,1L,10L,1L,1L,12L };
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
public class A208648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208648Inst : IEnumerable<long>
{
public static readonly long[] Value=A208648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208648.Bytes);
public long this[int i]=>Value[i];

public static A208648Inst Instance=new A208648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208649
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,6L,40L,150L,2100L,14700L,423360L,5556600L,325987200L,8068183200L,958961203200L,44996257706400L,10799101849536000L,965169727802280000L,BigInteger.Parse("466713183932835840000"),BigInteger.Parse("79775138681769651120000") };
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
public class A208649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208649Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208649.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208649.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208649Inst Instance=new A208649Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208650
{
public static readonly BigInteger[] Value={ 1L,2L,6L,36L,480L,15000L,1134000L,211768200L,99131719680L,117595223746560L,356467003200000000L,BigInteger.Parse("2779532232516963000000"),BigInteger.Parse("56049508602150185041920000"),BigInteger.Parse("2935889842347365340037522521600") };
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
public class A208650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208650.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208650Inst Instance=new A208650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208651
{
public static readonly BigInteger[] Value={ 1L,2L,12L,216L,11520L,1800000L,816480000L,1067311728000L,3996990937497600L,BigInteger.Parse("42672954793151692800"),BigInteger.Parse("1293547461212160000000000"),BigInteger.Parse("110950032218933108678400000000"),BigInteger.Parse("26847804299643702075375747072000000") };
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
public class A208651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208651.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208651Inst Instance=new A208651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208652
{
public static readonly BigInteger[] Value={ 1L,2L,18L,48L,3000L,10800L,4321800L,21073920L,51849745920L,342921600000L,5062554438480000L,45444644517888000L,BigInteger.Parse("3960533401513405516800"),BigInteger.Parse("48272757747179554068480"),BigInteger.Parse("24547182197052103038450000000") };
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
public class A208652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208652.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208652Inst Instance=new A208652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208653
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,4L,50L,90L,5145L,12544L,3429216L,11340000L,15219319500L,68309049600L,457937132487120L,2790771598030416L,BigInteger.Parse("94609025993497640625"),BigInteger.Parse("783056974947287040000"),BigInteger.Parse("135476575389769051389952000") };
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
public class A208653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208653Inst Instance=new A208653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208654
{
public static readonly BigInteger[] Value={ 1L,2L,18L,144L,12000L,540000L,388962000L,108425318400L,650403212820480L,1175952237465600000L,BigInteger.Parse("57409367332363200000000"),BigInteger.Parse("691636564481660937216000000"),BigInteger.Parse("270540272566435932512004833280000") };
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
public class A208654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208654.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208654Inst Instance=new A208654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208655
{
public static readonly BigInteger[] Value={ 1L,1L,6L,36L,2400L,90000L,55566000L,13553164800L,72267023646720L,117595223746560000L,BigInteger.Parse("5219033393851200000000"),BigInteger.Parse("57636380373471744768000000"),BigInteger.Parse("20810790197418148654769602560000"),BigInteger.Parse("1578992018570629416640340512656998400") };
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
public class A208655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208655.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208655Inst Instance=new A208655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208656
{
public static readonly long[] Value={ 0L,3L,1L,8L,7L,2L,15L,21L,13L,3L,24L,46L,44L,21L,4L,35L,85L,110L,80L,31L,5L,48L,141L,230L,225L,132L,43L,6L,63L,217L,427L,525L,413L,203L,57L,7L,80L,316L,728L,1078L,1064L,700L,296L,73L,8L,99L,441L,1164L,2016L,2394L,1974L,1116L,414L,91L,9L,120L,595L,1770L };
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
public class A208656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208656Inst : IEnumerable<long>
{
public static readonly long[] Value=A208656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208656.Bytes);
public long this[int i]=>Value[i];

public static A208656Inst Instance=new A208656Inst();

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