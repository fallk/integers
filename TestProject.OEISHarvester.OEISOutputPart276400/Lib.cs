using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A079883
{
public static readonly BigInteger[] Value={ 1L,1L,2L,-3L,32L,-339L,4424L,-75189L,1428614L,-32858093L,952884728L,-29539426531L,1092958781688L,-44811310049165L,1926886332114142L,-90563657609364621L,4799873853296324972L,BigInteger.Parse("-283192557344483173287"),BigInteger.Parse("17274745998013473570574"),BigInteger.Parse("-1157407981866902729228387") };
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
public class A079883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A079883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A079883Inst Instance=new A079883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079884
{
public static readonly long[] Value={ 11L,54L,285L,1731L,12145L,97196L,874809L,8748145L,96229661L,1154756010L,15011828221L,210165595199L,3152483928105L,50439742849816L,857475628447025L,15434561312046621L,293256664928885989L,5865133298577719990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079884Inst : IEnumerable<long>
{
public static readonly long[] Value=A079884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079884.Bytes);
public long this[int i]=>Value[i];

public static A079884Inst Instance=new A079884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079885
{
public static readonly long[] Value={ 0L,4L,29L,185L,1314L,10534L,94839L,948427L,10432748L,125193032L,1627509489L,22785132925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079885Inst : IEnumerable<long>
{
public static readonly long[] Value=A079885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079885.Bytes);
public long this[int i]=>Value[i];

public static A079885Inst Instance=new A079885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079886
{
public static readonly long[] Value={ 3L,5L,5L,7L,7L,9L,9L,11L,11L,13L,13L,11L,13L,15L,15L,17L,17L,15L,19L,19L,15L,17L,21L,19L,17L,23L,23L,21L,19L,25L,25L,25L,23L,25L,25L,27L,25L,21L,23L,29L,29L,27L,25L,29L,27L,31L,31L,33L,33L,25L,31L,29L,35L,35L,29L,35L,31L,35L,27L,31L,37L,29L,35L,39L,37L,39L,37L,33L,39L,37L,41L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079886Inst : IEnumerable<long>
{
public static readonly long[] Value=A079886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079886.Bytes);
public long this[int i]=>Value[i];

public static A079886Inst Instance=new A079886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079887
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,1L,5L,1L,5L,3L,5L,9L,7L,1L,7L,3L,5L,11L,1L,5L,13L,13L,5L,11L,15L,3L,5L,11L,15L,1L,3L,7L,13L,9L,11L,7L,13L,19L,17L,1L,5L,13L,17L,9L,17L,9L,11L,5L,7L,23L,15L,19L,1L,3L,21L,9L,19L,11L,25L,21L,7L,25L,17L,1L,13L,5L,15L,23L,11L,17L,5L,25L,23L,9L,3L,5L,19L,15L,27L,25L,13L,1L,19L,29L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079887Inst : IEnumerable<long>
{
public static readonly long[] Value=A079887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079887.Bytes);
public long this[int i]=>Value[i];

public static A079887Inst Instance=new A079887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079888
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,3L,6L,10L,2L,20L,24L,9L,1L,3L,1L,1L,23L,4L,1L,2L,1L,3L,1L,1L,5L,1L,1L,2L,3L,1L,1L,1L,2L,4L,2L,2L,1L,44L,1L,15L,2L,1L,40L,1L,5L,1L,1L,31L,1L,3L,28L,3L,1L,3L,1L,2L,2L,1L,2L,2L,1L,5L,4L,1L,5L,1L,6L,1L,152L,33L,1L,1L,1L,1L,1L,1L,4L,2L,7L,1L,1L,8L,2L,1L,1L,1L,9L,1L,2L,1L,1L,10L,2L,6L,1L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079888Inst : IEnumerable<long>
{
public static readonly long[] Value=A079888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079888.Bytes);
public long this[int i]=>Value[i];

public static A079888Inst Instance=new A079888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079889
{
public static readonly long[] Value={ 2L,17L,83L,113L,491L,1367L,1801L,5869L,15919L,34883L,70639L,70657L,214867L,2515871L,3952733L,13010143L,30220163L,60155567L,69931991L,203674907L,1092101119L,1363592621L,1363592677L,2124140323L,23024158649L,30282104173L,196948778371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079889Inst : IEnumerable<long>
{
public static readonly long[] Value=A079889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079889.Bytes);
public long this[int i]=>Value[i];

public static A079889Inst Instance=new A079889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079890
{
public static readonly long[] Value={ 2L,4L,4L,8L,6L,8L,9L,16L,12L,12L,14L,16L,14L,18L,18L,32L,21L,24L,21L,24L,27L,27L,25L,32L,27L,27L,36L,36L,33L,36L,33L,64L,42L,42L,42L,48L,38L,42L,42L,48L,46L,54L,46L,54L,54L,50L,49L,64L,50L,54L,52L,54L,55L,72L,63L,72L,63L,63L,62L,72L,62L,63L,81L,128L,66L,81L,69L,81L,70L,81L,74L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079890Inst : IEnumerable<long>
{
public static readonly long[] Value=A079890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079890.Bytes);
public long this[int i]=>Value[i];

public static A079890Inst Instance=new A079890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079891
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,2L,1L,8L,3L,2L,1L,4L,1L,2L,3L,16L,1L,6L,1L,4L,3L,1L,1L,8L,1L,1L,9L,4L,1L,6L,1L,32L,3L,2L,7L,12L,1L,2L,3L,8L,1L,6L,1L,2L,9L,2L,1L,16L,1L,2L,1L,2L,1L,18L,1L,8L,3L,1L,1L,12L,1L,1L,9L,64L,1L,3L,1L,1L,1L,1L,1L,24L,1L,1L,3L,1L,1L,3L,1L,16L,27L,2L,1L,12L,1L,2L,1L,4L,1L,18L,1L,4L,1L,2L,1L,32L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079891Inst : IEnumerable<long>
{
public static readonly long[] Value=A079891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079891.Bytes);
public long this[int i]=>Value[i];

public static A079891Inst Instance=new A079891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079892
{
public static readonly long[] Value={ 2L,6L,6L,6L,6L,30L,10L,10L,10L,30L,12L,30L,14L,30L,30L,18L,18L,30L,20L,30L,30L,30L,24L,30L,26L,30L,28L,30L,33L,210L,33L,33L,42L,42L,42L,42L,38L,42L,42L,42L,44L,210L,44L,60L,60L,60L,48L,60L,50L,60L,60L,60L,54L,60L,60L,60L,60L,60L,62L,210L,62L,66L,66L,65L,66L,210L,68L,70L,70L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079892Inst : IEnumerable<long>
{
public static readonly long[] Value=A079892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079892.Bytes);
public long this[int i]=>Value[i];

public static A079892Inst Instance=new A079892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079893
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,6L,1L,2L,1L,10L,1L,6L,1L,2L,15L,2L,1L,6L,1L,10L,3L,2L,1L,6L,1L,2L,1L,2L,1L,30L,1L,1L,3L,2L,7L,6L,1L,2L,3L,2L,1L,42L,1L,4L,15L,2L,1L,12L,1L,10L,3L,4L,1L,6L,5L,4L,3L,2L,1L,30L,1L,2L,3L,1L,1L,6L,1L,2L,1L,70L,1L,6L,1L,2L,3L,2L,1L,6L,1L,4L,1L,2L,1L,42L,5L,2L,3L,2L,1L,30L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079893Inst : IEnumerable<long>
{
public static readonly long[] Value=A079893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079893.Bytes);
public long this[int i]=>Value[i];

public static A079893Inst Instance=new A079893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079894
{
public static readonly long[] Value={ 2L,2L,2L,2L,6L,2L,1L,2L,2L,6L,2L,2L,14L,6L,6L,2L,3L,6L,1L,6L,3L,3L,1L,2L,1L,3L,4L,6L,33L,6L,33L,1L,42L,42L,42L,6L,38L,42L,42L,6L,2L,6L,2L,6L,6L,10L,1L,4L,50L,6L,4L,6L,1L,12L,3L,12L,3L,3L,62L,6L,62L,3L,3L,1L,66L,3L,1L,1L,70L,3L,2L,6L,74L,3L,3L,3L,78L,3L,2L,12L,2L,4L,85L,6L,2L,2L,2L,18L,91L,6L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079894Inst : IEnumerable<long>
{
public static readonly long[] Value=A079894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079894.Bytes);
public long this[int i]=>Value[i];

public static A079894Inst Instance=new A079894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079895
{
public static readonly long[] Value={ 1L,0L,2L,-2L,8L,-30L,66L,-392L,1574L,-9440L,37770L,-377696L,1510796L,-18129546L,108777284L,-870218264L,6961746128L,-111387938042L,668327628270L,-12029897308852L,96239178470828L,-1154870141649926L,11548701416499282L,-254071431162984196L,2032571449303873588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079895Inst : IEnumerable<long>
{
public static readonly long[] Value=A079895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079895.Bytes);
public long this[int i]=>Value[i];

public static A079895Inst Instance=new A079895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079896
{
public static readonly long[] Value={ 5L,8L,12L,13L,17L,20L,21L,24L,28L,29L,32L,33L,37L,40L,41L,44L,45L,48L,52L,53L,56L,57L,60L,61L,65L,68L,69L,72L,73L,76L,77L,80L,84L,85L,88L,89L,92L,93L,96L,97L,101L,104L,105L,108L,109L,112L,113L,116L,117L,120L,124L,125L,128L,129L,132L,133L,136L,137L,140L,141L,145L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079896Inst : IEnumerable<long>
{
public static readonly long[] Value=A079896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079896.Bytes);
public long this[int i]=>Value[i];

public static A079896Inst Instance=new A079896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079897
{
public static readonly BigInteger[] Value={ 1L,2L,-2L,15L,-99L,606L,-7264L,58127L,-871892L,11334614L,-204023040L,2448276508L,-68551742210L,959724390964L,-23033385383112L,552801249194719L,-17136838725036271L,308463097050652917L,BigInteger.Parse("-12030060784975463743"),BigInteger.Parse("240601215699509274902"),BigInteger.Parse("-10105251059379389545852") };
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
public class A079897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A079897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A079897Inst Instance=new A079897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079898
{
public static readonly long[] Value={ 1L,1L,0L,3L,-7L,18L,-70L,144L,-573L,1723L,-6890L,13786L,-82714L,165432L,-661724L,2646901L,-13234503L,26469012L,-158814070L,317628146L,-1905768872L,7623075492L,-30492301966L,60984603940L,-487876831517L,1463630494555L,-5854521978216L,23418087912870L,-140508527477218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079898Inst : IEnumerable<long>
{
public static readonly long[] Value=A079898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079898.Bytes);
public long this[int i]=>Value[i];

public static A079898Inst Instance=new A079898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079899
{
public static readonly BigInteger[] Value={ 1L,0L,2L,-1L,8L,-32L,269L,-3476L,73030L,-2482965L,136563164L,-12154121452L,1750193489321L,-407795083011416L,153738746295304442L,BigInteger.Parse("-93780635240135708633"),BigInteger.Parse("92561486982013944422368"),BigInteger.Parse("-147820694710276269242519112"),BigInteger.Parse("381968675131353879722669389589") };
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
public class A079899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079899Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A079899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079899.Bytes);
public BigInteger this[int i]=>Value[i];

public static A079899Inst Instance=new A079899Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079900
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,5L,3L,4L,2L,3L,7L,21L,9L,3L,34L,32L,5L,7L,16L,8L,4L,2L,28L,21L,7L,203L,100L,28L,15L,126L,14L,63L,35L,253L,520L,910L,105L,264L,665L,1155L,165L,504L,1155L,858L,156L,495L,91L,539L,715L,198L,507L,550L,275L,143L,720L,627L,2002L,2618L,5695L,4692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079900Inst : IEnumerable<long>
{
public static readonly long[] Value=A079900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079900.Bytes);
public long this[int i]=>Value[i];

public static A079900Inst Instance=new A079900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079901
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,1L,3L,9L,27L,1L,4L,16L,64L,256L,1L,5L,25L,125L,625L,3125L,1L,6L,36L,216L,1296L,7776L,46656L,1L,7L,49L,343L,2401L,16807L,117649L,823543L,1L,8L,64L,512L,4096L,32768L,262144L,2097152L,16777216L,1L,9L,81L,729L,6561L,59049L,531441L,4782969L,43046721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079901Inst : IEnumerable<long>
{
public static readonly long[] Value=A079901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079901.Bytes);
public long this[int i]=>Value[i];

public static A079901Inst Instance=new A079901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079902
{
public static readonly long[] Value={ 1L,0L,4L,-4L,12L,-20L,40L,-68L,124L,-208L,352L,-580L,944L,-1508L,2392L,-3732L,5772L,-8836L,13396L,-20132L,30024L,-44412L,65240L,-95188L,137984L,-198808L,284816L,-405764L,575072L,-810980L,1138184L,-1590132L,2211868L,-3063740L,4226640L,-5808372L,7952204L,-10848196L,14747560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079902Inst : IEnumerable<long>
{
public static readonly long[] Value=A079902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079902.Bytes);
public long this[int i]=>Value[i];

public static A079902Inst Instance=new A079902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079903
{
public static readonly long[] Value={ 1L,28L,190L,703L,1891L,4186L,8128L,14365L,23653L,36856L,54946L,79003L,110215L,149878L,199396L,260281L,334153L,422740L,527878L,651511L,795691L,962578L,1154440L,1373653L,1622701L,1904176L,2220778L,2575315L,2970703L,3409966L,3896236L,4432753L,5022865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079903Inst : IEnumerable<long>
{
public static readonly long[] Value=A079903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079903.Bytes);
public long this[int i]=>Value[i];

public static A079903Inst Instance=new A079903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079904
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,4L,0L,3L,6L,9L,0L,4L,8L,12L,16L,0L,5L,10L,15L,20L,25L,0L,6L,12L,18L,24L,30L,36L,0L,7L,14L,21L,28L,35L,42L,49L,0L,8L,16L,24L,32L,40L,48L,56L,64L,0L,9L,18L,27L,36L,45L,54L,63L,72L,81L,0L,10L,20L,30L,40L,50L,60L,70L,80L,90L,100L,0L,11L,22L,33L,44L,55L,66L,77L,88L,99L,110L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079904Inst : IEnumerable<long>
{
public static readonly long[] Value=A079904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079904.Bytes);
public long this[int i]=>Value[i];

public static A079904Inst Instance=new A079904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079905
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,9L,11L,12L,13L,14L,15L,17L,19L,21L,23L,24L,25L,26L,27L,28L,29L,30L,31L,33L,35L,37L,39L,41L,43L,45L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,96L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079905Inst : IEnumerable<long>
{
public static readonly long[] Value=A079905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079905.Bytes);
public long this[int i]=>Value[i];

public static A079905Inst Instance=new A079905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079906
{
public static readonly long[] Value={ 1L,2L,6L,7L,11L,23L,33L,48L,68L,79L,116L,151L,205L,1016L,1332L,1448L,3481L,3566L,3665L,11233L,13363L,29166L,44358L,58530L,191706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079906Inst : IEnumerable<long>
{
public static readonly long[] Value=A079906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079906.Bytes);
public long this[int i]=>Value[i];

public static A079906Inst Instance=new A079906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079907
{
public static readonly long[] Value={ 1L,2L,21L,25L,33L,54L,78L,235L,1566L,2273L,2310L,4121L,7775L,42249L,105974L,138961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079907Inst : IEnumerable<long>
{
public static readonly long[] Value=A079907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079907.Bytes);
public long this[int i]=>Value[i];

public static A079907Inst Instance=new A079907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079908
{
public static readonly long[] Value={ 1L,4L,14L,36L,76L,140L,234L,364L,536L,756L,1030L,1364L,1764L,2236L,2786L,3420L,4144L,4964L,5886L,6916L,8060L,9324L,10714L,12236L,13896L,15700L,17654L,19764L,22036L,24476L,27090L,29884L,32864L,36036L,39406L,42980L,46764L,50764L,54986L,59436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079908Inst : IEnumerable<long>
{
public static readonly long[] Value=A079908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079908.Bytes);
public long this[int i]=>Value[i];

public static A079908Inst Instance=new A079908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079909
{
public static readonly long[] Value={ 1L,5L,26L,90L,246L,566L,1146L,2106L,3590L,5766L,8826L,12986L,18486L,25590L,34586L,45786L,59526L,76166L,96090L,119706L,147446L,179766L,217146L,260090L,309126L,364806L,427706L,498426L,577590L,665846L,763866L,872346L,992006L,1123590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079909Inst : IEnumerable<long>
{
public static readonly long[] Value=A079909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079909.Bytes);
public long this[int i]=>Value[i];

public static A079909Inst Instance=new A079909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079910
{
public static readonly long[] Value={ 1L,6L,46L,212L,738L,2104L,5150L,11196L,22162L,40688L,70254L,115300L,181346L,275112L,404638L,579404L,810450L,1110496L,1494062L,1977588L,2579554L,3320600L,4223646L,5314012L,6619538L,8170704L,10000750L,12145796L,14644962L,17540488L,20877854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079910Inst : IEnumerable<long>
{
public static readonly long[] Value=A079910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079910.Bytes);
public long this[int i]=>Value[i];

public static A079910Inst Instance=new A079910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079911
{
public static readonly long[] Value={ 1L,7L,79L,478L,2108L,7364L,21652L,55532L,127604L,268108L,523244L,960212L,1672972L,2788724L,4475108L,6948124L,10480772L,15412412L,22158844L,31223108L,43207004L,58823332L,78908852L,104437964L,136537108L,176499884L,225802892L,286122292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079911Inst : IEnumerable<long>
{
public static readonly long[] Value=A079911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079911.Bytes);
public long this[int i]=>Value[i];

public static A079911Inst Instance=new A079911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079912
{
public static readonly long[] Value={ 1L,8L,133L,1044L,5794L,24720L,86608L,260720L,693552L,1666000L,3675680L,7549488L,14591440L,26770832L,46955760L,79197040L,129067568L,204062160L,314062912L,471875120L,693838800L,1000520848L,1417492880L,1976199792L,2714924080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079912Inst : IEnumerable<long>
{
public static readonly long[] Value=A079912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079912.Bytes);
public long this[int i]=>Value[i];

public static A079912Inst Instance=new A079912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079913
{
public static readonly long[] Value={ 1L,9L,221L,2227L,15458L,80196L,334072L,1173240L,3598120L,9856552L,24553080L,56423032L,121013800L,244555560L,469343992L,860997880L,1517994792L,2583928360L,4262971000L,6839066232L,10699415080L,16362861352L,24513820920L,36042440440L,52091711272L,74112304680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079913Inst : IEnumerable<long>
{
public static readonly long[] Value=A079913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079913.Bytes);
public long this[int i]=>Value[i];

public static A079913Inst Instance=new A079913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079914
{
public static readonly long[] Value={ 1L,10L,364L,4664L,40296L,253072L,1249768L,5112544L,17990600L,56010096L,157175032L,403579328L,959942664L,2136701200L,4488418616L,8961185952L,17105944648L,31378295984L,55549351800L,95256535936L,158727963272L,257719103568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079914Inst : IEnumerable<long>
{
public static readonly long[] Value=A079914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079914.Bytes);
public long this[int i]=>Value[i];

public static A079914Inst Instance=new A079914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079915
{
public static readonly long[] Value={ 1L,11L,596L,9627L,103129L,780902L,4557284L,21670160L,87396728L,308055528L,971055240L,2780440664L,7324967640L,17945144328L,41249101928L,89635336440L,185317652664L,366517590440L,696695849928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079915Inst : IEnumerable<long>
{
public static readonly long[] Value=A079915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079915.Bytes);
public long this[int i]=>Value[i];

public static A079915Inst Instance=new A079915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079916
{
public static readonly long[] Value={ 1L,12L,972L,19640L,260019L,2365772L,16266830L,89700624L,413977192L,1650607040L,5826331440L,18558391936L,54055214144L,145576033920L,365883104080L,865023114560L,1936764883296L,4130528893504L,8433028861040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079916Inst : IEnumerable<long>
{
public static readonly long[] Value=A079916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079916.Bytes);
public long this[int i]=>Value[i];

public static A079916Inst Instance=new A079916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079917
{
public static readonly long[] Value={ 1L,13L,1581L,39684L,647617L,7058469L,57031078L,363862092L,1918222840L,8641355080L,34132685120L,120629547584L,387665694976L,1145875468544L,3145428883520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079917Inst : IEnumerable<long>
{
public static readonly long[] Value=A079917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079917.Bytes);
public long this[int i]=>Value[i];

public static A079917Inst Instance=new A079917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079918
{
public static readonly long[] Value={ 1L,14L,2567L,79544L,1596800L,20789082L,196933710L,1450606028L,8719846960L,44321202192L,195717772000L,767025716736L,2713659864832L,8787898861568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079918Inst : IEnumerable<long>
{
public static readonly long[] Value=A079918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079918.Bytes);
public long this[int i]=>Value[i];

public static A079918Inst Instance=new A079918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079919
{
public static readonly long[] Value={ 1L,15L,4163L,158364L,3904260L,60560175L,671224467L,5697401802L,38983643908L,223245029176L,1100925116264L,4780871048064L,18612106195456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079919Inst : IEnumerable<long>
{
public static readonly long[] Value=A079919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079919.Bytes);
public long this[int i]=>Value[i];

public static A079919Inst Instance=new A079919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079920
{
public static readonly long[] Value={ 1L,16L,6746L,313464L,9479292L,174763208L,2262089361L,22088730348L,171764779170L,1106667645872L,6087616677864L,29267369636800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079920Inst : IEnumerable<long>
{
public static readonly long[] Value=A079920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079920.Bytes);
public long this[int i]=>Value[i];

public static A079920Inst Instance=new A079920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079921
{
public static readonly long[] Value={ 3L,7L,14L,26L,46L,79L,133L,221L,364L,596L,972L,1581L,2567L,4163L,6746L,10926L,17690L,28635L,46345L,75001L,121368L,196392L,317784L,514201L,832011L,1346239L,2178278L,3524546L,5702854L,9227431L,14930317L,24157781L,39088132L,63245948L,102334116L,165580101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079921Inst : IEnumerable<long>
{
public static readonly long[] Value=A079921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079921.Bytes);
public long this[int i]=>Value[i];

public static A079921Inst Instance=new A079921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079922
{
public static readonly long[] Value={ 4L,13L,36L,90L,212L,478L,1044L,2227L,4664L,9627L,19640L,39684L,79544L,158364L,313464L,617365L,1210588L,2364713L,4603388L,8934142L,17291756L,33385018L,64311660L,123634471L,237233712L,454429239L,869095472L,1659708488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079922Inst : IEnumerable<long>
{
public static readonly long[] Value=A079922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079922.Bytes);
public long this[int i]=>Value[i];

public static A079922Inst Instance=new A079922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079923
{
public static readonly long[] Value={ 5L,21L,76L,246L,738L,2108L,5794L,15458L,40296L,103129L,260019L,647617L,1596800L,3904260L,9479292L,22879520L,54947836L,131406732L,313129592L,743878505L,1762572329L,4167010597L,9832766588L,23164353834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079923Inst : IEnumerable<long>
{
public static readonly long[] Value=A079923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079923.Bytes);
public long this[int i]=>Value[i];

public static A079923Inst Instance=new A079923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079924
{
public static readonly long[] Value={ 6L,31L,140L,566L,2104L,7364L,24720L,80196L,253072L,780902L,2365772L,7058469L,20789082L,60560175L,174763208L,500245052L,1421824896L,4016278792L,11283371280L,31547434008L,87827653936L,243578509132L,673221043496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079924Inst : IEnumerable<long>
{
public static readonly long[] Value=A079924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079924.Bytes);
public long this[int i]=>Value[i];

public static A079924Inst Instance=new A079924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079925
{
public static readonly long[] Value={ 7L,43L,234L,1146L,5150L,21652L,86608L,334072L,1249768L,4557284L,16266830L,57031078L,196933710L,671224467L,2262089361L,7548882573L,24975936372L,82012110724L,267505920876L,867390073384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079925Inst : IEnumerable<long>
{
public static readonly long[] Value=A079925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079925.Bytes);
public long this[int i]=>Value[i];

public static A079925Inst Instance=new A079925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079926
{
public static readonly long[] Value={ 8L,57L,364L,2106L,11196L,55532L,260720L,1173240L,5112544L,21670160L,89700624L,363862092L,1450606028L,5697401802L,22088730348L,84669409935L,321307769052L,1208513572803L,4509661963752L,16709568237540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079926Inst : IEnumerable<long>
{
public static readonly long[] Value=A079926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079926.Bytes);
public long this[int i]=>Value[i];

public static A079926Inst Instance=new A079926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079927
{
public static readonly long[] Value={ 9L,73L,536L,3590L,22162L,127604L,693552L,3598120L,17990600L,87396728L,413977192L,1918222840L,8719846960L,38983643908L,171764779170L,747190081890L,3213760467348L,13684132415133L,57742830924831L,241687792906641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079927Inst : IEnumerable<long>
{
public static readonly long[] Value=A079927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079927.Bytes);
public long this[int i]=>Value[i];

public static A079927Inst Instance=new A079927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079928
{
public static readonly long[] Value={ 10L,91L,756L,5766L,40688L,268108L,1666000L,9856552L,56010096L,308055528L,1650607040L,8641355080L,44321202192L,223245029176L,1106667645872L,5409040818588L,26108349881112L,124618084809174L,588875653169028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079928Inst : IEnumerable<long>
{
public static readonly long[] Value=A079928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079928.Bytes);
public long this[int i]=>Value[i];

public static A079928Inst Instance=new A079928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079929
{
public static readonly BigInteger[] Value={ 1L,8L,280L,22400L,3203200L,717516800L,231757926400L,101973487616000L,58634755379200000L,BigInteger.Parse("42686101916057600000"),BigInteger.Parse("38374805622535782400000"),BigInteger.Parse("41751788517318931251200000"),BigInteger.Parse("54068566129928015970304000000") };
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
public class A079929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079929Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A079929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079929.Bytes);
public BigInteger this[int i]=>Value[i];

public static A079929Inst Instance=new A079929Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079930
{
public static readonly long[] Value={ 1L,2L,8L,10L,16L,18L,19L,26L,30L,36L,38L,41L,43L,45L,50L,51L,59L,65L,68L,70L,74L,75L,82L,84L,87L,89L,91L,94L,96L,99L,101L,103L,107L,113L,116L,117L,124L,127L,129L,136L,138L,142L,145L,149L,156L,161L,164L,166L,168L,170L,172L,176L,181L,183L,185L,187L,189L,192L,194L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079930Inst : IEnumerable<long>
{
public static readonly long[] Value=A079930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079930.Bytes);
public long this[int i]=>Value[i];

public static A079930Inst Instance=new A079930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079931
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,16L,20L,22L,23L,32L,33L,36L,39L,42L,43L,46L,47L,50L,51L,55L,59L,60L,63L,69L,74L,77L,80L,82L,87L,92L,94L,97L,100L,102L,105L,107L,111L,113L,114L,117L,119L,122L,126L,128L,129L,134L,141L,142L,146L,147L,150L,151L,154L,157L,160L,162L,165L,167L,168L,171L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079931Inst : IEnumerable<long>
{
public static readonly long[] Value=A079931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079931.Bytes);
public long this[int i]=>Value[i];

public static A079931Inst Instance=new A079931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079932
{
public static readonly long[] Value={ 1L,4L,10L,13L,22L,27L,32L,36L,40L,49L,54L,62L,66L,71L,80L,91L,97L,102L,109L,114L,120L,124L,127L,138L,146L,149L,159L,165L,169L,180L,184L,187L,194L,202L,208L,219L,224L,231L,235L,248L,258L,263L,266L,274L,281L,287L,294L,300L,304L,308L,316L,323L,329L,337L,343L,350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079932Inst : IEnumerable<long>
{
public static readonly long[] Value=A079932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079932.Bytes);
public long this[int i]=>Value[i];

public static A079932Inst Instance=new A079932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079933
{
public static readonly long[] Value={ 1L,2L,5L,7L,11L,12L,19L,22L,27L,33L,37L,39L,42L,44L,53L,54L,60L,62L,68L,69L,75L,77L,78L,83L,86L,87L,91L,94L,97L,100L,101L,105L,106L,110L,113L,115L,116L,120L,121L,125L,129L,131L,132L,137L,141L,144L,148L,149L,152L,155L,157L,166L,171L,173L,178L,179L,184L,186L,189L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079933Inst : IEnumerable<long>
{
public static readonly long[] Value=A079933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079933.Bytes);
public long this[int i]=>Value[i];

public static A079933Inst Instance=new A079933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079934
{
public static readonly long[] Value={ 1L,3L,5L,10L,17L,29L,46L,99L,169L,268L,577L,985L,1562L,3363L,5741L,9104L,19601L,33461L,53062L,114243L,195025L,309268L,665857L,1136689L,1802546L,3880899L,6625109L,10506008L,22619537L,38613965L,61233502L,131836323L,225058681L,356895004L,768398401L,1311738121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079934Inst : IEnumerable<long>
{
public static readonly long[] Value=A079934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079934.Bytes);
public long this[int i]=>Value[i];

public static A079934Inst Instance=new A079934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079935
{
public static readonly long[] Value={ 1L,3L,11L,41L,153L,571L,2131L,7953L,29681L,110771L,413403L,1542841L,5757961L,21489003L,80198051L,299303201L,1117014753L,4168755811L,15558008491L,58063278153L,216695104121L,808717138331L,3018173449203L,11263976658481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079935Inst : IEnumerable<long>
{
public static readonly long[] Value=A079935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079935.Bytes);
public long this[int i]=>Value[i];

public static A079935Inst Instance=new A079935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079936
{
public static readonly long[] Value={ 1L,2L,5L,13L,17L,34L,305L,610L,1597L,4181L,5473L,10946L,98209L,196418L,514229L,1346269L,1762289L,3524578L,31622993L,63245986L,165580141L,433494437L,567451585L,1134903170L,10182505537L,20365011074L,53316291173L,139583862445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079936Inst : IEnumerable<long>
{
public static readonly long[] Value=A079936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079936.Bytes);
public long this[int i]=>Value[i];

public static A079936Inst Instance=new A079936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079937
{
public static readonly long[] Value={ 1L,2L,14L,45L,107L,138L,276L,414L,1135L,2270L,6672L,12209L,18881L,180865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079937Inst : IEnumerable<long>
{
public static readonly long[] Value=A079937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079937.Bytes);
public long this[int i]=>Value[i];

public static A079937Inst Instance=new A079937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079938
{
public static readonly long[] Value={ 1L,2L,3L,8L,99L,33102L,66317L,265381L,1360120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079938Inst : IEnumerable<long>
{
public static readonly long[] Value=A079938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079938.Bytes);
public long this[int i]=>Value[i];

public static A079938Inst Instance=new A079938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079939
{
public static readonly long[] Value={ 1L,3L,7L,14L,39L,78L,394L,1001L,2002L,3003L,9545L,10546L,27634L,154257L,398959L,797918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079939Inst : IEnumerable<long>
{
public static readonly long[] Value=A079939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079939.Bytes);
public long this[int i]=>Value[i];

public static A079939Inst Instance=new A079939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080004
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,9L,15L,25L,46L,84L,156L,280L,501L,909L,1647L,2990L,5408L,9773L,17695L,32033L,58000L,104976L,189968L,343860L,622409L,1126617L,2039201L,3690898L,6680644L,12092173L,21887215L,39616409L,71706406L,129790404L,234923948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080004Inst : IEnumerable<long>
{
public static readonly long[] Value=A080004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080004.Bytes);
public long this[int i]=>Value[i];

public static A080004Inst Instance=new A080004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080005
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,7L,11L,19L,35L,62L,107L,186L,328L,578L,1012L,1771L,3107L,5455L,9568L,16774L,29417L,51603L,90513L,158741L,278404L,488301L,856448L,1502116L,2634532L,4620700L,8104269L,14214069L,24929981L,43724610L,76688540L,134503903L,235906039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080005Inst : IEnumerable<long>
{
public static readonly long[] Value=A080005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080005.Bytes);
public long this[int i]=>Value[i];

public static A080005Inst Instance=new A080005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080006
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,5L,8L,16L,27L,51L,91L,164L,298L,536L,972L,1755L,3172L,5735L,10363L,18735L,33861L,61204L,110628L,199957L,361427L,653277L,1180800L,2134300L,3857748L,6972892L,12603513L,22780876L,41176481L,74426569L,134526179L,243156337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080006Inst : IEnumerable<long>
{
public static readonly long[] Value=A080006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080006.Bytes);
public long this[int i]=>Value[i];

public static A080006Inst Instance=new A080006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080007
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,4L,4L,8L,19L,32L,56L,97L,180L,336L,592L,1064L,1925L,3488L,6312L,11345L,20486L,37028L,66852L,120688L,217767L,393216L,710032L,1281729L,2313896L,4177216L,7541568L,13615344L,24579657L,44374528L,80111088L,144628065L,261102474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080007Inst : IEnumerable<long>
{
public static readonly long[] Value=A080007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080007.Bytes);
public long this[int i]=>Value[i];

public static A080007Inst Instance=new A080007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080008
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,2L,3L,5L,11L,15L,24L,40L,68L,110L,177L,290L,480L,783L,1278L,2090L,3427L,5609L,9171L,15005L,24564L,40200L,65776L,107628L,176137L,288244L,471676L,771845L,1263074L,2066938L,3382367L,5534941L,9057495L,14821891L,24254820L,39691008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080008Inst : IEnumerable<long>
{
public static readonly long[] Value=A080008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080008.Bytes);
public long this[int i]=>Value[i];

public static A080008Inst Instance=new A080008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080009
{
public static readonly long[] Value={ 1L,1L,2L,4L,11L,26L,56L,127L,288L,660L,1500L,3401L,7729L,17565L,39930L,90735L,206176L,468536L,1064750L,2419661L,5498621L,12495505L,28395889L,64529315L,146642077L,333242093L,757288191L,1720927502L,3910785158L,8887207808L,20196062308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080009Inst : IEnumerable<long>
{
public static readonly long[] Value=A080009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080009.Bytes);
public long this[int i]=>Value[i];

public static A080009Inst Instance=new A080009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080010
{
public static readonly long[] Value={ 1L,1L,1L,3L,9L,19L,38L,84L,193L,430L,940L,2074L,4609L,10223L,22611L,50022L,110780L,245348L,543189L,1202511L,2662417L,5894961L,13051820L,28897016L,63979205L,141653762L,313629217L,694390210L,1537413824L,3403913006L,7536438344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080010Inst : IEnumerable<long>
{
public static readonly long[] Value=A080010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080010.Bytes);
public long this[int i]=>Value[i];

public static A080010Inst Instance=new A080010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080011
{
public static readonly long[] Value={ 1L,1L,1L,3L,7L,15L,29L,59L,126L,262L,542L,1121L,2328L,4839L,10039L,20827L,43220L,89704L,186172L,386345L,801768L,1663916L,3453137L,7166272L,14872078L,30863935L,64051787L,132926308L,275861116L,572492846L,1188091024L,2465638247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080011Inst : IEnumerable<long>
{
public static readonly long[] Value=A080011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080011.Bytes);
public long this[int i]=>Value[i];

public static A080011Inst Instance=new A080011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080012
{
public static readonly long[] Value={ 1L,0L,1L,2L,6L,11L,23L,51L,113L,244L,526L,1142L,2483L,5389L,11687L,25358L,55034L,119430L,259151L,562340L,1220276L,2647993L,5746085L,12468857L,27057165L,58713537L,127407187L,276470942L,599936262L,1301849496L,2824986880L,6130163753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080012Inst : IEnumerable<long>
{
public static readonly long[] Value=A080012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080012.Bytes);
public long this[int i]=>Value[i];

public static A080012Inst Instance=new A080012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080013
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,3L,3L,4L,6L,9L,12L,16L,24L,33L,46L,64L,91L,127L,177L,249L,349L,489L,684L,960L,1345L,1884L,2640L,3700L,5185L,7264L,10180L,14265L,19989L,28009L,39249L,54999L,77067L,107992L,151326L,212049L,297136L,416368L,583444L,817561L,1145622L,1605324L,2249491L,3152139L,4416993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080013Inst : IEnumerable<long>
{
public static readonly long[] Value=A080013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080013.Bytes);
public long this[int i]=>Value[i];

public static A080013Inst Instance=new A080013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080014
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,10L,18L,35L,65L,119L,221L,412L,764L,1416L,2629L,4881L,9057L,16807L,31194L,57894L,107442L,199399L,370065L,686799L,1274617L,2365544L,4390184L,8147680L,15121161L,28063153L,52082017L,96658283L,179386750L,332921362L,617864098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080014Inst : IEnumerable<long>
{
public static readonly long[] Value=A080014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080014.Bytes);
public long this[int i]=>Value[i];

public static A080014Inst Instance=new A080014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080015
{
public static readonly long[] Value={ 1L,2L,-2L,-4L,6L,8L,-12L,-16L,22L,30L,-40L,-52L,68L,88L,-112L,-144L,182L,228L,-286L,-356L,440L,544L,-668L,-816L,996L,1210L,-1464L,-1768L,2128L,2552L,-3056L,-3648L,4342L,5160L,-6116L,-7232L,8538L,10056L,-11820L,-13872L,16248L,18996L,-22176L,-25844L,30068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080015Inst : IEnumerable<long>
{
public static readonly long[] Value=A080015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080015.Bytes);
public long this[int i]=>Value[i];

public static A080015Inst Instance=new A080015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080016
{
public static readonly long[] Value={ 1L,2L,3L,5L,23L,51L,227L,1640L,1867L,9108L,20083L,69357L,297511L,3044467L,3341978L,9728423L,13070401L,22798824L,35869225L,560837199L,596706424L,2350956471L,14702445250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080016Inst : IEnumerable<long>
{
public static readonly long[] Value=A080016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080016.Bytes);
public long this[int i]=>Value[i];

public static A080016Inst Instance=new A080016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080017
{
public static readonly long[] Value={ 1L,1L,2L,3L,14L,31L,138L,997L,1135L,5537L,12209L,42164L,180865L,1850814L,2031679L,5914172L,7945851L,13860023L,21805874L,340948133L,362754007L,1429210154L,8938014931L,10367225085L,19305240016L,48977705117L,68282945133L,117260650250L,185543595383L,488347841016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080017Inst : IEnumerable<long>
{
public static readonly long[] Value=A080017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080017.Bytes);
public long this[int i]=>Value[i];

public static A080017Inst Instance=new A080017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080018
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,1L,2L,3L,1L,2L,10L,6L,5L,4L,20L,28L,44L,16L,8L,29L,104L,207L,180L,151L,36L,13L,206L,775L,1288L,1407L,830L,437L,76L,21L,1708L,6140L,10366L,10384L,7298L,3100L,1138L,152L,34L,15702L,55427L,91296L,92896L,63140L,31278L,10048L,2744L,294L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080018Inst : IEnumerable<long>
{
public static readonly long[] Value=A080018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080018.Bytes);
public long this[int i]=>Value[i];

public static A080018Inst Instance=new A080018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080019
{
public static readonly long[] Value={ 1L,2L,4L,9L,20L,45L,101L,226L,506L,1133L,2538L,5680L,12722L,28494L,63819L,142937L,320140L,717027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080019Inst : IEnumerable<long>
{
public static readonly long[] Value=A080019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080019.Bytes);
public long this[int i]=>Value[i];

public static A080019Inst Instance=new A080019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080020
{
public static readonly long[] Value={ 367L,373L,379L,397L,409L,439L,457L,499L,523L,577L,607L,673L,709L,787L,829L,919L,967L,1069L,1123L,1237L,1297L,1423L,1489L,1627L,1699L,2089L,2347L,2437L,2719L,2917L,3019L,3229L,3559L,3673L,3907L,4027L,4273L,4657L,4789L,5059L,5197L,5479L,5623L,6067L,6373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080020Inst : IEnumerable<long>
{
public static readonly long[] Value=A080020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080020.Bytes);
public long this[int i]=>Value[i];

public static A080020Inst Instance=new A080020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080021
{
public static readonly long[] Value={ 2L,3L,7L,20L,148L,403L,1096L,1097L,2980L,2981L,8103L,59874L,162755L,442413L,1202604L,3269017L,8886110L,8886111L,24154952L,24154953L,65659969L,178482301L,3584912846L,9744803446L,26489122130L,72004899337L,195729609428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080021Inst : IEnumerable<long>
{
public static readonly long[] Value=A080021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080021.Bytes);
public long this[int i]=>Value[i];

public static A080021Inst Instance=new A080021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080022
{
public static readonly long[] Value={ 2L,3L,10L,31L,306L,9488L,9489L,29808L,29809L,93648L,294204L,9122171L,28658146L,888582403L,8769956796L,27551631843L,86556004192L,854273519914L,2683779414318L,8431341691876L,26487841119103L,26487841119104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080022Inst : IEnumerable<long>
{
public static readonly long[] Value=A080022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080022.Bytes);
public long this[int i]=>Value[i];

public static A080022Inst Instance=new A080022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080023
{
public static readonly long[] Value={ 2L,3L,4L,7L,11L,18L,29L,47L,76L,123L,199L,322L,521L,843L,1364L,2207L,3571L,5778L,9349L,15127L,24476L,39603L,64079L,103682L,167761L,271443L,439204L,710647L,1149851L,1860498L,3010349L,4870847L,7881196L,12752043L,20633239L,33385282L,54018521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080023Inst : IEnumerable<long>
{
public static readonly long[] Value=A080023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080023.Bytes);
public long this[int i]=>Value[i];

public static A080023Inst Instance=new A080023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080024
{
public static readonly long[] Value={ 1L,2L,0L,3L,0L,0L,0L,4L,1L,0L,0L,0L,0L,0L,0L,5L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080024Inst : IEnumerable<long>
{
public static readonly long[] Value=A080024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080024.Bytes);
public long this[int i]=>Value[i];

public static A080024Inst Instance=new A080024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080025
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,16L,18L,32L,36L,49L,64L,72L,98L,128L,133L,144L,196L,225L,256L,259L,266L,273L,288L,385L,392L,450L,512L,518L,532L,546L,576L,585L,645L,770L,784L,897L,900L,961L,1024L,1029L,1035L,1036L,1064L,1065L,1092L,1152L,1155L,1161L,1170L,1290L,1539L,1540L,1568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080025Inst : IEnumerable<long>
{
public static readonly long[] Value=A080025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080025.Bytes);
public long this[int i]=>Value[i];

public static A080025Inst Instance=new A080025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080026
{
public static readonly long[] Value={ 1L,9L,49L,225L,961L,3969L,6241L,8281L,16129L,24649L,25281L,33489L,34969L,65025L,82369L,100489L,101761L,123201L,133225L,140625L,143641L,198025L,261121L,328329L,330625L,405769L,408321L,494209L,540225L,564001L,576081L,582169L,664225L,797449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080026Inst : IEnumerable<long>
{
public static readonly long[] Value=A080026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080026.Bytes);
public long this[int i]=>Value[i];

public static A080026Inst Instance=new A080026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080027
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,4L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,4L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080027Inst : IEnumerable<long>
{
public static readonly long[] Value=A080027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080027.Bytes);
public long this[int i]=>Value[i];

public static A080027Inst Instance=new A080027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080028
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080028Inst : IEnumerable<long>
{
public static readonly long[] Value=A080028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080028.Bytes);
public long this[int i]=>Value[i];

public static A080028Inst Instance=new A080028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080029
{
public static readonly long[] Value={ 0L,2L,3L,6L,5L,9L,12L,8L,15L,18L,11L,21L,24L,14L,27L,30L,17L,33L,36L,20L,39L,42L,23L,45L,48L,26L,51L,54L,29L,57L,60L,32L,63L,66L,35L,69L,72L,38L,75L,78L,41L,81L,84L,44L,87L,90L,47L,93L,96L,50L,99L,102L,53L,105L,108L,56L,111L,114L,59L,117L,120L,62L,123L,126L,65L,129L,132L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080029Inst : IEnumerable<long>
{
public static readonly long[] Value=A080029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080029.Bytes);
public long this[int i]=>Value[i];

public static A080029Inst Instance=new A080029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080030
{
public static readonly long[] Value={ 2L,1L,4L,5L,7L,10L,8L,13L,16L,11L,19L,22L,14L,25L,28L,17L,31L,34L,20L,37L,40L,23L,43L,46L,26L,49L,52L,29L,55L,58L,32L,61L,64L,35L,67L,70L,38L,73L,76L,41L,79L,82L,44L,85L,88L,47L,91L,94L,50L,97L,100L,53L,103L,106L,56L,109L,112L,59L,115L,118L,62L,121L,124L,65L,127L,130L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080030Inst : IEnumerable<long>
{
public static readonly long[] Value=A080030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080030.Bytes);
public long this[int i]=>Value[i];

public static A080030Inst Instance=new A080030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080031
{
public static readonly long[] Value={ 1L,2L,5L,4L,8L,11L,7L,14L,17L,10L,20L,23L,13L,26L,29L,16L,32L,35L,19L,38L,41L,22L,44L,47L,25L,50L,53L,28L,56L,59L,31L,62L,65L,34L,68L,71L,37L,74L,77L,40L,80L,83L,43L,86L,89L,46L,92L,95L,49L,98L,101L,52L,104L,107L,55L,110L,113L,58L,116L,119L,61L,122L,125L,64L,128L,131L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080031Inst : IEnumerable<long>
{
public static readonly long[] Value=A080031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080031.Bytes);
public long this[int i]=>Value[i];

public static A080031Inst Instance=new A080031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080032
{
public static readonly long[] Value={ 0L,2L,4L,1L,6L,7L,8L,10L,12L,11L,14L,16L,18L,15L,20L,22L,24L,19L,26L,28L,30L,23L,32L,34L,36L,27L,38L,40L,42L,31L,44L,46L,48L,35L,50L,52L,54L,39L,56L,58L,60L,43L,62L,64L,66L,47L,68L,70L,72L,51L,74L,76L,78L,55L,80L,82L,84L,59L,86L,88L,90L,63L,92L,94L,96L,67L,98L,100L,102L,71L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080032Inst : IEnumerable<long>
{
public static readonly long[] Value=A080032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080032.Bytes);
public long this[int i]=>Value[i];

public static A080032Inst Instance=new A080032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080033
{
public static readonly long[] Value={ 0L,2L,4L,5L,8L,12L,7L,16L,20L,10L,24L,13L,28L,32L,15L,36L,40L,18L,44L,21L,48L,52L,23L,56L,60L,26L,64L,29L,68L,72L,31L,76L,80L,34L,84L,37L,88L,92L,39L,96L,100L,42L,104L,45L,108L,112L,47L,116L,120L,50L,124L,53L,128L,132L,55L,136L,140L,58L,144L,61L,148L,152L,63L,156L,160L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080033Inst : IEnumerable<long>
{
public static readonly long[] Value=A080033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080033.Bytes);
public long this[int i]=>Value[i];

public static A080033Inst Instance=new A080033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080034
{
public static readonly long[] Value={ 1L,3L,4L,7L,11L,6L,15L,19L,9L,23L,12L,27L,31L,14L,35L,39L,17L,43L,20L,47L,51L,22L,55L,59L,25L,63L,28L,67L,71L,30L,75L,79L,33L,83L,36L,87L,91L,38L,95L,99L,41L,103L,44L,107L,111L,46L,115L,119L,49L,123L,52L,127L,131L,54L,135L,139L,57L,143L,60L,147L,151L,62L,155L,159L,65L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080034Inst : IEnumerable<long>
{
public static readonly long[] Value=A080034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080034.Bytes);
public long this[int i]=>Value[i];

public static A080034Inst Instance=new A080034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080035
{
public static readonly long[] Value={ 127L,343L,736L,1285L,2187L,2502L,2592L,2737L,3125L,3685L,3864L,3972L,4096L,6455L,11264L,11664L,12850L,13825L,14641L,15552L,15585L,15612L,15613L,15617L,15618L,15621L,15622L,15623L,15624L,15626L,15632L,15633L,15642L,15645L,15655L,15656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080035Inst : IEnumerable<long>
{
public static readonly long[] Value=A080035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080035.Bytes);
public long this[int i]=>Value[i];

public static A080035Inst Instance=new A080035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080036
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,9L,10L,12L,13L,14L,15L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,38L,39L,40L,41L,42L,43L,44L,45L,47L,48L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,80L,81L,82L,83L,84L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080036Inst : IEnumerable<long>
{
public static readonly long[] Value=A080036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080036.Bytes);
public long this[int i]=>Value[i];

public static A080036Inst Instance=new A080036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080037
{
public static readonly long[] Value={ 2L,4L,6L,8L,9L,11L,12L,14L,15L,16L,18L,19L,20L,22L,23L,24L,25L,27L,28L,29L,30L,32L,33L,34L,35L,36L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,58L,59L,60L,61L,62L,63L,64L,66L,67L,68L,69L,70L,71L,72L,74L,75L,76L,77L,78L,79L,80L,81L,83L,84L,85L,86L,87L,88L,89L,90L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080037Inst : IEnumerable<long>
{
public static readonly long[] Value=A080037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080037.Bytes);
public long this[int i]=>Value[i];

public static A080037Inst Instance=new A080037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080038
{
public static readonly long[] Value={ 3L,3L,4L,3L,3L,4L,3L,3L,4L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,4L,3L,3L,4L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,4L,3L,3L,4L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,4L,3L,3L,4L,4L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080038Inst : IEnumerable<long>
{
public static readonly long[] Value=A080038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080038.Bytes);
public long this[int i]=>Value[i];

public static A080038Inst Instance=new A080038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080039
{
public static readonly long[] Value={ 1L,2L,5L,14L,33L,82L,197L,478L,1153L,2786L,6725L,16238L,39201L,94642L,228485L,551614L,1331713L,3215042L,7761797L,18738638L,45239073L,109216786L,263672645L,636562078L,1536796801L,3710155682L,8957108165L,21624372014L,52205852193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080039Inst : IEnumerable<long>
{
public static readonly long[] Value=A080039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080039.Bytes);
public long this[int i]=>Value[i];

public static A080039Inst Instance=new A080039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080040
{
public static readonly long[] Value={ 2L,2L,8L,20L,56L,152L,416L,1136L,3104L,8480L,23168L,63296L,172928L,472448L,1290752L,3526400L,9634304L,26321408L,71911424L,196465664L,536754176L,1466439680L,4006387712L,10945654784L,29904084992L,81699479552L,223207129088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080040Inst : IEnumerable<long>
{
public static readonly long[] Value=A080040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080040.Bytes);
public long this[int i]=>Value[i];

public static A080040Inst Instance=new A080040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080041
{
public static readonly long[] Value={ 1L,2L,7L,20L,55L,152L,415L,1136L,3103L,8480L,23167L,63296L,172927L,472448L,1290751L,3526400L,9634303L,26321408L,71911423L,196465664L,536754175L,1466439680L,4006387711L,10945654784L,29904084991L,81699479552L,223207129087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080041Inst : IEnumerable<long>
{
public static readonly long[] Value=A080041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080041.Bytes);
public long this[int i]=>Value[i];

public static A080041Inst Instance=new A080041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080042
{
public static readonly long[] Value={ 2L,4L,22L,100L,466L,2164L,10054L,46708L,216994L,1008100L,4683382L,21757828L,101081458L,469599316L,2181641638L,10135364500L,47086382914L,218751625156L,1016265649366L,4721317472932L,21934066839826L,101900219778100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080042Inst : IEnumerable<long>
{
public static readonly long[] Value=A080042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080042.Bytes);
public long this[int i]=>Value[i];

public static A080042Inst Instance=new A080042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080043
{
public static readonly long[] Value={ 1L,4L,21L,100L,465L,2164L,10053L,46708L,216993L,1008100L,4683381L,21757828L,101081457L,469599316L,2181641637L,10135364500L,47086382913L,218751625156L,1016265649365L,4721317472932L,21934066839825L,101900219778100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080043Inst : IEnumerable<long>
{
public static readonly long[] Value=A080043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080043.Bytes);
public long this[int i]=>Value[i];

public static A080043Inst Instance=new A080043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080044
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,4L,4L,1L,1L,19L,8L,19L,1L,1L,107L,17L,17L,107L,1L,1L,39L,181L,17L,181L,39L,1L,1L,293L,479L,218L,218L,479L,293L,1L,1L,621L,1058L,1351L,436L,1351L,1058L,621L,1L,1L,5869L,10327L,4563L,619L,619L,4563L,10327L,5869L,1L,1L,6121L,3685L,7541L,17677L,619L,17677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080044Inst : IEnumerable<long>
{
public static readonly long[] Value=A080044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080044.Bytes);
public long this[int i]=>Value[i];

public static A080044Inst Instance=new A080044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080045
{
public static readonly long[] Value={ 1L,2L,2L,3L,1L,3L,4L,3L,3L,4L,5L,12L,3L,12L,5L,6L,60L,4L,4L,60L,6L,7L,20L,30L,2L,30L,20L,7L,8L,140L,60L,15L,15L,60L,140L,8L,9L,280L,105L,60L,15L,60L,105L,280L,9L,10L,2520L,840L,140L,12L,12L,140L,840L,2520L,10L,11L,2520L,252L,168L,210L,6L,210L,168L,252L,2520L,11L,12L,27720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080045Inst : IEnumerable<long>
{
public static readonly long[] Value=A080045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080045.Bytes);
public long this[int i]=>Value[i];

public static A080045Inst Instance=new A080045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080046
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,4L,12L,12L,4L,5L,48L,144L,48L,5L,6L,240L,6912L,6912L,240L,6L,7L,1440L,1658880L,47775744L,1658880L,1440L,7L,8L,10080L,2388787200L,79254226206720L,79254226206720L,2388787200L,10080L,8L,9L,80640L,24078974976000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080046Inst : IEnumerable<long>
{
public static readonly long[] Value=A080046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080046.Bytes);
public long this[int i]=>Value[i];

public static A080046Inst Instance=new A080046Inst();

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