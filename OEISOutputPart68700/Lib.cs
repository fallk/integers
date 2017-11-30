using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A136481
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,-2L,1L,1L,0L,3L,-1L,-1L,0L,2L,-4L,1L,1L,0L,0L,-5L,5L,-1L,-1L,0L,0L,-2L,9L,-6L,1L,1L,0L,0L,0L,7L,-14L,7L,-1L,-1L,0L,0L,0L,2L,-16L,20L,-8L,1L,1L,0L,0L,0L,0L,-9L,30L,-27L,9L,-1L,-1L,0L,0L,0L,0L,-2L,25L,-50L,35L,-10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136481Inst : IEnumerable<long>
{
public static readonly long[] Value=A136481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136481.Bytes);
public long this[int i]=>Value[i];

public static A136481Inst Instance=new A136481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136482
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,4L,4L,1L,1L,6L,8L,6L,1L,1L,7L,14L,14L,7L,1L,1L,9L,21L,30L,21L,9L,1L,1L,10L,30L,51L,51L,30L,10L,1L,1L,12L,40L,84L,102L,84L,40L,12L,1L,1L,13L,52L,124L,186L,186L,124L,52L,13L,1L,1L,15L,65L,180L,310L,378L,310L,180L,65L,15L,1L,1L,16L,80L,245L,490L,688L,688L,490L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136482Inst : IEnumerable<long>
{
public static readonly long[] Value=A136482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136482.Bytes);
public long this[int i]=>Value[i];

public static A136482Inst Instance=new A136482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136483
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,4L,6L,8L,13L,15L,19L,22L,28L,30L,37L,41L,48L,54L,64L,69L,77L,83L,94L,98L,110L,119L,131L,139L,152L,162L,172L,183L,199L,208L,226L,234L,253L,263L,281L,294L,308L,322L,343L,357L,377L,390L,412L,424L,447L,465L,488L,504L,528L,545L,567L,585L,612L,628L,654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136483Inst : IEnumerable<long>
{
public static readonly long[] Value=A136483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136483.Bytes);
public long this[int i]=>Value[i];

