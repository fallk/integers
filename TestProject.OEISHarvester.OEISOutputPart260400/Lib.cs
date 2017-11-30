using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A241222
{
public static readonly long[] Value={ 0L,3L,69L,390L,1314L,3441L,7503L,14388L,25692L,42471L,66417L,100194L,145206L,204429L,280971L,377400L,496608L,642891L,821925L,1034742L,1288602L,1587009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241222Inst : IEnumerable<long>
{
public static readonly long[] Value=A241222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241222.Bytes);
public long this[int i]=>Value[i];

public static A241222Inst Instance=new A241222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241223
{
public static readonly long[] Value={ 0L,32L,900L,7380L,34676L,118044L,325872L,775856L,1653888L,3237984L,5923028L,10249596L,16938588L,26924036L,41393424L,61830480L,90059672L,128293728L,179185500L,245889068L,332107188L,442162836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241223Inst : IEnumerable<long>
{
public static readonly long[] Value=A241223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241223.Bytes);
public long this[int i]=>Value[i];

public static A241223Inst Instance=new A241223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241224
{
public static readonly long[] Value={ 0L,8L,204L,1788L,8690L,30360L,85194L,205394L,441876L,870912L,1601708L,2783574L,4616220L,7358312L,11339430L,16972182L,24763604L,35328426L,49405944L,67873484L,91762128L,122276784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241224Inst : IEnumerable<long>
{
public static readonly long[] Value=A241224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241224.Bytes);
public long this[int i]=>Value[i];

public static A241224Inst Instance=new A241224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241225
{
public static readonly long[] Value={ 0L,12L,216L,1104L,3708L,9396L,20304L,38868L,68364L,112632L,176076L,263832L,381924L,536424L,735240L,985896L,1296540L,1676508L,2137392L,2689248L,3344244L,4114020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241225Inst : IEnumerable<long>
{
public static readonly long[] Value=A241225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241225.Bytes);
public long this[int i]=>Value[i];

public static A241225Inst Instance=new A241225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241226
{
public static readonly long[] Value={ 0L,12L,480L,4488L,22278L,78288L,220374L,531594L,1143648L,2254440L,4145244L,7202190L,11940444L,19029300L,29318754L,43872402L,63999528L,91288794L,127642164L,175326336L,237000816L,315772032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241226Inst : IEnumerable<long>
{
public static readonly long[] Value=A241226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241226.Bytes);
public long this[int i]=>Value[i];

public static A241226Inst Instance=new A241226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241227
{
public static readonly long[] Value={ 0L,12L,648L,6084L,30444L,107376L,302916L,732024L,1576728L,3111012L,5724852L,9952620L,16509336L,26321160L,40567872L,60724104L,88605480L,126413772L,176788476L,242874756L,328359624L,437553360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241227Inst : IEnumerable<long>
{
public static readonly long[] Value=A241227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241227.Bytes);
public long this[int i]=>Value[i];

public static A241227Inst Instance=new A241227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241228
{
public static readonly long[] Value={ 0L,20L,252L,1296L,4232L,10668L,22956L,43832L,77160L,126972L,198176L,296976L,429252L,602876L,825552L,1106376L,1454192L,1879956L,2397024L,3014312L,3747564L,4609476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241228Inst : IEnumerable<long>
{
public static readonly long[] Value=A241228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241228.Bytes);
public long this[int i]=>Value[i];

public static A241228Inst Instance=new A241228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241229
{
public static readonly long[] Value={ 0L,8L,144L,768L,2558L,6564L,14334L,27626L,48828L,80772L,126692L,190230L,275700L,388016L,532386L,714906L,941600L,1219410L,1556184L,1959608L,2438868L,3002700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241229Inst : IEnumerable<long>
{
public static readonly long[] Value=A241229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241229.Bytes);
public long this[int i]=>Value[i];

public static A241229Inst Instance=new A241229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241230
{
public static readonly long[] Value={ 0L,12L,108L,528L,1674L,4104L,8622L,16206L,28332L,46200L,71484L,106746L,153552L,214860L,293166L,391470L,512592L,660546L,840840L,1054704L,1308696L,1606776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241230Inst : IEnumerable<long>
{
public static readonly long[] Value=A241230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241230.Bytes);
public long this[int i]=>Value[i];

public static A241230Inst Instance=new A241230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241231
{
public static readonly long[] Value={ 0L,4L,34L,134L,379L,866L,1718L,3085L,5149L,8095L,12188L,17664L,24781L,33861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241231Inst : IEnumerable<long>
{
public static readonly long[] Value=A241231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241231.Bytes);
public long this[int i]=>Value[i];

public static A241231Inst Instance=new A241231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241280
{
public static readonly long[] Value={ 7L,13L,126L,773L,6783L,77955L,1009773L,14440961L,217830879L,3381893022L,53303588755L,846694715304L,13502819912939L,215775668844659L,3451661371624419L,55243520432395260L,884402593677949937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241280Inst : IEnumerable<long>
{
public static readonly long[] Value=A241280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241280.Bytes);
public long this[int i]=>Value[i];

public static A241280Inst Instance=new A241280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241281
{
public static readonly BigInteger[] Value={ 10L,17L,224L,1800L,20717L,309657L,5423164L,113305157L,2759021846L,75062814060L,2194626322280L,66941258995665L,2089883847033445L,66049038598082087L,2100649576601196394L,BigInteger.Parse("67025504140569165794") };
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
public class A241281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241281Inst Instance=new A241281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241282
{
public static readonly long[] Value={ 15L,35L,934L,16843L,451318L,15616828L,730435588L,40083129145L,2390612565177L,147969997624544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241282Inst : IEnumerable<long>
{
public static readonly long[] Value=A241282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241282.Bytes);
public long this[int i]=>Value[i];

public static A241282Inst Instance=new A241282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241283
{
public static readonly long[] Value={ 2L,3L,4L,4L,3L,10L,7L,5L,9L,24L,10L,13L,41L,36L,56L,15L,17L,126L,236L,139L,132L,24L,35L,224L,773L,1615L,532L,312L,35L,90L,934L,1800L,6783L,12356L,2111L,736L,54L,141L,2741L,16843L,20717L,77955L,96171L,8473L,1736L,83L,288L,5225L,54167L,451318L,309657L,1009773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241283Inst : IEnumerable<long>
{
public static readonly long[] Value=A241283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241283.Bytes);
public long this[int i]=>Value[i];

public static A241283Inst Instance=new A241283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241284
{
public static readonly long[] Value={ 4L,3L,5L,13L,17L,35L,90L,141L,288L,670L,1101L,2265L,4995L,8474L,17477L,37329L,64894L,133967L,279966L,496683L,1023868L,2105032L,3799717L,7810452L,15858460L,29052053L,59504463L,119660776L,221989407L,452920894L,904106577L,1695187559L,3445124586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241284Inst : IEnumerable<long>
{
public static readonly long[] Value=A241284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241284.Bytes);
public long this[int i]=>Value[i];

public static A241284Inst Instance=new A241284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241285
{
public static readonly long[] Value={ 10L,9L,41L,126L,224L,934L,2741L,5225L,20537L,55667L,113588L,422541L,1125360L,2473769L,8840311L,23068806L,53641026L,184488860L,476641936L,1157699906L,3848451987L,9887622772L,24862454468L,80220253420L,205811182949L,531847795781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241285Inst : IEnumerable<long>
{
public static readonly long[] Value=A241285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241285.Bytes);
public long this[int i]=>Value[i];

public static A241285Inst Instance=new A241285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241286
{
public static readonly long[] Value={ 24L,36L,236L,773L,1800L,16843L,54167L,159403L,1014287L,3055986L,10609732L,60969600L,191316011L,725713555L,3761999379L,12377676801L,48908645074L,236055743934L,808188094976L,3233355467890L,14810044876373L,52228582550562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241286Inst : IEnumerable<long>
{
public static readonly long[] Value=A241286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241286.Bytes);
public long this[int i]=>Value[i];

public static A241286Inst Instance=new A241286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241287
{
public static readonly long[] Value={ 56L,139L,1615L,6783L,20717L,451318L,1543713L,8288114L,79113707L,276340333L,1878731208L,14642190232L,59010752583L,404841299508L,2875913561864L,13757588225177L,90753330244908L,606550462257317L,3111205949073436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241287Inst : IEnumerable<long>
{
public static readonly long[] Value=A241287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241287.Bytes);
public long this[int i]=>Value[i];

public static A241287Inst Instance=new A241287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241288
{
public static readonly long[] Value={ 132L,532L,12356L,77955L,309657L,15616828L,60486552L,1053647507L,8994144991L,39245305813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241288Inst : IEnumerable<long>
{
public static readonly long[] Value=A241288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241288.Bytes);
public long this[int i]=>Value[i];

public static A241288Inst Instance=new A241288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241289
{
public static readonly long[] Value={ 7L,8L,9L,13L,18L,22L,37L,57L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241289Inst : IEnumerable<long>
{
public static readonly long[] Value=A241289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241289.Bytes);
public long this[int i]=>Value[i];

public static A241289Inst Instance=new A241289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241290
{
public static readonly long[] Value={ 0L,9L,0L,9L,7L,-100L,-471L,-1330L,-2966L,-5733L,-10050L,-16401L,-25335L,-37466L,-53473L,-74100L,-100156L,-132515L,-172116L,-219963L,-277125L,-344736L,-423995L,-516166L,-622578L,-744625L,-883766L,-1041525L,-1219491L,-1419318L,-1642725L,-1891496L,-2167480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241290Inst : IEnumerable<long>
{
public static readonly long[] Value=A241290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241290.Bytes);
public long this[int i]=>Value[i];

public static A241290Inst Instance=new A241290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241291
{
public static readonly long[] Value={ 2L,1L,2L,0L,0L,3L,8L,7L,2L,8L,8L,0L,8L,2L,1L,1L,9L,8L,4L,8L,8L,5L,1L,6L,4L,6L,9L,1L,6L,6L,2L,2L,7L,4L,6L,3L,0L,8L,3L,5L,6L,5L,4L,2L,3L,0L,6L,7L,5L,3L,7L,2L,4L,8L,3L,6L,2L,5L,9L,5L,1L,7L,5L,2L,3L,5L,4L,4L,1L,4L,5L,6L,5L,5L,6L,1L,1L,6L,1L,0L,4L,0L,7L,0L,8L,7L,7L,1L,0L,0L,8L,8L,0L,6L,9L,3L,2L,2L,1L,3L,9L,7L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241291Inst : IEnumerable<long>
{
public static readonly long[] Value=A241291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241291.Bytes);
public long this[int i]=>Value[i];

public static A241291Inst Instance=new A241291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241292
{
public static readonly long[] Value={ 1L,2L,5L,8L,0L,1L,4L,2L,9L,0L,6L,2L,7L,4L,9L,1L,3L,1L,7L,8L,6L,0L,3L,9L,0L,6L,9L,8L,2L,0L,3L,2L,8L,1L,2L,1L,5L,5L,1L,8L,0L,4L,6L,7L,1L,4L,3L,1L,6L,5L,9L,6L,0L,1L,5L,1L,8L,9L,6L,7L,4L,9L,4L,4L,3L,8L,1L,2L,1L,1L,0L,1L,1L,3L,0L,0L,0L,1L,7L,7L,8L,5L,3L,1L,0L,8L,0L,3L,9L,0L,3L,2L,9L,6L,2L,4L,0L,1L,1L,5L,6L,9L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241292Inst : IEnumerable<long>
{
public static readonly long[] Value=A241292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241292.Bytes);
public long this[int i]=>Value[i];

public static A241292Inst Instance=new A241292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241293
{
public static readonly long[] Value={ 2L,3L,6L,1L,0L,2L,2L,6L,7L,1L,4L,5L,9L,7L,3L,1L,3L,2L,0L,6L,8L,7L,7L,0L,2L,7L,4L,9L,7L,7L,8L,1L,7L,9L,4L,3L,0L,9L,4L,6L,1L,2L,7L,2L,9L,1L,4L,7L,7L,5L,1L,5L,4L,4L,6L,7L,1L,9L,2L,5L,6L,9L,4L,6L,2L,1L,2L,7L,1L,1L,8L,5L,3L,6L,6L,6L,4L,7L,5L,5L,2L,4L,9L,4L,5L,7L,6L,9L,3L,5L,0L,1L,0L,1L,9L,4L,1L,9L,9L,7L,7L,1L,6L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241293Inst : IEnumerable<long>
{
public static readonly long[] Value=A241293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241293.Bytes);
public long this[int i]=>Value[i];

public static A241293Inst Instance=new A241293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241294
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,8L,8L,0L,8L,1L,7L,9L,9L,9L,7L,4L,4L,5L,2L,8L,6L,1L,7L,8L,2L,7L,4L,1L,8L,6L,0L,5L,7L,5L,4L,5L,1L,6L,7L,3L,4L,6L,5L,2L,0L,5L,9L,6L,2L,7L,2L,1L,5L,4L,7L,3L,3L,3L,8L,6L,7L,4L,5L,2L,2L,5L,1L,9L,6L,5L,5L,4L,8L,3L,3L,7L,4L,0L,1L,8L,4L,7L,3L,5L,2L,0L,9L,9L,4L,0L,1L,8L,1L,1L,0L,5L,7L,3L,6L,4L,3L,5L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241294Inst : IEnumerable<long>
{
public static readonly long[] Value=A241294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241294.Bytes);
public long this[int i]=>Value[i];

public static A241294Inst Instance=new A241294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241295
{
public static readonly long[] Value={ 4L,4L,4L,6L,2L,3L,5L,1L,9L,0L,2L,3L,6L,9L,3L,4L,6L,9L,7L,5L,2L,5L,6L,5L,8L,2L,2L,2L,8L,2L,9L,2L,0L,0L,1L,5L,4L,0L,5L,7L,9L,4L,1L,4L,5L,4L,2L,4L,6L,3L,9L,6L,6L,3L,4L,2L,7L,8L,2L,6L,1L,5L,6L,9L,4L,4L,6L,3L,1L,4L,6L,6L,9L,7L,2L,3L,2L,2L,9L,7L,7L,5L,8L,4L,9L,2L,9L,4L,3L,0L,5L,0L,4L,8L,2L,1L,9L,1L,9L,3L,2L,6L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241295Inst : IEnumerable<long>
{
public static readonly long[] Value=A241295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241295.Bytes);
public long this[int i]=>Value[i];

public static A241295Inst Instance=new A241295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241488
{
public static readonly long[] Value={ 53L,263L,389L,431L,983L,1013L,1061L,1223L,1571L,1823L,2789L,3323L,3533L,3911L,4211L,5849L,6563L,6653L,7019L,7481L,8369L,8963L,9041L,9173L,9413L,9539L,9803L,10091L,10559L,10979L,12611L,12689L,12911L,13163L,13751L,13781L,14243L,14879L,15083L,16691L,17231L,17483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241488Inst : IEnumerable<long>
{
public static readonly long[] Value=A241488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241488.Bytes);
public long this[int i]=>Value[i];

public static A241488Inst Instance=new A241488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241489
{
public static readonly long[] Value={ 16L,52L,101L,252L,1002L,1001L,10003L,10002L,10001L,100003L,100002L,100001L,1000003L,1000002L,1000001L,10000003L,10000002L,10000001L,100000003L,100000002L,100000001L,1000000003L,1000000002L,1000000001L,10000000003L,10000000002L,10000000001L,100000000003L,100000000002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241489Inst : IEnumerable<long>
{
public static readonly long[] Value=A241489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241489.Bytes);
public long this[int i]=>Value[i];

public static A241489Inst Instance=new A241489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241490
{
public static readonly long[] Value={ 16L,52L,126L,252L,3138L,5852L,58752L,71138L,493352L,1916568L,11696559L,58633193L,191293929L,464296543L,386826983L,5886958939L,46493141317L,115356679131L,79633784516L,2154578383152L,6694429222569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241490Inst : IEnumerable<long>
{
public static readonly long[] Value=A241490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241490.Bytes);
public long this[int i]=>Value[i];

public static A241490Inst Instance=new A241490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241491
{
public static readonly long[] Value={ 88L,94L,104L,121L,122L,155L,262L,314L,328L,368L,377L,397L,416L,431L,433L,434L,440L,466L,472L,497L,500L,590L,620L,654L,655L,664L,671L,676L,688L,704L,710L,716L,720L,905L,945L,961L,973L,977L,1063L,1103L,1114L,1131L,1228L,1234L,1249L,1250L,1270L,1312L,1343L,1348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241491Inst : IEnumerable<long>
{
public static readonly long[] Value=A241491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241491.Bytes);
public long this[int i]=>Value[i];

public static A241491Inst Instance=new A241491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241492
{
public static readonly long[] Value={ 0L,1L,1L,0L,2L,2L,2L,1L,1L,1L,1L,2L,3L,3L,2L,3L,5L,3L,3L,2L,2L,2L,6L,3L,2L,5L,3L,4L,5L,5L,4L,7L,7L,7L,5L,4L,3L,5L,5L,8L,6L,2L,5L,4L,5L,3L,2L,5L,7L,6L,5L,4L,5L,8L,10L,8L,10L,4L,6L,6L,7L,8L,3L,4L,4L,9L,6L,4L,7L,8L,7L,5L,7L,7L,6L,9L,12L,6L,11L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241492Inst : IEnumerable<long>
{
public static readonly long[] Value=A241492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241492.Bytes);
public long this[int i]=>Value[i];

public static A241492Inst Instance=new A241492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241493
{
public static readonly long[] Value={ 1627L,2917L,3583L,4603L,5581L,6367L,6379L,8263L,9697L,12517L,12763L,13339L,14197L,15289L,16339L,16993L,17539L,17737L,18199L,19267L,19531L,20023L,28057L,28879L,29587L,32647L,33427L,34033L,34537L,35353L,35617L,37039L,37087L,37657L,37663L,42337L,43093L,47533L,48049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241493Inst : IEnumerable<long>
{
public static readonly long[] Value=A241493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241493.Bytes);
public long this[int i]=>Value[i];

public static A241493Inst Instance=new A241493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241494
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,8L,7L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241494Inst : IEnumerable<long>
{
public static readonly long[] Value=A241494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241494.Bytes);
public long this[int i]=>Value[i];

public static A241494Inst Instance=new A241494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241495
{
public static readonly long[] Value={ 101L,101L,101L,101L,101L,351L,1244L,194L,4648L,951L,4357L,3757L,2169L,2392L,7399L,7501L,9723L,8683L,13867L,6152L,15204L,18898L,40141L,54631L,29647L,35586L,46564L,67743L,84789L,119421L,43055L,43642L,83055L,44411L,142553L,94501L,135852L,52299L,174062L,121201L,196205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241495Inst : IEnumerable<long>
{
public static readonly long[] Value=A241495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241495.Bytes);
public long this[int i]=>Value[i];

public static A241495Inst Instance=new A241495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241496
{
public static readonly long[] Value={ 1L,4L,4L,12L,9L,24L,16L,40L,25L,60L,36L,84L,49L,112L,64L,144L,81L,180L,100L,220L,121L,264L,144L,312L,169L,364L,196L,420L,225L,480L,256L,544L,289L,612L,324L,684L,361L,760L,400L,840L,441L,924L,484L,1012L,529L,1104L,576L,1200L,625L,1300L,676L,1404L,729L,1512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241496Inst : IEnumerable<long>
{
public static readonly long[] Value=A241496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241496.Bytes);
public long this[int i]=>Value[i];

public static A241496Inst Instance=new A241496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241497
{
public static readonly BigInteger[] Value={ 0L,1L,2L,6L,20L,88L,496L,3808L,39360L,566144L,11208448L,312282624L,12102016000L,663758845952L,50897375227904L,5539307216494592L,844981210166968320L,BigInteger.Parse("183201981290428727296"),BigInteger.Parse("55743092552083293274112") };
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
public class A241497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241497Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241497.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241497.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241497Inst Instance=new A241497Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241498
{
public static readonly BigInteger[] Value={ 2L,1L,3L,5L,17L,57L,329L,2153L,23209L,298793L,6240297L,159222313L,6549286441L,332636583465L,27158513845801L,2752117405591081L,447717208255194665L,BigInteger.Parse("90629100354663736873"),BigInteger.Parse("29432224060567101302313") };
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
public class A241498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241498.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241498Inst Instance=new A241498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241499
{
public static readonly long[] Value={ 0L,3L,1L,1L,1L,0L,2L,0L,0L,2L,0L,0L,1L,0L,2L,2L,3L,0L,0L,4L,0L,0L,1L,2L,1L,0L,0L,0L,0L,2L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241499Inst : IEnumerable<long>
{
public static readonly long[] Value=A241499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241499.Bytes);
public long this[int i]=>Value[i];

public static A241499Inst Instance=new A241499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241500
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,4L,1L,1L,11L,16L,7L,1L,1L,23L,58L,41L,11L,1L,1L,47L,196L,215L,90L,16L,1L,1L,95L,634L,1041L,640L,176L,22L,1L,1L,191L,1996L,4767L,4151L,1631L,315L,29L,1L,1L,383L,6178L,21001L,25221L,13587L,3696L,526L,37L,1L,1L,767L,18916L,90055L,146140L,105042L,38409L,7638L,831L,46L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241500Inst : IEnumerable<long>
{
public static readonly long[] Value=A241500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241500.Bytes);
public long this[int i]=>Value[i];

public static A241500Inst Instance=new A241500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241501
{
public static readonly long[] Value={ 167564622641L,174977122641L,175543159858L,175543162247L,183477122641L,183518142444L,191500000000L,2779888721787L,2784986175699L,212148288981849L,212148288982006L,315131893491390L,321400000000000L,417586822240846L,417586822241003L,418112649991390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241501Inst : IEnumerable<long>
{
public static readonly long[] Value=A241501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241501.Bytes);
public long this[int i]=>Value[i];

public static A241501Inst Instance=new A241501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241502
{
public static readonly long[] Value={ 324L,648L,756L,4448L,4961L,4983L,5849L,11124L,34453L,37609L,54575L,97888L,860858L,1089693L,3143632L,3192897L,3588047L,3768167L,5557853L,25485909L,32899939L,35699309L,58260393L,64564422L,120054389L,121554165L,356346023L,357507563L,755438130L,990227314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241502Inst : IEnumerable<long>
{
public static readonly long[] Value=A241502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241502.Bytes);
public long this[int i]=>Value[i];

public static A241502Inst Instance=new A241502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241503
{
public static readonly long[] Value={ 12L,21L,34L,36L,43L,46L,58L,63L,64L,79L,85L,97L,338L,356L,374L,376L,426L,456L,544L,580L,593L,698L,845L,886L,947L,963L,2071L,2162L,3188L,4187L,5939L,8806L,8955L,8968L,9409L,9944L,34414L,34940L,38754L,41789L,42844L,44437L,45876L,47730L,49060L,54424L,58774L,67304L,69340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241503Inst : IEnumerable<long>
{
public static readonly long[] Value=A241503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241503.Bytes);
public long this[int i]=>Value[i];

public static A241503Inst Instance=new A241503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241568
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,2L,3L,1L,3L,2L,4L,2L,4L,2L,5L,3L,3L,5L,3L,4L,2L,5L,2L,4L,4L,3L,4L,3L,5L,3L,2L,5L,4L,7L,2L,6L,5L,4L,4L,5L,4L,3L,4L,7L,4L,4L,4L,5L,6L,4L,3L,5L,4L,3L,3L,3L,3L,3L,5L,6L,7L,8L,2L,5L,7L,6L,3L,5L,7L,5L,3L,4L,4L,6L,3L,6L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241568Inst : IEnumerable<long>
{
public static readonly long[] Value=A241568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241568.Bytes);
public long this[int i]=>Value[i];

public static A241568Inst Instance=new A241568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241569
{
public static readonly BigInteger[] Value={ 2L,13L,123457L,BigInteger.Parse("123456789101112131415161718192021222324252627282931") };
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
public class A241569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241569Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241569.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241569.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241569Inst Instance=new A241569Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241570
{
public static readonly BigInteger[] Value={ 11L,BigInteger.Parse("123456789101112131415161717") };
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
public class A241570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241570Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241570.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241570.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241570Inst Instance=new A241570Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241571
{
public static readonly long[] Value={ 0L,3L,5L,6L,9L,10L,12L,15L,17L,18L,20L,21L,24L,25L,27L,30L,31L,33L,35L,36L,38L,39L,40L,42L,45L,48L,50L,51L,52L,53L,54L,55L,57L,59L,60L,63L,64L,65L,66L,69L,70L,72L,73L,75L,77L,78L,80L,81L,84L,85L,86L,87L,90L,93L,94L,95L,96L,97L,99L,100L,101L,102L,103L,105L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241571Inst : IEnumerable<long>
{
public static readonly long[] Value=A241571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241571.Bytes);
public long this[int i]=>Value[i];

public static A241571Inst Instance=new A241571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241572
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,11L,14L,16L,17L,19L,20L,23L,24L,26L,29L,30L,32L,34L,35L,37L,38L,39L,41L,44L,47L,49L,50L,51L,52L,53L,54L,56L,58L,59L,62L,63L,64L,65L,68L,69L,71L,72L,74L,76L,77L,79L,80L,83L,84L,85L,86L,89L,92L,93L,94L,95L,96L,98L,99L,100L,101L,102L,104L,107L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241572Inst : IEnumerable<long>
{
public static readonly long[] Value=A241572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241572.Bytes);
public long this[int i]=>Value[i];

public static A241572Inst Instance=new A241572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241573
{
public static readonly BigInteger[] Value={ 7L,11L,35L,131L,2051L,8195L,131075L,524291L,8388611L,536870915L,2147483651L,137438953475L,2199023255555L,8796093022211L,140737488355331L,9007199254740995L,576460752303423491L,2305843009213693955L,BigInteger.Parse("147573952589676412931"),BigInteger.Parse("2361183241434822606851") };
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
public class A241573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241573.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241573Inst Instance=new A241573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241574
{
public static readonly long[] Value={ 1L,3L,9L,27L,78L,222L,618L,1686L,4512L,11856L,30624L,77856L,195072L,482304L,1178112L,2846208L,6807552L,16134144L,37920768L,88449024L,204865536L,471465984L,1078591488L,2454061056L,5555355648L,12516851712L,28078768128L,62732107776L,139619991552L,309640298496L,684409749504L,1508036837376L,3313030397952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241574Inst : IEnumerable<long>
{
public static readonly long[] Value=A241574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241574.Bytes);
public long this[int i]=>Value[i];

public static A241574Inst Instance=new A241574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241575
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241575Inst : IEnumerable<long>
{
public static readonly long[] Value=A241575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241575.Bytes);
public long this[int i]=>Value[i];

public static A241575Inst Instance=new A241575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241576
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,2L,2L,2L,4L,6L,8L,10L,16L,22L,31L,44L,62L,88L,124L,176L,248L,352L,497L,702L,994L,1406L,1987L,2812L,3975L,5622L,7951L,11244L,15902L,22488L,31804L,44976L,63607L,89954L,127213L,179908L,254427L,359814L,508855L,719628L,1017709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241576Inst : IEnumerable<long>
{
public static readonly long[] Value=A241576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241576.Bytes);
public long this[int i]=>Value[i];

public static A241576Inst Instance=new A241576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241577
{
public static readonly long[] Value={ 1L,1L,15L,49L,109L,201L,331L,505L,729L,1009L,1351L,1761L,2245L,2809L,3459L,4201L,5041L,5985L,7039L,8209L,9501L,10921L,12475L,14169L,16009L,18001L,20151L,22465L,24949L,27609L,30451L,33481L,36705L,40129L,43759L,47601L,51661L,55945L,60459L,65209L,70201L,75441L,80935L,86689L,92709L,99001L,105571L,112425L,119569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241577Inst : IEnumerable<long>
{
public static readonly long[] Value=A241577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241577.Bytes);
public long this[int i]=>Value[i];

public static A241577Inst Instance=new A241577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241578
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,5L,1L,1L,4L,11L,15L,1L,1L,5L,19L,49L,52L,1L,1L,6L,29L,109L,257L,203L,1L,1L,7L,41L,201L,742L,1539L,877L,1L,1L,8L,55L,331L,1657L,5815L,10299L,4140L,1L,1L,9L,71L,505L,3176L,15821L,51193L,75905L,21147L,1L,1L,10L,89L,729L,5497L,35451L,170389L,498118L,609441L,115975L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241578Inst : IEnumerable<long>
{
public static readonly long[] Value=A241578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241578.Bytes);
public long this[int i]=>Value[i];

public static A241578Inst Instance=new A241578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241579
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,3L,1L,1L,15L,11L,4L,1L,1L,52L,49L,19L,5L,1L,1L,203L,257L,109L,29L,6L,1L,1L,877L,1539L,742L,201L,41L,7L,1L,1L,4140L,10299L,5815L,1657L,331L,55L,8L,1L,1L,21147L,75905L,51193L,15821L,3176L,505L,71L,9L,1L,1L,115975L,609441L,498118L,170389L,35451L,5497L,729L,89L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241579Inst : IEnumerable<long>
{
public static readonly long[] Value=A241579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241579.Bytes);
public long this[int i]=>Value[i];

public static A241579Inst Instance=new A241579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241580
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,4L,3L,9L,15L,27L,40L,52L,88L,148L,256L,205L,405L,665L,1105L,1845L,3125L,2556L,3786L,6216L,10206L,16836L,27906L,46656L,24409L,42301L,68803L,112315L,183757L,301609L,496951L,823543L,347712L,542984L,881392L,1431816L,2330336L,3800392L,6213264L,10188872L,16777216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241580Inst : IEnumerable<long>
{
public static readonly long[] Value=A241580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241580.Bytes);
public long this[int i]=>Value[i];

public static A241580Inst Instance=new A241580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241581
{
public static readonly BigInteger[] Value={ 1L,1L,8L,54L,584L,7350L,114162L,2053688L,42513984L,991883610L,25807006730L,740614555692L,23250961252752L,792694751381078L,29169262097277330L,1152329533163353680L,BigInteger.Parse("48645406703597457152"),BigInteger.Parse("2185462919071085059890"),BigInteger.Parse("104113841197940277430554"),BigInteger.Parse("5242449827954998459195220") };
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
public class A241581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241581Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241581.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241581.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241581Inst Instance=new A241581Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241582
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,16L,20L,25L,31L,32L,37L,42L,43L,56L,58L,71L,72L,97L,109L,114L,120L,136L,153L,158L,172L,199L,220L,226L,249L,252L,254L,280L,305L,316L,340L,392L,394L,400L,448L,452L,457L,486L,499L,529L,537L,546L,572L,588L,619L,657L,704L,737L,809L,814L,872L,921L,934L,964L,973L,993L,1014L,1024L,1048L,1074L,1113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241582Inst : IEnumerable<long>
{
public static readonly long[] Value=A241582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241582.Bytes);
public long this[int i]=>Value[i];

public static A241582Inst Instance=new A241582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241583
{
public static readonly long[] Value={ 1L,2L,3L,7L,14L,18L,26L,29L,33L,40L,41L,47L,57L,58L,70L,77L,94L,99L,113L,122L,136L,145L,157L,191L,194L,209L,228L,250L,251L,260L,290L,303L,307L,338L,342L,412L,417L,428L,452L,454L,471L,502L,531L,533L,541L,590L,596L,626L,627L,661L,716L,739L,811L,843L,908L,931L,937L,988L,1003L,1009L,1018L,1071L,1086L,1090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241583Inst : IEnumerable<long>
{
public static readonly long[] Value=A241583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241583.Bytes);
public long this[int i]=>Value[i];

public static A241583Inst Instance=new A241583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241648
{
public static readonly long[] Value={ 4L,124L,320L,392L,416L,800L,1352L,1520L,2912L,2960L,3536L,3872L,5720L,5936L,6320L,7112L,8216L,9176L,9912L,10472L,11816L,12152L,12896L,13280L,14960L,15176L,16080L,16400L,16536L,18032L,18392L,18560L,19136L,19880L,20000L,21632L,21680L,21920L,22736L,23120L,23816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241648Inst : IEnumerable<long>
{
public static readonly long[] Value=A241648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241648.Bytes);
public long this[int i]=>Value[i];

public static A241648Inst Instance=new A241648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241649
{
public static readonly long[] Value={ 7L,210L,378L,630L,1904L,3570L,6188L,6510L,7154L,9296L,9800L,10220L,12446L,13664L,14378L,17654L,17780L,18536L,19110L,19376L,19530L,20034L,20580L,21266L,23240L,23310L,24150L,24584L,25298L,26754L,27930L,28938L,29106L,29610L,30380L,31640L,34146L,34230L,34664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241649Inst : IEnumerable<long>
{
public static readonly long[] Value=A241649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241649.Bytes);
public long this[int i]=>Value[i];

public static A241649Inst Instance=new A241649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241650
{
public static readonly long[] Value={ 6L,22152L,35724L,125892L,132444L,146484L,166764L,182052L,192504L,202332L,239304L,242580L,248664L,267852L,291252L,300612L,375492L,375804L,434772L,460044L,494364L,536952L,547992L,550524L,618852L,628212L,646668L,707304L,708984L,752232L,777852L,824304L,828984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241650Inst : IEnumerable<long>
{
public static readonly long[] Value=A241650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241650.Bytes);
public long this[int i]=>Value[i];

public static A241650Inst Instance=new A241650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241651
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,4L,5L,6L,8L,10L,13L,16L,22L,27L,38L,47L,66L,81L,112L,136L,187L,227L,301L,363L,473L,568L,727L,862L,1088L,1289L,1596L,1876L,2304L,2697L,3265L,3810L,4583L,5327L,6358L,7354L,8736L,10101L,11924L,13750L,16195L,18653L,21883L,25177L,29484L,33906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241651Inst : IEnumerable<long>
{
public static readonly long[] Value=A241651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241651.Bytes);
public long this[int i]=>Value[i];

public static A241651Inst Instance=new A241651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241652
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,5L,6L,10L,13L,21L,25L,40L,47L,69L,84L,117L,138L,187L,222L,292L,344L,439L,519L,654L,768L,951L,1118L,1378L,1612L,1968L,2308L,2807L,3282L,3977L,4657L,5630L,6585L,7936L,9278L,11170L,13046L,15648L,18274L,21868L,25481L,30402L,35385L,42069L,48875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241652Inst : IEnumerable<long>
{
public static readonly long[] Value=A241652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241652.Bytes);
public long this[int i]=>Value[i];

public static A241652Inst Instance=new A241652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241653
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,1L,4L,5L,11L,12L,24L,25L,42L,46L,70L,72L,106L,110L,156L,157L,212L,218L,291L,295L,383L,391L,516L,524L,679L,712L,931L,978L,1280L,1392L,1820L,2002L,2609L,2920L,3816L,4310L,5547L,6350L,8118L,9286L,11749L,13502L,16892L,19391L,23996L,27498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241653Inst : IEnumerable<long>
{
public static readonly long[] Value=A241653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241653.Bytes);
public long this[int i]=>Value[i];

public static A241653Inst Instance=new A241653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241654
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,4L,7L,10L,16L,22L,32L,43L,61L,79L,108L,138L,184L,231L,304L,378L,491L,605L,775L,954L,1212L,1485L,1868L,2283L,2856L,3477L,4315L,5246L,6473L,7839L,9613L,11618L,14167L,17054L,20688L,24827L,29984L,35847L,43073L,51337L,61425L,72939L,86905L,102871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241654Inst : IEnumerable<long>
{
public static readonly long[] Value=A241654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241654.Bytes);
public long this[int i]=>Value[i];

public static A241654Inst Instance=new A241654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241655
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,4L,6L,9L,12L,17L,21L,31L,37L,54L,66L,92L,114L,159L,198L,268L,335L,448L,563L,736L,921L,1190L,1485L,1892L,2340L,2953L,3636L,4534L,5542L,6861L,8333L,10226L,12347L,15052L,18079L,21907L,26168L,31537L,37526L,44987L,53307L,63653L,75156L,89369L,105204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241655Inst : IEnumerable<long>
{
public static readonly long[] Value=A241655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241655.Bytes);
public long this[int i]=>Value[i];

public static A241655Inst Instance=new A241655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241656
{
public static readonly long[] Value={ 0L,0L,0L,4L,4L,6L,4L,6L,4L,6L,0L,9L,4L,6L,4L,6L,9L,10L,4L,6L,4L,6L,21L,9L,4L,6L,15L,10L,9L,9L,4L,6L,4L,6L,15L,10L,9L,14L,4L,6L,25L,10L,4L,6L,4L,6L,9L,9L,4L,6L,9L,9L,15L,14L,4L,6L,21L,10L,25L,9L,4L,6L,4L,6L,9L,9L,15L,14L,4L,6L,9L,10L,4L,6L,4L,6L,9L,10L,15L,14L,4L,6L,21L,9L,4L,6L,15L,10L,9L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241656Inst : IEnumerable<long>
{
public static readonly long[] Value=A241656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241656.Bytes);
public long this[int i]=>Value[i];

public static A241656Inst Instance=new A241656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241657
{
public static readonly long[] Value={ 1L,5L,13L,25L,50L,61L,85L,130L,145L,181L,250L,265L,338L,410L,421L,481L,610L,650L,685L,850L,841L,925L,1183L,1105L,1250L,1450L,1405L,1586L,1810L,1741L,1861L,2275L,2210L,2245L,2650L,2521L,2665L,3255L,3050L,3121L,3731L,3445L,3770L,4210L,3961L,4250L,4810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241657Inst : IEnumerable<long>
{
public static readonly long[] Value=A241657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241657.Bytes);
public long this[int i]=>Value[i];

public static A241657Inst Instance=new A241657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241658
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,4L,0L,4L,0L,6L,4L,4L,6L,6L,0L,4L,4L,6L,6L,0L,9L,9L,4L,4L,6L,6L,4L,4L,6L,6L,0L,9L,9L,10L,4L,4L,4L,6L,6L,4L,4L,6L,6L,21L,9L,9L,10L,4L,25L,6L,4L,15L,4L,10L,6L,9L,4L,9L,4L,4L,6L,6L,10L,4L,9L,6L,4L,15L,6L,10L,4L,9L,6L,14L,15L,4L,10L,6L,4L,25L,6L,10L,34L,4L,10L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241658Inst : IEnumerable<long>
{
public static readonly long[] Value=A241658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241658.Bytes);
public long this[int i]=>Value[i];

public static A241658Inst Instance=new A241658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241659
{
public static readonly long[] Value={ 2L,11L,13L,17L,19L,23L,31L,41L,53L,59L,89L,101L,131L,137L,149L,193L,211L,223L,227L,229L,233L,239L,251L,271L,293L,317L,331L,359L,401L,449L,461L,557L,563L,571L,593L,599L,619L,641L,659L,677L,691L,719L,739L,751L,809L,821L,853L,929L,971L,991L,1009L,1013L,1039L,1051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241659Inst : IEnumerable<long>
{
public static readonly long[] Value=A241659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241659.Bytes);
public long this[int i]=>Value[i];

public static A241659Inst Instance=new A241659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241660
{
public static readonly long[] Value={ 3L,4L,7L,19L,62L,94L,722L,5197L,5262L,6182L,14007L,21579L,35354L,75592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241660Inst : IEnumerable<long>
{
public static readonly long[] Value=A241660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241660.Bytes);
public long this[int i]=>Value[i];

public static A241660Inst Instance=new A241660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241661
{
public static readonly BigInteger[] Value={ 2L,3L,23L,60217L,108412217573460833L,BigInteger.Parse("143003097309669584171480759") };
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
public class A241661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241661.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241661Inst Instance=new A241661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241662
{
public static readonly long[] Value={ 1L,3L,7L,9L,10L,11L,13L,17L,19L,21L,23L,27L,29L,30L,31L,33L,37L,39L,41L,43L,47L,49L,51L,53L,57L,59L,61L,63L,67L,69L,70L,71L,73L,77L,79L,81L,83L,87L,89L,90L,91L,93L,97L,99L,100L,101L,103L,107L,109L,110L,111L,113L,117L,119L,121L,123L,127L,129L,130L,131L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241662Inst : IEnumerable<long>
{
public static readonly long[] Value=A241662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241662.Bytes);
public long this[int i]=>Value[i];

public static A241662Inst Instance=new A241662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241663
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,3L,0L,0L,0L,7L,0L,9L,0L,0L,0L,13L,0L,15L,0L,0L,0L,19L,0L,5L,0L,0L,0L,25L,0L,27L,0L,0L,0L,3L,0L,33L,0L,0L,0L,37L,0L,39L,0L,0L,0L,43L,0L,21L,0L,0L,0L,49L,0L,7L,0L,0L,0L,55L,0L,57L,0L,0L,0L,9L,0L,63L,0L,0L,0L,67L,0L,69L,0L,0L,0L,21L,0L,75L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241663Inst : IEnumerable<long>
{
public static readonly long[] Value=A241663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241663.Bytes);
public long this[int i]=>Value[i];

public static A241663Inst Instance=new A241663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242112
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,3L,5L,4L,6L,4L,7L,5L,8L,6L,9L,6L,10L,7L,11L,8L,12L,8L,13L,9L,14L,10L,15L,10L,16L,11L,17L,12L,18L,12L,19L,13L,20L,14L,21L,14L,22L,15L,23L,16L,24L,16L,25L,17L,26L,18L,27L,18L,28L,19L,29L,20L,30L,20L,31L,21L,32L,22L,33L,22L,34L,23L,35L,24L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242112Inst : IEnumerable<long>
{
public static readonly long[] Value=A242112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242112.Bytes);
public long this[int i]=>Value[i];

public static A242112Inst Instance=new A242112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242113
{
public static readonly long[] Value={ 0L,1L,2L,6L,7L,2L,14L,7L,11L,10L,33L,10L,42L,35L,47L,39L,122L,22L,248L,113L,247L,236L,751L,75L,1268L,812L,1422L,1531L,4543L,87L,8669L,5750L,8884L,10983L,29084L,2274L,58841L,41242L,58030L,74646L,216647L,11656L,419147L,313237L,364925L,617742L,1576642L,75542L,3071839L,2299620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242113Inst : IEnumerable<long>
{
public static readonly long[] Value=A242113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242113.Bytes);
public long this[int i]=>Value[i];

public static A242113Inst Instance=new A242113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242114
{
public static readonly long[] Value={ 1L,3L,1L,7L,1L,1L,11L,3L,1L,1L,19L,3L,1L,1L,1L,23L,7L,3L,1L,1L,1L,35L,7L,3L,1L,1L,1L,1L,43L,11L,3L,3L,1L,1L,1L,1L,55L,11L,7L,3L,1L,1L,1L,1L,1L,63L,19L,7L,3L,3L,1L,1L,1L,1L,1L,83L,19L,7L,3L,3L,1L,1L,1L,1L,1L,1L,91L,23L,11L,7L,3L,3L,1L,1L,1L,1L,1L,1L,115L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242114Inst : IEnumerable<long>
{
public static readonly long[] Value=A242114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242114.Bytes);
public long this[int i]=>Value[i];

public static A242114Inst Instance=new A242114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242115
{
public static readonly BigInteger[] Value={ 159L,895L,2047L,4607L,10239L,49151L,4718591L,20971519L,838860799L,137438953471L,5085241278463L,21440476741631L,BigInteger.Parse("340010386766614455386111"),BigInteger.Parse("96714065569170333976494079"),BigInteger.Parse("3288278229351791355200798719"),BigInteger.Parse("111414603535684224740921180159"),BigInteger.Parse("15370263527767281493147526365183") };
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
public class A242115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242115Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242115.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242115.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242115Inst Instance=new A242115Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242116
{
public static readonly BigInteger[] Value={ 9L,25L,65L,161L,2049L,4609L,22529L,1048577L,44040193L,283467841537L,1202590842881L,BigInteger.Parse("256065421246102339102334047485953"),BigInteger.Parse("4259306016766850789028922770063361"),BigInteger.Parse("356615920533143509709616588588493085605889"),BigInteger.Parse("57729314674570665269045550892293179276409335447553") };
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
public class A242116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242116Inst Instance=new A242116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242117
{
public static readonly BigInteger[] Value={ 0L,0L,3L,24L,1680L,5317635L,66314914699608L,BigInteger.Parse("8947678119828215014722891024"),BigInteger.Parse("178098260698995011212395018312912894502905113202338936835") };
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
public class A242117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242117Inst Instance=new A242117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242118
{
public static readonly long[] Value={ 0L,4L,12L,20L,28L,28L,44L,52L,60L,68L,68L,84L,92L,92L,108L,108L,124L,124L,140L,148L,148L,164L,172L,180L,188L,180L,196L,212L,220L,220L,228L,244L,252L,260L,260L,268L,284L,284L,300L,300L,308L,316L,332L,340L,348L,348L,364L,372L,380L,388L,380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242118Inst : IEnumerable<long>
{
public static readonly long[] Value=A242118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242118.Bytes);
public long this[int i]=>Value[i];

public static A242118Inst Instance=new A242118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242119
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,1L,5L,11L,13L,1L,5L,7L,11L,17L,5L,7L,13L,17L,1L,7L,11L,17L,7L,11L,13L,17L,1L,5L,1L,5L,11L,13L,5L,7L,13L,1L,5L,11L,17L,1L,11L,13L,17L,1L,13L,7L,11L,13L,17L,5L,7L,17L,5L,11L,17L,1L,7L,11L,13L,5L,1L,5L,7L,11L,7L,13L,5L,7L,11L,17L,7L,13L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242119Inst : IEnumerable<long>
{
public static readonly long[] Value=A242119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242119.Bytes);
public long this[int i]=>Value[i];

public static A242119Inst Instance=new A242119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242120
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,3L,9L,11L,17L,1L,3L,7L,13L,19L,1L,7L,11L,13L,19L,3L,9L,17L,1L,3L,7L,9L,13L,7L,11L,17L,19L,9L,11L,17L,3L,7L,13L,19L,1L,11L,13L,17L,19L,11L,3L,7L,9L,13L,19L,1L,11L,17L,3L,9L,11L,17L,1L,3L,13L,7L,11L,13L,17L,11L,17L,7L,9L,13L,19L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242120Inst : IEnumerable<long>
{
public static readonly long[] Value=A242120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242120.Bytes);
public long this[int i]=>Value[i];

public static A242120Inst Instance=new A242120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242121
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,2L,8L,10L,16L,20L,1L,5L,11L,17L,19L,4L,8L,10L,16L,20L,5L,13L,17L,19L,2L,4L,8L,1L,5L,11L,13L,2L,4L,10L,16L,20L,5L,11L,13L,2L,4L,8L,10L,1L,13L,17L,19L,2L,8L,10L,20L,5L,11L,17L,19L,4L,8L,10L,20L,13L,17L,19L,2L,16L,1L,11L,13L,17L,2L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242121Inst : IEnumerable<long>
{
public static readonly long[] Value=A242121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242121.Bytes);
public long this[int i]=>Value[i];

public static A242121Inst Instance=new A242121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242122
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,1L,7L,9L,15L,19L,21L,3L,9L,15L,17L,1L,5L,7L,13L,17L,1L,9L,13L,15L,19L,21L,3L,17L,21L,5L,7L,17L,19L,3L,9L,13L,19L,3L,5L,15L,17L,21L,1L,13L,3L,7L,9L,13L,19L,21L,9L,15L,21L,5L,7L,13L,17L,19L,7L,21L,3L,5L,9L,1L,7L,17L,19L,1L,7L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242122Inst : IEnumerable<long>
{
public static readonly long[] Value=A242122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242122.Bytes);
public long this[int i]=>Value[i];

public static A242122Inst Instance=new A242122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242123
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,4L,6L,12L,16L,18L,22L,3L,9L,11L,17L,21L,23L,4L,8L,14L,22L,1L,3L,7L,9L,13L,2L,6L,12L,14L,24L,1L,7L,13L,17L,23L,4L,6L,16L,18L,22L,24L,11L,23L,2L,4L,8L,14L,16L,1L,7L,13L,19L,21L,2L,6L,8L,18L,7L,11L,13L,17L,6L,12L,22L,24L,3L,9L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242123Inst : IEnumerable<long>
{
public static readonly long[] Value=A242123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242123.Bytes);
public long this[int i]=>Value[i];

public static A242123Inst Instance=new A242123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242124
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,3L,5L,11L,15L,17L,21L,1L,7L,9L,15L,19L,21L,1L,5L,11L,19L,23L,25L,3L,5L,9L,23L,1L,7L,9L,19L,21L,1L,7L,11L,17L,23L,25L,9L,11L,15L,17L,3L,15L,19L,21L,25L,5L,7L,17L,23L,3L,9L,11L,17L,21L,23L,7L,21L,25L,1L,5L,19L,25L,9L,11L,15L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242124Inst : IEnumerable<long>
{
public static readonly long[] Value=A242124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242124.Bytes);
public long this[int i]=>Value[i];

public static A242124Inst Instance=new A242124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242125
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,2L,4L,10L,14L,16L,20L,26L,5L,7L,13L,17L,19L,25L,2L,8L,16L,20L,22L,26L,1L,5L,19L,23L,2L,4L,14L,16L,22L,1L,5L,11L,17L,19L,2L,4L,8L,10L,22L,7L,11L,13L,17L,23L,25L,8L,14L,20L,26L,1L,7L,11L,13L,23L,10L,14L,16L,20L,7L,13L,23L,25L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242125Inst : IEnumerable<long>
{
public static readonly long[] Value=A242125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242125.Bytes);
public long this[int i]=>Value[i];

public static A242125Inst Instance=new A242125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242126
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,1L,3L,9L,13L,15L,19L,25L,3L,5L,11L,15L,17L,23L,27L,5L,13L,17L,19L,23L,25L,1L,15L,19L,25L,27L,9L,11L,17L,23L,27L,5L,11L,13L,23L,25L,1L,3L,15L,27L,3L,5L,9L,15L,17L,27L,5L,11L,17L,19L,25L,1L,3L,13L,27L,3L,5L,9L,23L,1L,11L,13L,17L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242126Inst : IEnumerable<long>
{
public static readonly long[] Value=A242126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242126.Bytes);
public long this[int i]=>Value[i];

public static A242126Inst Instance=new A242126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242127
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,0L,2L,8L,12L,14L,18L,24L,1L,3L,9L,13L,15L,21L,25L,2L,10L,14L,16L,20L,22L,26L,11L,15L,21L,23L,4L,6L,12L,18L,22L,28L,5L,7L,17L,19L,23L,25L,8L,20L,24L,26L,1L,7L,9L,19L,25L,2L,8L,10L,16L,20L,22L,3L,17L,21L,23L,27L,12L,18L,28L,1L,5L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242127Inst : IEnumerable<long>
{
public static readonly long[] Value=A242127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242127.Bytes);
public long this[int i]=>Value[i];

public static A242127Inst Instance=new A242127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242176
{
public static readonly long[] Value={ 1L,2L,91L,185L,387L,488L,747L,800L,9901L,10115L,12043L,13118L,30981L,51496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242176Inst : IEnumerable<long>
{
public static readonly long[] Value=A242176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242176.Bytes);
public long this[int i]=>Value[i];

public static A242176Inst Instance=new A242176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242177
{
public static readonly long[] Value={ 34L,1980L,9898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242177Inst : IEnumerable<long>
{
public static readonly long[] Value=A242177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242177.Bytes);
public long this[int i]=>Value[i];

public static A242177Inst Instance=new A242177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242178
{
public static readonly long[] Value={ 5L,17L,23L,1911L,20855L,35945L,42816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242178Inst : IEnumerable<long>
{
public static readonly long[] Value=A242178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242178.Bytes);
public long this[int i]=>Value[i];

public static A242178Inst Instance=new A242178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242179
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242179Inst : IEnumerable<long>
{
public static readonly long[] Value=A242179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242179.Bytes);
public long this[int i]=>Value[i];

public static A242179Inst Instance=new A242179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242180
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,5L,1L,1L,1L,1L,1L,1L,11L,1L,1L,19L,23L,1L,1L,1L,89L,13L,61L,71L,1L,1L,37L,1L,1L,17L,1L,7L,1L,1L,167L,1L,1L,491L,53L,1L,31L,1L,227L,1L,1L,1L,97L,1L,59L,241L,29L,1L,953L,1063L,1777L,1L,367L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242180Inst : IEnumerable<long>
{
public static readonly long[] Value=A242180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242180.Bytes);
public long this[int i]=>Value[i];

public static A242180Inst Instance=new A242180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242181
{
public static readonly long[] Value={ 39L,89L,139L,189L,239L,289L,339L,389L,439L,489L,539L,589L,639L,689L,739L,789L,839L,889L,939L,989L,1039L,1089L,1139L,1189L,1239L,1289L,1339L,1389L,1439L,1489L,1539L,1589L,1639L,1689L,1739L,1789L,1839L,1889L,1939L,1989L,2039L,2089L,2139L,2189L,2239L,2289L,2339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242181Inst : IEnumerable<long>
{
public static readonly long[] Value=A242181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242181.Bytes);
public long this[int i]=>Value[i];

public static A242181Inst Instance=new A242181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242182
{
public static readonly long[] Value={ 390L,391L,392L,393L,394L,395L,396L,397L,398L,399L,890L,891L,892L,893L,894L,895L,896L,897L,898L,899L,1390L,1391L,1392L,1393L,1394L,1395L,1396L,1397L,1398L,1399L,1890L,1891L,1892L,1893L,1894L,1895L,1896L,1897L,1898L,1899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242182Inst : IEnumerable<long>
{
public static readonly long[] Value=A242182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242182.Bytes);
public long this[int i]=>Value[i];

public static A242182Inst Instance=new A242182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242183
{
public static readonly long[] Value={ 6L,9L,15L,35L,36L,42L,48L,57L,63L,71L,72L,72L,75L,78L,90L,98L,100L,100L,120L,135L,141L,147L,147L,162L,195L,196L,204L,208L,215L,225L,225L,225L,243L,252L,260L,279L,280L,288L,289L,295L,300L,306L,336L,363L,364L,384L,405L,441L,450L,456L,456L,462L,504L,510L,525L,537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242183Inst : IEnumerable<long>
{
public static readonly long[] Value=A242183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242183.Bytes);
public long this[int i]=>Value[i];

public static A242183Inst Instance=new A242183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242184
{
public static readonly long[] Value={ 27L,28L,63L,433L,648L,1176L,1728L,1792L,2925L,3807L,4032L,4500L,4785L,4941L,6000L,6083L,6875L,7203L,7452L,7902L,8100L,10000L,10125L,12005L,13328L,14703L,15525L,19683L,20412L,21266L,26775L,27712L,32507L,33750L,35672L,40572L,40797L,41328L,41472L,45927L,49375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242184Inst : IEnumerable<long>
{
public static readonly long[] Value=A242184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242184.Bytes);
public long this[int i]=>Value[i];

public static A242184Inst Instance=new A242184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242185
{
public static readonly long[] Value={ 8L,18L,23L,36L,49L,108L,108L,126L,128L,135L,136L,143L,216L,225L,245L,288L,288L,300L,343L,368L,375L,400L,450L,500L,576L,588L,600L,648L,686L,693L,784L,900L,1026L,1098L,1125L,1156L,1183L,1215L,1350L,1350L,1440L,1458L,1568L,1628L,1638L,1681L,1728L,1728L,1863L,2000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242185Inst : IEnumerable<long>
{
public static readonly long[] Value=A242185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242185.Bytes);
public long this[int i]=>Value[i];

public static A242185Inst Instance=new A242185Inst();

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