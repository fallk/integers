using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A276711
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,2L,2L,1L,1L,1L,4L,2L,2L,2L,2L,1L,2L,2L,3L,2L,3L,1L,3L,1L,1L,1L,4L,2L,3L,3L,2L,4L,2L,2L,3L,1L,3L,5L,4L,2L,3L,2L,3L,3L,4L,2L,4L,2L,3L,2L,4L,2L,3L,3L,3L,4L,2L,1L,3L,2L,3L,4L,3L,1L,2L,3L,4L,5L,4L,2L,3L,3L,3L,2L,5L,1L,4L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276711Inst : IEnumerable<long>
{
public static readonly long[] Value=A276711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276711.Bytes);
public long this[int i]=>Value[i];

public static A276711Inst Instance=new A276711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276710
{
public static readonly long[] Value={ 36L,40L,63L,80L,84L,90L,105L,108L,132L,144L,150L,154L,160L,165L,168L,175L,176L,180L,182L,195L,198L,200L,208L,210L,220L,260L,264L,270L,273L,275L,280L,286L,288L,297L,300L,306L,308L,312L,315L,320L,324L,330L,340L,351L,357L,360L,364L,374L,378L,380L,385L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276710Inst : IEnumerable<long>
{
public static readonly long[] Value=A276710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276710.Bytes);
public long this[int i]=>Value[i];

public static A276710Inst Instance=new A276710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276709
{
public static readonly long[] Value={ 2L,6L,8L,4L,5L,1L,0L,3L,5L,0L,8L,2L,0L,7L,0L,7L,6L,5L,2L,5L,0L,2L,3L,8L,2L,6L,4L,0L,4L,8L,7L,2L,3L,8L,6L,8L,5L,3L,1L,0L,1L,7L,9L,7L,3L,4L,5L,9L,8L,5L,5L,1L,6L,3L,5L,2L,2L,0L,4L,1L,4L,8L,6L,4L,5L,0L,2L,6L,4L,1L,1L,3L,3L,6L,3L,1L,7L,6L,7L,2L,4L,4L,8L,9L,3L,6L,2L,5L,0L,2L,2L,0L,1L,2L,5L,4L,8L,5L,2L,1L,5L,3L,6L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276709Inst : IEnumerable<long>
{
public static readonly long[] Value=A276709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276709.Bytes);
public long this[int i]=>Value[i];

public static A276709Inst Instance=new A276709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276708
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1100L,1L,111100L,1L,11110100L,1L,1111110100L,1L,111111110100L,1L,11111111010100L,1L,1111111101010100L,1L,111111111101010100L,1L,11111111111101010100UL,1L,BigInteger.Parse("1111111111111101010100"),1L,BigInteger.Parse("111111111111111101010100"),1L,BigInteger.Parse("11111111111111110101010100"),1L };
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
public class A276708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276708Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276708.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276708Inst Instance=new A276708Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276691
{
public static readonly long[] Value={ 1L,4L,11L,27L,63L,142L,314L,684L,1474L,3150L,6685L,14110L,29640L,62022L,129337L,268930L,557752L,1154164L,2383587L,4913835L,10113983L,20787252L,42668775L,87479539L,179157497L,366547820L,749256450L,1530251194L,3122882776L,6368433118L,12978230568L,26431617730L,53799078716L,109442256914L,222519713892L,452208698216L,918560947022L,1865036287632L,3785181059505L,7679199158098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276691Inst : IEnumerable<long>
{
public static readonly long[] Value=A276691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276691.Bytes);
public long this[int i]=>Value[i];

public static A276691Inst Instance=new A276691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276690
{
public static readonly long[] Value={ 2L,3L,6L,13L,14L,29L,114L,1810L,7989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276690Inst : IEnumerable<long>
{
public static readonly long[] Value=A276690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276690.Bytes);
public long this[int i]=>Value[i];

public static A276690Inst Instance=new A276690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276689
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,4L,2L,1L,1L,0L,6L,3L,2L,1L,1L,1L,0L,8L,4L,1L,2L,1L,1L,1L,1L,0L,10L,5L,2L,1L,2L,1L,1L,1L,1L,1L,0L,12L,6L,4L,3L,2L,2L,1L,1L,1L,1L,1L,1L,0L,14L,7L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,0L,16L,8L,1L,4L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,0L,18L,9L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276689Inst : IEnumerable<long>
{
public static readonly long[] Value=A276689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276689.Bytes);
public long this[int i]=>Value[i];

public static A276689Inst Instance=new A276689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276688
{
public static readonly BigInteger[] Value={ 0L,0L,1L,8L,5L,-220L,1895L,-9140L,-302175L,-2778300L,-95631825L,-10071428100L,-236788407375L,57706241794500L,-7412904844112625L,525300693117661500L,BigInteger.Parse("348922898045520800625"),BigInteger.Parse("55166584329677385922500"),BigInteger.Parse("28368558145043150339199375"),BigInteger.Parse("46873210124734003815040957500") };
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
public class A276688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276688Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276688.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276688Inst Instance=new A276688Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276687
{
public static readonly long[] Value={ 1L,1L,2L,4L,11L,30L,122L,336L,1412L,15129L,44561L,417542L,2479120L,7540843L,35983502L,451454834L,5313515136L,16809858904L,190077477328L,1124302066470L,3521811953565L,38563707677633L,240966297786218L,3192420711942298L,95433674596402663L,567734580765228356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276687Inst : IEnumerable<long>
{
public static readonly long[] Value=A276687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276687.Bytes);
public long this[int i]=>Value[i];

public static A276687Inst Instance=new A276687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276686
{
public static readonly long[] Value={ 3141L,582L,9999L,2796L,6549L,2019L,2916L,8352L,5485L,5485L,5485L,5485L,5485L,5485L,5485L,1177L,1177L,5485L,1177L,3718L,5485L,5485L,1766L,1766L,5485L,4608L,4608L,4608L,4608L,4608L,5485L,5485L,504L,504L,504L,504L,504L,504L,504L,2103L,504L,504L,9479L,504L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276686Inst : IEnumerable<long>
{
public static readonly long[] Value=A276686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276686.Bytes);
public long this[int i]=>Value[i];

public static A276686Inst Instance=new A276686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276685
{
public static readonly long[] Value={ 1L,0L,2L,3L,4L,6L,5L,8L,20L,21L,10L,22L,24L,26L,29L,9L,28L,7L,40L,42L,30L,25L,44L,32L,41L,11L,12L,23L,33L,34L,45L,46L,36L,48L,27L,60L,50L,43L,38L,61L,14L,62L,64L,47L,66L,52L,63L,68L,16L,80L,65L,54L,67L,70L,49L,82L,72L,69L,84L,74L,85L,55L,56L,83L,86L,18L,88L,200L,76L,89L,90L,87L,77L,78L,202L,201L,100L,204L,206L,92L,208L,58L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276685Inst : IEnumerable<long>
{
public static readonly long[] Value=A276685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276685.Bytes);
public long this[int i]=>Value[i];

public static A276685Inst Instance=new A276685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276684
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,7L,4L,9L,11L,10L,13L,15L,17L,6L,19L,8L,31L,33L,35L,21L,14L,37L,22L,23L,30L,39L,25L,34L,41L,12L,27L,50L,51L,29L,53L,16L,55L,43L,32L,57L,44L,45L,36L,59L,47L,52L,71L,49L,56L,61L,18L,73L,63L,38L,75L,65L,54L,77L,66L,67L,58L,79L,69L,74L,91L,93L,81L,76L,95L,83L,96L,97L,85L,99L,94L,111L,70L,112L,110L,113L,115L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276684Inst : IEnumerable<long>
{
public static readonly long[] Value=A276684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276684.Bytes);
public long this[int i]=>Value[i];

public static A276684Inst Instance=new A276684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276683
{
public static readonly long[] Value={ 1L,4L,4L,6L,4L,12L,6L,8L,8L,8L,4L,24L,6L,8L,12L,10L,8L,16L,4L,24L,12L,16L,4L,24L,6L,8L,20L,12L,4L,32L,6L,24L,12L,16L,8L,24L,8L,8L,16L,16L,8L,48L,6L,12L,16L,8L,8L,50L,6L,12L,12L,24L,8L,20L,16L,32L,24L,8L,4L,36L,4L,24L,16L,28L,8L,32L,8L,12L,24L,16L,4L,64L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276683Inst : IEnumerable<long>
{
public static readonly long[] Value=A276683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276683.Bytes);
public long this[int i]=>Value[i];

public static A276683Inst Instance=new A276683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276682
{
public static readonly long[] Value={ 1L,3L,8L,4L,6L,4L,8L,12L,6L,6L,18L,8L,4L,8L,16L,8L,8L,9L,14L,24L,8L,4L,16L,12L,8L,8L,24L,8L,12L,12L,8L,20L,8L,4L,48L,24L,4L,12L,16L,24L,8L,12L,12L,16L,18L,4L,20L,16L,9L,16L,40L,8L,8L,8L,24L,36L,8L,4L,24L,24L,4L,16L,24L,12L,24L,8L,16L,16L,8L,12L,16L,18L,8L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276682Inst : IEnumerable<long>
{
public static readonly long[] Value=A276682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276682.Bytes);
public long this[int i]=>Value[i];

public static A276682Inst Instance=new A276682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276681
{
public static readonly long[] Value={ 1L,4L,4L,8L,4L,12L,4L,10L,9L,16L,4L,16L,4L,20L,8L,12L,6L,24L,8L,16L,8L,16L,4L,40L,6L,16L,8L,16L,8L,40L,8L,14L,8L,24L,8L,24L,4L,24L,16L,20L,6L,32L,4L,32L,24L,20L,4L,24L,12L,24L,8L,32L,4L,56L,8L,20L,12L,16L,12L,32L,4L,20L,24L,32L,8L,48L,4L,16L,16L,48L,4L,30L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276681Inst : IEnumerable<long>
{
public static readonly long[] Value=A276681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276681.Bytes);
public long this[int i]=>Value[i];

public static A276681Inst Instance=new A276681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276680
{
public static readonly long[] Value={ 1L,2L,6L,4L,4L,5L,10L,6L,8L,4L,8L,12L,4L,4L,24L,16L,4L,8L,8L,8L,12L,4L,16L,24L,6L,4L,20L,8L,4L,18L,12L,10L,12L,4L,16L,16L,8L,8L,36L,12L,4L,16L,8L,16L,16L,4L,12L,24L,9L,12L,32L,8L,4L,10L,32L,12L,12L,8L,8L,40L,4L,4L,48L,12L,16L,12L,8L,8L,16L,8L,20L,48L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276680Inst : IEnumerable<long>
{
public static readonly long[] Value=A276680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276680.Bytes);
public long this[int i]=>Value[i];

public static A276680Inst Instance=new A276680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276679
{
public static readonly long[] Value={ 1L,4L,4L,6L,6L,8L,4L,16L,6L,8L,8L,12L,6L,16L,8L,10L,8L,24L,4L,24L,8L,8L,12L,16L,9L,16L,8L,24L,8L,16L,4L,36L,16L,8L,16L,18L,4L,24L,16L,16L,10L,16L,8L,24L,12L,16L,8L,40L,6L,36L,8L,12L,16L,16L,8L,32L,8L,16L,12L,48L,6L,16L,24L,14L,16L,16L,8L,48L,8L,16L,8L,48L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276679Inst : IEnumerable<long>
{
public static readonly long[] Value=A276679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276679.Bytes);
public long this[int i]=>Value[i];

public static A276679Inst Instance=new A276679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276678
{
public static readonly long[] Value={ 1L,2L,6L,4L,4L,4L,8L,6L,6L,4L,10L,16L,4L,4L,16L,8L,6L,6L,12L,8L,8L,8L,8L,12L,6L,8L,32L,8L,4L,8L,8L,20L,12L,4L,24L,12L,8L,4L,16L,24L,4L,16L,14L,8L,12L,4L,16L,32L,6L,6L,24L,16L,4L,16L,16L,12L,16L,4L,16L,16L,8L,8L,24L,12L,8L,8L,18L,16L,8L,16L,8L,36L,4L,8L,60L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276678Inst : IEnumerable<long>
{
public static readonly long[] Value=A276678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276678.Bytes);
public long this[int i]=>Value[i];

public static A276678Inst Instance=new A276678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276677
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,28L,48L,76L,120L,180L,272L,396L,584L,836L,1216L,1724L,2488L,3508L,5040L,7084L,10152L,14244L,20384L,28572L,40856L,57236L,81808L,114572L,163720L,229252L,327552L,458620L,655224L,917364L,1310576L,1834860L,2621288L,3669860L,5242720L,7339868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276677Inst : IEnumerable<long>
{
public static readonly long[] Value=A276677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276677.Bytes);
public long this[int i]=>Value[i];

public static A276677Inst Instance=new A276677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276676
{
public static readonly long[] Value={ 2L,11L,2L,47L,47L,2L,47L,47L,11L,2L,47L,47L,17L,17L,2L,683L,683L,683L,683L,683L,2L,683L,683L,683L,683L,683L,11L,2L,683L,683L,683L,683L,683L,17L,17L,2L,683L,683L,683L,683L,683L,467L,467L,467L,2L,683L,683L,683L,683L,683L,467L,467L,467L,11L,2L,683L,683L,683L,683L,683L,467L,467L,467L,79L,79L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276676Inst : IEnumerable<long>
{
public static readonly long[] Value=A276676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276676.Bytes);
public long this[int i]=>Value[i];

public static A276676Inst Instance=new A276676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276659
{
public static readonly long[] Value={ 0L,2L,11L,39L,114L,300L,741L,1757L,4052L,9162L,20415L,44979L,98214L,212888L,458633L,982905L,2097000L,4456278L,9436995L,19922735L,41942810L,88080132L,184549101L,385875669L,805306044L,1677721250L,3489660551L,7247756907L,15032385102L,31138512432L,64424508945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276659Inst : IEnumerable<long>
{
public static readonly long[] Value=A276659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276659.Bytes);
public long this[int i]=>Value[i];

public static A276659Inst Instance=new A276659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276658
{
public static readonly long[] Value={ 1L,2L,0L,3L,5L,8L,16L,29L,53L,98L,180L,331L,609L,1120L,2060L,3789L,6969L,12818L,23576L,43363L,79757L,146696L,269816L,496269L,912781L,1678866L,3087916L,5679563L,10446345L,19213824L,35339732L,64999901L,119553457L,219893090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276658Inst : IEnumerable<long>
{
public static readonly long[] Value=A276658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276658.Bytes);
public long this[int i]=>Value[i];

public static A276658Inst Instance=new A276658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276657
{
public static readonly BigInteger[] Value={ 1L,1L,2L,2L,8L,28L,72L,432L,1728L,9792L,56448L,372096L,2419200L,19526400L,144806400L,1310515200L,11338444800L,112903372800L,1102226227200L,12163505356800L,131369759539200L,1589020051046400L,18899570737152000L,247773823008768000L,3220159580209152000L,BigInteger.Parse("45535430530695168000") };
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
public class A276657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276657Inst Instance=new A276657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276656
{
public static readonly long[] Value={ 2L,3L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,10L,10L,11L,11L,12L,12L,12L,13L,13L,14L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,21L,22L,22L,22L,22L,23L,23L,23L,24L,24L,24L,25L,25L,25L,26L,26L,26L,27L,27L,27L,27L,28L,28L,28L,29L,29L,29L,30L,30L,30L,30L,31L,31L,31L,32L,32L,32L,32L,33L,33L,33L,34L,34L,34L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276656Inst : IEnumerable<long>
{
public static readonly long[] Value=A276656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276656.Bytes);
public long this[int i]=>Value[i];

public static A276656Inst Instance=new A276656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276655
{
public static readonly long[] Value={ 1L,21L,30L,60L,63L,90L,120L,147L,150L,180L,189L,240L,270L,300L,360L,441L,450L,480L,540L,567L,600L,720L,750L,810L,900L,960L,979L,1029L,1080L,1200L,1323L,1350L,1411L,1440L,1463L,1500L,1547L,1620L,1701L,1742L,1800L,1920L,1947L,2059L,2090L,2160L,2210L,2250L,2318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276655Inst : IEnumerable<long>
{
public static readonly long[] Value=A276655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276655.Bytes);
public long this[int i]=>Value[i];

public static A276655Inst Instance=new A276655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276654
{
public static readonly long[] Value={ 2L,21L,2905L,281785L,47740490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276654Inst : IEnumerable<long>
{
public static readonly long[] Value=A276654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276654.Bytes);
public long this[int i]=>Value[i];

public static A276654Inst Instance=new A276654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276653
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276653Inst : IEnumerable<long>
{
public static readonly long[] Value=A276653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276653.Bytes);
public long this[int i]=>Value[i];

public static A276653Inst Instance=new A276653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276652
{
public static readonly long[] Value={ 5L,10L,5L,2L,2L,10L,5L,10L,10L,100L,2L,100L,10L,5L,5L,100L,2L,100L,10L,1L,100L,100L,2L,2L,100L,10L,10L,100L,1L,100L,5L,100L,100L,5L,2L,100L,100L,100L,10L,100L,5L,100L,100L,5L,100L,100L,2L,10L,10L,100L,100L,100L,2L,100L,10L,100L,100L,100L,1L,100L,100L,1L,5L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276652Inst : IEnumerable<long>
{
public static readonly long[] Value=A276652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276652.Bytes);
public long this[int i]=>Value[i];

public static A276652Inst Instance=new A276652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276651
{
public static readonly long[] Value={ 1L,3L,1L,1L,1L,7L,1L,3L,7L,11L,1L,13L,9L,4L,1L,17L,1L,19L,7L,1L,31L,23L,1L,1L,33L,3L,9L,29L,1L,31L,1L,41L,37L,6L,1L,37L,39L,43L,7L,41L,6L,43L,31L,4L,43L,47L,1L,7L,7L,47L,33L,53L,1L,61L,9L,49L,49L,59L,1L,61L,51L,1L,1L,63L,61L,67L,37L,53L,7L,71L,1L,73L,57L,4L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276651Inst : IEnumerable<long>
{
public static readonly long[] Value=A276651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276651.Bytes);
public long this[int i]=>Value[i];

public static A276651Inst Instance=new A276651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276650
{
public static readonly BigInteger[] Value={ 2L,2399L,1801152661459L,BigInteger.Parse("73885357344138503765443") };
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
public class A276650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276650Inst Instance=new A276650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276649
{
public static readonly long[] Value={ 2L,7L,47L,191L,383L,439L,1151L,1399L,2351L,2879L,3119L,3511L,3559L,4127L,5087L,5431L,6911L,8887L,9127L,9791L,9887L,12391L,13151L,14407L,15551L,16607L,19543L,20399L,21031L,21319L,21839L,23039L,25391L,26399L,28087L,28463L,28711L,29287L,33223L,39551L,43103L,44879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276649Inst : IEnumerable<long>
{
public static readonly long[] Value=A276649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276649.Bytes);
public long this[int i]=>Value[i];

public static A276649Inst Instance=new A276649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276648
{
public static readonly long[] Value={ 1L,9L,59L,169L,339L,701L,1243L,1893L,2741L,3943L,5577L,7343L,9409L,12039L,15065L,18421L,22227L,26717L,31879L,37461L,43655L,50557L,58071L,66227L,75121L,85083L,95801L,107227L,119541L,133019L,147271L,161901L,178127L,195481L,214143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276648Inst : IEnumerable<long>
{
public static readonly long[] Value=A276648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276648.Bytes);
public long this[int i]=>Value[i];

public static A276648Inst Instance=new A276648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276647
{
public static readonly long[] Value={ 1L,3L,7L,15L,31L,59L,107L,183L,303L,483L,755L,1151L,1735L,2571L,3787L,5511L,7999L,11507L,16547L,23631L,33783L,48027L,68411L,96983L,137839L,195075L,276883L,391455L,555175L,784427L,1111979L,1570599L,2225823L,3143187L,4453763L,6288623L,8909911L,12579771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276647Inst : IEnumerable<long>
{
public static readonly long[] Value=A276647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276647.Bytes);
public long this[int i]=>Value[i];

public static A276647Inst Instance=new A276647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276646
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,2L,3L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,13L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,20L,20L,21L,21L,22L,22L,23L,24L,24L,25L,26L,26L,27L,28L,28L,29L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276646Inst : IEnumerable<long>
{
public static readonly long[] Value=A276646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276646.Bytes);
public long this[int i]=>Value[i];

public static A276646Inst Instance=new A276646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276645
{
public static readonly long[] Value={ 0L,1L,4L,5L,9L,19L,148L,209L,404L,652L,763L,1739L,2790L,9551L,11117L,13173L,25641L,170003L,181927L,519900L,3253342L,4816257L,7103608L,8269588L,64261168L,177847445L,294878941L,819667577L,844965349L,2944185248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276645Inst : IEnumerable<long>
{
public static readonly long[] Value=A276645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276645.Bytes);
public long this[int i]=>Value[i];

public static A276645Inst Instance=new A276645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276644
{
public static readonly BigInteger[] Value={ 0L,1L,22L,464L,9658L,199666L,4112922L,84558014L,1736623658L,35646098566L,731452470122L,15006822709814L,307859627711658L,6315326642698966L,129547066718721322L,2657377349777550614L,BigInteger.Parse("54509922224486463658"),BigInteger.Parse("1118139793621467673366"),BigInteger.Parse("22935894163202834676522"),BigInteger.Parse("470473020119757115115414") };
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
public class A276644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276644Inst Instance=new A276644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276627
{
public static readonly long[] Value={ 1L,5L,8L,2L,5L,5L,1L,7L,2L,7L,2L,2L,3L,7L,1L,5L,9L,1L,1L,8L,3L,3L,1L,3L,5L,0L,7L,1L,0L,7L,0L,4L,0L,9L,8L,7L,6L,5L,2L,9L,4L,8L,8L,1L,4L,9L,6L,1L,8L,7L,8L,9L,2L,4L,3L,4L,9L,7L,1L,6L,9L,4L,4L,8L,4L,7L,8L,2L,0L,8L,5L,3L,5L,1L,8L,6L,6L,6L,3L,5L,5L,1L,7L,3L,6L,2L,0L,9L,8L,1L,4L,0L,6L,5L,5L,4L,3L,2L,2L,2L,0L,0L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276627Inst : IEnumerable<long>
{
public static readonly long[] Value=A276627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276627.Bytes);
public long this[int i]=>Value[i];

public static A276627Inst Instance=new A276627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276626
{
public static readonly long[] Value={ 10L,22L,34L,58L,94L,142L,178L,202L,214L,382L,394L,454L,502L,538L,634L,718L,922L,934L,1042L,1138L,1294L,1318L,1402L,1438L,1642L,1714L,1762L,1822L,1858L,1894L,1942L,2182L,2218L,2362L,2434L,2518L,2578L,2722L,2734L,2902L,2974L,3118L,3274L,3694L,3778L,3958L,4198L,4282L,4414L,4534L,4594L,4678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276626Inst : IEnumerable<long>
{
public static readonly long[] Value=A276626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276626.Bytes);
public long this[int i]=>Value[i];

public static A276626Inst Instance=new A276626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276625
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,10L,11L,13L,15L,22L,26L,29L,30L,31L,33L,39L,41L,47L,55L,58L,62L,65L,66L,78L,79L,82L,87L,93L,94L,101L,109L,110L,113L,123L,127L,130L,137L,141L,143L,145L,155L,158L,165L,167L,174L,179L,186L,195L,202L,205L,211L,218L,226L,235L,237L,246L,254L,257L,271L,274L,282L,286L,290L,293L,303L,310L,313L,317L,319L,327L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276625Inst : IEnumerable<long>
{
public static readonly long[] Value=A276625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276625.Bytes);
public long this[int i]=>Value[i];

public static A276625Inst Instance=new A276625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276624
{
public static readonly long[] Value={ 0L,2L,8L,4L,26L,20L,16L,12L,10L,80L,72L,68L,62L,56L,52L,46L,42L,38L,34L,30L,28L,242L,232L,224L,216L,212L,204L,198L,194L,188L,180L,176L,170L,164L,160L,152L,144L,140L,134L,126L,122L,116L,110L,106L,100L,96L,92L,88L,84L,82L,728L,716L,706L,698L,688L,680L,672L,664L,656L,648L,644L,634L,626L,618L,610L,602L,594L,590L,582L,576L,572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276624Inst : IEnumerable<long>
{
public static readonly long[] Value=A276624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276624.Bytes);
public long this[int i]=>Value[i];

public static A276624Inst Instance=new A276624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276623
{
public static readonly long[] Value={ 0L,2L,4L,8L,10L,12L,16L,20L,26L,28L,30L,34L,38L,42L,46L,52L,56L,62L,68L,72L,80L,82L,84L,88L,92L,96L,100L,106L,110L,116L,122L,126L,134L,140L,144L,152L,160L,164L,170L,176L,180L,188L,194L,198L,204L,212L,216L,224L,232L,242L,244L,246L,250L,254L,258L,262L,268L,272L,278L,284L,288L,296L,302L,306L,314L,322L,326L,332L,338L,342L,350L,356L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276623Inst : IEnumerable<long>
{
public static readonly long[] Value=A276623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276623.Bytes);
public long this[int i]=>Value[i];

public static A276623Inst Instance=new A276623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276622
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,6L,5L,4L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,123L,122L,121L,120L,119L,118L,117L,116L,115L,114L,113L,112L,111L,110L,109L,108L,107L,106L,105L,104L,103L,102L,101L,100L,99L,98L,97L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276622Inst : IEnumerable<long>
{
public static readonly long[] Value=A276622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276622.Bytes);
public long this[int i]=>Value[i];

public static A276622Inst Instance=new A276622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276621
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276621Inst : IEnumerable<long>
{
public static readonly long[] Value=A276621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276621.Bytes);
public long this[int i]=>Value[i];

public static A276621Inst Instance=new A276621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276620
{
public static readonly long[] Value={ 4L,4L,8L,4L,10L,10L,4L,8L,12L,20L,4L,10L,12L,20L,16L,4L,8L,12L,22L,12L,24L,4L,10L,10L,24L,16L,26L,38L,4L,8L,10L,24L,14L,30L,40L,20L,4L,10L,14L,22L,14L,20L,38L,18L,34L,4L,8L,10L,16L,12L,32L,34L,14L,22L,40L,4L,10L,10L,22L,20L,26L,38L,22L,34L,68L,36L,4L,8L,12L,28L,14L,18L,40L,14L,26L,46L,36L,22L,4L,10L,12L,20L,8L,30L,48L,12L,30L,74L,28L,14L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276620Inst : IEnumerable<long>
{
public static readonly long[] Value=A276620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276620.Bytes);
public long this[int i]=>Value[i];

public static A276620Inst Instance=new A276620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276619
{
public static readonly long[] Value={ 4L,8L,4L,10L,10L,4L,20L,12L,8L,4L,16L,20L,12L,10L,4L,24L,12L,22L,12L,8L,4L,38L,26L,16L,24L,10L,10L,4L,20L,40L,30L,14L,24L,10L,8L,4L,34L,18L,38L,20L,14L,22L,14L,10L,4L,40L,22L,14L,34L,32L,12L,16L,10L,8L,4L,36L,68L,34L,22L,38L,26L,20L,22L,10L,10L,4L,22L,36L,46L,26L,14L,40L,18L,14L,28L,12L,8L,4L,34L,14L,28L,74L,30L,12L,48L,30L,8L,20L,12L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276619Inst : IEnumerable<long>
{
public static readonly long[] Value=A276619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276619.Bytes);
public long this[int i]=>Value[i];

public static A276619Inst Instance=new A276619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276618
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,4L,15L,10L,12L,8L,17L,30L,20L,24L,16L,51L,34L,60L,40L,48L,32L,85L,102L,68L,120L,80L,96L,64L,255L,170L,204L,136L,240L,160L,192L,128L,257L,510L,340L,408L,272L,480L,320L,384L,256L,771L,514L,1020L,680L,816L,544L,960L,640L,768L,512L,1285L,1542L,1028L,2040L,1360L,1632L,1088L,1920L,1280L,1536L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276618Inst : IEnumerable<long>
{
public static readonly long[] Value=A276618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276618.Bytes);
public long this[int i]=>Value[i];

public static A276618Inst Instance=new A276618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276617
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,4L,1L,5L,6L,5L,1L,6L,8L,7L,7L,1L,7L,10L,9L,13L,9L,1L,8L,12L,11L,21L,16L,10L,1L,9L,14L,13L,31L,25L,18L,11L,1L,10L,16L,15L,43L,36L,28L,19L,13L,1L,11L,18L,17L,57L,49L,40L,29L,25L,15L,1L,12L,20L,19L,73L,64L,54L,41L,41L,28L,16L,1L,13L,22L,21L,91L,81L,70L,55L,61L,45L,30L,17L,1L,14L,24L,23L,111L,100L,88L,71L,85L,66L,48L,31L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276617Inst : IEnumerable<long>
{
public static readonly long[] Value=A276617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276617.Bytes);
public long this[int i]=>Value[i];

public static A276617Inst Instance=new A276617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276616
{
public static readonly long[] Value={ 1L,3L,1L,4L,4L,1L,5L,6L,5L,1L,7L,7L,8L,6L,1L,9L,13L,9L,10L,7L,1L,10L,16L,21L,11L,12L,8L,1L,11L,18L,25L,31L,13L,14L,9L,1L,13L,19L,28L,36L,43L,15L,16L,10L,1L,15L,25L,29L,40L,49L,57L,17L,18L,11L,1L,16L,28L,41L,41L,54L,64L,73L,19L,20L,12L,1L,17L,30L,45L,61L,55L,70L,81L,91L,21L,22L,13L,1L,18L,31L,48L,66L,85L,71L,88L,100L,111L,23L,24L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276616Inst : IEnumerable<long>
{
public static readonly long[] Value=A276616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276616.Bytes);
public long this[int i]=>Value[i];

public static A276616Inst Instance=new A276616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276615
{
public static readonly long[] Value={ 0L,7L,7L,7L,5L,7L,7L,7L,5L,7L,4L,7L,7L,7L,5L,7L,7L,7L,5L,9L,7L,7L,7L,5L,7L,7L,7L,5L,7L,4L,7L,7L,7L,7L,7L,7L,7L,5L,7L,7L,7L,5L,7L,4L,7L,7L,7L,5L,7L,7L,12L,9L,3L,7L,7L,7L,5L,7L,7L,7L,5L,7L,4L,7L,7L,7L,5L,7L,7L,12L,9L,7L,7L,7L,5L,7L,7L,5L,7L,7L,7L,5L,7L,7L,7L,5L,7L,4L,7L,7L,7L,5L,7L,7L,12L,9L,7L,7L,7L,5L,7L,7L,12L,11L,7L,7L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276615Inst : IEnumerable<long>
{
public static readonly long[] Value=A276615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276615.Bytes);
public long this[int i]=>Value[i];

public static A276615Inst Instance=new A276615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276614
{
public static readonly long[] Value={ 0L,7L,26L,21L,14L,63L,59L,52L,47L,40L,33L,124L,115L,110L,103L,96L,89L,84L,77L,70L,215L,208L,201L,194L,187L,183L,176L,171L,164L,157L,150L,145L,138L,131L,342L,339L,330L,318L,311L,304L,299L,292L,285L,278L,274L,267L,262L,255L,248L,241L,236L,229L,222L,511L,506L,499L,492L,487L,480L,473L,466L,457L,445L,438L,431L,426L,419L,412L,405L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276614Inst : IEnumerable<long>
{
public static readonly long[] Value=A276614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276614.Bytes);
public long this[int i]=>Value[i];

public static A276614Inst Instance=new A276614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276613
{
public static readonly long[] Value={ 0L,7L,14L,21L,26L,33L,40L,47L,52L,59L,63L,70L,77L,84L,89L,96L,103L,110L,115L,124L,131L,138L,145L,150L,157L,164L,171L,176L,183L,187L,194L,201L,208L,215L,222L,229L,236L,241L,248L,255L,262L,267L,274L,278L,285L,292L,299L,304L,311L,318L,330L,339L,342L,349L,356L,363L,368L,375L,382L,389L,394L,401L,405L,412L,419L,426L,431L,438L,445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276613Inst : IEnumerable<long>
{
public static readonly long[] Value=A276613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276613.Bytes);
public long this[int i]=>Value[i];

public static A276613Inst Instance=new A276613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276612
{
public static readonly long[] Value={ 0L,1L,4L,3L,2L,10L,9L,8L,7L,6L,5L,19L,18L,17L,16L,15L,14L,13L,12L,11L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,77L,76L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276612Inst : IEnumerable<long>
{
public static readonly long[] Value=A276612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276612.Bytes);
public long this[int i]=>Value[i];

public static A276612Inst Instance=new A276612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276563
{
public static readonly long[] Value={ 1L,3L,4L,0L,7L,2L,7L,3L,8L,4L,6L,9L,7L,8L,7L,1L,2L,5L,0L,8L,0L,5L,6L,9L,8L,3L,7L,5L,4L,0L,5L,0L,8L,2L,5L,8L,2L,6L,8L,0L,5L,0L,6L,4L,2L,7L,0L,6L,7L,0L,4L,9L,6L,3L,5L,6L,6L,7L,9L,5L,8L,5L,6L,0L,1L,5L,6L,2L,0L,6L,5L,9L,2L,1L,4L,8L,3L,3L,1L,9L,3L,8L,2L,6L,9L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276563Inst : IEnumerable<long>
{
public static readonly long[] Value=A276563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276563.Bytes);
public long this[int i]=>Value[i];

public static A276563Inst Instance=new A276563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276562
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,3L,1L,8L,7L,4L,1L,16L,15L,10L,5L,1L,32L,35L,22L,13L,6L,1L,64L,83L,54L,29L,16L,7L,1L,128L,199L,134L,73L,36L,19L,8L,1L,256L,479L,340L,185L,92L,43L,22L,9L,1L,512L,1155L,872L,481L,236L,111L,50L,25L,10L,1L,1024L,2787L,2254L,1265L,622L,287L,130L,57L,28L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276562Inst : IEnumerable<long>
{
public static readonly long[] Value=A276562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276562.Bytes);
public long this[int i]=>Value[i];

public static A276562Inst Instance=new A276562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276561
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,0L,1L,3L,6L,7L,2L,4L,5L,7L,10L,13L,14L,1L,3L,4L,7L,9L,12L,16L,18L,19L,21L,22L,24L,31L,1L,4L,5L,10L,11L,14L,17L,19L,22L,25L,26L,31L,32L,34L,35L,41L,47L,49L,50L,52L,55L,56L,61L,0L,3L,6L,7L,10L,12L,13L,18L,25L,27L,28L,30L,37L,40L,45L,46L,48L,51L,55L,58L,61L,63L,66L,70L,72L,76L,81L,82L,87L,88L,91L,93L,96L,100L,102L,103L,105L,111L,115L,117L,121L,123L,126L,4L,5L,14L,17L,22L,25L,28L,29L,32L,37L,40L,43L,44L,47L,50L,52L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276561Inst : IEnumerable<long>
{
public static readonly long[] Value=A276561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276561.Bytes);
public long this[int i]=>Value[i];

public static A276561Inst Instance=new A276561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276560
{
public static readonly long[] Value={ 0L,2L,3L,4L,10L,12L,21L,24L,36L,50L,66L,84L,117L,140L,180L,224L,289L,342L,437L,520L,630L,770L,920L,1104L,1300L,1560L,1809L,2156L,2523L,2940L,3441L,3968L,4620L,5338L,6125L,7092L,8103L,9272L,10608L,12080L,13776L,15624L,17759L,20064L,22680L,25622L,28858L,32496L,36456L,40950L,45849L,51324L,57399L,64044L,71390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276560Inst : IEnumerable<long>
{
public static readonly long[] Value=A276560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276560.Bytes);
public long this[int i]=>Value[i];

public static A276560Inst Instance=new A276560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276559
{
public static readonly long[] Value={ 1L,2L,3L,8L,10L,12L,14L,24L,36L,40L,44L,60L,78L,84L,90L,128L,153L,180L,190L,240L,273L,308L,322L,384L,475L,520L,567L,644L,754L,810L,868L,992L,1122L,1258L,1330L,1548L,1702L,1862L,1950L,2200L,2460L,2646L,2838L,3124L,3510L,3726L,3948L,4320L,4802L,5200L,5457L,6032L,6572L,7128L,7425L,8064L,8778L,9454L,9971L,10680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276559Inst : IEnumerable<long>
{
public static readonly long[] Value=A276559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276559.Bytes);
public long this[int i]=>Value[i];

public static A276559Inst Instance=new A276559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276558
{
public static readonly long[] Value={ 9L,3L,9L,5L,6L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276558Inst : IEnumerable<long>
{
public static readonly long[] Value=A276558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276558.Bytes);
public long this[int i]=>Value[i];

public static A276558Inst Instance=new A276558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276557
{
public static readonly long[] Value={ 1L,1L,2L,4L,17L,39L,191L,410L,1771L,13805L,26459L,170897L,556698L,988053L,3019206L,15074481L,70202708L,115639004L,498047289L,1281427052L,2039282754L,7981334946L,19374343049L,71015123687L,380553620426L,862797574415L,1292837481584L,2875949125749L,4270259833946L,9334145396729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276557Inst : IEnumerable<long>
{
public static readonly long[] Value=A276557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276557.Bytes);
public long this[int i]=>Value[i];

public static A276557Inst Instance=new A276557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276556
{
public static readonly long[] Value={ 5L,281L,461L,4937L,25367L,75997L,1193909L,3464389L,48591863L,23674667L,22486333L,1648510979L,12708853771L,25139472583L,53498475287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276556Inst : IEnumerable<long>
{
public static readonly long[] Value=A276556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276556.Bytes);
public long this[int i]=>Value[i];

public static A276556Inst Instance=new A276556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276555
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,2L,3L,3L,3L,4L,4L,3L,4L,5L,6L,4L,7L,5L,5L,5L,5L,5L,6L,6L,6L,7L,7L,6L,8L,6L,7L,8L,8L,7L,9L,7L,9L,9L,8L,8L,10L,7L,10L,11L,8L,8L,9L,12L,9L,11L,9L,8L,10L,10L,10L,13L,10L,11L,14L,8L,12L,12L,13L,12L,9L,10L,9L,15L,10L,12L,11L,10L,13L,12L,10L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276555Inst : IEnumerable<long>
{
public static readonly long[] Value=A276555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276555.Bytes);
public long this[int i]=>Value[i];

public static A276555Inst Instance=new A276555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276554
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,1L,-2L,-2L,0L,1L,-3L,-3L,-1L,0L,1L,-4L,-3L,2L,0L,0L,1L,-5L,-2L,8L,6L,4L,0L,1L,-6L,0L,16L,12L,12L,4L,0L,1L,-7L,3L,25L,13L,9L,1L,7L,0L,1L,-8L,7L,34L,5L,-12L,-29L,-10L,3L,0L,1L,-9L,12L,42L,-15L,-51L,-78L,-54L,-32L,-2L,0L,1L,-10L,18L,48L,-49L,-102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276554Inst : IEnumerable<long>
{
public static readonly long[] Value=A276554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276554.Bytes);
public long this[int i]=>Value[i];

public static A276554Inst Instance=new A276554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276553
{
public static readonly long[] Value={ 2L,14L,15L,21L,33L,34L,38L,44L,57L,75L,81L,85L,86L,93L,94L,98L,116L,118L,122L,133L,135L,141L,142L,145L,147L,158L,171L,177L,201L,202L,205L,213L,214L,217L,218L,230L,244L,253L,272L,285L,296L,298L,301L,302L,326L,332L,334L,375L,381L,387L,393L,394L,405L,429L,434L,445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276553Inst : IEnumerable<long>
{
public static readonly long[] Value=A276553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276553.Bytes);
public long this[int i]=>Value[i];

public static A276553Inst Instance=new A276553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276552
{
public static readonly long[] Value={ 1L,-3L,-3L,8L,12L,9L,-29L,-54L,-51L,8L,168L,273L,270L,-18L,-546L,-1220L,-1539L,-969L,796L,3693L,6591L,8098L,5412L,-2568L,-16053L,-31524L,-42195L,-38684L,-11868L,41994L,117630L,193365L,235497L,197758L,42852L,-247224L,-639547L,-1041432L,-1291425L,-1184100L,-520650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276552Inst : IEnumerable<long>
{
public static readonly long[] Value=A276552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276552.Bytes);
public long this[int i]=>Value[i];

public static A276552Inst Instance=new A276552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276551
{
public static readonly long[] Value={ 1L,-2L,-3L,2L,6L,12L,1L,-10L,-32L,-46L,-24L,18L,96L,168L,213L,124L,-61L,-386L,-734L,-992L,-957L,-386L,685L,2288L,3939L,5158L,5012L,2930L,-1853L,-8888L,-17283L,-24782L,-28312L,-24422L,-9825L,16674L,54197L,96584L,134729L,153718L,138624L,73438L,-49526L,-228614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276551Inst : IEnumerable<long>
{
public static readonly long[] Value=A276551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276551.Bytes);
public long this[int i]=>Value[i];

public static A276551Inst Instance=new A276551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276550
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,0L,4L,3L,2L,0L,5L,6L,7L,3L,0L,6L,10L,16L,15L,6L,0L,7L,15L,30L,45L,36L,8L,0L,8L,21L,50L,105L,132L,79L,16L,0L,9L,28L,77L,210L,372L,404L,195L,24L,0L,10L,36L,112L,378L,882L,1460L,1296L,477L,42L,0L,11L,45L,156L,630L,1848L,4220L,5890L,4380L,1209L,69L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276550Inst : IEnumerable<long>
{
public static readonly long[] Value=A276550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276550.Bytes);
public long this[int i]=>Value[i];

public static A276550Inst Instance=new A276550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276549
{
public static readonly long[] Value={ 1L,1L,3L,9L,31L,112L,467L,2141L,10739L,58454L,340389L,2110093L,13830234L,95475087L,691543059L,5240282987L,41432986587L,341040306207L,2916376237349L,25862097428262L,237434959190586L,2253358056942644L,22076003468637449L,222979436688500085L,2319295172178428701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276549Inst : IEnumerable<long>
{
public static readonly long[] Value=A276549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276549.Bytes);
public long this[int i]=>Value[i];

public static A276549Inst Instance=new A276549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276548
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,33L,92L,347L,1347L,6338L,31949L,179265L,1071264L,6845487L,46162569L,327731596L,2437753739L,18948597836L,153498350744L,1293123237572L,11306475314372L,102425554267565L,959826755336241L,9290811905211847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276548Inst : IEnumerable<long>
{
public static readonly long[] Value=A276548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276548.Bytes);
public long this[int i]=>Value[i];

public static A276548Inst Instance=new A276548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276067
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,4L,3L,1L,14L,9L,7L,4L,1L,41L,23L,16L,11L,5L,1L,122L,64L,39L,27L,16L,6L,1L,366L,186L,103L,66L,43L,22L,7L,1L,1105L,552L,289L,169L,109L,65L,29L,8L,1L,3356L,1657L,841L,458L,278L,174L,94L,37L,9L,1L,10251L,5013L,2498L,1299L,736L,452L,268L,131L,46L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276067Inst : IEnumerable<long>
{
public static readonly long[] Value=A276067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276067.Bytes);
public long this[int i]=>Value[i];

public static A276067Inst Instance=new A276067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276066
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,2L,1L,0L,1L,2L,4L,1L,4L,1L,0L,1L,4L,6L,8L,8L,1L,6L,1L,0L,1L,7L,14L,22L,12L,19L,12L,1L,8L,1L,0L,1L,13L,34L,43L,48L,55L,18L,35L,16L,1L,10L,1L,0L,1L,26L,72L,105L,148L,109L,116L,103L,24L,56L,20L,1L,12L,1L,0L,1L,52L,154L,276L,344L,347L,398L,205L,232L,166L,30L,82L,24L,1L,14L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276066Inst : IEnumerable<long>
{
public static readonly long[] Value=A276066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276066.Bytes);
public long this[int i]=>Value[i];

public static A276066Inst Instance=new A276066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276065
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,2L,2L,4L,4L,6L,8L,16L,20L,34L,40L,64L,80L,130L,164L,256L,320L,490L,620L,944L,1200L,1800L,2290L,3400L,4344L,6406L,8206L,12008L,15408L,22404L,28810L,41672L,53680L,77258L,99662L,142808L,184480L,263320L,340578L,484392L,627200L,889160L,1152480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276065Inst : IEnumerable<long>
{
public static readonly long[] Value=A276065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276065.Bytes);
public long this[int i]=>Value[i];

public static A276065Inst Instance=new A276065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276064
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,1L,4L,2L,4L,2L,6L,3L,8L,3L,8L,4L,4L,12L,4L,4L,10L,12L,6L,16L,12L,5L,16L,24L,8L,24L,28L,6L,26L,40L,8L,10L,36L,52L,8L,8L,40L,60L,32L,13L,56L,84L,32L,11L,58L,96L,80L,17L,84L,136L,88L,15L,80L,160L,160L,16L,23L,120L,220L,192L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276064Inst : IEnumerable<long>
{
public static readonly long[] Value=A276064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276064.Bytes);
public long this[int i]=>Value[i];

public static A276064Inst Instance=new A276064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276063
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,2L,4L,4L,8L,14L,20L,32L,44L,70L,104L,152L,228L,326L,488L,704L,1026L,1492L,2144L,3120L,4470L,6450L,9256L,13256L,19026L,27144L,38840L,55360L,78910L,112406L,159768L,227240L,322500L,457734L,648996L,919372L,1302114L,1842036L,2605452L,3682112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276063Inst : IEnumerable<long>
{
public static readonly long[] Value=A276063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276063.Bytes);
public long this[int i]=>Value[i];

public static A276063Inst Instance=new A276063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276062
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,1L,4L,3L,4L,2L,8L,4L,6L,4L,3L,12L,4L,6L,8L,12L,4L,20L,12L,8L,14L,28L,5L,32L,24L,8L,11L,24L,52L,8L,7L,52L,40L,32L,15L,38L,96L,32L,10L,80L,72L,88L,21L,56L,172L,80L,16L,14L,122L,132L,192L,16L,29L,84L,304L,160L,80L,19L,184L,232L,392L,80L,40L,128L,516L,312L,256L,26L,278L,384L,768L,240L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276062Inst : IEnumerable<long>
{
public static readonly long[] Value=A276062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276062.Bytes);
public long this[int i]=>Value[i];

public static A276062Inst Instance=new A276062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276061
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,2L,4L,6L,10L,18L,28L,46L,74L,114L,184L,286L,448L,700L,1080L,1676L,2582L,3970L,6104L,9338L,14288L,21808L,33224L,50580L,76844L,116640L,176832L,267740L,405058L,612110L,924204L,1394266L,2101558L,3165406L,4764184L,7165530L,10770386L,16178378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276061Inst : IEnumerable<long>
{
public static readonly long[] Value=A276061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276061.Bytes);
public long this[int i]=>Value[i];

public static A276061Inst Instance=new A276061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276060
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,4L,3L,6L,3L,10L,5L,10L,4L,4L,20L,4L,7L,22L,12L,6L,34L,20L,10L,42L,36L,9L,64L,48L,8L,15L,70L,96L,8L,13L,112L,120L,32L,22L,124L,204L,56L,19L,184L,280L,112L,32L,212L,436L,176L,16L,28L,310L,564L,360L,16L,47L,346L,896L,504L,80L,41L,512L,1128L,920L,144L,69L,570L,1704L,1360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276060Inst : IEnumerable<long>
{
public static readonly long[] Value=A276060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276060.Bytes);
public long this[int i]=>Value[i];

public static A276060Inst Instance=new A276060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276059
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,2L,2L,4L,6L,10L,14L,24L,38L,62L,98L,156L,242L,376L,580L,896L,1380L,2126L,3266L,5008L,7658L,11688L,17804L,27084L,41148L,62448L,94668L,143360L,216864L,327726L,494790L,746368L,1124950L,1694286L,2549942L,3835120L,5764274L,8658442L,12997998L,19501468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276059Inst : IEnumerable<long>
{
public static readonly long[] Value=A276059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276059.Bytes);
public long this[int i]=>Value[i];

public static A276059Inst Instance=new A276059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276058
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,4L,3L,6L,3L,10L,5L,14L,4L,24L,7L,30L,4L,6L,46L,8L,10L,58L,20L,9L,84L,36L,15L,106L,68L,13L,152L,112L,22L,188L,196L,19L,264L,304L,8L,32L,324L,492L,24L,28L,446L,732L,72L,47L,546L,1120L,160L,41L,744L,1616L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276058Inst : IEnumerable<long>
{
public static readonly long[] Value=A276058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276058.Bytes);
public long this[int i]=>Value[i];

public static A276058Inst Instance=new A276058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276057
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,2L,4L,6L,14L,18L,36L,50L,94L,130L,236L,330L,580L,816L,1404L,1984L,3354L,4758L,7932L,11286L,18600L,26532L,43308L,61908L,100232L,143540L,230776L,331008L,528950L,759726L,1207584L,1736534L,2747242L,3954826L,6230444L,8977686L,14090410L,20320854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276057Inst : IEnumerable<long>
{
public static readonly long[] Value=A276057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276057.Bytes);
public long this[int i]=>Value[i];

public static A276057Inst Instance=new A276057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276056
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,2L,4L,3L,6L,3L,6L,4L,5L,10L,4L,4L,12L,12L,7L,18L,16L,6L,22L,24L,8L,10L,34L,36L,8L,9L,36L,52L,32L,15L,58L,76L,40L,13L,60L,108L,80L,16L,22L,96L,160L,112L,16L,19L,100L,204L,192L,80L,32L,160L,312L,272L,96L,28L,162L,376L,440L,240L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276056Inst : IEnumerable<long>
{
public static readonly long[] Value=A276056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276056.Bytes);
public long this[int i]=>Value[i];

public static A276056Inst Instance=new A276056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276055
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,7L,3L,13L,6L,23L,10L,42L,19L,75L,33L,136L,61L,244L,108L,441L,197L,793L,352L,1431L,638L,2576L,1145L,4645L,2069L,8366L,3721L,15080L,6714L,27167L,12087L,48961L,21794L,88215L,39254L,158970L,70755L,286439L,127469L,516164L,229725L,930072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276055Inst : IEnumerable<long>
{
public static readonly long[] Value=A276055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276055.Bytes);
public long this[int i]=>Value[i];

public static A276055Inst Instance=new A276055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276054
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,8L,16L,34L,72L,146L,294L,590L,1156L,2278L,4422L,8572L,16510L,31682L,60558L,115398L,219190L,415348L,784996L,1480600L,2786818L,5236078L,9821222L,18393268L,34397388L,64241880L,119831316L,223266154L,415532226L,772587316L,1435082052L,2663283782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276054Inst : IEnumerable<long>
{
public static readonly long[] Value=A276054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276054.Bytes);
public long this[int i]=>Value[i];

public static A276054Inst Instance=new A276054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276053
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,4L,2L,2L,8L,7L,8L,4L,3L,26L,4L,13L,24L,24L,6L,66L,28L,8L,23L,62L,104L,8L,10L,158L,120L,64L,42L,148L,352L,80L,16L,19L,350L,416L,344L,16L,75L,334L,1052L,448L,160L,33L,756L,1252L,1440L,208L,32L,136L,726L,2860L,1936L,1024L,32L,61L,1578L,3448L,5176L,1440L,384L,244L,1534L,7312L,7056L,5072L,512L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276053Inst : IEnumerable<long>
{
public static readonly long[] Value=A276053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276053.Bytes);
public long this[int i]=>Value[i];

public static A276053Inst Instance=new A276053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276052
{
public static readonly long[] Value={ 5L,4L,3L,2L,15L,106L,21L,127L,3L,39282L,3L,53L,135L,65014L,5L,9489L,171L,361L,27L,19641L,7L,13133L,141L,6326L,3L,6978L,19L,32507L,375L,13094L,165L,93186L,19L,1359L,9L,12588L,15L,171L,45L,35253L,3L,35794L,9L,16796L,7L,1689L,69L,3163L,3L,13653L,57L,3489L,12L,249L,45L,58497L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276052Inst : IEnumerable<long>
{
public static readonly long[] Value=A276052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276052.Bytes);
public long this[int i]=>Value[i];

public static A276052Inst Instance=new A276052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275523
{
public static readonly long[] Value={ 1L,2L,6L,7L,8L,11L,42L,73L,115L,131L,163L,178L,247L,320L,343L,346L,736L,1230L,1556L,3746L,5946L,6020L,6566L,6770L,11302L,14024L,29062L,33268L,37424L,42187L,49216L,51000L,79242L,81287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275523Inst : IEnumerable<long>
{
public static readonly long[] Value=A275523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275523.Bytes);
public long this[int i]=>Value[i];

public static A275523Inst Instance=new A275523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275522
{
public static readonly long[] Value={ 0L,2L,5L,6L,11L,20L,32L,59L,81L,98L,128L,437L,758L,989L,998L,1403L,1548L,1907L,1914L,2219L,5414L,9047L,13196L,18518L,28382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275522Inst : IEnumerable<long>
{
public static readonly long[] Value=A275522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275522.Bytes);
public long this[int i]=>Value[i];

public static A275522Inst Instance=new A275522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275521
{
public static readonly long[] Value={ 1L,0L,1L,4L,3L,40L,15L,420L,105L,5040L,945L,69300L,10395L,1081080L,135135L,18918900L,2027025L,367567200L,34459425L,7856748900L,654729075L,183324141000L,13749310575L,4638100767300L,316234143225L,126493657290000L,7905853580625L,3699939475732500L,213458046676875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275521Inst : IEnumerable<long>
{
public static readonly long[] Value=A275521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275521.Bytes);
public long this[int i]=>Value[i];

public static A275521Inst Instance=new A275521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275520
{
public static readonly long[] Value={ 1L,3L,2L,3L,8L,5L,6L,7L,4L,19L,10L,11L,12L,13L,14L,15L,25L,17L,9L,19L,20L,21L,22L,23L,8L,45L,26L,55L,28L,29L,30L,15L,49L,33L,34L,35L,18L,37L,38L,39L,20L,41L,42L,21L,14L,45L,46L,35L,6L,39L,25L,51L,52L,35L,54L,55L,28L,57L,58L,59L,60L,61L,62L,15L,12L,65L,66L,33L,68L,69L,70L,35L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275520Inst : IEnumerable<long>
{
public static readonly long[] Value=A275520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275520.Bytes);
public long this[int i]=>Value[i];

public static A275520Inst Instance=new A275520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275519
{
public static readonly long[] Value={ 1L,9L,3L,4L,9L,6L,4L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275519Inst : IEnumerable<long>
{
public static readonly long[] Value=A275519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275519.Bytes);
public long this[int i]=>Value[i];

public static A275519Inst Instance=new A275519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275518
{
public static readonly long[] Value={ 1L,2L,5L,16L,67L,364L,2445L,19296L,173015L,1728604L,19011049L,228124384L,2965598547L,41518338684L,622774990133L,9964399645504L,169394793547567L,3049106282938684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275518Inst : IEnumerable<long>
{
public static readonly long[] Value=A275518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275518.Bytes);
public long this[int i]=>Value[i];

public static A275518Inst Instance=new A275518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275517
{
public static readonly BigInteger[] Value={ 1L,0L,0L,4L,39L,472L,7255L,131876L,2771685L,66253552L,1775801814L,52761229240L,1721387545471L,61187851111432L,2353835271333611L,97437447411025008L,4318780849687684325L,BigInteger.Parse("204079128112017902848"),BigInteger.Parse("10241833975586335217950"),BigInteger.Parse("544031400274026445420368") };
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
public class A275517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275517Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275517.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275517Inst Instance=new A275517Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275516
{
public static readonly long[] Value={ 7L,11L,13L,13L,17L,19L,37L,41L,43L,67L,71L,73L,97L,101L,103L,103L,107L,109L,193L,197L,199L,223L,227L,229L,277L,281L,283L,307L,311L,313L,457L,461L,463L,613L,617L,619L,823L,827L,829L,853L,857L,859L,877L,881L,883L,1087L,1091L,1093L,1297L,1301L,1303L,1423L,1427L,1429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275516Inst : IEnumerable<long>
{
public static readonly long[] Value=A275516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275516.Bytes);
public long this[int i]=>Value[i];

public static A275516Inst Instance=new A275516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275515
{
public static readonly long[] Value={ 5L,7L,11L,11L,13L,17L,17L,19L,23L,41L,43L,47L,101L,103L,107L,107L,109L,113L,191L,193L,197L,227L,229L,233L,311L,313L,317L,347L,349L,353L,461L,463L,467L,641L,643L,647L,821L,823L,827L,857L,859L,863L,881L,883L,887L,1091L,1093L,1097L,1277L,1279L,1283L,1301L,1303L,1307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275515Inst : IEnumerable<long>
{
public static readonly long[] Value=A275515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275515.Bytes);
public long this[int i]=>Value[i];

public static A275515Inst Instance=new A275515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275514
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,0L,1L,2L,1L,0L,1L,5L,5L,0L,0L,1L,9L,15L,1L,0L,0L,1L,14L,35L,7L,0L,0L,0L,1L,20L,70L,28L,1L,0L,0L,0L,1L,27L,126L,84L,9L,0L,0L,0L,0L,1L,35L,210L,210L,45L,1L,0L,0L,0L,0L,1L,44L,330L,462L,165L,11L,0L,0L,0L,0L,0L,1L,54L,495L,924L,495L,66L,1L,0L,0L,0L,0L,0L,1L,65L,715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275514Inst : IEnumerable<long>
{
public static readonly long[] Value=A275514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275514.Bytes);
public long this[int i]=>Value[i];

public static A275514Inst Instance=new A275514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275513
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,20L,21L,110L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,111L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,1111L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,11111L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,111111L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,1111111L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,11111111L,82L,83L,84L,85L,86L,87L,88L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275513Inst : IEnumerable<long>
{
public static readonly long[] Value=A275513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275513.Bytes);
public long this[int i]=>Value[i];

public static A275513Inst Instance=new A275513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275512
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,20L,12L,13L,14L,22L,15L,16L,17L,18L,23L,19L,21L,31L,41L,51L,24L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,37L,38L,39L,40L,42L,43L,44L,45L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,71L,81L,91L,100L,101L,62L,63L,64L,65L,66L,67L,68L,69L,70L,72L,73L,74L,75L,76L,77L,78L,79L,80L,82L,83L,84L,85L,86L,87L,88L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275512Inst : IEnumerable<long>
{
public static readonly long[] Value=A275512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275512.Bytes);
public long this[int i]=>Value[i];

public static A275512Inst Instance=new A275512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275511
{
public static readonly long[] Value={ 1L,3L,10L,5L,11L,7L,12L,9L,13L,14L,15L,16L,17L,18L,19L,21L,31L,41L,51L,22L,61L,71L,24L,81L,26L,91L,28L,100L,30L,101L,102L,33L,103L,35L,104L,37L,105L,39L,106L,42L,107L,108L,44L,109L,46L,110L,48L,111L,50L,112L,113L,53L,114L,55L,115L,57L,116L,59L,117L,62L,118L,119L,64L,120L,66L,121L,68L,122L,70L,123L,124L,73L,125L,75L,126L,77L,127L,79L,128L,82L,130L,131L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275511Inst : IEnumerable<long>
{
public static readonly long[] Value=A275511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275511.Bytes);
public long this[int i]=>Value[i];

public static A275511Inst Instance=new A275511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275510
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275510Inst : IEnumerable<long>
{
public static readonly long[] Value=A275510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275510.Bytes);
public long this[int i]=>Value[i];

public static A275510Inst Instance=new A275510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275509
{
public static readonly long[] Value={ 5L,2L,11L,17L,41L,27L,170L,279L,428L,8825L,5879L,27937L,19453L,13871L,41233L,171707L,1100826L,1004646L,1633357L,5460156L,11902755L,49390927L,21627159L,38821328L,41983357L,619535061L,259681234L,1250565732L,799932281L,4168699147L,867086432L,2487208142L,179376463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275509Inst : IEnumerable<long>
{
public static readonly long[] Value=A275509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275509.Bytes);
public long this[int i]=>Value[i];

public static A275509Inst Instance=new A275509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275508
{
public static readonly long[] Value={ 1L,9L,14L,33L,54L,201L,140L,2170L,213L,4529L,10403L,1934L,35811L,162144L,38405L,414225L,200938L,389409L,1792209L,5606457L,18493931L,30947532L,61190563L,8405437L,203631499L,577699919L,158280474L,68780189L,4082994208L,3944563444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275508Inst : IEnumerable<long>
{
public static readonly long[] Value=A275508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275508.Bytes);
public long this[int i]=>Value[i];

public static A275508Inst Instance=new A275508Inst();

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