public static A136483Inst Instance=new A136483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136484
{
public static readonly long[] Value={ 0L,1L,3L,6L,13L,19L,28L,37L,48L,64L,77L,94L,110L,131L,152L,172L,199L,226L,253L,281L,308L,343L,377L,412L,447L,488L,528L,567L,612L,654L,703L,750L,796L,847L,902L,957L,1013L,1068L,1129L,1187L,1252L,1313L,1378L,1446L,1511L,1582L,1650L,1725L,1800L,1877L,1955L,2034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136484Inst : IEnumerable<long>
{
public static readonly long[] Value=A136484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136484.Bytes);
public long this[int i]=>Value[i];

public static A136484Inst Instance=new A136484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136485
{
public static readonly long[] Value={ 0L,0L,4L,4L,12L,16L,24L,32L,52L,60L,76L,88L,112L,120L,148L,164L,192L,216L,256L,276L,308L,332L,376L,392L,440L,476L,524L,556L,608L,648L,688L,732L,796L,832L,904L,936L,1012L,1052L,1124L,1176L,1232L,1288L,1372L,1428L,1508L,1560L,1648L,1696L,1788L,1860L,1952L,2016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136485Inst : IEnumerable<long>
{
public static readonly long[] Value=A136485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136485.Bytes);
public long this[int i]=>Value[i];

public static A136485Inst Instance=new A136485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136486
{
public static readonly long[] Value={ 0L,4L,12L,24L,52L,76L,112L,148L,192L,256L,308L,376L,440L,524L,608L,688L,796L,904L,1012L,1124L,1232L,1372L,1508L,1648L,1788L,1952L,2112L,2268L,2448L,2616L,2812L,3000L,3184L,3388L,3608L,3828L,4052L,4272L,4516L,4748L,5008L,5252L,5512L,5784L,6044L,6328L,6600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136486Inst : IEnumerable<long>
{
public static readonly long[] Value=A136486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136486.Bytes);
public long this[int i]=>Value[i];

public static A136486Inst Instance=new A136486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136487
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,-1L,-1L,-1L,0L,2L,0L,-1L,2L,0L,-4L,0L,2L,-3L,2L,7L,-4L,-5L,2L,1L,5L,-5L,-11L,11L,7L,-7L,-1L,1L,-8L,12L,16L,-28L,-8L,20L,0L,-4L,13L,-25L,-20L,60L,-2L,-46L,12L,12L,-3L,-1L,-21L,50L,19L,-120L,38L,92L,-50L,-24L,15L,2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136487Inst : IEnumerable<long>
{
public static readonly long[] Value=A136487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136487.Bytes);
public long this[int i]=>Value[i];

public static A136487Inst Instance=new A136487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136520
{
public static readonly long[] Value={ 1L,1L,3L,13L,44L,146L,530L,1975L,7314L,27262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136520Inst : IEnumerable<long>
{
public static readonly long[] Value=A136520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136520.Bytes);
public long this[int i]=>Value[i];

public static A136520Inst Instance=new A136520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136521
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136521Inst : IEnumerable<long>
{
public static readonly long[] Value=A136521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136521.Bytes);
public long this[int i]=>Value[i];

public static A136521Inst Instance=new A136521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136522
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136522Inst : IEnumerable<long>
{
public static readonly long[] Value=A136522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136522.Bytes);
public long this[int i]=>Value[i];

public static A136522Inst Instance=new A136522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136523
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,2L,-1L,-3L,2L,4L,1L,-3L,-8L,4L,8L,1L,5L,-8L,-20L,8L,16L,-1L,5L,18L,-20L,-48L,16L,32L,-1L,-7L,18L,56L,-48L,-112L,32L,64L,1L,-7L,-32L,56L,160L,-112L,-256L,64L,128L,1L,9L,-32L,-120L,160L,432L,-256L,-576L,128L,256L,-1L,9L,50L,-120L,-400L,432L,1120L,-576L,-1280L,256L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136523Inst : IEnumerable<long>
{
public static readonly long[] Value=A136523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136523.Bytes);
public long this[int i]=>Value[i];

public static A136523Inst Instance=new A136523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136524
{
public static readonly BigInteger[] Value={ 1L,2L,24L,968L,128000L,59973152L,107564800000L,774840978000000L,BigInteger.Parse("22880602349081985024"),BigInteger.Parse("2779532441951756299960832"),BigInteger.Parse("1383517973370847653192530395136"),BigInteger.Parse("2804745232514434754535719279455029248") };
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
public class A136524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136524Inst Instance=new A136524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136525
{
public static readonly BigInteger[] Value={ 1L,3L,35L,1296L,157437L,68809488L,117274907815L,816249936543744L,BigInteger.Parse("23585997104539765625"),BigInteger.Parse("2828012919296320973299968"),BigInteger.Parse("1396969787088550953695654296875"),BigInteger.Parse("2819773093146732354646026240000000000") };
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
public class A136525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136525Inst Instance=new A136525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136526
{
public static readonly long[] Value={ 1L,0L,1L,-6L,0L,6L,0L,-42L,0L,36L,36L,0L,-288L,0L,216L,0L,468L,0L,-1944L,0L,1296L,-216L,0L,4536L,0L,-12960L,0L,7776L,0L,-4104L,0L,38880L,0L,-85536L,0L,46656L,1296L,0L,-51840L,0L,311040L,0L,-559872L,0L,279936L,0L,32400L,0L,-544320L,0L,2379456L,0L,-3639168L,0L,1679616L,-7776L,0L,505440L,0L,-5132160L,0L,17635968L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136526Inst : IEnumerable<long>
{
public static readonly long[] Value=A136526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136526.Bytes);
public long this[int i]=>Value[i];

public static A136526Inst Instance=new A136526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136527
{
public static readonly long[] Value={ 4L,2L,6L,4L,2L,8L,1L,3L,1L,9L,2L,2L,2L,1L,10L,4L,6L,4L,3L,2L,12L,2L,2L,2L,1L,2L,2L,14L,1L,3L,1L,3L,5L,3L,1L,15L,4L,2L,8L,1L,2L,4L,2L,1L,16L,2L,6L,2L,9L,2L,6L,2L,3L,2L,18L,4L,2L,4L,1L,10L,4L,2L,5L,4L,2L,20L,1L,3L,1L,3L,1L,3L,7L,3L,1L,3L,1L,21L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,22L,4L,6L,8L,3L,2L,12L,2L,3L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136527Inst : IEnumerable<long>
{
public static readonly long[] Value=A136527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136527.Bytes);
public long this[int i]=>Value[i];

public static A136527Inst Instance=new A136527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136528
{
public static readonly long[] Value={ 2L,3L,4L,4L,4L,4L,6L,6L,6L,6L,6L,4L,5L,6L,8L,6L,8L,6L,8L,8L,8L,8L,9L,8L,6L,9L,8L,8L,9L,6L,10L,9L,9L,9L,10L,4L,8L,8L,12L,8L,10L,6L,10L,12L,10L,10L,12L,8L,12L,8L,8L,8L,12L,12L,12L,12L,12L,12L,12L,4L,7L,12L,12L,8L,12L,6L,12L,12L,12L,12L,12L,4L,6L,12L,10L,12L,12L,10L,16L,12L,12L,12L,12L,12L,8L,12L,12L,12L,16L,8L,12L,12L,12L,12L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136528Inst : IEnumerable<long>
{
public static readonly long[] Value=A136528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136528.Bytes);
public long this[int i]=>Value[i];

public static A136528Inst Instance=new A136528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136529
{
public static readonly long[] Value={ 2L,3L,2L,4L,2L,4L,2L,3L,2L,6L,2L,4L,2L,3L,2L,6L,2L,6L,2L,3L,2L,8L,2L,4L,2L,3L,2L,8L,2L,6L,2L,3L,2L,4L,2L,4L,2L,3L,2L,8L,2L,6L,2L,3L,2L,10L,2L,4L,2L,3L,2L,8L,2L,4L,2L,3L,2L,12L,2L,4L,2L,3L,2L,4L,2L,6L,2L,3L,2L,12L,2L,4L,2L,3L,2L,4L,2L,10L,2L,3L,2L,12L,2L,4L,2L,3L,2L,12L,2L,4L,2L,3L,2L,4L,2L,6L,2L,3L,2L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136529Inst : IEnumerable<long>
{
public static readonly long[] Value=A136529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136529.Bytes);
public long this[int i]=>Value[i];

public static A136529Inst Instance=new A136529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136530
{
public static readonly long[] Value={ 1L,6L,23L,74L,216L,592L,1552L,3936L,9728L,23552L,56064L,131584L,305152L,700416L,1593344L,3596288L,8060928L,17956864L,39780352L,87687168L,192413696L,420478976L,915406848L,1986002944L,4294967296L,9261023232L,19914555392L,42714791936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136530Inst : IEnumerable<long>
{
public static readonly long[] Value=A136530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136530.Bytes);
public long this[int i]=>Value[i];

public static A136530Inst Instance=new A136530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136531
{
public static readonly long[] Value={ 1L,0L,1L,1L,-1L,1L,-1L,3L,-2L,1L,2L,-5L,6L,-3L,1L,-3L,10L,-13L,10L,-4L,1L,5L,-18L,29L,-26L,15L,-5L,1L,-8L,33L,-60L,65L,-45L,21L,-6L,1L,13L,-59L,122L,-151L,125L,-71L,28L,-7L,1L,-21L,105L,-241L,338L,-321L,217L,-105L,36L,-8L,1L,34L,-185L,468L,-730L,784L,-609L,350L,-148L,45L,-9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136531Inst : IEnumerable<long>
{
public static readonly long[] Value=A136531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136531.Bytes);
public long this[int i]=>Value[i];

public static A136531Inst Instance=new A136531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136532
{
public static readonly long[] Value={ 1L,0L,-3L,-8L,-16L,4L,-60L,-65L,50L,-5L,-384L,-168L,462L,-108L,6L,-2380L,763L,3836L,-1624L,196L,-7L,-14208L,21248L,29560L,-21472L,4256L,-320L,8L,-73836L,302571L,199998L,-269127L,78840L,-9387L,486L,-9L,-176000L,3761240L,854530L,-3288940L,1360150L,-228880L,18430L,-700L,10L,3824964L,44711623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136532Inst : IEnumerable<long>
{
public static readonly long[] Value=A136532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136532.Bytes);
public long this[int i]=>Value[i];

public static A136532Inst Instance=new A136532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136533
{
public static readonly long[] Value={ 1L,3L,-3L,12L,-24L,4L,60L,-180L,65L,-5L,360L,-1440L,822L,-132L,6L,2520L,-12600L,9954L,-2478L,231L,-7L,20160L,-120960L,122832L,-41856L,5976L,-368L,8L,181440L,-1270080L,1581768L,-688392L,133380L,-12492L,549L,-9L,1814400L,-14515200L,21462480L,-11412000L,2806200L,-354720L,23610L,-780L,10L,19958400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136533Inst : IEnumerable<long>
{
public static readonly long[] Value=A136533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136533.Bytes);
public long this[int i]=>Value[i];

public static A136533Inst Instance=new A136533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136534
{
public static readonly long[] Value={ 1L,2L,2L,4L,8L,3L,7L,24L,21L,4L,11L,60L,90L,44L,5L,16L,130L,300L,260L,80L,6L,22L,2252L,840L,1120L,630L,132L,7L,29L,448L,2058L,3920L,3430L,1344L,203L,8L,37L,744L,4536L,11760L,14700L,9072L,2604L,296L,9L,46L,1170L,9180L,31248L,52920L,46872L,21420L,4680L,414L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136534Inst : IEnumerable<long>
{
public static readonly long[] Value=A136534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136534.Bytes);
public long this[int i]=>Value[i];

public static A136534Inst Instance=new A136534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136535
{
public static readonly long[] Value={ 1L,1L,2L,1L,7L,3L,1L,15L,21L,4L,1L,26L,76L,46L,5L,1L,40L,20L,250L,85L,6L,1L,57L,435L,925L,645L,141L,7L,1L,77L,833L,2695L,3185L,1421L,217L,8L,1L,100L,1456L,6664L,11956L,9016L,2800L,316L,9L,1L,126L,2376L,14616L,37044L,42336L,22176L,5076L,441L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136535Inst : IEnumerable<long>
{
public static readonly long[] Value=A136535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136535.Bytes);
public long this[int i]=>Value[i];

public static A136535Inst Instance=new A136535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136760
{
public static readonly long[] Value={ 1L,1L,2L,6L,2L,1L,8L,6L,6L,6L,6L,8L,1L,1L,2L,4L,8L,1L,3L,7L,1L,4L,1L,2L,7L,2L,6L,2L,7L,2L,8L,3L,1L,4L,1L,7L,3L,1L,6L,3L,1L,7L,3L,1L,1L,5L,3L,1L,1L,5L,3L,2L,1L,8L,5L,3L,2L,1L,1L,8L,6L,4L,3L,2L,2L,1L,1L,1L,1L,7L,6L,6L,5L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,5L,5L,6L,7L,8L,1L,1L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136760Inst : IEnumerable<long>
{
public static readonly long[] Value=A136760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136760.Bytes);
public long this[int i]=>Value[i];

public static A136760Inst Instance=new A136760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136761
{
public static readonly long[] Value={ 1L,1L,2L,6L,2L,10L,5L,3L,2L,2L,2L,2L,2L,2L,3L,4L,6L,10L,1L,2L,4L,9L,1L,3L,7L,1L,3L,9L,2L,5L,1L,3L,1L,3L,9L,2L,9L,2L,9L,3L,1L,3L,1L,5L,1L,7L,2L,1L,4L,1L,9L,3L,1L,7L,3L,1L,8L,3L,1L,9L,4L,2L,1L,7L,3L,2L,1L,6L,3L,2L,1L,8L,4L,2L,1L,1L,7L,4L,3L,2L,1L,10L,6L,4L,3L,2L,1L,1L,9L,6L,5L,3L,2L,2L,1L,1L,1L,9L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136761Inst : IEnumerable<long>
{
public static readonly long[] Value=A136761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136761.Bytes);
public long this[int i]=>Value[i];

public static A136761Inst Instance=new A136761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136762
{
public static readonly long[] Value={ 1L,1L,2L,6L,2L,10L,5L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,7L,1L,1L,3L,6L,1L,2L,5L,11L,2L,5L,1L,2L,7L,1L,4L,1L,3L,11L,2L,9L,2L,9L,2L,9L,2L,10L,3L,1L,4L,1L,6L,2L,9L,3L,1L,6L,2L,11L,4L,1L,9L,4L,1L,9L,4L,1L,10L,4L,2L,1L,6L,3L,1L,9L,4L,2L,1L,8L,4L,2L,1L,9L,5L,3L,1L,1L,7L,4L,2L,1L,1L,8L,5L,3L,2L,1L,11L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136762Inst : IEnumerable<long>
{
public static readonly long[] Value=A136762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136762.Bytes);
public long this[int i]=>Value[i];

public static A136762Inst Instance=new A136762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136763
{
public static readonly long[] Value={ 1L,1L,2L,6L,1L,9L,4L,2L,1L,12L,9L,8L,7L,7L,8L,9L,11L,1L,1L,2L,3L,5L,9L,1L,2L,4L,9L,1L,3L,7L,1L,3L,7L,1L,3L,10L,2L,6L,1L,4L,1L,3L,10L,2L,9L,2L,8L,2L,8L,2L,9L,2L,11L,3L,1L,4L,1L,7L,2L,11L,4L,1L,6L,2L,12L,4L,1L,9L,3L,1L,8L,3L,1L,8L,3L,1L,9L,4L,2L,12L,5L,2L,1L,8L,4L,2L,1L,7L,3L,2L,1L,7L,4L,2L,1L,9L,5L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136763Inst : IEnumerable<long>
{
public static readonly long[] Value=A136763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136763.Bytes);
public long this[int i]=>Value[i];

public static A136763Inst Instance=new A136763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136764
{
public static readonly long[] Value={ 1L,1L,2L,6L,1L,8L,3L,1L,1L,9L,6L,5L,4L,4L,4L,4L,5L,6L,8L,10L,1L,1L,2L,4L,7L,13L,1L,3L,6L,1L,2L,4L,10L,1L,4L,11L,2L,5L,1L,2L,8L,1L,5L,1L,3L,11L,2L,9L,2L,7L,1L,7L,1L,7L,2L,7L,2L,9L,2L,11L,3L,1L,4L,1L,7L,2L,11L,3L,1L,6L,2L,11L,4L,1L,8L,3L,1L,6L,2L,1L,6L,2L,1L,6L,2L,1L,7L,3L,1L,9L,4L,2L,13L,6L,3L,1L,9L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136764Inst : IEnumerable<long>
{
public static readonly long[] Value=A136764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136764.Bytes);
public long this[int i]=>Value[i];

public static A136764Inst Instance=new A136764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136765
{
public static readonly long[] Value={ 1L,1L,2L,6L,1L,8L,3L,1L,11L,7L,4L,3L,2L,2L,2L,2L,2L,2L,3L,4L,5L,7L,11L,1L,1L,3L,5L,9L,1L,2L,4L,9L,1L,3L,6L,1L,2L,6L,1L,2L,7L,1L,3L,10L,2L,6L,1L,4L,12L,2L,9L,2L,7L,1L,6L,1L,5L,1L,5L,1L,5L,1L,6L,1L,7L,2L,10L,2L,13L,4L,1L,6L,1L,9L,3L,1L,5L,1L,9L,3L,1L,6L,2L,12L,4L,1L,10L,3L,1L,9L,3L,1L,9L,3L,1L,10L,4L,1L,12L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136765Inst : IEnumerable<long>
{
public static readonly long[] Value=A136765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136765.Bytes);
public long this[int i]=>Value[i];

public static A136765Inst Instance=new A136765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136766
{
public static readonly long[] Value={ 1L,1L,2L,6L,1L,7L,2L,1L,9L,5L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,5L,8L,12L,1L,2L,3L,6L,13L,1L,3L,6L,13L,1L,4L,9L,1L,3L,8L,1L,3L,10L,1L,4L,14L,2L,7L,1L,4L,14L,2L,9L,2L,7L,1L,5L,1L,4L,1L,4L,1L,3L,15L,4L,1L,4L,1L,5L,1L,6L,1L,7L,2L,10L,3L,15L,4L,1L,7L,2L,11L,3L,1L,6L,2L,11L,4L,1L,7L,2L,1L,5L,2L,12L,4L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136766Inst : IEnumerable<long>
{
public static readonly long[] Value=A136766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136766.Bytes);
public long this[int i]=>Value[i];

public static A136766Inst Instance=new A136766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136767
{
public static readonly long[] Value={ 6L,10L,14L,18L,22L,29L,30L,34L,38L,45L,46L,53L,57L,61L,62L,66L,70L,77L,78L,85L,89L,93L,94L,101L,105L,109L,113L,117L,124L,125L,126L,130L,134L,141L,142L,149L,153L,157L,158L,165L,169L,173L,177L,181L,188L,189L,190L,197L,201L,205L,209L,213L,220L,221L,225L,229L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136767Inst : IEnumerable<long>
{
public static readonly long[] Value=A136767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136767.Bytes);
public long this[int i]=>Value[i];

public static A136767Inst Instance=new A136767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136768
{
public static readonly long[] Value={ 7L,15L,23L,31L,39L,47L,55L,56L,64L,72L,80L,88L,96L,104L,112L,113L,121L,129L,137L,145L,153L,161L,169L,170L,178L,186L,194L,202L,210L,218L,226L,227L,235L,243L,251L,259L,267L,275L,283L,284L,292L,300L,308L,316L,324L,332L,340L,341L,349L,357L,365L,373L,381L,389L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136768Inst : IEnumerable<long>
{
public static readonly long[] Value=A136768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136768.Bytes);
public long this[int i]=>Value[i];

public static A136768Inst Instance=new A136768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136769
{
public static readonly long[] Value={ 4L,9L,20L,25L,30L,41L,62L,83L,84L,89L,94L,105L,110L,115L,126L,147L,168L,169L,190L,211L,222L,227L,232L,243L,248L,253L,254L,275L,296L,307L,312L,317L,328L,333L,338L,339L,340L,345L,350L,361L,366L,371L,382L,403L,424L,425L,430L,435L,446L,451L,456L,467L,488L,509L,510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136769Inst : IEnumerable<long>
{
public static readonly long[] Value=A136769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136769.Bytes);
public long this[int i]=>Value[i];

public static A136769Inst Instance=new A136769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136770
{
public static readonly long[] Value={ 12L,19L,32L,39L,52L,59L,66L,79L,86L,99L,106L,119L,120L,133L,140L,153L,160L,173L,180L,181L,194L,201L,214L,221L,234L,241L,248L,261L,268L,281L,288L,301L,302L,315L,322L,335L,342L,355L,362L,363L,376L,383L,396L,403L,416L,423L,430L,443L,450L,463L,470L,483L,484L,497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136770Inst : IEnumerable<long>
{
public static readonly long[] Value=A136770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136770.Bytes);
public long this[int i]=>Value[i];

public static A136770Inst Instance=new A136770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136771
{
public static readonly long[] Value={ 11L,23L,35L,47L,59L,71L,83L,95L,107L,119L,131L,132L,144L,156L,168L,180L,192L,204L,216L,228L,240L,252L,264L,265L,277L,289L,301L,313L,325L,337L,349L,361L,373L,385L,397L,398L,410L,422L,434L,446L,458L,470L,482L,494L,506L,518L,530L,531L,543L,555L,567L,579L,591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136771Inst : IEnumerable<long>
{
public static readonly long[] Value=A136771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136771.Bytes);
public long this[int i]=>Value[i];

public static A136771Inst Instance=new A136771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136772
{
public static readonly long[] Value={ 7L,16L,24L,29L,33L,37L,38L,45L,51L,53L,57L,64L,69L,73L,77L,78L,87L,93L,96L,104L,105L,109L,113L,117L,124L,125L,128L,132L,141L,145L,150L,158L,159L,165L,173L,177L,181L,185L,188L,190L,194L,198L,199L,201L,212L,213L,221L,225L,230L,234L,238L,239L,244L,248L,253L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136772Inst : IEnumerable<long>
{
public static readonly long[] Value=A136772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136772.Bytes);
public long this[int i]=>Value[i];

public static A136772Inst Instance=new A136772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136773
{
public static readonly long[] Value={ 13L,27L,41L,55L,69L,83L,97L,111L,125L,139L,153L,167L,181L,182L,196L,210L,224L,238L,252L,266L,280L,294L,308L,322L,336L,350L,364L,365L,379L,393L,407L,421L,435L,449L,463L,477L,491L,505L,519L,533L,547L,548L,562L,576L,590L,604L,618L,632L,646L,660L,674L,688L,702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136773Inst : IEnumerable<long>
{
public static readonly long[] Value=A136773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136773.Bytes);
public long this[int i]=>Value[i];

public static A136773Inst Instance=new A136773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136774
{
public static readonly long[] Value={ 62L,94L,110L,118L,126L,158L,174L,182L,190L,206L,214L,222L,230L,238L,254L,286L,302L,310L,318L,334L,342L,350L,358L,366L,382L,398L,406L,414L,422L,430L,446L,454L,462L,478L,510L,542L,558L,566L,574L,590L,598L,606L,614L,622L,638L,654L,662L,670L,678L,686L,702L,710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136774Inst : IEnumerable<long>
{
public static readonly long[] Value=A136774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136774.Bytes);
public long this[int i]=>Value[i];

public static A136774Inst Instance=new A136774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136775
{
public static readonly long[] Value={ 1L,3L,11L,40L,145L,525L,1900L,6875L,24875L,90000L,325625L,1178125L,4262500L,15421875L,55796875L,201875000L,730390625L,2642578125L,9560937500L,34591796875L,125154296875L,452812500000L,1638291015625L,5927392578125L,21445507812500L,77590576171875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136775Inst : IEnumerable<long>
{
public static readonly long[] Value=A136775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136775.Bytes);
public long this[int i]=>Value[i];

public static A136775Inst Instance=new A136775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136968
{
public static readonly long[] Value={ 1L,2L,5L,11L,12L,15L,21L,35L,111L,112L,115L,211L,235L,335L,1111L,1115L,1235L,1521L,2132L,2312L,2335L,3335L,3512L,3515L,11111L,11115L,12335L,12415L,23335L,33335L,33515L,35415L,123335L,123512L,124235L,145415L,152132L,231115L,233335L,235211L,333335L,333515L,1114115L,1155211L,1233335L,1531115L,1534312L,2311115L,2311132L,2333335L,2354235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136968Inst : IEnumerable<long>
{
public static readonly long[] Value=A136968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136968.Bytes);
public long this[int i]=>Value[i];

public static A136968Inst Instance=new A136968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136969
{
public static readonly long[] Value={ 1L,2L,4L,6L,11L,12L,21L,46L,111L,121L,146L,162L,462L,642L,1111L,1146L,1632L,3621L,3642L,4611L,4631L,6642L,11142L,11146L,33632L,34121L,36361L,36642L,46111L,211262L,211332L,334162L,362162L,364231L,461642L,641344L,642131L,643142L,664162L,1111132L,1123131L,1123444L,1124332L,1623642L,1623646L,3334162L,3336332L,3363646L,3621344L,3636361L,4622361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136969Inst : IEnumerable<long>
{
public static readonly long[] Value=A136969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136969.Bytes);
public long this[int i]=>Value[i];

public static A136969Inst Instance=new A136969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136970
{
public static readonly long[] Value={ 1L,2L,11L,12L,21L,111L,132L,271L,421L,1111L,1171L,1312L,1332L,2171L,13332L,34311L,34312L,133332L,371111L,417412L,421111L,473421L,1214171L,1333332L,3337271L,3427421L,12137271L,13333332L,121337271L,131423412L,133333332L,177232171L,217433311L,333432412L,334232171L,337227421L,377774171L,473743311L,1114142412L,1114142421L,1114144171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136970Inst : IEnumerable<long>
{
public static readonly long[] Value=A136970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136970.Bytes);
public long this[int i]=>Value[i];

public static A136970Inst Instance=new A136970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136971
{
public static readonly long[] Value={ 1L,2L,11L,12L,18L,21L,22L,38L,111L,122L,182L,221L,338L,428L,482L,488L,1111L,1132L,1188L,1488L,1812L,3338L,3482L,4338L,4341L,4818L,4832L,11128L,11141L,11332L,28482L,28832L,33338L,42818L,113332L,118841L,181222L,182818L,333338L,334488L,338841L,348188L,482818L,1111222L,1133332L,1812232L,1823221L,2888128L,3333338L,3343832L,3344132L,3388428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136971Inst : IEnumerable<long>
{
public static readonly long[] Value=A136971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136971.Bytes);
public long this[int i]=>Value[i];

public static A136971Inst Instance=new A136971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136972
{
public static readonly long[] Value={ 1L,2L,3L,11L,12L,21L,111L,139L,212L,339L,1111L,1193L,4943L,11132L,12212L,14139L,14943L,21193L,43923L,49229L,119132L,122193L,141111L,149139L,221911L,439229L,492239L,499423L,1192193L,1221193L,1393239L,2222911L,2234143L,3491911L,4911123L,4913443L,4929423L,4944132L,11132921L,11929423L,12214423L,14122143L,14912911L,14914132L,21194132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136972Inst : IEnumerable<long>
{
public static readonly long[] Value=A136972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136972.Bytes);
public long this[int i]=>Value[i];

public static A136972Inst Instance=new A136972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136973
{
public static readonly long[] Value={ 1L,5L,11L,15L,35L,111L,115L,235L,335L,1235L,3335L,3515L,12335L,33335L,33515L,123335L,333335L,333515L,1233335L,3333335L,3333515L,12333335L,33333335L,33333515L,123333335L,333333335L,333333515L,1233333335L,3333333335L,3333333515L,12333333335L,33333333335L,33333333515L,123333333335L,333333333335L,333333333515L,1233333333335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136973Inst : IEnumerable<long>
{
public static readonly long[] Value=A136973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136973.Bytes);
public long this[int i]=>Value[i];

public static A136973Inst Instance=new A136973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136974
{
public static readonly long[] Value={ 1L,5L,6L,11L,15L,16L,25L,35L,56L,111L,115L,125L,231L,235L,256L,335L,365L,511L,515L,516L,1125L,1156L,1231L,1235L,1525L,1535L,2261L,2515L,2556L,3335L,3365L,3515L,3516L,3635L,3656L,5111L,5115L,5125L,11231L,11235L,12335L,12511L,12515L,15216L,15335L,22631L,23166L,23566L,25125L,25525L,33335L,33365L,33515L,33516L,33635L,33665L,35515L,36211L,36215L,36361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136974Inst : IEnumerable<long>
{
public static readonly long[] Value=A136974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136974.Bytes);
public long this[int i]=>Value[i];

public static A136974Inst Instance=new A136974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136975
{
public static readonly long[] Value={ 1L,5L,11L,15L,35L,111L,115L,235L,335L,715L,1235L,2715L,3335L,3511L,3515L,3711L,12335L,27115L,33335L,33515L,35711L,37115L,72335L,75711L,111235L,123335L,132335L,177515L,333335L,333515L,357115L,572115L,575515L,577515L,723335L,757115L,1233335L,1312335L,1323335L,3333335L,3333515L,3512511L,5227115L,5772115L,7233335L,11212115L,11277115L,11735515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136975Inst : IEnumerable<long>
{
public static readonly long[] Value=A136975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136975.Bytes);
public long this[int i]=>Value[i];

public static A136975Inst Instance=new A136975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136976
{
public static readonly long[] Value={ 1L,5L,11L,15L,35L,111L,115L,135L,235L,285L,335L,1135L,1235L,1511L,1585L,1885L,2285L,2885L,3335L,3515L,3585L,12335L,12385L,12585L,15885L,18115L,18235L,23135L,33335L,33515L,53135L,55885L,111885L,123335L,123385L,152385L,152585L,153585L,181335L,231335L,285111L,285515L,333335L,333515L,358235L,582135L,1132335L,1233335L,1233385L,1258115L,1258235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136976Inst : IEnumerable<long>
{
public static readonly long[] Value=A136976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136976.Bytes);
public long this[int i]=>Value[i];

public static A136976Inst Instance=new A136976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136977
{
public static readonly long[] Value={ 1L,3L,5L,11L,15L,23L,35L,39L,111L,115L,123L,139L,235L,315L,335L,1235L,1239L,1515L,1523L,2315L,3335L,3515L,3911L,11515L,12335L,13911L,15911L,23515L,23523L,31515L,33335L,33515L,95511L,95515L,123335L,123515L,123911L,151523L,159139L,231515L,333335L,333515L,353911L,593239L,1122139L,1151239L,1233335L,1233515L,1523523L,1591515L,1592235L,1593523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136977Inst : IEnumerable<long>
{
public static readonly long[] Value=A136977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136977.Bytes);
public long this[int i]=>Value[i];

public static A136977Inst Instance=new A136977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136978
{
public static readonly long[] Value={ 1L,6L,11L,111L,36361L,3636361L,33336363361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136978Inst : IEnumerable<long>
{
public static readonly long[] Value=A136978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136978.Bytes);
public long this[int i]=>Value[i];

public static A136978Inst Instance=new A136978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136979
{
public static readonly long[] Value={ 1L,6L,11L,26L,61L,111L,131L,276L,611L,2761L,11731L,12776L,27611L,36361L,36376L,37111L,116731L,116761L,161761L,163131L,611361L,613361L,1166731L,1166761L,1171376L,1273276L,1277761L,1327261L,1616376L,1636361L,1662261L,3336731L,3371376L,3636361L,6113376L,11237111L,11237131L,11666731L,11666761L,12771731L,12777761L,13272631L,16632111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136979Inst : IEnumerable<long>
{
public static readonly long[] Value=A136979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136979.Bytes);
public long this[int i]=>Value[i];

public static A136979Inst Instance=new A136979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136980
{
public static readonly long[] Value={ 1L,6L,11L,111L,261L,8131L,36361L,116881L,162261L,163361L,183881L,362131L,1166881L,1366881L,1616361L,1683111L,2612131L,3366361L,3636361L,6218381L,11666881L,16316361L,28863881L,28868361L,36223361L,112322131L,116666881L,116883131L,162383131L,168131861L,168282111L,261282631L,333636361L,362881361L,618233881L,816163361L,826633131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136980Inst : IEnumerable<long>
{
public static readonly long[] Value=A136980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136980.Bytes);
public long this[int i]=>Value[i];

public static A136980Inst Instance=new A136980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136981
{
public static readonly long[] Value={ 1L,3L,6L,11L,13L,19L,31L,36L,63L,96L,111L,139L,263L,369L,1123L,1619L,2631L,3161L,3361L,3623L,6296L,9963L,11119L,12911L,16313L,16339L,19213L,19219L,31131L,33611L,36361L,36963L,62619L,96123L,99631L,126969L,139261L,162296L,162369L,199231L,262911L,263236L,316119L,333611L,333661L,336339L,362369L,363639L,369219L,369611L,369623L,963969L,969119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136981Inst : IEnumerable<long>
{
public static readonly long[] Value=A136981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136981.Bytes);
public long this[int i]=>Value[i];

public static A136981Inst Instance=new A136981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136982
{
public static readonly long[] Value={ 1L,11L,111L,1311L,13311L,17811L,133311L,288311L,883811L,1333311L,1823111L,3373111L,13333311L,87828311L,88781311L,133333311L,178387811L,878133311L,888137811L,1333333311L,1372178311L,3337231311L,8881287811L,13183783111L,13333333311L,17712178811L,27781781311L,117183137811L,133333333311L,137373112811L,181138378811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136982Inst : IEnumerable<long>
{
public static readonly long[] Value=A136982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136982.Bytes);
public long this[int i]=>Value[i];

public static A136982Inst Instance=new A136982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136983
{
public static readonly long[] Value={ 1L,3L,11L,27L,111L,139L,173L,177L,373L,1139L,1339L,1927L,2777L,3373L,11123L,13123L,17123L,17923L,17927L,19777L,27927L,117123L,133123L,173139L,193373L,199277L,279177L,312911L,373139L,1127927L,1131339L,1312239L,1392739L,1712373L,1771777L,1771923L,1792739L,1799277L,1933177L,1977911L,1977923L,1993223L,1997927L,2792739L,3731927L,11122939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136983Inst : IEnumerable<long>
{
public static readonly long[] Value=A136983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136983.Bytes);
public long this[int i]=>Value[i];

public static A136983Inst Instance=new A136983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137144
{
public static readonly long[] Value={ 8L,88L,8874L,68474L,86478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137144Inst : IEnumerable<long>
{
public static readonly long[] Value=A137144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137144.Bytes);
public long this[int i]=>Value[i];

public static A137144Inst Instance=new A137144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137145
{
public static readonly long[] Value={ 7L,8L,67L,88L,667L,864L,886L,887L,974L,6667L,8874L,8887L,66667L,68474L,86478L,87664L,94788L,94867L,98978L,666667L,947886L,947887L,948678L,984878L,988878L,988887L,6666667L,6846886L,6974788L,6974867L,6977664L,9469788L,9478764L,9897978L,9984878L,66666667L,69776786L,69977687L,69997764L,88694864L,88796676L,88868878L,98476788L,98877687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137145Inst : IEnumerable<long>
{
public static readonly long[] Value=A137145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137145.Bytes);
public long this[int i]=>Value[i];

public static A137145Inst Instance=new A137145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137146
{
public static readonly long[] Value={ 76L,766L,7666L,76666L,766666L,7666666L,76666666L,766666666L,7666666666L,76666666666L,766666666666L,7666666666666L,76666666666666L,766666666666666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137146Inst : IEnumerable<long>
{
public static readonly long[] Value=A137146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137146.Bytes);
public long this[int i]=>Value[i];

public static A137146Inst Instance=new A137146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137147
{
public static readonly long[] Value={ 76L,87L,766L,887L,7666L,8887L,9786L,76587L,76666L,87576L,759576L,766666L,869866L,869867L,886886L,888587L,988866L,7666666L,8766867L,8885887L,76587576L,76666666L,76789686L,86998666L,87565786L,87685676L,88766867L,97759786L,97957576L,766666666L,875765766L,886885887L,887579686L,977699687L,987759576L,987859786L,998977867L,999788866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137147Inst : IEnumerable<long>
{
public static readonly long[] Value=A137147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137147.Bytes);
public long this[int i]=>Value[i];

public static A137147Inst Instance=new A137147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137148
{
public static readonly long[] Value={ 1L,8L,12L,32L,54L,40L,48L,84L,120L,128L,108L,160L,252L,220L,192L,500L,312L,486L,336L,240L,512L,660L,544L,840L,432L,684L,936L,640L,504L,880L,1080L,1012L,768L,2058L,1000L,1632L,1248L,972L,2200L,1344L,2052L,1624L,960L,1860L,2268L,2048L,3120L,1320L,2176L,3036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137148Inst : IEnumerable<long>
{
public static readonly long[] Value=A137148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137148.Bytes);
public long this[int i]=>Value[i];

public static A137148Inst Instance=new A137148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137149
{
public static readonly BigInteger[] Value={ 1L,1L,6L,120L,362880L,39916800L,1307674368000L,355687428096000L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("10888869450418352160768000000"),BigInteger.Parse("8841761993739701954543616000000") };
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
public class A137149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137149Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A137149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137149.Bytes);
public BigInteger this[int i]=>Value[i];

public static A137149Inst Instance=new A137149Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137150
{
public static readonly BigInteger[] Value={ 1L,3L,60L,1260L,6720L,90720L,9979200L,1037836800L,10897286400L,163459296000L,59281238016000L,15205637551104000L,202741834014720000L,5109094217170944000L,BigInteger.Parse("3231502092360622080000"),BigInteger.Parse("31022420086661971968000") };
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
public class A137150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137150Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A137150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137150.Bytes);
public BigInteger this[int i]=>Value[i];

public static A137150Inst Instance=new A137150Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137151
{
public static readonly long[] Value={ 1L,2L,1L,5L,2L,1L,13L,4L,3L,1L,34L,9L,6L,4L,1L,88L,22L,11L,10L,5L,1L,225L,55L,22L,20L,15L,6L,1L,569L,137L,50L,36L,35L,21L,7L,1L,1425L,338L,122L,65L,70L,56L,28L,8L,1L,3538L,826L,302L,130L,127L,126L,84L,36L,9L,1L,8717L,2002L,740L,296L,221L,252L,210L,120L,45L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137151Inst : IEnumerable<long>
{
public static readonly long[] Value=A137151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137151.Bytes);
public long this[int i]=>Value[i];

public static A137151Inst Instance=new A137151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137152
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,1L,3L,4L,1L,1L,3L,4L,5L,1L,1L,3L,4L,5L,7L,1L,1L,3L,1L,5L,7L,8L,1L,1L,1L,1L,5L,7L,8L,9L,1L,1L,1L,1L,5L,7L,8L,9L,11L,1L,1L,1L,1L,5L,7L,8L,9L,11L,13L,1L,1L,1L,1L,5L,7L,1L,9L,11L,13L,16L,1L,1L,1L,1L,5L,7L,1L,9L,11L,13L,16L,17L,1L,1L,1L,1L,5L,7L,1L,9L,11L,13L,16L,17L,19L,1L,1L,1L,1L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137152Inst : IEnumerable<long>
{
public static readonly long[] Value=A137152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137152.Bytes);
public long this[int i]=>Value[i];

public static A137152Inst Instance=new A137152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137153
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,1L,1L,4L,10L,8L,1L,1L,5L,20L,36L,16L,1L,1L,6L,35L,120L,136L,32L,1L,1L,7L,56L,330L,816L,528L,64L,1L,1L,8L,84L,792L,3876L,5984L,2080L,128L,1L,1L,9L,120L,1716L,15504L,52360L,45760L,8256L,256L,1L,1L,10L,165L,3432L,54264L,376992L,766480L,357760L,32896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137153Inst : IEnumerable<long>
{
public static readonly long[] Value=A137153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137153.Bytes);
public long this[int i]=>Value[i];

public static A137153Inst Instance=new A137153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137154
{
public static readonly BigInteger[] Value={ 1L,2L,4L,9L,24L,79L,331L,1803L,12954L,123983L,1592513L,27604172L,648528166L,20722205191L,903019659239L,53792176322629L,4388683843024734L,491232972054490915L,BigInteger.Parse("75545748143323475653"),BigInteger.Parse("15984344095578889888206") };
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
public class A137154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A137154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A137154Inst Instance=new A137154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137155
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,17L,35L,80L,201L,561L,1771L,6298L,25217L,115440L,605243L,3609754L,24742305L,196470603L,1792166979L,18817616610L,230233601737L,3268914688382L,53509699527491L,1020486454701731L,22777217813040393L,589097686208575727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137155Inst : IEnumerable<long>
{
public static readonly long[] Value=A137155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137155.Bytes);
public long this[int i]=>Value[i];

public static A137155Inst Instance=new A137155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137156
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-2L,1L,-2L,5L,-4L,1L,9L,-24L,22L,-8L,1L,-88L,239L,-228L,92L,-16L,1L,1802L,-4920L,4749L,-1976L,376L,-32L,1L,-75598L,206727L,-200240L,84086L,-16432L,1520L,-64L,1L,6421599L,-17568408L,17034964L,-7173240L,1413084L,-133984L,6112L,-128L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137156Inst : IEnumerable<long>
{
public static readonly long[] Value=A137156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137156.Bytes);
public long this[int i]=>Value[i];

public static A137156Inst Instance=new A137156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137157
{
public static readonly BigInteger[] Value={ 1L,2L,5L,24L,239L,4920L,206727L,17568408L,3003763243L,1030272816360L,707851744149198L,973425618916674288L,BigInteger.Parse("2678332881795756783639"),BigInteger.Parse("14741522294008025924154864"),BigInteger.Parse("162290544340043699103996962253") };
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
public class A137157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A137157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A137157Inst Instance=new A137157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137158
{
public static readonly BigInteger[] Value={ 1L,4L,22L,228L,4749L,200240L,17034964L,2913479848L,999402129243L,686662003846640L,944294243796543974L,BigInteger.Parse("2598186366278914473948"),BigInteger.Parse("14300408328085246335179009"),BigInteger.Parse("157434326611214704329370130880") };
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
public class A137158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A137158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A137158Inst Instance=new A137158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137159
{
public static readonly BigInteger[] Value={ 1L,8L,92L,1976L,84086L,7173240L,1227862380L,421296930984L,289484024512093L,398106386971472608L,BigInteger.Parse("1095381029276651137560"),BigInteger.Parse("6028986377761538637043792"),BigInteger.Parse("66373632185586959347740452492"),BigInteger.Parse("1461497816340787260620205149915824") };
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
public class A137159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137159Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A137159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137159.Bytes);
public BigInteger this[int i]=>Value[i];

public static A137159Inst Instance=new A137159Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137192
{
public static readonly long[] Value={ 3L,43L,51L,67L,75L,99L,115L,163L,171L,195L,211L,219L,235L,259L,267L,283L,307L,331L,339L,427L,451L,475L,483L,579L,619L,643L,651L,699L,723L,739L,787L,819L,867L,883L,931L,979L,1011L,1107L,1123L,1147L,1155L,1179L,1203L,1219L,1251L,1275L,1291L,1323L,1339L,1387L,1395L,1419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137192Inst : IEnumerable<long>
{
public static readonly long[] Value=A137192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137192.Bytes);
public long this[int i]=>Value[i];

public static A137192Inst Instance=new A137192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137193
{
public static readonly long[] Value={ 0L,0L,1L,2L,10L,46L,215L,1037L,5083L,24918L,122437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137193Inst : IEnumerable<long>
{
public static readonly long[] Value=A137193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137193.Bytes);
public long this[int i]=>Value[i];

public static A137193Inst Instance=new A137193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137194
{
public static readonly long[] Value={ 13L,21L,37L,69L,93L,133L,141L,189L,205L,237L,261L,285L,349L,357L,421L,429L,477L,517L,541L,613L,621L,645L,685L,693L,717L,741L,781L,805L,885L,925L,933L,957L,981L,997L,1021L,1029L,1053L,1093L,1101L,1117L,1189L,1197L,1245L,1261L,1285L,1309L,1357L,1365L,1389L,1485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137194Inst : IEnumerable<long>
{
public static readonly long[] Value=A137194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137194.Bytes);
public long this[int i]=>Value[i];

public static A137194Inst Instance=new A137194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137195
{
public static readonly long[] Value={ 1L,6L,19L,64L,185L,542L,1511L,4144L,11329L,29894L,80731L,207696L,556217L,1405566L,3741263L,9328928L,24716353L,60998086L,161022115L,394136864L,1037382905L,2522256670L,6622609463L,16012527312L,41958312193L,100973218566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137195Inst : IEnumerable<long>
{
public static readonly long[] Value=A137195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137195.Bytes);
public long this[int i]=>Value[i];

public static A137195Inst Instance=new A137195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137196
{
public static readonly long[] Value={ 7L,15L,31L,63L,79L,87L,111L,127L,135L,151L,159L,223L,231L,303L,319L,327L,367L,391L,399L,415L,463L,487L,495L,511L,519L,535L,559L,583L,591L,615L,631L,639L,655L,679L,727L,735L,823L,831L,855L,895L,903L,927L,975L,991L,1023L,1039L,1087L,1095L,1167L,1183L,1231L,1263L,1303L,1455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137196Inst : IEnumerable<long>
{
public static readonly long[] Value=A137196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137196.Bytes);
public long this[int i]=>Value[i];

public static A137196Inst Instance=new A137196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137197
{
public static readonly long[] Value={ 1L,0L,9L,2L,3L,6L,3L,7L,9L,1L,0L,9L,5L,1L,2L,2L,7L,8L,8L,8L,0L,1L,3L,8L,0L,4L,2L,4L,4L,8L,9L,0L,9L,7L,0L,5L,8L,8L,7L,1L,5L,0L,4L,6L,4L,4L,7L,1L,0L,8L,1L,4L,2L,4L,4L,2L,3L,8L,0L,5L,4L,9L,7L,5L,5L,0L,2L,2L,7L,2L,8L,4L,7L,3L,0L,1L,8L,8L,5L,5L,4L,8L,5L,9L,2L,0L,6L,0L,3L,6L,5L,9L,4L,6L,6L,2L,2L,8L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137197Inst : IEnumerable<long>
{
public static readonly long[] Value=A137197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137197.Bytes);
public long this[int i]=>Value[i];

public static A137197Inst Instance=new A137197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137198
{
public static readonly long[] Value={ 561L,645L,1905L,2465L,4371L,23001L,25761L,60701L,87249L,158369L,181901L,206601L,212421L,253241L,280601L,332949L,348161L,513629L,580337L,587861L,656601L,831405L,1207361L,1275681L,1472505L,1489665L,1678541L,1735841L,1815465L,1909001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137198Inst : IEnumerable<long>
{
public static readonly long[] Value=A137198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137198.Bytes);
public long this[int i]=>Value[i];

public static A137198Inst Instance=new A137198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137199
{
public static readonly long[] Value={ 1L,1L,1L,5L,9L,25L,57L,141L,337L,817L,1969L,4757L,11481L,27721L,66921L,161565L,390049L,941665L,2273377L,5488421L,13250217L,31988857L,77227929L,186444717L,450117361L,1086679441L,2623476241L,6333631925L,15290740089L,36915112105L,89120964297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137199Inst : IEnumerable<long>
{
public static readonly long[] Value=A137199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137199.Bytes);
public long this[int i]=>Value[i];

public static A137199Inst Instance=new A137199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137200
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,7L,9L,13L,18L,25L,34L,47L,65L,90L,124L,171L,236L,326L,450L,621L,857L,1183L,1633L,2254L,3111L,4294L,5927L,8181L,11292L,15586L,21513L,29694L,40986L,56572L,78085L,107779L,148765L,205337L,283422L,391201L,539966L,745303L,1028725L,1419926L,1959892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137200Inst : IEnumerable<long>
{
public static readonly long[] Value=A137200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137200.Bytes);
public long this[int i]=>Value[i];

public static A137200Inst Instance=new A137200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137201
{
public static readonly long[] Value={ 342L,438L,546L,666L,685L,798L,942L,950L,1028L,1098L,1266L,1275L,1371L,1446L,1462L,1638L,1666L,1714L,1842L,1974L,2004L,2057L,2058L,2129L,2286L,2394L,2395L,2396L,2397L,2398L,2399L,2400L,2486L,2526L,2666L,2670L,2733L,2743L,2778L,2998L,3042L,3086L,3295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137201Inst : IEnumerable<long>
{
public static readonly long[] Value=A137201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137201.Bytes);
public long this[int i]=>Value[i];

public static A137201Inst Instance=new A137201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137202
{
public static readonly long[] Value={ 3L,3L,5L,9L,16L,23L,33L,46L,63L,82L,109L,139L,178L,224L,282L,348L,434L,531L,653L,796L,973L,1176L,1433L,1725L,2090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137202Inst : IEnumerable<long>
{
public static readonly long[] Value=A137202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137202.Bytes);
public long this[int i]=>Value[i];

public static A137202Inst Instance=new A137202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137203
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,9L,10L,10L,11L,11L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137203Inst : IEnumerable<long>
{
public static readonly long[] Value=A137203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137203.Bytes);
public long this[int i]=>Value[i];

public static A137203Inst Instance=new A137203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137204
{
public static readonly long[] Value={ 3L,0L,8L,6L,1L,6L,1L,2L,6L,9L,6L,3L,0L,4L,8L,7L,5L,5L,6L,9L,5L,5L,8L,1L,1L,2L,4L,1L,5L,1L,4L,1L,2L,3L,3L,6L,5L,2L,0L,3L,0L,5L,8L,2L,2L,4L,7L,3L,1L,7L,2L,7L,4L,0L,9L,4L,7L,4L,8L,0L,4L,4L,2L,9L,4L,2L,1L,5L,3L,8L,1L,2L,6L,0L,9L,8L,4L,4L,7L,3L,9L,7L,9L,2L,8L,5L,2L,9L,4L,5L,2L,8L,7L,1L,0L,8L,6L,0L,7L,1L,1L,7L,4L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137204Inst : IEnumerable<long>
{
public static readonly long[] Value=A137204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137204.Bytes);
public long this[int i]=>Value[i];

public static A137204Inst Instance=new A137204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137205
{
public static readonly long[] Value={ 215L,923L,944L,1455L,2379L,5355L,6467L,6623L,14099L,23495L,196343L,212795L,1661135L,4070199L,4160919L,4626699L,60464627L,217408415L,248621603L,262792907L,265371335L,613033667L,684241907L,1065360113L,3148946723L,4773647871L,6729842063L,19910536424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137205Inst : IEnumerable<long>
{
public static readonly long[] Value=A137205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137205.Bytes);
public long this[int i]=>Value[i];

public static A137205Inst Instance=new A137205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137206
{
public static readonly long[] Value={ 0L,2L,-1L,4L,-2L,8L,-4L,16L,-8L,32L,-16L,64L,-32L,128L,-64L,256L,-128L,512L,-256L,1024L,-512L,2048L,-1024L,4096L,-2048L,8192L,-4096L,16384L,-8192L,32768L,-16384L,65536L,-32768L,131072L,-65536L,262144L,-131072L,524288L,-262144L,1048576L,-524288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137206Inst : IEnumerable<long>
{
public static readonly long[] Value=A137206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137206.Bytes);
public long this[int i]=>Value[i];

public static A137206Inst Instance=new A137206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137207
{
public static readonly long[] Value={ 12L,87L,584L,3835L,25008L,162792L,1060048L,6910695L,45119100L,295038315L,1932260256L,12673336052L,83236707232L,547388545740L,3604063891104L,23755630474079L,156740823815940L,1035157282013085L,6842413166034600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137207Inst : IEnumerable<long>
{
public static readonly long[] Value=A137207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137207.Bytes);
public long this[int i]=>Value[i];

public static A137207Inst Instance=new A137207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137256
{
public static readonly long[] Value={ 1L,2L,4L,9L,21L,48L,108L,243L,549L,1242L,2808L,6345L,14337L,32400L,73224L,165483L,373977L,845154L,1909980L,4316409L,9754749L,22044960L,49819860L,112588947L,254442141L,575019162L,1299497904L,2936762649L,6636851721L,14998760928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137256Inst : IEnumerable<long>
{
public static readonly long[] Value=A137256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137256.Bytes);
public long this[int i]=>Value[i];

public static A137256Inst Instance=new A137256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137257
{
public static readonly long[] Value={ 4L,12L,16L,18L,20L,24L,27L,28L,36L,44L,48L,50L,52L,54L,60L,64L,68L,72L,76L,80L,84L,90L,92L,98L,100L,108L,112L,116L,120L,124L,126L,132L,135L,140L,144L,148L,150L,156L,160L,162L,164L,168L,172L,176L,180L,188L,189L,192L,196L,198L,200L,204L,208L,212L,216L,220L,228L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137257Inst : IEnumerable<long>
{
public static readonly long[] Value=A137257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137257.Bytes);
public long this[int i]=>Value[i];

public static A137257Inst Instance=new A137257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137258
{
public static readonly long[] Value={ 3L,5L,7L,17L,19L,139L,157L,577L,1201L,27361L,530401L,2513281L,7183201L,407817217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137258Inst : IEnumerable<long>
{
public static readonly long[] Value=A137258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137258.Bytes);
public long this[int i]=>Value[i];

public static A137258Inst Instance=new A137258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137259
{
public static readonly long[] Value={ 0L,0L,0L,3L,3L,0L,20L,20L,16L,0L,115L,115L,110L,90L,0L,714L,714L,708L,684L,576L,0L,5033L,5033L,5026L,4998L,4872L,4200L,0L,40312L,40312L,40304L,40272L,40128L,39360L,34560L,0L,362871L,362871L,362862L,362826L,362664L,361800L,356400L,317520L,0L,3628790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137259Inst : IEnumerable<long>
{
public static readonly long[] Value=A137259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137259.Bytes);
public long this[int i]=>Value[i];

public static A137259Inst Instance=new A137259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137260
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,0L,5L,10L,12L,0L,23L,46L,66L,72L,0L,119L,238L,354L,456L,480L,0L,719L,1438L,2154L,2856L,3480L,3600L,0L,5039L,10078L,15114L,20136L,25080L,29520L,30240L,0L,40319L,80638L,120954L,161256L,201480L,241200L,277200L,282240L,0L,362879L,725758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137260Inst : IEnumerable<long>
{
public static readonly long[] Value=A137260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137260.Bytes);
public long this[int i]=>Value[i];

public static A137260Inst Instance=new A137260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137261
{
public static readonly long[] Value={ 1200L,360L,360L,29172L,360L,360L,360L,5765161L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137261Inst : IEnumerable<long>
{
public static readonly long[] Value=A137261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137261.Bytes);
public long this[int i]=>Value[i];

public static A137261Inst Instance=new A137261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137262
{
public static readonly long[] Value={ 1L,22L,671L,21097L,666716L,21082008L,666667166L,21081852648L,666666671666L,21081851083600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137262Inst : IEnumerable<long>
{
public static readonly long[] Value=A137262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137262.Bytes);
public long this[int i]=>Value[i];

public static A137262Inst Instance=new A137262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137263
{
public static readonly long[] Value={ 26L,50L,56L,86L,134L,170L,176L,236L,254L,260L,266L,356L,386L,446L,473L,506L,515L,560L,566L,590L,596L,650L,656L,680L,803L,944L,950L,974L,980L,1016L,1100L,1106L,1184L,1190L,1220L,1226L,1268L,1286L,1313L,1364L,1370L,1436L,1496L,1505L,1517L,1556L,1604L,1616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137263Inst : IEnumerable<long>
{
public static readonly long[] Value=A137263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137263.Bytes);
public long this[int i]=>Value[i];

public static A137263Inst Instance=new A137263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137264
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,1L,2L,1L,0L,2L,0L,1L,2L,1L,0L,0L,2L,0L,1L,2L,0L,1L,0L,2L,1L,2L,1L,2L,1L,2L,1L,0L,2L,1L,2L,0L,0L,1L,0L,0L,2L,1L,2L,1L,2L,0L,0L,1L,2L,1L,0L,2L,1L,0L,0L,0L,2L,0L,1L,2L,1L,2L,1L,2L,1L,2L,0L,1L,2L,1L,0L,2L,0L,0L,1L,0L,2L,1L,2L,1L,2L,1L,2L,0L,1L,0L,2L,1L,2L,1L,0L,2L,1L,2L,1L,0L,0L,2L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137264Inst : IEnumerable<long>
{
public static readonly long[] Value=A137264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137264.Bytes);
public long this[int i]=>Value[i];

public static A137264Inst Instance=new A137264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137265
{
public static readonly long[] Value={ 1L,1L,2L,8L,35L,163L,796L,4024L,20885L,110654L,596064L,3254752L,17974893L,100227022L,563482140L,3190633232L,18179765509L,104158703503L,599698459613L,3467978715612L,20134256546896L,117313279477959L,685756774642494L,4020515276730588L,23636036336651811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137265Inst : IEnumerable<long>
{
public static readonly long[] Value=A137265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137265.Bytes);
public long this[int i]=>Value[i];

public static A137265Inst Instance=new A137265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137266
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,2L,3L,4L,3L,3L,3L,4L,3L,3L,4L,5L,3L,5L,3L,4L,4L,4L,3L,6L,3L,5L,5L,5L,2L,4L,6L,6L,3L,3L,5L,8L,4L,3L,4L,7L,2L,5L,5L,6L,5L,3L,4L,8L,5L,6L,4L,5L,4L,6L,4L,6L,5L,5L,3L,8L,2L,5L,7L,8L,4L,5L,4L,6L,4L,5L,5L,9L,4L,5L,6L,6L,3L,5L,5L,9L,7L,4L,3L,8L,5L,4L,5L,6L,4L,8L,6L,5L,5L,4L,5L,9L,3L,6L,7L,10L,4L,5L,4L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137266Inst : IEnumerable<long>
{
public static readonly long[] Value=A137266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137266.Bytes);
public long this[int i]=>Value[i];

public static A137266Inst Instance=new A137266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137267
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,4L,6L,4L,4L,6L,12L,24L,5L,5L,8L,18L,48L,120L,6L,6L,10L,24L,72L,240L,720L,7L,7L,12L,30L,96L,360L,1440L,5040L,8L,8L,14L,36L,120L,480L,2160L,10080L,40320L,9L,9L,16L,42L,144L,600L,2880L,15120L,80640L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137267Inst : IEnumerable<long>
{
public static readonly long[] Value=A137267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137267.Bytes);
public long this[int i]=>Value[i];

public static A137267Inst Instance=new A137267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137268
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,6L,8L,18L,24L,24L,16L,54L,96L,120L,120L,32L,162L,384L,600L,720L,720L,64L,486L,1536L,3000L,4320L,5040L,5040L,128L,1458L,6144L,15000L,25920L,35280L,40320L,40320L,256L,4374L,24576L,75000L,155520L,246960L,322560L,362880L,362880L,512L,13122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137268Inst : IEnumerable<long>
{
public static readonly long[] Value=A137268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137268.Bytes);
public long this[int i]=>Value[i];

public static A137268Inst Instance=new A137268Inst();

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