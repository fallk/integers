using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A124405
{
public static readonly BigInteger[] Value={ 2L,9L,57L,495L,5700L,82201L,1419761L,28501117L,651233662L,16676686697L,472883843993L,14705395791307L,497538872883728L,18193397941038737L,714950006521386977L,BigInteger.Parse("30046260016074301945"),BigInteger.Parse("1344648068888240941018") };
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
public class A124405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124405Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A124405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124405.Bytes);
public BigInteger this[int i]=>Value[i];

public static A124405Inst Instance=new A124405Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124406
{
public static readonly long[] Value={ 2L,3L,4L,1L,6L,0L,2L,1L,8L,0L,10L,-8L,-4L,8L,2L,1L,12L,-2L,2L,0L,10L,2L,14L,-18L,-14L,2L,12L,6L,2L,2L,-6L,15L,14L,-2L,38L,-42L,-32L,16L,26L,-4L,78L,-66L,-74L,26L,2L,66L,56L,-94L,-26L,-112L,-12L,164L,18L,-38L,-16L,-134L,-8L,204L,46L,-42L,-48L,-338L,2L,453L,10L,-50L,-4L,-252L,24L,272L,64L,-104L,-64L,-176L,-6L,242L,48L,-28L,-20L,-402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124406Inst : IEnumerable<long>
{
public static readonly long[] Value=A124406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124406.Bytes);
public long this[int i]=>Value[i];

public static A124406Inst Instance=new A124406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124407
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,-1L,-1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,-2L,-2L,0L,1L,1L,-1L,1L,0L,1L,1L,0L,3L,-4L,-3L,1L,1L,1L,6L,-5L,-5L,0L,0L,6L,3L,-6L,-2L,-10L,-2L,13L,0L,-3L,1L,-12L,-2L,17L,2L,-1L,-2L,-30L,0L,41L,-1L,-6L,0L,-22L,3L,22L,2L,-6L,-3L,-14L,-2L,15L,-1L,4L,2L,-27L,8L,24L,2L,-49L,-7L,-1L,0L,45L,-2L,-24L,5L,-89L,0L,83L,5L,25L,-3L,-9L,-8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124407Inst : IEnumerable<long>
{
public static readonly long[] Value=A124407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124407.Bytes);
public long this[int i]=>Value[i];

public static A124407Inst Instance=new A124407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124520
{
public static readonly long[] Value={ 3L,30L,33L,63L,75L,78L,93L,102L,123L,138L,153L,162L,165L,192L,195L,240L,252L,273L,297L,303L,342L,387L,393L,420L,435L,438L,450L,468L,483L,522L,525L,540L,588L,630L,633L,660L,663L,717L,738L,747L,750L,765L,798L,825L,837L,855L,957L,978L,993L,1023L,1032L,1062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124520Inst : IEnumerable<long>
{
public static readonly long[] Value=A124520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124520.Bytes);
public long this[int i]=>Value[i];

public static A124520Inst Instance=new A124520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124521
{
public static readonly long[] Value={ 12L,15L,27L,72L,93L,117L,132L,162L,168L,195L,198L,210L,258L,267L,300L,327L,330L,345L,435L,468L,642L,765L,813L,855L,903L,912L,960L,978L,993L,1128L,1143L,1182L,1290L,1350L,1353L,1365L,1392L,1398L,1440L,1632L,1680L,1713L,1737L,1797L,1848L,1860L,1947L,1953L,1962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124521Inst : IEnumerable<long>
{
public static readonly long[] Value=A124521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124521.Bytes);
public long this[int i]=>Value[i];

public static A124521Inst Instance=new A124521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124522
{
public static readonly long[] Value={ 2L,1L,1L,9L,3L,1L,3L,12L,1L,3L,9L,3L,12L,15L,1L,6L,3L,2L,6L,6L,1L,15L,3L,4L,3L,6L,2L,48L,6L,1L,21L,3L,3L,15L,6L,1L,27L,3L,4L,3L,15L,5L,12L,15L,2L,9L,3L,2L,9L,6L,1L,3L,60L,1L,6L,24L,2L,3L,9L,2L,129L,12L,7L,9L,15L,5L,12L,27L,1L,3L,9L,3L,42L,45L,1L,90L,3L,2L,66L,21L,5L,63L,27L,16L,6L,6L,2L,12L,24L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124522Inst : IEnumerable<long>
{
public static readonly long[] Value=A124522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124522.Bytes);
public long this[int i]=>Value[i];

public static A124522Inst Instance=new A124522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124523
{
public static readonly long[] Value={ 1L,3L,8L,20L,49L,119L,289L,707L,1749L,4379L,11092L,28412L,73573L,192535L,508918L,1357770L,3653343L,9905437L,27040975L,74269569L,205091177L,569078255L,1585839062L,4436191950L,12452408525L,35062157207L,99000292173L,280242836387L,795124827781L,2260758570327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124523Inst : IEnumerable<long>
{
public static readonly long[] Value=A124523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124523.Bytes);
public long this[int i]=>Value[i];

public static A124523Inst Instance=new A124523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124524
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,2L,3L,4L,4L,2L,2L,3L,3L,3L,2L,5L,3L,7L,6L,6L,2L,2L,7L,3L,3L,6L,3L,2L,5L,4L,6L,3L,9L,3L,8L,2L,3L,3L,5L,12L,3L,3L,8L,3L,2L,7L,9L,10L,5L,22L,3L,11L,9L,10L,2L,2L,5L,3L,3L,5L,3L,3L,3L,3L,3L,2L,8L,3L,12L,17L,12L,5L,30L,3L,13L,11L,12L,2L,2L,10L,3L,8L,19L,3L,3L,22L,3L,3L,11L,3L,2L,8L,3L,11L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124524Inst : IEnumerable<long>
{
public static readonly long[] Value=A124524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124524.Bytes);
public long this[int i]=>Value[i];

public static A124524Inst Instance=new A124524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124525
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,2L,3L,4L,4L,2L,4L,7L,8L,6L,4L,5L,6L,9L,4L,9L,2L,6L,9L,10L,13L,14L,6L,6L,7L,8L,15L,8L,19L,4L,13L,2L,8L,13L,13L,16L,23L,15L,19L,10L,7L,9L,10L,16L,12L,26L,7L,25L,7L,12L,3L,10L,13L,23L,24L,31L,18L,31L,25L,21L,12L,10L,11L,12L,21L,15L,36L,11L,38L,19L,25L,11L,21L,3L,12L,19L,22L,24L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124525Inst : IEnumerable<long>
{
public static readonly long[] Value=A124525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124525.Bytes);
public long this[int i]=>Value[i];

public static A124525Inst Instance=new A124525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124526
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,9L,1L,10L,30L,6L,25L,100L,36L,1L,75L,370L,186L,10L,225L,1369L,961L,100L,1L,780L,5587L,4960L,750L,15L,2704L,22801L,25600L,5625L,225L,1L,10556L,101774L,136960L,39000L,2325L,21L,41209L,454276L,732736L,270400L,24025L,441L,1L,178031L,2199262L,4110512L,1849120L,217000L,6027L,28L,769129L,10647169L,23059204L,12645136L,1960000L,82369L,784L,1L,3630780L,55493841L,136074274L,87570056L,16787400L,944230L,13720L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124526Inst : IEnumerable<long>
{
public static readonly long[] Value=A124526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124526.Bytes);
public long this[int i]=>Value[i];

public static A124526Inst Instance=new A124526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124527
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,46L,162L,641L,2656L,12092L,56956L,290636L,1523088L,8559980L,49163792L,300514337L,1870652672L,12318376190L,82394305842L,580168452664L,4141242464512L,30992978322024L,234765130286990L,1858132080028884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124527Inst : IEnumerable<long>
{
public static readonly long[] Value=A124527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124527.Bytes);
public long this[int i]=>Value[i];

public static A124527Inst Instance=new A124527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124528
{
public static readonly long[] Value={ 1L,1L,3L,8L,26L,94L,377L,1639L,7623L,38034L,199338L,1111816L,6442481L,39478219L,249507483L,1659172454L,11321526022L,80944313164L,591617080305L,4514822914133L,35120998653271L,284407875530728L,2342407874087454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124528Inst : IEnumerable<long>
{
public static readonly long[] Value=A124528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124528.Bytes);
public long this[int i]=>Value[i];

public static A124528Inst Instance=new A124528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124529
{
public static readonly BigInteger[] Value={ 1L,2L,6L,29L,190L,1562L,15457L,179034L,2377092L,35599701L,593731310L,10914169312L,219252994039L,4779086510108L,112341582757512L,2833025331800643L,76293601822430388L,2185288262904326236L,BigInteger.Parse("66338823231846583471") };
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
public class A124529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A124529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A124529Inst Instance=new A124529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124530
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,5L,1L,1L,1L,4L,10L,16L,1L,1L,1L,5L,16L,39L,62L,1L,1L,1L,6L,23L,71L,174L,274L,1L,1L,1L,7L,31L,113L,351L,858L,1332L,1L,1L,1L,8L,40L,166L,608L,1891L,4564L,6978L,1L,1L,1L,9L,50L,231L,961L,3535L,10888L,25793L,38873L,1L,1L,1L,10L,61L,309L,1427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124530Inst : IEnumerable<long>
{
public static readonly long[] Value=A124530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124530.Bytes);
public long this[int i]=>Value[i];

public static A124530Inst Instance=new A124530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124531
{
public static readonly long[] Value={ 1L,1L,2L,5L,16L,62L,274L,1332L,6978L,38873L,228090L,1399625L,8933506L,59066261L,403241292L,2835267821L,20490128048L,151951503074L,1154770194362L,8983396031267L,71473650532630L,581142591346325L,4825842125683150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124531Inst : IEnumerable<long>
{
public static readonly long[] Value=A124531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124531.Bytes);
public long this[int i]=>Value[i];

public static A124531Inst Instance=new A124531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124532
{
public static readonly long[] Value={ 1L,1L,3L,10L,39L,174L,858L,4564L,25793L,153301L,951325L,6130757L,40861658L,280767621L,1983859580L,14385651988L,106878699675L,812480791324L,6312686006725L,50083418434737L,405430892640225L,3346568909331984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124532Inst : IEnumerable<long>
{
public static readonly long[] Value=A124532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124532.Bytes);
public long this[int i]=>Value[i];

public static A124532Inst Instance=new A124532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124533
{
public static readonly long[] Value={ 1L,1L,4L,16L,71L,351L,1891L,10888L,66139L,420235L,2775981L,18978873L,133828922L,970678790L,7226115267L,55115404005L,430080085093L,3429311454089L,27912555377062L,231710034354364L,1960247357996533L,16889105788701591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124533Inst : IEnumerable<long>
{
public static readonly long[] Value=A124533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124533.Bytes);
public long this[int i]=>Value[i];

public static A124533Inst Instance=new A124533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124534
{
public static readonly long[] Value={ 1L,1L,5L,25L,113L,608L,3535L,21844L,141809L,959882L,6738850L,48877221L,365145267L,2803002587L,22066904802L,177881536038L,1466278969213L,12345543329079L,106069531868783L,929158597546721L,8292429187449462L,75348425058995464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124534Inst : IEnumerable<long>
{
public static readonly long[] Value=A124534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124534.Bytes);
public long this[int i]=>Value[i];

public static A124534Inst Instance=new A124534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124535
{
public static readonly long[] Value={ 1L,1L,6L,36L,216L,961L,5977L,39363L,271564L,1949165L,14487241L,111115804L,877086405L,7109569724L,59075905996L,502464618671L,4369068613929L,38796820526316L,351496911119002L,3246426019892427L,30543990287835441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124535Inst : IEnumerable<long>
{
public static readonly long[] Value=A124535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124535.Bytes);
public long this[int i]=>Value[i];

public static A124535Inst Instance=new A124535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124568
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,3L,5L,25L,36L,16L,16L,143L,364L,362L,125L,66L,990L,3909L,6417L,4728L,1296L,348L,8464L,48518L,116274L,135932L,76867L,16807L,2321L,89741L,720078L,2370938L,3923330L,3441366L,1518460L,262144L,19437L,1180978L,12965026L,56627440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124568Inst : IEnumerable<long>
{
public static readonly long[] Value=A124568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124568.Bytes);
public long this[int i]=>Value[i];

public static A124568Inst Instance=new A124568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124569
{
public static readonly long[] Value={ 1L,11L,13L,15L,17L,29L,31L,33L,35L,37L,51L,53L,55L,65L,67L,83L,85L,87L,89L,91L,101L,103L,105L,107L,109L,127L,137L,139L,155L,157L,159L,161L,177L,179L,181L,191L,193L,195L,197L,199L,209L,211L,213L,215L,217L,227L,229L,231L,233L,235L,247L,249L,251L,253L,263L,265L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124569Inst : IEnumerable<long>
{
public static readonly long[] Value=A124569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124569.Bytes);
public long this[int i]=>Value[i];

public static A124569Inst Instance=new A124569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124570
{
public static readonly long[] Value={ 4L,4L,4L,4L,9L,4L,4L,4L,33L,4L,4L,6L,91L,0L,4L,4L,6L,115L,213L,0L,4L,4L,4L,6L,0L,213L,0L,4L,4L,4L,4L,111L,0L,1383L,0L,4L,4L,14L,9L,0L,201L,0L,3091L,0L,4L,4L,6L,51L,203L,0L,201L,0L,8129L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124570Inst : IEnumerable<long>
{
public static readonly long[] Value=A124570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124570.Bytes);
public long this[int i]=>Value[i];

public static A124570Inst Instance=new A124570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124571
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,6L,12L,21L,33L,53L,90L,151L,253L,426L,701L,1151L,1900L,3123L,5162L,8553L,14092L,23223L,38296L,62963L,103458L,170056L,279140L,457833L,751033L,1231671L,2019090L,3309710L,5424315L,8886249L,14553015L,23826952L,38997232L,63806394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124571Inst : IEnumerable<long>
{
public static readonly long[] Value=A124571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124571.Bytes);
public long this[int i]=>Value[i];

public static A124571Inst Instance=new A124571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124572
{
public static readonly long[] Value={ 1L,1L,3L,1L,12L,3L,1L,39L,15L,9L,1L,120L,54L,72L,9L,1L,363L,174L,378L,81L,27L,1L,1092L,537L,1656L,459L,324L,27L,1L,3279L,1629L,6579L,2115L,2349L,351L,81L,1L,9840L,4908L,24624L,8694L,13392L,2700L,1296L,81L,1L,29523L,14748L,88596L,33318L,66258L,16092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124572Inst : IEnumerable<long>
{
public static readonly long[] Value=A124572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124572.Bytes);
public long this[int i]=>Value[i];

public static A124572Inst Instance=new A124572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124573
{
public static readonly long[] Value={ 1L,3L,1L,9L,4L,3L,27L,13L,21L,3L,81L,40L,102L,24L,9L,243L,121L,426L,126L,99L,9L,729L,364L,1641L,552L,675L,108L,27L,2187L,1093L,6015L,2193L,3681L,783L,405L,27L,6561L,3280L,21324L,8208L,17622L,4464L,3564L,432L,81L,19683L,9841L,73812L,29532L,77490L,22086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124573Inst : IEnumerable<long>
{
public static readonly long[] Value=A124573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124573.Bytes);
public long this[int i]=>Value[i];

public static A124573Inst Instance=new A124573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124574
{
public static readonly long[] Value={ 1L,3L,1L,10L,7L,1L,37L,39L,11L,1L,150L,204L,84L,15L,1L,654L,1050L,555L,145L,19L,1L,3012L,5409L,3415L,1154L,222L,23L,1L,14445L,28063L,20223L,8253L,2065L,315L,27L,1L,71398L,146920L,117208L,55300L,16828L,3352L,424L,31L,1L,361114L,776286L,671052L,355236L,125964L,30660L,5079L,549L,35L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124574Inst : IEnumerable<long>
{
public static readonly long[] Value=A124574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124574.Bytes);
public long this[int i]=>Value[i];

public static A124574Inst Instance=new A124574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124575
{
public static readonly long[] Value={ 1L,2L,1L,5L,6L,1L,16L,30L,10L,1L,62L,146L,71L,14L,1L,270L,717L,444L,128L,18L,1L,1257L,3582L,2621L,974L,201L,22L,1L,6096L,18206L,15040L,6718L,1800L,290L,26L,1L,30398L,93960L,85084L,43712L,14208L,2986L,395L,30L,1L,154756L,491322L,478008L,274140L,103530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124575Inst : IEnumerable<long>
{
public static readonly long[] Value=A124575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124575.Bytes);
public long this[int i]=>Value[i];

public static A124575Inst Instance=new A124575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124576
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,1L,7L,23L,9L,1L,30L,108L,60L,13L,1L,138L,522L,361L,113L,17L,1L,660L,2587L,2079L,830L,182L,21L,1L,3247L,13087L,11733L,5581L,1579L,267L,25L,1L,16334L,67328L,65600L,35636L,12164L,2672L,368L,29L,1L,83662L,351246L,365364L,220308L,86964L,23220L,4173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124576Inst : IEnumerable<long>
{
public static readonly long[] Value=A124576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124576.Bytes);
public long this[int i]=>Value[i];

public static A124576Inst Instance=new A124576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124577
{
public static readonly BigInteger[] Value={ 1L,1L,6L,39L,356L,4055L,57786L,983535L,19520264L,441967518L,11235798510L,316719689506L,9800860032876L,330230585628437L,12032866998445818L,471416196117401340L,BigInteger.Parse("19758835313514076176"),BigInteger.Parse("882185444649249777913"),BigInteger.Parse("41797472220815112375966"),BigInteger.Parse("2094455101139881670407954") };
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
public class A124577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A124577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A124577Inst Instance=new A124577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124578
{
public static readonly long[] Value={ 2L,16L,150L,1784L,25460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124578Inst : IEnumerable<long>
{
public static readonly long[] Value=A124578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124578.Bytes);
public long this[int i]=>Value[i];

public static A124578Inst Instance=new A124578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124579
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,3L,1L,2L,2L,4L,3L,5L,3L,4L,4L,6L,5L,7L,6L,5L,6L,8L,7L,8L,7L,9L,10L,9L,10L,11L,11L,8L,9L,10L,12L,12L,11L,12L,13L,13L,14L,15L,14L,15L,13L,16L,16L,17L,18L,14L,19L,17L,20L,15L,21L,16L,17L,18L,22L,19L,18L,23L,24L,19L,20L,21L,25L,20L,22L,23L,26L,24L,21L,27L,28L,22L,25L,26L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124579Inst : IEnumerable<long>
{
public static readonly long[] Value=A124579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124579.Bytes);
public long this[int i]=>Value[i];

public static A124579Inst Instance=new A124579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124580
{
public static readonly long[] Value={ 1L,9L,15L,31L,36L,40L,47L,165L,237L,330L,354L,357L,365L,402L,406L,421L,426L,794L,797L,813L,885L,894L,897L,905L,914L,1257L,1281L,1290L,1298L,1301L,1337L,1522L,1526L,1545L,1842L,1865L,2094L,2098L,2118L,2121L,2137L,2569L,3598L,4602L,4609L,4621L,4629L,4726L,4729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124580Inst : IEnumerable<long>
{
public static readonly long[] Value=A124580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124580.Bytes);
public long this[int i]=>Value[i];

public static A124580Inst Instance=new A124580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124581
{
public static readonly long[] Value={ 216L,1000L,1728L,2744L,5832L,8000L,10648L,13824L,17576L,21952L,27000L,46656L,64000L,74088L,85184L,110592L,125000L,140608L,157464L,175616L,216000L,287496L,314432L,343000L,373248L,438976L,474552L,512000L,592704L,681472L,729000L,778688L,884736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124581Inst : IEnumerable<long>
{
public static readonly long[] Value=A124581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124581.Bytes);
public long this[int i]=>Value[i];

public static A124581Inst Instance=new A124581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124582
{
public static readonly long[] Value={ 23L,31L,47L,53L,61L,73L,83L,89L,113L,131L,139L,151L,157L,167L,173L,181L,199L,211L,233L,241L,251L,257L,263L,271L,283L,293L,317L,331L,337L,353L,359L,367L,373L,383L,389L,401L,409L,421L,433L,443L,449L,467L,479L,491L,503L,509L,523L,541L,547L,557L,563L,571L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124582Inst : IEnumerable<long>
{
public static readonly long[] Value=A124582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124582.Bytes);
public long this[int i]=>Value[i];

public static A124582Inst Instance=new A124582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124583
{
public static readonly long[] Value={ 89L,113L,139L,181L,199L,211L,241L,283L,293L,317L,337L,359L,389L,401L,409L,421L,449L,467L,479L,491L,509L,523L,547L,577L,619L,631L,661L,683L,691L,701L,709L,719L,743L,761L,773L,787L,797L,811L,829L,839L,863L,887L,911L,919L,929L,953L,983L,997L,1021L,1039L,1051L,1069L,1109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124583Inst : IEnumerable<long>
{
public static readonly long[] Value=A124583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124583.Bytes);
public long this[int i]=>Value[i];

public static A124583Inst Instance=new A124583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124600
{
public static readonly long[] Value={ 1L,-1L,14L,5L,-1L,5L,17L,11L,16L,-1L,10L,10L,6L,3L,36L,12L,-1L,6L,7L,13L,37L,16L,4L,26L,52L,-1L,2L,12L,6L,9L,11L,13L,16L,14L,4L,5L,-1L,2L,8L,18L,10L,3L,4L,12L,10L,3L,20L,9L,6L,-1L,2L,48L,6L,4L,49L,11L,32L,13L,9L,15L,19L,4L,5L,21L,-1L,2L,5L,24L,17L,3L,6L,19L,16L,5L,3L,4L,11L,17L,7L,19L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124600Inst : IEnumerable<long>
{
public static readonly long[] Value=A124600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124600.Bytes);
public long this[int i]=>Value[i];

public static A124600Inst Instance=new A124600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124601
{
public static readonly long[] Value={ -1L,1L,1L,1L,-1L,23L,14L,7L,8L,-1L,2L,3L,5L,7L,4L,15L,-1L,2L,11L,25L,5L,26L,6L,7L,17L,-1L,6L,2L,4L,5L,13L,16L,17L,24L,7L,3L,-1L,15L,2L,26L,41L,5L,57L,23L,12L,25L,11L,13L,17L,-1L,4L,2L,3L,5L,22L,3L,6L,32L,3L,4L,12L,3L,12L,11L,-1L,24L,2L,2L,6L,12L,22L,5L,7L,12L,19L,25L,3L,14L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124601Inst : IEnumerable<long>
{
public static readonly long[] Value=A124601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124601.Bytes);
public long this[int i]=>Value[i];

public static A124601Inst Instance=new A124601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124602
{
public static readonly long[] Value={ -1L,-1L,5L,4L,1L,1L,1L,1L,1L,-1L,4L,6L,25L,8L,28L,4L,-1L,3L,2L,19L,4L,4L,12L,9L,34L,-1L,13L,7L,2L,20L,5L,10L,8L,7L,25L,19L,-1L,4L,10L,2L,3L,6L,17L,9L,5L,5L,4L,18L,3L,-1L,17L,6L,2L,2L,8L,16L,16L,11L,17L,27L,10L,5L,31L,5L,-1L,4L,3L,7L,2L,6L,8L,3L,5L,27L,4L,5L,32L,13L,12L,33L,5L,-1L,18L,14L,56L,2L,2L,3L,23L,10L,7L,7L,12L,13L,13L,35L,13L,18L,24L,26L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124602Inst : IEnumerable<long>
{
public static readonly long[] Value=A124602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124602.Bytes);
public long this[int i]=>Value[i];

public static A124602Inst Instance=new A124602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124603
{
public static readonly long[] Value={ -1L,-1L,7L,3L,-1L,3L,13L,8L,22L,1L,1L,1L,1L,1L,1L,1L,-1L,4L,36L,2L,6L,28L,13L,6L,14L,-1L,10L,15L,22L,2L,18L,8L,14L,12L,3L,10L,-1L,9L,26L,11L,2L,4L,18L,6L,3L,7L,5L,21L,7L,-1L,25L,23L,21L,23L,2L,23L,4L,6L,7L,30L,15L,17L,24L,3L,-1L,20L,6L,5L,12L,2L,2L,10L,8L,7L,5L,9L,14L,8L,3L,11L,21L,-1L,5L,6L,8L,17L,4L,2L,2L,3L,6L,3L,7L,4L,5L,8L,12L,42L,9L,8L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124603Inst : IEnumerable<long>
{
public static readonly long[] Value=A124603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124603.Bytes);
public long this[int i]=>Value[i];

public static A124603Inst Instance=new A124603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124604
{
public static readonly long[] Value={ -1L,-1L,2L,23L,-1L,11L,2L,3L,5L,-1L,27L,7L,2L,11L,3L,9L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,16L,8L,38L,7L,2L,7L,7L,3L,10L,18L,-1L,25L,4L,3L,4L,2L,2L,5L,6L,11L,22L,7L,19L,-1L,14L,3L,23L,26L,3L,2L,2L,3L,23L,6L,3L,6L,4L,22L,-1L,9L,4L,14L,3L,16L,12L,2L,2L,3L,12L,7L,15L,4L,15L,7L,3L,-1L,14L,5L,25L,6L,8L,18L,12L,2L,2L,10L,9L,3L,10L,3L,69L,3L,5L,3L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124604Inst : IEnumerable<long>
{
public static readonly long[] Value=A124604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124604.Bytes);
public long this[int i]=>Value[i];

public static A124604Inst Instance=new A124604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124605
{
public static readonly long[] Value={ -1L,-1L,8L,6L,-1L,37L,31L,4L,36L,-1L,26L,12L,10L,4L,6L,19L,-1L,7L,16L,3L,7L,2L,7L,4L,10L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,8L,18L,19L,5L,38L,22L,2L,8L,23L,13L,3L,13L,-1L,13L,11L,8L,14L,14L,13L,11L,2L,4L,7L,4L,10L,22L,6L,-1L,6L,13L,4L,9L,18L,10L,15L,4L,2L,7L,6L,45L,35L,18L,13L,15L,-1L,3L,8L,4L,5L,10L,9L,8L,12L,11L,2L,2L,6L,4L,39L,6L,6L,16L,17L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124605Inst : IEnumerable<long>
{
public static readonly long[] Value=A124605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124605.Bytes);
public long this[int i]=>Value[i];

public static A124605Inst Instance=new A124605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124606
{
public static readonly long[] Value={ -1L,-1L,9L,12L,-1L,4L,39L,2L,13L,-1L,3L,4L,3L,2L,5L,10L,-1L,8L,5L,14L,30L,8L,2L,27L,12L,-1L,39L,4L,8L,6L,14L,3L,2L,6L,37L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,6L,30L,19L,41L,6L,4L,21L,17L,2L,2L,6L,8L,20L,27L,-1L,3L,11L,18L,4L,4L,3L,4L,48L,18L,2L,2L,24L,6L,6L,26L,20L,-1L,16L,23L,3L,30L,5L,34L,11L,13L,4L,12L,5L,2L,2L,4L,25L,13L,10L,12L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124606Inst : IEnumerable<long>
{
public static readonly long[] Value=A124606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124606.Bytes);
public long this[int i]=>Value[i];

public static A124606Inst Instance=new A124606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124607
{
public static readonly long[] Value={ -1L,-1L,12L,2L,-1L,7L,8L,5L,7L,-1L,6L,8L,13L,9L,2L,3L,-1L,13L,10L,15L,3L,6L,8L,2L,6L,-1L,14L,11L,28L,10L,3L,4L,23L,2L,18L,6L,-1L,5L,15L,7L,14L,10L,5L,4L,11L,2L,2L,24L,12L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,7L,47L,8L,26L,15L,14L,8L,9L,8L,10L,10L,2L,2L,5L,10L,6L,-1L,13L,9L,21L,10L,3L,4L,28L,27L,16L,52L,24L,8L,8L,2L,2L,7L,31L,6L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124607Inst : IEnumerable<long>
{
public static readonly long[] Value=A124607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124607.Bytes);
public long this[int i]=>Value[i];

public static A124607Inst Instance=new A124607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124608
{
public static readonly long[] Value={ -1L,-1L,19L,8L,-1L,15L,6L,45L,2L,-1L,13L,17L,18L,15L,9L,2L,-1L,20L,9L,4L,20L,3L,11L,5L,2L,-1L,15L,17L,15L,3L,26L,11L,5L,13L,2L,9L,-1L,3L,13L,10L,16L,14L,3L,7L,9L,4L,3L,2L,4L,-1L,8L,7L,16L,3L,4L,7L,3L,5L,11L,3L,14L,2L,2L,23L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,6L,16L,9L,14L,7L,12L,3L,6L,3L,26L,18L,36L,11L,11L,7L,2L,2L,5L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124608Inst : IEnumerable<long>
{
public static readonly long[] Value=A124608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124608.Bytes);
public long this[int i]=>Value[i];

public static A124608Inst Instance=new A124608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124609
{
public static readonly long[] Value={ -1L,-1L,15L,18L,-1L,8L,4L,15L,15L,-1L,16L,9L,24L,14L,14L,5L,-1L,19L,13L,6L,8L,9L,3L,3L,3L,-1L,3L,3L,3L,27L,22L,17L,10L,19L,5L,2L,-1L,12L,11L,5L,20L,58L,9L,25L,7L,8L,7L,20L,2L,-1L,33L,16L,11L,7L,7L,6L,24L,4L,14L,22L,5L,7L,19L,2L,-1L,12L,14L,16L,18L,11L,19L,7L,18L,31L,22L,31L,6L,5L,29L,6L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124609Inst : IEnumerable<long>
{
public static readonly long[] Value=A124609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124609.Bytes);
public long this[int i]=>Value[i];

public static A124609Inst Instance=new A124609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124610
{
public static readonly long[] Value={ 1L,1L,7L,37L,199L,1069L,5743L,30853L,165751L,890461L,4783807L,25699957L,138067399L,741736909L,3984819343L,21407570533L,115007491351L,617852597821L,3319277971807L,17832095054677L,95799031216999L,514659346194349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124610Inst : IEnumerable<long>
{
public static readonly long[] Value=A124610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124610.Bytes);
public long this[int i]=>Value[i];

public static A124610Inst Instance=new A124610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124611
{
public static readonly long[] Value={ 1L,3L,6L,7L,15L,9L,28L,21L,21L,17L,66L,21L,91L,27L,21L,73L,153L,39L,190L,37L,33L,53L,276L,63L,85L,69L,138L,55L,435L,33L,496L,273L,54L,107L,50L,129L,703L,129L,72L,107L,861L,51L,946L,97L,96L,179L,1128L,219L,217L,157L,99L,121L,1431L,273L,80L,153L,123L,269L,1770L,93L,1891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124611Inst : IEnumerable<long>
{
public static readonly long[] Value=A124611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124611.Bytes);
public long this[int i]=>Value[i];

public static A124611Inst Instance=new A124611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124612
{
public static readonly long[] Value={ 1L,2L,6L,14L,34L,68L,144L,276L,534L,974L,1774L,3106L,5410L,9146L,15334L,25158L,40884L,65264L,103204L,160808L,248222L,378350L,571534L,853890L,1264962L,1855638L,2700490L,3895626L,5577846L,7923072L,11176164L,15650712L,21774473L,30092868L,41337096L,56434524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124612Inst : IEnumerable<long>
{
public static readonly long[] Value=A124612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124612.Bytes);
public long this[int i]=>Value[i];

public static A124612Inst Instance=new A124612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124613
{
public static readonly long[] Value={ 1L,2L,6L,14L,34L,74L,159L,324L,657L,1286L,2488L,4702L,8790L,16146L,29326L,52526L,93064L,162910L,282267L,483792L,821182L,1380052L,2297972L,3791220L,6200379L,10053018L,16165158L,25782702L,40801449L,64075416L,99882597L,154577022L,237551012L,362577214L,549750200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124613Inst : IEnumerable<long>
{
public static readonly long[] Value=A124613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124613.Bytes);
public long this[int i]=>Value[i];

public static A124613Inst Instance=new A124613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124614
{
public static readonly long[] Value={ 1L,2L,6L,14L,34L,74L,166L,342L,716L,1442L,2898L,5686L,11122L,21366L,40842L,77098L,144581L,268376L,494812L,904056L,1640304L,2951812L,5274356L,9351868L,16465309L,28776074L,49943314L,86067486L,147313950L,250422502L,422885538L,709413626L,1182445150L,1958355754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124614Inst : IEnumerable<long>
{
public static readonly long[] Value=A124614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124614.Bytes);
public long this[int i]=>Value[i];

public static A124614Inst Instance=new A124614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124615
{
public static readonly long[] Value={ 1L,4L,14L,38L,93L,204L,419L,806L,1480L,2600L,4411L,7244L,11579L,18048L,27528L,41150L,60428L,87280L,124203L,174308L,241555L,330808L,448140L,600918L,798193L,1050820L,1371953L,1777210L,2285288L,2918188L,3701971L,4667052L,5849124L,7289536L,9036406L,11145104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124615Inst : IEnumerable<long>
{
public static readonly long[] Value=A124615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124615.Bytes);
public long this[int i]=>Value[i];

public static A124615Inst Instance=new A124615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124696
{
public static readonly long[] Value={ 1L,3L,7L,15L,35L,83L,199L,479L,1155L,2787L,6727L,16239L,39203L,94643L,228487L,551615L,1331715L,3215043L,7761799L,18738639L,45239075L,109216787L,263672647L,636562079L,1536796803L,3710155683L,8957108167L,21624372015L,52205852195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124696Inst : IEnumerable<long>
{
public static readonly long[] Value=A124696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124696.Bytes);
public long this[int i]=>Value[i];

public static A124696Inst Instance=new A124696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124697
{
public static readonly long[] Value={ 1L,4L,10L,22L,54L,134L,340L,872L,2254L,5854L,15250L,39802L,104004L,271964L,711490L,1861862L,4873054L,12755614L,33391060L,87413152L,228841254L,599099054L,1568437210L,4106182322L,10750060804L,28143920884L,73681573690L,192900592822L,505019869254L,1322158472054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124697Inst : IEnumerable<long>
{
public static readonly long[] Value=A124697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124697.Bytes);
public long this[int i]=>Value[i];

public static A124697Inst Instance=new A124697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124698
{
public static readonly long[] Value={ 1L,5L,13L,29L,73L,185L,481L,1265L,3361L,8993L,24193L,65345L,177025L,480641L,1307137L,3559169L,9699841L,26452481L,72173569L,196989953L,537802753L,1468536833L,4010582017L,10954043393L,29920862209L,81733033985L,223274237953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124698Inst : IEnumerable<long>
{
public static readonly long[] Value=A124698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124698.Bytes);
public long this[int i]=>Value[i];

public static A124698Inst Instance=new A124698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124699
{
public static readonly long[] Value={ 1L,6L,16L,36L,92L,236L,622L,1658L,4468L,12132L,33146L,90998L,250802L,693426L,1922118L,5339006L,14854932L,41387764L,115438672L,322267784L,900314242L,2516648618L,7038066876L,19690060024L,55102545322L,154241612986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124699Inst : IEnumerable<long>
{
public static readonly long[] Value=A124699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124699.Bytes);
public long this[int i]=>Value[i];

public static A124699Inst Instance=new A124699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124700
{
public static readonly long[] Value={ 1L,7L,19L,43L,111L,287L,763L,2051L,5575L,15271L,42099L,116651L,324591L,906367L,2538331L,7126403L,20049671L,56509639L,159514963L,450865067L,1275778031L,3613401695L,10242581819L,29053799555L,82461727687L,234163952487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124700Inst : IEnumerable<long>
{
public static readonly long[] Value=A124700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124700.Bytes);
public long this[int i]=>Value[i];

public static A124700Inst Instance=new A124700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124701
{
public static readonly long[] Value={ 1L,8L,22L,50L,130L,338L,904L,2444L,6682L,18410L,51052L,142304L,398380L,1119308L,3154558L,8914010L,25246282L,71644298L,203665054L,579841286L,1653025900L,4718011460L,13479908926L,38548802570L,110327691316L,315985475588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124701Inst : IEnumerable<long>
{
public static readonly long[] Value=A124701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124701.Bytes);
public long this[int i]=>Value[i];

public static A124701Inst Instance=new A124701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124702
{
public static readonly long[] Value={ 1L,9L,25L,57L,149L,389L,1045L,2837L,7789L,21549L,60005L,167957L,472169L,1332249L,3770785L,10701617L,30442909L,86779229L,247817845L,708837797L,2030401509L,5823331109L,16720830525L,48060737357L,138268935049L,398126270889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124702Inst : IEnumerable<long>
{
public static readonly long[] Value=A124702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124702.Bytes);
public long this[int i]=>Value[i];

public static A124702Inst Instance=new A124702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124703
{
public static readonly long[] Value={ 1L,10L,28L,64L,168L,440L,1186L,3230L,8896L,24688L,68958L,193610L,545958L,1545190L,4387012L,12489224L,35639536L,101914160L,291970654L,837834650L,2407780858L,6928681418L,19961961014L,57573920446L,166216938550L,480300958390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124703Inst : IEnumerable<long>
{
public static readonly long[] Value=A124703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124703.Bytes);
public long this[int i]=>Value[i];

public static A124703Inst Instance=new A124703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124704
{
public static readonly long[] Value={ 1L,11L,31L,71L,187L,491L,1327L,3623L,10003L,27827L,77911L,219263L,619747L,1758131L,5003239L,14276831L,40836163L,117049091L,336123463L,966831503L,2785160227L,8034032147L,23203096519L,67087148063L,194165268355L,562477731491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124704Inst : IEnumerable<long>
{
public static readonly long[] Value=A124704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124704.Bytes);
public long this[int i]=>Value[i];

public static A124704Inst Instance=new A124704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124705
{
public static readonly long[] Value={ 1L,12L,34L,78L,206L,542L,1468L,4016L,11110L,30966L,86864L,244916L,693536L,1971072L,5619466L,16064438L,46032790L,132184022L,380276272L,1095828356L,3162539596L,9139382876L,26444232046L,76600376186L,222113604712L,644654567192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124705Inst : IEnumerable<long>
{
public static readonly long[] Value=A124705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124705.Bytes);
public long this[int i]=>Value[i];

public static A124705Inst Instance=new A124705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124706
{
public static readonly long[] Value={ 1L,13L,37L,85L,225L,593L,1609L,4409L,12217L,34105L,95817L,270569L,767325L,2184013L,6235693L,17852045L,51229417L,147318953L,424429081L,1224825209L,3539918965L,10244733605L,29685367573L,86113604309L,250061941093L,726831403493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124706Inst : IEnumerable<long>
{
public static readonly long[] Value=A124706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124706.Bytes);
public long this[int i]=>Value[i];

public static A124706Inst Instance=new A124706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124707
{
public static readonly long[] Value={ 1L,14L,40L,92L,244L,644L,1750L,4802L,13324L,37244L,104770L,296222L,841114L,2396954L,6851920L,19639652L,56426044L,162453884L,468581890L,1353822062L,3917298334L,11350084334L,32926503100L,95626832432L,278010277474L,809008239794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124707Inst : IEnumerable<long>
{
public static readonly long[] Value=A124707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124707.Bytes);
public long this[int i]=>Value[i];

public static A124707Inst Instance=new A124707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124708
{
public static readonly long[] Value={ 1L,15L,43L,99L,263L,695L,1891L,5195L,14431L,40383L,113723L,321875L,914903L,2609895L,7468147L,21427259L,61622671L,177588815L,512734699L,1482818915L,4294677703L,12455435063L,36167638627L,105140060555L,305958613855L,891185076095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124708Inst : IEnumerable<long>
{
public static readonly long[] Value=A124708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124708.Bytes);
public long this[int i]=>Value[i];

public static A124708Inst Instance=new A124708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124709
{
public static readonly long[] Value={ 1L,16L,46L,106L,282L,746L,2032L,5588L,15538L,43522L,122676L,347528L,988692L,2822836L,8084374L,23214866L,66819298L,192723746L,556887508L,1611815768L,4672057072L,13560785792L,39408774154L,114653288678L,333906950236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124709Inst : IEnumerable<long>
{
public static readonly long[] Value=A124709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124709.Bytes);
public long this[int i]=>Value[i];

public static A124709Inst Instance=new A124709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124710
{
public static readonly long[] Value={ 1L,17L,49L,113L,301L,797L,2173L,5981L,16645L,46661L,131629L,373181L,1062481L,3035777L,8700601L,25002473L,72015925L,207858677L,601040317L,1740812621L,5049436441L,14666136521L,42649909681L,124166516801L,361855286617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124710Inst : IEnumerable<long>
{
public static readonly long[] Value=A124710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124710.Bytes);
public long this[int i]=>Value[i];

public static A124710Inst Instance=new A124710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124711
{
public static readonly long[] Value={ 1L,18L,52L,120L,320L,848L,2314L,6374L,17752L,49800L,140582L,398834L,1136270L,3248718L,9316828L,26790080L,77212552L,222993608L,645193126L,1869809474L,5426815810L,15771487250L,45891045208L,133679744924L,389803622998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124711Inst : IEnumerable<long>
{
public static readonly long[] Value=A124711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124711.Bytes);
public long this[int i]=>Value[i];

public static A124711Inst Instance=new A124711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124744
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,-2L,1L,0L,0L,0L,0L,1L,-2L,1L,0L,0L,0L,0L,0L,1L,-3L,1L,0L,0L,0L,0L,0L,0L,3L,-3L,1L,0L,0L,0L,0L,0L,0L,-1L,3L,-4L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,6L,-4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124744Inst : IEnumerable<long>
{
public static readonly long[] Value=A124744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124744.Bytes);
public long this[int i]=>Value[i];

public static A124744Inst Instance=new A124744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124745
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,-1L,0L,-1L,1L,-1L,2L,-2L,3L,-4L,5L,-7L,9L,-12L,16L,-21L,28L,-37L,49L,-65L,86L,-114L,151L,-200L,265L,-351L,465L,-616L,816L,-1081L,1432L,-1897L,2513L,-3329L,4410L,-5842L,7739L,-10252L,13581L,-17991L,23833L,-31572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124745Inst : IEnumerable<long>
{
public static readonly long[] Value=A124745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124745.Bytes);
public long this[int i]=>Value[i];

public static A124745Inst Instance=new A124745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124746
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,-1L,1L,-1L,1L,-2L,2L,-2L,2L,-3L,4L,-4L,4L,-5L,7L,-8L,8L,-9L,12L,-15L,16L,-17L,21L,-27L,31L,-33L,38L,-48L,58L,-64L,71L,-86L,106L,-122L,135L,-157L,192L,-228L,257L,-292L,349L,-420L,485L,-549L,641L,-769L,905L,-1034L,1190L,-1410L,1674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124746Inst : IEnumerable<long>
{
public static readonly long[] Value=A124746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124746.Bytes);
public long this[int i]=>Value[i];

public static A124746Inst Instance=new A124746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124747
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,2L,2L,2L,1L,0L,0L,3L,3L,3L,2L,1L,0L,0L,7L,7L,7L,5L,3L,1L,0L,0L,12L,12L,12L,9L,6L,3L,1L,0L,0L,30L,30L,30L,23L,16L,9L,4L,1L,0L,0L,55L,55L,55L,43L,31L,19L,10L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124747Inst : IEnumerable<long>
{
public static readonly long[] Value=A124747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124747.Bytes);
public long this[int i]=>Value[i];

public static A124747Inst Instance=new A124747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124748
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,1L,0L,3L,2L,2L,2L,1L,1L,1L,0L,4L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,0L,5L,4L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,0L,6L,5L,5L,5L,5L,5L,5L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124748Inst : IEnumerable<long>
{
public static readonly long[] Value=A124748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124748.Bytes);
public long this[int i]=>Value[i];

public static A124748Inst Instance=new A124748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124749
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,0L,-2L,1L,0L,0L,0L,0L,0L,0L,1L,-2L,1L,0L,0L,0L,0L,0L,0L,0L,1L,-2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124749Inst : IEnumerable<long>
{
public static readonly long[] Value=A124749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124749.Bytes);
public long this[int i]=>Value[i];

public static A124749Inst Instance=new A124749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124750
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,0L,0L,-1L,0L,0L,-1L,1L,0L,-1L,2L,-1L,-1L,3L,-3L,0L,4L,-6L,3L,4L,-10L,9L,1L,-14L,19L,-8L,-15L,33L,-27L,-7L,48L,-60L,20L,55L,-108L,80L,35L,-163L,188L,-45L,-198L,351L,-233L,-153L,549L,-584L,80L,702L,-1133L,664L,622L,-1835L,1797L,-42L,-2457L,3632L,-1839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124750Inst : IEnumerable<long>
{
public static readonly long[] Value=A124750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124750.Bytes);
public long this[int i]=>Value[i];

public static A124750Inst Instance=new A124750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124751
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,-1L,1L,-1L,1L,-1L,1L,-2L,2L,-2L,2L,-2L,2L,-3L,4L,-4L,4L,-4L,4L,-5L,7L,-8L,8L,-8L,8L,-9L,12L,-15L,16L,-16L,16L,-17L,21L,-27L,31L,-32L,32L,-33L,38L,-48L,58L,-63L,64L,-65L,71L,-86L,106L,-121L,127L,-129L,136L,-157L,192L,-227L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124751Inst : IEnumerable<long>
{
public static readonly long[] Value=A124751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124751.Bytes);
public long this[int i]=>Value[i];

public static A124751Inst Instance=new A124751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124752
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,2L,2L,2L,2L,1L,0L,0L,0L,3L,3L,3L,3L,2L,1L,0L,0L,0L,4L,4L,4L,4L,3L,2L,1L,0L,0L,0L,9L,9L,9L,9L,7L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124752Inst : IEnumerable<long>
{
public static readonly long[] Value=A124752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124752.Bytes);
public long this[int i]=>Value[i];

public static A124752Inst Instance=new A124752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124753
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,9L,15L,22L,52L,91L,140L,340L,612L,969L,2394L,4389L,7084L,17710L,32890L,53820L,135720L,254475L,420732L,1068012L,2017356L,3362260L,8579560L,16301164L,27343888L,70068713L,133767543L,225568798L,580034052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124753Inst : IEnumerable<long>
{
public static readonly long[] Value=A124753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124753.Bytes);
public long this[int i]=>Value[i];

public static A124753Inst Instance=new A124753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124754
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,1L,-1L,1L,4L,2L,0L,2L,-2L,0L,2L,0L,5L,3L,1L,3L,-1L,1L,3L,1L,-3L,-1L,1L,-1L,3L,1L,-1L,1L,6L,4L,2L,4L,0L,2L,4L,2L,-2L,0L,2L,0L,4L,2L,0L,2L,-4L,-2L,0L,-2L,2L,0L,-2L,0L,4L,2L,0L,2L,-2L,0L,2L,0L,7L,5L,3L,5L,1L,3L,5L,3L,-1L,1L,3L,1L,5L,3L,1L,3L,-3L,-1L,1L,-1L,3L,1L,-1L,1L,5L,3L,1L,3L,-1L,1L,3L,1L,-5L,-3L,-1L,-3L,1L,-1L,-3L,-1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124754Inst : IEnumerable<long>
{
public static readonly long[] Value=A124754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124754.Bytes);
public long this[int i]=>Value[i];

public static A124754Inst Instance=new A124754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124755
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,4L,6L,5L,8L,5L,5L,5L,6L,5L,7L,6L,9L,5L,8L,7L,11L,6L,11L,9L,16L,6L,6L,6L,7L,6L,8L,7L,10L,6L,9L,8L,12L,7L,12L,10L,17L,6L,10L,9L,14L,8L,14L,12L,20L,7L,14L,12L,22L,10L,20L,17L,32L,7L,7L,7L,8L,7L,9L,8L,11L,7L,10L,9L,13L,8L,13L,11L,18L,7L,11L,10L,15L,9L,15L,13L,21L,8L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124755Inst : IEnumerable<long>
{
public static readonly long[] Value=A124755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124755.Bytes);
public long this[int i]=>Value[i];

public static A124755Inst Instance=new A124755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124756
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,1L,-1L,0L,4L,2L,0L,1L,-2L,-2L,1L,0L,5L,3L,1L,2L,-1L,-1L,2L,1L,-3L,-4L,-1L,-3L,2L,3L,-1L,0L,6L,4L,2L,3L,0L,0L,3L,2L,-2L,-3L,0L,-2L,3L,4L,0L,1L,-4L,-6L,-3L,-6L,0L,0L,-4L,-4L,3L,6L,2L,6L,-2L,-4L,1L,0L,7L,5L,3L,4L,1L,1L,4L,3L,-1L,-2L,1L,-1L,4L,5L,1L,2L,-3L,-5L,-2L,-5L,1L,1L,-3L,-3L,4L,7L,3L,7L,-1L,-3L,2L,1L,-5L,-8L,-5L,-9L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124756Inst : IEnumerable<long>
{
public static readonly long[] Value=A124756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124756.Bytes);
public long this[int i]=>Value[i];

public static A124756Inst Instance=new A124756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124757
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,2L,3L,0L,1L,2L,3L,3L,4L,5L,6L,0L,1L,2L,3L,3L,4L,5L,6L,4L,5L,6L,7L,7L,8L,9L,10L,0L,1L,2L,3L,3L,4L,5L,6L,4L,5L,6L,7L,7L,8L,9L,10L,5L,6L,7L,8L,8L,9L,10L,11L,9L,10L,11L,12L,12L,13L,14L,15L,0L,1L,2L,3L,3L,4L,5L,6L,4L,5L,6L,7L,7L,8L,9L,10L,5L,6L,7L,8L,8L,9L,10L,11L,9L,10L,11L,12L,12L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124757Inst : IEnumerable<long>
{
public static readonly long[] Value=A124757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124757.Bytes);
public long this[int i]=>Value[i];

public static A124757Inst Instance=new A124757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124758
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,2L,1L,4L,3L,4L,2L,3L,2L,2L,1L,5L,4L,6L,3L,6L,4L,4L,2L,4L,3L,4L,2L,3L,2L,2L,1L,6L,5L,8L,4L,9L,6L,6L,3L,8L,6L,8L,4L,6L,4L,4L,2L,5L,4L,6L,3L,6L,4L,4L,2L,4L,3L,4L,2L,3L,2L,2L,1L,7L,6L,10L,5L,12L,8L,8L,4L,12L,9L,12L,6L,9L,6L,6L,3L,10L,8L,12L,6L,12L,8L,8L,4L,8L,6L,8L,4L,6L,4L,4L,2L,6L,5L,8L,4L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124758Inst : IEnumerable<long>
{
public static readonly long[] Value=A124758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124758.Bytes);
public long this[int i]=>Value[i];

public static A124758Inst Instance=new A124758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124759
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,2L,2L,0L,3L,4L,3L,3L,4L,3L,3L,0L,4L,6L,4L,6L,6L,4L,4L,4L,6L,6L,5L,4L,5L,4L,4L,0L,5L,8L,5L,9L,8L,5L,5L,8L,9L,8L,7L,5L,6L,5L,5L,5L,8L,9L,7L,8L,8L,6L,6L,5L,7L,7L,6L,5L,6L,5L,5L,0L,6L,10L,6L,12L,10L,6L,6L,12L,12L,10L,9L,6L,7L,6L,6L,10L,12L,12L,10L,10L,10L,8L,8L,6L,8L,8L,7L,6L,7L,6L,6L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124759Inst : IEnumerable<long>
{
public static readonly long[] Value=A124759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124759.Bytes);
public long this[int i]=>Value[i];

public static A124759Inst Instance=new A124759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124792
{
public static readonly long[] Value={ 18L,42L,50L,78L,92L,110L,130L,138L,154L,164L,222L,230L,236L,266L,282L,284L,285L,338L,357L,366L,370L,374L,404L,425L,426L,429L,430L,438L,452L,555L,574L,582L,590L,596L,602L,605L,610L,637L,638L,654L,668L,682L,710L,754L,764L,782L,814L,826L,854L,874L,894L,908L,938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124792Inst : IEnumerable<long>
{
public static readonly long[] Value=A124792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124792.Bytes);
public long this[int i]=>Value[i];

public static A124792Inst Instance=new A124792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124793
{
public static readonly long[] Value={ 1L,5L,35L,157L,1123L,5021L,35939L,160669L,1150051L,5141405L,36801635L,164524957L,1177652323L,5264798621L,37684874339L,168473555869L,1205915978851L,5391153787805L,38589311323235L,172516921209757L,1234857962343523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124793Inst : IEnumerable<long>
{
public static readonly long[] Value=A124793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124793.Bytes);
public long this[int i]=>Value[i];

public static A124793Inst Instance=new A124793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124794
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,3L,4L,1L,6L,1L,5L,10L,1L,1L,15L,1L,10L,15L,6L,1L,10L,10L,7L,15L,15L,1L,60L,1L,1L,21L,8L,35L,45L,1L,9L,28L,20L,1L,105L,1L,21L,105L,10L,1L,15L,35L,70L,36L,28L,1L,105L,56L,35L,45L,11L,1L,210L,1L,12L,210L,1L,84L,168L,1L,36L,55L,280L,1L,105L,1L,13L,280L,45L,126L,252L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124794Inst : IEnumerable<long>
{
public static readonly long[] Value=A124794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124794.Bytes);
public long this[int i]=>Value[i];

public static A124794Inst Instance=new A124794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124795
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,6L,1L,3L,8L,24L,6L,120L,30L,20L,1L,720L,15L,5040L,20L,90L,144L,40320L,10L,40L,840L,15L,90L,362880L,120L,3628800L,1L,504L,5760L,420L,45L,39916800L,45360L,3360L,40L,479001600L,630L,6227020800L,504L,210L,403200L,87178291200L,15L,1260L,280L,25920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124795Inst : IEnumerable<long>
{
public static readonly long[] Value=A124795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124795.Bytes);
public long this[int i]=>Value[i];

public static A124795Inst Instance=new A124795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124796
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,3L,0L,1L,1L,1L,0L,6L,0L,0L,0L,1L,0L,7L,0L,4L,0L,0L,0L,10L,0L,0L,1L,1L,0L,4L,0L,1L,0L,0L,0L,25L,0L,0L,0L,10L,0L,0L,0L,0L,0L,0L,0L,15L,0L,0L,0L,0L,0L,15L,0L,5L,0L,0L,0L,30L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,65L,0L,0L,0L,0L,0L,0L,0L,20L,1L,0L,0L,7L,0L,0L,0L,1L,0L,11L,0L,0L,0L,0L,0L,21L,0L,0L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124796Inst : IEnumerable<long>
{
public static readonly long[] Value=A124796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124796.Bytes);
public long this[int i]=>Value[i];

public static A124796Inst Instance=new A124796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124797
{
public static readonly BigInteger[] Value={ 1L,12L,126L,1560L,23325L,411768L,8388604L,193710240L,4999999995L,142655835300L,4458050224122L,151437553296120L,5556003412779001L,218946945190429680L,9223372036854775800L,BigInteger.Parse("413620130943168382080"),BigInteger.Parse("19673204037648268787703") };
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
public class A124797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124797Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A124797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124797.Bytes);
public BigInteger this[int i]=>Value[i];

public static A124797Inst Instance=new A124797Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124798
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,3L,3L,1L,0L,2L,2L,2L,2L,3L,5L,5L,5L,5L,2L,0L,3L,3L,3L,3L,3L,3L,4L,7L,7L,7L,7L,7L,7L,3L,0L,4L,4L,4L,4L,4L,4L,4L,4L,5L,9L,9L,9L,9L,9L,9L,9L,9L,4L,0L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,5L,0L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,13L,13L,13L,13L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124798Inst : IEnumerable<long>
{
public static readonly long[] Value=A124798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124798.Bytes);
public long this[int i]=>Value[i];

public static A124798Inst Instance=new A124798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124799
{
public static readonly long[] Value={ 1L,30L,88L,204L,548L,1460L,4006L,11090L,31036L,87468L,248018L,706670L,2021738L,5804010L,16711552L,48241364L,139572076L,404612780L,1175026834L,3417771710L,9955368238L,29035695998L,84784671532L,247838482400L,725183659570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124799Inst : IEnumerable<long>
{
public static readonly long[] Value=A124799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124799.Bytes);
public long this[int i]=>Value[i];

public static A124799Inst Instance=new A124799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124800
{
public static readonly long[] Value={ 2L,2L,1L,2L,2L,1L,2L,3L,3L,-1L,2L,4L,6L,-4L,3L,2L,5L,10L,-10L,15L,-9L,2L,6L,15L,-20L,45L,-54L,23L,2L,7L,21L,-35L,105L,-189L,161L,-53L,2L,8L,28L,-56L,210L,-504L,644L,-424L,115L,2L,9L,36L,-84L,378L,-1134L,1932L,-1908L,1035L,-237L,2L,10L,45L,-120L,630L,-2268L,4830L,-6360L,5175L,-2370L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124800Inst : IEnumerable<long>
{
public static readonly long[] Value=A124800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124800.Bytes);
public long this[int i]=>Value[i];

public static A124800Inst Instance=new A124800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124801
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,3L,-1L,1L,0L,6L,-4L,1L,1L,0L,10L,-10L,10L,-3L,1L,0L,15L,-20L,30L,-18L,5L,1L,0L,21L,-35L,70L,-63L,35L,-8L,1L,0L,28L,-56L,140L,-168L,140L,-64L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124801Inst : IEnumerable<long>
{
public static readonly long[] Value=A124801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124801.Bytes);
public long this[int i]=>Value[i];

public static A124801Inst Instance=new A124801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124802
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,-1L,1L,6L,-4L,2L,1L,10L,-10L,10L,-3L,1L,15L,-20L,30L,-18L,5L,1L,21L,-35L,70L,-63L,35L,-8L,1L,28L,-56L,140L,-168L,140L,-64L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124802Inst : IEnumerable<long>
{
public static readonly long[] Value=A124802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124802.Bytes);
public long this[int i]=>Value[i];

public static A124802Inst Instance=new A124802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124803
{
public static readonly long[] Value={ 1L,31L,91L,211L,567L,1511L,4147L,11483L,32143L,90607L,256971L,732323L,2095527L,6016951L,17327779L,50028971L,144768703L,419747711L,1219179643L,3546768563L,10332747607L,30141046727L,88025807059L,257351710523L,753131995951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124803Inst : IEnumerable<long>
{
public static readonly long[] Value=A124803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124803.Bytes);
public long this[int i]=>Value[i];

public static A124803Inst Instance=new A124803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124804
{
public static readonly long[] Value={ 1L,32L,94L,218L,586L,1562L,4288L,11876L,33250L,93746L,265924L,757976L,2169316L,6229892L,17944006L,51816578L,149965330L,434882642L,1263332452L,3675765416L,10710126976L,31246397456L,91266942586L,266864938646L,781080332332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124804Inst : IEnumerable<long>
{
public static readonly long[] Value=A124804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124804.Bytes);
public long this[int i]=>Value[i];

public static A124804Inst Instance=new A124804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124805
{
public static readonly long[] Value={ 1L,4L,14L,46L,162L,574L,2042L,7270L,25890L,92206L,328394L,1169590L,4165554L,14835838L,52838618L,188187526L,670239810L,2387094478L,8501763050L,30279478102L,107841960402L,384084837406L,1367938433018L,4871984973862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124805Inst : IEnumerable<long>
{
public static readonly long[] Value=A124805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124805.Bytes);
public long this[int i]=>Value[i];

public static A124805Inst Instance=new A124805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124806
{
public static readonly long[] Value={ 1L,5L,19L,65L,247L,955L,3733L,14649L,57583L,226505L,891219L,3507047L,13801285L,54313277L,213745019L,841177105L,3310392415L,13027820227L,51270096661L,201769982673L,794052091767L,3124938240153L,12297982928987L,48397879544975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124806Inst : IEnumerable<long>
{
public static readonly long[] Value=A124806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124806.Bytes);
public long this[int i]=>Value[i];

public static A124806Inst Instance=new A124806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124807
{
public static readonly long[] Value={ 1L,6L,24L,84L,332L,1336L,5478L,22658L,94196L,392664L,1639274L,6849002L,28627874L,119688094L,500456806L,2092720174L,8751273556L,36596513060L,153042707976L,640011807436L,2676483843602L,11192882945426L,46807955443900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124807Inst : IEnumerable<long>
{
public static readonly long[] Value=A124807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124807.Bytes);
public long this[int i]=>Value[i];

public static A124807Inst Instance=new A124807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124840
{
public static readonly long[] Value={ 1L,1L,-2L,1L,-4L,2L,1L,-6L,6L,-1L,1L,-8L,12L,-4L,-2L,1L,-10L,20L,-10L,-10L,10L,1L,-12L,30L,-20L,-30L,60L,-30L,1L,-14L,42L,-35L,-70L,210L,-210L,76L,1L,-16L,46L,-56L,-140L,560L,-840L,608L,-173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124840Inst : IEnumerable<long>
{
public static readonly long[] Value=A124840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124840.Bytes);
public long this[int i]=>Value[i];

public static A124840Inst Instance=new A124840Inst();

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