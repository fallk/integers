using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A101341
{
public static readonly BigInteger[] Value={ 2L,5L,1597L,BigInteger.Parse("229265413057075367692743352179590077832064383222590237") };
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
public class A101341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101341Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101341.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101341Inst Instance=new A101341Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101342
{
public static readonly BigInteger[] Value={ 0L,1L,2L,13L,610L,1346269L,6557470319842L,BigInteger.Parse("155576970220531065681649693"),BigInteger.Parse("87571595343018854458033386304178158174356588264390370"),BigInteger.Parse("27745922289305716855338470916082815029348872029647830861914852073402148308000613611082094085891168867554589") };
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
public class A101342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101342Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101342.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101342Inst Instance=new A101342Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101343
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,6L,8L,2L,24L,40L,16L,120L,240L,136L,16L,720L,1680L,1232L,272L,5040L,13440L,12096L,3968L,272L,40320L,120960L,129024L,56320L,7936L,362880L,1209600L,1491840L,814080L,176896L,7936L,3628800L,13305600L,18627840L,12207360L,3610112L,353792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101343Inst : IEnumerable<long>
{
public static readonly long[] Value=A101343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101343.Bytes);
public long this[int i]=>Value[i];

public static A101343Inst Instance=new A101343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101344
{
public static readonly long[] Value={ 2L,2L,3L,4L,6L,6L,8L,8L,10L,13L,13L,17L,17L,17L,19L,21L,23L,24L,27L,27L,26L,29L,30L,32L,36L,36L,36L,38L,37L,38L,44L,45L,47L,46L,51L,51L,54L,55L,56L,57L,58L,58L,62L,62L,62L,62L,68L,73L,74L,74L,74L,75L,75L,79L,81L,82L,82L,83L,86L,86L,85L,89L,94L,94L,94L,95L,100L,101L,106L,105L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101344Inst : IEnumerable<long>
{
public static readonly long[] Value=A101344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101344.Bytes);
public long this[int i]=>Value[i];

public static A101344Inst Instance=new A101344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101345
{
public static readonly long[] Value={ 5L,8L,13L,18L,21L,26L,29L,34L,39L,42L,47L,52L,55L,60L,63L,68L,73L,76L,81L,84L,89L,94L,97L,102L,107L,110L,115L,118L,123L,128L,131L,136L,141L,144L,149L,152L,157L,162L,165L,170L,173L,178L,183L,186L,191L,196L,199L,204L,207L,212L,217L,220L,225L,228L,233L,238L,241L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101345Inst : IEnumerable<long>
{
public static readonly long[] Value=A101345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101345.Bytes);
public long this[int i]=>Value[i];

public static A101345Inst Instance=new A101345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101346
{
public static readonly BigInteger[] Value={ 1L,4L,28L,560L,35960L,7624512L,5423611200L,13161885792000L,110859231254749120L,BigInteger.Parse("3293259778311548232704"),BigInteger.Parse("349928324708588104171703296"),BigInteger.Parse("134575849279352109587517966790656") };
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
public class A101346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101346Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101346.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101346Inst Instance=new A101346Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101347
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,6L,3L,1L,8L,10L,1L,10L,20L,5L,1L,12L,33L,20L,1L,14L,49L,49L,7L,1L,16L,68L,96L,34L,1L,18L,90L,165L,99L,9L,1L,20L,115L,260L,225L,52L,1L,22L,143L,385L,440L,176L,11L,1L,24L,174L,544L,777L,456L,74L,1L,26L,208L,741L,1274L,1001L,286L,13L,1L,28L,245L,980L,1974L,1960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101347Inst : IEnumerable<long>
{
public static readonly long[] Value=A101347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101347.Bytes);
public long this[int i]=>Value[i];

public static A101347Inst Instance=new A101347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101348
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,0L,3L,0L,0L,0L,0L,4L,0L,5L,5L,6L,6L,0L,7L,0L,0L,0L,0L,8L,0L,9L,9L,10L,10L,0L,11L,0L,0L,0L,0L,12L,0L,13L,13L,14L,14L,0L,15L,0L,0L,0L,0L,16L,0L,17L,17L,18L,18L,0L,19L,0L,0L,0L,0L,20L,0L,21L,21L,22L,22L,0L,23L,0L,0L,0L,0L,24L,0L,25L,25L,26L,26L,0L,27L,0L,0L,0L,0L,28L,0L,29L,29L,30L,30L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101348Inst : IEnumerable<long>
{
public static readonly long[] Value=A101348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101348.Bytes);
public long this[int i]=>Value[i];

public static A101348Inst Instance=new A101348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101349
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101349Inst : IEnumerable<long>
{
public static readonly long[] Value=A101349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101349.Bytes);
public long this[int i]=>Value[i];

public static A101349Inst Instance=new A101349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101350
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,5L,2L,1L,7L,7L,1L,9L,16L,3L,1L,11L,29L,15L,1L,13L,46L,43L,5L,1L,15L,67L,95L,30L,1L,17L,92L,179L,104L,8L,1L,19L,121L,303L,271L,58L,1L,21L,154L,475L,591L,235L,13L,1L,23L,191L,703L,1140L,705L,109L,1L,25L,232L,995L,2010L,1746L,506L,21L,1L,27L,277L,1359L,3309L,3780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101350Inst : IEnumerable<long>
{
public static readonly long[] Value=A101350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101350.Bytes);
public long this[int i]=>Value[i];

public static A101350Inst Instance=new A101350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101351
{
public static readonly long[] Value={ 2L,4L,9L,18L,36L,71L,140L,276L,545L,1078L,2136L,4239L,8424L,16760L,33377L,66522L,132668L,264727L,528468L,1055340L,2108097L,4212014L,8417264L,16823583L,33629456L,67230256L,134414145L,268753266L,537385140L,1074573863L,2148829916L,4297145604L,8593459169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101351Inst : IEnumerable<long>
{
public static readonly long[] Value=A101351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101351.Bytes);
public long this[int i]=>Value[i];

public static A101351Inst Instance=new A101351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101352
{
public static readonly long[] Value={ 0L,2L,6L,15L,33L,69L,140L,280L,556L,1101L,2179L,4315L,8554L,16978L,33738L,67115L,133637L,266305L,531032L,1059500L,2114840L,4222937L,8434951L,16852215L,33675798L,67305254L,134535510L,268949655L,537702921L,1075088061L,2149661924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101352Inst : IEnumerable<long>
{
public static readonly long[] Value=A101352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101352.Bytes);
public long this[int i]=>Value[i];

public static A101352Inst Instance=new A101352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101353
{
public static readonly long[] Value={ 1L,4L,9L,19L,38L,75L,147L,288L,565L,1111L,2190L,4327L,8567L,16992L,33753L,67131L,133654L,266323L,531051L,1059520L,2114861L,4222959L,8434974L,16852239L,33675823L,67305280L,134535537L,268949683L,537702950L,1075088091L,2149661955L,4298491872L,8595637477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101353Inst : IEnumerable<long>
{
public static readonly long[] Value=A101353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101353.Bytes);
public long this[int i]=>Value[i];

public static A101353Inst Instance=new A101353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101354
{
public static readonly long[] Value={ 4L,52L,232L,1028L,3846L,16678L,89584L,409894L,2166630L,12433014L,67381452L,468282278L,2914549798L,23237125624L,148957518364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101354Inst : IEnumerable<long>
{
public static readonly long[] Value=A101354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101354.Bytes);
public long this[int i]=>Value[i];

public static A101354Inst Instance=new A101354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101355
{
public static readonly BigInteger[] Value={ 1L,56L,145422675L,BigInteger.Parse("383737587959312915862780874001472"),BigInteger.Parse("104855671593334873537054726960536206227962383788929048378607066138235834636350039247224047185071025086703803882342429773895200") };
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
public class A101355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101355Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101355.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101355Inst Instance=new A101355Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101356
{
public static readonly BigInteger[] Value={ 1L,8L,435L,227920L,1278098745L,82575323184816L,BigInteger.Parse("65027115220581214701"),BigInteger.Parse("650673256738362079479972000"),BigInteger.Parse("85317908524399246240116500743559745"),BigInteger.Parse("150076667939221169116862871933576383129271760") };
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
public class A101356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101356Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101356.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101356Inst Instance=new A101356Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101357
{
public static readonly long[] Value={ 0L,1L,3L,9L,25L,60L,126L,238L,414L,675L,1045L,1551L,2223L,3094L,4200L,5580L,7276L,9333L,11799L,14725L,18165L,22176L,26818L,32154L,38250L,45175L,53001L,61803L,71659L,82650L,94860L,108376L,123288L,139689L,157675L,177345L,198801L,222148L,247494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101357Inst : IEnumerable<long>
{
public static readonly long[] Value=A101357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101357.Bytes);
public long this[int i]=>Value[i];

public static A101357Inst Instance=new A101357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101358
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,9L,11L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,24L,26L,27L,28L,29L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,56L,57L,72L,73L,74L,75L,76L,77L,78L,79L,81L,82L,83L,84L,85L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101358Inst : IEnumerable<long>
{
public static readonly long[] Value=A101358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101358.Bytes);
public long this[int i]=>Value[i];

public static A101358Inst Instance=new A101358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101359
{
public static readonly long[] Value={ 0L,2L,4L,7L,10L,12L,18L,25L,30L,36L,48L,54L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,80L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101359Inst : IEnumerable<long>
{
public static readonly long[] Value=A101359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101359.Bytes);
public long this[int i]=>Value[i];

public static A101359Inst Instance=new A101359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101360
{
public static readonly long[] Value={ 2L,2L,2L,3L,7L,22L,83L,326L,1300L,5195L,20776L,83098L,332387L,1329543L,5318166L,21272659L,85090631L,340362521L,1361450080L,5445800316L,21783201259L,87132805033L,348531220128L,1394124880509L,5576499522030L,22305998088117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101360Inst : IEnumerable<long>
{
public static readonly long[] Value=A101360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101360.Bytes);
public long this[int i]=>Value[i];

public static A101360Inst Instance=new A101360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101361
{
public static readonly BigInteger[] Value={ 1L,1L,3L,8L,55L,987L,121393L,267914296L,72723460248141L,BigInteger.Parse("43566776258854844738105"),BigInteger.Parse("7084593923980518516849609894969925639"),BigInteger.Parse("690168906931029935139391829792095612517948949963798093315456") };
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
public class A101361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101361Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101361.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101361Inst Instance=new A101361Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101362
{
public static readonly long[] Value={ 0L,2L,48L,324L,1280L,3750L,9072L,19208L,36864L,65610L,110000L,175692L,269568L,399854L,576240L,810000L,1114112L,1503378L,1994544L,2606420L,3360000L,4278582L,5387888L,6716184L,8294400L,10156250L,12338352L,14880348L,17825024L,21218430L,25110000L,29552672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101362Inst : IEnumerable<long>
{
public static readonly long[] Value=A101362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101362.Bytes);
public long this[int i]=>Value[i];

public static A101362Inst Instance=new A101362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101363
{
public static readonly long[] Value={ 0L,1L,8L,20L,60L,112L,208L,216L,480L,660L,864L,1196L,1568L,2250L,2464L,2992L,3924L,4332L,5160L,8148L,7040L,8096L,10560L,10600L,12064L,15552L,15288L,17052L,25320L,21080L,23360L,30360L,28288L,30940L,36288L,36852L,40128L,50076L,47120L,50840L,67620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101363Inst : IEnumerable<long>
{
public static readonly long[] Value=A101363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101363.Bytes);
public long this[int i]=>Value[i];

public static A101363Inst Instance=new A101363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101364
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,12L,0L,0L,0L,0L,0L,54L,0L,0L,0L,0L,0L,264L,0L,0L,0L,0L,0L,420L,0L,0L,0L,0L,0L,396L,0L,0L,0L,0L,0L,1134L,0L,0L,0L,0L,0L,1200L,0L,0L,0L,0L,0L,1296L,0L,0L,0L,0L,0L,3780L,0L,0L,0L,0L,0L,2310L,0L,0L,0L,0L,0L,2520L,0L,0L,0L,0L,0L,3276L,0L,0L,0L,0L,0L,3612L,0L,0L,0L,0L,0L,4050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101364Inst : IEnumerable<long>
{
public static readonly long[] Value=A101364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101364.Bytes);
public long this[int i]=>Value[i];

public static A101364Inst Instance=new A101364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101365
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,54L,0L,0L,0L,0L,0L,24L,0L,0L,0L,0L,0L,180L,0L,0L,0L,0L,0L,216L,0L,0L,0L,0L,0L,546L,0L,0L,0L,0L,0L,336L,0L,0L,0L,0L,0L,648L,0L,0L,0L,0L,0L,720L,0L,0L,0L,0L,0L,990L,0L,0L,0L,0L,0L,936L,0L,0L,0L,0L,0L,1404L,0L,0L,0L,0L,0L,2352L,0L,0L,0L,0L,0L,1890L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101365Inst : IEnumerable<long>
{
public static readonly long[] Value=A101365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101365.Bytes);
public long this[int i]=>Value[i];

public static A101365Inst Instance=new A101365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101366
{
public static readonly long[] Value={ 3L,7L,8L,42L,48L,57L,33L,82L,78L,77L,83L,189L,154L,92L,321L,341L,549L,664L,106L,1034L,2929L,4072L,5049L,3037L,6957L,7097L,5051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101366Inst : IEnumerable<long>
{
public static readonly long[] Value=A101366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101366.Bytes);
public long this[int i]=>Value[i];

public static A101366Inst Instance=new A101366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101367
{
public static readonly long[] Value={ 5L,3L,19L,15L,29L,6L,74L,19L,111L,147L,185L,91L,197L,269L,122L,159L,72L,827L,1487L,2903L,968L,999L,702L,5803L,326L,2474L,7871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101367Inst : IEnumerable<long>
{
public static readonly long[] Value=A101367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101367.Bytes);
public long this[int i]=>Value[i];

public static A101367Inst Instance=new A101367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101368
{
public static readonly long[] Value={ 1L,1L,3L,13L,61L,291L,1393L,6673L,31971L,153181L,733933L,3516483L,16848481L,80725921L,386781123L,1853179693L,8879117341L,42542407011L,203832917713L,976622181553L,4679277990051L,22419767768701L,107419560853453L,514678036498563L,2465970621639361L,11815175071698241L,56609904736851843L,271234348612560973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101368Inst : IEnumerable<long>
{
public static readonly long[] Value=A101368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101368.Bytes);
public long this[int i]=>Value[i];

public static A101368Inst Instance=new A101368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101369
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,9L,5L,12L,7L,16L,8L,19L,10L,23L,11L,26L,13L,30L,14L,33L,15L,36L,17L,40L,18L,43L,20L,47L,21L,50L,22L,53L,24L,57L,25L,60L,27L,64L,28L,67L,29L,70L,31L,74L,32L,77L,34L,81L,35L,84L,37L,88L,38L,91L,39L,94L,41L,98L,42L,101L,44L,105L,45L,108L,46L,111L,48L,115L,49L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101369Inst : IEnumerable<long>
{
public static readonly long[] Value=A101369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101369.Bytes);
public long this[int i]=>Value[i];

public static A101369Inst Instance=new A101369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101370
{
public static readonly BigInteger[] Value={ 1L,4L,24L,196L,2016L,24976L,361792L,5997872L,111969552L,2324081728L,53089540992L,1323476327488L,35752797376128L,1040367629940352L,32441861122796672L,1079239231677587264L,BigInteger.Parse("38151510015777089280"),BigInteger.Parse("1428149538870997774080"),BigInteger.Parse("56435732691153773665280") };
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
public class A101370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101370Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101370.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101370Inst Instance=new A101370Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101371
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,7L,4L,0L,1L,34L,14L,6L,0L,1L,171L,72L,21L,8L,0L,1L,905L,370L,114L,28L,10L,0L,1L,4952L,1995L,597L,160L,35L,12L,0L,1L,27802L,11064L,3278L,852L,210L,42L,14L,0L,1L,159254L,62774L,18420L,4762L,1135L,264L,49L,16L,0L,1L,927081L,362614L,105618L,27104L,6455L,1446L,322L,56L,18L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101371Inst : IEnumerable<long>
{
public static readonly long[] Value=A101371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101371.Bytes);
public long this[int i]=>Value[i];

public static A101371Inst Instance=new A101371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101372
{
public static readonly long[] Value={ 1L,2L,2L,7L,10L,4L,30L,50L,32L,8L,143L,260L,208L,88L,16L,728L,1400L,1280L,704L,224L,32L,3876L,7752L,7752L,5016L,2128L,544L,64L,21318L,43890L,46816L,33880L,17248L,5984L,1280L,128L,120175L,253000L,283360L,222640L,128800L,54400L,16000L,2944L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101372Inst : IEnumerable<long>
{
public static readonly long[] Value=A101372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101372.Bytes);
public long this[int i]=>Value[i];

public static A101372Inst Instance=new A101372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101373
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,15L,19L,20L,22L,25L,28L,31L,34L,41L,42L,46L,52L,58L,59L,69L,74L,77L,83L,93L,99L,116L,130L,138L,140L,156L,165L,166L,167L,173L,192L,200L,218L,219L,223L,241L,242L,271L,276L,292L,304L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101373Inst : IEnumerable<long>
{
public static readonly long[] Value=A101373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101373.Bytes);
public long this[int i]=>Value[i];

public static A101373Inst Instance=new A101373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101374
{
public static readonly long[] Value={ 0L,1L,8L,39L,124L,305L,636L,1183L,2024L,3249L,4960L,7271L,10308L,14209L,19124L,25215L,32656L,41633L,52344L,64999L,79820L,97041L,116908L,139679L,165624L,195025L,228176L,265383L,306964L,353249L,404580L,461311L,523808L,592449L,667624L,749735L,839196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101374Inst : IEnumerable<long>
{
public static readonly long[] Value=A101374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101374.Bytes);
public long this[int i]=>Value[i];

public static A101374Inst Instance=new A101374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101375
{
public static readonly long[] Value={ 0L,1L,6L,30L,100L,255L,546L,1036L,1800L,2925L,4510L,6666L,9516L,13195L,17850L,23640L,30736L,39321L,49590L,61750L,76020L,92631L,111826L,133860L,159000L,187525L,219726L,255906L,296380L,341475L,391530L,446896L,507936L,575025L,648550L,728910L,816516L,911791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101375Inst : IEnumerable<long>
{
public static readonly long[] Value=A101375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101375.Bytes);
public long this[int i]=>Value[i];

public static A101375Inst Instance=new A101375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101376
{
public static readonly long[] Value={ 0L,1L,14L,99L,424L,1325L,3366L,7399L,14624L,26649L,45550L,73931L,114984L,172549L,251174L,356175L,493696L,670769L,895374L,1176499L,1524200L,1949661L,2465254L,3084599L,3822624L,4695625L,5721326L,6918939L,8309224L,9914549L,11758950L,13868191L,16269824L,18993249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101376Inst : IEnumerable<long>
{
public static readonly long[] Value=A101376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101376.Bytes);
public long this[int i]=>Value[i];

public static A101376Inst Instance=new A101376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101377
{
public static readonly long[] Value={ 0L,1L,16L,117L,496L,1525L,3816L,8281L,16192L,29241L,49600L,79981L,123696L,184717L,267736L,378225L,522496L,707761L,942192L,1234981L,1596400L,2037861L,2571976L,3212617L,3974976L,4875625L,5932576L,7165341L,8594992L,10244221L,12137400L,14300641L,16761856L,19550817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101377Inst : IEnumerable<long>
{
public static readonly long[] Value=A101377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101377.Bytes);
public long this[int i]=>Value[i];

public static A101377Inst Instance=new A101377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101378
{
public static readonly long[] Value={ 0L,1L,18L,126L,520L,1575L,3906L,8428L,16416L,29565L,50050L,80586L,124488L,185731L,269010L,379800L,524416L,710073L,944946L,1238230L,1600200L,2042271L,2577058L,3218436L,3981600L,4883125L,5941026L,7174818L,8605576L,10255995L,12150450L,14315056L,16777728L,19568241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101378Inst : IEnumerable<long>
{
public static readonly long[] Value=A101378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101378.Bytes);
public long this[int i]=>Value[i];

public static A101378Inst Instance=new A101378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101379
{
public static readonly long[] Value={ 0L,1L,27L,256L,1325L,4815L,13916L,34272L,75006L,149925L,278905L,489456L,818467L,1314131L,2038050L,3067520L,4497996L,6445737L,9050631L,12479200L,16927785L,22625911L,29839832L,38876256L,50086250L,63869325L,80677701L,101020752L,125469631L,154662075L,189307390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101379Inst : IEnumerable<long>
{
public static readonly long[] Value=A101379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101379.Bytes);
public long this[int i]=>Value[i];

public static A101379Inst Instance=new A101379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101380
{
public static readonly long[] Value={ 0L,1L,29L,288L,1540L,5725L,16821L,41944L,92688L,186705L,349525L,616616L,1035684L,1669213L,2597245L,3920400L,5763136L,8277249L,11645613L,16086160L,21856100L,29256381L,38636389L,50398888L,65005200L,82980625L,104920101L,131494104L,163454788L,201642365L,246991725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101380Inst : IEnumerable<long>
{
public static readonly long[] Value=A101380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101380.Bytes);
public long this[int i]=>Value[i];

public static A101380Inst Instance=new A101380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101381
{
public static readonly long[] Value={ 0L,1L,30L,300L,1600L,5925L,17346L,43120L,95040L,191025L,356950L,628716L,1054560L,1697605L,2638650L,3979200L,5844736L,8388225L,11793870L,16281100L,22108800L,29579781L,39045490L,50910960L,65640000L,83760625L,105870726L,132643980L,164836000L,203290725L,248947050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101381Inst : IEnumerable<long>
{
public static readonly long[] Value=A101381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101381.Bytes);
public long this[int i]=>Value[i];

public static A101381Inst Instance=new A101381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101382
{
public static readonly long[] Value={ 0L,3L,196L,4418L,43320L,257645L,1108828L,3810996L,11105328L,28524615L,66322740L,142270678L,285547496L,541981713L,980925260L,1704069160L,2856536928L,4640618571L,7332534948L,11302649130L,17039568280L,25178606453L,36535105596L,52143138908L,73300147600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101382Inst : IEnumerable<long>
{
public static readonly long[] Value=A101382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101382.Bytes);
public long this[int i]=>Value[i];

public static A101382Inst Instance=new A101382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101383
{
public static readonly long[] Value={ 0L,1L,14L,94L,380L,1135L,2786L,5964L,11544L,20685L,34870L,55946L,86164L,128219L,185290L,261080L,359856L,486489L,646494L,846070L,1092140L,1392391L,1755314L,2190244L,2707400L,3317925L,4033926L,4868514L,5835844L,6951155L,8230810L,9692336L,11354464L,13237169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101383Inst : IEnumerable<long>
{
public static readonly long[] Value=A101383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101383.Bytes);
public long this[int i]=>Value[i];

public static A101383Inst Instance=new A101383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101384
{
public static readonly long[] Value={ 0L,0L,1L,60L,594L,3040L,10875L,30996L,75460L,163584L,324405L,599500L,1046166L,1740960L,2783599L,4301220L,6453000L,9435136L,13486185L,18892764L,25995610L,35196000L,46962531L,61838260L,80448204L,103507200L,131828125L,166330476L,208049310L,258144544L,317910615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101384Inst : IEnumerable<long>
{
public static readonly long[] Value=A101384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101384.Bytes);
public long this[int i]=>Value[i];

public static A101384Inst Instance=new A101384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101385
{
public static readonly long[] Value={ 3L,8L,8L,21L,34L,21L,24L,144L,144L,24L,55L,152L,987L,152L,55L,58L,610L,1008L,1008L,610L,58L,63L,618L,6765L,1032L,6765L,618L,63L,144L,644L,6786L,6820L,6820L,6786L,644L,144L,147L,2584L,6909L,6844L,75025L,6844L,6909L,2584L,147L,152L,2592L,46368L,6972L,75080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101385Inst : IEnumerable<long>
{
public static readonly long[] Value=A101385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101385.Bytes);
public long this[int i]=>Value[i];

public static A101385Inst Instance=new A101385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101386
{
public static readonly long[] Value={ 5L,27L,157L,915L,5333L,31083L,181165L,1055907L,6154277L,35869755L,209064253L,1218515763L,7102030325L,41393666187L,241259966797L,1406166134595L,8195736840773L,47768254910043L,278413792619485L,1622714500806867L,9457873212221717L,55124524772523435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101386Inst : IEnumerable<long>
{
public static readonly long[] Value=A101386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101386.Bytes);
public long this[int i]=>Value[i];

public static A101386Inst Instance=new A101386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101387
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,5L,1L,1L,7L,1L,2L,1L,9L,1L,3L,1L,12L,1L,1L,4L,1L,15L,1L,2L,1L,5L,1L,18L,1L,3L,1L,7L,1L,1L,21L,1L,4L,1L,9L,1L,2L,1L,24L,1L,5L,1L,11L,1L,3L,1L,28L,1L,1L,6L,1L,13L,1L,4L,1L,32L,1L,2L,1L,7L,1L,15L,1L,5L,1L,36L,1L,3L,1L,9L,1L,1L,17L,1L,6L,1L,40L,1L,4L,1L,11L,1L,2L,1L,19L,1L,7L,1L,44L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101387Inst : IEnumerable<long>
{
public static readonly long[] Value=A101387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101387.Bytes);
public long this[int i]=>Value[i];

public static A101387Inst Instance=new A101387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101388
{
public static readonly long[] Value={ 1L,1L,8L,137L,7704L,1413982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101388Inst : IEnumerable<long>
{
public static readonly long[] Value=A101388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101388.Bytes);
public long this[int i]=>Value[i];

public static A101388Inst Instance=new A101388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101389
{
public static readonly long[] Value={ 1L,1L,3L,21L,369L,16929L,1913682L,546626268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101389Inst : IEnumerable<long>
{
public static readonly long[] Value=A101389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101389.Bytes);
public long this[int i]=>Value[i];

public static A101389Inst Instance=new A101389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101390
{
public static readonly long[] Value={ 1L,0L,1L,2L,7L,41L,347L,5447L,158097L,8456025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101390Inst : IEnumerable<long>
{
public static readonly long[] Value=A101390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101390.Bytes);
public long this[int i]=>Value[i];

public static A101390Inst Instance=new A101390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101391
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,4L,6L,4L,1L,2L,9L,10L,5L,1L,6L,15L,20L,15L,6L,1L,4L,18L,34L,35L,21L,7L,1L,6L,27L,56L,70L,56L,28L,8L,1L,4L,30L,80L,125L,126L,84L,36L,9L,1L,10L,45L,120L,210L,252L,210L,120L,45L,10L,1L,4L,42L,154L,325L,461L,462L,330L,165L,55L,11L,1L,12L,66L,220L,495L,792L,924L,792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101391Inst : IEnumerable<long>
{
public static readonly long[] Value=A101391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101391.Bytes);
public long this[int i]=>Value[i];

public static A101391Inst Instance=new A101391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101392
{
public static readonly long[] Value={ 0L,1L,5L,25L,455L,761L,9205L,13561L,15955L,26669L,113941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101392Inst : IEnumerable<long>
{
public static readonly long[] Value=A101392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101392.Bytes);
public long this[int i]=>Value[i];

public static A101392Inst Instance=new A101392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101393
{
public static readonly long[] Value={ 1L,2L,218L,692L,1805L,2207L,2873L,59135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101393Inst : IEnumerable<long>
{
public static readonly long[] Value=A101393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101393.Bytes);
public long this[int i]=>Value[i];

public static A101393Inst Instance=new A101393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101394
{
public static readonly long[] Value={ 0L,2L,4L,5L,8L,9L,28L,191L,196L,2038L,34414L,39266L,50579L,94286L,108412L,130480L,178091L,185355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101394Inst : IEnumerable<long>
{
public static readonly long[] Value=A101394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101394.Bytes);
public long this[int i]=>Value[i];

public static A101394Inst Instance=new A101394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101395
{
public static readonly long[] Value={ 0L,1L,3L,9L,39L,2323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101395Inst : IEnumerable<long>
{
public static readonly long[] Value=A101395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101395.Bytes);
public long this[int i]=>Value[i];

public static A101395Inst Instance=new A101395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101396
{
public static readonly long[] Value={ 1L,17L,19L,29L,43L,119L,173L,949L,1609L,5579L,19679L,34147L,43493L,97799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101396Inst : IEnumerable<long>
{
public static readonly long[] Value=A101396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101396.Bytes);
public long this[int i]=>Value[i];

public static A101396Inst Instance=new A101396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101397
{
public static readonly long[] Value={ 0L,1L,3L,7L,10L,40L,419L,449L,1737L,2245L,3131L,3813L,5345L,5659L,5681L,8410L,9097L,11293L,21061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101397Inst : IEnumerable<long>
{
public static readonly long[] Value=A101397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101397.Bytes);
public long this[int i]=>Value[i];

public static A101397Inst Instance=new A101397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101398
{
public static readonly long[] Value={ 1L,2L,14L,20L,30L,44L,66L,260L,872L,8846L,26744L,57506L,98472L,106892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101398Inst : IEnumerable<long>
{
public static readonly long[] Value=A101398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101398.Bytes);
public long this[int i]=>Value[i];

public static A101398Inst Instance=new A101398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101399
{
public static readonly long[] Value={ 1L,2L,5L,10L,22L,47L,101L,217L,466L,1001L,2150L,4618L,9919L,21305L,45761L,98290L,211117L,453458L,973982L,2092015L,4493437L,9651449L,20730338L,44526673L,95638798L,205422482L,441226751L,947710513L,2035586497L,4372234274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101399Inst : IEnumerable<long>
{
public static readonly long[] Value=A101399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101399.Bytes);
public long this[int i]=>Value[i];

public static A101399Inst Instance=new A101399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101400
{
public static readonly long[] Value={ 1L,2L,5L,10L,21L,44L,91L,190L,395L,822L,1711L,3560L,7409L,15418L,32085L,66770L,138949L,289156L,601739L,1252230L,2605915L,5422958L,11285279L,23484880L,48872481L,101704562L,211649125L,440445850L,916576181L,1907412444L,3969361531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101400Inst : IEnumerable<long>
{
public static readonly long[] Value=A101400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101400.Bytes);
public long this[int i]=>Value[i];

public static A101400Inst Instance=new A101400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101401
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,3L,12L,24L,15L,4L,55L,110L,75L,28L,5L,273L,546L,390L,168L,45L,6L,1428L,2856L,2100L,980L,315L,66L,7L,7752L,15504L,11628L,5712L,2040L,528L,91L,8L,43263L,86526L,65835L,33516L,12825L,3762L,819L,120L,9L,246675L,493350L,379500L,198352L,79695L,25410L,6370L,1200L,153L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101401Inst : IEnumerable<long>
{
public static readonly long[] Value=A101401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101401.Bytes);
public long this[int i]=>Value[i];

public static A101401Inst Instance=new A101401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101402
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,9L,9L,9L,9L,10L,10L,10L,11L,11L,12L,12L,13L,13L,13L,14L,14L,15L,15L,15L,15L,16L,16L,16L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,24L,24L,24L,25L,25L,26L,26L,26L,26L,27L,27L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101402Inst : IEnumerable<long>
{
public static readonly long[] Value=A101402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101402.Bytes);
public long this[int i]=>Value[i];

public static A101402Inst Instance=new A101402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101403
{
public static readonly long[] Value={ 1L,3L,2L,4L,3L,2L,3L,3L,2L,4L,3L,2L,2L,3L,2L,4L,3L,2L,3L,3L,2L,4L,3L,3L,3L,2L,4L,3L,2L,3L,3L,2L,4L,3L,2L,2L,3L,2L,4L,3L,2L,3L,3L,2L,4L,3L,2L,3L,2L,4L,3L,2L,3L,3L,2L,4L,3L,2L,2L,3L,2L,4L,3L,2L,3L,3L,2L,4L,3L,3L,3L,2L,4L,3L,2L,3L,3L,2L,4L,3L,2L,2L,3L,2L,4L,3L,2L,3L,3L,2L,4L,4L,3L,2L,4L,3L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101403Inst : IEnumerable<long>
{
public static readonly long[] Value=A101403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101403.Bytes);
public long this[int i]=>Value[i];

public static A101403Inst Instance=new A101403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101404
{
public static readonly long[] Value={ 0L,3L,4L,12L,12L,10L,18L,21L,16L,36L,30L,22L,24L,39L,28L,60L,48L,34L,54L,57L,40L,84L,66L,69L,72L,50L,104L,81L,56L,87L,90L,62L,128L,99L,68L,70L,108L,74L,152L,117L,80L,123L,126L,86L,176L,135L,92L,141L,96L,196L,150L,102L,156L,159L,108L,220L,168L,114L,116L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101404Inst : IEnumerable<long>
{
public static readonly long[] Value=A101404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101404.Bytes);
public long this[int i]=>Value[i];

public static A101404Inst Instance=new A101404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101405
{
public static readonly long[] Value={ 1L,1L,3L,16L,25L,216L,343L,4096L,6561L,10000L,14641L,248832L,371293L,7529536L,11390625L,16777216L,24137569L,612220032L,893871739L,25600000000L,37822859361L,54875873536L,78310985281L,2641807540224L,3814697265625L,5429503678976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101405Inst : IEnumerable<long>
{
public static readonly long[] Value=A101405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101405.Bytes);
public long this[int i]=>Value[i];

public static A101405Inst Instance=new A101405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101406
{
public static readonly long[] Value={ 3L,2L,3L,2L,2L,3L,3L,19L,2L,2L,45L,7L,15L,7L,5L,5L,44L,2L,4L,3L,84L,62L,128L,5L,4L,90L,16L,37L,15L,11L,311L,15L,295L,72L,3L,3L,242L,2L,126L,64L,152L,11L,78L,26L,2L,13L,14L,26L,140L,2L,24L,16L,157L,4L,49L,13L,2L,123L,64L,16L,61L,206L,6L,76L,412L,31L,84L,23L,24L,9L,471L,26L,422L,227L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101406Inst : IEnumerable<long>
{
public static readonly long[] Value=A101406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101406.Bytes);
public long this[int i]=>Value[i];

public static A101406Inst Instance=new A101406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101407
{
public static readonly BigInteger[] Value={ 4L,4L,16L,4096L,281474976710656L,BigInteger.Parse("1766847064778384329583297500742918515827483896875618958121606201292619776") };
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
public class A101407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101407Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101407.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101407Inst Instance=new A101407Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101408
{
public static readonly long[] Value={ 13L,19L,31L,61L,97L,103L,109L,151L,163L,181L,193L,223L,229L,277L,283L,307L,367L,373L,409L,433L,439L,487L,499L,523L,571L,601L,607L,613L,619L,709L,733L,787L,811L,823L,877L,907L,997L,1013L,1019L,1031L,1039L,1061L,1063L,1069L,1087L,1097L,1103L,1109L,1129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101408Inst : IEnumerable<long>
{
public static readonly long[] Value=A101408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101408.Bytes);
public long this[int i]=>Value[i];

public static A101408Inst Instance=new A101408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101409
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,4L,12L,19L,16L,8L,55L,85L,73L,44L,16L,273L,416L,361L,234L,112L,32L,1428L,2156L,1883L,1269L,680L,272L,64L,7752L,11628L,10200L,7043L,4016L,1856L,640L,128L,43263L,64581L,56829L,39897L,23665L,11864L,4848L,1472L,256L,246675L,366850L,323587L,229936L,140161L,74050L,33360L,12256L,3328L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101409Inst : IEnumerable<long>
{
public static readonly long[] Value=A101409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101409.Bytes);
public long this[int i]=>Value[i];

public static A101409Inst Instance=new A101409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101410
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,1L,61L,2L,52L,23L,4L,5L,8L,1L,521L,61L,2L,52L,4L,5L,526L,8L,1L,521L,2L,52L,5213L,4L,5L,526L,1L,521L,2L,52L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101410Inst : IEnumerable<long>
{
public static readonly long[] Value=A101410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101410.Bytes);
public long this[int i]=>Value[i];

public static A101410Inst Instance=new A101410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101411
{
public static readonly BigInteger[] Value={ 2L,5L,12L,29L,169L,408L,470832L,6625109L,44560482149L,345869461223138161L,BigInteger.Parse("13558774610046711780701"),BigInteger.Parse("87275373599917999482560755526644279276078854297832438763690789") };
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
public class A101411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101411Inst Instance=new A101411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101412
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,9L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,9L,2L,3L,4L,5L,6L,7L,8L,9L,10L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,9L,2L,3L,4L,5L,6L,7L,8L,9L,10L,3L,4L,5L,6L,7L,8L,9L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,9L,2L,3L,4L,5L,6L,7L,8L,9L,2L,3L,4L,5L,6L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101412Inst : IEnumerable<long>
{
public static readonly long[] Value=A101412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101412.Bytes);
public long this[int i]=>Value[i];

public static A101412Inst Instance=new A101412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101413
{
public static readonly long[] Value={ 1L,-1L,1L,-3L,2L,1L,-8L,17L,-10L,1L,-22L,129L,-248L,140L,1L,-64L,1053L,-5666L,10556L,-5880L,1L,-196L,9501L,-144662L,758468L,-1399272L,776160L,1L,-625L,93585L,-4220591L,62818466L,-326782044L,601063848L,-332972640L,1L,-2055L,987335L,-138047141L,6098263596L,-90157188424L,467899386768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101413Inst : IEnumerable<long>
{
public static readonly long[] Value=A101413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101413.Bytes);
public long this[int i]=>Value[i];

public static A101413Inst Instance=new A101413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101414
{
public static readonly long[] Value={ 5L,17L,23L,37L,47L,53L,61L,79L,83L,97L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101414Inst : IEnumerable<long>
{
public static readonly long[] Value=A101414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101414.Bytes);
public long this[int i]=>Value[i];

public static A101414Inst Instance=new A101414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101415
{
public static readonly long[] Value={ 2L,3L,7L,13L,19L,29L,31L,41L,43L,59L,67L,71L,73L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101415Inst : IEnumerable<long>
{
public static readonly long[] Value=A101415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101415.Bytes);
public long this[int i]=>Value[i];

public static A101415Inst Instance=new A101415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101416
{
public static readonly long[] Value={ 2L,2L,2L,6L,20L,14L,32L,90L,72L,80L,230L,80L,560L,740L,1542L,1782L,450L,828L,2562L,3936L,12474L,9288L,10224L,16022L,11088L,31034L,53972L,92372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101416Inst : IEnumerable<long>
{
public static readonly long[] Value=A101416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101416.Bytes);
public long this[int i]=>Value[i];

public static A101416Inst Instance=new A101416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101417
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,2L,1L,1L,3L,3L,3L,6L,5L,6L,10L,9L,12L,17L,17L,22L,28L,30L,37L,48L,52L,62L,78L,86L,103L,127L,141L,166L,201L,227L,266L,317L,358L,417L,492L,560L,647L,757L,860L,991L,1153L,1309L,1503L,1738L,1971L,2257L,2594L,2941L,3356L,3843L,4351L,4948L,5644L,6382L,7240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101417Inst : IEnumerable<long>
{
public static readonly long[] Value=A101417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101417.Bytes);
public long this[int i]=>Value[i];

public static A101417Inst Instance=new A101417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101418
{
public static readonly long[] Value={ 1L,4L,11L,19L,30L,44L,60L,78L,99L,122L,148L,176L,207L,240L,276L,314L,354L,397L,443L,491L,541L,594L,649L,707L,767L,830L,895L,963L,1033L,1105L,1180L,1257L,1337L,1419L,1504L,1591L,1681L,1773L,1868L,1965L,2064L,2166L,2271L,2378L,2487L,2599L,2713L,2830L,2949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101418Inst : IEnumerable<long>
{
public static readonly long[] Value=A101418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101418.Bytes);
public long this[int i]=>Value[i];

public static A101418Inst Instance=new A101418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101419
{
public static readonly long[] Value={ 4L,0L,0L,0L,9L,0L,0L,6L,6L,5L,3L,5L,2L,9L,9L,1L,0L,0L,4L,8L,0L,9L,6L,2L,6L,0L,2L,4L,2L,2L,0L,2L,4L,9L,5L,7L,7L,5L,9L,5L,3L,0L,3L,2L,2L,0L,8L,2L,7L,9L,0L,8L,8L,0L,0L,9L,4L,0L,5L,3L,9L,9L,7L,6L,8L,9L,4L,8L,6L,9L,2L,0L,5L,9L,3L,9L,7L,2L,4L,6L,9L,6L,2L,5L,4L,7L,7L,8L,9L,6L,4L,0L,4L,4L,3L,9L,7L,0L,3L,0L,8L,0L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101419Inst : IEnumerable<long>
{
public static readonly long[] Value=A101419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101419.Bytes);
public long this[int i]=>Value[i];

public static A101419Inst Instance=new A101419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101420
{
public static readonly long[] Value={ 2L,9L,16L,28L,35L,54L,72L,126L,128L,133L,152L,189L,217L,224L,243L,250L,280L,341L,344L,370L,407L,432L,513L,539L,576L,686L,730L,737L,756L,854L,855L,945L,1008L,1024L,1064L,1072L,1125L,1216L,1241L,1332L,1343L,1358L,1395L,1458L,1512L,1674L,1736L,1792L,1843L,1853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101420Inst : IEnumerable<long>
{
public static readonly long[] Value=A101420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101420.Bytes);
public long this[int i]=>Value[i];

public static A101420Inst Instance=new A101420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101421
{
public static readonly long[] Value={ 28L,35L,91L,126L,133L,189L,217L,224L,280L,539L,637L,686L,728L,756L,854L,945L,1001L,1008L,1064L,1358L,1456L,1512L,1547L,1729L,1736L,1792L,2198L,2205L,2240L,2261L,2331L,2457L,2709L,2926L,3059L,3087L,3402L,3500L,3528L,3591L,4123L,4221L,4312L,4375L,4914L,4921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101421Inst : IEnumerable<long>
{
public static readonly long[] Value=A101421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101421.Bytes);
public long this[int i]=>Value[i];

public static A101421Inst Instance=new A101421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101422
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,3L,2L,3L,1L,2L,3L,2L,2L,3L,1L,2L,3L,3L,2L,3L,1L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,1L,3L,2L,3L,1L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,1L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,2L,3L,2L,3L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101422Inst : IEnumerable<long>
{
public static readonly long[] Value=A101422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101422.Bytes);
public long this[int i]=>Value[i];

public static A101422Inst Instance=new A101422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101423
{
public static readonly long[] Value={ 3L,6L,12L,19L,28L,38L,51L,64L,80L,97L,116L,136L,159L,182L,208L,235L,264L,294L,327L,360L,396L,433L,472L,512L,555L,598L,644L,691L,740L,790L,843L,896L,952L,1009L,1068L,1128L,1191L,1254L,1320L,1387L,1456L,1526L,1599L,1672L,1748L,1825L,1904L,1984L,2067L,2150L,2236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101423Inst : IEnumerable<long>
{
public static readonly long[] Value=A101423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101423.Bytes);
public long this[int i]=>Value[i];

public static A101423Inst Instance=new A101423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101424
{
public static readonly long[] Value={ 4L,9L,18L,28L,42L,57L,76L,96L,120L,145L,174L,204L,238L,273L,312L,352L,396L,441L,490L,540L,594L,649L,708L,768L,832L,897L,966L,1036L,1110L,1185L,1264L,1344L,1428L,1513L,1602L,1692L,1786L,1881L,1980L,2080L,2184L,2289L,2398L,2508L,2622L,2737L,2856L,2976L,3100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101424Inst : IEnumerable<long>
{
public static readonly long[] Value=A101424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101424.Bytes);
public long this[int i]=>Value[i];

public static A101424Inst Instance=new A101424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101425
{
public static readonly long[] Value={ 5L,12L,24L,38L,57L,78L,104L,132L,165L,200L,240L,282L,329L,378L,432L,488L,549L,612L,680L,750L,825L,902L,984L,1068L,1157L,1248L,1344L,1442L,1545L,1650L,1760L,1872L,1989L,2108L,2232L,2358L,2489L,2622L,2760L,2900L,3045L,3192L,3344L,3498L,3657L,3818L,3984L,4152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101425Inst : IEnumerable<long>
{
public static readonly long[] Value=A101425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101425.Bytes);
public long this[int i]=>Value[i];

public static A101425Inst Instance=new A101425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101426
{
public static readonly long[] Value={ 7L,16L,32L,51L,76L,104L,139L,176L,220L,267L,320L,376L,439L,504L,576L,651L,732L,816L,907L,1000L,1100L,1203L,1312L,1424L,1543L,1664L,1792L,1923L,2060L,2200L,2347L,2496L,2652L,2811L,2976L,3144L,3319L,3496L,3680L,3867L,4060L,4256L,4459L,4664L,4876L,5091L,5312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101426Inst : IEnumerable<long>
{
public static readonly long[] Value=A101426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101426.Bytes);
public long this[int i]=>Value[i];

public static A101426Inst Instance=new A101426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101427
{
public static readonly long[] Value={ 1L,2L,8L,19L,42L,78L,139L,224L,350L,517L,744L,1032L,1405L,1862L,2432L,3115L,3942L,4914L,6067L,7400L,8954L,10729L,12768L,15072L,17689L,20618L,23912L,27571L,31650L,36150L,41131L,46592L,52598L,59149L,66312L,74088L,82549L,91694L,101600L,112267L,123774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101427Inst : IEnumerable<long>
{
public static readonly long[] Value=A101427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101427.Bytes);
public long this[int i]=>Value[i];

public static A101427Inst Instance=new A101427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101428
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,1L,2L,0L,1L,3L,1L,1L,0L,1L,2L,2L,1L,0L,3L,0L,1L,2L,0L,1L,2L,2L,0L,2L,1L,1L,2L,1L,0L,0L,1L,2L,4L,0L,1L,2L,0L,1L,0L,1L,2L,3L,0L,0L,2L,1L,1L,2L,1L,1L,2L,1L,1L,0L,2L,0L,2L,0L,0L,4L,1L,1L,2L,0L,0L,4L,1L,1L,0L,1L,1L,0L,1L,1L,2L,1L,2L,3L,0L,1L,2L,0L,2L,0L,0L,0L,4L,2L,0L,2L,1L,1L,0L,0L,0L,3L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101428Inst : IEnumerable<long>
{
public static readonly long[] Value=A101428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101428.Bytes);
public long this[int i]=>Value[i];

public static A101428Inst Instance=new A101428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101429
{
public static readonly long[] Value={ 2L,7L,115L,1366L,13561L,135178L,1351546L,13546438L,135481777L,1354575715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101429Inst : IEnumerable<long>
{
public static readonly long[] Value=A101429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101429.Bytes);
public long this[int i]=>Value[i];

public static A101429Inst Instance=new A101429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101430
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,6L,7L,13L,15L,10L,13L,12L,17L,14L,14L,16L,19L,18L,20L,20L,27L,22L,26L,24L,28L,26L,32L,28L,37L,30L,38L,33L,32L,35L,34L,37L,43L,39L,40L,41L,46L,43L,46L,45L,52L,47L,52L,50L,50L,51L,58L,54L,59L,56L,54L,58L,64L,60L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101430Inst : IEnumerable<long>
{
public static readonly long[] Value=A101430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101430.Bytes);
public long this[int i]=>Value[i];

public static A101430Inst Instance=new A101430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101431
{
public static readonly long[] Value={ 1L,3L,9L,3L,27L,28L,81L,174L,18L,243L,900L,285L,729L,4185L,2703L,135L,2187L,18144L,19908L,3024L,6561L,74844L,125496L,38640L,1134L,19683L,297432L,711018L,369696L,32886L,59049L,1148175L,3725190L,2943090L,528930L,10206L,177147L,4330260L,18379548L,20588040L,6228585L,363528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101431Inst : IEnumerable<long>
{
public static readonly long[] Value=A101431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101431.Bytes);
public long this[int i]=>Value[i];

public static A101431Inst Instance=new A101431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101432
{
public static readonly long[] Value={ 1L,3L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101432Inst : IEnumerable<long>
{
public static readonly long[] Value=A101432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101432.Bytes);
public long this[int i]=>Value[i];

public static A101432Inst Instance=new A101432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101433
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,10L,13L,16L,19L,23L,27L,31L,36L,41L,47L,53L,59L,66L,73L,80L,88L,96L,105L,114L,123L,132L,142L,152L,162L,173L,184L,196L,208L,221L,234L,247L,261L,275L,290L,305L,320L,335L,351L,367L,383L,400L,417L,435L,453L,471L,490L,509L,528L,548L,568L,589L,610L,631L,652L,674L,696L,718L,741L,764L,787L,811L,835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101433Inst : IEnumerable<long>
{
public static readonly long[] Value=A101433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101433.Bytes);
public long this[int i]=>Value[i];

public static A101433Inst Instance=new A101433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101434
{
public static readonly long[] Value={ 4L,8L,16L,32L,46L,64L,74L,92L,94L,106L,128L,134L,148L,158L,166L,178L,184L,188L,194L,212L,226L,254L,256L,262L,268L,296L,314L,316L,326L,332L,334L,346L,356L,368L,376L,388L,422L,424L,446L,452L,466L,502L,508L,512L,514L,524L,526L,529L,536L,554L,586L,592L,614L,628L,632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101434Inst : IEnumerable<long>
{
public static readonly long[] Value=A101434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101434.Bytes);
public long this[int i]=>Value[i];

public static A101434Inst Instance=new A101434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101435
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,5L,5L,5L,7L,7L,7L,9L,9L,11L,11L,11L,13L,13L,15L,15L,17L,17L,17L,19L,19L,21L,21L,23L,23L,23L,25L,27L,27L,29L,31L,31L,31L,33L,35L,37L,37L,37L,39L,39L,41L,41L,41L,41L,43L,43L,45L,47L,47L,49L,51L,51L,51L,53L,53L,55L,55L,57L,57L,61L,61L,61L,63L,63L,65L,67L,69L,69L,71L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101435Inst : IEnumerable<long>
{
public static readonly long[] Value=A101435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101435.Bytes);
public long this[int i]=>Value[i];

public static A101435Inst Instance=new A101435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101436
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,2L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101436Inst : IEnumerable<long>
{
public static readonly long[] Value=A101436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101436.Bytes);
public long this[int i]=>Value[i];

public static A101436Inst Instance=new A101436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101437
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,3L,3L,6L,6L,8L,11L,13L,17L,15L,25L,30L,34L,34L,46L,47L,42L,61L,72L,82L,76L,86L,93L,95L,102L,130L,145L,163L,153L,148L,172L,230L,205L,226L,214L,182L,230L,231L,272L,322L,329L,315L,340L,373L,354L,356L,378L,431L,510L,457L,498L,565L,558L,468L,528L,591L,613L,578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101437Inst : IEnumerable<long>
{
public static readonly long[] Value=A101437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101437.Bytes);
public long this[int i]=>Value[i];

public static A101437Inst Instance=new A101437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101438
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,4L,9L,11L,6L,13L,15L,8L,17L,19L,21L,10L,23L,25L,12L,27L,29L,31L,14L,33L,35L,16L,37L,39L,41L,18L,43L,45L,20L,47L,49L,22L,51L,53L,55L,24L,57L,59L,26L,61L,63L,65L,28L,67L,69L,30L,71L,73L,32L,75L,77L,79L,34L,81L,83L,36L,85L,87L,89L,38L,91L,93L,40L,95L,97L,42L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101438Inst : IEnumerable<long>
{
public static readonly long[] Value=A101438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101438.Bytes);
public long this[int i]=>Value[i];

public static A101438Inst Instance=new A101438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101439
{
public static readonly BigInteger[] Value={ 6L,63336L,474474L,666666L,4383834L,43177134L,460962269064L,60471399317406L,60490233209406L,643869171968346L,6708875775788076L,44703479297430744L,608857707707758806L,BigInteger.Parse("44523865177156832544"),BigInteger.Parse("683665820959028566386") };
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
public class A101439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101439Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A101439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101439.Bytes);
public BigInteger this[int i]=>Value[i];

public static A101439Inst Instance=new A101439Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A101440
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,5L,10L,20L,40L,80L,160L,320L,640L,1280L,2560L,9L,18L,36L,72L,144L,288L,576L,1152L,2304L,4608L,17L,34L,68L,136L,272L,544L,1088L,2176L,4352L,8704L,33L,66L,132L,264L,528L,1056L,2112L,4224L,8448L,16896L,65L,130L,260L,520L,1040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A101440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A101440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A101440Inst : IEnumerable<long>
{
public static readonly long[] Value=A101440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A101440.Bytes);
public long this[int i]=>Value[i];

public static A101440Inst Instance=new A101440Inst();

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