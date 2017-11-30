using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A249382
{
public static readonly long[] Value={ 3L,3L,7L,3L,3L,31L,7L,61L,13L,7L,43L,31L,19L,3L,31L,307L,733L,79L,43L,73L,421L,73L,181L,19L,157L,181L,3L,739L,421L,127L,103L,73L,571L,421L,109L,211L,1459L,103L,1693L,487L,829L,139L,1153L,439L,3067L,601L,199L,853L,421L,3541L,1069L,1279L,1297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249382Inst : IEnumerable<long>
{
public static readonly long[] Value=A249382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249382.Bytes);
public long this[int i]=>Value[i];

public static A249382Inst Instance=new A249382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249383
{
public static readonly long[] Value={ 3L,3L,7L,3L,31L,7L,61L,43L,79L,19L,739L,103L,2707L,4513L,139L,13L,4027L,28027L,14029L,87151L,11257L,8677L,122449L,104161L,113287L,216211L,150097L,862009L,876721L,414949L,4590451L,1391281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249383Inst : IEnumerable<long>
{
public static readonly long[] Value=A249383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249383.Bytes);
public long this[int i]=>Value[i];

public static A249383Inst Instance=new A249383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249384
{
public static readonly long[] Value={ 3L,5L,3L,5L,5L,53L,11L,239L,53L,191L,1229L,5L,233L,347L,1367L,9767L,2063L,89L,14009L,3329L,19991L,50849L,2711L,337871L,46301L,2543L,413093L,1157111L,615161L,1138649L,3778427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249384Inst : IEnumerable<long>
{
public static readonly long[] Value=A249384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249384.Bytes);
public long this[int i]=>Value[i];

public static A249384Inst Instance=new A249384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249385
{
public static readonly long[] Value={ 1L,0L,1L,5L,9L,8L,3L,5L,3L,3L,6L,9L,2L,5L,7L,3L,4L,0L,7L,9L,6L,0L,8L,3L,9L,6L,4L,1L,0L,0L,2L,6L,4L,5L,7L,2L,9L,1L,0L,4L,2L,5L,3L,9L,2L,2L,7L,5L,3L,7L,4L,0L,0L,1L,3L,9L,6L,1L,7L,2L,4L,4L,6L,1L,0L,3L,2L,0L,0L,5L,1L,2L,3L,8L,9L,5L,9L,4L,7L,7L,6L,0L,3L,8L,1L,3L,6L,7L,5L,6L,5L,3L,6L,2L,0L,2L,1L,2L,4L,9L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249385Inst : IEnumerable<long>
{
public static readonly long[] Value=A249385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249385.Bytes);
public long this[int i]=>Value[i];

public static A249385Inst Instance=new A249385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249386
{
public static readonly long[] Value={ 2L,3L,1L,5L,1L,6L,8L,1L,3L,4L,4L,8L,8L,9L,8L,3L,7L,0L,5L,6L,0L,3L,5L,6L,4L,0L,6L,4L,0L,6L,3L,3L,2L,1L,1L,0L,8L,5L,5L,1L,2L,9L,2L,1L,2L,5L,9L,3L,2L,8L,7L,9L,2L,6L,5L,9L,7L,9L,4L,4L,5L,2L,4L,1L,7L,6L,7L,3L,9L,6L,6L,5L,4L,3L,9L,4L,4L,2L,0L,2L,2L,7L,4L,5L,1L,2L,7L,5L,3L,1L,9L,7L,2L,3L,2L,5L,3L,0L,3L,0L,2L,3L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249386Inst : IEnumerable<long>
{
public static readonly long[] Value=A249386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249386.Bytes);
public long this[int i]=>Value[i];

public static A249386Inst Instance=new A249386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249387
{
public static readonly long[] Value={ 2L,0L,0L,9L,4L,4L,5L,6L,6L,0L,8L,7L,7L,0L,1L,3L,7L,5L,3L,0L,6L,4L,9L,0L,8L,7L,6L,5L,8L,1L,6L,4L,3L,4L,3L,1L,5L,8L,8L,5L,9L,0L,4L,6L,8L,9L,7L,9L,5L,1L,1L,9L,4L,6L,8L,2L,3L,6L,7L,8L,0L,9L,7L,2L,1L,5L,8L,6L,3L,7L,8L,4L,5L,2L,0L,4L,3L,8L,0L,4L,8L,6L,7L,1L,4L,0L,5L,7L,4L,4L,0L,6L,6L,3L,3L,2L,3L,9L,4L,0L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249387Inst : IEnumerable<long>
{
public static readonly long[] Value=A249387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249387.Bytes);
public long this[int i]=>Value[i];

public static A249387Inst Instance=new A249387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249388
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,2L,2L,94L,1L,1L,1L,2L,6L,2L,17L,2L,2L,1187L,6L,2L,1L,62L,2L,56883L,14L,3L,14471L,2L,14L,3018L,34L,6L,3L,29L,67L,19L,1L,38L,528846L,9758L,14L,18278015L,163506530L,767014L,7L,2L,2611563L,2081053770L,3L,2L,2L,53654L,94L,17175330570L,2L,1612685866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249388Inst : IEnumerable<long>
{
public static readonly long[] Value=A249388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249388.Bytes);
public long this[int i]=>Value[i];

public static A249388Inst Instance=new A249388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249389
{
public static readonly long[] Value={ 1L,1L,3L,3L,8L,4L,1L,5L,5L,6L,2L,0L,5L,4L,9L,6L,4L,6L,6L,7L,3L,3L,7L,6L,8L,6L,3L,2L,4L,6L,0L,5L,0L,1L,9L,3L,1L,2L,0L,6L,0L,2L,9L,6L,2L,8L,8L,0L,8L,6L,5L,4L,0L,1L,0L,4L,1L,7L,3L,8L,0L,6L,7L,2L,7L,8L,0L,8L,4L,7L,5L,5L,1L,2L,5L,9L,1L,7L,9L,4L,5L,8L,5L,8L,3L,6L,2L,1L,1L,9L,0L,6L,3L,3L,9L,5L,9L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249389Inst : IEnumerable<long>
{
public static readonly long[] Value=A249389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249389.Bytes);
public long this[int i]=>Value[i];

public static A249389Inst Instance=new A249389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249390
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,8L,68L,480L,3637L,27968L,231410L,2014784L,18789010L,185234176L,1943243785L,21501237248L,251589065328L,3093350098432L,40007001803593L,541652523341824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249390Inst : IEnumerable<long>
{
public static readonly long[] Value=A249390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249390.Bytes);
public long this[int i]=>Value[i];

public static A249390Inst Instance=new A249390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249391
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,1L,16L,272L,2880L,32648L,333696L,3617545L,38942336L,443291226L,5168682752L,63523977424L,807890646528L,10790865576074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249391Inst : IEnumerable<long>
{
public static readonly long[] Value=A249391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249391.Bytes);
public long this[int i]=>Value[i];

public static A249391Inst Instance=new A249391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249392
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,32L,1088L,17280L,293832L,4004352L,57687080L,773838336L,10900027949L,151388845568L,2200665880514L,32321771402240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249392Inst : IEnumerable<long>
{
public static readonly long[] Value=A249392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249392.Bytes);
public long this[int i]=>Value[i];

public static A249392Inst Instance=new A249392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249393
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,64L,4352L,103680L,2644488L,48052224L,922764744L,15466088448L,271484691944L,4512300607488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249393Inst : IEnumerable<long>
{
public static readonly long[] Value=A249393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249393.Bytes);
public long this[int i]=>Value[i];

public static A249393Inst Instance=new A249393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249394
{
public static readonly long[] Value={ 4L,5L,13L,53L,8645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249394Inst : IEnumerable<long>
{
public static readonly long[] Value=A249394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249394.Bytes);
public long this[int i]=>Value[i];

public static A249394Inst Instance=new A249394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249395
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,21L,97L,491L,2989L,19756L,148444L,1205731L,10767889L,103379533L,1069512329L,11819221164L,138980503372L,1734555299547L,22842846011691L,317403042567207L,4626310914540965L,70776622667767954L,1130784058442869122L,BigInteger.Parse("18877678724072172281") };
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
public class A249395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249395Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249395.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249395.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249395Inst Instance=new A249395Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249396
{
public static readonly long[] Value={ 9L,75L,135L,265L,1383L,6585L,17251L,165615L,503111L,856195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249396Inst : IEnumerable<long>
{
public static readonly long[] Value=A249396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249396.Bytes);
public long this[int i]=>Value[i];

public static A249396Inst Instance=new A249396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249397
{
public static readonly long[] Value={ 161L,171L,895L,1337L,1843L,1967L,2575L,5833L,8255L,36121L,54439L,87353L,195921L,274115L,284419L,340363L,368449L,387087L,444639L,504539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249397Inst : IEnumerable<long>
{
public static readonly long[] Value=A249397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249397.Bytes);
public long this[int i]=>Value[i];

public static A249397Inst Instance=new A249397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249398
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,20L,25L,50L,100L,125L,200L,250L,400L,500L,625L,1000L,1250L,2000L,2500L,3125L,5000L,6250L,10000L,12500L,15625L,20000L,25000L,31250L,40000L,50000L,62500L,78125L,100000L,125000L,156250L,200000L,250000L,312500L,390625L,500000L,625000L,781250L,1000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249398Inst : IEnumerable<long>
{
public static readonly long[] Value=A249398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249398.Bytes);
public long this[int i]=>Value[i];

public static A249398Inst Instance=new A249398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249399
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,20L,8L,16L,25L,50L,40L,32L,64L,80L,100L,125L,200L,160L,128L,250L,400L,320L,256L,500L,625L,1000L,800L,640L,512L,1024L,1250L,2000L,1280L,1600L,2500L,3125L,5000L,3200L,2048L,2560L,4000L,6250L,10000L,6400L,4096L,5120L,8000L,10240L,8192L,12500L,15625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249399Inst : IEnumerable<long>
{
public static readonly long[] Value=A249399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249399.Bytes);
public long this[int i]=>Value[i];

public static A249399Inst Instance=new A249399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249400
{
public static readonly long[] Value={ 2L,4L,5L,7L,8L,10L,11L,13L,14L,16L,19L,20L,26L,28L,29L,32L,41L,56L,61L,77L,100L,169L,181L,205L,338L,347L,955L,1952L,2197L,2428L,2960L,3430L,4618L,7478L,8209L,8422L,9235L,11107L,13481L,18194L,19229L,29854L,46532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249400Inst : IEnumerable<long>
{
public static readonly long[] Value=A249400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249400.Bytes);
public long this[int i]=>Value[i];

public static A249400Inst Instance=new A249400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249401
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,11L,43L,1L,67L,103L,405L,157L,1603L,2627L,10819L,1L,11427L,18395L,73273L,27099L,245929L,385333L,1516069L,8955L,3288479L,5588411L,24411113L,9596521L,104620147L,171729011L,708599923L,1L,496472227L,846762835L,3610797801L,1364604931L,13485280597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249401Inst : IEnumerable<long>
{
public static readonly long[] Value=A249401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249401.Bytes);
public long this[int i]=>Value[i];

public static A249401Inst Instance=new A249401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249402
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,11L,40L,99L,589L,3194L,11259L,92159L,666160L,3052323L,31799041L,287316122L,1620265923L,20497038755L,222237912664L,1488257158851L,22149498351205L,280180369563194L,2172534146099019L,37183508549366519L,537546603651987424L,4736552519729393091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249402Inst : IEnumerable<long>
{
public static readonly long[] Value=A249402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249402.Bytes);
public long this[int i]=>Value[i];

public static A249402Inst Instance=new A249402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249403
{
public static readonly long[] Value={ 1L,5L,8L,0L,0L,3L,7L,2L,1L,0L,6L,3L,2L,0L,5L,2L,3L,5L,2L,0L,8L,4L,0L,6L,3L,4L,9L,8L,1L,8L,3L,2L,6L,4L,4L,9L,2L,1L,1L,2L,8L,1L,5L,8L,0L,5L,9L,1L,6L,5L,9L,6L,1L,9L,7L,0L,1L,7L,4L,2L,3L,6L,9L,2L,0L,6L,0L,1L,5L,3L,7L,3L,7L,1L,0L,5L,3L,7L,7L,1L,1L,3L,5L,9L,2L,3L,5L,6L,4L,8L,0L,9L,0L,2L,1L,7L,0L,1L,4L,4L,8L,7L,0L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249403Inst : IEnumerable<long>
{
public static readonly long[] Value=A249403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249403.Bytes);
public long this[int i]=>Value[i];

public static A249403Inst Instance=new A249403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249404
{
public static readonly long[] Value={ 52L,52L,52L,52L,53L,52L,52L,52L,52L,53L,52L,52L,52L,52L,52L,53L,52L,52L,52L,52L,53L,52L,52L,52L,52L,52L,53L,52L,52L,52L,52L,52L,53L,52L,52L,52L,52L,53L,52L,52L,52L,52L,52L,53L,52L,52L,52L,52L,53L,52L,52L,52L,52L,52L,53L,52L,52L,52L,52L,52L,53L,52L,52L,52L,52L,53L,52L,52L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249404Inst : IEnumerable<long>
{
public static readonly long[] Value=A249404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249404.Bytes);
public long this[int i]=>Value[i];

public static A249404Inst Instance=new A249404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249405
{
public static readonly long[] Value={ 411203L,411205L,3202114L,4111203L,4111205L,4112023L,4112025L,5202114L,30211234L,30232114L,30234114L,30252114L,30256114L,32021114L,32032114L,32034114L,32052114L,32056114L,32074114L,32076114L,32112034L,32112074L,32302114L,32502114L,41111203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249405Inst : IEnumerable<long>
{
public static readonly long[] Value=A249405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249405.Bytes);
public long this[int i]=>Value[i];

public static A249405Inst Instance=new A249405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249406
{
public static readonly long[] Value={ 1L,6L,20L,56L,90L,132L,182L,240L,306L,399L,506L,600L,702L,812L,930L,1056L,1190L,1332L,1482L,1640L,1806L,1980L,2162L,2352L,2550L,2756L,2970L,3306L,3540L,3782L,4032L,4290L,4556L,4830L,5112L,5402L,5700L,6006L,6320L,6642L,6972L,7310L,7656L,8099L,8556L,8930L,9312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249406Inst : IEnumerable<long>
{
public static readonly long[] Value=A249406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249406.Bytes);
public long this[int i]=>Value[i];

public static A249406Inst Instance=new A249406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249407
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249407Inst : IEnumerable<long>
{
public static readonly long[] Value=A249407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249407.Bytes);
public long this[int i]=>Value[i];

public static A249407Inst Instance=new A249407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249408
{
public static readonly long[] Value={ 1L,399L,8099L,33123L,93635L,159200L,256035L,492803L,864899L,1416099L,2196323L,3261635L,4674243L,6502499L,8820899L,12531599L,16257023L,20757135L,26132543L,32489999L,39942399L,48608783L,58614335L,65593800L,73205135L,86713343L,102009999L,119246399L,138579983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249408Inst : IEnumerable<long>
{
public static readonly long[] Value=A249408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249408.Bytes);
public long this[int i]=>Value[i];

public static A249408Inst Instance=new A249408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249409
{
public static readonly BigInteger[] Value={ 1L,0L,2L,3L,100L,965L,26166L,652687L,22791336L,942744105L,46394042410L,2686920755651L,179344249073628L,13675378594960381L,1179389058183817950L,BigInteger.Parse("114010570608973463895"),BigInteger.Parse("12267159489256485080656"),BigInteger.Parse("1459502985288809274179153"),BigInteger.Parse("190910980556047614953376594"),BigInteger.Parse("27316077853047666256173322603") };
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
public class A249409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249409Inst Instance=new A249409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249410
{
public static readonly long[] Value={ 2L,3L,5L,17L,19L,37L,73L,101L,163L,197L,257L,401L,577L,677L,883L,1153L,1297L,1459L,1601L,1801L,2179L,2593L,2917L,3137L,3529L,4051L,4357L,5477L,7057L,8101L,8713L,8837L,10369L,11251L,12101L,13457L,14401L,15139L,15377L,15877L,16901L,17299L,17957L,18433L,19603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249410Inst : IEnumerable<long>
{
public static readonly long[] Value=A249410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249410.Bytes);
public long this[int i]=>Value[i];

public static A249410Inst Instance=new A249410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249411
{
public static readonly long[] Value={ 2L,12L,30L,42L,72L,110L,156L,210L,272L,342L,380L,420L,462L,552L,650L,756L,870L,992L,1122L,1260L,1406L,1560L,1722L,1892L,2070L,2256L,2450L,2652L,2862L,3080L,3192L,3422L,3660L,3906L,4160L,4422L,4692L,4970L,5256L,5550L,5852L,6162L,6480L,6806L,7140L,7482L,7832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249411Inst : IEnumerable<long>
{
public static readonly long[] Value=A249411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249411.Bytes);
public long this[int i]=>Value[i];

public static A249411Inst Instance=new A249411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249412
{
public static readonly long[] Value={ 3L,5L,7L,9L,13L,25L,29L,61L,81L,121L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249412Inst : IEnumerable<long>
{
public static readonly long[] Value=A249412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249412.Bytes);
public long this[int i]=>Value[i];

public static A249412Inst Instance=new A249412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249413
{
public static readonly BigInteger[] Value={ 11L,41L,72426721L,143664401L,565262081L,4160105226881L,253399862985121L,997027328131841L,BigInteger.Parse("212479323351825962211841"),BigInteger.Parse("188939838859312612896128881921"),BigInteger.Parse("22828424707602602744356458636161"),BigInteger.Parse("661045104283639247572028952777478721") };
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
public class A249413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249413Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249413.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249413.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249413Inst Instance=new A249413Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249414
{
public static readonly long[] Value={ 0L,3L,9L,4L,9L,2L,9L,2L,2L,7L,7L,1L,6L,6L,3L,5L,8L,9L,5L,1L,6L,4L,0L,3L,7L,4L,6L,9L,9L,0L,8L,1L,4L,6L,1L,1L,2L,0L,1L,0L,6L,6L,0L,4L,5L,8L,2L,4L,3L,0L,7L,0L,6L,6L,6L,9L,5L,0L,2L,7L,8L,7L,4L,2L,6L,6L,4L,5L,3L,8L,1L,5L,4L,5L,7L,7L,0L,9L,1L,7L,3L,4L,5L,7L,9L,7L,3L,4L,7L,5L,4L,8L,6L,5L,9L,1L,0L,7L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249414Inst : IEnumerable<long>
{
public static readonly long[] Value=A249414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249414.Bytes);
public long this[int i]=>Value[i];

public static A249414Inst Instance=new A249414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249415
{
public static readonly long[] Value={ 1L,8L,4L,7L,4L,1L,6L,3L,3L,6L,0L,7L,6L,3L,4L,2L,1L,2L,9L,3L,9L,7L,6L,9L,3L,6L,8L,9L,7L,3L,4L,5L,9L,1L,2L,1L,1L,9L,1L,5L,3L,4L,7L,8L,3L,2L,5L,0L,3L,7L,0L,2L,6L,9L,7L,5L,2L,1L,8L,4L,0L,2L,9L,8L,4L,1L,1L,8L,2L,1L,7L,9L,4L,6L,3L,8L,1L,4L,2L,4L,8L,5L,2L,1L,1L,8L,9L,0L,1L,9L,2L,1L,0L,6L,4L,1L,9L,4L,9L,4L,4L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249415Inst : IEnumerable<long>
{
public static readonly long[] Value=A249415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249415.Bytes);
public long this[int i]=>Value[i];

public static A249415Inst Instance=new A249415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249416
{
public static readonly long[] Value={ 1L,2L,1L,2L,10L,2L,1L,2L,118L,19L,519L,2L,635L,370L,829L,1333L,8454L,17315L,3599L,15307L,423769L,852006L,495431L,2L,2425755L,2121070L,3192295L,1614598L,35685686L,10081687L,735961L,12902173L,216093318L,151123623L,5270424935L,39937013L,22884337L,7281379334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249416Inst : IEnumerable<long>
{
public static readonly long[] Value=A249416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249416.Bytes);
public long this[int i]=>Value[i];

public static A249416Inst Instance=new A249416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249417
{
public static readonly long[] Value={ 2L,0L,9L,3L,4L,0L,6L,6L,4L,9L,6L,7L,8L,3L,2L,1L,8L,0L,6L,9L,2L,0L,1L,6L,1L,8L,1L,1L,2L,5L,0L,0L,8L,1L,8L,2L,8L,6L,0L,0L,5L,4L,6L,9L,0L,5L,2L,0L,7L,9L,5L,8L,5L,2L,0L,5L,3L,0L,2L,3L,7L,8L,0L,6L,6L,8L,9L,4L,7L,2L,6L,9L,5L,7L,8L,0L,3L,9L,2L,8L,1L,0L,3L,7L,5L,5L,7L,5L,9L,5L,8L,6L,6L,0L,4L,3L,1L,2L,2L,0L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249417Inst : IEnumerable<long>
{
public static readonly long[] Value=A249417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249417.Bytes);
public long this[int i]=>Value[i];

public static A249417Inst Instance=new A249417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249418
{
public static readonly long[] Value={ 9L,0L,1L,9L,0L,8L,0L,1L,2L,6L,5L,2L,8L,0L,6L,5L,0L,0L,6L,3L,9L,4L,3L,1L,2L,0L,8L,4L,4L,3L,7L,7L,6L,7L,4L,2L,8L,4L,3L,4L,1L,9L,2L,6L,0L,6L,1L,9L,5L,7L,8L,9L,5L,3L,9L,6L,3L,1L,9L,6L,5L,0L,2L,5L,3L,0L,0L,6L,9L,3L,5L,3L,5L,4L,6L,4L,0L,8L,0L,8L,6L,6L,5L,7L,5L,1L,5L,8L,5L,3L,5L,4L,7L,8L,8L,9L,8L,3L,1L,1L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249418Inst : IEnumerable<long>
{
public static readonly long[] Value=A249418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249418.Bytes);
public long this[int i]=>Value[i];

public static A249418Inst Instance=new A249418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249419
{
public static readonly long[] Value={ 2L,7L,13L,19L,31L,37L,83L,131L,67L,317L,277L,109L,367L,127L,139L,157L,293L,181L,199L,211L,509L,709L,911L,443L,677L,503L,307L,2459L,761L,337L,379L,653L,409L,971L,743L,3169L,1097L,487L,499L,863L,1609L,541L,571L,577L,983L,1789L,631L,1559L,6581L,1601L,1163L,1193L,3613L,751L,769L,787L,2957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249419Inst : IEnumerable<long>
{
public static readonly long[] Value=A249419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249419.Bytes);
public long this[int i]=>Value[i];

public static A249419Inst Instance=new A249419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249420
{
public static readonly long[] Value={ 2L,3L,3L,3L,3L,3L,5L,7L,3L,11L,9L,3L,9L,3L,3L,3L,5L,3L,3L,3L,7L,9L,11L,5L,7L,5L,3L,23L,7L,3L,3L,5L,3L,7L,5L,21L,7L,3L,3L,5L,9L,3L,3L,3L,5L,9L,3L,7L,29L,7L,5L,5L,15L,3L,3L,3L,11L,3L,3L,11L,7L,3L,3L,5L,3L,5L,3L,3L,3L,7L,11L,9L,9L,3L,15L,5L,9L,7L,3L,7L,9L,13L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249420Inst : IEnumerable<long>
{
public static readonly long[] Value=A249420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249420.Bytes);
public long this[int i]=>Value[i];

public static A249420Inst Instance=new A249420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249421
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,5L,2L,0L,0L,0L,2L,1L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,4L,4L,0L,0L,0L,0L,0L,17L,2L,3L,0L,0L,0L,0L,0L,0L,10L,0L,2L,0L,0L,0L,0L,0L,0L,0L,12L,14L,1L,6L,0L,0L,0L,0L,0L,0L,0L,4L,10L,0L,5L,0L,0L,0L,0L,0L,0L,0L,0L,18L,6L,8L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,8L,13L,6L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,8L,4L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249421Inst : IEnumerable<long>
{
public static readonly long[] Value=A249421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249421.Bytes);
public long this[int i]=>Value[i];

public static A249421Inst Instance=new A249421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249422
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,5L,0L,0L,0L,0L,1L,2L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,4L,4L,0L,0L,0L,0L,0L,0L,0L,3L,2L,17L,0L,0L,0L,0L,0L,0L,0L,2L,0L,10L,0L,0L,0L,0L,0L,0L,0L,6L,1L,14L,12L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,10L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,8L,6L,18L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,6L,13L,8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,4L,8L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249422Inst : IEnumerable<long>
{
public static readonly long[] Value=A249422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249422.Bytes);
public long this[int i]=>Value[i];

public static A249422Inst Instance=new A249422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249423
{
public static readonly long[] Value={ 0L,35L,39L,62L,79L,83L,89L,104L,107L,131L,143L,149L,153L,159L,164L,167L,175L,179L,181L,194L,197L,199L,207L,209L,219L,259L,263L,269L,272L,274L,279L,285L,287L,296L,299L,305L,307L,311L,314L,319L,329L,339L,356L,359L,363L,373L,377L,379L,384L,389L,391L,395L,399L,407L,415L,417L,419L,424L,428L,431L,441L,449L,455L,461L,467L,475L,489L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249423Inst : IEnumerable<long>
{
public static readonly long[] Value=A249423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249423.Bytes);
public long this[int i]=>Value[i];

public static A249423Inst Instance=new A249423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249424
{
public static readonly long[] Value={ 3L,5L,9L,13L,21L,23L,25L,33L,37L,45L,57L,61L,73L,81L,85L,93L,105L,117L,121L,133L,141L,145L,157L,165L,177L,193L,201L,205L,213L,217L,225L,253L,261L,273L,277L,297L,301L,313L,325L,333L,345L,357L,361L,381L,385L,393L,397L,421L,445L,453L,457L,465L,477L,481L,501L,513L,525L,537L,541L,553L,561L,565L,585L,613L,621L,625L,633L,661L,673L,693L,697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249424Inst : IEnumerable<long>
{
public static readonly long[] Value=A249424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249424.Bytes);
public long this[int i]=>Value[i];

public static A249424Inst Instance=new A249424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249425
{
public static readonly long[] Value={ 0L,2L,4L,6L,10L,12L,16L,18L,22L,28L,30L,35L,39L,42L,46L,52L,58L,60L,62L,66L,70L,72L,78L,79L,82L,83L,88L,89L,96L,100L,102L,104L,106L,107L,112L,125L,126L,130L,131L,136L,138L,143L,148L,149L,153L,156L,159L,162L,164L,166L,167L,172L,174L,179L,181L,190L,192L,194L,196L,197L,199L,207L,209L,219L,222L,226L,228L,232L,238L,240L,250L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249425Inst : IEnumerable<long>
{
public static readonly long[] Value=A249425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249425.Bytes);
public long this[int i]=>Value[i];

public static A249425Inst Instance=new A249425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249426
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,11L,15L,17L,21L,27L,29L,35L,39L,41L,45L,51L,57L,59L,62L,65L,69L,71L,77L,79L,81L,83L,87L,89L,95L,99L,101L,104L,105L,107L,111L,118L,125L,129L,131L,135L,137L,143L,147L,149L,153L,155L,159L,161L,164L,165L,167L,171L,177L,179L,181L,189L,191L,194L,195L,197L,199L,207L,209L,219L,221L,225L,227L,231L,237L,239L,249L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249426Inst : IEnumerable<long>
{
public static readonly long[] Value=A249426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249426.Bytes);
public long this[int i]=>Value[i];

public static A249426Inst Instance=new A249426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249427
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,12L,16L,18L,22L,28L,30L,36L,40L,42L,46L,52L,58L,60L,63L,66L,70L,72L,78L,80L,82L,84L,88L,90L,96L,100L,102L,105L,106L,108L,112L,119L,126L,130L,132L,136L,138L,144L,148L,150L,154L,156L,160L,162L,165L,166L,168L,172L,178L,180L,182L,190L,192L,195L,196L,198L,200L,208L,210L,220L,222L,226L,228L,232L,238L,240L,250L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249427Inst : IEnumerable<long>
{
public static readonly long[] Value=A249427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249427.Bytes);
public long this[int i]=>Value[i];

public static A249427Inst Instance=new A249427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249428
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,11L,12L,16L,18L,22L,28L,30L,36L,40L,42L,46L,52L,58L,60L,66L,70L,72L,78L,82L,88L,96L,100L,102L,106L,108L,112L,126L,130L,136L,138L,148L,150L,156L,162L,166L,172L,178L,180L,190L,192L,196L,198L,210L,222L,226L,228L,232L,238L,240L,250L,256L,262L,268L,270L,276L,280L,282L,292L,306L,310L,312L,316L,330L,336L,346L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249428Inst : IEnumerable<long>
{
public static readonly long[] Value=A249428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249428.Bytes);
public long this[int i]=>Value[i];

public static A249428Inst Instance=new A249428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249429
{
public static readonly long[] Value={ 0L,35L,39L,62L,79L,83L,89L,104L,107L,131L,143L,149L,153L,159L,164L,167L,174L,175L,179L,181L,194L,197L,199L,207L,209L,219L,259L,263L,269L,272L,274L,279L,285L,287L,296L,299L,305L,307L,311L,314L,319L,323L,329L,339L,350L,356L,359L,363L,373L,377L,379L,384L,389L,391L,395L,398L,399L,407L,415L,417L,419L,424L,428L,431L,439L,440L,441L,449L,454L,455L,461L,467L,475L,489L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249429Inst : IEnumerable<long>
{
public static readonly long[] Value=A249429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249429.Bytes);
public long this[int i]=>Value[i];

public static A249429Inst Instance=new A249429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249430
{
public static readonly long[] Value={ 1L,0L,350L,439L,174L,713L,323L,1923L,1052L,999L,1766L,3749L,2254L,2253L,1934L,3391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249430Inst : IEnumerable<long>
{
public static readonly long[] Value=A249430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249430.Bytes);
public long this[int i]=>Value[i];

public static A249430Inst Instance=new A249430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249431
{
public static readonly long[] Value={ 1L,0L,0L,-2L,0L,-3L,0L,-6L,-6L,-5L,0L,-4L,0L,-7L,-10L,-14L,0L,-15L,0L,-15L,-14L,-11L,0L,-12L,-20L,-13L,-24L,-21L,0L,-4L,0L,-30L,-22L,-17L,-28L,1L,0L,-19L,-26L,1L,0L,-35L,0L,-33L,-21L,-23L,0L,-28L,-42L,-45L,-34L,-39L,0L,-51L,-44L,-20L,-38L,-29L,0L,-12L,0L,-31L,1L,-62L,-52L,-55L,0L,-51L,-46L,-20L,0L,-30L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249431Inst : IEnumerable<long>
{
public static readonly long[] Value=A249431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249431.Bytes);
public long this[int i]=>Value[i];

public static A249431Inst Instance=new A249431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249432
{
public static readonly long[] Value={ 0L,174L,323L,999L,1766L,1934L,2974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249432Inst : IEnumerable<long>
{
public static readonly long[] Value=A249432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249432.Bytes);
public long this[int i]=>Value[i];

public static A249432Inst Instance=new A249432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249433
{
public static readonly long[] Value={ 3L,5L,7L,8L,9L,11L,13L,14L,15L,17L,19L,20L,21L,23L,24L,25L,26L,27L,29L,31L,32L,33L,34L,37L,38L,41L,43L,44L,45L,47L,48L,49L,50L,51L,53L,54L,55L,56L,57L,59L,61L,63L,64L,65L,67L,68L,69L,71L,73L,74L,75L,76L,77L,80L,81L,84L,85L,86L,87L,90L,91L,92L,93L,94L,95L,97L,98L,99L,101L,103L,105L,109L,110L,111L,113L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,127L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249433Inst : IEnumerable<long>
{
public static readonly long[] Value=A249433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249433.Bytes);
public long this[int i]=>Value[i];

public static A249433Inst Instance=new A249433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249434
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,10L,12L,16L,18L,22L,28L,30L,35L,36L,39L,40L,42L,46L,52L,58L,60L,62L,66L,70L,72L,78L,79L,82L,83L,88L,89L,96L,100L,102L,104L,106L,107L,108L,112L,126L,130L,131L,136L,138L,143L,148L,149L,150L,153L,156L,159L,162L,164L,166L,167L,172L,174L,175L,178L,179L,180L,181L,190L,192L,194L,196L,197L,198L,199L,207L,209L,210L,219L,222L,226L,228L,232L,238L,240L,250L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249434Inst : IEnumerable<long>
{
public static readonly long[] Value=A249434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249434.Bytes);
public long this[int i]=>Value[i];

public static A249434Inst Instance=new A249434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249435
{
public static readonly long[] Value={ 0L,3L,7L,8L,15L,24L,26L,31L,48L,63L,80L,120L,124L,127L,168L,242L,255L,288L,342L,360L,511L,528L,624L,728L,840L,960L,1023L,1330L,1368L,1680L,1848L,2047L,2186L,2196L,2208L,2400L,2808L,3124L,3480L,3720L,4095L,4488L,4912L,5040L,5328L,6240L,6560L,6858L,6888L,7920L,8191L,9408L,10200L,10608L,11448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249435Inst : IEnumerable<long>
{
public static readonly long[] Value=A249435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249435.Bytes);
public long this[int i]=>Value[i];

public static A249435Inst Instance=new A249435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249436
{
public static readonly long[] Value={ 11L,29L,44L,55L,59L,69L,71L,111L,119L,125L,139L,188L,215L,223L,230L,233L,239L,251L,324L,335L,349L,351L,447L,458L,474L,479L,493L,494L,503L,509L,560L,593L,599L,647L,662L,701L,714L,719L,831L,835L,849L,895L,956L,959L,979L,991L,1000L,1007L,1019L,1034L,1063L,1077L,1169L,1224L,1319L,1322L,1364L,1376L,1424L,1427L,1448L,1507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249436Inst : IEnumerable<long>
{
public static readonly long[] Value=A249436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249436.Bytes);
public long this[int i]=>Value[i];

public static A249436Inst Instance=new A249436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249437
{
public static readonly long[] Value={ 7L,25L,23L,35L,47L,49L,41L,67L,89L,119L,97L,139L,113L,131L,120L,188L,181L,233L,168L,265L,209L,241L,259L,329L,309L,357L,337L,449L,463L,501L,288L,461L,409L,329L,493L,548L,571L,656L,649L,681L,577L,515L,791L,709L,601L,837L,805L,919L,995L,528L,721L,901L,961L,1009L,1121L,895L,1273L,977L,1063L,1121L,1376L,1273L,1057L,840L,1189L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249437Inst : IEnumerable<long>
{
public static readonly long[] Value=A249437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249437.Bytes);
public long this[int i]=>Value[i];

public static A249437Inst Instance=new A249437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249438
{
public static readonly long[] Value={ 7L,23L,25L,35L,41L,47L,49L,67L,89L,97L,113L,119L,120L,131L,139L,168L,181L,188L,209L,233L,241L,259L,265L,288L,309L,329L,337L,357L,409L,449L,461L,463L,493L,501L,515L,528L,548L,571L,577L,601L,649L,656L,681L,709L,721L,791L,805L,837L,840L,895L,901L,919L,961L,977L,995L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249438Inst : IEnumerable<long>
{
public static readonly long[] Value=A249438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249438.Bytes);
public long this[int i]=>Value[i];

public static A249438Inst Instance=new A249438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249439
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,8L,21L,24L,32L,36L,40L,45L,48L,64L,91L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249439Inst : IEnumerable<long>
{
public static readonly long[] Value=A249439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249439.Bytes);
public long this[int i]=>Value[i];

public static A249439Inst Instance=new A249439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249440
{
public static readonly long[] Value={ 0L,4L,6L,13L,15L,43L,47L,239L,7199L,16559L,21599L,33119L,45359L,60479L,90719L,1179359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249440Inst : IEnumerable<long>
{
public static readonly long[] Value=A249440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249440.Bytes);
public long this[int i]=>Value[i];

public static A249440Inst Instance=new A249440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249441
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,2L,0L,2L,2L,2L,0L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249441Inst : IEnumerable<long>
{
public static readonly long[] Value=A249441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249441.Bytes);
public long this[int i]=>Value[i];

public static A249441Inst Instance=new A249441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249442
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,3L,0L,1L,1L,2L,0L,1L,5L,3L,7L,1L,2L,1L,2L,1L,4L,3L,0L,1L,1L,2L,1L,1L,3L,3L,5L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,8L,1L,1L,2L,21L,1L,1L,1L,2L,1L,4L,1L,2L,1L,2L,3L,6L,1L,6L,3L,1L,1L,2L,3L,4L,1L,6L,3L,8L,1L,2L,3L,1L,1L,3L,3L,8L,1L,1L,2L,3L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249442Inst : IEnumerable<long>
{
public static readonly long[] Value=A249442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249442.Bytes);
public long this[int i]=>Value[i];

public static A249442Inst Instance=new A249442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249443
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,22L,23L,24L,25L,26L,27L,28L,29L,33L,34L,35L,36L,37L,38L,39L,44L,45L,46L,47L,48L,49L,55L,56L,57L,58L,59L,66L,67L,68L,69L,77L,78L,79L,88L,89L,99L,123L,124L,125L,126L,127L,128L,129L,133L,134L,135L,136L,137L,138L,139L,144L,145L,146L,147L,148L,149L,155L,156L,157L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249443Inst : IEnumerable<long>
{
public static readonly long[] Value=A249443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249443.Bytes);
public long this[int i]=>Value[i];

public static A249443Inst Instance=new A249443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249444
{
public static readonly long[] Value={ 13L,137L,251L,353L,2213L,4933L,24421L,78137L,148933L,205441L,371311L,493121L,524309L,571873L,912773L,1225153L,1594339L,4330913L,7189253L,13652161L,18191713L,21254213L,28629187L,31855333L,42508901L,49431233L,73560481L,81183173L,99253313L,178454113L,184220581L,192100613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249444Inst : IEnumerable<long>
{
public static readonly long[] Value=A249444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249444.Bytes);
public long this[int i]=>Value[i];

public static A249444Inst Instance=new A249444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249445
{
public static readonly long[] Value={ 5L,8L,4L,2L,0L,2L,7L,8L,0L,2L,4L,1L,9L,0L,4L,1L,3L,7L,3L,5L,3L,3L,0L,3L,5L,2L,3L,2L,5L,4L,2L,0L,3L,2L,7L,0L,8L,6L,8L,9L,8L,3L,5L,1L,6L,3L,2L,3L,3L,6L,0L,9L,8L,7L,9L,3L,4L,8L,9L,6L,6L,7L,6L,4L,4L,1L,8L,5L,9L,3L,9L,6L,9L,1L,4L,2L,8L,7L,7L,4L,9L,2L,9L,2L,7L,3L,7L,1L,6L,5L,4L,2L,5L,6L,5L,5L,6L,9L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249445Inst : IEnumerable<long>
{
public static readonly long[] Value=A249445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249445.Bytes);
public long this[int i]=>Value[i];

public static A249445Inst Instance=new A249445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249446
{
public static readonly long[] Value={ 2L,4L,10L,11L,34L,41L,46L,49L,56L,59L,76L,85L,95L,125L,160L,181L,185L,196L,200L,206L,220L,245L,266L,280L,295L,301L,304L,346L,365L,379L,386L,391L,440L,470L,505L,556L,571L,595L,659L,679L,689L,731L,784L,815L,820L,854L,869L,896L,944L,959L,994L,1001L,1004L,1015L,1025L,1154L,1250L,1345L,1376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249446Inst : IEnumerable<long>
{
public static readonly long[] Value=A249446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249446.Bytes);
public long this[int i]=>Value[i];

public static A249446Inst Instance=new A249446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249447
{
public static readonly BigInteger[] Value={ 2L,11L,101L,1013L,10037L,100019L,1000033L,10000019L,100000037L,1000000033L,10000000019L,100000000019L,1000000000039L,10000000000037L,100000000000031L,1000000000000037L,10000000000000079L,100000000000000013L,1000000000000000031L,10000000000000000051UL,BigInteger.Parse("100000000000000000039") };
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
public class A249447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249447Inst Instance=new A249447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249448
{
public static readonly BigInteger[] Value={ 7L,89L,991L,9967L,99991L,999983L,9999971L,99999989L,999999937L,9999999943L,99999999821L,999999999989L,9999999999971L,99999999999923L,999999999999883L,9999999999999851L,99999999999999997L,999999999999999967L,9999999999999999919UL,BigInteger.Parse("99999999999999999989"),BigInteger.Parse("999999999999999999829") };
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
public class A249448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249448.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249448Inst Instance=new A249448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249449
{
public static readonly long[] Value={ 8L,5L,1L,0L,8L,3L,7L,0L,3L,2L,7L,9L,3L,5L,9L,6L,5L,3L,1L,1L,1L,2L,2L,7L,9L,0L,6L,7L,2L,8L,3L,8L,2L,2L,4L,7L,6L,9L,6L,4L,8L,6L,2L,2L,7L,9L,6L,4L,7L,4L,1L,7L,9L,7L,7L,1L,9L,5L,9L,7L,0L,3L,2L,9L,8L,0L,1L,5L,5L,6L,0L,1L,9L,8L,3L,0L,0L,2L,2L,5L,8L,1L,0L,0L,6L,2L,1L,1L,5L,2L,3L,6L,3L,9L,2L,2L,1L,3L,7L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249449Inst : IEnumerable<long>
{
public static readonly long[] Value=A249449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249449.Bytes);
public long this[int i]=>Value[i];

public static A249449Inst Instance=new A249449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249450
{
public static readonly long[] Value={ -2L,-1L,1L,6L,19L,53L,142L,375L,985L,2582L,6763L,17709L,46366L,121391L,317809L,832038L,2178307L,5702885L,14930350L,39088167L,102334153L,267914294L,701408731L,1836311901L,4807526974L,12586269023L,32951280097L,86267571270L,225851433715L,591286729877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249450Inst : IEnumerable<long>
{
public static readonly long[] Value=A249450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249450.Bytes);
public long this[int i]=>Value[i];

public static A249450Inst Instance=new A249450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249451
{
public static readonly long[] Value={ 3L,8L,8L,2L,3L,8L,2L,9L,4L,7L,0L,6L,7L,8L,5L,5L,2L,9L,3L,5L,3L,9L,6L,4L,1L,5L,4L,4L,4L,6L,7L,4L,7L,7L,5L,4L,2L,0L,9L,5L,0L,4L,0L,3L,5L,5L,0L,5L,1L,8L,5L,9L,9L,0L,8L,3L,2L,4L,1L,2L,1L,2L,3L,9L,6L,1L,3L,9L,0L,6L,7L,8L,5L,7L,3L,9L,5L,3L,7L,2L,3L,1L,0L,3L,4L,9L,4L,5L,9L,6L,7L,5L,0L,3L,5L,1L,9L,6L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249451Inst : IEnumerable<long>
{
public static readonly long[] Value=A249451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249451.Bytes);
public long this[int i]=>Value[i];

public static A249451Inst Instance=new A249451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249452
{
public static readonly long[] Value={ 15L,31L,47L,63L,95L,127L,191L,255L,383L,511L,767L,1023L,1535L,2047L,3071L,4095L,6143L,8191L,12287L,16383L,24575L,32767L,49151L,65535L,98303L,131071L,196607L,262143L,393215L,524287L,786431L,1048575L,1572863L,2097151L,3145727L,4194303L,6291455L,8388607L,12582911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249452Inst : IEnumerable<long>
{
public static readonly long[] Value=A249452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249452.Bytes);
public long this[int i]=>Value[i];

public static A249452Inst Instance=new A249452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249453
{
public static readonly long[] Value={ 4L,3L,4L,9L,22L,51L,112L,237L,490L,999L,2020L,4065L,8158L,16347L,32728L,65493L,131026L,262095L,524236L,1048521L,2097094L,4194243L,8388544L,16777149L,33554362L,67108791L,134217652L,268435377L,536870830L,1073741739L,2147483560L,4294967205L,8589934498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249453Inst : IEnumerable<long>
{
public static readonly long[] Value=A249453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249453.Bytes);
public long this[int i]=>Value[i];

public static A249453Inst Instance=new A249453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249454
{
public static readonly BigInteger[] Value={ 1L,1L,5L,25L,121L,641L,4861L,44185L,272945L,480961L,19687861L,754778201L,1734823465L,-259904463935L,180602875181L,188945735209561L,21689448762721L,-167679491870531455L,2951642934531685L,BigInteger.Parse("193773398162963638681"),448885053392410841L };
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
public class A249454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249454Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249454.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249454.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249454Inst Instance=new A249454Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249455
{
public static readonly long[] Value={ 1L,2L,1L,3L,0L,6L,1L,3L,1L,9L,4L,2L,5L,2L,6L,6L,8L,4L,7L,2L,0L,7L,5L,9L,9L,0L,6L,9L,9L,8L,2L,3L,6L,0L,9L,0L,6L,8L,8L,3L,8L,3L,6L,2L,7L,0L,9L,7L,4L,3L,7L,3L,9L,1L,1L,3L,6L,5L,7L,8L,4L,3L,1L,7L,4L,7L,0L,1L,1L,3L,0L,3L,8L,8L,2L,7L,4L,9L,6L,8L,4L,7L,9L,9L,7L,2L,9L,5L,2L,2L,3L,0L,1L,5L,9L,7L,8L,9L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249455Inst : IEnumerable<long>
{
public static readonly long[] Value=A249455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249455.Bytes);
public long this[int i]=>Value[i];

public static A249455Inst Instance=new A249455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249456
{
public static readonly long[] Value={ 2L,1L,3L,9L,6L,9L,0L,9L,4L,7L,4L,1L,2L,8L,5L,9L,8L,6L,0L,5L,0L,5L,3L,0L,2L,2L,6L,3L,8L,5L,2L,3L,5L,2L,4L,4L,4L,3L,2L,3L,1L,4L,6L,9L,5L,6L,0L,5L,5L,1L,2L,9L,3L,8L,5L,8L,2L,4L,9L,8L,0L,0L,0L,7L,6L,0L,1L,1L,1L,5L,5L,2L,1L,8L,3L,2L,5L,1L,3L,3L,3L,2L,3L,8L,9L,6L,9L,7L,2L,7L,1L,2L,4L,4L,0L,0L,5L,2L,3L,8L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249456Inst : IEnumerable<long>
{
public static readonly long[] Value=A249456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249456.Bytes);
public long this[int i]=>Value[i];

public static A249456Inst Instance=new A249456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249457
{
public static readonly BigInteger[] Value={ 10L,100L,2890L,96100L,3237610L,109202500L,3683712490L,124263300100L,4191798484810L,141402777864100L,4769968258260490L,160906295771812900L,5427884341892493610L,BigInteger.Parse("183099910962324064900"),BigInteger.Parse("6176546013641762558890"),BigInteger.Parse("208354665265158340802500") };
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
public class A249457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249457Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249457.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249457.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249457Inst Instance=new A249457Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249458
{
public static readonly BigInteger[] Value={ 10L,100L,1690L,36100L,835210L,19802500L,472931290L,11318832100L,271066588810L,6492762648100L,155527144782490L,3725543446072900L,89243180863948810L,2137770243127864900L,BigInteger.Parse("51209104645650371290"),BigInteger.Parse("1226685938180259902500") };
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
public class A249458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249458Inst Instance=new A249458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249459
{
public static readonly BigInteger[] Value={ 1L,17L,794L,72354L,10874275L,2438235715L,762963987380L,317685943157892L,169842891165484965L,BigInteger.Parse("113394131858832552133"),BigInteger.Parse("92465351109879998121806"),BigInteger.Parse("90431265068257318469676710"),BigInteger.Parse("104479466717230437574945525959"),BigInteger.Parse("140782828210237288756752539959687") };
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
public class A249459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249459.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249459Inst Instance=new A249459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249460
{
public static readonly long[] Value={ 0L,0L,0L,1L,10L,55L,230L,770L,2156L,5250L,11460L,22935L,42790L,75361L,126490L,203840L,317240L,479060L,704616L,1012605L,1425570L,1970395L,2678830L,3588046L,4741220L,6188150L,7985900L,10199475L,12902526L,16178085L,20119330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249460Inst : IEnumerable<long>
{
public static readonly long[] Value=A249460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249460.Bytes);
public long this[int i]=>Value[i];

public static A249460Inst Instance=new A249460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249461
{
public static readonly long[] Value={ 860L,2948L,10124L,34832L,119932L,412972L,1422232L,4898776L,16874830L,58131580L,200257200L,689871586L,2376578686L,8187255382L,28204984386L,97165888404L,334735779168L,1153163060226L,3972642458048L,13685741942400L,47147347303294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249461Inst : IEnumerable<long>
{
public static readonly long[] Value=A249461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249461.Bytes);
public long this[int i]=>Value[i];

public static A249461Inst Instance=new A249461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249462
{
public static readonly long[] Value={ 2640L,11260L,48180L,206428L,884728L,3791504L,16249428L,69646680L,298527530L,1279613894L,5484967770L,23510991158L,100778855292L,431985293958L,1851693204500L,7937234390598L,34022755120144L,145837709303458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249462Inst : IEnumerable<long>
{
public static readonly long[] Value=A249462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249462.Bytes);
public long this[int i]=>Value[i];

public static A249462Inst Instance=new A249462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249463
{
public static readonly long[] Value={ 6730L,35322L,185982L,980718L,5174842L,27309702L,144140836L,760833398L,4016197550L,21200828116L,111916666626L,590797789556L,3118776430716L,16463816131498L,86911505863698L,458800889433320L,2421984333500072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249463Inst : IEnumerable<long>
{
public static readonly long[] Value=A249463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249463.Bytes);
public long this[int i]=>Value[i];

public static A249463Inst Instance=new A249463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249464
{
public static readonly long[] Value={ 14730L,91160L,565516L,3512232L,21824440L,135637752L,843025344L,5239822940L,32568952752L,202440565098L,1258327314766L,7821507915080L,48616960819938L,302193724046726L,1878379190428402L,11675652828179748L,72573673473580502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249464Inst : IEnumerable<long>
{
public static readonly long[] Value=A249464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249464.Bytes);
public long this[int i]=>Value[i];

public static A249464Inst Instance=new A249464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249465
{
public static readonly long[] Value={ 29060L,207760L,1488294L,10671554L,76550058L,549183692L,3940066010L,28268238072L,202814997034L,1455140474848L,10440249554448L,74906102995968L,537432238422096L,3855940687831096L,27665406008609022L,198492352203114492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249465Inst : IEnumerable<long>
{
public static readonly long[] Value=A249465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249465.Bytes);
public long this[int i]=>Value[i];

public static A249465Inst Instance=new A249465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249466
{
public static readonly long[] Value={ 30L,190L,58L,860L,464L,112L,2640L,2948L,1140L,216L,6730L,11260L,10124L,2802L,416L,14730L,35322L,48180L,34832L,6872L,802L,29060L,91160L,185982L,206428L,119932L,16800L,1546L,52900L,207760L,565516L,980718L,884728L,412972L,41084L,2980L,90390L,429364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249466Inst : IEnumerable<long>
{
public static readonly long[] Value=A249466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249466.Bytes);
public long this[int i]=>Value[i];

public static A249466Inst Instance=new A249466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249467
{
public static readonly long[] Value={ 30L,190L,860L,2640L,6730L,14730L,29060L,52900L,90390L,146610L,228000L,342120L,498030L,706270L,979100L,1330440L,1776250L,2334330L,3024740L,3869740L,4893990L,6124530L,7591200L,9326400L,11365470L,13746670L,16511420L,19704240L,23373130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249467Inst : IEnumerable<long>
{
public static readonly long[] Value=A249467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249467.Bytes);
public long this[int i]=>Value[i];

public static A249467Inst Instance=new A249467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249468
{
public static readonly long[] Value={ 58L,464L,2948L,11260L,35322L,91160L,207760L,429364L,821614L,1475648L,2518348L,4114408L,6479030L,9883248L,14668588L,21247164L,30124654L,41900528L,57290148L,77134712L,102409834L,134241312L,173931480L,222958784L,283011294L,355982968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249468Inst : IEnumerable<long>
{
public static readonly long[] Value=A249468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249468.Bytes);
public long this[int i]=>Value[i];

public static A249468Inst Instance=new A249468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249469
{
public static readonly long[] Value={ 112L,1140L,10124L,48180L,185982L,565516L,1488294L,3491108L,7479834L,14872588L,27848932L,49534034L,84370308L,138424022L,219934350L,339564798L,511246534L,752562638L,1085714794L,1538310894L,2144026442L,2943704164L,3986818718L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249469Inst : IEnumerable<long>
{
public static readonly long[] Value=A249469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249469.Bytes);
public long this[int i]=>Value[i];

public static A249469Inst Instance=new A249469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249470
{
public static readonly long[] Value={ 216L,2802L,34832L,206428L,980718L,3512232L,10671554L,28408106L,68141702L,149985134L,308128976L,596635030L,1099154100L,1939520516L,3298783802L,5428583306L,8678985766L,13520275360L,20580791722L,30686017266L,44896600642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249470Inst : IEnumerable<long>
{
public static readonly long[] Value=A249470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249470.Bytes);
public long this[int i]=>Value[i];

public static A249470Inst Instance=new A249470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249471
{
public static readonly long[] Value={ 416L,6872L,119932L,884728L,5174842L,21824440L,76550058L,231236220L,620927172L,1512868480L,3409871172L,7187658694L,14321688284L,27179247012L,49484565130L,86796151488L,147351090962L,242923972126L,390163791394L,612170875944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249471Inst : IEnumerable<long>
{
public static readonly long[] Value=A249471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249471.Bytes);
public long this[int i]=>Value[i];

public static A249471Inst Instance=new A249471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249472
{
public static readonly long[] Value={ 802L,16800L,412972L,3791504L,27309702L,135637752L,549183692L,1882322198L,5658152588L,15260105412L,37735175366L,86590121782L,186608489008L,380873907090L,742312367226L,1387762688078L,2501716768582L,4364708959260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249472Inst : IEnumerable<long>
{
public static readonly long[] Value=A249472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249472.Bytes);
public long this[int i]=>Value[i];

public static A249472Inst Instance=new A249472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249473
{
public static readonly long[] Value={ 1546L,41084L,1422232L,16249428L,144140836L,843025344L,3940066010L,15322870410L,51559998434L,153928094968L,417597134828L,1043160494934L,2431475134350L,5337351650512L,11135359755600L,22188626020430L,42474008430092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249473Inst : IEnumerable<long>
{
public static readonly long[] Value=A249473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249473.Bytes);
public long this[int i]=>Value[i];

public static A249473Inst Instance=new A249473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249474
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,30L,169L,1128L,8700L,76494L,753139L,8182188L,97131376L,1256860330L,17470791933L,261284377168L,4164406202270L,70677340199670L,1268718107324255L,24091289738163140L,480954355282406340L,10097484764045220626UL,BigInteger.Parse("221918808641500960217"),BigInteger.Parse("5103937368681669463800") };
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
public class A249474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249474Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249474.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249474.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249474Inst Instance=new A249474Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249475
{
public static readonly BigInteger[] Value={ 1L,1L,5L,25L,156L,1048L,8400L,72384L,710184L,7519240L,87797880L,1098513880L,14945280640L,216079283040L,3352657547680L,55071779464352L,961293645943680L,17669716422651776L,342988501737128576L,6978772157389361280L,BigInteger.Parse("149123855108936024576"),BigInteger.Parse("3328674238745847019520") };
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
public class A249475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249475Inst Instance=new A249475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249476
{
public static readonly BigInteger[] Value={ 1L,1L,6L,35L,242L,1773L,15056L,136652L,1393722L,15257919L,183206388L,2347929936L,32602306542L,479885400177L,7563888117504L,125952344438838L,2225653414414386L,41351620513521627L,810520833521436732L,16633643598838880244UL,BigInteger.Parse("358221783030360367014"),BigInteger.Parse("8051927483267030640573") };
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
public class A249476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249476.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249476Inst Instance=new A249476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249477
{
public static readonly BigInteger[] Value={ 1L,1L,7L,47L,360L,2884L,26068L,250140L,2659544L,30188024L,373401768L,4911407656L,69701336160L,1046114985408L,16770977757888L,283455401409920L,5076208319560320L,95434083840830080L,1890657361059194240L,BigInteger.Parse("39170792604756397440"),BigInteger.Parse("850920224456551054336"),BigInteger.Parse("19275340855527901297152") };
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
public class A249477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249477.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249477Inst Instance=new A249477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249478
{
public static readonly BigInteger[] Value={ 1L,1L,1L,5L,12L,88L,496L,4032L,32072L,335144L,3443928L,41477176L,523289472L,7298441952L,107525078304L,1714360202528L,28771306555776L,515446334184832L,9722819034952832L,193501572577378944L,4042243606465206784L,BigInteger.Parse("88584621284011603968"),BigInteger.Parse("2029364250844776170496"),BigInteger.Parse("48539531534286294782976") };
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
public class A249478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249478.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249478Inst Instance=new A249478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249479
{
public static readonly BigInteger[] Value={ 1L,1L,3L,10L,47L,246L,1622L,11656L,97869L,899338L,9225674L,102689808L,1252353159L,16392179766L,231501723312L,3489107989204L,56102882993753L,956324067974034L,17265334914237406L,328565326494695912L,6582472704969812115L,BigInteger.Parse("138369486361447809150"),BigInteger.Parse("3047029944703252620540"),BigInteger.Parse("70122393369209990745660") };
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
public class A249479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249479.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249479Inst Instance=new A249479Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249480
{
public static readonly long[] Value={ 1L,1L,0L,3L,1L,0L,11L,5L,1L,0L,56L,32L,7L,1L,0L,324L,204L,57L,9L,1L,0L,2324L,1604L,487L,89L,11L,1L,0L,18332L,13292L,4441L,897L,128L,13L,1L,0L,167544L,127224L,44712L,9864L,1486L,174L,15L,1L,0L,1674264L,1311384L,485592L,111744L,18486L,2286L,227L,17L,1L,0L,18615432L,14986632L,5735616L,1393872L,240318L,31734L,3329L,287L,19L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249480Inst : IEnumerable<long>
{
public static readonly long[] Value=A249480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249480.Bytes);
public long this[int i]=>Value[i];

public static A249480Inst Instance=new A249480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249481
{
public static readonly long[] Value={ 8L,152L,224L,279L,423L,440L,584L,711L,855L,872L,1016L,1143L,1287L,1304L,1448L,1575L,1719L,1736L,1824L,1880L,2007L,2151L,2168L,2312L,2439L,2583L,2600L,2744L,2871L,2975L,3015L,3032L,3176L,3303L,3424L,3447L,3464L,3608L,3735L,3879L,3896L,3968L,4040L,4167L,4311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249481Inst : IEnumerable<long>
{
public static readonly long[] Value=A249481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249481.Bytes);
public long this[int i]=>Value[i];

public static A249481Inst Instance=new A249481Inst();

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