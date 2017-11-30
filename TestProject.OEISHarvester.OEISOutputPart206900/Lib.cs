using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A245282
{
public static readonly long[] Value={ 1L,3L,4L,8L,9L,19L,22L,42L,59L,100L,145L,257L,378L,634L,999L,1639L,2585L,4255L,6766L,11051L,17736L,28804L,46369L,75316L,121402L,196798L,317870L,514868L,832041L,1347372L,2178310L,3526217L,5703035L,9230052L,14930382L,24162310L,39088170L,63252754L,102334536L,165591226L,267914297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245282Inst : IEnumerable<long>
{
public static readonly long[] Value=A245282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245282.Bytes);
public long this[int i]=>Value[i];

public static A245282Inst Instance=new A245282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245283
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,6L,48L,2592L,3421440L,1952520007680L,BigInteger.Parse("79423772100432548659200"),BigInteger.Parse("2433694280407609647520301298079459442688000"),BigInteger.Parse("1731103819002733625504286414686785477293241305893841298989509923950758461440000") };
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
public class A245283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245283Inst Instance=new A245283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245284
{
public static readonly long[] Value={ 55L,85L,91L,105L,115L,133L,140L,145L,187L,195L,204L,205L,217L,231L,235L,247L,253L,259L,265L,275L,285L,295L,301L,319L,351L,355L,357L,385L,391L,403L,415L,425L,427L,429L,445L,451L,465L,469L,476L,481L,483L,493L,505L,511L,517L,535L,553L,555L,559L,565L,575L,583L,589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245284Inst : IEnumerable<long>
{
public static readonly long[] Value=A245284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245284.Bytes);
public long this[int i]=>Value[i];

public static A245284Inst Instance=new A245284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245285
{
public static readonly long[] Value={ 2L,6L,18L,52L,145L,400L,1093L,2977L,8098L,22021L,59868L,162748L,442406L,1202597L,3269009L,8886102L,24154944L,65659960L,178482291L,485165185L,1318815724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245285Inst : IEnumerable<long>
{
public static readonly long[] Value=A245285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245285.Bytes);
public long this[int i]=>Value[i];

public static A245285Inst Instance=new A245285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245286
{
public static readonly long[] Value={ 2L,2L,7L,4L,3L,2L,2L,3L,5L,0L,9L,7L,9L,9L,3L,7L,1L,1L,8L,1L,6L,0L,6L,4L,4L,3L,1L,2L,0L,6L,6L,9L,7L,8L,3L,9L,8L,9L,6L,6L,6L,2L,8L,5L,6L,7L,9L,9L,0L,1L,0L,6L,9L,7L,1L,8L,0L,6L,1L,1L,9L,9L,1L,7L,1L,4L,8L,4L,6L,4L,8L,1L,7L,0L,5L,8L,8L,1L,1L,5L,3L,1L,4L,8L,7L,0L,3L,6L,5L,9L,4L,6L,4L,5L,5L,2L,1L,0L,9L,2L,2L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245286Inst : IEnumerable<long>
{
public static readonly long[] Value=A245286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245286.Bytes);
public long this[int i]=>Value[i];

public static A245286Inst Instance=new A245286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245287
{
public static readonly long[] Value={ 2L,9L,7L,9L,6L,3L,3L,9L,0L,5L,9L,8L,6L,2L,2L,1L,7L,4L,4L,7L,9L,5L,5L,1L,2L,3L,3L,8L,0L,1L,6L,1L,4L,9L,7L,0L,6L,6L,9L,4L,2L,2L,8L,7L,8L,2L,8L,7L,7L,1L,3L,6L,3L,1L,2L,2L,0L,8L,1L,2L,5L,8L,3L,7L,8L,6L,2L,0L,4L,5L,9L,5L,5L,5L,5L,2L,8L,0L,8L,1L,1L,6L,6L,6L,3L,5L,6L,5L,8L,2L,0L,5L,4L,6L,3L,5L,1L,9L,2L,2L,0L,6L,5L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245287Inst : IEnumerable<long>
{
public static readonly long[] Value=A245287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245287.Bytes);
public long this[int i]=>Value[i];

public static A245287Inst Instance=new A245287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245288
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,3L,12L,6L,22L,10L,35L,15L,51L,21L,70L,28L,92L,36L,117L,45L,145L,55L,176L,66L,210L,78L,247L,91L,287L,105L,330L,120L,376L,136L,425L,153L,477L,171L,532L,190L,590L,210L,651L,231L,715L,253L,782L,276L,852L,300L,925L,325L,1001L,351L,1080L,378L,1162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245288Inst : IEnumerable<long>
{
public static readonly long[] Value=A245288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245288.Bytes);
public long this[int i]=>Value[i];

public static A245288Inst Instance=new A245288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245289
{
public static readonly long[] Value={ 2L,6L,14L,17L,19L,22L,26L,30L,34L,38L,42L,53L,55L,58L,66L,70L,78L,86L,89L,91L,94L,102L,106L,110L,114L,130L,138L,142L,158L,161L,163L,166L,170L,178L,182L,186L,194L,197L,199L,202L,210L,214L,218L,222L,230L,233L,235L,238L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245289Inst : IEnumerable<long>
{
public static readonly long[] Value=A245289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245289.Bytes);
public long this[int i]=>Value[i];

public static A245289Inst Instance=new A245289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245290
{
public static readonly BigInteger[] Value={ 1L,31L,5119L,9961471L,259577085951L,94554701453852671L,BigInteger.Parse("494214691850093043122175"),BigInteger.Parse("37747948215762478445361018961919"),BigInteger.Parse("42694960288928350006693371507341885702143"),BigInteger.Parse("722273364120299921501331975953872089285372151857151") };
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
public class A245290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245290Inst Instance=new A245290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245291
{
public static readonly BigInteger[] Value={ 0L,32L,27648L,258473984L,34924795002880L,BigInteger.Parse("73692421593384353792"),BigInteger.Parse("2475385863878910456755126272"),BigInteger.Parse("1329190247836700110425361699261382656"),BigInteger.Parse("11417938846687390120116281062224453749176270848"),BigInteger.Parse("1569274711573306070659025854469940650153499575743856771072") };
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
public class A245291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245291Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245291.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245291Inst Instance=new A245291Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245292
{
public static readonly long[] Value={ 0L,0L,9L,5L,8L,1L,9L,3L,0L,2L,6L,7L,8L,3L,9L,3L,1L,7L,5L,4L,9L,0L,2L,3L,2L,9L,3L,2L,1L,0L,7L,7L,8L,4L,3L,8L,7L,5L,8L,6L,9L,4L,4L,9L,5L,2L,9L,7L,3L,8L,5L,5L,1L,6L,1L,5L,7L,1L,3L,5L,2L,1L,6L,9L,3L,5L,8L,2L,0L,7L,3L,6L,1L,0L,2L,0L,2L,6L,7L,8L,4L,9L,1L,1L,2L,8L,8L,1L,7L,9L,0L,6L,6L,8L,7L,9L,5L,0L,8L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245292Inst : IEnumerable<long>
{
public static readonly long[] Value=A245292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245292.Bytes);
public long this[int i]=>Value[i];

public static A245292Inst Instance=new A245292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245293
{
public static readonly long[] Value={ 1L,0L,8L,0L,9L,6L,0L,1L,2L,3L,8L,4L,5L,6L,2L,7L,5L,1L,5L,1L,8L,8L,0L,8L,0L,1L,5L,0L,6L,3L,6L,5L,4L,5L,6L,4L,9L,2L,3L,7L,5L,7L,7L,0L,7L,4L,7L,2L,5L,5L,2L,3L,4L,3L,8L,0L,1L,3L,5L,6L,6L,4L,4L,2L,5L,9L,2L,7L,5L,9L,9L,0L,9L,7L,9L,0L,6L,6L,8L,5L,7L,2L,5L,0L,6L,8L,4L,8L,1L,8L,1L,1L,2L,7L,0L,7L,0L,7L,6L,1L,6L,1L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245293Inst : IEnumerable<long>
{
public static readonly long[] Value=A245293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245293.Bytes);
public long this[int i]=>Value[i];

public static A245293Inst Instance=new A245293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245294
{
public static readonly long[] Value={ 1L,0L,9L,5L,4L,4L,5L,1L,1L,5L,0L,1L,0L,3L,3L,2L,2L,2L,6L,9L,1L,3L,9L,3L,9L,5L,6L,5L,6L,0L,1L,6L,0L,4L,2L,6L,7L,9L,0L,5L,4L,8L,9L,3L,8L,9L,9L,9L,5L,9L,6L,6L,5L,0L,8L,4L,5L,3L,7L,8L,8L,8L,9L,9L,4L,6L,4L,9L,8L,6L,5L,5L,4L,2L,4L,5L,4L,4L,5L,4L,6L,7L,6L,0L,1L,7L,1L,6L,8L,7L,2L,3L,2L,7L,7L,4L,1L,2L,5L,1L,5L,2L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245294Inst : IEnumerable<long>
{
public static readonly long[] Value=A245294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245294.Bytes);
public long this[int i]=>Value[i];

public static A245294Inst Instance=new A245294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245295
{
public static readonly long[] Value={ 1L,4L,8L,0L,1L,6L,5L,6L,0L,8L,9L,8L,4L,5L,7L,0L,5L,0L,1L,1L,3L,3L,5L,7L,9L,9L,3L,2L,3L,2L,7L,6L,7L,3L,6L,3L,8L,5L,9L,8L,1L,2L,3L,5L,8L,2L,6L,1L,2L,3L,7L,6L,2L,3L,6L,6L,4L,9L,7L,2L,4L,8L,1L,1L,8L,3L,1L,4L,9L,3L,3L,7L,3L,1L,5L,9L,9L,2L,3L,0L,5L,2L,4L,0L,8L,8L,8L,3L,9L,0L,3L,8L,0L,3L,7L,6L,7L,9L,7L,3L,4L,5L,1L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245295Inst : IEnumerable<long>
{
public static readonly long[] Value=A245295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245295.Bytes);
public long this[int i]=>Value[i];

public static A245295Inst Instance=new A245295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245296
{
public static readonly long[] Value={ 1L,0L,4L,4L,2L,5L,7L,9L,0L,9L,3L,0L,9L,7L,9L,5L,1L,4L,3L,4L,4L,5L,3L,6L,9L,6L,1L,7L,1L,5L,5L,7L,0L,2L,5L,8L,3L,0L,8L,0L,4L,2L,0L,8L,0L,4L,2L,0L,2L,5L,3L,7L,2L,0L,7L,7L,5L,7L,6L,1L,3L,4L,1L,5L,8L,0L,0L,2L,3L,2L,5L,8L,8L,8L,0L,0L,6L,2L,3L,5L,7L,8L,8L,7L,4L,4L,6L,0L,2L,0L,1L,1L,1L,9L,2L,2L,0L,2L,7L,8L,5L,4L,7L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245296Inst : IEnumerable<long>
{
public static readonly long[] Value=A245296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245296.Bytes);
public long this[int i]=>Value[i];

public static A245296Inst Instance=new A245296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245297
{
public static readonly long[] Value={ 1L,1L,1L,6L,6L,4L,5L,9L,7L,1L,1L,0L,3L,8L,0L,9L,8L,8L,2L,6L,4L,5L,7L,1L,5L,4L,5L,1L,0L,7L,3L,1L,5L,3L,1L,7L,8L,9L,6L,6L,5L,1L,2L,0L,0L,6L,6L,9L,7L,4L,0L,4L,0L,1L,6L,4L,5L,6L,3L,4L,2L,1L,6L,0L,6L,0L,8L,1L,7L,9L,5L,2L,8L,6L,4L,8L,5L,2L,2L,2L,9L,6L,8L,4L,6L,4L,6L,0L,0L,2L,6L,2L,2L,4L,5L,4L,9L,9L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245297Inst : IEnumerable<long>
{
public static readonly long[] Value=A245297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245297.Bytes);
public long this[int i]=>Value[i];

public static A245297Inst Instance=new A245297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245298
{
public static readonly long[] Value={ 1L,1L,1L,9L,4L,2L,3L,7L,3L,1L,7L,3L,5L,1L,0L,7L,6L,1L,1L,6L,2L,9L,7L,1L,1L,0L,8L,2L,0L,8L,1L,2L,6L,1L,0L,4L,1L,2L,4L,9L,9L,8L,5L,5L,6L,7L,0L,5L,8L,6L,0L,7L,0L,8L,6L,5L,2L,0L,9L,8L,2L,7L,9L,9L,1L,3L,1L,5L,4L,2L,2L,9L,2L,2L,9L,6L,9L,0L,4L,5L,1L,5L,2L,5L,2L,6L,2L,8L,6L,5L,9L,6L,1L,3L,0L,8L,5L,2L,2L,9L,2L,9L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245298Inst : IEnumerable<long>
{
public static readonly long[] Value=A245298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245298.Bytes);
public long this[int i]=>Value[i];

public static A245298Inst Instance=new A245298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245299
{
public static readonly long[] Value={ 1L,4L,9L,6L,2L,7L,7L,8L,6L,9L,7L,3L,8L,8L,4L,4L,7L,3L,8L,5L,0L,8L,1L,0L,2L,1L,3L,9L,3L,2L,9L,7L,8L,2L,5L,5L,3L,3L,1L,7L,0L,0L,6L,2L,4L,7L,0L,9L,3L,2L,5L,4L,1L,0L,3L,0L,8L,7L,5L,6L,8L,6L,3L,9L,5L,0L,3L,6L,8L,0L,0L,9L,7L,2L,0L,4L,5L,0L,0L,4L,3L,3L,7L,4L,5L,7L,0L,3L,5L,8L,1L,0L,9L,0L,8L,3L,9L,6L,3L,9L,6L,9L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245299Inst : IEnumerable<long>
{
public static readonly long[] Value=A245299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245299.Bytes);
public long this[int i]=>Value[i];

public static A245299Inst Instance=new A245299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245300
{
public static readonly long[] Value={ 0L,1L,4L,3L,7L,12L,6L,11L,17L,24L,10L,16L,23L,31L,40L,15L,22L,30L,39L,49L,60L,21L,29L,38L,48L,59L,71L,84L,28L,37L,47L,58L,70L,83L,97L,112L,36L,46L,57L,69L,82L,96L,111L,127L,144L,45L,56L,68L,81L,95L,110L,126L,143L,161L,180L,55L,67L,80L,94L,109L,125L,142L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245300Inst : IEnumerable<long>
{
public static readonly long[] Value=A245300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245300.Bytes);
public long this[int i]=>Value[i];

public static A245300Inst Instance=new A245300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245301
{
public static readonly long[] Value={ 0L,5L,22L,58L,120L,215L,350L,532L,768L,1065L,1430L,1870L,2392L,3003L,3710L,4520L,5440L,6477L,7638L,8930L,10360L,11935L,13662L,15548L,17600L,19825L,22230L,24822L,27608L,30595L,33790L,37200L,40832L,44693L,48790L,53130L,57720L,62567L,67678L,73060L,78720L,84665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245301Inst : IEnumerable<long>
{
public static readonly long[] Value=A245301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245301.Bytes);
public long this[int i]=>Value[i];

public static A245301Inst Instance=new A245301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245302
{
public static readonly long[] Value={ 3L,5L,9L,13L,19L,25L,32L,39L,48L,57L,67L,78L,90L,103L,116L,130L,145L,161L,178L,195L,213L,232L,252L,273L,294L,317L,340L,364L,388L,414L,440L,467L,495L,524L,554L,584L,615L,647L,680L,714L,748L,783L,820L,856L,894L,933L,972L,1012L,1053L,1095L,1137L,1181L,1225L,1270L,1316L,1362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245302Inst : IEnumerable<long>
{
public static readonly long[] Value=A245302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245302.Bytes);
public long this[int i]=>Value[i];

public static A245302Inst Instance=new A245302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245303
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,11L,12L,13L,16L,17L,18L,19L,20L,23L,24L,27L,28L,29L,31L,32L,37L,40L,41L,43L,44L,45L,47L,48L,50L,52L,53L,54L,56L,59L,61L,63L,64L,67L,68L,71L,72L,73L,75L,76L,79L,80L,81L,83L,88L,89L,92L,96L,97L,98L,99L,101L,103L,104L,107L,108L,109L,112L,113L,116L,117L,124L,125L,127L,128L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245303Inst : IEnumerable<long>
{
public static readonly long[] Value=A245303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245303.Bytes);
public long this[int i]=>Value[i];

public static A245303Inst Instance=new A245303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245304
{
public static readonly long[] Value={ 4L,10L,100L,1480L,16060L,19420L,21010L,22270L,43780L,55330L,144160L,165700L,166840L,195730L,201820L,225340L,247600L,268810L,326140L,347980L,361210L,397750L,465160L,518800L,536440L,633460L,633790L,661090L,768190L,795790L,829720L,857950L,876010L,958540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245304Inst : IEnumerable<long>
{
public static readonly long[] Value=A245304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245304.Bytes);
public long this[int i]=>Value[i];

public static A245304Inst Instance=new A245304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245305
{
public static readonly long[] Value={ 1L,4L,7L,37L,142L,154L,202L,214L,307L,424L,469L,487L,499L,559L,577L,664L,742L,814L,847L,979L,982L,1054L,1129L,1159L,1162L,1252L,1369L,1522L,1612L,1642L,1672L,1837L,1987L,2107L,2134L,2149L,2209L,2242L,2359L,2407L,2419L,2482L,2632L,2677L,2767L,2887L,2929L,2944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245305Inst : IEnumerable<long>
{
public static readonly long[] Value=A245305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245305.Bytes);
public long this[int i]=>Value[i];

public static A245305Inst Instance=new A245305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245306
{
public static readonly long[] Value={ 1L,2L,2L,5L,10L,26L,65L,170L,442L,1157L,3026L,7922L,20737L,54290L,142130L,372101L,974170L,2550410L,6677057L,17480762L,45765226L,119814917L,313679522L,821223650L,2149991425L,5628750626L,14736260450L,38580030725L,101003831722L,264431464442L,692290561601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245306Inst : IEnumerable<long>
{
public static readonly long[] Value=A245306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245306.Bytes);
public long this[int i]=>Value[i];

public static A245306Inst Instance=new A245306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245307
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,77L,771L,9258L,127656L,1969366L,33422650L,616779303L,12272428173L,261620716744L,5945330149226L,143439343672519L,3661506704040203L,98597706579694403L,2793561790527733313L,BigInteger.Parse("83084652845766283317"),BigInteger.Parse("2588418449175558698525"),BigInteger.Parse("84305591450606402889544") };
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
public class A245307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245307Inst Instance=new A245307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245308
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,205L,3501L,90271L,3357103L,171841209L,11598601465L,996140770651L,105829573610091L,13602095395648453L,2077762791361106149L,BigInteger.Parse("371766799417828843575"),BigInteger.Parse("76978381709312988826951"),BigInteger.Parse("18256702588619162109630961"),BigInteger.Parse("4915636696257611754342845553"),BigInteger.Parse("1491009565882345791444427756339") };
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
public class A245308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245308Inst Instance=new A245308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245309
{
public static readonly BigInteger[] Value={ 1L,1L,3L,25L,397L,10101L,372991L,18744853L,1227094905L,101320257097L,10294575759451L,1262050509059121L,183700770307306693L,BigInteger.Parse("31322680620408105085"),BigInteger.Parse("6184922808789945458967"),BigInteger.Parse("1400325997347499801032301"),BigInteger.Parse("360395936189117983848624241"),BigInteger.Parse("104632853179210298481432557073") };
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
public class A245309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245309Inst Instance=new A245309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245310
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,12L,34L,120L,412L,1608L,6244L,26288L,111448L,499256L,2265288L,10701896L,51339768L,254175048L,1278947304L,6604214760L,34662182904L,186002333640L,1014140252376L,5638617162312L,31837193871480L,182962292354376L,1067120997002680L,6325487157903240L,38030207563538680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245310Inst : IEnumerable<long>
{
public static readonly long[] Value=A245310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245310.Bytes);
public long this[int i]=>Value[i];

public static A245310Inst Instance=new A245310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245311
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,50L,182L,707L,2903L,12479L,55844L,258860L,1238588L,6099054L,30836886L,159770751L,846927495L,4586883023L,25351486346L,142843162421L,819783142271L,4788268962584L,28444114318056L,171737405798836L,1053285775758916L,6558551535958516L,41441942236323008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245311Inst : IEnumerable<long>
{
public static readonly long[] Value=A245311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245311.Bytes);
public long this[int i]=>Value[i];

public static A245311Inst Instance=new A245311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245312
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,10L,60L,360L,2940L,24528L,247968L,2595920L,31175496L,389671200L,5422095536L,78605082528L,1244958773760L,20527083114496L,364984417934400L,6745106725383168L,133136189132775360L,2726068542132666240L,BigInteger.Parse("59173740044950124160"),BigInteger.Parse("1329834118793805335040"),BigInteger.Parse("31493916740885086274304") };
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
public class A245312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245312Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245312.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245312Inst Instance=new A245312Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245313
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,31L,176L,1158L,8919L,76751L,742597L,7865088L,91553100L,1150905332L,15665172108L,227991734414L,3554320236911L,58795765799791L,1033303679424539L,19151079894682674L,374662948814998855L,7691131223011551255L,BigInteger.Parse("165785969673935575904"),BigInteger.Parse("3734170668741419488552") };
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
public class A245313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245313Inst Instance=new A245313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245314
{
public static readonly long[] Value={ 0L,3L,5L,8L,10L,13L,16L,19L,20L,22L,25L,28L,30L,32L,35L,38L,39L,42L,44L,47L,49L,52L,54L,57L,59L,60L,64L,66L,68L,71L,73L,76L,78L,81L,83L,85L,88L,91L,93L,95L,97L,100L,103L,105L,107L,110L,112L,115L,116L,119L,122L,124L,126L,129L,131L,134L,136L,139L,141L,143L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245314Inst : IEnumerable<long>
{
public static readonly long[] Value=A245314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245314.Bytes);
public long this[int i]=>Value[i];

public static A245314Inst Instance=new A245314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245315
{
public static readonly long[] Value={ 422L,623L,8222L,933L,1025L,12223L,1427L,1535L,162222L,18233L,20225L,2137L,22211L,242223L,2555L,26213L,27333L,28227L,30235L,3222222L,33311L,34217L,3557L,362233L,38219L,39313L,402225L,42237L,442211L,45335L,46223L,4822223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245315Inst : IEnumerable<long>
{
public static readonly long[] Value=A245315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245315.Bytes);
public long this[int i]=>Value[i];

public static A245315Inst Instance=new A245315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245316
{
public static readonly long[] Value={ 4224L,6235L,82226L,9336L,10257L,122237L,14279L,15358L,1622228L,182338L,202259L,213710L,2221113L,2422239L,255510L,2621315L,273339L,2822711L,3023510L,322222210L,3331114L,3421719L,355712L,36223310L,3821921L,3931316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245316Inst : IEnumerable<long>
{
public static readonly long[] Value=A245316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245316.Bytes);
public long this[int i]=>Value[i];

public static A245316Inst Instance=new A245316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245317
{
public static readonly long[] Value={ 41L,62L,83L,94L,105L,126L,147L,158L,169L,1810L,2011L,2112L,2213L,2414L,2515L,2616L,2717L,2818L,3019L,3220L,3321L,3422L,3523L,3624L,3825L,3926L,4027L,4228L,4429L,4530L,4631L,4832L,4933L,5034L,5135L,5236L,5437L,5538L,5639L,5740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245317Inst : IEnumerable<long>
{
public static readonly long[] Value=A245317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245317.Bytes);
public long this[int i]=>Value[i];

public static A245317Inst Instance=new A245317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245318
{
public static readonly long[] Value={ 1L,7L,133L,1517L,11761L,676333L,1484413L,3627557L,10289371L,1449045241L,2433687407L,12309023183L,29013950411L,11701492535299L,223598572318157L,362232879754103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245318Inst : IEnumerable<long>
{
public static readonly long[] Value=A245318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245318.Bytes);
public long this[int i]=>Value[i];

public static A245318Inst Instance=new A245318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245319
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,12L,18L,24L,36L,72L,88L,198L,228L,1032L,2412L,2838L,4553L,5958L,10008L,24588L,25938L,46777L,65538L,75468L,82505L,130056L,143916L,200364L,540738L,598818L,750852L,797478L,923628L,958212L,1151538L,1250568L,1505388L,1647396L,2365128L,2964036L,3490028L,3704418L,3844808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245319Inst : IEnumerable<long>
{
public static readonly long[] Value=A245319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245319.Bytes);
public long this[int i]=>Value[i];

public static A245319Inst Instance=new A245319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245320
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,1L,-3L,3L,0L,0L,3L,-8L,6L,0L,1L,-8L,28L,-40L,20L,0L,0L,6L,-40L,105L,-120L,50L,0L,1L,-15L,105L,-355L,615L,-525L,175L,0L,0L,10L,-120L,615L,-1624L,2310L,-1680L,490L,0L,1L,-24L,276L,-1624L,5376L,-10416L,11704L,-7056L,1764L,0L,0L,15L,-280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245320Inst : IEnumerable<long>
{
public static readonly long[] Value=A245320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245320.Bytes);
public long this[int i]=>Value[i];

public static A245320Inst Instance=new A245320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245321
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,5L,6L,7L,8L,9L,10L,9L,10L,11L,12L,13L,14L,12L,13L,14L,15L,16L,17L,14L,15L,16L,17L,18L,19L,15L,16L,17L,18L,19L,20L,15L,16L,17L,18L,19L,20L,20L,21L,22L,23L,24L,25L,19L,20L,21L,22L,23L,24L,23L,24L,25L,26L,27L,28L,21L,22L,23L,24L,25L,26L,24L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245321Inst : IEnumerable<long>
{
public static readonly long[] Value=A245321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245321.Bytes);
public long this[int i]=>Value[i];

public static A245321Inst Instance=new A245321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245322
{
public static readonly BigInteger[] Value={ 1L,1L,8L,161L,6016L,360421L,31628288L,3823725821L,609263681536L,123729353398441L,31195066498285568L,9560281195915697081UL,BigInteger.Parse("3500145542231863853056"),BigInteger.Parse("1508772905238685631514061"),BigInteger.Parse("756360258034794813559144448"),BigInteger.Parse("436312320288025061112662937941"),BigInteger.Parse("286966475921556619941746443288576") };
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
public class A245322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245322Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245322.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245322Inst Instance=new A245322Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245323
{
public static readonly BigInteger[] Value={ 4L,170L,7320L,328380L,15124186L,704915600L,33014404692L,1549142827050L,72743819556328L,3416820019114700L,160507201018772634L,7540231471940495520L,BigInteger.Parse("354226959651753624100"),BigInteger.Parse("16641065639596669234730"),BigInteger.Parse("781774759322033582085816"),BigInteger.Parse("36726752905662141638238300") };
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
public class A245323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245323Inst Instance=new A245323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245324
{
public static readonly long[] Value={ 4L,2L,1L,7L,9L,9L,3L,6L,1L,4L,8L,4L,4L,4L,2L,7L,6L,9L,7L,6L,8L,0L,7L,6L,1L,4L,6L,1L,0L,1L,8L,1L,7L,4L,4L,9L,6L,8L,8L,0L,3L,4L,8L,3L,8L,6L,1L,6L,0L,9L,9L,6L,9L,4L,0L,1L,3L,5L,9L,5L,5L,0L,1L,4L,7L,7L,0L,5L,7L,6L,7L,9L,5L,9L,3L,1L,8L,1L,3L,3L,6L,9L,8L,4L,4L,8L,1L,5L,6L,1L,2L,1L,3L,2L,4L,1L,0L,8L,2L,1L,8L,8L,7L,8L,7L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245324Inst : IEnumerable<long>
{
public static readonly long[] Value=A245324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245324.Bytes);
public long this[int i]=>Value[i];

public static A245324Inst Instance=new A245324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245325
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,3L,3L,3L,2L,1L,5L,4L,5L,4L,5L,4L,5L,4L,3L,3L,2L,1L,8L,7L,7L,5L,8L,7L,7L,5L,8L,7L,7L,5L,8L,7L,7L,5L,5L,4L,5L,4L,3L,3L,2L,1L,13L,11L,12L,9L,11L,10L,9L,6L,13L,11L,12L,9L,11L,10L,9L,6L,13L,11L,12L,9L,11L,10L,9L,6L,13L,11L,12L,9L,11L,10L,9L,6L,8L,7L,7L,5L,8L,7L,7L,5L,5L,4L,5L,4L,3L,3L,2L,1L,21L,18L,19L,14L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245325Inst : IEnumerable<long>
{
public static readonly long[] Value=A245325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245325.Bytes);
public long this[int i]=>Value[i];

public static A245325Inst Instance=new A245325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245326
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,2L,1L,5L,4L,5L,4L,3L,3L,2L,1L,8L,7L,7L,5L,8L,7L,7L,5L,5L,4L,5L,4L,3L,3L,2L,1L,13L,11L,12L,9L,11L,10L,9L,6L,13L,11L,12L,9L,11L,10L,9L,6L,8L,7L,7L,5L,8L,7L,7L,5L,5L,4L,5L,4L,3L,3L,2L,1L,21L,18L,19L,14L,19L,17L,16L,11L,18L,15L,17L,13L,14L,13L,11L,7L,21L,18L,19L,14L,19L,17L,16L,11L,18L,15L,17L,13L,14L,13L,11L,7L,13L,11L,12L,9L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245326Inst : IEnumerable<long>
{
public static readonly long[] Value=A245326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245326.Bytes);
public long this[int i]=>Value[i];

public static A245326Inst Instance=new A245326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245327
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,1L,3L,3L,5L,2L,5L,3L,4L,1L,4L,5L,8L,3L,8L,5L,7L,2L,7L,4L,7L,3L,7L,4L,5L,1L,5L,8L,13L,5L,13L,8L,11L,3L,11L,7L,12L,5L,12L,7L,9L,2L,9L,7L,11L,4L,11L,7L,10L,3L,10L,5L,9L,4L,9L,5L,6L,1L,6L,13L,21L,8L,21L,13L,18L,5L,18L,11L,19L,8L,19L,11L,14L,3L,14L,12L,19L,7L,19L,12L,17L,5L,17L,9L,16L,7L,16L,9L,11L,2L,11L,11L,18L,7L,18L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245327Inst : IEnumerable<long>
{
public static readonly long[] Value=A245327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245327.Bytes);
public long this[int i]=>Value[i];

public static A245327Inst Instance=new A245327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245328
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,1L,5L,3L,5L,2L,4L,3L,4L,1L,8L,5L,8L,3L,7L,5L,7L,2L,7L,4L,7L,3L,5L,4L,5L,1L,13L,8L,13L,5L,11L,8L,11L,3L,12L,7L,12L,5L,9L,7L,9L,2L,11L,7L,11L,4L,10L,7L,10L,3L,9L,5L,9L,4L,6L,5L,6L,1L,21L,13L,21L,8L,18L,13L,18L,5L,19L,11L,19L,8L,14L,11L,14L,3L,19L,12L,19L,7L,17L,12L,17L,5L,16L,9L,16L,7L,11L,9L,11L,2L,18L,11L,18L,7L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245328Inst : IEnumerable<long>
{
public static readonly long[] Value=A245328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245328.Bytes);
public long this[int i]=>Value[i];

public static A245328Inst Instance=new A245328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245329
{
public static readonly BigInteger[] Value={ 1L,-7L,1L,1001L,-15359L,30233L,3126529L,-61392247L,259448833L,11970181433L,-287815672319L,1854020654633L,48800262650881L,-1443188813338279L,12410505050039041L,198977188596692681L,-7472188661349285887L,BigInteger.Parse("80331498114096555641") };
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
public class A245329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245329Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245329.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245329Inst Instance=new A245329Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245330
{
public static readonly long[] Value={ 9L,8L,9L,1L,3L,3L,6L,3L,4L,4L,4L,6L,9L,9L,3L,0L,5L,2L,2L,4L,3L,4L,9L,0L,3L,0L,8L,2L,6L,6L,3L,3L,7L,9L,8L,1L,3L,8L,0L,3L,4L,8L,0L,9L,8L,0L,4L,4L,1L,8L,2L,2L,1L,9L,0L,3L,9L,3L,5L,7L,8L,7L,8L,0L,8L,7L,3L,8L,2L,8L,9L,5L,4L,2L,6L,7L,5L,7L,9L,5L,8L,1L,5L,3L,8L,0L,3L,7L,6L,7L,5L,0L,8L,8L,0L,8L,0L,3L,8L,9L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245330Inst : IEnumerable<long>
{
public static readonly long[] Value=A245330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245330.Bytes);
public long this[int i]=>Value[i];

public static A245330Inst Instance=new A245330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245331
{
public static readonly long[] Value={ 2L,23L,87L,157L,1523L,3445551L,26620870L,30512347L,72713283L,344661698L,1129330411L,3886591581L,5085084202L,11916345303L,15510679381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245331Inst : IEnumerable<long>
{
public static readonly long[] Value=A245331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245331.Bytes);
public long this[int i]=>Value[i];

public static A245331Inst Instance=new A245331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245332
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,0L,3L,3L,4L,6L,9L,10L,16L,20L,27L,36L,49L,63L,86L,113L,150L,199L,265L,349L,465L,615L,815L,1080L,1432L,1895L,2513L,3328L,4409L,5841L,7739L,10250L,13581L,17990L,23832L,31571L,41824L,55403L,73396L,97228L,128800L,170624L,226030L,299424L,396655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245332Inst : IEnumerable<long>
{
public static readonly long[] Value=A245332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245332.Bytes);
public long this[int i]=>Value[i];

public static A245332Inst Instance=new A245332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245333
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,0L,6L,7L,4L,7L,0L,8L,1L,7L,6L,2L,1L,3L,1L,6L,9L,2L,7L,7L,9L,9L,0L,8L,7L,3L,3L,7L,6L,0L,1L,9L,6L,4L,6L,7L,6L,3L,1L,8L,2L,4L,0L,9L,3L,8L,5L,3L,8L,2L,2L,2L,7L,1L,5L,6L,5L,0L,1L,2L,9L,3L,6L,5L,4L,0L,4L,4L,4L,5L,6L,7L,3L,2L,9L,5L,9L,5L,3L,9L,6L,8L,5L,6L,4L,7L,9L,6L,1L,9L,2L,5L,7L,9L,0L,4L,9L,9L,7L,6L,2L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245333Inst : IEnumerable<long>
{
public static readonly long[] Value=A245333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245333.Bytes);
public long this[int i]=>Value[i];

public static A245333Inst Instance=new A245333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245334
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,2L,4L,9L,12L,6L,5L,16L,36L,48L,24L,6L,25L,80L,180L,240L,120L,7L,36L,150L,480L,1080L,1440L,720L,8L,49L,252L,1050L,3360L,7560L,10080L,5040L,9L,64L,392L,2016L,8400L,26880L,60480L,80640L,40320L,10L,81L,576L,3528L,18144L,75600L,241920L,544320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245334Inst : IEnumerable<long>
{
public static readonly long[] Value=A245334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245334.Bytes);
public long this[int i]=>Value[i];

public static A245334Inst Instance=new A245334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245335
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,5L,6L,7L,8L,7L,8L,9L,10L,11L,9L,10L,11L,12L,13L,10L,11L,12L,13L,14L,10L,11L,12L,13L,14L,14L,15L,16L,17L,18L,13L,14L,15L,16L,17L,16L,17L,18L,19L,20L,14L,15L,16L,17L,18L,16L,17L,18L,19L,20L,20L,21L,22L,23L,24L,17L,18L,19L,20L,21L,18L,19L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245335Inst : IEnumerable<long>
{
public static readonly long[] Value=A245335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245335.Bytes);
public long this[int i]=>Value[i];

public static A245335Inst Instance=new A245335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245336
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,7L,8L,9L,10L,11L,12L,13L,14L,13L,14L,15L,16L,17L,18L,19L,20L,18L,19L,20L,21L,22L,23L,24L,25L,22L,23L,24L,25L,26L,27L,28L,29L,25L,26L,27L,28L,29L,30L,31L,32L,27L,28L,29L,30L,31L,32L,33L,34L,28L,29L,30L,31L,32L,33L,34L,35L,28L,29L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245336Inst : IEnumerable<long>
{
public static readonly long[] Value=A245336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245336.Bytes);
public long this[int i]=>Value[i];

public static A245336Inst Instance=new A245336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245337
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,6L,7L,8L,9L,10L,11L,12L,11L,12L,13L,14L,15L,16L,17L,15L,16L,17L,18L,19L,20L,21L,18L,19L,20L,21L,22L,23L,24L,20L,21L,22L,23L,24L,25L,26L,21L,22L,23L,24L,25L,26L,27L,21L,22L,23L,24L,25L,26L,27L,27L,28L,29L,30L,31L,32L,33L,26L,27L,28L,29L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245337Inst : IEnumerable<long>
{
public static readonly long[] Value=A245337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245337.Bytes);
public long this[int i]=>Value[i];

public static A245337Inst Instance=new A245337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245338
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,8L,9L,10L,11L,12L,13L,14L,15L,16L,15L,16L,17L,18L,19L,20L,21L,22L,23L,21L,22L,23L,24L,25L,26L,27L,28L,29L,26L,27L,28L,29L,30L,31L,32L,33L,34L,30L,31L,32L,33L,34L,35L,36L,37L,38L,33L,34L,35L,36L,37L,38L,39L,40L,41L,35L,36L,37L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245338Inst : IEnumerable<long>
{
public static readonly long[] Value=A245338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245338.Bytes);
public long this[int i]=>Value[i];

public static A245338Inst Instance=new A245338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245339
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,39L,40L,41L,42L,43L,44L,45L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245339Inst : IEnumerable<long>
{
public static readonly long[] Value=A245339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245339.Bytes);
public long this[int i]=>Value[i];

public static A245339Inst Instance=new A245339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245340
{
public static readonly long[] Value={ 0L,1L,4L,2L,8L,21L,3L,5L,18L,16L,14L,12L,10L,6L,1518L,32L,58L,30L,184L,28L,7L,26L,9L,11L,13L,15L,17L,19L,102L,51L,100L,49L,98L,47L,96L,45L,94L,43L,92L,41L,90L,39L,88L,37L,86L,35L,84L,20L,24L,22L,505L,81L,2510L,79L,166L,77L,296L,75L,501L,73L,162L,71L,498L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245340Inst : IEnumerable<long>
{
public static readonly long[] Value=A245340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245340.Bytes);
public long this[int i]=>Value[i];

public static A245340Inst Instance=new A245340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245341
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,2L,3L,4L,5L,6L,4L,5L,6L,7L,8L,3L,4L,5L,6L,7L,5L,6L,7L,8L,9L,4L,5L,6L,7L,8L,6L,7L,8L,9L,10L,8L,9L,10L,11L,12L,4L,5L,6L,7L,8L,6L,7L,8L,9L,10L,5L,6L,7L,8L,9L,7L,8L,9L,10L,11L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,7L,8L,9L,10L,11L,6L,7L,8L,9L,10L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245341Inst : IEnumerable<long>
{
public static readonly long[] Value=A245341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245341.Bytes);
public long this[int i]=>Value[i];

public static A245341Inst Instance=new A245341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245342
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,9L,10L,6L,7L,8L,9L,10L,11L,12L,3L,4L,5L,6L,7L,8L,9L,5L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,13L,4L,5L,6L,7L,8L,9L,10L,6L,7L,8L,9L,10L,11L,12L,8L,9L,10L,11L,12L,13L,14L,10L,11L,12L,13L,14L,15L,16L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245342Inst : IEnumerable<long>
{
public static readonly long[] Value=A245342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245342.Bytes);
public long this[int i]=>Value[i];

public static A245342Inst Instance=new A245342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245343
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,3L,4L,5L,6L,7L,4L,5L,6L,7L,8L,7L,8L,9L,10L,11L,6L,7L,8L,9L,10L,7L,8L,9L,10L,11L,10L,11L,12L,13L,14L,7L,8L,9L,10L,11L,10L,11L,12L,13L,14L,9L,10L,11L,12L,13L,10L,11L,12L,13L,14L,13L,14L,15L,16L,17L,8L,9L,10L,11L,12L,11L,12L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245343Inst : IEnumerable<long>
{
public static readonly long[] Value=A245343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245343.Bytes);
public long this[int i]=>Value[i];

public static A245343Inst Instance=new A245343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245344
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,3L,4L,5L,6L,7L,8L,9L,6L,7L,8L,9L,10L,11L,12L,5L,6L,7L,8L,9L,10L,11L,8L,9L,10L,11L,12L,13L,14L,7L,8L,9L,10L,11L,12L,13L,10L,11L,12L,13L,14L,15L,16L,5L,6L,7L,8L,9L,10L,11L,8L,9L,10L,11L,12L,13L,14L,11L,12L,13L,14L,15L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245344Inst : IEnumerable<long>
{
public static readonly long[] Value=A245344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245344.Bytes);
public long this[int i]=>Value[i];

public static A245344Inst Instance=new A245344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245345
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,2L,3L,4L,5L,6L,7L,8L,9L,10L,4L,5L,6L,7L,8L,9L,10L,11L,12L,6L,7L,8L,9L,10L,11L,12L,13L,14L,8L,9L,10L,11L,12L,13L,14L,15L,16L,3L,4L,5L,6L,7L,8L,9L,10L,11L,5L,6L,7L,8L,9L,10L,11L,12L,13L,7L,8L,9L,10L,11L,12L,13L,14L,15L,9L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245345Inst : IEnumerable<long>
{
public static readonly long[] Value=A245345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245345.Bytes);
public long this[int i]=>Value[i];

public static A245345Inst Instance=new A245345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245346
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245346Inst : IEnumerable<long>
{
public static readonly long[] Value=A245346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245346.Bytes);
public long this[int i]=>Value[i];

public static A245346Inst Instance=new A245346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245347
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,8L,9L,10L,6L,7L,8L,9L,10L,11L,12L,13L,4L,5L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,13L,14L,10L,11L,12L,13L,14L,15L,16L,17L,8L,9L,10L,11L,12L,13L,14L,15L,11L,12L,13L,14L,15L,16L,17L,18L,4L,5L,6L,7L,8L,9L,10L,11L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245347Inst : IEnumerable<long>
{
public static readonly long[] Value=A245347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245347.Bytes);
public long this[int i]=>Value[i];

public static A245347Inst Instance=new A245347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245348
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,2L,27L,15L,8L,4L,256L,112L,50L,22L,10L,3125L,1125L,430L,166L,66L,26L,46656L,14256L,4752L,1626L,576L,206L,76L,823543L,218491L,64484L,19768L,6310L,2054L,688L,232L,16777216L,3932160L,1040384L,288512L,83736L,24952L,7660L,2388L,764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245348Inst : IEnumerable<long>
{
public static readonly long[] Value=A245348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245348.Bytes);
public long this[int i]=>Value[i];

public static A245348Inst Instance=new A245348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245349
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,4L,5L,6L,7L,8L,9L,10L,5L,6L,7L,8L,9L,10L,11L,9L,10L,11L,12L,13L,14L,15L,7L,8L,9L,10L,11L,12L,13L,11L,12L,13L,14L,15L,16L,17L,12L,13L,14L,15L,16L,17L,18L,7L,8L,9L,10L,11L,12L,13L,11L,12L,13L,14L,15L,16L,17L,12L,13L,14L,15L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245349Inst : IEnumerable<long>
{
public static readonly long[] Value=A245349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245349.Bytes);
public long this[int i]=>Value[i];

public static A245349Inst Instance=new A245349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245350
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,9L,10L,11L,12L,8L,9L,10L,11L,12L,13L,14L,15L,16L,7L,8L,9L,10L,11L,12L,13L,14L,15L,11L,12L,13L,14L,15L,16L,17L,18L,19L,10L,11L,12L,13L,14L,15L,16L,17L,18L,14L,15L,16L,17L,18L,19L,20L,21L,22L,8L,9L,10L,11L,12L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245350Inst : IEnumerable<long>
{
public static readonly long[] Value=A245350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245350.Bytes);
public long this[int i]=>Value[i];

public static A245350Inst Instance=new A245350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245351
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,21L,22L,23L,24L,25L,26L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245351Inst : IEnumerable<long>
{
public static readonly long[] Value=A245351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245351.Bytes);
public long this[int i]=>Value[i];

public static A245351Inst Instance=new A245351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245352
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,5L,6L,7L,8L,9L,10L,11L,8L,9L,10L,11L,12L,13L,14L,9L,10L,11L,12L,13L,14L,15L,14L,15L,16L,17L,18L,19L,20L,13L,14L,15L,16L,17L,18L,19L,16L,17L,18L,19L,20L,21L,22L,13L,14L,15L,16L,17L,18L,19L,18L,19L,20L,21L,22L,23L,24L,19L,20L,21L,22L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245352Inst : IEnumerable<long>
{
public static readonly long[] Value=A245352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245352.Bytes);
public long this[int i]=>Value[i];

public static A245352Inst Instance=new A245352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245353
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,7L,8L,9L,10L,11L,12L,13L,14L,15L,12L,13L,14L,15L,16L,17L,18L,19L,20L,15L,16L,17L,18L,19L,20L,21L,22L,23L,16L,17L,18L,19L,20L,21L,22L,23L,24L,23L,24L,25L,26L,27L,28L,29L,30L,31L,22L,23L,24L,25L,26L,27L,28L,29L,30L,27L,28L,29L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245353Inst : IEnumerable<long>
{
public static readonly long[] Value=A245353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245353.Bytes);
public long this[int i]=>Value[i];

public static A245353Inst Instance=new A245353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245354
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,5L,6L,7L,8L,9L,10L,11L,12L,13L,6L,7L,8L,9L,10L,11L,12L,13L,14L,11L,12L,13L,14L,15L,16L,17L,18L,19L,8L,9L,10L,11L,12L,13L,14L,15L,16L,13L,14L,15L,16L,17L,18L,19L,20L,21L,14L,15L,16L,17L,18L,19L,20L,21L,22L,19L,20L,21L,22L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245354Inst : IEnumerable<long>
{
public static readonly long[] Value=A245354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245354.Bytes);
public long this[int i]=>Value[i];

public static A245354Inst Instance=new A245354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245355
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,5L,6L,7L,8L,9L,10L,11L,12L,7L,8L,9L,10L,11L,12L,13L,14L,12L,13L,14L,15L,16L,17L,18L,19L,11L,12L,13L,14L,15L,16L,17L,18L,13L,14L,15L,16L,17L,18L,19L,20L,18L,19L,20L,21L,22L,23L,24L,25L,14L,15L,16L,17L,18L,19L,20L,21L,13L,14L,15L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245355Inst : IEnumerable<long>
{
public static readonly long[] Value=A245355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245355.Bytes);
public long this[int i]=>Value[i];

public static A245355Inst Instance=new A245355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245356
{
public static readonly long[] Value={ 4L,4L,4L,4L,8L,8L,12L,16L,20L,28L,36L,48L,64L,88L,116L,156L,208L,276L,368L,492L,656L,872L,1164L,1552L,2068L,2760L,3680L,4904L,6540L,8720L,11628L,15504L,20672L,27560L,36748L,48996L,65328L,87104L,116140L,154852L,206472L,275296L,367060L,489412L,652552L,870068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245356Inst : IEnumerable<long>
{
public static readonly long[] Value=A245356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245356.Bytes);
public long this[int i]=>Value[i];

public static A245356Inst Instance=new A245356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245357
{
public static readonly long[] Value={ 5L,5L,5L,5L,5L,10L,10L,15L,15L,20L,25L,30L,40L,50L,60L,75L,95L,120L,150L,185L,235L,290L,365L,455L,570L,710L,890L,1110L,1390L,1735L,2170L,2715L,3390L,4240L,5300L,6625L,8280L,10350L,12940L,16175L,20215L,25270L,31590L,39485L,49355L,61695L,77120L,96400L,120500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245357Inst : IEnumerable<long>
{
public static readonly long[] Value=A245357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245357.Bytes);
public long this[int i]=>Value[i];

public static A245357Inst Instance=new A245357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245358
{
public static readonly BigInteger[] Value={ 2L,12L,199L,113L,14459L,223L,1133779L,1111222L,2225L,222222666689L,111111111222344678L,112225556779999L,BigInteger.Parse("1122233333333444555888888"),BigInteger.Parse("111111111133333333334444555666") };
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
public class A245358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245358Inst Instance=new A245358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245359
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,-1L,2L,0L,2L,0L,2L,0L,0L,0L,1L,2L,0L,2L,0L,2L,0L,0L,0L,1L,1L,0L,2L,0L,1L,0L,0L,0L,2L,0L,0L,2L,0L,1L,0L,0L,0L,1L,0L,2L,1L,0L,2L,0L,0L,0L,2L,0L,2L,0L,0L,2L,0L,0L,0L,2L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,1L,0L,0L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245359Inst : IEnumerable<long>
{
public static readonly long[] Value=A245359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245359.Bytes);
public long this[int i]=>Value[i];

public static A245359Inst Instance=new A245359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245360
{
public static readonly long[] Value={ 8L,36L,100L,128L,144L,216L,576L,1764L,2304L,3844L,5184L,7056L,8100L,8192L,12100L,14400L,14884L,21952L,30276L,41616L,43264L,48400L,53824L,57600L,69696L,74088L,93636L,106276L,112896L,138384L,148996L,166464L,168100L,197136L,206116L,207936L,219024L,220900L,224676L,272484L,279936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245360Inst : IEnumerable<long>
{
public static readonly long[] Value=A245360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245360.Bytes);
public long this[int i]=>Value[i];

public static A245360Inst Instance=new A245360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245361
{
public static readonly long[] Value={ 3L,8L,30L,36L,42L,51L,53L,80L,84L,99L,300L,323L,341L,360L,384L,387L,420L,422L,426L,510L,530L,552L,575L,576L,591L,800L,825L,827L,840L,861L,882L,990L,993L,998L,3000L,3032L,3069L,3072L,3201L,3230L,3264L,3276L,3410L,3441L,3477L,3483L,3600L,3633L,3648L,3671L,3806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245361Inst : IEnumerable<long>
{
public static readonly long[] Value=A245361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245361.Bytes);
public long this[int i]=>Value[i];

public static A245361Inst Instance=new A245361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245362
{
public static readonly long[] Value={ 51L,323L,341L,422L,591L,993L,998L,4227L,4265L,5129L,5534L,5921L,5937L,8049L,8657L,8801L,9953L,32133L,32282L,32471L,32597L,32817L,34091L,34379L,36611L,36863L,38937L,42011L,42243L,42605L,53211L,53673L,55745L,57167L,57903L,59543L,82151L,86354L,86781L,88217L,88433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245362Inst : IEnumerable<long>
{
public static readonly long[] Value=A245362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245362.Bytes);
public long this[int i]=>Value[i];

public static A245362Inst Instance=new A245362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245363
{
public static readonly long[] Value={ 19L,37L,49L,69L,73L,102L,165L,236L,253L,365L,465L,542L,595L,694L,713L,723L,762L,920L,962L,979L,1119L,1162L,1259L,1334L,1387L,1441L,1706L,1797L,1843L,1906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245363Inst : IEnumerable<long>
{
public static readonly long[] Value=A245363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245363.Bytes);
public long this[int i]=>Value[i];

public static A245363Inst Instance=new A245363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245364
{
public static readonly long[] Value={ 111L,164L,195L,222L,265L,333L,444L,498L,555L,666L,777L,888L,999L,1111L,1664L,1995L,2222L,2665L,3333L,4444L,4847L,4998L,5555L,6545L,6666L,7424L,7777L,8888L,9999L,11111L,16664L,19995L,22222L,26665L,33333L,43243L,44444L,49998L,55555L,66666L,77777L,86486L,88888L,99999L,111111L,166664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245364Inst : IEnumerable<long>
{
public static readonly long[] Value=A245364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245364.Bytes);
public long this[int i]=>Value[i];

public static A245364Inst Instance=new A245364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245365
{
public static readonly long[] Value={ 22L,35L,51L,145L,247L,287L,1247L,1717L,2147L,2501L,3151L,4187L,5017L,7957L,11051L,13207L,15251L,16801L,17767L,20827L,26867L,33227L,49051L,63551L,68587L,71177L,76501L,81317L,96647L,112477L,118301L,128627L,147737L,159251L,182527L,232657L,237407L,241001L,250717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245365Inst : IEnumerable<long>
{
public static readonly long[] Value=A245365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245365.Bytes);
public long this[int i]=>Value[i];

public static A245365Inst Instance=new A245365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245366
{
public static readonly BigInteger[] Value={ 2L,3L,4L,9L,55L,1321L,570673L,40677571441L,BigInteger.Parse("30641887385179424641"),BigInteger.Parse("711307017047678652146384291462042881"),BigInteger.Parse("886599784992546696966754646294076268713472764725575212247451289601") };
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
public class A245366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245366Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245366.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245366Inst Instance=new A245366Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245367
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,1L,2L,1L,3L,3L,3L,6L,5L,8L,10L,11L,17L,18L,25L,32L,37L,52L,61L,79L,102L,123L,163L,200L,254L,326L,402L,519L,649L,819L,1045L,1305L,1664L,2096L,2643L,3358L,4220L,5352L,6759L,8527L,10806L,13622L,17237L,21785L,27501L,34802L,43934L,55544L,70209L,88672L,112131L,141644L,179018L,226274L,285860L,361358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245367Inst : IEnumerable<long>
{
public static readonly long[] Value=A245367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245367.Bytes);
public long this[int i]=>Value[i];

public static A245367Inst Instance=new A245367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245368
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,3L,1L,1L,5L,5L,2L,7L,13L,8L,10L,25L,26L,20L,42L,64L,54L,72L,131L,144L,146L,245L,339L,344L,463L,715L,827L,953L,1423L,1881L,2124L,2839L,4019L,4832L,5916L,8281L,10732L,12872L,17036L,23032L,28436L,35824L,48349L,62200L,77132L,101209L,133581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245368Inst : IEnumerable<long>
{
public static readonly long[] Value=A245368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245368.Bytes);
public long this[int i]=>Value[i];

public static A245368Inst Instance=new A245368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245369
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,3L,1L,1L,5L,1L,5L,7L,2L,13L,9L,8L,25L,12L,26L,41L,22L,64L,62L,56L,130L,96L,146L,233L,174L,340L,391L,376L,703L,661L,862L,1327L,1211L,1905L,2379L,2449L,3935L,4251L,5216L,7641L,7911L,11056L,14271L,15576L,22632L,26433L,31848L,44544L,49920L,65536L,85248L,97344L,132712L,161601L,194728L,262504L,308865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245369Inst : IEnumerable<long>
{
public static readonly long[] Value=A245369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245369.Bytes);
public long this[int i]=>Value[i];

public static A245369Inst Instance=new A245369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245370
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,2L,2L,1L,3L,3L,3L,6L,5L,6L,11L,10L,13L,19L,19L,27L,35L,37L,52L,65L,74L,100L,121L,145L,192L,230L,282L,365L,440L,548L,695L,843L,1058L,1327L,1621L,2035L,2535L,3119L,3910L,4851L,5997L,7503L,9297L,11528L,14389L,17829L,22150L,27596L,34208L,42536L,52928L,65655L,81660L,101525L,126020L,156738L,194776L,241888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245370Inst : IEnumerable<long>
{
public static readonly long[] Value=A245370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245370.Bytes);
public long this[int i]=>Value[i];

public static A245370Inst Instance=new A245370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245371
{
public static readonly long[] Value={ 16L,25L,36L,49L,64L,81L,100L,121L,144L,169L,289L,324L,361L,400L,441L,484L,529L,729L,784L,841L,900L,961L,1225L,1600L,1681L,1764L,1849L,1936L,2025L,2116L,2209L,2304L,2401L,2500L,2601L,2704L,2809L,2916L,3025L,3136L,3249L,3364L,3481L,3600L,4225L,4900L,5625L,6400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245371Inst : IEnumerable<long>
{
public static readonly long[] Value=A245371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245371.Bytes);
public long this[int i]=>Value[i];

public static A245371Inst Instance=new A245371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245372
{
public static readonly long[] Value={ 46L,76L,96L,106L,134L,142L,146L,204L,218L,276L,310L,408L,438L,466L,518L,534L,536L,546L,580L,624L,650L,672L,680L,694L,792L,800L,896L,970L,1000L,1016L,1100L,1160L,1170L,1318L,1344L,1358L,1364L,1384L,1470L,1480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245372Inst : IEnumerable<long>
{
public static readonly long[] Value=A245372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245372.Bytes);
public long this[int i]=>Value[i];

public static A245372Inst Instance=new A245372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245373
{
public static readonly BigInteger[] Value={ 1L,2L,6L,20L,80L,368L,1904L,10880L,67904L,459008L,3336704L,25925120L,214175744L,1873092608L,17276401664L,167504076800L,1702214549504L,18084149854208L,200388963958784L,2311212530401280L,27693720143396864L,344157474490155008L,4428851361694613504L,BigInteger.Parse("58933575269230837760") };
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
public class A245373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245373Inst Instance=new A245373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245374
{
public static readonly BigInteger[] Value={ 1L,3L,12L,54L,288L,1782L,12474L,96714L,819882L,7536402L,74610234L,790692354L,8921660922L,106687646802L,1346863560714L,17890362862434L,249297686894682L,3634756665823602L,55317506662094634L,876911386062810114L,14451743847813157242UL,BigInteger.Parse("247171758180997987602"),BigInteger.Parse("4380263376360686471754") };
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
public class A245374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245374Inst Instance=new A245374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245375
{
public static readonly BigInteger[] Value={ 1L,4L,20L,112L,736L,5632L,49024L,474112L,5017600L,57597952L,712597504L,9446981632L,133474877440L,2000265674752L,31666683510784L,527786775150592L,9233419259084800L,169106747636580352L,3234542505882025984L,BigInteger.Parse("64473076850860490752"),BigInteger.Parse("1336621867385969704960"),BigInteger.Parse("28769619371258703511552") };
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
public class A245375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245375Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245375.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245375Inst Instance=new A245375Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245376
{
public static readonly BigInteger[] Value={ 1L,5L,30L,200L,1550L,14000L,144500L,1662500L,20952500L,286437500L,4221312500L,66703437500L,1124194062500L,20109785937500L,380209901562500L,7571141773437500L,158312671414062500L,3466819503710937500L,BigInteger.Parse("79316483272226562500"),BigInteger.Parse("1891747084452148437500"),BigInteger.Parse("46942864023040039062500") };
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
public class A245376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245376Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245376.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245376Inst Instance=new A245376Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245377
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,4L,17L,80L,422L,2480L,16095L,114432L,884969L,7398464L,66502048L,639653632L,6556170841L,71340409600L,821408397105L,9977630263296L,127518757153174L,1710576547456000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245377Inst : IEnumerable<long>
{
public static readonly long[] Value=A245377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245377.Bytes);
public long this[int i]=>Value[i];

public static A245377Inst Instance=new A245377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245378
{
public static readonly long[] Value={ 1L,1L,3L,10L,39L,165L,743L,3507L,17199L,87126L,454159L,2430031L,13326623L,74856230L,430628069L,2538270783L,15343363603L,95233568052L,607850790015L,3996223189468L,27105153736781L,189947851239185L,1376864409041417L,10330672337146804L,80248762443834399L,645206035074873681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245378Inst : IEnumerable<long>
{
public static readonly long[] Value=A245378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245378.Bytes);
public long this[int i]=>Value[i];

public static A245378Inst Instance=new A245378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245379
{
public static readonly long[] Value={ 12L,18L,24L,36L,40L,56L,72L,80L,88L,96L,104L,108L,136L,152L,184L,225L,232L,248L,288L,296L,328L,344L,376L,384L,424L,441L,448L,472L,488L,536L,568L,584L,632L,640L,664L,712L,776L,808L,824L,856L,864L,872L,896L,904L,972L,1016L,1048L,1089L,1096L,1112L,1152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245379Inst : IEnumerable<long>
{
public static readonly long[] Value=A245379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245379.Bytes);
public long this[int i]=>Value[i];

public static A245379Inst Instance=new A245379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245380
{
public static readonly long[] Value={ 0L,1L,22L,153L,624L,1875L,4626L,9947L,19328L,34749L,58750L,94501L,145872L,217503L,314874L,444375L,613376L,830297L,1104678L,1447249L,1870000L,2386251L,3010722L,3759603L,4650624L,5703125L,6938126L,8378397L,10048528L,11974999L,14186250L,16712751L,19587072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245380Inst : IEnumerable<long>
{
public static readonly long[] Value=A245380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245380.Bytes);
public long this[int i]=>Value[i];

public static A245380Inst Instance=new A245380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245381
{
public static readonly long[] Value={ 19L,37L,73L,127L,271L,1153L,1531L,1571L,3511L,5113L,5171L,5711L,7151L,11161L,11251L,12511L,15121L,16111L,25111L,111119L,111191L,111317L,111731L,113117L,113131L,113171L,115151L,131113L,131171L,131311L,131711L,171131L,311711L,511151L,515111L,711131L,911111L,1111213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245381Inst : IEnumerable<long>
{
public static readonly long[] Value=A245381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245381.Bytes);
public long this[int i]=>Value[i];

public static A245381Inst Instance=new A245381Inst();

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