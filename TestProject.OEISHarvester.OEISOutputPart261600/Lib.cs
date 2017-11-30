using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A277770
{
public static readonly BigInteger[] Value={ 0L,56L,3666L,270291L,20049229L,1487830718L,110036582827L,8144355400488L,602835463794197L,44616311792079721L,3302197502743906336L,BigInteger.Parse("244405001824291326112"),BigInteger.Parse("18089091210686721809130"),BigInteger.Parse("1338824653239265489456655") };
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
public class A277770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277770Inst Instance=new A277770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277771
{
public static readonly BigInteger[] Value={ 0L,284L,46289L,8971150L,1762881313L,343944986355L,67079817376928L,13082674671680942L,2551870774231153918L,BigInteger.Parse("497725696443014836641"),BigInteger.Parse("97078962056423037413261"),BigInteger.Parse("18934823123149797267341357") };
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
public class A277771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277771Inst Instance=new A277771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277772
{
public static readonly BigInteger[] Value={ 0L,1304L,560809L,280603511L,145416104585L,74591651561541L,38224184451654485L,BigInteger.Parse("19594056304528558357"),BigInteger.Parse("10045114847567207328081"),BigInteger.Parse("5149301096028551482379853"),BigInteger.Parse("2639661525564889493885834000"),BigInteger.Parse("1353158899116458615963424246675") };
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
public class A277772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277772Inst Instance=new A277772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277773
{
public static readonly long[] Value={ 1L,0L,4L,3L,16L,15L,64L,47L,256L,191L,1024L,767L,4096L,2815L,16384L,11007L,65536L,44031L,262144L,176127L,1048576L,704511L,4194304L,2818047L,16777216L,11206655L,67108864L,44761087L,268435456L,178978815L,1073741824L,715849727L,4294967296L,2863398911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277773Inst : IEnumerable<long>
{
public static readonly long[] Value=A277773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277773.Bytes);
public long this[int i]=>Value[i];

public static A277773Inst Instance=new A277773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277774
{
public static readonly long[] Value={ 1L,0L,9L,7L,8L,5L,1L,0L,3L,9L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277774Inst : IEnumerable<long>
{
public static readonly long[] Value=A277774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277774.Bytes);
public long this[int i]=>Value[i];

public static A277774Inst Instance=new A277774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277775
{
public static readonly long[] Value={ 8L,3L,7L,1L,1L,3L,2L,1L,2L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277775Inst : IEnumerable<long>
{
public static readonly long[] Value=A277775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277775.Bytes);
public long this[int i]=>Value[i];

public static A277775Inst Instance=new A277775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277776
{
public static readonly long[] Value={ 3L,5L,5L,7L,4L,11L,7L,9L,9L,11L,8L,13L,5L,7L,11L,13L,17L,19L,13L,15L,11L,19L,15L,17L,10L,23L,6L,29L,17L,19L,14L,25L,9L,11L,19L,21L,29L,31L,13L,29L,21L,23L,19L,26L,7L,17L,23L,25L,31L,41L,16L,35L,25L,27L,21L,34L,13L,15L,27L,29L,41L,43L,20L,37L,11L,19L,29L,31L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277776Inst : IEnumerable<long>
{
public static readonly long[] Value=A277776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277776.Bytes);
public long this[int i]=>Value[i];

public static A277776Inst Instance=new A277776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277777
{
public static readonly long[] Value={ 5L,7L,11L,9L,11L,13L,19L,15L,19L,17L,23L,29L,19L,25L,31L,29L,23L,26L,41L,35L,27L,34L,43L,37L,49L,55L,33L,51L,43L,35L,47L,41L,55L,49L,39L,43L,53L,71L,71L,69L,59L,67L,71L,64L,47L,61L,56L,79L,89L,51L,67L,79L,76L,55L,89L,73L,97L,77L,91L,59L,64L,69L,109L,83L,63L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277777Inst : IEnumerable<long>
{
public static readonly long[] Value=A277777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277777.Bytes);
public long this[int i]=>Value[i];

public static A277777Inst Instance=new A277777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277778
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,-1L,0L,0L,1L,0L,1L,2L,1L,-1L,-1L,0L,0L,-1L,0L,1L,1L,-1L,0L,-1L,1L,1L,2L,2L,1L,0L,-1L,-1L,-1L,0L,0L,1L,0L,-1L,-1L,-1L,0L,0L,1L,2L,1L,-1L,-1L,1L,0L,-2L,-1L,0L,1L,-1L,1L,0L,2L,1L,2L,1L,1L,1L,0L,0L,-1L,0L,-1L,-1L,-1L,0L,0L,-1L,0L,1L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277778Inst : IEnumerable<long>
{
public static readonly long[] Value=A277778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277778.Bytes);
public long this[int i]=>Value[i];

public static A277778Inst Instance=new A277778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277779
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,12L,14L,15L,16L,22L,24L,30L,36L,42L,44L,48L,60L,63L,72L,80L,90L,96L,120L,156L,158L,160L,186L,192L,212L,214L,216L,222L,240L,288L,312L,420L,432L,468L,474L,480L,484L,618L,620L,624L,840L,942L,948L,960L,996L,1124L,1200L,1224L,1494L,1560L,1656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277779Inst : IEnumerable<long>
{
public static readonly long[] Value=A277779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277779.Bytes);
public long this[int i]=>Value[i];

public static A277779Inst Instance=new A277779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277812
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,7L,8L,4L,2L,11L,1L,13L,14L,7L,16L,8L,4L,19L,2L,21L,22L,11L,1L,25L,26L,13L,28L,14L,7L,31L,32L,16L,8L,35L,4L,37L,38L,19L,2L,41L,42L,21L,44L,22L,11L,47L,1L,49L,50L,25L,52L,26L,13L,55L,56L,28L,14L,59L,7L,61L,62L,31L,64L,32L,16L,67L,8L,69L,70L,35L,4L,73L,74L,37L,76L,38L,19L,79L,2L,81L,82L,41L,84L,42L,21L,87L,88L,44L,22L,91L,11L,93L,94L,47L,1L,97L,98L,49L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277812Inst : IEnumerable<long>
{
public static readonly long[] Value=A277812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277812.Bytes);
public long this[int i]=>Value[i];

public static A277812Inst Instance=new A277812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277813
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,5L,3L,2L,6L,1L,7L,8L,4L,9L,5L,3L,10L,2L,11L,12L,6L,1L,13L,14L,7L,15L,8L,4L,16L,17L,9L,5L,18L,3L,19L,20L,10L,2L,21L,22L,11L,23L,12L,6L,24L,1L,25L,26L,13L,27L,14L,7L,28L,29L,15L,8L,30L,4L,31L,32L,16L,33L,17L,9L,34L,5L,35L,36L,18L,3L,37L,38L,19L,39L,20L,10L,40L,2L,41L,42L,21L,43L,22L,11L,44L,45L,23L,12L,46L,6L,47L,48L,24L,1L,49L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277813Inst : IEnumerable<long>
{
public static readonly long[] Value=A277813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277813.Bytes);
public long this[int i]=>Value[i];

public static A277813Inst Instance=new A277813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277814
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,5L,6L,7L,8L,8L,8L,9L,9L,10L,11L,12L,13L,14L,14L,14L,14L,14L,15L,16L,16L,16L,16L,17L,17L,18L,19L,20L,21L,22L,22L,23L,23L,23L,23L,23L,23L,23L,23L,23L,23L,24L,25L,26L,27L,27L,27L,27L,27L,27L,27L,28L,28L,28L,28L,29L,29L,30L,31L,32L,33L,34L,34L,35L,35L,35L,35L,36L,37L,37L,37L,37L,37L,37L,37L,37L,38L,38L,38L,38L,38L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277814Inst : IEnumerable<long>
{
public static readonly long[] Value=A277814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277814.Bytes);
public long this[int i]=>Value[i];

public static A277814Inst Instance=new A277814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277815
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,7L,0L,5L,0L,0L,0L,0L,0L,11L,4L,9L,14L,0L,0L,17L,10L,15L,0L,13L,0L,0L,0L,0L,0L,19L,0L,25L,22L,3L,8L,29L,18L,23L,28L,21L,0L,0L,0L,0L,34L,27L,20L,37L,30L,47L,0L,33L,26L,31L,0L,41L,0L,0L,0L,0L,0L,35L,0L,57L,38L,55L,0L,0L,50L,39L,44L,53L,6L,43L,16L,0L,58L,79L,36L,61L,46L,0L,56L,73L,42L,71L,0L,45L,0L,0L,0L,0L,0L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277815Inst : IEnumerable<long>
{
public static readonly long[] Value=A277815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277815.Bytes);
public long this[int i]=>Value[i];

public static A277815Inst Instance=new A277815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277816
{
public static readonly long[] Value={ 0L,5L,10L,39L,20L,13L,78L,11L,40L,21L,26L,19L,156L,29L,22L,27L,80L,25L,42L,35L,52L,45L,38L,43L,312L,37L,58L,51L,44L,41L,54L,59L,160L,57L,50L,67L,84L,53L,70L,75L,104L,61L,90L,79L,76L,93L,86L,55L,624L,101L,74L,99L,116L,77L,102L,71L,88L,69L,82L,115L,108L,85L,118L,123L,320L,121L,114L,131L,100L,117L,134L,91L,168L,89L,106L,147L,140L,109L,150L,83L,208L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277816Inst : IEnumerable<long>
{
public static readonly long[] Value=A277816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277816.Bytes);
public long this[int i]=>Value[i];

public static A277816Inst Instance=new A277816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277817
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,12L,14L,15L,16L,17L,18L,23L,24L,28L,30L,31L,32L,33L,34L,36L,46L,47L,48L,49L,56L,60L,62L,63L,64L,65L,66L,68L,72L,73L,81L,87L,92L,94L,95L,96L,97L,98L,111L,112L,120L,124L,126L,127L,128L,129L,130L,132L,135L,136L,137L,143L,144L,145L,146L,153L,159L,162L,174L,175L,177L,184L,188L,190L,191L,192L,193L,194L,196L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277817Inst : IEnumerable<long>
{
public static readonly long[] Value=A277817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277817.Bytes);
public long this[int i]=>Value[i];

public static A277817Inst Instance=new A277817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277818
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,1L,2L,3L,1L,2L,1L,1L,4L,1L,5L,2L,1L,3L,1L,1L,2L,2L,1L,1L,3L,1L,2L,4L,1L,1L,2L,5L,1L,2L,1L,1L,3L,3L,1L,1L,2L,1L,4L,2L,1L,2L,1L,1L,6L,1L,2L,3L,1L,1L,3L,2L,1L,4L,1L,1L,2L,1L,3L,2L,1L,5L,1L,1L,2L,2L,1L,1L,4L,1L,2L,3L,1L,3L,1L,1L,2L,1L,7L,2L,1L,1L,2L,4L,1L,2L,1L,1L,3L,2L,1L,1L,3L,1L,2L,6L,1L,1L,4L,2L,1L,3L,1L,1L,2L,1L,2L,3L,1L,2L,1L,1L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277818Inst : IEnumerable<long>
{
public static readonly long[] Value=A277818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277818.Bytes);
public long this[int i]=>Value[i];

public static A277818Inst Instance=new A277818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277819
{
public static readonly long[] Value={ 1L,2L,3L,7L,6L,5L,4L,9L,10L,15L,13L,12L,27L,30L,17L,14L,23L,20L,45L,34L,51L,11L,18L,57L,60L,119L,102L,85L,8L,29L,54L,75L,68L,153L,170L,255L,25L,24L,39L,90L,221L,204L,427L,510L,257L,26L,43L,40L,105L,238L,359L,340L,765L,514L,771L,31L,46L,125L,120L,187L,306L,937L,1020L,1799L,1542L,1285L,28L,33L,114L,135L,136L,461L,854L,1275L,1028L,2313L,2570L,3855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277819Inst : IEnumerable<long>
{
public static readonly long[] Value=A277819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277819.Bytes);
public long this[int i]=>Value[i];

public static A277819Inst Instance=new A277819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277820
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,7L,15L,10L,9L,4L,17L,30L,27L,12L,13L,51L,34L,45L,20L,23L,14L,85L,102L,119L,60L,57L,18L,11L,255L,170L,153L,68L,75L,54L,29L,8L,257L,510L,427L,204L,221L,90L,39L,24L,25L,771L,514L,765L,340L,359L,238L,105L,40L,43L,26L,1285L,1542L,1799L,1020L,937L,306L,187L,120L,125L,46L,31L,3855L,2570L,2313L,1028L,1275L,854L,461L,136L,135L,114L,33L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277820Inst : IEnumerable<long>
{
public static readonly long[] Value=A277820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277820.Bytes);
public long this[int i]=>Value[i];

public static A277820Inst Instance=new A277820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277821
{
public static readonly long[] Value={ 1L,3L,2L,10L,4L,5L,6L,36L,9L,8L,28L,14L,15L,21L,7L,136L,11L,27L,120L,19L,91L,105L,20L,44L,45L,55L,13L,78L,35L,12L,66L,528L,77L,17L,496L,90L,435L,465L,43L,53L,325L,351L,54L,406L,18L,65L,378L,152L,153L,171L,16L,210L,135L,34L,190L,300L,26L,119L,276L,25L,231L,253L,104L,2080L,118L,275L,2016L,32L,1891L,1953L,252L,324L,1653L,1711L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277821Inst : IEnumerable<long>
{
public static readonly long[] Value=A277821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277821.Bytes);
public long this[int i]=>Value[i];

public static A277821Inst Instance=new A277821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277822
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,6L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,6L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,7L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,1L,2L,3L,1L,4L,1L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277822Inst : IEnumerable<long>
{
public static readonly long[] Value=A277822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277822.Bytes);
public long this[int i]=>Value[i];

public static A277822Inst Instance=new A277822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277823
{
public static readonly long[] Value={ 3L,6L,9L,12L,23L,18L,29L,24L,43L,46L,33L,36L,63L,58L,53L,48L,83L,86L,89L,92L,71L,66L,77L,72L,123L,126L,113L,116L,111L,106L,101L,96L,163L,166L,169L,172L,183L,178L,189L,184L,139L,142L,129L,132L,159L,154L,149L,144L,243L,246L,249L,252L,231L,226L,237L,232L,219L,222L,209L,212L,207L,202L,197L,192L,323L,326L,329L,332L,343L,338L,349L,344L,363L,366L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277823Inst : IEnumerable<long>
{
public static readonly long[] Value=A277823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277823.Bytes);
public long this[int i]=>Value[i];

public static A277823Inst Instance=new A277823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277824
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,3L,1L,1L,1L,1L,1L,3L,2L,2L,2L,1L,1L,2L,3L,2L,1L,4L,1L,1L,1L,1L,1L,4L,1L,3L,3L,2L,2L,5L,2L,2L,2L,3L,1L,1L,1L,1L,2L,3L,3L,4L,2L,2L,1L,2L,4L,2L,1L,6L,1L,1L,1L,1L,1L,5L,1L,3L,4L,3L,1L,1L,3L,3L,3L,5L,2L,3L,2L,1L,5L,4L,2L,7L,2L,1L,2L,2L,3L,4L,1L,4L,1L,1L,1L,1L,1L,4L,2L,2L,3L,5L,3L,2L,4L,5L,2L,6L,2L,1L,1L,2L,2L,3L,4L,4L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277824Inst : IEnumerable<long>
{
public static readonly long[] Value=A277824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277824.Bytes);
public long this[int i]=>Value[i];

public static A277824Inst Instance=new A277824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277825
{
public static readonly long[] Value={ 5L,10L,27L,20L,57L,54L,39L,40L,125L,114L,99L,108L,65L,78L,95L,80L,245L,250L,235L,228L,201L,198L,215L,216L,141L,130L,147L,156L,177L,190L,175L,160L,485L,490L,507L,500L,473L,470L,455L,456L,413L,402L,387L,396L,417L,430L,447L,432L,277L,282L,267L,260L,297L,294L,311L,312L,365L,354L,371L,380L,337L,350L,335L,320L,965L,970L,987L,980L,1017L,1014L,999L,1000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277825Inst : IEnumerable<long>
{
public static readonly long[] Value=A277825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277825.Bytes);
public long this[int i]=>Value[i];

public static A277825Inst Instance=new A277825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277826
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,1L,6L,7L,8L,9L,2L,7L,12L,1L,14L,15L,16L,17L,18L,7L,4L,9L,14L,23L,24L,17L,2L,15L,28L,1L,30L,31L,32L,33L,34L,7L,36L,17L,14L,3L,8L,1L,18L,23L,28L,9L,46L,47L,48L,49L,34L,15L,4L,17L,30L,47L,56L,33L,2L,31L,60L,1L,62L,63L,64L,65L,66L,7L,68L,33L,14L,47L,72L,73L,34L,3L,28L,17L,6L,23L,16L,81L,2L,23L,36L,1L,46L,87L,56L,73L,18L,47L,92L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277826Inst : IEnumerable<long>
{
public static readonly long[] Value=A277826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277826.Bytes);
public long this[int i]=>Value[i];

public static A277826Inst Instance=new A277826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277827
{
public static readonly long[] Value={ 3L,8L,9L,4L,9L,1L,6L,4L,5L,2L,1L,1L,1L,5L,5L,4L,2L,4L,8L,6L,3L,4L,3L,6L,6L,3L,0L,6L,5L,8L,8L,0L,1L,3L,8L,6L,1L,3L,1L,1L,1L,4L,9L,8L,2L,1L,3L,3L,4L,6L,2L,7L,6L,0L,0L,7L,7L,7L,4L,2L,2L,9L,1L,4L,7L,7L,9L,1L,9L,9L,9L,9L,9L,9L,4L,5L,2L,3L,4L,1L,8L,0L,0L,8L,3L,7L,6L,5L,1L,8L,7L,7L,2L,6L,0L,6L,1L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277827Inst : IEnumerable<long>
{
public static readonly long[] Value=A277827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277827.Bytes);
public long this[int i]=>Value[i];

public static A277827Inst Instance=new A277827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278020
{
public static readonly BigInteger[] Value={ 0L,48510L,35217368L,33064544648L,30622716754158L,28318244060569024L,BigInteger.Parse("26189441962786135952"),BigInteger.Parse("24220244091289286969102"),BigInteger.Parse("22398930025770598869206272"),BigInteger.Parse("20714553726314324138411735648"),BigInteger.Parse("19156837196453052929812096448268") };
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
public class A278020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278020Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278020.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278020Inst Instance=new A278020Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278021
{
public static readonly long[] Value={ 4L,9L,15L,25L,33L,35L,49L,65L,69L,77L,87L,91L,95L,115L,119L,121L,123L,143L,159L,169L,185L,187L,215L,221L,247L,249L,255L,259L,267L,287L,289L,295L,299L,319L,323L,329L,339L,341L,361L,365L,377L,393L,395L,407L,413L,415L,427L,437L,455L,473L,485L,511L,515L,519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278021Inst : IEnumerable<long>
{
public static readonly long[] Value=A278021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278021.Bytes);
public long this[int i]=>Value[i];

public static A278021Inst Instance=new A278021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278022
{
public static readonly long[] Value={ 36L,121L,144L,289L,1764L,2304L,2601L,2809L,4225L,5184L,5329L,6241L,6889L,7056L,8100L,9409L,13225L,15625L,17689L,19881L,23409L,25281L,27225L,30276L,34969L,35721L,38025L,40401L,41616L,42849L,43681L,45369L,63001L,69696L,72361L,78961L,82369L,84681L,87025L,93636L,106929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278022Inst : IEnumerable<long>
{
public static readonly long[] Value=A278022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278022.Bytes);
public long this[int i]=>Value[i];

public static A278022Inst Instance=new A278022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278023
{
public static readonly long[] Value={ 0L,1L,2L,8L,30L,109L,401L,1495L,5623L,21289L,81034L,309817L,1188932L,4576980L,17667647L,68359881L,265045494L,1029512644L,4005417845L,15606129991L,60885118375L,237816401610L,929909358659L,3639712494186L,14258889345834L,55906875628333L,219370377887309L,861389105627213L,3384600499000626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278023Inst : IEnumerable<long>
{
public static readonly long[] Value=A278023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278023.Bytes);
public long this[int i]=>Value[i];

public static A278023Inst Instance=new A278023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278024
{
public static readonly long[] Value={ 1L,3L,5L,13L,37L,107L,341L,1141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278024Inst : IEnumerable<long>
{
public static readonly long[] Value=A278024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278024.Bytes);
public long this[int i]=>Value[i];

public static A278024Inst Instance=new A278024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278025
{
public static readonly long[] Value={ 1L,3L,4L,9L,16L,31L,58L,112L,211L,411L,781L,1526L,2923L,5721L,11023L,21610L,41821L,82112L,159460L,313503L,610531L,1201721L,2345734L,4621899L,9039472L,17827054L,34923997L,68930585L,135231649L,267104311L,524673184L,1036989265L,2039191564L,4032728190L,7937870407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278025Inst : IEnumerable<long>
{
public static readonly long[] Value=A278025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278025.Bytes);
public long this[int i]=>Value[i];

public static A278025Inst Instance=new A278025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278026
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,14L,49L,174L,626L,2276L,8346L,30821L,114495L,427481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278026Inst : IEnumerable<long>
{
public static readonly long[] Value=A278026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278026.Bytes);
public long this[int i]=>Value[i];

public static A278026Inst Instance=new A278026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278027
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,7L,33L,139L,566L,2279L,9132L,36488L,145500L,579318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278027Inst : IEnumerable<long>
{
public static readonly long[] Value=A278027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278027.Bytes);
public long this[int i]=>Value[i];

public static A278027Inst Instance=new A278027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278028
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,4L,5L,1L,2L,2L,1L,6L,7L,8L,9L,10L,11L,1L,1L,1L,12L,13L,14L,15L,16L,17L,18L,19L,3L,1L,20L,2L,2L,21L,22L,23L,24L,1L,3L,25L,26L,27L,4L,1L,28L,29L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278028Inst : IEnumerable<long>
{
public static readonly long[] Value=A278028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278028.Bytes);
public long this[int i]=>Value[i];

public static A278028Inst Instance=new A278028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278029
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,4L,5L,0L,0L,6L,7L,8L,9L,10L,11L,0L,12L,13L,14L,15L,16L,17L,18L,19L,0L,20L,0L,21L,22L,23L,24L,0L,25L,26L,27L,0L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,0L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,0L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278029Inst : IEnumerable<long>
{
public static readonly long[] Value=A278029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278029.Bytes);
public long this[int i]=>Value[i];

public static A278029Inst Instance=new A278029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278030
{
public static readonly long[] Value={ 12L,22L,23L,32L,35L,44L,48L,75L,76L,94L,95L,96L,97L,98L,99L,100L,105L,106L,107L,108L,109L,114L,115L,117L,121L,122L,125L,134L,143L,179L,180L,207L,209L,213L,214L,217L,220L,221L,222L,224L,225L,243L,244L,253L,254L,272L,274L,283L,284L,302L,306L,308L,310L,311L,316L,320L,321L,322L,324L,325L,326L,327L,328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278030Inst : IEnumerable<long>
{
public static readonly long[] Value=A278030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278030.Bytes);
public long this[int i]=>Value[i];

public static A278030Inst Instance=new A278030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278031
{
public static readonly long[] Value={ 2L,4L,6L,13L,19L,22L,24L,28L,33L,42L,51L,59L,66L,75L,84L,93L,101L,103L,109L,129L,138L,189L,198L,202L,211L,299L,499L,7999L,8899L,9999L,18999L,19899L,89999L,799999L,889999L,99999999L,5999999999L,6899999999L,69999999999L,4999999999999L,6999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278031Inst : IEnumerable<long>
{
public static readonly long[] Value=A278031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278031.Bytes);
public long this[int i]=>Value[i];

public static A278031Inst Instance=new A278031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278032
{
public static readonly long[] Value={ 3L,1L,5L,6L,15L,9L,23L,10L,27L,63L,12L,95L,29L,17L,30L,111L,119L,18L,123L,39L,20L,125L,43L,126L,255L,45L,24L,46L,33L,51L,16383L,53L,159L,34L,1023L,36L,175L,183L,54L,187L,189L,40L,1535L,48L,57L,65L,4095L,6143L,58L,66L,60L,190L,68L,1791L,207L,215L,219L,72L,221L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278032Inst : IEnumerable<long>
{
public static readonly long[] Value=A278032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278032.Bytes);
public long this[int i]=>Value[i];

public static A278032Inst Instance=new A278032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278033
{
public static readonly BigInteger[] Value={ 6L,15L,30L,114L,522L,2529L,12636L,69744L,405168L,2449773L,15261150L,97808574L,641284110L,4287838548L,29153498904L,201163103922L,1406107987374L,9941935540692L,71017384630734L,511976000663130L,3721663648494978L,27257992426100979L,201015705767041110L,1491738880927589808L,11134231701698352462UL,BigInteger.Parse("83548054037756075397") };
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
public class A278033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278033Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278033.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278033Inst Instance=new A278033Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278034
{
public static readonly long[] Value={ 12L,-16L,256L,-1012L,17168L,-102432L,1768032L,-12810048L,226260008L,-1831410544L,33000429000L,-286340050052L,5252822116016L,-47718467477584L,890108488876160L,-8340130846927456L,158096635640838140L,-1512328959263997360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278034Inst : IEnumerable<long>
{
public static readonly long[] Value=A278034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278034.Bytes);
public long this[int i]=>Value[i];

public static A278034Inst Instance=new A278034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278035
{
public static readonly long[] Value={ 3L,-4L,64L,-253L,4292L,-25608L,442008L,-3202512L,56565002L,-457852636L,8250107250L,-71585012513L,1313205529004L,-11929616869396L,222527122219040L,-2085032711731864L,39524158910209535L,-378082239815999340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278035Inst : IEnumerable<long>
{
public static readonly long[] Value=A278035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278035.Bytes);
public long this[int i]=>Value[i];

public static A278035Inst Instance=new A278035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278052
{
public static readonly BigInteger[] Value={ 1L,4L,39L,52L,4069L,8573L,258017L,46639L,53371999L,113518551L,768140741L,1560819091L,242830653007L,169134016817L,38186305937387L,408881289764107L,143220706672837L,41293923006131L,9928250098118791L,10936700271572951L,BigInteger.Parse("97615258031147892517"),643700119549549507L,BigInteger.Parse("62211198375587838727") };
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
public class A278052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278052Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278052.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278052Inst Instance=new A278052Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278053
{
public static readonly long[] Value={ 3L,5L,11L,17L,29L,59L,1277L,4421L,110501L,132047L,20996009L,24036581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278053Inst : IEnumerable<long>
{
public static readonly long[] Value=A278053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278053.Bytes);
public long this[int i]=>Value[i];

public static A278053Inst Instance=new A278053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278054
{
public static readonly long[] Value={ 31L,127L,8191L,524287L,2147483647L,2305843009213693951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278054Inst : IEnumerable<long>
{
public static readonly long[] Value=A278054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278054.Bytes);
public long this[int i]=>Value[i];

public static A278054Inst Instance=new A278054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278055
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,6L,7L,8L,9L,9L,10L,11L,12L,12L,13L,14L,15L,15L,16L,17L,17L,18L,18L,19L,20L,21L,21L,22L,23L,24L,24L,25L,26L,26L,27L,27L,28L,29L,30L,30L,31L,32L,33L,33L,34L,35L,35L,36L,36L,37L,38L,39L,39L,40L,41L,42L,42L,43L,44L,44L,45L,45L,46L,47L,48L,48L,49L,50L,50L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278055Inst : IEnumerable<long>
{
public static readonly long[] Value=A278055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278055.Bytes);
public long this[int i]=>Value[i];

public static A278055Inst Instance=new A278055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278056
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,5L,6L,5L,7L,6L,7L,8L,8L,10L,9L,11L,10L,11L,12L,12L,14L,11L,15L,15L,12L,17L,15L,15L,20L,15L,18L,20L,17L,20L,20L,22L,19L,23L,23L,20L,25L,21L,22L,26L,27L,24L,27L,29L,23L,29L,26L,32L,29L,23L,37L,29L,27L,38L,34L,28L,32L,35L,33L,38L,35L,33L,40L,35L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278056Inst : IEnumerable<long>
{
public static readonly long[] Value=A278056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278056.Bytes);
public long this[int i]=>Value[i];

public static A278056Inst Instance=new A278056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278057
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,6L,7L,5L,8L,6L,7L,9L,11L,7L,10L,14L,11L,12L,12L,10L,15L,16L,12L,14L,18L,14L,19L,15L,13L,21L,18L,14L,22L,19L,25L,18L,21L,21L,24L,26L,21L,29L,23L,25L,26L,25L,31L,23L,26L,33L,30L,28L,30L,28L,37L,27L,31L,37L,31L,25L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278057Inst : IEnumerable<long>
{
public static readonly long[] Value=A278057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278057.Bytes);
public long this[int i]=>Value[i];

public static A278057Inst Instance=new A278057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278058
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,3L,7L,8L,5L,9L,6L,7L,10L,12L,10L,8L,12L,12L,14L,11L,16L,9L,19L,16L,8L,21L,17L,13L,15L,22L,13L,23L,20L,18L,22L,24L,20L,24L,24L,16L,20L,30L,29L,22L,27L,30L,23L,20L,36L,34L,22L,34L,27L,28L,30L,34L,36L,25L,37L,41L,27L,38L,32L,44L,36L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278058Inst : IEnumerable<long>
{
public static readonly long[] Value=A278058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278058.Bytes);
public long this[int i]=>Value[i];

public static A278058Inst Instance=new A278058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278059
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,3L,8L,9L,5L,10L,6L,7L,11L,13L,10L,8L,13L,17L,7L,16L,20L,7L,13L,19L,10L,16L,19L,12L,23L,25L,12L,24L,25L,15L,26L,30L,14L,28L,16L,26L,20L,15L,25L,30L,26L,24L,33L,29L,24L,36L,29L,21L,43L,31L,26L,35L,19L,29L,51L,17L,40L,33L,38L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278059Inst : IEnumerable<long>
{
public static readonly long[] Value=A278059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278059.Bytes);
public long this[int i]=>Value[i];

public static A278059Inst Instance=new A278059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278060
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,3L,9L,10L,5L,11L,6L,7L,12L,14L,10L,8L,14L,18L,12L,15L,8L,23L,13L,10L,17L,13L,25L,16L,19L,20L,13L,19L,29L,18L,17L,30L,24L,24L,20L,23L,26L,20L,27L,24L,26L,38L,13L,28L,38L,30L,20L,42L,35L,19L,45L,30L,32L,29L,45L,23L,32L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278060Inst : IEnumerable<long>
{
public static readonly long[] Value=A278060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278060.Bytes);
public long this[int i]=>Value[i];

public static A278060Inst Instance=new A278060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278061
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,3L,10L,11L,5L,12L,6L,7L,13L,15L,10L,8L,15L,19L,12L,16L,14L,14L,10L,27L,12L,18L,15L,25L,23L,19L,18L,28L,19L,13L,22L,25L,17L,27L,21L,25L,24L,34L,17L,27L,44L,18L,30L,38L,18L,35L,27L,27L,36L,34L,26L,33L,45L,25L,28L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278061Inst : IEnumerable<long>
{
public static readonly long[] Value=A278061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278061.Bytes);
public long this[int i]=>Value[i];

public static A278061Inst Instance=new A278061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278062
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,3L,11L,12L,5L,13L,6L,7L,14L,16L,10L,8L,16L,20L,12L,17L,14L,22L,11L,21L,25L,16L,13L,17L,15L,24L,19L,26L,27L,23L,19L,30L,31L,23L,20L,33L,26L,13L,40L,28L,26L,37L,27L,20L,37L,38L,30L,38L,21L,35L,40L,22L,35L,41L,41L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278062Inst : IEnumerable<long>
{
public static readonly long[] Value=A278062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278062.Bytes);
public long this[int i]=>Value[i];

public static A278062Inst Instance=new A278062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278063
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,3L,12L,13L,5L,14L,6L,7L,15L,17L,10L,8L,17L,21L,12L,18L,14L,23L,11L,22L,26L,16L,13L,17L,15L,25L,11L,26L,35L,18L,23L,36L,24L,25L,27L,25L,25L,34L,26L,35L,26L,24L,25L,33L,30L,35L,22L,42L,17L,31L,47L,31L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278063Inst : IEnumerable<long>
{
public static readonly long[] Value=A278063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278063.Bytes);
public long this[int i]=>Value[i];

public static A278063Inst Instance=new A278063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278064
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,3L,13L,14L,5L,15L,6L,7L,16L,18L,10L,8L,18L,22L,12L,19L,14L,24L,11L,23L,27L,16L,13L,17L,15L,26L,20L,10L,27L,36L,20L,15L,42L,14L,31L,21L,34L,28L,15L,23L,50L,14L,31L,54L,24L,19L,23L,42L,32L,31L,34L,51L,14L,36L,61L,29L,17L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278064Inst : IEnumerable<long>
{
public static readonly long[] Value=A278064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278064.Bytes);
public long this[int i]=>Value[i];

public static A278064Inst Instance=new A278064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278065
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,3L,14L,15L,5L,16L,6L,7L,17L,19L,10L,8L,19L,23L,12L,20L,14L,25L,11L,24L,28L,16L,13L,17L,15L,27L,20L,20L,34L,27L,24L,12L,45L,17L,27L,28L,36L,22L,28L,33L,26L,37L,30L,29L,32L,37L,31L,24L,40L,46L,15L,52L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278065Inst : IEnumerable<long>
{
public static readonly long[] Value=A278065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278065.Bytes);
public long this[int i]=>Value[i];

public static A278065Inst Instance=new A278065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278066
{
public static readonly long[] Value={ 5L,2L,5L,2L,5L,7L,2L,12L,2L,12L,2L,12L,7L,4L,14L,14L,10L,14L,7L,14L,6L,26L,10L,4L,20L,33L,2L,33L,2L,33L,2L,33L,2L,38L,2L,38L,2L,38L,7L,4L,40L,40L,10L,40L,7L,14L,6L,78L,10L,4L,46L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278066Inst : IEnumerable<long>
{
public static readonly long[] Value=A278066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278066.Bytes);
public long this[int i]=>Value[i];

public static A278066Inst Instance=new A278066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278067
{
public static readonly long[] Value={ 37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,39L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278067Inst : IEnumerable<long>
{
public static readonly long[] Value=A278067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278067.Bytes);
public long this[int i]=>Value[i];

public static A278067Inst Instance=new A278067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278100
{
public static readonly long[] Value={ 0L,3L,6L,11L,16L,23L,31L,39L,50L,61L,75L,89L,103L,120L,139L,157L,177L,199L,219L,243L,269L,297L,323L,351L,381L,412L,444L,477L,513L,547L,584L,624L,660L,703L,745L,789L,835L,882L,928L,977L,1025L,1073L,1124L,1174L,1230L,1285L,1342L,1400L,1460L,1523L,1582L,1645L,1708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278100Inst : IEnumerable<long>
{
public static readonly long[] Value=A278100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278100.Bytes);
public long this[int i]=>Value[i];

public static A278100Inst Instance=new A278100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278101
{
public static readonly long[] Value={ 1L,4L,2L,3L,9L,8L,3L,5L,6L,7L,16L,8L,12L,5L,6L,7L,10L,11L,13L,14L,15L,25L,18L,12L,20L,24L,7L,10L,11L,13L,14L,15L,17L,19L,21L,22L,23L,36L,32L,27L,20L,24L,28L,10L,11L,13L,14L,15L,17L,19L,21L,22L,23L,26L,29L,30L,31L,33L,34L,35L,49L,32L,48L,45L,24L,28L,40L,44L,13L,14L,15L,17L,19L,21L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278101Inst : IEnumerable<long>
{
public static readonly long[] Value=A278101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278101.Bytes);
public long this[int i]=>Value[i];

public static A278101Inst Instance=new A278101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278102
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,2L,4L,2L,3L,2L,3L,4L,2L,4L,2L,3L,2L,3L,4L,2L,5L,6L,5L,2L,2L,3L,2L,4L,4L,4L,2L,2L,3L,2L,3L,4L,4L,5L,2L,2L,2L,3L,5L,3L,5L,2L,2L,2L,3L,5L,2L,4L,4L,4L,2L,3L,4L,2L,4L,5L,4L,2L,3L,2L,2L,4L,5L,4L,3L,3L,2L,2L,3L,5L,4L,5L,2L,2L,2L,3L,2L,3L,4L,2L,2L,2L,3L,2L,3L,4L,6L,5L,2L,3L,2L,2L,4L,6L,6L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278102Inst : IEnumerable<long>
{
public static readonly long[] Value=A278102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278102.Bytes);
public long this[int i]=>Value[i];

public static A278102Inst Instance=new A278102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278103
{
public static readonly long[] Value={ 1L,4L,2L,9L,8L,3L,16L,8L,25L,18L,12L,36L,32L,27L,20L,49L,32L,64L,50L,48L,45L,81L,72L,100L,98L,75L,121L,98L,144L,128L,108L,169L,162L,147L,125L,196L,162L,225L,200L,192L,180L,256L,242L,289L,288L,243L,324L,288L,361L,338L,300L,400L,392L,363L,320L,441L,392L,484L,450L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278103Inst : IEnumerable<long>
{
public static readonly long[] Value=A278103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278103.Bytes);
public long this[int i]=>Value[i];

public static A278103Inst Instance=new A278103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278104
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,2L,5L,3L,2L,6L,4L,3L,2L,7L,4L,8L,5L,4L,3L,9L,6L,10L,7L,5L,11L,7L,12L,8L,6L,13L,9L,7L,5L,14L,9L,15L,10L,8L,6L,16L,11L,17L,12L,9L,18L,12L,19L,13L,10L,20L,14L,11L,8L,21L,14L,22L,15L,12L,9L,8L,23L,16L,13L,10L,9L,8L,24L,16L,13L,10L,9L,25L,17L,26L,18L,27L,19L,15L,28L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278104Inst : IEnumerable<long>
{
public static readonly long[] Value=A278104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278104.Bytes);
public long this[int i]=>Value[i];

public static A278104Inst Instance=new A278104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278105
{
public static readonly long[] Value={ 3L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278105Inst : IEnumerable<long>
{
public static readonly long[] Value=A278105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278105.Bytes);
public long this[int i]=>Value[i];

public static A278105Inst Instance=new A278105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278106
{
public static readonly long[] Value={ 1L,2L,3L,6L,22L,23L,177L,129L,4954L,58976L,288436L,238773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278106Inst : IEnumerable<long>
{
public static readonly long[] Value=A278106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278106.Bytes);
public long this[int i]=>Value[i];

public static A278106Inst Instance=new A278106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278107
{
public static readonly long[] Value={ 1L,49L,5L,21L,10L,174L,27L,223L,1656L,3901L,1286L,1847L,5095L,3117L,5678L,1727L,14844L,23678L,10986L,33868L,41241L,42794L,50451L,35301L,39546L,206241L,10561L,89600L,50075L,87273L,75922L,142760L,3493L,236213L,277242L,805287L,619149L,333339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278107Inst : IEnumerable<long>
{
public static readonly long[] Value=A278107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278107.Bytes);
public long this[int i]=>Value[i];

public static A278107Inst Instance=new A278107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278108
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,5L,1L,6L,1L,7L,1L,8L,2L,9L,2L,1L,10L,2L,1L,11L,2L,1L,12L,3L,1L,13L,3L,1L,14L,3L,1L,15L,3L,1L,16L,4L,1L,1L,17L,4L,1L,1L,18L,4L,2L,1L,19L,4L,2L,1L,20L,5L,2L,1L,21L,5L,2L,1L,22L,5L,2L,1L,23L,5L,2L,1L,24L,6L,2L,1L,25L,6L,2L,1L,1L,26L,6L,2L,1L,1L,27L,6L,3L,1L,1L,28L,7L,3L,1L,1L,29L,7L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278108Inst : IEnumerable<long>
{
public static readonly long[] Value=A278108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278108.Bytes);
public long this[int i]=>Value[i];

public static A278108Inst Instance=new A278108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278109
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,2L,1L,2L,1L,3L,1L,3L,1L,3L,1L,3L,1L,4L,1L,4L,1L,4L,2L,4L,2L,5L,2L,5L,2L,5L,2L,5L,2L,6L,2L,6L,2L,1L,6L,2L,1L,6L,3L,1L,7L,3L,1L,7L,3L,1L,7L,3L,1L,7L,3L,1L,8L,3L,1L,8L,3L,1L,8L,3L,1L,8L,3L,1L,9L,4L,1L,9L,4L,1L,9L,4L,1L,9L,4L,1L,10L,4L,1L,10L,4L,1L,10L,4L,1L,10L,4L,1L,11L,4L,1L,11L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278109Inst : IEnumerable<long>
{
public static readonly long[] Value=A278109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278109.Bytes);
public long this[int i]=>Value[i];

public static A278109Inst Instance=new A278109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278110
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,4L,12L,12L,12L,24L,24L,24L,24L,48L,48L,144L,144L,288L,288L,288L,288L,576L,2880L,2880L,8640L,17280L,17280L,17280L,17280L,34560L,34560L,34560L,34560L,207360L,207360L,207360L,207360L,414720L,414720L,414720L,414720L,829440L,2488320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278110Inst : IEnumerable<long>
{
public static readonly long[] Value=A278110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278110.Bytes);
public long this[int i]=>Value[i];

public static A278110Inst Instance=new A278110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278111
{
public static readonly long[] Value={ 2L,1L,8L,4L,2L,2L,1L,1L,1L,1L,18L,9L,6L,4L,3L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,32L,16L,10L,8L,6L,5L,4L,4L,3L,3L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,50L,25L,16L,12L,10L,8L,7L,6L,5L,5L,4L,4L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278111Inst : IEnumerable<long>
{
public static readonly long[] Value=A278111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278111.Bytes);
public long this[int i]=>Value[i];

public static A278111Inst Instance=new A278111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278112
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,4L,3L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,4L,3L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,5L,4L,3L,3L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278112Inst : IEnumerable<long>
{
public static readonly long[] Value=A278112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278112.Bytes);
public long this[int i]=>Value[i];

public static A278112Inst Instance=new A278112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278113
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,3L,2L,1L,1L,1L,1L,1L,4L,3L,2L,2L,1L,1L,1L,1L,1L,1L,1L,5L,4L,3L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,6L,4L,3L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,5L,4L,3L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,8L,6L,5L,4L,3L,3L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278113Inst : IEnumerable<long>
{
public static readonly long[] Value=A278113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278113.Bytes);
public long this[int i]=>Value[i];

public static A278113Inst Instance=new A278113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278114
{
public static readonly long[] Value={ 1L,4L,7L,11L,15L,20L,25L,31L,37L,46L,53L,61L,68L,77L,87L,97L,106L,118L,128L,139L,152L,163L,177L,190L,204L,217L,231L,247L,263L,278L,293L,309L,326L,344L,363L,377L,399L,418L,436L,452L,474L,492L,516L,536L,558L,580L,600L,623L,647L,669L,692L,713L,738L,765L,789L,816L,842L,867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278114Inst : IEnumerable<long>
{
public static readonly long[] Value=A278114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278114.Bytes);
public long this[int i]=>Value[i];

public static A278114Inst Instance=new A278114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278115
{
public static readonly long[] Value={ 2L,8L,3L,5L,7L,18L,12L,5L,7L,11L,13L,17L,32L,27L,20L,28L,11L,13L,17L,19L,23L,29L,31L,50L,48L,45L,28L,44L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,72L,48L,45L,63L,44L,52L,68L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,98L,75L,80L,63L,44L,52L,68L,76L,92L,29L,31L,37L,41L,43L,47L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278115Inst : IEnumerable<long>
{
public static readonly long[] Value=A278115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278115.Bytes);
public long this[int i]=>Value[i];

public static A278115Inst Instance=new A278115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278148
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,3L,1L,2L,2L,3L,5L,4L,1L,2L,2L,3L,3L,4L,5L,5L,7L,5L,1L,2L,2L,2L,3L,3L,4L,5L,5L,7L,9L,6L,1L,2L,2L,2L,3L,3L,3L,5L,4L,5L,7L,5L,7L,8L,7L,9L,11L,7L,1L,2L,2L,2L,2L,3L,3L,4L,5L,5L,4L,5L,7L,8L,7L,7L,8L,7L,9L,11L,13L,8L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,5L,5L,7L,5L,6L,9L,7L,8L,7L,7L,8L,10L,11L,9L,11L,13L,15L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278148Inst : IEnumerable<long>
{
public static readonly long[] Value=A278148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278148.Bytes);
public long this[int i]=>Value[i];

public static A278148Inst Instance=new A278148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278149
{
public static readonly long[] Value={ 2L,3L,3L,4L,5L,5L,4L,5L,7L,5L,5L,7L,5L,6L,9L,7L,8L,7L,7L,8L,7L,9L,6L,7L,11L,9L,7L,8L,7L,7L,8L,7L,9L,11L,7L,8L,13L,11L,9L,11L,10L,8L,12L,9L,9L,12L,8L,10L,11L,9L,11L,13L,8L,9L,15L,13L,11L,9L,11L,10L,11L,13L,12L,9L,9L,12L,13L,11L,10L,11L,9L,11L,13L,15L,9L,10L,17L,15L,13L,11L,14L,13L,11L,10L,11L,13L,12L,16L,11L,11L,16L,12L,13L,11L,10L,11L,13L,14L,11L,13L,15L,17L,10L,11L,19L,17L,15L,13L,11L,14L,13L,11L,17L,13L,11L,13L,12L,16L,11L,11L,16L,12L,13L,11L,13L,17L,11L,13L,14L,11L,13L,15L,17L,19L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278149Inst : IEnumerable<long>
{
public static readonly long[] Value=A278149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278149.Bytes);
public long this[int i]=>Value[i];

public static A278149Inst Instance=new A278149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278150
{
public static readonly BigInteger[] Value={ 0L,2L,42L,3382L,1118946L,1459438050L,7332741364328L,143431562727241070L,BigInteger.Parse("10922269761078538034876"),BigInteger.Parse("3236762187328159003256067178"),BigInteger.Parse("3732763619664688373840578545273092") };
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
public class A278150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278150Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278150.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278150Inst Instance=new A278150Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278151
{
public static readonly long[] Value={ 0L,2L,7L,22L,75L,254L,859L,2906L,9831L,33258L,112511L,380622L,1287635L,4356038L,14736371L,49852786L,168650767L,570541458L,1930127927L,6529576006L,22089397403L,74727896142L,252802661835L,855225279050L,2893206395127L,9787647126266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278151Inst : IEnumerable<long>
{
public static readonly long[] Value=A278151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278151.Bytes);
public long this[int i]=>Value[i];

public static A278151Inst Instance=new A278151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278152
{
public static readonly long[] Value={ 0L,7L,42L,268L,1759L,11675L,77102L,509336L,3365082L,22232537L,146885095L,970436014L,6411449580L,42358984701L,279856142429L,1848945655959L,12215561936959L,80705429566515L,533202352449825L,3522746241343707L,23273980363926953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278152Inst : IEnumerable<long>
{
public static readonly long[] Value=A278152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278152.Bytes);
public long this[int i]=>Value[i];

public static A278152Inst Instance=new A278152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278153
{
public static readonly long[] Value={ 0L,22L,268L,3382L,43876L,571214L,7404889L,96014730L,1245182813L,16148180576L,209415726220L,2715786209858L,35219410286723L,456739471814363L,5923180934385869L,76814190061408485L,996157278817145623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278153Inst : IEnumerable<long>
{
public static readonly long[] Value=A278153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278153.Bytes);
public long this[int i]=>Value[i];

public static A278153Inst Instance=new A278153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278154
{
public static readonly BigInteger[] Value={ 0L,75L,1759L,43876L,1118946L,28772962L,736017223L,18830978857L,481877272697L,12331031245847L,315541549100809L,8074473377302998L,206619882344006745L,5287251693347146722L,BigInteger.Parse("135296899872399464823"),BigInteger.Parse("3462148631985469379478") };
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
public class A278154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278154Inst Instance=new A278154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278155
{
public static readonly BigInteger[] Value={ 0L,254L,11675L,571214L,28772962L,1459438050L,73654449669L,3717851037151L,187699707259842L,9476189368415446L,478407914745643442L,BigInteger.Parse("24152577356822109201"),BigInteger.Parse("1219351305393469653908"),BigInteger.Parse("61559372518202872739319") };
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
public class A278155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278155Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278155.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278155Inst Instance=new A278155Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278156
{
public static readonly BigInteger[] Value={ 0L,859L,77102L,7404889L,736017223L,73654449669L,7332741364328L,730168696119876L,72720692813101842L,7242547316810715720L,BigInteger.Parse("721305315619197154090"),BigInteger.Parse("71836875811771995363258"),BigInteger.Parse("7154445488017757277489605") };
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
public class A278156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278156Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278156.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278156Inst Instance=new A278156Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278157
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,7L,7L,0L,0L,22L,42L,22L,0L,0L,75L,268L,268L,75L,0L,0L,254L,1759L,3382L,1759L,254L,0L,0L,859L,11675L,43876L,43876L,11675L,859L,0L,0L,2906L,77102L,571214L,1118946L,571214L,77102L,2906L,0L,0L,9831L,509336L,7404889L,28772962L,28772962L,7404889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278157Inst : IEnumerable<long>
{
public static readonly long[] Value=A278157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278157.Bytes);
public long this[int i]=>Value[i];

public static A278157Inst Instance=new A278157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278158
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,0L,12L,2L,6L,1L,6L,2L,24L,4L,2L,6L,60L,6L,60L,6L,6L,6L,6L,12L,6L,24L,210L,24L,30L,4L,420L,30L,30L,30L,20160L,24L,9240L,420L,12L,30L,60060L,30L,420L,30L,240L,30L,420L,210L,27720L,30L,60L,720L,420L,420L,6L,720L,2310L,30L,210L,30L,2042040L,4620L,24L,210L,7680L,60L,60060L,210L,6L,30240L,510510L,2160L,6486480L,840L,2310L,9240L,9240L,420L,60060L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278158Inst : IEnumerable<long>
{
public static readonly long[] Value=A278158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278158.Bytes);
public long this[int i]=>Value[i];

public static A278158Inst Instance=new A278158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278159
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,4L,6L,30L,2L,4L,4L,12L,6L,12L,30L,210L,2L,4L,4L,12L,4L,8L,12L,60L,6L,12L,12L,36L,30L,60L,210L,2310L,2L,4L,4L,12L,4L,8L,12L,60L,4L,8L,8L,24L,12L,24L,60L,420L,6L,12L,12L,36L,12L,24L,36L,180L,30L,60L,60L,180L,210L,420L,2310L,30030L,2L,4L,4L,12L,4L,8L,12L,60L,4L,8L,8L,24L,12L,24L,60L,420L,4L,8L,8L,24L,8L,16L,24L,120L,12L,24L,24L,72L,60L,120L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278159Inst : IEnumerable<long>
{
public static readonly long[] Value=A278159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278159.Bytes);
public long this[int i]=>Value[i];

public static A278159Inst Instance=new A278159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278160
{
public static readonly long[] Value={ 2L,8L,6L,24L,6L,48L,12L,48L,12L,120L,6L,120L,30L,96L,30L,288L,6L,360L,30L,120L,30L,240L,12L,240L,72L,120L,24L,840L,6L,960L,30L,192L,210L,360L,30L,360L,30L,240L,30L,1680L,6L,840L,60L,120L,60L,480L,12L,1440L,60L,360L,30L,1080L,30L,2160L,210L,240L,30L,840L,6L,840L,60L,384L,420L,1920L,30L,840L,30L,840L,30L,5040L,6L,720L,60L,120L,420L,840L,30L,3360L,48L,480L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278160Inst : IEnumerable<long>
{
public static readonly long[] Value=A278160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278160.Bytes);
public long this[int i]=>Value[i];

public static A278160Inst Instance=new A278160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278161
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,2L,2L,3L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,4L,2L,2L,3L,3L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,2L,2L,3L,2L,2L,2L,4L,2L,2L,4L,4L,2L,2L,2L,4L,3L,3L,3L,4L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,2L,2L,3L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,4L,2L,2L,3L,3L,2L,2L,2L,4L,2L,2L,4L,4L,2L,2L,2L,4L,4L,4L,4L,6L,2L,2L,2L,4L,2L,2L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278161Inst : IEnumerable<long>
{
public static readonly long[] Value=A278161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278161.Bytes);
public long this[int i]=>Value[i];

public static A278161Inst Instance=new A278161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278162
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,6L,2L,12L,6L,6L,2L,6L,6L,30L,2L,6L,2L,30L,12L,6L,2L,30L,6L,30L,2L,6L,2L,30L,6L,6L,6L,30L,12L,30L,6L,6L,2L,30L,12L,6L,2L,12L,6L,60L,6L,6L,6L,210L,6L,6L,6L,6L,6L,30L,2L,30L,2L,120L,6L,6L,6L,6L,6L,30L,6L,6L,2L,30L,24L,6L,12L,6L,30L,210L,2L,30L,6L,30L,6L,6L,6L,30L,12L,210L,2L,6L,6L,30L,6L,30L,2L,30L,6L,60L,2L,6L,6L,30L,30L,60L,6L,6L,6L,30L,6L,30L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278162Inst : IEnumerable<long>
{
public static readonly long[] Value=A278162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278162.Bytes);
public long this[int i]=>Value[i];

public static A278162Inst Instance=new A278162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278163
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278163Inst : IEnumerable<long>
{
public static readonly long[] Value=A278163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278163.Bytes);
public long this[int i]=>Value[i];

public static A278163Inst Instance=new A278163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278196
{
public static readonly long[] Value={ 2436L,5604L,451276L,715220L,831820L,1300156L,7089500L,12132164L,15796476L,26543660L,190569292L,483502844L,761002156L,851376628L,1327710076L,2841940500L,3519222692L,9035836076L,54770336324L,1280011042268L,1820701100652L,3972999029388L,6085253859260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278196Inst : IEnumerable<long>
{
public static readonly long[] Value=A278196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278196.Bytes);
public long this[int i]=>Value[i];

public static A278196Inst Instance=new A278196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278197
{
public static readonly long[] Value={ 56L,792L,8118264L,92669720L,150198136L,1188908248L,1844349560L,3163127352L,4351078600L,5371315400L,7346629512L,11097645016L,16670689208L,18440293320L,684957390936L,6622987708040L,51820051838712L,77195892663512L,133978259344888L,197726516681672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278197Inst : IEnumerable<long>
{
public static readonly long[] Value=A278197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278197.Bytes);
public long this[int i]=>Value[i];

public static A278197Inst Instance=new A278197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278198
{
public static readonly BigInteger[] Value={ 176L,384276336L,2291320912L,5964539504L,10015581680L,290726957916112L,6486674127079088L,60105349839666544L,134819180623301520L,2332821198543892336L,14023788883518847344UL,BigInteger.Parse("126891542690981418000"),BigInteger.Parse("320103136152993290544"),BigInteger.Parse("5852110108921301661040") };
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
public class A278198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278198Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278198.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278198Inst Instance=new A278198Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278199
{
public static readonly BigInteger[] Value={ 4087968L,625846753120L,576672674947168L,1896564103591584L,BigInteger.Parse("21424521360255636320"),BigInteger.Parse("61382395164161775318496"),BigInteger.Parse("25744258930034131533263392"),BigInteger.Parse("54951205445179608281719072"),BigInteger.Parse("1317709210896221493178043552"),BigInteger.Parse("172557592110602218633091543840"),BigInteger.Parse("6647848746214407376439536432805536") };
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
public class A278199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278199Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278199.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278199Inst Instance=new A278199Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278200
{
public static readonly BigInteger[] Value={ 2323520L,37027355200L,8030248384943040L,BigInteger.Parse("55733465144636286656"),BigInteger.Parse("134508188001572923840"),BigInteger.Parse("6179690078238084808000"),BigInteger.Parse("975509982873756796925504"),BigInteger.Parse("69523232218023552371152320"),BigInteger.Parse("638864582333908382360557376"),BigInteger.Parse("1151097146124113726578727360"),BigInteger.Parse("1204186073016375022219516992") };
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
public class A278200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278200Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278200.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278200Inst Instance=new A278200Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278201
{
public static readonly BigInteger[] Value={ 541946240L,47826239745920L,BigInteger.Parse("49760750604354432757376"),BigInteger.Parse("18426207875324210441995136"),BigInteger.Parse("914345304752746677204951178080640"),BigInteger.Parse("377394877138559089794329589034333523822720"),BigInteger.Parse("33381228189530831120385246576357623531476650368"),BigInteger.Parse("23951815370456759593096244705083096637451017834880") };
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
public class A278201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278201Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278201.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278201Inst Instance=new A278201Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278202
{
public static readonly BigInteger[] Value={ 0L,3L,97L,8242L,3295771L,5306819216L,33056811286568L,812312404546266967L,BigInteger.Parse("78877646007318566942149"),BigInteger.Parse("30229204386668969418436705255"),BigInteger.Parse("45720403850059908972915757270717926") };
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
public class A278202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278202Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278202.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278202Inst Instance=new A278202Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278203
{
public static readonly long[] Value={ 0L,15L,97L,666L,4827L,34869L,251260L,1811189L,13056663L,94122538L,678506791L,4891196693L,35259493158L,254177432493L,1832305613593L,13208662283862L,95218154664535L,686405389318065L,4948135785116200L,35669952667919773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278203Inst : IEnumerable<long>
{
public static readonly long[] Value=A278203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278203.Bytes);
public long this[int i]=>Value[i];

public static A278203Inst Instance=new A278203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278204
{
public static readonly long[] Value={ 0L,46L,666L,8242L,117088L,1674402L,23732454L,336380248L,4770344900L,67648850802L,959306211222L,13603641359640L,192909619956550L,2735599405114814L,38792794983910750L,550110139019848618L,7800963216380203384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278204Inst : IEnumerable<long>
{
public static readonly long[] Value=A278204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278204.Bytes);
public long this[int i]=>Value[i];

public static A278204Inst Instance=new A278204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278205
{
public static readonly BigInteger[] Value={ 0L,161L,4827L,117088L,3295771L,93838003L,2644587148L,74502577363L,2100207846025L,59204820850114L,1668914682945041L,47044781998461473L,1326141579240041036L,BigInteger.Parse("37382494487271576091"),BigInteger.Parse("1053771855874680878859"),BigInteger.Parse("29704682675479642221344") };
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
public class A278205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278205Inst Instance=new A278205Inst();

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