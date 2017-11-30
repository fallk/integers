using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200257
{
public static readonly long[] Value={ 5L,5L,0L,6L,2L,9L,9L,6L,3L,8L,6L,6L,8L,1L,3L,1L,8L,1L,9L,8L,8L,4L,3L,9L,5L,0L,6L,3L,3L,1L,3L,1L,8L,8L,1L,6L,6L,3L,2L,5L,3L,5L,3L,9L,0L,5L,5L,1L,8L,2L,7L,9L,2L,0L,0L,0L,3L,9L,6L,8L,0L,3L,8L,8L,6L,5L,0L,1L,1L,9L,7L,7L,6L,2L,9L,3L,6L,2L,9L,1L,1L,1L,8L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200257Inst : IEnumerable<long>
{
public static readonly long[] Value=A200257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200257.Bytes);
public long this[int i]=>Value[i];

public static A200257Inst Instance=new A200257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200258
{
public static readonly BigInteger[] Value={ 32L,1508L,70844L,3328160L,156352676L,7345247612L,345070285088L,16210958151524L,761569962836540L,35777577295165856L,1680784562909958692L,BigInteger.Parse("78961096879472892668"),BigInteger.Parse("3709490768772315996704"),BigInteger.Parse("174267105035419378952420"),BigInteger.Parse("8186844445895938494767036") };
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
public class A200258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200258Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200258.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200258Inst Instance=new A200258Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200259
{
public static readonly long[] Value={ 1L,5L,6L,7L,8L,11L,12L,16L,17L,20L,21L,22L,25L,26L,27L,28L,29L,31L,35L,38L,39L,42L,47L,51L,52L,54L,55L,58L,59L,62L,63L,69L,70L,73L,76L,77L,81L,83L,84L,85L,88L,92L,94L,95L,96L,97L,98L,99L,100L,101L,103L,104L,107L,112L,113L,114L,115L,119L,120L,122L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200259Inst : IEnumerable<long>
{
public static readonly long[] Value=A200259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200259.Bytes);
public long this[int i]=>Value[i];

public static A200259Inst Instance=new A200259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200260
{
public static readonly long[] Value={ 2L,3L,4L,9L,10L,13L,14L,15L,18L,19L,23L,24L,30L,32L,33L,34L,36L,37L,40L,41L,43L,44L,45L,46L,48L,49L,50L,53L,56L,57L,60L,61L,64L,65L,66L,67L,68L,71L,72L,74L,75L,78L,79L,80L,82L,86L,87L,89L,90L,91L,93L,102L,105L,106L,108L,109L,110L,111L,116L,117L,118L,121L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200260Inst : IEnumerable<long>
{
public static readonly long[] Value=A200260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200260.Bytes);
public long this[int i]=>Value[i];

public static A200260Inst Instance=new A200260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200261
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200261Inst : IEnumerable<long>
{
public static readonly long[] Value=A200261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200261.Bytes);
public long this[int i]=>Value[i];

public static A200261Inst Instance=new A200261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200262
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,5L,5L,6L,7L,7L,7L,7L,8L,9L,9L,9L,10L,11L,12L,12L,12L,13L,14L,15L,16L,17L,17L,18L,18L,18L,18L,19L,19L,19L,20L,21L,21L,21L,22L,22L,22L,22L,22L,23L,23L,23L,23L,24L,25L,25L,26L,27L,27L,27L,28L,29L,29L,29L,30L,31L,31L,31L,31L,31L,31L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200262Inst : IEnumerable<long>
{
public static readonly long[] Value=A200262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200262.Bytes);
public long this[int i]=>Value[i];

public static A200262Inst Instance=new A200262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200263
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200263Inst : IEnumerable<long>
{
public static readonly long[] Value=A200263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200263.Bytes);
public long this[int i]=>Value[i];

public static A200263Inst Instance=new A200263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200264
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,3L,3L,3L,4L,5L,5L,5L,6L,7L,8L,8L,8L,9L,10L,10L,10L,10L,11L,12L,12L,12L,12L,12L,12L,13L,13L,14L,15L,16L,16L,17L,18L,18L,18L,19L,20L,20L,21L,22L,23L,24L,24L,25L,26L,27L,27L,27L,28L,28L,28L,29L,30L,30L,30L,31L,32L,32L,32L,33L,34L,35L,36L,37L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200264Inst : IEnumerable<long>
{
public static readonly long[] Value=A200264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200264.Bytes);
public long this[int i]=>Value[i];

public static A200264Inst Instance=new A200264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200265
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,11L,2L,21L,84L,131L,6L,92L,588L,1908L,2666L,24L,490L,4380L,22020L,62860L,81534L,120L,3084L,35790L,246480L,1075020L,2823180L,3478014L,720L,22428L,322224L,2838570L,16775640L,66811920L,165838848L,196993194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200265Inst : IEnumerable<long>
{
public static readonly long[] Value=A200265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200265.Bytes);
public long this[int i]=>Value[i];

public static A200265Inst Instance=new A200265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200266
{
public static readonly long[] Value={ 1L,3L,3L,3L,5L,5L,5L,7L,3L,3L,7L,9L,11L,17L,5L,3L,13L,17L,15L,21L,5L,9L,21L,19L,9L,13L,3L,5L,21L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200266Inst : IEnumerable<long>
{
public static readonly long[] Value=A200266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200266.Bytes);
public long this[int i]=>Value[i];

public static A200266Inst Instance=new A200266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200267
{
public static readonly long[] Value={ 1L,4L,4L,6L,8L,8L,8L,16L,4L,10L,12L,36L,20L,48L,8L,20L,28L,70L,28L,154L,8L,32L,40L,174L,16L,100L,4L,38L,44L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200267Inst : IEnumerable<long>
{
public static readonly long[] Value=A200267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200267.Bytes);
public long this[int i]=>Value[i];

public static A200267Inst Instance=new A200267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200268
{
public static readonly long[] Value={ 1L,5L,7L,9L,13L,13L,21L,31L,19L,37L,75L,139L,97L,181L,101L,225L,277L,505L,465L,971L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200268Inst : IEnumerable<long>
{
public static readonly long[] Value=A200268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200268.Bytes);
public long this[int i]=>Value[i];

public static A200268Inst Instance=new A200268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200269
{
public static readonly long[] Value={ 1L,6L,10L,14L,18L,26L,34L,52L,34L,104L,172L,392L,186L,546L,226L,766L,806L,2474L,1202L,4214L,442L,2328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200269Inst : IEnumerable<long>
{
public static readonly long[] Value=A200269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200269.Bytes);
public long this[int i]=>Value[i];

public static A200269Inst Instance=new A200269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200270
{
public static readonly long[] Value={ 1L,7L,13L,25L,37L,53L,53L,83L,119L,261L,477L,955L,615L,1617L,937L,2447L,5409L,13829L,9379L,17547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200270Inst : IEnumerable<long>
{
public static readonly long[] Value=A200270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200270.Bytes);
public long this[int i]=>Value[i];

public static A200270Inst Instance=new A200270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200271
{
public static readonly long[] Value={ 1L,8L,16L,36L,64L,112L,118L,228L,236L,574L,958L,2110L,1434L,4316L,2560L,8448L,18834L,60888L,38672L,73250L,15518L,42050L,48352L,309524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200271Inst : IEnumerable<long>
{
public static readonly long[] Value=A200271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200271.Bytes);
public long this[int i]=>Value[i];

public static A200271Inst Instance=new A200271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200272
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,7L,6L,5L,2L,1L,7L,10L,9L,8L,5L,2L,1L,8L,13L,14L,13L,8L,5L,2L,1L,9L,16L,25L,18L,13L,8L,7L,2L,1L,10L,21L,36L,37L,26L,21L,16L,3L,2L,1L,11L,26L,47L,64L,53L,34L,31L,4L,3L,2L,1L,12L,31L,64L,97L,112L,53L,52L,19L,10L,7L,2L,1L,13L,36L,87L,140L,197L,118L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200272Inst : IEnumerable<long>
{
public static readonly long[] Value=A200272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200272.Bytes);
public long this[int i]=>Value[i];

public static A200272Inst Instance=new A200272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200273
{
public static readonly long[] Value={ 2L,3L,6L,9L,14L,25L,36L,47L,64L,87L,110L,143L,176L,209L,258L,311L,364L,431L,498L,575L,666L,761L,856L,969L,1092L,1219L,1364L,1513L,1662L,1847L,2032L,2221L,2432L,2647L,2876L,3135L,3394L,3657L,3946L,4257L,4568L,4913L,5258L,5607L,6004L,6409L,6814L,7257L,7700L,8169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200273Inst : IEnumerable<long>
{
public static readonly long[] Value=A200273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200273.Bytes);
public long this[int i]=>Value[i];

public static A200273Inst Instance=new A200273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200274
{
public static readonly long[] Value={ 2L,5L,8L,13L,18L,37L,64L,97L,140L,207L,286L,399L,528L,687L,878L,1127L,1408L,1749L,2130L,2607L,3128L,3743L,4414L,5191L,6056L,7067L,8156L,9387L,10706L,12241L,13876L,15717L,17670L,19829L,22172L,24787L,27542L,30571L,33752L,37317L,41058L,45153L,49440L,54073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200274Inst : IEnumerable<long>
{
public static readonly long[] Value=A200274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200274.Bytes);
public long this[int i]=>Value[i];

public static A200274Inst Instance=new A200274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200275
{
public static readonly long[] Value={ 2L,5L,8L,13L,26L,53L,112L,197L,302L,465L,688L,1013L,1406L,1995L,2790L,3759L,4990L,6419L,8132L,10281L,13134L,16521L,20352L,24767L,30018L,36095L,43022L,51469L,60976L,71993L,84356L,98137L,113366L,130095L,150630L,173315L,198134L,225225L,254604L,287725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200275Inst : IEnumerable<long>
{
public static readonly long[] Value=A200275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200275.Bytes);
public long this[int i]=>Value[i];

public static A200275Inst Instance=new A200275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200276
{
public static readonly long[] Value={ 2L,5L,8L,21L,34L,53L,118L,267L,516L,901L,1454L,2249L,3264L,5135L,7616L,11061L,15434L,21089L,28008L,36687L,49294L,65037L,84056L,107327L,134670L,167275L,204986L,256111L,315260L,385087L,464742L,557425L,661956L,781471L,930978L,1102693L,1294980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200276Inst : IEnumerable<long>
{
public static readonly long[] Value=A200276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200276.Bytes);
public long this[int i]=>Value[i];

public static A200276Inst Instance=new A200276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200277
{
public static readonly long[] Value={ 8L,1L,7L,7L,1L,5L,2L,1L,8L,7L,9L,2L,3L,0L,4L,5L,4L,5L,1L,1L,1L,9L,1L,4L,5L,4L,2L,0L,8L,3L,6L,5L,7L,7L,7L,1L,5L,3L,9L,3L,9L,1L,6L,5L,1L,3L,2L,7L,1L,2L,0L,1L,5L,3L,7L,2L,7L,9L,0L,7L,5L,0L,9L,9L,8L,6L,2L,4L,1L,4L,4L,1L,9L,7L,2L,7L,4L,5L,8L,0L,2L,7L,4L,7L,1L,3L,8L,1L,9L,8L,3L,6L,2L,7L,8L,7L,2L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200277Inst : IEnumerable<long>
{
public static readonly long[] Value=A200277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200277.Bytes);
public long this[int i]=>Value[i];

public static A200277Inst Instance=new A200277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200278
{
public static readonly long[] Value={ 1L,0L,0L,0L,3L,0L,3L,6L,3L,9L,2L,8L,3L,5L,9L,0L,1L,8L,5L,1L,8L,7L,2L,2L,5L,0L,3L,5L,7L,4L,4L,1L,8L,0L,0L,1L,2L,2L,5L,8L,5L,6L,5L,6L,1L,8L,5L,2L,9L,2L,0L,2L,6L,4L,2L,6L,3L,2L,2L,5L,7L,4L,9L,5L,4L,6L,0L,9L,3L,0L,3L,2L,3L,5L,9L,3L,8L,1L,8L,7L,9L,0L,3L,9L,0L,6L,4L,2L,4L,1L,8L,6L,9L,7L,4L,6L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200278Inst : IEnumerable<long>
{
public static readonly long[] Value=A200278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200278.Bytes);
public long this[int i]=>Value[i];

public static A200278Inst Instance=new A200278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200279
{
public static readonly long[] Value={ 7L,3L,5L,6L,3L,8L,0L,7L,6L,4L,4L,4L,6L,8L,2L,0L,8L,6L,1L,4L,7L,7L,6L,9L,5L,5L,6L,1L,2L,3L,1L,1L,6L,8L,1L,9L,6L,8L,7L,7L,6L,5L,5L,3L,8L,3L,9L,9L,4L,8L,2L,5L,4L,5L,9L,7L,7L,0L,5L,1L,1L,3L,8L,7L,9L,4L,5L,8L,4L,1L,7L,8L,0L,7L,1L,9L,1L,9L,7L,3L,5L,5L,2L,8L,4L,2L,2L,0L,3L,5L,6L,5L,9L,2L,8L,5L,8L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200279Inst : IEnumerable<long>
{
public static readonly long[] Value=A200279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200279.Bytes);
public long this[int i]=>Value[i];

public static A200279Inst Instance=new A200279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200280
{
public static readonly long[] Value={ 1L,0L,9L,6L,4L,0L,6L,9L,9L,2L,4L,2L,1L,2L,6L,7L,9L,4L,7L,2L,2L,1L,9L,8L,7L,6L,8L,1L,3L,1L,4L,0L,2L,0L,2L,2L,9L,8L,2L,3L,2L,2L,7L,4L,2L,6L,9L,9L,9L,1L,0L,5L,7L,2L,0L,4L,6L,6L,1L,8L,9L,3L,1L,7L,4L,9L,4L,3L,5L,6L,1L,2L,7L,3L,8L,5L,4L,7L,7L,3L,2L,9L,1L,5L,8L,4L,9L,3L,8L,2L,9L,1L,5L,0L,3L,7L,5L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200280Inst : IEnumerable<long>
{
public static readonly long[] Value=A200280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200280.Bytes);
public long this[int i]=>Value[i];

public static A200280Inst Instance=new A200280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200281
{
public static readonly long[] Value={ 6L,6L,1L,5L,7L,2L,3L,7L,8L,1L,8L,7L,9L,8L,9L,9L,9L,2L,0L,6L,2L,8L,9L,9L,3L,0L,7L,3L,2L,8L,9L,8L,9L,3L,6L,5L,5L,7L,5L,7L,4L,9L,6L,3L,1L,7L,5L,0L,6L,4L,6L,6L,2L,7L,2L,2L,8L,7L,0L,8L,1L,1L,3L,0L,6L,7L,7L,3L,1L,5L,1L,9L,9L,2L,2L,4L,8L,9L,9L,0L,3L,5L,9L,8L,6L,7L,4L,3L,9L,2L,8L,6L,7L,4L,4L,9L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200281Inst : IEnumerable<long>
{
public static readonly long[] Value=A200281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200281.Bytes);
public long this[int i]=>Value[i];

public static A200281Inst Instance=new A200281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200282
{
public static readonly long[] Value={ 1L,1L,9L,2L,4L,0L,4L,5L,5L,0L,0L,7L,6L,8L,1L,5L,6L,5L,9L,2L,9L,0L,0L,9L,5L,4L,9L,6L,6L,1L,3L,6L,9L,0L,6L,9L,9L,6L,9L,8L,5L,2L,7L,5L,5L,6L,4L,2L,1L,0L,0L,3L,5L,5L,4L,4L,8L,2L,3L,5L,9L,1L,8L,3L,1L,4L,6L,8L,9L,9L,9L,4L,8L,6L,2L,2L,0L,2L,9L,2L,8L,7L,6L,5L,4L,6L,6L,0L,3L,9L,8L,9L,5L,8L,2L,9L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200282Inst : IEnumerable<long>
{
public static readonly long[] Value=A200282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200282.Bytes);
public long this[int i]=>Value[i];

public static A200282Inst Instance=new A200282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200283
{
public static readonly long[] Value={ 5L,9L,5L,9L,2L,9L,4L,5L,4L,1L,2L,0L,2L,2L,3L,4L,2L,6L,3L,2L,2L,3L,4L,8L,0L,6L,7L,3L,5L,2L,6L,2L,1L,4L,9L,7L,8L,7L,4L,8L,9L,4L,9L,4L,8L,5L,0L,7L,5L,1L,6L,1L,3L,7L,3L,9L,7L,9L,0L,9L,8L,6L,9L,1L,2L,5L,8L,6L,4L,4L,0L,4L,6L,2L,0L,4L,3L,4L,1L,3L,0L,8L,5L,5L,7L,1L,8L,2L,4L,9L,2L,8L,2L,6L,2L,1L,8L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200283Inst : IEnumerable<long>
{
public static readonly long[] Value=A200283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200283.Bytes);
public long this[int i]=>Value[i];

public static A200283Inst Instance=new A200283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200284
{
public static readonly long[] Value={ 1L,2L,8L,6L,1L,2L,8L,0L,2L,6L,7L,4L,5L,9L,0L,9L,9L,6L,5L,2L,7L,9L,1L,5L,1L,1L,2L,6L,1L,4L,6L,3L,7L,9L,4L,2L,3L,5L,1L,2L,6L,4L,2L,7L,5L,6L,5L,2L,8L,4L,4L,1L,9L,4L,6L,0L,0L,6L,6L,9L,7L,2L,2L,3L,6L,1L,3L,0L,5L,8L,2L,2L,0L,3L,8L,5L,4L,0L,6L,3L,0L,8L,7L,8L,1L,6L,4L,5L,6L,4L,8L,4L,3L,6L,3L,8L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200284Inst : IEnumerable<long>
{
public static readonly long[] Value=A200284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200284.Bytes);
public long this[int i]=>Value[i];

public static A200284Inst Instance=new A200284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200285
{
public static readonly long[] Value={ 3L,7L,5L,4L,0L,3L,6L,4L,9L,9L,6L,1L,1L,3L,9L,8L,4L,8L,6L,9L,2L,9L,5L,7L,7L,3L,5L,8L,3L,7L,1L,5L,4L,4L,2L,9L,2L,9L,9L,7L,6L,1L,4L,4L,3L,4L,6L,5L,7L,3L,0L,8L,5L,7L,0L,2L,2L,9L,3L,2L,6L,0L,8L,6L,4L,5L,3L,1L,4L,7L,9L,1L,5L,9L,0L,0L,2L,3L,7L,6L,2L,0L,0L,4L,8L,2L,8L,6L,4L,7L,6L,2L,8L,2L,4L,9L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200285Inst : IEnumerable<long>
{
public static readonly long[] Value=A200285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200285.Bytes);
public long this[int i]=>Value[i];

public static A200285Inst Instance=new A200285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200286
{
public static readonly long[] Value={ 5L,8L,8L,8L,5L,1L,7L,4L,2L,6L,7L,5L,0L,4L,1L,1L,7L,9L,9L,9L,9L,6L,5L,9L,7L,1L,4L,6L,4L,4L,8L,4L,8L,0L,3L,8L,1L,8L,0L,1L,6L,1L,3L,7L,1L,7L,0L,6L,1L,7L,3L,1L,0L,3L,1L,5L,9L,4L,8L,7L,4L,1L,6L,6L,3L,8L,7L,9L,2L,3L,6L,2L,6L,0L,5L,0L,4L,2L,8L,3L,7L,4L,8L,0L,4L,0L,8L,0L,9L,8L,6L,0L,4L,9L,9L,8L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200286Inst : IEnumerable<long>
{
public static readonly long[] Value=A200286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200286.Bytes);
public long this[int i]=>Value[i];

public static A200286Inst Instance=new A200286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200287
{
public static readonly long[] Value={ 3L,0L,0L,9L,3L,1L,8L,8L,5L,4L,2L,1L,9L,0L,2L,3L,7L,0L,0L,3L,1L,0L,0L,6L,2L,4L,0L,7L,1L,7L,5L,1L,4L,9L,5L,6L,3L,1L,9L,8L,7L,9L,8L,0L,3L,3L,2L,2L,2L,6L,8L,8L,4L,5L,0L,8L,3L,5L,0L,3L,3L,3L,7L,2L,3L,5L,3L,1L,6L,0L,8L,9L,4L,3L,2L,6L,1L,3L,9L,1L,9L,2L,8L,1L,6L,6L,5L,7L,1L,9L,5L,2L,0L,1L,6L,2L,3L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200287Inst : IEnumerable<long>
{
public static readonly long[] Value=A200287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200287.Bytes);
public long this[int i]=>Value[i];

public static A200287Inst Instance=new A200287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200288
{
public static readonly long[] Value={ 7L,1L,9L,3L,8L,4L,2L,6L,0L,4L,5L,9L,8L,7L,5L,8L,3L,2L,1L,0L,7L,5L,5L,2L,4L,1L,1L,5L,9L,1L,3L,8L,0L,6L,1L,7L,5L,5L,7L,6L,3L,3L,7L,2L,7L,5L,5L,4L,2L,4L,6L,3L,4L,1L,9L,6L,7L,5L,8L,9L,1L,7L,2L,4L,8L,5L,5L,8L,5L,3L,7L,4L,4L,4L,3L,4L,0L,5L,7L,4L,5L,9L,8L,7L,5L,5L,2L,9L,0L,4L,2L,5L,1L,9L,8L,0L,5L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200288Inst : IEnumerable<long>
{
public static readonly long[] Value=A200288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200288.Bytes);
public long this[int i]=>Value[i];

public static A200288Inst Instance=new A200288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200289
{
public static readonly long[] Value={ 2L,4L,5L,4L,6L,3L,0L,3L,1L,8L,3L,0L,8L,2L,4L,2L,4L,2L,4L,7L,0L,6L,1L,7L,6L,6L,0L,4L,7L,0L,7L,3L,8L,4L,5L,8L,1L,6L,4L,2L,5L,7L,7L,4L,2L,9L,7L,6L,4L,7L,9L,0L,9L,3L,7L,0L,2L,2L,5L,4L,1L,0L,9L,6L,0L,5L,9L,1L,2L,8L,3L,6L,7L,0L,6L,9L,3L,3L,6L,3L,2L,7L,8L,1L,3L,7L,7L,8L,9L,3L,8L,6L,6L,5L,6L,9L,8L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200289Inst : IEnumerable<long>
{
public static readonly long[] Value=A200289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200289.Bytes);
public long this[int i]=>Value[i];

public static A200289Inst Instance=new A200289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200290
{
public static readonly long[] Value={ 8L,5L,4L,2L,5L,8L,4L,7L,7L,2L,9L,9L,7L,1L,2L,1L,4L,7L,8L,6L,6L,9L,4L,7L,0L,3L,2L,6L,3L,5L,3L,6L,1L,9L,3L,4L,5L,7L,3L,3L,8L,4L,5L,6L,4L,5L,1L,7L,7L,6L,5L,6L,6L,2L,4L,5L,3L,7L,3L,3L,9L,0L,9L,0L,1L,2L,0L,7L,1L,3L,2L,0L,1L,9L,3L,6L,7L,7L,4L,3L,8L,2L,1L,1L,1L,9L,5L,1L,5L,5L,5L,7L,3L,9L,9L,9L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200290Inst : IEnumerable<long>
{
public static readonly long[] Value=A200290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200290.Bytes);
public long this[int i]=>Value[i];

public static A200290Inst Instance=new A200290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200291
{
public static readonly long[] Value={ 2L,0L,4L,4L,2L,5L,5L,0L,1L,5L,3L,7L,7L,8L,0L,7L,1L,3L,1L,3L,6L,4L,9L,2L,9L,3L,9L,8L,7L,9L,7L,9L,5L,5L,2L,5L,2L,4L,5L,8L,6L,8L,5L,1L,0L,3L,1L,2L,4L,5L,4L,0L,5L,4L,4L,6L,4L,0L,5L,5L,3L,1L,6L,6L,9L,9L,0L,1L,8L,8L,2L,2L,8L,9L,3L,8L,5L,8L,2L,1L,8L,9L,8L,6L,8L,7L,3L,2L,9L,6L,3L,6L,5L,1L,7L,0L,3L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200291Inst : IEnumerable<long>
{
public static readonly long[] Value=A200291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200291.Bytes);
public long this[int i]=>Value[i];

public static A200291Inst Instance=new A200291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200292
{
public static readonly long[] Value={ 9L,8L,5L,7L,7L,6L,3L,8L,1L,7L,0L,3L,9L,0L,0L,4L,5L,5L,0L,3L,0L,7L,9L,4L,0L,5L,3L,8L,7L,9L,8L,1L,9L,7L,0L,2L,6L,4L,6L,4L,5L,4L,7L,6L,8L,0L,5L,5L,7L,6L,8L,2L,0L,7L,6L,9L,5L,1L,3L,0L,6L,1L,3L,2L,4L,7L,8L,8L,7L,1L,1L,4L,4L,3L,5L,5L,7L,6L,3L,0L,7L,3L,6L,6L,1L,0L,7L,1L,6L,8L,3L,1L,1L,7L,4L,8L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200292Inst : IEnumerable<long>
{
public static readonly long[] Value=A200292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200292.Bytes);
public long this[int i]=>Value[i];

public static A200292Inst Instance=new A200292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200293
{
public static readonly long[] Value={ 5L,4L,5L,5L,9L,7L,3L,8L,8L,4L,8L,1L,4L,7L,5L,7L,3L,9L,5L,0L,4L,2L,1L,4L,8L,8L,4L,7L,8L,5L,7L,7L,0L,8L,2L,9L,5L,6L,7L,1L,6L,1L,0L,9L,4L,3L,0L,5L,0L,7L,0L,8L,5L,7L,7L,6L,2L,5L,1L,5L,3L,7L,5L,2L,4L,9L,3L,9L,3L,1L,6L,9L,6L,6L,6L,8L,7L,1L,7L,6L,5L,7L,1L,8L,2L,1L,1L,6L,7L,3L,3L,3L,3L,5L,7L,9L,4L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200293Inst : IEnumerable<long>
{
public static readonly long[] Value=A200293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200293.Bytes);
public long this[int i]=>Value[i];

public static A200293Inst Instance=new A200293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200294
{
public static readonly long[] Value={ 7L,3L,3L,9L,7L,2L,6L,2L,7L,9L,4L,0L,2L,8L,9L,6L,1L,4L,3L,3L,4L,5L,0L,5L,0L,5L,6L,0L,0L,3L,9L,2L,9L,9L,2L,2L,0L,8L,5L,4L,5L,1L,3L,5L,6L,9L,6L,3L,5L,3L,9L,8L,1L,5L,0L,7L,6L,2L,5L,5L,4L,7L,2L,6L,5L,7L,2L,8L,2L,7L,5L,2L,5L,7L,8L,5L,8L,9L,3L,8L,3L,1L,7L,1L,7L,4L,0L,3L,8L,2L,6L,2L,1L,8L,4L,2L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200294Inst : IEnumerable<long>
{
public static readonly long[] Value=A200294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200294.Bytes);
public long this[int i]=>Value[i];

public static A200294Inst Instance=new A200294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200295
{
public static readonly long[] Value={ 4L,0L,5L,0L,0L,7L,1L,4L,9L,6L,7L,3L,3L,0L,6L,8L,1L,3L,5L,3L,0L,1L,0L,1L,2L,5L,6L,3L,6L,7L,3L,0L,1L,2L,9L,4L,7L,4L,7L,4L,6L,9L,7L,5L,9L,6L,2L,6L,2L,8L,2L,3L,1L,1L,5L,4L,6L,1L,0L,3L,4L,9L,1L,3L,8L,3L,3L,9L,0L,8L,0L,9L,3L,5L,8L,3L,8L,0L,4L,1L,8L,0L,5L,9L,0L,0L,8L,1L,2L,7L,9L,6L,0L,9L,3L,2L,7L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200295Inst : IEnumerable<long>
{
public static readonly long[] Value=A200295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200295.Bytes);
public long this[int i]=>Value[i];

public static A200295Inst Instance=new A200295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200296
{
public static readonly long[] Value={ 9L,4L,9L,1L,4L,5L,7L,1L,9L,4L,2L,3L,0L,0L,9L,8L,4L,4L,8L,1L,8L,9L,1L,9L,6L,7L,0L,8L,5L,7L,2L,5L,6L,6L,1L,0L,8L,7L,9L,0L,6L,6L,3L,3L,3L,0L,0L,2L,9L,8L,9L,2L,3L,1L,7L,5L,6L,2L,8L,7L,1L,6L,4L,0L,4L,2L,2L,9L,8L,6L,6L,4L,6L,6L,4L,9L,9L,0L,2L,8L,0L,0L,7L,2L,8L,4L,5L,1L,8L,0L,1L,9L,4L,7L,2L,4L,3L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200296Inst : IEnumerable<long>
{
public static readonly long[] Value=A200296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200296.Bytes);
public long this[int i]=>Value[i];

public static A200296Inst Instance=new A200296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200297
{
public static readonly long[] Value={ 5L,8L,8L,4L,7L,0L,8L,6L,9L,2L,8L,6L,8L,5L,2L,6L,1L,6L,4L,9L,9L,7L,9L,8L,6L,4L,8L,5L,6L,0L,3L,6L,6L,1L,8L,8L,2L,9L,8L,3L,2L,9L,5L,4L,3L,1L,0L,7L,1L,1L,9L,3L,6L,5L,0L,0L,9L,1L,7L,5L,7L,7L,4L,4L,8L,9L,7L,9L,1L,0L,8L,7L,6L,1L,0L,5L,0L,6L,5L,4L,1L,1L,8L,9L,1L,8L,1L,9L,7L,5L,0L,0L,7L,4L,4L,7L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200297Inst : IEnumerable<long>
{
public static readonly long[] Value=A200297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200297.Bytes);
public long this[int i]=>Value[i];

public static A200297Inst Instance=new A200297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200298
{
public static readonly long[] Value={ 9L,2L,2L,6L,9L,7L,3L,3L,6L,5L,4L,8L,3L,1L,4L,7L,9L,4L,6L,0L,3L,9L,0L,6L,5L,5L,1L,7L,9L,1L,5L,6L,2L,3L,6L,8L,8L,9L,4L,9L,0L,9L,0L,4L,9L,0L,7L,7L,2L,5L,7L,0L,5L,8L,6L,7L,3L,2L,2L,9L,0L,3L,3L,1L,1L,2L,1L,4L,2L,4L,9L,0L,9L,0L,3L,3L,9L,7L,3L,4L,8L,4L,2L,3L,0L,2L,3L,5L,1L,4L,5L,3L,8L,5L,5L,6L,8L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200298Inst : IEnumerable<long>
{
public static readonly long[] Value=A200298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200298.Bytes);
public long this[int i]=>Value[i];

public static A200298Inst Instance=new A200298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200299
{
public static readonly long[] Value={ 6L,6L,1L,8L,2L,6L,1L,4L,1L,1L,8L,8L,8L,5L,0L,9L,9L,3L,7L,4L,3L,0L,2L,6L,1L,2L,3L,3L,5L,7L,0L,9L,4L,9L,8L,9L,9L,7L,5L,1L,0L,6L,5L,0L,4L,6L,2L,1L,0L,8L,6L,4L,2L,4L,6L,4L,5L,8L,2L,2L,2L,9L,2L,0L,0L,8L,7L,1L,3L,6L,7L,6L,2L,5L,6L,7L,4L,1L,1L,2L,3L,6L,0L,8L,5L,7L,6L,5L,1L,0L,0L,8L,9L,0L,2L,7L,5L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200299Inst : IEnumerable<long>
{
public static readonly long[] Value=A200299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200299.Bytes);
public long this[int i]=>Value[i];

public static A200299Inst Instance=new A200299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200300
{
public static readonly long[] Value={ 8L,3L,0L,8L,5L,0L,3L,2L,7L,6L,6L,0L,5L,4L,7L,4L,0L,2L,7L,6L,6L,6L,2L,0L,9L,9L,3L,5L,6L,6L,5L,9L,7L,2L,8L,9L,7L,8L,5L,3L,0L,3L,0L,1L,5L,7L,3L,0L,2L,8L,1L,4L,8L,0L,7L,4L,7L,1L,6L,5L,1L,2L,1L,8L,3L,5L,0L,0L,1L,8L,5L,4L,8L,1L,3L,3L,8L,1L,5L,2L,2L,3L,2L,5L,4L,0L,6L,8L,6L,3L,2L,0L,8L,3L,6L,2L,8L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200300Inst : IEnumerable<long>
{
public static readonly long[] Value=A200300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200300.Bytes);
public long this[int i]=>Value[i];

public static A200300Inst Instance=new A200300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200301
{
public static readonly long[] Value={ 5L,2L,3L,7L,7L,4L,1L,5L,6L,7L,5L,3L,2L,5L,5L,7L,2L,1L,7L,1L,7L,8L,4L,0L,4L,9L,6L,7L,3L,9L,4L,4L,5L,2L,8L,5L,3L,9L,0L,6L,0L,2L,4L,7L,1L,1L,0L,3L,1L,6L,0L,9L,9L,7L,1L,6L,8L,4L,8L,7L,8L,1L,5L,3L,9L,7L,3L,9L,2L,9L,3L,2L,3L,9L,5L,9L,6L,2L,6L,5L,2L,2L,3L,5L,6L,8L,4L,2L,6L,0L,2L,5L,3L,5L,8L,7L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200301Inst : IEnumerable<long>
{
public static readonly long[] Value=A200301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200301.Bytes);
public long this[int i]=>Value[i];

public static A200301Inst Instance=new A200301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200302
{
public static readonly long[] Value={ 1L,0L,1L,6L,1L,4L,3L,9L,5L,6L,7L,2L,3L,5L,5L,8L,7L,3L,3L,7L,9L,9L,4L,5L,5L,9L,0L,1L,2L,9L,6L,8L,6L,4L,7L,4L,6L,8L,7L,7L,9L,9L,4L,9L,2L,5L,9L,9L,2L,1L,9L,8L,1L,9L,8L,1L,9L,0L,3L,6L,6L,3L,3L,4L,1L,4L,8L,1L,0L,7L,6L,3L,7L,0L,8L,3L,4L,4L,0L,9L,5L,0L,4L,4L,0L,1L,3L,4L,3L,9L,8L,5L,6L,2L,0L,2L,9L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200302Inst : IEnumerable<long>
{
public static readonly long[] Value=A200302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200302.Bytes);
public long this[int i]=>Value[i];

public static A200302Inst Instance=new A200302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200303
{
public static readonly long[] Value={ 4L,6L,7L,6L,4L,3L,6L,3L,2L,2L,2L,9L,0L,5L,6L,5L,3L,4L,2L,0L,3L,5L,4L,0L,0L,4L,9L,4L,7L,7L,1L,6L,5L,0L,1L,3L,9L,2L,4L,1L,6L,9L,8L,1L,7L,2L,2L,4L,0L,2L,6L,3L,5L,7L,1L,6L,8L,7L,3L,2L,8L,1L,2L,7L,5L,7L,8L,8L,0L,9L,5L,9L,8L,2L,5L,0L,6L,1L,3L,9L,9L,5L,1L,3L,0L,2L,3L,8L,8L,9L,3L,3L,8L,9L,3L,9L,4L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200303Inst : IEnumerable<long>
{
public static readonly long[] Value=A200303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200303.Bytes);
public long this[int i]=>Value[i];

public static A200303Inst Instance=new A200303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200304
{
public static readonly long[] Value={ 1L,1L,0L,8L,8L,1L,1L,8L,8L,2L,9L,7L,1L,7L,2L,7L,6L,2L,1L,8L,5L,8L,4L,9L,5L,3L,5L,2L,2L,8L,5L,8L,9L,1L,7L,2L,5L,5L,4L,0L,0L,8L,9L,9L,4L,0L,1L,9L,4L,8L,5L,0L,6L,8L,1L,9L,7L,6L,4L,9L,9L,3L,1L,5L,7L,1L,7L,8L,4L,8L,7L,1L,3L,8L,8L,5L,5L,5L,9L,5L,8L,9L,9L,7L,8L,4L,3L,9L,2L,3L,8L,0L,5L,3L,6L,3L,5L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200304Inst : IEnumerable<long>
{
public static readonly long[] Value=A200304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200304.Bytes);
public long this[int i]=>Value[i];

public static A200304Inst Instance=new A200304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200305
{
public static readonly long[] Value={ 7L,4L,9L,4L,8L,3L,5L,5L,6L,2L,5L,9L,1L,5L,5L,2L,2L,3L,5L,6L,8L,3L,6L,3L,4L,8L,7L,7L,3L,5L,7L,9L,3L,9L,4L,2L,5L,6L,2L,1L,5L,9L,3L,5L,7L,9L,4L,4L,7L,1L,3L,3L,2L,7L,9L,6L,9L,0L,6L,5L,2L,0L,9L,0L,1L,8L,1L,8L,6L,4L,0L,1L,2L,0L,3L,7L,3L,4L,3L,2L,7L,4L,0L,6L,6L,0L,2L,3L,8L,2L,0L,8L,4L,7L,3L,7L,2L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200305Inst : IEnumerable<long>
{
public static readonly long[] Value=A200305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200305.Bytes);
public long this[int i]=>Value[i];

public static A200305Inst Instance=new A200305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200306
{
public static readonly long[] Value={ 9L,0L,3L,0L,5L,9L,6L,1L,3L,9L,0L,4L,8L,6L,4L,2L,5L,0L,9L,1L,0L,2L,2L,7L,4L,6L,4L,5L,5L,2L,6L,1L,6L,5L,5L,1L,3L,8L,3L,0L,6L,6L,7L,8L,4L,2L,8L,2L,3L,3L,3L,3L,9L,2L,0L,0L,9L,9L,1L,7L,6L,5L,2L,9L,4L,7L,4L,5L,4L,3L,7L,5L,5L,2L,1L,0L,1L,4L,2L,6L,7L,5L,1L,7L,6L,7L,4L,5L,5L,7L,4L,9L,6L,8L,2L,7L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200306Inst : IEnumerable<long>
{
public static readonly long[] Value=A200306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200306.Bytes);
public long this[int i]=>Value[i];

public static A200306Inst Instance=new A200306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200307
{
public static readonly long[] Value={ 6L,1L,7L,4L,0L,6L,5L,1L,4L,4L,2L,0L,1L,3L,2L,1L,3L,1L,6L,8L,8L,2L,9L,8L,4L,3L,5L,0L,7L,2L,3L,0L,9L,8L,1L,2L,5L,7L,3L,1L,3L,9L,1L,2L,9L,5L,5L,9L,8L,2L,5L,4L,5L,5L,5L,4L,4L,5L,8L,1L,9L,7L,6L,3L,6L,4L,4L,3L,7L,4L,4L,1L,0L,8L,2L,0L,8L,0L,0L,5L,4L,9L,4L,6L,8L,7L,4L,7L,4L,5L,2L,0L,6L,5L,2L,2L,1L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200307Inst : IEnumerable<long>
{
public static readonly long[] Value=A200307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200307.Bytes);
public long this[int i]=>Value[i];

public static A200307Inst Instance=new A200307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200308
{
public static readonly long[] Value={ 1L,0L,6L,7L,4L,0L,8L,4L,8L,5L,6L,9L,3L,5L,9L,1L,7L,2L,3L,8L,3L,9L,2L,6L,0L,5L,6L,7L,0L,0L,7L,0L,6L,4L,1L,8L,4L,7L,6L,0L,4L,6L,0L,0L,3L,5L,9L,5L,3L,0L,2L,7L,8L,6L,5L,0L,5L,4L,6L,5L,9L,3L,0L,4L,0L,8L,3L,5L,4L,3L,1L,7L,8L,2L,0L,4L,4L,8L,3L,7L,9L,5L,5L,4L,1L,5L,1L,6L,5L,4L,8L,3L,2L,1L,1L,0L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200308Inst : IEnumerable<long>
{
public static readonly long[] Value=A200308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200308.Bytes);
public long this[int i]=>Value[i];

public static A200308Inst Instance=new A200308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200309
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,65L,440L,3571L,33824L,366113L,4458240L,60321091L,897774592L,14576528801L,256391130112L,4856647308787L,98567413125120L,2133825372539585L,49080991762153472L,1195339768057071619L,BigInteger.Parse("30729146849826701312"),BigInteger.Parse("831545527540481198465"),BigInteger.Parse("23627123985544955559936") };
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
public class A200309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200309Inst Instance=new A200309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200310
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,8L,12L,18L,26L,37L,53L,76L,108L,154L,218L,309L,437L,620L,876L,1242L,1754L,2485L,3509L,4972L,7020L,9946L,14042L,19893L,28085L,39788L,56172L,79578L,112346L,159157L,224693L,318316L,449388L,636634L,898778L,1273269L,1797557L,2546540L,3595116L,5093082L,7190234L,10186165L,14380469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200310Inst : IEnumerable<long>
{
public static readonly long[] Value=A200310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200310.Bytes);
public long this[int i]=>Value[i];

public static A200310Inst Instance=new A200310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200311
{
public static readonly long[] Value={ 2L,3L,4L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200311Inst : IEnumerable<long>
{
public static readonly long[] Value=A200311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200311.Bytes);
public long this[int i]=>Value[i];

public static A200311Inst Instance=new A200311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200312
{
public static readonly long[] Value={ 1L,1L,8L,35L,266L,1680L,12804L,93093L,726440L,5635058L,45063668L,362121760L,2955642508L,24284658100L,201428123040L,1680921310635L,14119413718770L,119205791509200L,1011387051005100L,8617021562542470L,73704123363739440L,632601537174078420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200312Inst : IEnumerable<long>
{
public static readonly long[] Value=A200312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200312.Bytes);
public long this[int i]=>Value[i];

public static A200312Inst Instance=new A200312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200313
{
public static readonly BigInteger[] Value={ 1L,1L,70L,28000L,33833800L,91842150400L,471920698849600L,4105733038511104000L,BigInteger.Parse("55918460253906250000000"),BigInteger.Parse("1124922893768186370457600000"),BigInteger.Parse("31962429471680921191680301600000"),BigInteger.Parse("1237813985055170041194334820761600000"),BigInteger.Parse("63474917512551971525535771981021376000000") };
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
public class A200313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200313Inst Instance=new A200313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200314
{
public static readonly BigInteger[] Value={ 1L,1L,315L,975975L,12909521625L,495181420358625L,BigInteger.Parse("44035787449951171875"),BigInteger.Parse("7845481113748784765634375"),BigInteger.Parse("2526730187976408357560632640625"),BigInteger.Parse("1362965093449949100037985665872890625"),BigInteger.Parse("1160978904909328561005478318639484556796875") };
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
public class A200314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200314Inst Instance=new A200314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200315
{
public static readonly BigInteger[] Value={ 1L,1L,1386L,32288256L,4527372986136L,2373840824586206976L,BigInteger.Parse("3532226719132271834449776"),BigInteger.Parse("12455133709483299692008910094336"),BigInteger.Parse("91656142095228409912231665590704016256"),BigInteger.Parse("1280796898530759870923631204720457656538791936") };
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
public class A200315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200315Inst Instance=new A200315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200316
{
public static readonly long[] Value={ 1L,2L,6L,22L,84L,308L,1090L,3782L,13000L,44504L,152102L,519506L,1773948L,6056932L,20680010L,70606382L,241065744L,823050480L,2810070734L,9594182314L,32756588164L,111837988444L,381838777906L,1303679135238L,4451038985688L,15196797672872L,51885112720758L,177146855537986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200316Inst : IEnumerable<long>
{
public static readonly long[] Value=A200316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200316.Bytes);
public long this[int i]=>Value[i];

public static A200316Inst Instance=new A200316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200317
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,90L,736L,7308L,85364L,1146660L,17411296L,294880608L,5510730224L,112638576960L,2499645858256L,59850581734128L,1537891759461344L,42211161452391840L,1232537502720495616L,BigInteger.Parse("38148561442665067968"),BigInteger.Parse("1247578217573259535424"),BigInteger.Parse("42985394533206479112000") };
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
public class A200317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200317Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200317.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200317Inst Instance=new A200317Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200318
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,120L,1156L,13608L,189316L,3039060L,55291336L,1124309208L,25268818576L,622008616320L,16642670404816L,480923246983728L,14926731083999296L,495243684302520000L,17491488288340789696UL,BigInteger.Parse("655224017429959987968"),BigInteger.Parse("25947019896579324410176"),BigInteger.Parse("1083050878686674070676800") };
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
public class A200318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200318Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200318.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200318Inst Instance=new A200318Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200319
{
public static readonly BigInteger[] Value={ 1L,2L,12L,132L,2040L,40440L,979440L,28034160L,925858080L,34654465440L,1449705660480L,67029745527360L,3394417068282240L,186842736763562880L,11107390768144070400UL,BigInteger.Parse("709223357051739129600"),BigInteger.Parse("48408150749346010022400"),BigInteger.Parse("3517279496138031162739200"),BigInteger.Parse("271050342684747077612160000") };
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
public class A200319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200319Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200319.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200319Inst Instance=new A200319Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200320
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,150L,1590L,20580L,314790L,5554710L,111071520L,2482076520L,61301435580L,1658129152680L,48749053413060L,1547849157554700L,52785934927525800L,1924269399236784600L,BigInteger.Parse("74672595203551745400"),BigInteger.Parse("3073314600152521124400"),BigInteger.Parse("133716009695044269893400"),BigInteger.Parse("6132253708189762323370200") };
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
public class A200320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200320Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200320.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200320Inst Instance=new A200320Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200321
{
public static readonly long[] Value={ 17L,43L,59L,103L,139L,151L,157L,173L,193L,281L,457L,461L,463L,499L,607L,1409L,1451L,2143L,2657L,4229L,16063L,19583L,19699L,62143L,124981L,166303L,172663L,240257L,244301L,276041L,289853L,305411L,327319L,376639L,417941L,505663L,518761L,524119L,600703L,1056287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200321Inst : IEnumerable<long>
{
public static readonly long[] Value=A200321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200321.Bytes);
public long this[int i]=>Value[i];

public static A200321Inst Instance=new A200321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200322
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,4L,7L,8L,9L,10L,9L,8L,9L,8L,15L,16L,17L,18L,17L,16L,21L,18L,17L,16L,17L,16L,19L,16L,17L,16L,31L,32L,33L,34L,33L,36L,33L,34L,33L,32L,33L,42L,33L,32L,37L,34L,33L,32L,33L,32L,35L,32L,33L,36L,35L,32L,33L,32L,35L,32L,33L,32L,63L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200322Inst : IEnumerable<long>
{
public static readonly long[] Value=A200322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200322.Bytes);
public long this[int i]=>Value[i];

public static A200322Inst Instance=new A200322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200323
{
public static readonly long[] Value={ 2L,3L,2L,3L,3L,2L,2L,1L,2L,3L,2L,7L,2L,2L,1L,2L,3L,2L,3L,2L,1L,2L,1L,2L,3L,1L,2L,3L,2L,3L,4L,2L,2L,3L,2L,2L,3L,1L,2L,1L,3L,2L,2L,3L,2L,4L,3L,2L,1L,3L,2L,2L,1L,2L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,3L,3L,2L,3L,4L,1L,2L,2L,1L,2L,3L,2L,7L,3L,2L,3L,2L,2L,3L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200323Inst : IEnumerable<long>
{
public static readonly long[] Value=A200323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200323.Bytes);
public long this[int i]=>Value[i];

public static A200323Inst Instance=new A200323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200324
{
public static readonly long[] Value={ 3L,5L,4L,6L,2L,5L,2L,4L,5L,1L,5L,3L,1L,2L,4L,4L,1L,3L,2L,1L,3L,2L,3L,4L,2L,0L,1L,0L,1L,6L,1L,2L,0L,4L,0L,2L,2L,1L,2L,2L,0L,3L,0L,1L,0L,4L,4L,1L,0L,1L,1L,0L,3L,1L,1L,1L,0L,1L,1L,0L,2L,4L,1L,0L,1L,3L,1L,2L,0L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,0L,2L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200324Inst : IEnumerable<long>
{
public static readonly long[] Value=A200324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200324.Bytes);
public long this[int i]=>Value[i];

public static A200324Inst Instance=new A200324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200325
{
public static readonly long[] Value={ 1L,5L,5L,5L,5L,5L,5L,5L,5L,9L,11L,11L,7L,7L,11L,17L,13L,7L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200325Inst : IEnumerable<long>
{
public static readonly long[] Value=A200325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200325.Bytes);
public long this[int i]=>Value[i];

public static A200325Inst Instance=new A200325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200326
{
public static readonly long[] Value={ 1L,6L,8L,6L,6L,6L,6L,6L,6L,16L,18L,18L,10L,10L,18L,30L,22L,14L,8L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200326Inst : IEnumerable<long>
{
public static readonly long[] Value=A200326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200326.Bytes);
public long this[int i]=>Value[i];

public static A200326Inst Instance=new A200326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200327
{
public static readonly long[] Value={ 1L,7L,11L,13L,13L,9L,7L,7L,17L,25L,31L,29L,13L,21L,33L,55L,79L,77L,31L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200327Inst : IEnumerable<long>
{
public static readonly long[] Value=A200327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200327.Bytes);
public long this[int i]=>Value[i];

public static A200327Inst Instance=new A200327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200328
{
public static readonly long[] Value={ 1L,8L,14L,20L,28L,26L,18L,16L,30L,34L,44L,42L,16L,44L,54L,98L,168L,248L,76L,54L,30L,12L,18L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200328Inst : IEnumerable<long>
{
public static readonly long[] Value=A200328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200328.Bytes);
public long this[int i]=>Value[i];

public static A200328Inst Instance=new A200328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200329
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,7L,8L,5L,4L,3L,2L,1L,8L,11L,6L,5L,4L,3L,2L,1L,9L,14L,13L,6L,5L,4L,3L,2L,1L,10L,17L,20L,13L,6L,5L,4L,3L,2L,1L,11L,20L,27L,28L,9L,6L,5L,4L,3L,2L,1L,12L,25L,36L,43L,26L,7L,6L,5L,4L,3L,2L,1L,13L,30L,49L,58L,49L,18L,7L,6L,9L,4L,3L,2L,1L,14L,35L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200329Inst : IEnumerable<long>
{
public static readonly long[] Value=A200329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200329.Bytes);
public long this[int i]=>Value[i];

public static A200329Inst Instance=new A200329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200330
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,13L,20L,27L,36L,49L,62L,81L,100L,119L,146L,177L,208L,247L,286L,329L,380L,435L,490L,555L,624L,697L,780L,867L,954L,1059L,1164L,1273L,1394L,1519L,1648L,1797L,1946L,2099L,2264L,2441L,2618L,2817L,3016L,3219L,3444L,3677L,3910L,4165L,4420L,4687L,4974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200330Inst : IEnumerable<long>
{
public static readonly long[] Value=A200330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200330.Bytes);
public long this[int i]=>Value[i];

public static A200330Inst Instance=new A200330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200331
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,13L,28L,43L,58L,87L,116L,159L,206L,271L,350L,453L,566L,689L,828L,1007L,1226L,1481L,1744L,2035L,2366L,2753L,3158L,3653L,4172L,4787L,5432L,6137L,6870L,7653L,8610L,9665L,10750L,11913L,13108L,14481L,15896L,17541L,19234L,21013L,22952L,25023L,27160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200331Inst : IEnumerable<long>
{
public static readonly long[] Value=A200331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200331.Bytes);
public long this[int i]=>Value[i];

public static A200331Inst Instance=new A200331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200332
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,26L,49L,76L,117L,174L,257L,348L,505L,704L,965L,1290L,1655L,2080L,2605L,3346L,4255L,5252L,6403L,7734L,9275L,10998L,13237L,15704L,18585L,21774L,25341L,29192L,33409L,38746L,44719L,51168L,58207L,65718L,74187L,83264L,94195L,105850L,118427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200332Inst : IEnumerable<long>
{
public static readonly long[] Value=A200332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200332.Bytes);
public long this[int i]=>Value[i];

public static A200332Inst Instance=new A200332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200333
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,18L,43L,78L,131L,224L,363L,526L,833L,1236L,1803L,2496L,3415L,4528L,5877L,7916L,10451L,13488L,17327L,21768L,26935L,33012L,41353L,50824L,62305L,75252L,90125L,107056L,126205L,150204L,178441L,209636L,244833L,284382L,328443L,376446L,436733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200333Inst : IEnumerable<long>
{
public static readonly long[] Value=A200333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200333.Bytes);
public long this[int i]=>Value[i];

public static A200333Inst Instance=new A200333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200334
{
public static readonly long[] Value={ 3L,5L,5L,0L,9L,3L,5L,7L,1L,9L,3L,0L,6L,7L,7L,6L,2L,3L,6L,2L,7L,3L,7L,6L,9L,0L,2L,2L,4L,3L,3L,8L,8L,8L,8L,8L,5L,8L,9L,0L,6L,1L,7L,3L,5L,8L,7L,9L,6L,8L,1L,0L,5L,2L,5L,4L,1L,3L,1L,3L,9L,9L,4L,4L,8L,7L,4L,3L,6L,9L,9L,3L,7L,8L,7L,8L,2L,3L,1L,3L,9L,7L,9L,8L,3L,5L,1L,2L,5L,1L,9L,1L,3L,1L,5L,8L,0L,7L,9L,3L,7L,1L,5L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200334Inst : IEnumerable<long>
{
public static readonly long[] Value=A200334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200334.Bytes);
public long this[int i]=>Value[i];

public static A200334Inst Instance=new A200334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200335
{
public static readonly BigInteger[] Value={ 137L,253772063L,472142416783537L,BigInteger.Parse("878420022140682133063"),BigInteger.Parse("1634298694352222684783778137"),BigInteger.Parse("3040609452244043180572708973082863"),BigInteger.Parse("5657047804679503550674811676317937783937"),BigInteger.Parse("10524926126507566387571141730985597902165021463") };
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
public class A200335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200335Inst Instance=new A200335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200336
{
public static readonly long[] Value={ 1L,2L,5L,9L,5L,1L,7L,0L,3L,6L,9L,8L,4L,5L,0L,1L,6L,1L,2L,8L,6L,3L,9L,8L,9L,6L,4L,9L,4L,8L,6L,4L,6L,0L,7L,0L,9L,5L,6L,5L,4L,2L,9L,0L,5L,1L,0L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200336Inst : IEnumerable<long>
{
public static readonly long[] Value=A200336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200336.Bytes);
public long this[int i]=>Value[i];

public static A200336Inst Instance=new A200336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200337
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,12L,24L,72L,384L,1104L,2208L,6624L,35328L,101568L,28421376L,67326336L,366139392L,983761152L,1967522304L,5902566912L,31480356864L,90506025984L,25325947097088L,59993690093568L,326262418538496L,876617757413376L,BigInteger.Parse("248432976768114295652352"),BigInteger.Parse("584740458214216890753024") };
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
public class A200337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200337Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200337.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200337Inst Instance=new A200337Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200338
{
public static readonly long[] Value={ 1L,1L,7L,2L,0L,9L,3L,6L,1L,7L,2L,8L,5L,6L,6L,9L,0L,3L,9L,6L,8L,7L,8L,1L,8L,7L,9L,5L,8L,1L,0L,8L,9L,8L,8L,0L,4L,0L,2L,4L,2L,4L,5L,7L,0L,8L,8L,0L,2L,7L,6L,3L,7L,1L,7L,6L,0L,1L,8L,6L,6L,3L,6L,7L,1L,2L,1L,8L,6L,6L,3L,4L,6L,0L,7L,6L,4L,1L,2L,2L,8L,3L,6L,5L,4L,5L,6L,1L,1L,2L,2L,8L,6L,7L,2L,3L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200338Inst : IEnumerable<long>
{
public static readonly long[] Value=A200338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200338.Bytes);
public long this[int i]=>Value[i];

public static A200338Inst Instance=new A200338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200339
{
public static readonly long[] Value={ 1L,3L,0L,7L,4L,7L,7L,6L,0L,0L,3L,0L,1L,3L,4L,9L,9L,2L,1L,2L,1L,6L,9L,3L,5L,0L,7L,1L,6L,9L,0L,0L,4L,8L,0L,8L,8L,7L,0L,5L,5L,2L,7L,4L,6L,2L,2L,3L,6L,3L,7L,9L,4L,4L,8L,8L,6L,9L,2L,8L,5L,5L,9L,3L,2L,3L,2L,2L,7L,2L,2L,7L,0L,7L,6L,8L,2L,1L,1L,0L,9L,6L,4L,0L,4L,7L,0L,9L,5L,0L,9L,9L,9L,9L,3L,0L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200339Inst : IEnumerable<long>
{
public static readonly long[] Value=A200339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200339.Bytes);
public long this[int i]=>Value[i];

public static A200339Inst Instance=new A200339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200340
{
public static readonly long[] Value={ 1L,3L,6L,8L,3L,7L,1L,2L,7L,5L,0L,4L,7L,8L,9L,7L,7L,3L,4L,0L,8L,0L,7L,9L,0L,8L,8L,6L,6L,4L,0L,4L,2L,0L,6L,5L,2L,3L,7L,3L,9L,0L,9L,1L,5L,1L,6L,4L,9L,6L,3L,9L,1L,8L,6L,9L,0L,7L,9L,4L,4L,7L,3L,8L,5L,6L,4L,2L,5L,2L,7L,0L,2L,0L,8L,1L,5L,6L,9L,4L,2L,9L,9L,6L,3L,1L,4L,1L,7L,3L,1L,3L,1L,3L,1L,1L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200340Inst : IEnumerable<long>
{
public static readonly long[] Value=A200340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200340.Bytes);
public long this[int i]=>Value[i];

public static A200340Inst Instance=new A200340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200341
{
public static readonly long[] Value={ 1L,4L,0L,4L,9L,3L,7L,8L,9L,6L,3L,7L,8L,1L,7L,5L,7L,8L,8L,8L,2L,3L,5L,2L,2L,7L,4L,9L,3L,2L,8L,0L,0L,5L,3L,1L,7L,4L,3L,4L,4L,8L,8L,0L,0L,9L,1L,6L,4L,0L,2L,9L,4L,5L,7L,1L,5L,9L,2L,0L,3L,6L,7L,4L,6L,3L,7L,8L,8L,9L,6L,0L,2L,5L,8L,0L,3L,2L,5L,2L,6L,0L,8L,9L,8L,9L,0L,4L,2L,1L,5L,1L,6L,3L,8L,4L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200341Inst : IEnumerable<long>
{
public static readonly long[] Value=A200341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200341.Bytes);
public long this[int i]=>Value[i];

public static A200341Inst Instance=new A200341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200342
{
public static readonly long[] Value={ 1L,3L,3L,1L,8L,9L,1L,4L,1L,7L,5L,5L,2L,2L,8L,8L,2L,0L,3L,7L,6L,7L,3L,2L,9L,1L,4L,9L,7L,5L,8L,0L,8L,9L,2L,0L,1L,1L,5L,7L,7L,7L,5L,2L,8L,2L,4L,3L,8L,6L,1L,1L,9L,5L,3L,6L,6L,8L,2L,7L,5L,1L,0L,6L,4L,5L,8L,1L,6L,5L,4L,4L,4L,1L,3L,1L,1L,8L,6L,5L,3L,2L,6L,7L,1L,7L,7L,0L,0L,5L,1L,4L,2L,1L,5L,6L,2L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200342Inst : IEnumerable<long>
{
public static readonly long[] Value=A200342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200342.Bytes);
public long this[int i]=>Value[i];

public static A200342Inst Instance=new A200342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200343
{
public static readonly long[] Value={ 1L,3L,8L,4L,3L,3L,3L,9L,8L,6L,0L,7L,9L,0L,1L,7L,1L,0L,1L,1L,4L,3L,1L,2L,1L,9L,4L,7L,7L,9L,4L,2L,7L,2L,4L,9L,7L,0L,0L,0L,4L,1L,2L,2L,3L,9L,1L,7L,0L,1L,7L,9L,7L,4L,5L,1L,4L,3L,8L,0L,3L,8L,9L,1L,9L,0L,1L,0L,5L,4L,2L,4L,1L,7L,2L,4L,8L,2L,0L,6L,9L,2L,7L,9L,4L,1L,0L,7L,5L,9L,3L,6L,8L,0L,3L,5L,9L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200343Inst : IEnumerable<long>
{
public static readonly long[] Value=A200343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200343.Bytes);
public long this[int i]=>Value[i];

public static A200343Inst Instance=new A200343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200344
{
public static readonly long[] Value={ 1L,4L,1L,6L,3L,2L,9L,7L,0L,4L,2L,3L,0L,1L,1L,2L,6L,3L,8L,9L,8L,2L,4L,4L,0L,6L,5L,1L,6L,3L,0L,0L,5L,3L,4L,7L,5L,7L,1L,1L,5L,2L,8L,9L,0L,3L,3L,5L,0L,3L,7L,2L,4L,5L,5L,0L,4L,4L,1L,5L,2L,0L,4L,0L,1L,5L,3L,1L,3L,6L,5L,6L,9L,2L,9L,6L,0L,7L,0L,4L,7L,9L,6L,3L,7L,2L,4L,0L,6L,7L,4L,9L,0L,6L,6L,9L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200344Inst : IEnumerable<long>
{
public static readonly long[] Value=A200344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200344.Bytes);
public long this[int i]=>Value[i];

public static A200344Inst Instance=new A200344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200345
{
public static readonly long[] Value={ 1L,4L,3L,8L,3L,7L,1L,9L,3L,5L,3L,2L,3L,1L,6L,6L,3L,4L,3L,0L,2L,4L,7L,1L,1L,2L,3L,3L,3L,8L,7L,5L,7L,8L,9L,2L,1L,8L,4L,8L,3L,9L,0L,1L,5L,3L,7L,3L,5L,5L,7L,2L,3L,9L,2L,2L,1L,4L,0L,1L,8L,4L,2L,5L,0L,7L,7L,9L,8L,5L,2L,3L,8L,9L,4L,3L,5L,0L,4L,9L,3L,8L,8L,6L,0L,5L,4L,7L,8L,2L,9L,1L,3L,2L,2L,4L,0L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200345Inst : IEnumerable<long>
{
public static readonly long[] Value=A200345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200345.Bytes);
public long this[int i]=>Value[i];

public static A200345Inst Instance=new A200345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200346
{
public static readonly long[] Value={ 1L,3L,9L,8L,7L,1L,8L,4L,7L,5L,9L,7L,1L,1L,1L,4L,8L,0L,4L,5L,0L,6L,7L,2L,5L,2L,5L,7L,2L,2L,8L,0L,9L,9L,4L,9L,8L,1L,7L,4L,9L,0L,9L,2L,2L,8L,3L,8L,8L,0L,5L,5L,0L,4L,0L,7L,4L,4L,2L,1L,2L,8L,2L,8L,7L,5L,3L,6L,0L,7L,5L,4L,4L,1L,9L,0L,1L,4L,7L,9L,0L,0L,4L,3L,4L,4L,3L,8L,6L,3L,2L,4L,8L,7L,0L,4L,8L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200346Inst : IEnumerable<long>
{
public static readonly long[] Value=A200346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200346.Bytes);
public long this[int i]=>Value[i];

public static A200346Inst Instance=new A200346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200347
{
public static readonly long[] Value={ 1L,4L,2L,6L,6L,3L,5L,1L,0L,9L,9L,3L,3L,0L,4L,3L,8L,0L,9L,0L,1L,4L,9L,2L,5L,7L,1L,1L,4L,9L,6L,1L,0L,4L,3L,4L,4L,2L,4L,9L,7L,2L,8L,1L,7L,6L,8L,0L,7L,7L,5L,4L,0L,6L,1L,2L,7L,6L,8L,6L,2L,5L,9L,1L,3L,8L,4L,4L,1L,5L,5L,0L,6L,0L,1L,5L,6L,7L,5L,3L,8L,3L,1L,8L,9L,4L,7L,0L,2L,4L,8L,5L,1L,8L,9L,8L,7L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200347Inst : IEnumerable<long>
{
public static readonly long[] Value=A200347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200347.Bytes);
public long this[int i]=>Value[i];

public static A200347Inst Instance=new A200347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200348
{
public static readonly long[] Value={ 1L,4L,4L,6L,1L,9L,2L,4L,9L,5L,1L,6L,1L,0L,3L,6L,9L,3L,8L,9L,4L,7L,5L,9L,6L,0L,3L,9L,9L,3L,7L,2L,1L,2L,7L,4L,0L,5L,3L,0L,0L,7L,9L,5L,3L,2L,7L,6L,4L,2L,6L,9L,3L,6L,1L,9L,4L,0L,6L,5L,0L,5L,2L,0L,6L,5L,5L,9L,8L,5L,9L,2L,6L,0L,2L,6L,0L,7L,5L,3L,6L,5L,2L,3L,5L,3L,4L,7L,4L,8L,7L,8L,0L,1L,9L,1L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200348Inst : IEnumerable<long>
{
public static readonly long[] Value=A200348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200348.Bytes);
public long this[int i]=>Value[i];

public static A200348Inst Instance=new A200348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200349
{
public static readonly long[] Value={ 1L,4L,6L,0L,8L,1L,3L,0L,5L,2L,2L,2L,3L,0L,5L,1L,5L,0L,3L,4L,1L,9L,2L,4L,2L,6L,6L,3L,3L,7L,9L,0L,6L,0L,0L,7L,2L,4L,9L,3L,2L,4L,7L,9L,1L,0L,1L,6L,3L,7L,8L,1L,5L,6L,2L,0L,1L,0L,3L,9L,3L,2L,4L,6L,1L,9L,8L,2L,2L,2L,7L,0L,4L,5L,2L,4L,4L,1L,7L,9L,9L,1L,3L,6L,9L,8L,4L,6L,2L,2L,3L,8L,0L,9L,6L,2L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200349Inst : IEnumerable<long>
{
public static readonly long[] Value=A200349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200349.Bytes);
public long this[int i]=>Value[i];

public static A200349Inst Instance=new A200349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200350
{
public static readonly long[] Value={ 1L,4L,3L,5L,9L,2L,8L,9L,0L,2L,3L,3L,8L,6L,4L,1L,2L,9L,9L,0L,3L,2L,0L,3L,2L,4L,4L,8L,3L,2L,2L,1L,4L,2L,5L,7L,2L,2L,7L,2L,1L,7L,1L,9L,3L,6L,9L,9L,6L,8L,5L,8L,1L,8L,7L,0L,3L,5L,0L,7L,5L,4L,2L,2L,8L,7L,5L,0L,8L,2L,0L,8L,2L,4L,6L,0L,9L,8L,1L,5L,0L,1L,0L,4L,2L,1L,0L,4L,5L,9L,8L,2L,1L,7L,3L,3L,2L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200350Inst : IEnumerable<long>
{
public static readonly long[] Value=A200350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200350.Bytes);
public long this[int i]=>Value[i];

public static A200350Inst Instance=new A200350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200351
{
public static readonly long[] Value={ 1L,4L,5L,3L,3L,0L,4L,1L,5L,8L,5L,7L,4L,3L,3L,6L,7L,9L,5L,3L,0L,4L,0L,2L,9L,6L,2L,5L,8L,3L,8L,5L,5L,0L,8L,8L,6L,8L,8L,6L,6L,0L,5L,7L,0L,7L,5L,5L,8L,7L,5L,9L,8L,4L,0L,0L,7L,0L,0L,5L,3L,4L,8L,7L,1L,0L,2L,2L,1L,7L,1L,2L,6L,6L,3L,4L,4L,4L,9L,4L,3L,9L,8L,8L,3L,6L,1L,3L,2L,7L,3L,5L,2L,9L,6L,6L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200351Inst : IEnumerable<long>
{
public static readonly long[] Value=A200351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200351.Bytes);
public long this[int i]=>Value[i];

public static A200351Inst Instance=new A200351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200352
{
public static readonly long[] Value={ 1L,4L,6L,6L,4L,6L,3L,4L,7L,1L,0L,1L,0L,8L,5L,3L,8L,0L,8L,0L,2L,1L,1L,8L,1L,5L,1L,4L,4L,7L,5L,9L,8L,2L,1L,8L,5L,5L,3L,6L,6L,1L,5L,5L,1L,2L,9L,5L,9L,0L,0L,4L,1L,3L,3L,1L,8L,8L,4L,4L,4L,8L,2L,3L,5L,4L,9L,4L,9L,6L,3L,0L,6L,8L,9L,4L,5L,8L,8L,7L,1L,7L,1L,2L,9L,1L,4L,6L,0L,8L,9L,0L,7L,8L,6L,5L,0L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200352Inst : IEnumerable<long>
{
public static readonly long[] Value=A200352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200352.Bytes);
public long this[int i]=>Value[i];

public static A200352Inst Instance=new A200352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200353
{
public static readonly long[] Value={ 1L,4L,7L,6L,8L,3L,6L,9L,4L,2L,0L,3L,5L,6L,2L,9L,5L,9L,6L,6L,0L,0L,2L,2L,5L,3L,3L,2L,4L,9L,9L,6L,8L,5L,6L,6L,4L,3L,5L,6L,7L,9L,0L,2L,8L,3L,6L,1L,0L,4L,8L,0L,7L,3L,0L,9L,4L,9L,8L,8L,6L,3L,5L,6L,4L,4L,5L,2L,4L,3L,6L,7L,8L,9L,5L,0L,5L,0L,9L,7L,7L,6L,6L,8L,3L,9L,3L,5L,1L,7L,9L,5L,8L,2L,3L,8L,6L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200353Inst : IEnumerable<long>
{
public static readonly long[] Value=A200353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200353.Bytes);
public long this[int i]=>Value[i];

public static A200353Inst Instance=new A200353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200354
{
public static readonly long[] Value={ 1L,4L,5L,9L,7L,7L,2L,3L,4L,6L,4L,3L,8L,5L,7L,0L,0L,3L,3L,7L,7L,1L,7L,0L,2L,8L,7L,3L,5L,8L,9L,5L,4L,4L,7L,7L,3L,5L,3L,9L,9L,8L,8L,7L,3L,5L,6L,9L,6L,4L,4L,6L,5L,6L,2L,2L,5L,0L,4L,5L,4L,2L,3L,5L,9L,0L,1L,7L,7L,2L,9L,1L,0L,2L,7L,3L,1L,6L,6L,5L,6L,2L,5L,0L,4L,5L,5L,5L,6L,5L,5L,8L,4L,2L,1L,2L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200354Inst : IEnumerable<long>
{
public static readonly long[] Value=A200354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200354.Bytes);
public long this[int i]=>Value[i];

public static A200354Inst Instance=new A200354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200355
{
public static readonly long[] Value={ 1L,4L,7L,1L,6L,4L,2L,8L,6L,9L,7L,6L,5L,3L,3L,8L,3L,0L,6L,1L,1L,0L,9L,6L,4L,7L,9L,3L,2L,9L,4L,4L,0L,1L,5L,2L,1L,6L,6L,4L,6L,5L,3L,8L,3L,5L,3L,8L,1L,8L,3L,6L,4L,2L,3L,5L,0L,3L,0L,0L,4L,4L,6L,1L,9L,6L,9L,6L,0L,1L,8L,5L,8L,7L,0L,4L,9L,3L,1L,6L,3L,1L,7L,2L,3L,8L,8L,3L,5L,3L,5L,3L,5L,5L,9L,9L,6L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200355Inst : IEnumerable<long>
{
public static readonly long[] Value=A200355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200355.Bytes);
public long this[int i]=>Value[i];

public static A200355Inst Instance=new A200355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200356
{
public static readonly long[] Value={ 1L,4L,8L,1L,0L,9L,3L,5L,7L,0L,0L,9L,6L,8L,2L,8L,2L,3L,1L,2L,1L,6L,9L,9L,4L,9L,3L,4L,8L,4L,7L,0L,5L,9L,9L,5L,0L,9L,7L,3L,0L,5L,5L,4L,7L,5L,7L,9L,9L,9L,8L,9L,6L,9L,9L,8L,1L,6L,4L,2L,8L,2L,3L,0L,3L,0L,5L,5L,8L,5L,9L,0L,8L,6L,1L,2L,0L,6L,4L,7L,4L,3L,5L,7L,5L,0L,0L,0L,1L,3L,1L,0L,7L,8L,0L,2L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200356Inst : IEnumerable<long>
{
public static readonly long[] Value=A200356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200356.Bytes);
public long this[int i]=>Value[i];

public static A200356Inst Instance=new A200356Inst();

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