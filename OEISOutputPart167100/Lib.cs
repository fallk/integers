using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A210205
{
public static readonly long[] Value={ 439L,34603L,1016201L,3696493L,4002991L,6344687L,10221397L,14662309L,16209029L,19925483L,20856907L,22805969L,43441271L,60120691L,60761413L,62056457L,62710787L,87791567L,96268243L,125977651L,166225747L,170027449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210205Inst : IEnumerable<long>
{
public static readonly long[] Value=A210205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210205.Bytes);
public long this[int i]=>Value[i];

public static A210205Inst Instance=new A210205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210206
{
public static readonly long[] Value={ 12L,42L,90L,160L,240L,344L,462L,598L,756L,922L,1108L,1314L,1534L,1772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210206Inst : IEnumerable<long>
{
public static readonly long[] Value=A210206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210206.Bytes);
public long this[int i]=>Value[i];

public static A210206Inst Instance=new A210206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210207
{
public static readonly long[] Value={ 168L,432L,480L,624L,672L,768L,1320L,1512L,1536L,1560L,1680L,1728L,1848L,1920L,2040L,2304L,2376L,2496L,2520L,2688L,2856L,3024L,3072L,3240L,3696L,3720L,3840L,3864L,3888L,4104L,4200L,4320L,4536L,5280L,5376L,5616L,5712L,6000L,6048L,6144L,6240L,6552L,6720L,6912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210207Inst : IEnumerable<long>
{
public static readonly long[] Value=A210207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210207.Bytes);
public long this[int i]=>Value[i];

public static A210207Inst Instance=new A210207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210208
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,4L,1L,5L,1L,2L,3L,1L,7L,1L,2L,4L,8L,1L,3L,9L,1L,2L,5L,1L,11L,1L,2L,3L,4L,1L,13L,1L,2L,7L,1L,3L,5L,1L,2L,4L,8L,16L,1L,17L,1L,2L,3L,9L,1L,19L,1L,2L,4L,5L,1L,3L,7L,1L,2L,11L,1L,23L,1L,2L,3L,4L,8L,1L,5L,25L,1L,2L,13L,1L,3L,9L,27L,1L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210208Inst : IEnumerable<long>
{
public static readonly long[] Value=A210208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210208.Bytes);
public long this[int i]=>Value[i];

public static A210208Inst Instance=new A210208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210209
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,4L,1L,3L,2L,11L,1L,8L,1L,29L,2L,21L,1L,76L,1L,55L,2L,199L,1L,144L,1L,521L,2L,377L,1L,1364L,1L,987L,2L,3571L,1L,2584L,1L,9349L,2L,6765L,1L,24476L,1L,17711L,2L,64079L,1L,46368L,1L,167761L,2L,121393L,1L,439204L,1L,317811L,2L,1149851L,1L,832040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210209Inst : IEnumerable<long>
{
public static readonly long[] Value=A210209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210209.Bytes);
public long this[int i]=>Value[i];

public static A210209Inst Instance=new A210209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210210
{
public static readonly long[] Value={ 0L,1L,2L,4L,2L,2L,4L,1L,2L,3L,3L,6L,2L,9L,4L,6L,7L,4L,4L,6L,3L,3L,3L,5L,2L,6L,4L,4L,4L,8L,3L,4L,6L,3L,3L,8L,8L,6L,6L,7L,7L,10L,7L,6L,14L,5L,5L,8L,5L,4L,6L,3L,3L,13L,2L,14L,12L,12L,12L,18L,18L,18L,11L,11L,11L,17L,10L,11L,11L,16L,16L,9L,9L,16L,15L,16L,8L,14L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210210Inst : IEnumerable<long>
{
public static readonly long[] Value=A210210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210210.Bytes);
public long this[int i]=>Value[i];

public static A210210Inst Instance=new A210210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210211
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,8L,8L,1L,5L,14L,19L,16L,1L,6L,21L,42L,42L,32L,1L,7L,30L,72L,114L,89L,64L,1L,8L,40L,120L,216L,290L,184L,128L,1L,9L,52L,178L,414L,593L,706L,375L,256L,1L,10L,65L,260L,670L,1292L,1531L,1666L,758L,512L,1L,11L,80L,355L,1090L,2247L,3754L,3782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210211Inst : IEnumerable<long>
{
public static readonly long[] Value=A210211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210211.Bytes);
public long this[int i]=>Value[i];

public static A210211Inst Instance=new A210211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210212
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,4L,4L,10L,11L,8L,5L,16L,28L,23L,16L,6L,24L,51L,72L,47L,32L,7L,33L,90L,144L,176L,95L,64L,8L,44L,138L,294L,377L,416L,191L,128L,9L,56L,208L,492L,878L,938L,960L,383L,256L,10L,70L,290L,830L,1577L,2462L,2251L,2176L,767L,512L,11L,85L,400L,1250L,2952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210212Inst : IEnumerable<long>
{
public static readonly long[] Value=A210212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210212.Bytes);
public long this[int i]=>Value[i];

public static A210212Inst Instance=new A210212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210213
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,1L,7L,9L,4L,1L,12L,21L,16L,5L,1L,20L,46L,46L,25L,6L,1L,33L,94L,121L,85L,36L,7L,1L,54L,185L,289L,260L,141L,49L,8L,1L,88L,353L,653L,708L,491L,217L,64L,9L,1L,143L,659L,1409L,1800L,1499L,847L,316L,81L,10L,1L,232L,1209L,2939L,4320L,4229L,2863L,1366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210213Inst : IEnumerable<long>
{
public static readonly long[] Value=A210213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210213.Bytes);
public long this[int i]=>Value[i];

public static A210213Inst Instance=new A210213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210214
{
public static readonly long[] Value={ 1L,3L,1L,6L,5L,1L,11L,14L,7L,1L,19L,34L,25L,9L,1L,32L,74L,75L,39L,11L,1L,53L,152L,195L,139L,56L,13L,1L,87L,299L,468L,419L,231L,76L,15L,1L,142L,571L,1056L,1147L,791L,356L,99L,17L,1L,231L,1066L,2280L,2911L,2429L,1364L,519L,125L,19L,1L,375L,1956L,4755L,6991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210214Inst : IEnumerable<long>
{
public static readonly long[] Value=A210214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210214.Bytes);
public long this[int i]=>Value[i];

public static A210214Inst Instance=new A210214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210215
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,1L,2L,5L,7L,1L,2L,5L,12L,11L,1L,2L,5L,13L,26L,16L,1L,2L,5L,13L,33L,51L,22L,1L,2L,5L,13L,34L,79L,92L,29L,1L,2L,5L,13L,34L,88L,176L,155L,37L,1L,2L,5L,13L,34L,89L,221L,365L,247L,46L,1L,2L,5L,13L,34L,89L,232L,530L,709L,376L,56L,1L,2L,5L,13L,34L,89L,233L,596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210215Inst : IEnumerable<long>
{
public static readonly long[] Value=A210215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210215.Bytes);
public long this[int i]=>Value[i];

public static A210215Inst Instance=new A210215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210216
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,3L,7L,4L,1L,3L,8L,14L,5L,1L,3L,8L,20L,25L,6L,1L,3L,8L,21L,46L,41L,7L,1L,3L,8L,21L,54L,97L,63L,8L,1L,3L,8L,21L,55L,133L,189L,92L,9L,1L,3L,8L,21L,55L,143L,309L,344L,129L,10L,1L,3L,8L,21L,55L,144L,364L,674L,591L,175L,11L,1L,3L,8L,21L,55L,144L,376L,894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210216Inst : IEnumerable<long>
{
public static readonly long[] Value=A210216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210216.Bytes);
public long this[int i]=>Value[i];

public static A210216Inst Instance=new A210216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210217
{
public static readonly long[] Value={ 1L,2L,1L,2L,5L,1L,2L,6L,12L,1L,2L,6L,19L,27L,1L,2L,6L,20L,57L,58L,1L,2L,6L,20L,67L,160L,121L,1L,2L,6L,20L,68L,218L,424L,248L,1L,2L,6L,20L,68L,231L,680L,1073L,503L,1L,2L,6L,20L,68L,232L,775L,2028L,2619L,1014L,1L,2L,6L,20L,68L,232L,791L,2543L,5797L,6214L,2037L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210217Inst : IEnumerable<long>
{
public static readonly long[] Value=A210217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210217.Bytes);
public long this[int i]=>Value[i];

public static A210217Inst Instance=new A210217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210218
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,7L,1L,4L,13L,15L,1L,4L,14L,38L,31L,1L,4L,14L,47L,103L,63L,1L,4L,14L,48L,151L,264L,127L,1L,4L,14L,48L,163L,462L,649L,255L,1L,4L,14L,48L,164L,544L,1348L,1546L,511L,1L,4L,14L,48L,164L,559L,1768L,3769L,3595L,1023L,1L,4L,14L,48L,164L,560L,1893L,5564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210218Inst : IEnumerable<long>
{
public static readonly long[] Value=A210218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210218.Bytes);
public long this[int i]=>Value[i];

public static A210218Inst Instance=new A210218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210219
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,9L,7L,1L,5L,16L,22L,11L,1L,6L,25L,50L,46L,16L,1L,7L,36L,95L,130L,86L,22L,1L,8L,49L,161L,295L,296L,148L,29L,1L,9L,64L,252L,581L,791L,610L,239L,37L,1L,10L,81L,372L,1036L,1792L,1897L,1163L,367L,46L,1L,11L,100L,525L,1716L,3612L,4900L,4166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210219Inst : IEnumerable<long>
{
public static readonly long[] Value=A210219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210219.Bytes);
public long this[int i]=>Value[i];

public static A210219Inst Instance=new A210219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210220
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,3L,4L,12L,13L,4L,5L,20L,34L,24L,5L,6L,30L,70L,80L,40L,6L,7L,42L,125L,200L,166L,62L,7L,8L,56L,203L,420L,496L,314L,91L,8L,9L,72L,308L,784L,1211L,1106L,553L,128L,9L,10L,90L,444L,1344L,2576L,3108L,2269L,920L,174L,10L,11L,110L,615L,2160L,4956L,7476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210220Inst : IEnumerable<long>
{
public static readonly long[] Value=A210220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210220.Bytes);
public long this[int i]=>Value[i];

public static A210220Inst Instance=new A210220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210221
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,4L,4L,8L,10L,8L,8L,13L,20L,24L,16L,16L,21L,40L,52L,56L,32L,32L,34L,76L,116L,128L,128L,64L,64L,55L,142L,240L,312L,304L,288L,128L,128L,89L,260L,488L,688L,800L,704L,640L,256L,256L,144L,470L,964L,1496L,1856L,1984L,1600L,1408L,512L,512L,233L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210221Inst : IEnumerable<long>
{
public static readonly long[] Value=A210221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210221.Bytes);
public long this[int i]=>Value[i];

public static A210221Inst Instance=new A210221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210222
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,2L,4L,12L,10L,2L,5L,20L,28L,14L,2L,6L,30L,60L,52L,18L,2L,7L,42L,110L,140L,84L,22L,2L,8L,56L,182L,310L,276L,124L,26L,2L,9L,72L,280L,602L,726L,484L,172L,30L,2L,10L,90L,408L,1064L,1638L,1486L,780L,228L,34L,2L,11L,110L,570L,1752L,3304L,3850L,2750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210222Inst : IEnumerable<long>
{
public static readonly long[] Value=A210222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210222.Bytes);
public long this[int i]=>Value[i];

public static A210222Inst Instance=new A210222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210223
{
public static readonly long[] Value={ 1L,2L,1L,2L,5L,1L,2L,7L,10L,1L,2L,7L,22L,17L,1L,2L,7L,26L,57L,26L,1L,2L,7L,26L,89L,126L,37L,1L,2L,7L,26L,97L,266L,247L,50L,1L,2L,7L,26L,97L,346L,695L,442L,65L,1L,2L,7L,26L,97L,362L,1127L,1618L,737L,82L,1L,2L,7L,26L,97L,362L,1319L,3298L,3425L,1162L,101L,1L,2L,7L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210223Inst : IEnumerable<long>
{
public static readonly long[] Value=A210223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210223.Bytes);
public long this[int i]=>Value[i];

public static A210223Inst Instance=new A210223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210224
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,5L,1L,5L,15L,7L,1L,5L,19L,35L,9L,1L,5L,19L,63L,69L,11L,1L,5L,19L,71L,177L,121L,13L,1L,5L,19L,71L,249L,429L,195L,15L,1L,5L,19L,71L,265L,781L,923L,295L,17L,1L,5L,19L,71L,265L,957L,2171L,1807L,425L,19L,1L,5L,19L,71L,265L,989L,3211L,5407L,3281L,589L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210224Inst : IEnumerable<long>
{
public static readonly long[] Value=A210224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210224.Bytes);
public long this[int i]=>Value[i];

public static A210224Inst Instance=new A210224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210225
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,1L,4L,12L,10L,1L,5L,22L,36L,17L,1L,6L,35L,88L,87L,26L,1L,7L,51L,175L,277L,181L,37L,1L,8L,70L,306L,680L,734L,338L,50L,1L,9L,92L,490L,1416L,2196L,1710L,582L,65L,1L,10L,117L,736L,2632L,5402L,6156L,3606L,941L,82L,1L,11L,145L,1053L,4502L,11592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210225Inst : IEnumerable<long>
{
public static readonly long[] Value=A210225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210225.Bytes);
public long this[int i]=>Value[i];

public static A210225Inst Instance=new A210225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210226
{
public static readonly long[] Value={ 1L,2L,3L,3L,9L,5L,4L,18L,24L,7L,5L,30L,66L,51L,9L,6L,45L,140L,189L,94L,11L,7L,63L,255L,505L,457L,157L,13L,8L,84L,420L,1110L,1516L,976L,244L,15L,9L,108L,644L,2142L,3986L,3960L,1896L,359L,17L,10L,135L,936L,3766L,8960L,12338L,9276L,3419L,506L,19L,11L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210226Inst : IEnumerable<long>
{
public static readonly long[] Value=A210226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210226.Bytes);
public long this[int i]=>Value[i];

public static A210226Inst Instance=new A210226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210227
{
public static readonly long[] Value={ 1L,2L,1L,2L,6L,1L,2L,8L,16L,1L,2L,8L,32L,38L,1L,2L,8L,36L,112L,84L,1L,2L,8L,36L,156L,348L,178L,1L,2L,8L,36L,164L,620L,988L,368L,1L,2L,8L,36L,164L,732L,2244L,2624L,750L,1L,2L,8L,36L,164L,748L,3108L,7468L,6632L,1516L,1L,2L,8L,36L,164L,748L,3380L,12348L,23164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210227Inst : IEnumerable<long>
{
public static readonly long[] Value=A210227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210227.Bytes);
public long this[int i]=>Value[i];

public static A210227Inst Instance=new A210227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210228
{
public static readonly long[] Value={ 1L,1L,4L,1L,6L,10L,1L,6L,24L,22L,1L,6L,28L,80L,46L,1L,6L,28L,120L,236L,94L,1L,6L,28L,128L,464L,640L,190L,1L,6L,28L,128L,568L,1624L,1636L,382L,1L,6L,28L,128L,584L,2376L,5224L,4008L,766L,1L,6L,28L,128L,584L,2632L,9240L,15696L,9516L,1534L,1L,6L,28L,128L,584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210228Inst : IEnumerable<long>
{
public static readonly long[] Value=A210228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210228.Bytes);
public long this[int i]=>Value[i];

public static A210228Inst Instance=new A210228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210229
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,1L,7L,8L,4L,1L,12L,18L,13L,5L,1L,20L,38L,35L,19L,6L,1L,33L,76L,86L,59L,26L,7L,1L,54L,147L,197L,164L,91L,34L,8L,1L,88L,277L,430L,420L,281L,132L,43L,9L,1L,143L,512L,904L,1014L,792L,447L,183L,53L,10L,1L,232L,932L,1846L,2338L,2087L,1371L,673L,245L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210229Inst : IEnumerable<long>
{
public static readonly long[] Value=A210229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210229.Bytes);
public long this[int i]=>Value[i];

public static A210229Inst Instance=new A210229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210230
{
public static readonly long[] Value={ 1L,3L,1L,6L,4L,1L,11L,11L,5L,1L,19L,26L,17L,6L,1L,32L,56L,48L,24L,7L,1L,53L,114L,121L,78L,32L,8L,1L,87L,223L,283L,223L,117L,41L,9L,1L,142L,424L,627L,584L,372L,166L,51L,10L,1L,231L,789L,1334L,1434L,1073L,579L,226L,62L,11L,1L,375L,1444L,2750L,3352L,2879L,1818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210230Inst : IEnumerable<long>
{
public static readonly long[] Value=A210230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210230.Bytes);
public long this[int i]=>Value[i];

public static A210230Inst Instance=new A210230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210231
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,8L,7L,1L,5L,14L,18L,11L,1L,6L,21L,39L,36L,16L,1L,7L,30L,69L,93L,66L,22L,1L,8L,40L,114L,192L,199L,113L,29L,1L,9L,52L,172L,360L,474L,393L,183L,37L,1L,10L,65L,250L,610L,997L,1068L,729L,283L,46L,1L,11L,80L,345L,980L,1882L,2501L,2238L,1285L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210231Inst : IEnumerable<long>
{
public static readonly long[] Value=A210231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210231.Bytes);
public long this[int i]=>Value[i];

public static A210231Inst Instance=new A210231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210232
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,10L,10L,4L,5L,16L,25L,18L,5L,6L,24L,48L,54L,30L,6L,7L,33L,84L,123L,106L,47L,7L,8L,44L,132L,246L,282L,194L,70L,8L,9L,56L,198L,438L,637L,594L,336L,100L,9L,10L,70L,280L,730L,1272L,1504L,1170L,556L,138L,10L,11L,85L,385L,1140L,2337L,3337L,3301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210232Inst : IEnumerable<long>
{
public static readonly long[] Value=A210232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210232.Bytes);
public long this[int i]=>Value[i];

public static A210232Inst Instance=new A210232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210233
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,1L,4L,10L,12L,1L,5L,18L,30L,27L,1L,6L,27L,68L,83L,58L,1L,7L,39L,119L,225L,217L,121L,1L,8L,52L,200L,454L,680L,544L,248L,1L,9L,68L,300L,866L,1566L,1928L,1320L,503L,1L,10L,85L,440L,1450L,3332L,5014L,5216L,3121L,1014L,1L,11L,105L,605L,2350L,6182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210233Inst : IEnumerable<long>
{
public static readonly long[] Value=A210233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210233.Bytes);
public long this[int i]=>Value[i];

public static A210233Inst Instance=new A210233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210234
{
public static readonly long[] Value={ 1L,2L,3L,3L,7L,7L,4L,14L,20L,15L,5L,22L,50L,53L,31L,6L,33L,92L,157L,134L,63L,7L,45L,161L,335L,455L,327L,127L,8L,60L,248L,666L,1112L,1248L,776L,255L,9L,76L,372L,1150L,2466L,3448L,3288L,1801L,511L,10L,95L,520L,1910L,4732L,8426L,10144L,8399L,4106L,1023L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210234Inst : IEnumerable<long>
{
public static readonly long[] Value=A210234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210234.Bytes);
public long this[int i]=>Value[i];

public static A210234Inst Instance=new A210234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210235
{
public static readonly long[] Value={ 1L,2L,1L,4L,4L,1L,7L,12L,7L,1L,12L,29L,28L,11L,1L,20L,64L,86L,56L,16L,1L,33L,132L,230L,210L,101L,22L,1L,54L,261L,560L,662L,451L,169L,29L,1L,88L,500L,1279L,1860L,1646L,883L,267L,37L,1L,143L,936L,2785L,4819L,5257L,3682L,1611L,403L,46L,1L,232L,1721L,5848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210235Inst : IEnumerable<long>
{
public static readonly long[] Value=A210235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210235.Bytes);
public long this[int i]=>Value[i];

public static A210235Inst Instance=new A210235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210236
{
public static readonly long[] Value={ 1L,3L,2L,6L,8L,3L,11L,22L,16L,4L,19L,52L,57L,28L,5L,32L,112L,166L,124L,45L,6L,53L,228L,428L,432L,241L,68L,7L,87L,446L,1018L,1300L,984L,432L,98L,8L,142L,848L,2285L,3540L,3397L,2036L,728L,136L,9L,231L,1578L,4912L,8964L,10443L,7962L,3914L,1168L,183L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210236Inst : IEnumerable<long>
{
public static readonly long[] Value=A210236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210236.Bytes);
public long this[int i]=>Value[i];

public static A210236Inst Instance=new A210236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210237
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,6L,1L,4L,6L,12L,24L,1L,5L,10L,20L,30L,60L,120L,1L,6L,15L,20L,30L,60L,90L,120L,180L,360L,720L,1L,7L,21L,35L,42L,105L,140L,210L,420L,630L,840L,1260L,2520L,5040L,1L,8L,28L,56L,70L,168L,280L,336L,420L,560L,840L,1120L,1680L,2520L,3360L,5040L,6720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210237Inst : IEnumerable<long>
{
public static readonly long[] Value=A210237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210237.Bytes);
public long this[int i]=>Value[i];

public static A210237Inst Instance=new A210237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210238
{
public static readonly long[] Value={ 1L,2L,1L,3L,6L,1L,4L,12L,6L,12L,1L,5L,20L,20L,30L,30L,20L,1L,6L,30L,30L,15L,60L,120L,20L,60L,90L,30L,1L,7L,42L,42L,42L,105L,210L,105L,245L,420L,140L,105L,210L,42L,1L,8L,56L,56L,224L,28L,336L,336L,280L,168L,168L,840L,420L,1120L,70L,1120L,560L,168L,420L,56L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210238Inst : IEnumerable<long>
{
public static readonly long[] Value=A210238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210238.Bytes);
public long this[int i]=>Value[i];

public static A210238Inst Instance=new A210238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210239
{
public static readonly long[] Value={ 1L,2L,2L,2L,5L,3L,2L,9L,12L,5L,2L,13L,28L,25L,8L,2L,17L,52L,74L,50L,13L,2L,21L,84L,167L,177L,96L,21L,2L,25L,124L,320L,470L,397L,180L,34L,2L,29L,172L,549L,1041L,1211L,850L,331L,55L,2L,33L,228L,870L,2034L,3042L,2928L,1758L,600L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210239Inst : IEnumerable<long>
{
public static readonly long[] Value=A210239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210239.Bytes);
public long this[int i]=>Value[i];

public static A210239Inst Instance=new A210239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210240
{
public static readonly long[] Value={ 5L,8L,13L,17L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210240Inst : IEnumerable<long>
{
public static readonly long[] Value=A210240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210240.Bytes);
public long this[int i]=>Value[i];

public static A210240Inst Instance=new A210240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210241
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,13L,15L,19L,22L,25L,27L,31L,33L,36L,39L,44L,46L,50L,52L,56L,59L,62L,64L,69L,72L,75L,79L,83L,85L,89L,91L,97L,100L,103L,106L,111L,113L,116L,119L,124L,126L,130L,132L,136L,140L,143L,145L,151L,154L,158L,161L,165L,167L,172L,175L,180L,183L,186L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210241Inst : IEnumerable<long>
{
public static readonly long[] Value=A210241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210241.Bytes);
public long this[int i]=>Value[i];

public static A210241Inst Instance=new A210241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210242
{
public static readonly long[] Value={ 17L,19L,89L,97L,137L,139L,263L,269L,757L,761L,907L,911L,1201L,1213L,1481L,1483L,2309L,2311L,2609L,2617L,4679L,4691L,5743L,5749L,10733L,10739L,16103L,16111L,16267L,16273L,19759L,19763L,20269L,20287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210242Inst : IEnumerable<long>
{
public static readonly long[] Value=A210242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210242.Bytes);
public long this[int i]=>Value[i];

public static A210242Inst Instance=new A210242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210243
{
public static readonly long[] Value={ 1L,3L,1L,2L,3L,2L,1L,3L,2L,1L,2L,3L,1L,3L,1L,2L,3L,2L,3L,1L,2L,1L,3L,2L,1L,3L,1L,2L,3L,2L,1L,3L,2L,1L,2L,3L,1L,3L,2L,1L,3L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,3L,2L,1L,3L,2L,1L,2L,3L,1L,3L,1L,2L,3L,2L,3L,1L,2L,1L,3L,2L,1L,3L,1L,2L,3L,2L,3L,1L,2L,1L,2L,3L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210243Inst : IEnumerable<long>
{
public static readonly long[] Value=A210243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210243.Bytes);
public long this[int i]=>Value[i];

public static A210243Inst Instance=new A210243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210244
{
public static readonly long[] Value={ -1L,-1L,1L,5L,-7L,-49L,-53L,2215L,1259L,-14201L,-183197L,248885L,9583753L,14525053L,-554173253L,-4573299625L,99833187251L,215440236599L,-1654012631597L,-84480933600305L,-36267273557287L,10992430255511053L,117548575473066241L,-1380910044674479865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210244Inst : IEnumerable<long>
{
public static readonly long[] Value=A210244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210244.Bytes);
public long this[int i]=>Value[i];

public static A210244Inst Instance=new A210244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210245
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210245Inst : IEnumerable<long>
{
public static readonly long[] Value=A210245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210245.Bytes);
public long this[int i]=>Value[i];

public static A210245Inst Instance=new A210245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210246
{
public static readonly BigInteger[] Value={ 1L,-1L,-2L,2L,40L,104L,-1232L,-13168L,16000L,1483904L,9695488L,-151161088L,-3287997440L,146760704L,866038110208L,10263094740992L,-169941494497280L,-6324725967978496L,-15215847186563072L,2895126258819203072L,BigInteger.Parse("54295929047166484480") };
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
public class A210246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210246Inst Instance=new A210246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210247
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210247Inst : IEnumerable<long>
{
public static readonly long[] Value=A210247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210247.Bytes);
public long this[int i]=>Value[i];

public static A210247Inst Instance=new A210247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210248
{
public static readonly long[] Value={ 7L,241L,967L,15787L,111577L,1587499L,25230061L,118194961L,188698981L,761453863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210248Inst : IEnumerable<long>
{
public static readonly long[] Value=A210248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210248.Bytes);
public long this[int i]=>Value[i];

public static A210248Inst Instance=new A210248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210249
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,3L,4L,8L,10L,18L,23L,37L,47L,71L,90L,131L,164L,230L,288L,393L,488L,653L,807L,1060L,1303L,1686L,2063L,2637L,3210L,4057L,4920L,6158L,7434L,9228L,11098L,13671L,16380L,20040L,23928L,29098L,34624L,41869L,49668L,59755L,70667L,84626L,99795L,118991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210249Inst : IEnumerable<long>
{
public static readonly long[] Value=A210249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210249.Bytes);
public long this[int i]=>Value[i];

public static A210249Inst Instance=new A210249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210250
{
public static readonly long[] Value={ 48L,192L,240L,432L,480L,672L,768L,936L,960L,1200L,1440L,1680L,1728L,1920L,2160L,2352L,2640L,2688L,2856L,3072L,3744L,3840L,3864L,3888L,4032L,4320L,4368L,4536L,4800L,5016L,5040L,5376L,5712L,5760L,5808L,5880L,6000L,6048L,6072L,6696L,6720L,6912L,7056L,7392L,7560L,7680L,7728L,7752L,7920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210250Inst : IEnumerable<long>
{
public static readonly long[] Value=A210250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210250.Bytes);
public long this[int i]=>Value[i];

public static A210250Inst Instance=new A210250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210251
{
public static readonly long[] Value={ 1L,9L,21L,25L,29L,41L,49L,61L,69L,81L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210251Inst : IEnumerable<long>
{
public static readonly long[] Value=A210251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210251.Bytes);
public long this[int i]=>Value[i];

public static A210251Inst Instance=new A210251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210252
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,4L,0L,0L,0L,3L,24L,0L,0L,0L,0L,33L,188L,0L,0L,0L,0L,13L,338L,1705L,0L,0L,0L,0L,0L,252L,3580L,16980L,0L,0L,0L,0L,0L,68L,3740L,39525L,180670L,0L,0L,0L,0L,0L,0L,1938L,51300L,452865L,2020120L,0L,0L,0L,0L,0L,0L,399L,38076L,685419L,5354832L,23478426L,0L,0L,0L,0L,0L,0L,0L,15180L,646415L,9095856L,65022840L,281481880L,0L,0L,0L,0L,0L,0L,0L,2530L,373175L,10215450L,120872850L,807560625L,3461873536L,0L,0L,0L,0L,0L,0L,0L,0L,121095L,7580040L,155282400L,1614234960L,10224817515L,43494961404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210252Inst : IEnumerable<long>
{
public static readonly long[] Value=A210252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210252.Bytes);
public long this[int i]=>Value[i];

public static A210252Inst Instance=new A210252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210253
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,8L,9L,10L,11L,13L,14L,16L,16L,16L,17L,18L,19L,20L,22L,24L,24L,25L,26L,27L,29L,30L,32L,32L,32L,32L,33L,34L,35L,36L,37L,40L,40L,41L,42L,43L,45L,46L,48L,48L,48L,49L,50L,51L,52L,54L,56L,56L,57L,58L,59L,61L,62L,64L,64L,64L,64L,64L,65L,66L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210253Inst : IEnumerable<long>
{
public static readonly long[] Value=A210253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210253.Bytes);
public long this[int i]=>Value[i];

public static A210253Inst Instance=new A210253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210254
{
public static readonly long[] Value={ 0L,7L,12L,15L,21L,23L,28L,31L,38L,39L,44L,47L,53L,55L,60L,63L,70L,76L,79L,85L,87L,92L,95L,102L,103L,108L,111L,117L,119L,124L,127L,134L,136L,140L,143L,149L,151L,156L,159L,166L,167L,172L,175L,181L,183L,188L,191L,198L,204L,207L,213L,215L,220L,223L,230L,231L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210254Inst : IEnumerable<long>
{
public static readonly long[] Value=A210254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210254.Bytes);
public long this[int i]=>Value[i];

public static A210254Inst Instance=new A210254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210255
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,0L,1L,2L,1L,1L,2L,0L,0L,0L,1L,2L,1L,2L,2L,0L,0L,1L,2L,1L,1L,2L,0L,0L,0L,0L,1L,2L,1L,2L,3L,0L,0L,1L,2L,1L,1L,2L,0L,0L,0L,1L,2L,1L,2L,2L,0L,0L,1L,2L,1L,1L,2L,0L,0L,0L,0L,0L,1L,2L,1L,2L,3L,1L,0L,1L,2L,1L,1L,2L,0L,0L,0L,1L,2L,1L,2L,2L,0L,0L,1L,2L,1L,1L,2L,0L,0L,0L,0L,1L,2L,1L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210255Inst : IEnumerable<long>
{
public static readonly long[] Value=A210255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210255.Bytes);
public long this[int i]=>Value[i];

public static A210255Inst Instance=new A210255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210256
{
public static readonly long[] Value={ 2L,1L,3L,1L,4L,1L,2L,4L,2L,1L,6L,1L,2L,2L,6L,1L,3L,1L,7L,2L,2L,1L,4L,6L,2L,2L,3L,1L,9L,1L,3L,2L,2L,2L,10L,1L,2L,2L,4L,1L,10L,1L,3L,3L,2L,1L,5L,8L,3L,2L,3L,1L,4L,2L,11L,2L,2L,1L,6L,1L,2L,3L,11L,2L,4L,1L,3L,2L,4L,1L,14L,1L,2L,3L,3L,2L,4L,1L,5L,11L,2L,1L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210256Inst : IEnumerable<long>
{
public static readonly long[] Value=A210256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210256.Bytes);
public long this[int i]=>Value[i];

public static A210256Inst Instance=new A210256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210257
{
public static readonly BigInteger[] Value={ 1L,212L,32423L,4364634L,548696845L,651081291281056L,BigInteger.Parse("7612101512161215101267"),BigInteger.Parse("87141218152016201518121478"),BigInteger.Parse("981614211824202520241821141689"),BigInteger.Parse("109181624212824302530242821241618910") };
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
public class A210257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210257Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210257.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210257.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210257Inst Instance=new A210257Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210258
{
public static readonly long[] Value={ 1L,1L,-2L,1L,-3L,3L,1L,-4L,4L,2L,-4L,1L,-5L,5L,5L,-5L,-5L,5L,1L,-6L,6L,9L,-6L,-12L,6L,-2L,6L,3L,-6L,1L,-7L,7L,14L,-7L,-21L,7L,-7L,14L,7L,-7L,7L,-7L,-7L,7L,1L,-8L,8L,20L,-8L,-32L,8L,-16L,24L,12L,-8L,24L,-16L,-16L,8L,2L,-8L,-8L,8L,8L,8L,-8L,1L,-9L,9L,27L,-9L,-45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210258Inst : IEnumerable<long>
{
public static readonly long[] Value=A210258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210258.Bytes);
public long this[int i]=>Value[i];

public static A210258Inst Instance=new A210258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210259
{
public static readonly BigInteger[] Value={ 0L,1039L,1409910L,9204003223L,332946143914838L,BigInteger.Parse("67504950532170896962"),BigInteger.Parse("76734939290291126791703390"),BigInteger.Parse("489053432070220933819410319061667") };
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
public class A210259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210259Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210259.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210259.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210259Inst Instance=new A210259Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210260
{
public static readonly long[] Value={ 0L,29L,400L,4298L,42520L,406580L,3828928L,35804264L,333688864L,3104980304L,28869996928L,268334928032L,2493631919488L,23171354998592L,215304570112000L,2000537970249344L,18588159494998528L,172712625468359936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210260Inst : IEnumerable<long>
{
public static readonly long[] Value=A210260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210260.Bytes);
public long this[int i]=>Value[i];

public static A210260Inst Instance=new A210260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210261
{
public static readonly BigInteger[] Value={ 29L,1039L,25901L,592969L,13233079L,292930403L,6467110597L,142651105201L,3145676312903L,69360351853819L,1529307333302941L,33718923388205609L,743448896978561935L,16391852782863165859UL,BigInteger.Parse("361413860134081682837") };
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
public class A210261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210261Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210261.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210261.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210261Inst Instance=new A210261Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210262
{
public static readonly BigInteger[] Value={ 400L,25901L,1409910L,74289956L,3885183814L,202860601666L,10588222391490L,552602645281386L,28839969343496682L,1505132834337221378L,BigInteger.Parse("78551495655794104818"),BigInteger.Parse("4099529313431145641202"),BigInteger.Parse("213950602165064389073730") };
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
public class A210262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210262Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210262.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210262.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210262Inst Instance=new A210262Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210263
{
public static readonly BigInteger[] Value={ 4298L,592969L,74289956L,9204003223L,1137801615818L,140618780386783L,17377926553935982L,2147582662927620895L,BigInteger.Parse("265400237596322758282"),BigInteger.Parse("32798400227021219841431"),BigInteger.Parse("4053255707882983814841256") };
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
public class A210263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210263Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210263.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210263.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210263Inst Instance=new A210263Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210264
{
public static readonly BigInteger[] Value={ 42520L,13233079L,3885183814L,1137801615818L,332946143914838L,97427021073113618L,BigInteger.Parse("28508853879455964312"),BigInteger.Parse("8342193957083521350330"),BigInteger.Parse("2441072766493238740821372"),BigInteger.Parse("714300863819734626424099882") };
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
public class A210264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210264Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210264.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210264.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210264Inst Instance=new A210264Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210265
{
public static readonly BigInteger[] Value={ 406580L,292930403L,202860601666L,140618780386783L,97427021073113618L,BigInteger.Parse("67504950532170896962"),BigInteger.Parse("46772256594635018663098"),BigInteger.Parse("32407200627974582453716845"),BigInteger.Parse("22454047914872390935721775848"),BigInteger.Parse("15557785658285684261082467862656") };
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
public class A210265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210265.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210265Inst Instance=new A210265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210266
{
public static readonly BigInteger[] Value={ 3828928L,6467110597L,10588222391490L,17377926553935982L,BigInteger.Parse("28508853879455964312"),BigInteger.Parse("46772256594635018663098"),BigInteger.Parse("76734939290291126791703390"),BigInteger.Parse("125892128682791619473809468768"),BigInteger.Parse("206539882212054243580765021833408") };
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
public class A210266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210266Inst Instance=new A210266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210267
{
public static readonly long[] Value={ 0L,29L,29L,400L,1039L,400L,4298L,25901L,25901L,4298L,42520L,592969L,1409910L,592969L,42520L,406580L,13233079L,74289956L,74289956L,13233079L,406580L,3828928L,292930403L,3885183814L,9204003223L,3885183814L,292930403L,3828928L,35804264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210267Inst : IEnumerable<long>
{
public static readonly long[] Value=A210267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210267.Bytes);
public long this[int i]=>Value[i];

public static A210267Inst Instance=new A210267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210268
{
public static readonly BigInteger[] Value={ 35L,5558L,6028871L,44678808183L,2261599192647037L,BigInteger.Parse("781910030615896210474"),BigInteger.Parse("1846356382998737252290206762"),BigInteger.Parse("29777644269614247388351983235258241"),BigInteger.Parse("3280051134759806457403130482690269897360711") };
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
public class A210268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210268Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210268.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210268.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210268Inst Instance=new A210268Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210269
{
public static readonly long[] Value={ 35L,273L,2130L,16620L,129684L,1011912L,7895856L,61610640L,480742176L,3751187136L,29270169408L,228392449152L,1782125347584L,13905760747776L,108505376592384L,846657508568064L,6606390939571200L,51549062997460992L,402232613876871168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210269Inst : IEnumerable<long>
{
public static readonly long[] Value=A210269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210269.Bytes);
public long this[int i]=>Value[i];

public static A210269Inst Instance=new A210269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210270
{
public static readonly BigInteger[] Value={ 273L,5558L,113248L,2307956L,47036870L,958632858L,19537398722L,398181683100L,8115136633050L,165390438528106L,3370737726383882L,68697277333917074L,1400083986498649180L,BigInteger.Parse("28534393870466854178"),BigInteger.Parse("581544851172163483038") };
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
public class A210270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210270Inst Instance=new A210270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210271
{
public static readonly BigInteger[] Value={ 2130L,113248L,6028871L,321050788L,17097482699L,910532241954L,48490791961375L,2582399328204990L,137526868179029404L,7324056952893265933L,BigInteger.Parse("390046040465491252479"),BigInteger.Parse("20772082296310330599391"),BigInteger.Parse("1106226850689067938595724") };
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
public class A210271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210271Inst Instance=new A210271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210272
{
public static readonly BigInteger[] Value={ 16620L,2307956L,321050788L,44678808183L,6218088462292L,865403655856588L,120443009719061218L,16762728653468925176UL,BigInteger.Parse("2332963101699637083278"),BigInteger.Parse("324691585708247938940794"),BigInteger.Parse("45189152848885338414135408") };
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
public class A210272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210272.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210272Inst Instance=new A210272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210273
{
public static readonly BigInteger[] Value={ 129684L,47036870L,17097482699L,6218088462292L,2261599192647037L,822588621201609131L,BigInteger.Parse("299192733780770135628"),BigInteger.Parse("108822749899700419187880"),BigInteger.Parse("39581149154521036273501515"),BigInteger.Parse("14396506354147981090231615659") };
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
public class A210273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210273Inst Instance=new A210273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210274
{
public static readonly BigInteger[] Value={ 1011912L,958632858L,910532241954L,865403655856588L,822588621201609131L,BigInteger.Parse("781910030615896210474"),BigInteger.Parse("743245692531829336470460"),BigInteger.Parse("706493865582146467787545885"),BigInteger.Parse("671559422936656100572786437396") };
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
public class A210274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210274.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210274Inst Instance=new A210274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210275
{
public static readonly BigInteger[] Value={ 7895856L,19537398722L,48490791961375L,120443009719061218L,BigInteger.Parse("299192733780770135628"),BigInteger.Parse("743245692531829336470460"),BigInteger.Parse("1846356382998737252290206762"),BigInteger.Parse("4586687051164609867229232781805") };
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
public class A210275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210275.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210275Inst Instance=new A210275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210276
{
public static readonly long[] Value={ 35L,273L,273L,2130L,5558L,2130L,16620L,113248L,113248L,16620L,129684L,2307956L,6028871L,2307956L,129684L,1011912L,47036870L,321050788L,321050788L,47036870L,1011912L,7895856L,958632858L,17097482699L,44678808183L,17097482699L,958632858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210276Inst : IEnumerable<long>
{
public static readonly long[] Value=A210276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210276.Bytes);
public long this[int i]=>Value[i];

public static A210276Inst Instance=new A210276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210277
{
public static readonly BigInteger[] Value={ 1L,2L,80L,13440L,5913600L,5381376000L,8782405632000L,23361198981120000L,BigInteger.Parse("94566133475573760000"),BigInteger.Parse("553211880832106496000000"),BigInteger.Parse("4492080472356704747520000000"),BigInteger.Parse("49017582114356362204938240000000"),BigInteger.Parse("699971072593008852286518067200000000") };
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
public class A210277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210277.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210277Inst Instance=new A210277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210278
{
public static readonly BigInteger[] Value={ 1L,24L,145152L,10461394944L,3892643213082624L,BigInteger.Parse("4963587213865915514880"),BigInteger.Parse("16976183027980227752723742720"),BigInteger.Parse("132264293969742655099733137120296960"),BigInteger.Parse("2088743125114618199924764850166056689336320"),BigInteger.Parse("61246577083125859615725138685776750112964471685120") };
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
public class A210278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210278Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210278.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210278.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210278Inst Instance=new A210278Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210279
{
public static readonly BigInteger[] Value={ 1L,120L,13305600L,29640619008000L,BigInteger.Parse("478741050720092160000"),BigInteger.Parse("34111736086958726676480000000"),BigInteger.Parse("7973107998754741458076119859200000000"),BigInteger.Parse("5019026197962676820927435579005599744000000000") };
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
public class A210279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210279Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210279.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210279.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210279Inst Instance=new A210279Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210280
{
public static readonly BigInteger[] Value={ 1L,720L,1779148800L,148953184174080000L,BigInteger.Parse("126983900296423931904000000"),BigInteger.Parse("614812159599342234168301977600000000"),BigInteger.Parse("11942354952042770431904585727413846016000000000") };
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
public class A210280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210280Inst Instance=new A210280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210281
{
public static readonly BigInteger[] Value={ 1L,5040L,326918592000L,BigInteger.Parse("1211813284635233280000"),BigInteger.Parse("64240926985765022013480960000000"),BigInteger.Parse("24899758399899222849902687670779904000000000"),BigInteger.Parse("47355329866546908076714664639943599847875543040000000000") };
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
public class A210281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210281Inst Instance=new A210281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210282
{
public static readonly long[] Value={ 1L,3L,12L,21L,43L,45L,102L,75L,161L,156L,234L,163L,433L,221L,424L,460L,608L,359L,876L,447L,1049L,830L,942L,637L,1784L,932L,1304L,1306L,1905L,997L,2648L,1137L,2428L,1920L,2164L,2042L,3980L,1595L,2694L,2618L,4378L,1961L,4900L,2163L,4423L,4283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210282Inst : IEnumerable<long>
{
public static readonly long[] Value=A210282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210282.Bytes);
public long this[int i]=>Value[i];

public static A210282Inst Instance=new A210282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210283
{
public static readonly long[] Value={ 0L,10L,7L,20L,29L,59L,53L,126L,91L,185L,172L,274L,179L,481L,245L,456L,492L,672L,383L,948L,479L,1097L,870L,1030L,669L,1864L,980L,1376L,1354L,2017L,1029L,2768L,1201L,2508L,1984L,2260L,2090L,4124L,1667L,2790L,2682L,4538L,2009L,5068L,2243L,4519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210283Inst : IEnumerable<long>
{
public static readonly long[] Value=A210283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210283.Bytes);
public long this[int i]=>Value[i];

public static A210283Inst Instance=new A210283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210284
{
public static readonly long[] Value={ 0L,0L,1L,11L,9L,42L,23L,81L,72L,126L,79L,273L,121L,268L,280L,416L,227L,624L,299L,761L,570L,690L,457L,1384L,672L,1004L,982L,1489L,769L,2108L,893L,1980L,1500L,1768L,1574L,3308L,1303L,2250L,2118L,3658L,1637L,4120L,1823L,3751L,3527L,3320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210284Inst : IEnumerable<long>
{
public static readonly long[] Value=A210284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210284.Bytes);
public long this[int i]=>Value[i];

public static A210284Inst Instance=new A210284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210285
{
public static readonly long[] Value={ 1L,10L,7L,15L,36L,52L,65L,89L,155L,179L,153L,193L,374L,422L,287L,319L,617L,681L,584L,656L,914L,962L,639L,727L,1705L,1785L,889L,961L,1672L,1784L,1768L,1888L,2496L,2576L,1483L,1579L,3460L,3604L,1843L,1939L,4177L,4337L,3298L,3466L,3886L,3982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210285Inst : IEnumerable<long>
{
public static readonly long[] Value=A210285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210285.Bytes);
public long this[int i]=>Value[i];

public static A210285Inst Instance=new A210285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210286
{
public static readonly long[] Value={ 1L,3L,10L,18L,28L,42L,56L,74L,96L,118L,140L,170L,200L,234L,272L,302L,336L,386L,432L,482L,536L,578L,624L,690L,752L,810L,876L,938L,1000L,1082L,1156L,1234L,1328L,1402L,1476L,1558L,1632L,1730L,1840L,1926L,2008L,2122L,2228L,2338L,2464L,2554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210286Inst : IEnumerable<long>
{
public static readonly long[] Value=A210286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210286.Bytes);
public long this[int i]=>Value[i];

public static A210286Inst Instance=new A210286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210287
{
public static readonly long[] Value={ 1L,3L,1L,6L,6L,1L,11L,18L,10L,1L,19L,45L,41L,15L,1L,32L,100L,130L,80L,21L,1L,53L,208L,352L,310L,141L,28L,1L,87L,413L,866L,994L,652L,231L,36L,1L,142L,794L,1991L,2828L,2429L,1253L,358L,45L,1L,231L,1490L,4358L,7391L,7871L,5348L,2248L,531L,55L,1L,375L,2745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210287Inst : IEnumerable<long>
{
public static readonly long[] Value=A210287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210287.Bytes);
public long this[int i]=>Value[i];

public static A210287Inst Instance=new A210287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210288
{
public static readonly long[] Value={ 1L,6L,19L,29L,41L,51L,65L,75L,89L,101L,115L,125L,143L,153L,167L,181L,197L,207L,225L,235L,253L,267L,281L,291L,313L,325L,339L,353L,371L,381L,403L,413L,431L,445L,459L,473L,497L,507L,521L,535L,557L,567L,589L,599L,617L,635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210288Inst : IEnumerable<long>
{
public static readonly long[] Value=A210288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210288.Bytes);
public long this[int i]=>Value[i];

public static A210288Inst Instance=new A210288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210289
{
public static readonly long[] Value={ 1L,5L,9L,15L,25L,29L,35L,53L,63L,81L,85L,89L,107L,141L,159L,165L,193L,197L,215L,261L,271L,323L,327L,331L,349L,389L,423L,461L,529L,533L,539L,617L,645L,651L,655L,673L,727L,817L,863L,959L,969L,973L,1025L,1131L,1141L,1159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210289Inst : IEnumerable<long>
{
public static readonly long[] Value=A210289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210289.Bytes);
public long this[int i]=>Value[i];

public static A210289Inst Instance=new A210289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210290
{
public static readonly long[] Value={ 1L,13L,56L,160L,369L,733L,1328L,2216L,3505L,5285L,7680L,10792L,14809L,19813L,26024L,33600L,42721L,53549L,66384L,81336L,98761L,118821L,141784L,167888L,197561L,230917L,268352L,310176L,356753L,408285L,465376L,528088L,597049L,672533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210290Inst : IEnumerable<long>
{
public static readonly long[] Value=A210290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210290.Bytes);
public long this[int i]=>Value[i];

public static A210290Inst Instance=new A210290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210291
{
public static readonly long[] Value={ 0L,0L,6L,40L,125L,323L,647L,1235L,2074L,3337L,5057L,7477L,10436L,14490L,19436L,25591L,33015L,42259L,52849L,65833L,80528L,97909L,117905L,141163L,166651L,196474L,229796L,267289L,308712L,355766L,406488L,464094L,526402L,595477L,670963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210291Inst : IEnumerable<long>
{
public static readonly long[] Value=A210291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210291.Bytes);
public long this[int i]=>Value[i];

public static A210291Inst Instance=new A210291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210292
{
public static readonly BigInteger[] Value={ 112L,78628L,688122928L,75244563204398L,BigInteger.Parse("102755730987812117952"),BigInteger.Parse("1752648993312488853687634462"),BigInteger.Parse("373366766716480043025684339650029800"),BigInteger.Parse("993411552731407131616878668696108769698390398") };
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
public class A210292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210292.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210292Inst Instance=new A210292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210293
{
public static readonly long[] Value={ 112L,1578L,22212L,312704L,4402192L,61973516L,872455004L,12282307884L,172908727756L,2434186513236L,34268160178956L,482422688537636L,6791483674595260L,95609621185469444L,1345979774260696316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210293Inst : IEnumerable<long>
{
public static readonly long[] Value=A210293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210293.Bytes);
public long this[int i]=>Value[i];

public static A210293Inst Instance=new A210293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210294
{
public static readonly BigInteger[] Value={ 1578L,78628L,3913002L,194768054L,9694276684L,482519042626L,24016699289368L,1195397128587610L,59499195398348818L,2961488004421137772L,BigInteger.Parse("147403862192382974048"),BigInteger.Parse("7336818031079109775274"),BigInteger.Parse("365179704387717596682932") };
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
public class A210294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210294.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210294Inst Instance=new A210294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210295
{
public static readonly BigInteger[] Value={ 22212L,3913002L,688122928L,121040117840L,21290108702694L,3744799069935140L,658686645074030420L,BigInteger.Parse("115858857345804835112"),BigInteger.Parse("20378847387666462558384"),BigInteger.Parse("3584511632177122331815826"),BigInteger.Parse("630493147720709548341110160") };
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
public class A210295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210295Inst Instance=new A210295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210296
{
public static readonly BigInteger[] Value={ 312704L,194768054L,121040117840L,75244563204398L,46773822117508382L,BigInteger.Parse("29075895528477825602"),BigInteger.Parse("18074362569780907584746"),BigInteger.Parse("11235513600375237582792174"),BigInteger.Parse("6984299629532890008981374274"),BigInteger.Parse("4341629868067826124129752698278") };
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
public class A210296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210296.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210296Inst Instance=new A210296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210297
{
public static readonly BigInteger[] Value={ 4402192L,9694276684L,21290108702694L,46773822117508382L,BigInteger.Parse("102755730987812117952"),BigInteger.Parse("225741948376039857049980"),BigInteger.Parse("495927352523356139887864420"),BigInteger.Parse("1089491673865425887607249889930") };
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
public class A210297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210297Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210297.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210297.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210297Inst Instance=new A210297Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210298
{
public static readonly BigInteger[] Value={ 61973516L,482519042626L,3744799069935140L,BigInteger.Parse("29075895528477825602"),BigInteger.Parse("225741948376039857049980"),BigInteger.Parse("1752648993312488853687634462"),BigInteger.Parse("13607462253433812638431489199962"),BigInteger.Parse("105647542211301539024933439827978282") };
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
public class A210298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210298Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210298.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210298.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210298Inst Instance=new A210298Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210299
{
public static readonly BigInteger[] Value={ 872455004L,24016699289368L,658686645074030420L,BigInteger.Parse("18074362569780907584746"),BigInteger.Parse("495927352523356139887864420"),BigInteger.Parse("13607462253433812638431489199962"),BigInteger.Parse("373366766716480043025684339650029800") };
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
public class A210299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210299.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210299Inst Instance=new A210299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210300
{
public static readonly long[] Value={ 112L,1578L,1578L,22212L,78628L,22212L,312704L,3913002L,3913002L,312704L,4402192L,194768054L,688122928L,194768054L,4402192L,61973516L,9694276684L,121040117840L,121040117840L,9694276684L,61973516L,872455004L,482519042626L,21290108702694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210300Inst : IEnumerable<long>
{
public static readonly long[] Value=A210300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210300.Bytes);
public long this[int i]=>Value[i];

public static A210300Inst Instance=new A210300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210301
{
public static readonly BigInteger[] Value={ 0L,1091L,1575467L,11061291451L,437971830335043L,BigInteger.Parse("98959142504758664603"),BigInteger.Parse("127648944948853198818703027"),BigInteger.Parse("940014634185937826679488616180507") };
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
public class A210301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210301.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210301Inst Instance=new A210301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210302
{
public static readonly long[] Value={ 0L,29L,414L,4553L,45890L,446093L,4266246L,40490097L,382887722L,3614390197L,34090440494L,321405533785L,3029622853138L,28555016231773L,269126357016278L,2536415298825665L,23904507782220922L,225287438517410949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210302Inst : IEnumerable<long>
{
public static readonly long[] Value=A210302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210302.Bytes);
public long this[int i]=>Value[i];

public static A210302Inst Instance=new A210302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210303
{
public static readonly BigInteger[] Value={ 29L,1091L,27957L,655743L,14976529L,339125187L,7657326365L,172736626311L,3895426271881L,87837486236459L,1980567115521301L,44657472344530991L,1006924739685862081L,BigInteger.Parse("22703839965026573971"),BigInteger.Parse("511919216667906316429") };
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
public class A210303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210303.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210303Inst Instance=new A210303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210304
{
public static readonly BigInteger[] Value={ 414L,27957L,1575467L,85724987L,4628067519L,249417760123L,13436313660615L,723757498910275L,38984944780383519L,2099900397267926699L,BigInteger.Parse("113109737477748574263"),BigInteger.Parse("6092579222040877989907"),BigInteger.Parse("328172625066633894785487") };
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
public class A210304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210304.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210304Inst Instance=new A210304Inst();

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