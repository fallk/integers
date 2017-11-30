using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A201905
{
public static readonly long[] Value={ 3L,4L,2L,5L,6L,6L,7L,4L,1L,0L,2L,0L,2L,8L,7L,7L,3L,7L,3L,2L,6L,5L,6L,2L,6L,0L,6L,4L,7L,2L,5L,8L,1L,6L,6L,9L,7L,8L,2L,7L,3L,5L,7L,2L,6L,1L,7L,3L,3L,2L,3L,3L,5L,5L,5L,3L,6L,6L,6L,3L,4L,3L,8L,0L,6L,5L,1L,2L,9L,4L,4L,3L,4L,9L,4L,2L,4L,4L,2L,7L,5L,0L,1L,2L,8L,7L,3L,9L,9L,6L,5L,9L,7L,0L,2L,5L,7L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201905Inst : IEnumerable<long>
{
public static readonly long[] Value=A201905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201905.Bytes);
public long this[int i]=>Value[i];

public static A201905Inst Instance=new A201905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201906
{
public static readonly long[] Value={ 3L,5L,6L,8L,7L,4L,9L,1L,9L,1L,3L,8L,6L,3L,6L,4L,8L,5L,6L,5L,0L,6L,6L,7L,0L,5L,8L,7L,5L,9L,9L,1L,2L,4L,4L,0L,9L,5L,9L,9L,2L,0L,0L,5L,2L,6L,2L,0L,8L,0L,4L,2L,0L,9L,9L,6L,8L,1L,8L,4L,5L,7L,7L,9L,2L,0L,7L,4L,7L,0L,6L,1L,9L,1L,8L,6L,6L,5L,3L,2L,2L,5L,4L,6L,7L,4L,0L,0L,6L,5L,0L,2L,7L,5L,6L,9L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201906Inst : IEnumerable<long>
{
public static readonly long[] Value=A201906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201906.Bytes);
public long this[int i]=>Value[i];

public static A201906Inst Instance=new A201906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201907
{
public static readonly long[] Value={ 3L,2L,3L,4L,9L,2L,3L,2L,1L,7L,7L,7L,6L,0L,6L,6L,3L,6L,7L,0L,3L,2L,7L,9L,6L,1L,3L,2L,7L,3L,0L,4L,4L,3L,0L,4L,4L,8L,4L,7L,8L,6L,8L,0L,4L,6L,8L,7L,0L,4L,0L,9L,6L,1L,1L,3L,1L,4L,6L,8L,8L,5L,5L,3L,1L,4L,3L,8L,6L,6L,5L,2L,1L,0L,2L,5L,9L,3L,6L,4L,2L,2L,0L,9L,5L,3L,8L,2L,5L,6L,0L,8L,1L,5L,7L,5L,9L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201907Inst : IEnumerable<long>
{
public static readonly long[] Value=A201907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201907.Bytes);
public long this[int i]=>Value[i];

public static A201907Inst Instance=new A201907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201908
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,4L,3L,1L,2L,4L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,5L,10L,9L,7L,3L,6L,1L,2L,4L,8L,3L,6L,12L,11L,9L,5L,10L,7L,1L,2L,4L,8L,1L,2L,4L,8L,16L,15L,13L,9L,1L,2L,4L,8L,16L,13L,7L,14L,9L,18L,17L,15L,11L,3L,6L,12L,5L,10L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201908Inst : IEnumerable<long>
{
public static readonly long[] Value=A201908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201908.Bytes);
public long this[int i]=>Value[i];

public static A201908Inst Instance=new A201908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201909
{
public static readonly long[] Value={ 1L,0L,1L,3L,4L,2L,1L,3L,2L,6L,4L,5L,1L,3L,9L,5L,4L,1L,3L,9L,1L,3L,9L,10L,13L,5L,15L,11L,16L,14L,8L,7L,4L,12L,2L,6L,1L,3L,9L,8L,5L,15L,7L,2L,6L,18L,16L,10L,11L,14L,4L,12L,17L,13L,1L,3L,9L,4L,12L,13L,16L,2L,6L,18L,8L,1L,3L,9L,27L,23L,11L,4L,12L,7L,21L,5L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201909Inst : IEnumerable<long>
{
public static readonly long[] Value=A201909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201909.Bytes);
public long this[int i]=>Value[i];

public static A201909Inst Instance=new A201909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201910
{
public static readonly long[] Value={ 1L,1L,2L,0L,1L,5L,4L,6L,2L,3L,1L,5L,3L,4L,9L,1L,5L,12L,8L,1L,5L,8L,6L,13L,14L,2L,10L,16L,12L,9L,11L,4L,3L,15L,7L,1L,5L,6L,11L,17L,9L,7L,16L,4L,1L,5L,2L,10L,4L,20L,8L,17L,16L,11L,9L,22L,18L,21L,13L,19L,3L,15L,6L,7L,12L,14L,1L,5L,25L,9L,16L,22L,23L,28L,24L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201910Inst : IEnumerable<long>
{
public static readonly long[] Value=A201910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201910.Bytes);
public long this[int i]=>Value[i];

public static A201910Inst Instance=new A201910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201911
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,3L,0L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,15L,3L,4L,11L,9L,12L,16L,10L,2L,14L,13L,6L,8L,5L,1L,7L,11L,1L,7L,3L,21L,9L,17L,4L,5L,12L,15L,13L,22L,16L,20L,2L,14L,6L,19L,18L,11L,8L,10L,1L,7L,20L,24L,23L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201911Inst : IEnumerable<long>
{
public static readonly long[] Value=A201911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201911.Bytes);
public long this[int i]=>Value[i];

public static A201911Inst Instance=new A201911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201912
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,4L,3L,1L,2L,4L,1L,2L,4L,8L,5L,10L,9L,7L,3L,6L,1L,2L,4L,8L,3L,6L,12L,11L,9L,5L,10L,7L,1L,2L,4L,8L,16L,15L,13L,9L,1L,2L,4L,8L,16L,13L,7L,14L,9L,18L,17L,15L,11L,3L,6L,12L,5L,10L,1L,2L,4L,8L,16L,9L,18L,13L,3L,6L,12L,1L,2L,4L,8L,16L,3L,6L,12L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201912Inst : IEnumerable<long>
{
public static readonly long[] Value=A201912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201912.Bytes);
public long this[int i]=>Value[i];

public static A201912Inst Instance=new A201912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201913
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,1L,2L,3L,1L,1L,2L,2L,2L,1L,3L,4L,1L,2L,2L,1L,1L,3L,2L,3L,1L,4L,5L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,1L,2L,3L,3L,3L,1L,1L,4L,2L,4L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201913Inst : IEnumerable<long>
{
public static readonly long[] Value=A201913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201913.Bytes);
public long this[int i]=>Value[i];

public static A201913Inst Instance=new A201913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201914
{
public static readonly long[] Value={ 2L,5L,3L,7L,47L,31L,191L,127L,1279L,3583L,5119L,6143L,20479L,8191L,81919L,294911L,1114111L,131071L,786431L,524287L,17825791L,14680063L,138412031L,109051903L,654311423L,1912602623L,738197503L,2818572287L,7247757311L,3758096383L,228707008511L,2147483647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201914Inst : IEnumerable<long>
{
public static readonly long[] Value=A201914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201914.Bytes);
public long this[int i]=>Value[i];

public static A201914Inst Instance=new A201914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201915
{
public static readonly long[] Value={ 1L,6L,11L,14L,15L,23L,42L,62L,69L,77L,30L,46L,51L,55L,71L,60L,78L,92L,123L,143L,167L,114L,135L,158L,177L,203L,209L,239L,132L,140L,182L,188L,195L,249L,287L,299L,120L,174L,184L,190L,267L,295L,319L,323L,359L,204L,220L,224L,246L,284L,286L,334L,415L,451L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201915Inst : IEnumerable<long>
{
public static readonly long[] Value=A201915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201915.Bytes);
public long this[int i]=>Value[i];

public static A201915Inst Instance=new A201915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201916
{
public static readonly long[] Value={ 0L,75L,203L,323L,552L,708L,1020L,1127L,1311L,1428L,1608L,1820L,1955L,2336L,2675L,3128L,3311L,3627L,3927L,4140L,4508L,4743L,5535L,6003L,6800L,7280L,7848L,8211L,8588L,9240L,9860L,11063L,11895L,13583L,14168L,15180L,15827L,16827L,18011L,18768L,20915L,22836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201916Inst : IEnumerable<long>
{
public static readonly long[] Value=A201916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201916.Bytes);
public long this[int i]=>Value[i];

public static A201916Inst Instance=new A201916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201917
{
public static readonly long[] Value={ 0L,2085L,2325L,5253L,6141L,6293L,7728L,10013L,11960L,12920L,14637L,16940L,17112L,18737L,21648L,21948L,23541L,24633L,26588L,27716L,31620L,33012L,34937L,35145L,38012L,40641L,42716L,44268L,47633L,49848L,52785L,54237L,56420L,56840L,60605L,63828L,67541L,70448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201917Inst : IEnumerable<long>
{
public static readonly long[] Value=A201917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201917.Bytes);
public long this[int i]=>Value[i];

public static A201917Inst Instance=new A201917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201918
{
public static readonly long[] Value={ 0L,1L,4L,9L,64L,81L,513L,1216L,6400L,14337L,234496L,483328L,2502657L,17432577L,18399232L,412549120L,842530816L,4317249537L,11162091520L,50755272705L,692253097984L,2178269839360L,6737830608897L,46758772080640L,60234433298433L,474731593596928L,809186870951937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201918Inst : IEnumerable<long>
{
public static readonly long[] Value=A201918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201918.Bytes);
public long this[int i]=>Value[i];

public static A201918Inst Instance=new A201918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201919
{
public static readonly long[] Value={ 0L,1L,7L,8L,49L,148L,344L,2401L,36016L,151264L,386561L,1764736L,5764801L,46941952L,58471553L,374712065L,1101076992L,4802079233L,15858967552L,139825248256L,149429406721L,1595702681601L,2453862488064L,14602557997056L,42091354378241L,127990382747648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201919Inst : IEnumerable<long>
{
public static readonly long[] Value=A201919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201919.Bytes);
public long this[int i]=>Value[i];

public static A201919Inst Instance=new A201919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201920
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,64L,3L,6L,12L,24L,48L,96L,67L,9L,18L,36L,72L,19L,38L,76L,27L,54L,108L,91L,57L,114L,103L,81L,37L,74L,23L,46L,92L,59L,118L,111L,97L,69L,13L,26L,52L,104L,83L,41L,82L,39L,78L,31L,62L,124L,123L,121L,117L,109L,93L,61L,122L,119L,113L,101L,77L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201920Inst : IEnumerable<long>
{
public static readonly long[] Value=A201920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201920.Bytes);
public long this[int i]=>Value[i];

public static A201920Inst Instance=new A201920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201921
{
public static readonly long[] Value={ 0L,1L,6L,10L,100L,126L,1000L,2376L,4375L,46251L,156250L,603126L,3640626L,7750000L,19140625L,151718751L,835156251L,1727734375L,5960937501L,32482421875L,236621093751L,340029296875L,8413134765625L,60784912109376L,68961425781250L,709516601562501L,1236678466796875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201921Inst : IEnumerable<long>
{
public static readonly long[] Value=A201921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201921.Bytes);
public long this[int i]=>Value[i];

public static A201921Inst Instance=new A201921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201922
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,6L,3L,1L,1L,21L,8L,3L,1L,1L,112L,30L,9L,3L,1L,1L,853L,145L,32L,9L,3L,1L,1L,11117L,1028L,154L,33L,9L,3L,1L,1L,261080L,12320L,1065L,156L,33L,9L,3L,1L,1L,11716571L,274806L,12513L,1074L,157L,33L,9L,3L,1L,1L,1006700565L,12007355L,276114L,12550L,1076L,157L,33L,9L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201922Inst : IEnumerable<long>
{
public static readonly long[] Value=A201922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201922.Bytes);
public long this[int i]=>Value[i];

public static A201922Inst Instance=new A201922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201923
{
public static readonly BigInteger[] Value={ 1L,1L,5L,44L,581L,10256L,227529L,6088256L,190930729L,6870227200L,279066777613L,12632667642880L,630670054092525L,34426087332253696L,2039903110075608977L,BigInteger.Parse("130404672744539242496"),BigInteger.Parse("8946117466489960168913"),BigInteger.Parse("655585000075494566199296"),BigInteger.Parse("51111210765059412626238741") };
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
public class A201923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201923Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201923.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201923.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201923Inst Instance=new A201923Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201924
{
public static readonly long[] Value={ 3L,0L,2L,4L,0L,1L,4L,5L,0L,1L,1L,3L,5L,2L,9L,3L,7L,8L,4L,7L,7L,5L,5L,8L,9L,6L,2L,7L,7L,9L,7L,3L,9L,5L,3L,5L,1L,6L,5L,9L,8L,2L,8L,2L,8L,7L,1L,3L,2L,9L,0L,7L,9L,1L,9L,8L,7L,5L,0L,3L,5L,5L,4L,8L,2L,6L,2L,3L,8L,2L,5L,2L,4L,7L,0L,6L,6L,4L,3L,2L,9L,4L,3L,2L,4L,8L,4L,3L,4L,2L,4L,1L,0L,3L,3L,5L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201924Inst : IEnumerable<long>
{
public static readonly long[] Value=A201924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201924.Bytes);
public long this[int i]=>Value[i];

public static A201924Inst Instance=new A201924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201925
{
public static readonly long[] Value={ 7L,9L,5L,2L,2L,6L,6L,1L,3L,8L,6L,0L,5L,4L,0L,7L,9L,8L,8L,9L,6L,2L,6L,1L,5L,5L,6L,3L,8L,8L,7L,1L,8L,0L,2L,9L,3L,6L,3L,7L,4L,8L,5L,3L,8L,5L,6L,2L,0L,8L,7L,8L,6L,0L,3L,5L,7L,5L,0L,0L,6L,4L,4L,0L,0L,6L,9L,4L,8L,1L,6L,2L,4L,2L,3L,4L,8L,1L,2L,6L,8L,5L,9L,0L,8L,7L,3L,9L,7L,0L,2L,5L,4L,6L,5L,0L,8L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201925Inst : IEnumerable<long>
{
public static readonly long[] Value=A201925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201925.Bytes);
public long this[int i]=>Value[i];

public static A201925Inst Instance=new A201925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201926
{
public static readonly long[] Value={ 3L,2L,9L,8L,6L,2L,7L,5L,6L,2L,8L,0L,3L,8L,6L,5L,1L,8L,0L,2L,5L,5L,9L,4L,1L,3L,1L,6L,4L,9L,2L,3L,4L,1L,3L,4L,3L,1L,8L,2L,0L,4L,3L,0L,3L,6L,5L,6L,2L,3L,9L,5L,6L,3L,7L,8L,3L,7L,0L,0L,8L,6L,3L,3L,5L,7L,8L,8L,6L,2L,0L,1L,5L,3L,4L,4L,6L,8L,4L,1L,7L,2L,0L,6L,2L,7L,1L,9L,0L,6L,5L,3L,7L,8L,4L,1L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201926Inst : IEnumerable<long>
{
public static readonly long[] Value=A201926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201926.Bytes);
public long this[int i]=>Value[i];

public static A201926Inst Instance=new A201926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201927
{
public static readonly long[] Value={ 2L,3L,1L,4L,3L,6L,9L,9L,0L,2L,9L,6L,7L,6L,2L,8L,0L,1L,9L,1L,7L,3L,9L,1L,3L,3L,9L,2L,0L,4L,2L,9L,4L,7L,1L,8L,9L,3L,2L,0L,3L,5L,0L,5L,5L,7L,6L,8L,2L,8L,5L,8L,5L,9L,0L,7L,9L,3L,7L,5L,4L,4L,3L,2L,0L,9L,4L,9L,2L,5L,2L,5L,8L,4L,2L,1L,4L,5L,1L,0L,4L,0L,7L,3L,1L,4L,6L,5L,7L,5L,5L,4L,7L,5L,4L,9L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201927Inst : IEnumerable<long>
{
public static readonly long[] Value=A201927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201927.Bytes);
public long this[int i]=>Value[i];

public static A201927Inst Instance=new A201927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201928
{
public static readonly long[] Value={ 1L,5L,3L,6L,0L,7L,8L,0L,9L,4L,0L,2L,6L,9L,3L,1L,1L,3L,0L,5L,1L,1L,3L,6L,7L,0L,5L,2L,1L,5L,5L,0L,9L,5L,9L,8L,1L,8L,1L,3L,6L,9L,8L,2L,9L,7L,7L,4L,3L,8L,3L,6L,3L,8L,9L,0L,2L,0L,6L,2L,0L,6L,5L,4L,4L,9L,6L,7L,5L,7L,7L,8L,0L,2L,5L,5L,2L,4L,6L,8L,4L,1L,4L,1L,8L,2L,9L,0L,2L,7L,8L,0L,4L,0L,6L,7L,9L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201928Inst : IEnumerable<long>
{
public static readonly long[] Value=A201928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201928.Bytes);
public long this[int i]=>Value[i];

public static A201928Inst Instance=new A201928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201929
{
public static readonly long[] Value={ 3L,3L,5L,6L,6L,9L,3L,9L,8L,0L,0L,3L,3L,3L,2L,1L,3L,0L,6L,8L,2L,5L,7L,6L,9L,0L,2L,4L,1L,8L,9L,0L,4L,6L,1L,6L,9L,6L,4L,8L,9L,1L,7L,5L,3L,0L,7L,0L,3L,2L,0L,4L,4L,3L,2L,7L,9L,6L,6L,8L,3L,7L,3L,6L,7L,9L,8L,0L,9L,5L,2L,9L,1L,3L,7L,1L,4L,2L,6L,8L,7L,3L,9L,9L,4L,9L,3L,9L,6L,4L,8L,3L,7L,6L,2L,4L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201929Inst : IEnumerable<long>
{
public static readonly long[] Value=A201929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201929.Bytes);
public long this[int i]=>Value[i];

public static A201929Inst Instance=new A201929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201930
{
public static readonly long[] Value={ 3L,4L,1L,0L,1L,4L,6L,8L,4L,4L,9L,4L,5L,6L,2L,9L,4L,9L,2L,2L,8L,6L,4L,8L,0L,6L,3L,6L,5L,3L,0L,2L,2L,6L,0L,6L,6L,2L,5L,2L,5L,3L,7L,8L,6L,7L,5L,2L,9L,8L,6L,1L,1L,6L,1L,3L,1L,4L,9L,0L,9L,4L,7L,4L,9L,5L,1L,4L,5L,3L,9L,8L,1L,4L,0L,1L,7L,1L,0L,0L,4L,5L,7L,2L,1L,2L,0L,7L,0L,5L,3L,8L,2L,1L,6L,1L,9L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201930Inst : IEnumerable<long>
{
public static readonly long[] Value=A201930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201930.Bytes);
public long this[int i]=>Value[i];

public static A201930Inst Instance=new A201930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201931
{
public static readonly long[] Value={ 4L,7L,9L,3L,0L,9L,5L,4L,5L,5L,1L,2L,7L,4L,9L,3L,5L,8L,9L,5L,6L,5L,6L,2L,1L,1L,0L,8L,5L,0L,4L,2L,0L,4L,3L,1L,4L,3L,4L,8L,9L,0L,9L,3L,1L,7L,4L,9L,1L,1L,1L,6L,0L,8L,1L,0L,6L,7L,9L,3L,2L,4L,1L,6L,4L,7L,7L,9L,2L,7L,2L,5L,5L,7L,4L,3L,6L,2L,1L,1L,3L,1L,9L,9L,3L,3L,1L,8L,8L,1L,4L,2L,4L,1L,1L,4L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201931Inst : IEnumerable<long>
{
public static readonly long[] Value=A201931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201931.Bytes);
public long this[int i]=>Value[i];

public static A201931Inst Instance=new A201931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201932
{
public static readonly long[] Value={ 3L,3L,7L,7L,3L,6L,1L,4L,8L,4L,1L,9L,7L,4L,0L,0L,5L,7L,9L,2L,5L,5L,0L,2L,5L,0L,5L,8L,8L,8L,9L,2L,1L,0L,6L,1L,4L,3L,9L,2L,6L,1L,0L,8L,0L,3L,0L,3L,1L,5L,9L,4L,9L,4L,8L,2L,5L,0L,4L,0L,2L,2L,1L,0L,4L,2L,4L,4L,1L,7L,7L,6L,0L,9L,0L,2L,6L,1L,0L,7L,7L,4L,6L,8L,2L,9L,4L,9L,2L,4L,0L,2L,5L,7L,2L,0L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201932Inst : IEnumerable<long>
{
public static readonly long[] Value=A201932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201932.Bytes);
public long this[int i]=>Value[i];

public static A201932Inst Instance=new A201932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201933
{
public static readonly long[] Value={ 4L,5L,6L,4L,0L,7L,8L,3L,6L,0L,3L,7L,9L,3L,7L,7L,2L,0L,1L,3L,4L,1L,4L,8L,6L,8L,5L,2L,3L,4L,2L,0L,7L,4L,4L,8L,0L,6L,9L,5L,7L,9L,6L,4L,3L,4L,6L,1L,3L,1L,4L,1L,1L,1L,2L,5L,2L,3L,5L,7L,5L,3L,5L,9L,5L,4L,2L,6L,0L,2L,8L,0L,7L,3L,3L,7L,5L,3L,7L,0L,3L,7L,9L,6L,6L,5L,7L,8L,4L,5L,5L,4L,5L,0L,8L,4L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201933Inst : IEnumerable<long>
{
public static readonly long[] Value=A201933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201933.Bytes);
public long this[int i]=>Value[i];

public static A201933Inst Instance=new A201933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201934
{
public static readonly long[] Value={ 2L,5L,9L,0L,6L,9L,5L,3L,3L,0L,5L,1L,1L,0L,9L,1L,0L,8L,6L,8L,6L,4L,0L,5L,6L,6L,4L,6L,5L,5L,9L,6L,2L,2L,6L,2L,8L,9L,6L,4L,8L,0L,5L,4L,5L,7L,8L,6L,4L,2L,5L,5L,1L,3L,1L,6L,9L,2L,1L,5L,6L,5L,9L,4L,9L,0L,1L,7L,2L,4L,9L,0L,0L,0L,8L,8L,2L,5L,6L,7L,1L,2L,6L,4L,9L,8L,1L,3L,4L,8L,3L,9L,7L,0L,1L,2L,4L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201934Inst : IEnumerable<long>
{
public static readonly long[] Value=A201934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201934.Bytes);
public long this[int i]=>Value[i];

public static A201934Inst Instance=new A201934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201935
{
public static readonly long[] Value={ 3L,4L,3L,2L,0L,0L,8L,7L,1L,1L,6L,1L,0L,6L,8L,0L,3L,5L,2L,8L,0L,3L,7L,9L,1L,4L,6L,2L,6L,9L,4L,7L,1L,9L,7L,0L,6L,0L,4L,2L,2L,3L,3L,0L,3L,7L,3L,5L,4L,2L,0L,5L,2L,1L,0L,0L,8L,7L,1L,4L,8L,9L,9L,5L,3L,7L,4L,7L,9L,7L,1L,1L,3L,4L,3L,6L,4L,6L,3L,1L,4L,1L,6L,5L,3L,4L,9L,1L,1L,4L,0L,0L,4L,6L,5L,3L,3L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201935Inst : IEnumerable<long>
{
public static readonly long[] Value=A201935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201935.Bytes);
public long this[int i]=>Value[i];

public static A201935Inst Instance=new A201935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201936
{
public static readonly long[] Value={ 2L,6L,1L,7L,8L,6L,6L,6L,1L,3L,0L,6L,6L,8L,1L,2L,7L,6L,9L,1L,7L,8L,9L,7L,8L,0L,5L,9L,1L,4L,3L,2L,0L,2L,8L,1L,7L,3L,2L,0L,2L,7L,4L,3L,5L,9L,4L,1L,0L,4L,8L,2L,9L,1L,9L,2L,1L,0L,5L,0L,8L,1L,6L,1L,0L,4L,0L,3L,7L,0L,3L,2L,5L,3L,3L,2L,2L,7L,9L,6L,5L,9L,9L,6L,5L,0L,6L,3L,6L,1L,7L,0L,4L,5L,6L,3L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201936Inst : IEnumerable<long>
{
public static readonly long[] Value=A201936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201936.Bytes);
public long this[int i]=>Value[i];

public static A201936Inst Instance=new A201936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201937
{
public static readonly long[] Value={ 1L,4L,8L,7L,9L,6L,2L,0L,6L,5L,4L,9L,8L,1L,7L,7L,1L,5L,6L,2L,5L,4L,3L,7L,0L,1L,2L,0L,9L,3L,2L,6L,3L,2L,5L,6L,3L,7L,2L,6L,4L,8L,4L,2L,4L,3L,7L,8L,0L,2L,1L,0L,6L,8L,4L,6L,2L,3L,6L,9L,6L,8L,9L,7L,7L,2L,6L,8L,6L,8L,0L,9L,4L,4L,6L,2L,7L,6L,8L,7L,4L,4L,2L,2L,8L,9L,2L,0L,8L,3L,0L,1L,2L,0L,9L,0L,1L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201937Inst : IEnumerable<long>
{
public static readonly long[] Value=A201937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201937.Bytes);
public long this[int i]=>Value[i];

public static A201937Inst Instance=new A201937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201938
{
public static readonly long[] Value={ 5L,3L,9L,8L,3L,5L,2L,7L,6L,9L,0L,2L,8L,2L,0L,0L,4L,9L,2L,1L,1L,8L,0L,3L,9L,0L,8L,3L,6L,3L,3L,3L,8L,7L,2L,0L,0L,9L,3L,0L,1L,3L,0L,7L,9L,8L,7L,4L,4L,2L,7L,4L,2L,8L,6L,2L,7L,3L,2L,2L,0L,2L,7L,1L,2L,1L,8L,2L,5L,4L,5L,7L,5L,2L,4L,9L,9L,2L,0L,3L,8L,2L,5L,8L,3L,8L,3L,8L,1L,2L,2L,3L,8L,6L,6L,7L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201938Inst : IEnumerable<long>
{
public static readonly long[] Value=A201938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201938.Bytes);
public long this[int i]=>Value[i];

public static A201938Inst Instance=new A201938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201939
{
public static readonly long[] Value={ 1L,1L,5L,0L,5L,8L,4L,9L,6L,7L,4L,1L,8L,6L,6L,3L,9L,4L,9L,5L,3L,4L,9L,3L,3L,7L,3L,3L,6L,1L,3L,7L,8L,8L,1L,9L,5L,7L,6L,6L,8L,3L,7L,4L,9L,4L,8L,4L,4L,2L,4L,2L,3L,4L,1L,1L,8L,3L,3L,9L,2L,5L,1L,8L,0L,8L,8L,3L,2L,2L,5L,4L,6L,1L,7L,6L,4L,1L,1L,7L,2L,8L,0L,1L,3L,6L,7L,5L,4L,4L,1L,4L,5L,2L,4L,6L,9L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201939Inst : IEnumerable<long>
{
public static readonly long[] Value=A201939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201939.Bytes);
public long this[int i]=>Value[i];

public static A201939Inst Instance=new A201939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201940
{
public static readonly long[] Value={ 1L,1L,4L,7L,7L,5L,7L,6L,3L,2L,1L,4L,4L,7L,4L,3L,4L,9L,3L,0L,3L,4L,3L,7L,1L,9L,9L,0L,6L,1L,0L,6L,7L,4L,7L,6L,6L,4L,3L,4L,6L,1L,9L,1L,2L,4L,4L,6L,2L,9L,3L,5L,9L,9L,1L,5L,2L,8L,4L,5L,4L,4L,0L,8L,2L,6L,9L,0L,5L,7L,7L,9L,2L,1L,8L,8L,7L,0L,9L,8L,1L,9L,2L,4L,6L,7L,6L,7L,8L,1L,0L,0L,1L,4L,5L,5L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201940Inst : IEnumerable<long>
{
public static readonly long[] Value=A201940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201940.Bytes);
public long this[int i]=>Value[i];

public static A201940Inst Instance=new A201940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201941
{
public static readonly long[] Value={ 4L,4L,4L,1L,3L,0L,2L,2L,8L,8L,2L,3L,9L,6L,6L,5L,9L,0L,5L,8L,5L,4L,6L,6L,3L,2L,9L,4L,9L,0L,9L,8L,4L,6L,6L,7L,0L,7L,9L,3L,2L,0L,9L,6L,9L,9L,4L,2L,1L,3L,7L,7L,5L,6L,9L,5L,9L,1L,8L,2L,6L,3L,4L,4L,1L,1L,8L,9L,3L,8L,6L,8L,5L,7L,4L,5L,2L,8L,5L,0L,8L,3L,6L,5L,4L,3L,8L,0L,2L,1L,0L,4L,2L,9L,8L,5L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201941Inst : IEnumerable<long>
{
public static readonly long[] Value=A201941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201941.Bytes);
public long this[int i]=>Value[i];

public static A201941Inst Instance=new A201941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201942
{
public static readonly long[] Value={ 1L,3L,0L,9L,7L,9L,9L,5L,8L,5L,8L,0L,4L,1L,5L,0L,4L,7L,7L,6L,6L,9L,2L,3L,3L,7L,0L,1L,9L,6L,8L,1L,7L,2L,5L,0L,6L,0L,1L,0L,8L,6L,8L,8L,9L,6L,4L,3L,0L,4L,8L,0L,4L,3L,5L,5L,5L,8L,4L,7L,5L,3L,6L,7L,4L,2L,6L,2L,1L,4L,5L,1L,3L,3L,5L,8L,2L,2L,6L,2L,3L,4L,9L,1L,5L,4L,2L,1L,4L,2L,8L,1L,2L,2L,4L,2L,0L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201942Inst : IEnumerable<long>
{
public static readonly long[] Value=A201942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201942.Bytes);
public long this[int i]=>Value[i];

public static A201942Inst Instance=new A201942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201943
{
public static readonly long[] Value={ 1L,3L,9L,7L,6L,5L,8L,9L,7L,7L,4L,2L,2L,4L,3L,8L,0L,2L,0L,4L,4L,0L,3L,2L,5L,2L,0L,6L,5L,3L,0L,8L,3L,8L,9L,8L,3L,9L,7L,8L,9L,0L,1L,4L,6L,0L,1L,8L,9L,9L,0L,0L,8L,6L,9L,4L,8L,0L,0L,2L,8L,3L,7L,4L,6L,6L,2L,5L,8L,2L,0L,1L,3L,4L,1L,8L,7L,2L,7L,9L,8L,9L,1L,9L,0L,3L,3L,2L,0L,6L,2L,0L,1L,8L,7L,0L,2L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201943Inst : IEnumerable<long>
{
public static readonly long[] Value=A201943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201943.Bytes);
public long this[int i]=>Value[i];

public static A201943Inst Instance=new A201943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201944
{
public static readonly long[] Value={ 5L,7L,5L,2L,9L,2L,4L,8L,3L,7L,0L,9L,3L,3L,1L,9L,7L,4L,7L,6L,7L,4L,6L,6L,8L,6L,6L,8L,0L,6L,8L,9L,4L,0L,9L,7L,8L,8L,3L,4L,1L,8L,7L,4L,7L,4L,2L,2L,1L,2L,1L,1L,7L,0L,5L,9L,1L,6L,9L,6L,2L,5L,9L,0L,4L,4L,1L,6L,1L,2L,7L,3L,0L,8L,8L,2L,0L,5L,8L,6L,4L,0L,0L,6L,8L,3L,7L,7L,2L,0L,7L,2L,6L,2L,3L,4L,9L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201944Inst : IEnumerable<long>
{
public static readonly long[] Value=A201944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201944.Bytes);
public long this[int i]=>Value[i];

public static A201944Inst Instance=new A201944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201945
{
public static readonly long[] Value={ 4L,6L,5L,8L,8L,6L,3L,2L,5L,8L,0L,7L,4L,7L,9L,3L,4L,0L,1L,4L,6L,7L,7L,5L,0L,6L,8L,8L,4L,3L,6L,1L,2L,9L,9L,4L,6L,5L,9L,6L,3L,3L,8L,2L,0L,0L,6L,3L,3L,0L,0L,2L,8L,9L,8L,2L,6L,6L,7L,6L,1L,2L,4L,8L,8L,7L,5L,2L,7L,3L,3L,7L,8L,0L,6L,2L,4L,2L,6L,6L,3L,0L,6L,3L,4L,4L,4L,0L,1L,8L,6L,2L,2L,0L,9L,3L,5L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201945Inst : IEnumerable<long>
{
public static readonly long[] Value=A201945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201945.Bytes);
public long this[int i]=>Value[i];

public static A201945Inst Instance=new A201945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201946
{
public static readonly long[] Value={ 1L,2L,4L,9L,3L,9L,4L,3L,3L,6L,6L,4L,6L,3L,2L,4L,4L,7L,2L,5L,1L,1L,2L,7L,4L,3L,2L,1L,2L,6L,1L,0L,0L,8L,1L,2L,3L,4L,6L,9L,4L,4L,1L,3L,0L,0L,9L,0L,1L,5L,2L,9L,6L,9L,6L,2L,9L,7L,2L,6L,0L,7L,6L,8L,6L,8L,8L,2L,1L,2L,3L,9L,7L,3L,1L,0L,6L,2L,2L,9L,8L,3L,0L,0L,5L,3L,2L,5L,7L,7L,0L,8L,2L,8L,6L,5L,3L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201946Inst : IEnumerable<long>
{
public static readonly long[] Value=A201946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201946.Bytes);
public long this[int i]=>Value[i];

public static A201946Inst Instance=new A201946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201947
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,0L,3L,5L,1L,-1L,5L,10L,4L,-2L,-1L,8L,20L,12L,-4L,-4L,0L,13L,38L,31L,-4L,-13L,-2L,1L,21L,71L,73L,3L,-33L,-11L,3L,1L,34L,130L,162L,34L,-74L,-42L,6L,6L,0L,55L,235L,344L,128L,-146L,-130L,0L,24L,3L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201947Inst : IEnumerable<long>
{
public static readonly long[] Value=A201947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201947.Bytes);
public long this[int i]=>Value[i];

public static A201947Inst Instance=new A201947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201948
{
public static readonly long[] Value={ 0L,1L,9L,10L,81L,244L,729L,5104L,6561L,98416L,413344L,1476225L,9034497L,24977728L,263063296L,349156737L,2711943424L,8308017153L,96467701761L,101891588608L,1286623443969L,2283843782656L,30847581595648L,33420828483585L,352189631991808L,804641749434369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201948Inst : IEnumerable<long>
{
public static readonly long[] Value=A201948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201948.Bytes);
public long this[int i]=>Value[i];

public static A201948Inst Instance=new A201948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201949
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,3L,5L,6L,5L,3L,1L,1L,6L,15L,24L,28L,24L,15L,6L,1L,1L,10L,40L,90L,139L,160L,139L,90L,40L,10L,1L,1L,15L,91L,300L,629L,945L,1078L,945L,629L,300L,91L,15L,1L,1L,21L,182L,861L,2520L,5019L,7377L,8358L,7377L,5019L,2520L,861L,182L,21L,1L,1L,28L,330L,2156L,8729L,23520L,45030L,65016L,73260L,65016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201949Inst : IEnumerable<long>
{
public static readonly long[] Value=A201949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201949.Bytes);
public long this[int i]=>Value[i];

public static A201949Inst Instance=new A201949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201950
{
public static readonly BigInteger[] Value={ 1L,0L,2L,6L,28L,160L,1078L,8358L,73260L,716112L,7721844L,91039740L,1164932470L,16077368580L,238037983558L,3763371442530L,63276351409092L,1127406030014112L,21218146474666864L,420611921077524912L,8759617763834095796L,BigInteger.Parse("191208185756772875880") };
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
public class A201950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201950Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201950.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201950.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201950Inst Instance=new A201950Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201951
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,13L,33L,85L,234L,675L,2032L,6367L,20677L,69442L,240529L,857634L,3141970L,11808611L,45464065L,179088744L,720947705L,2962994169L,12420658682L,53061133078L,230828047288L,1021809688593L,4599749893986L,21043392417004L,97784119963565L,461277854065112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201951Inst : IEnumerable<long>
{
public static readonly long[] Value=A201951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201951.Bytes);
public long this[int i]=>Value[i];

public static A201951Inst Instance=new A201951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201952
{
public static readonly BigInteger[] Value={ 1L,1L,5L,24L,139L,945L,7377L,65016L,638418L,6910650L,81747665L,1049089470L,14516096009L,215419836359L,3412889885571L,57492203734320L,1026121982213480L,19342642266760680L,383995631680561234L,8007915240045479980L,BigInteger.Parse("175020604366224762038"),BigInteger.Parse("4000551483475536398178") };
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
public class A201952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201952.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201952Inst Instance=new A201952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201953
{
public static readonly BigInteger[] Value={ 1L,3L,15L,90L,629L,5019L,45030L,448776L,4919321L,58825415L,762089899L,10633219662L,158974192987L,2535484008225L,42970371055268L,771162539117408L,14609924404202130L,291386317037291622L,6102681801481066642L,BigInteger.Parse("133910606028043519500"),BigInteger.Parse("3072216586896101950757") };
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
public class A201953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201953Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201953.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201953.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201953Inst Instance=new A201953Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201954
{
public static readonly BigInteger[] Value={ 1L,0L,2L,0L,24L,0L,552L,0L,15936L,0L,427008L,0L,35567232L,0L,7352654592L,0L,-1064016089088L,0L,-285531029213184L,0L,515396596477280256L,0L,BigInteger.Parse("-177833505179096580096"),0L,BigInteger.Parse("-286336846462160593059840"),0L,BigInteger.Parse("573948928392687509387673600"),0L,BigInteger.Parse("-211350462543692217044652785664") };
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
public class A201954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201954.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201954Inst Instance=new A201954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201955
{
public static readonly long[] Value={ 7L,231L,1587L,17903L,194633L,2232183L,25952953L,305979795L,3640250461L,43624267941L,525774918227L,6366440653727L,77388201173481L,943784967491137L,11542145313593503L,141498452574240619L,1738344524754583621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201955Inst : IEnumerable<long>
{
public static readonly long[] Value=A201955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201955.Bytes);
public long this[int i]=>Value[i];

public static A201955Inst Instance=new A201955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201956
{
public static readonly BigInteger[] Value={ 37L,1587L,17091L,303955L,4735345L,85454789L,1489376611L,27222524599L,493561989579L,9124430335331L,168519041238653L,3142665027511853L,58661584782394781L,1101133968614654601L,BigInteger.Parse("20697996312691430763") };
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
public class A201956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201956.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201956Inst Instance=new A201956Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201957
{
public static readonly long[] Value={ 231L,17903L,303955L,9654533L,300895245L,10356370455L,360008261031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201957Inst : IEnumerable<long>
{
public static readonly long[] Value=A201957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201957.Bytes);
public long this[int i]=>Value[i];

public static A201957Inst Instance=new A201957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201958
{
public static readonly long[] Value={ 1L,7L,7L,37L,231L,37L,231L,1587L,1587L,231L,1451L,17903L,17091L,17903L,1451L,9331L,194633L,303955L,303955L,194633L,9331L,60691L,2232183L,4735345L,9654533L,4735345L,2232183L,60691L,398567L,25952953L,85454789L,300895245L,300895245L,85454789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201958Inst : IEnumerable<long>
{
public static readonly long[] Value=A201958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201958.Bytes);
public long this[int i]=>Value[i];

public static A201958Inst Instance=new A201958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201959
{
public static readonly BigInteger[] Value={ 1L,2L,6L,28L,200L,1686L,14322L,120856L,1046376L,10250890L,150231950L,3231032388L,63012862068L,578740591534L,-16721732074110L,-795532873957712L,-563556173628880L,1315395887469186834L,BigInteger.Parse("58144603365684119574"),BigInteger.Parse("-114890208409408898660"),BigInteger.Parse("-145164771250945501267380") };
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
public class A201959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201959Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201959.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201959.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201959Inst Instance=new A201959Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201960
{
public static readonly long[] Value={ 31L,139L,571L,1291L,1759L,5179L,6079L,10399L,17419L,20731L,28219L,30271L,34591L,39199L,41611L,49279L,54751L,63499L,69691L,82939L,101119L,104971L,116959L,125311L,147451L,161599L,186619L,207931L,219019L,242059L,247999L,285151L,311359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201960Inst : IEnumerable<long>
{
public static readonly long[] Value=A201960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201960.Bytes);
public long this[int i]=>Value[i];

public static A201960Inst Instance=new A201960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201961
{
public static readonly long[] Value={ 73L,433L,2017L,2593L,6553L,7561L,8641L,13681L,15121L,16633L,18217L,21601L,31321L,42841L,45361L,53353L,68113L,74521L,84673L,91801L,106921L,110881L,114913L,140617L,159193L,168913L,178921L,205201L,216217L,250993L,288361L,308017L,370873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201961Inst : IEnumerable<long>
{
public static readonly long[] Value=A201961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201961.Bytes);
public long this[int i]=>Value[i];

public static A201961Inst Instance=new A201961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201962
{
public static readonly long[] Value={ 7L,37L,157L,487L,997L,2557L,2887L,3607L,6247L,13687L,14437L,21157L,24007L,28087L,31357L,33637L,34807L,44887L,46237L,63997L,90247L,106087L,114487L,120997L,132247L,146407L,153757L,176887L,184957L,187687L,195997L,204487L,210247L,222007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201962Inst : IEnumerable<long>
{
public static readonly long[] Value=A201962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201962.Bytes);
public long this[int i]=>Value[i];

public static A201962Inst Instance=new A201962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201963
{
public static readonly long[] Value={ 3L,83L,353L,1433L,2243L,7283L,10883L,12953L,26003L,29153L,35993L,75683L,92153L,104033L,123203L,129953L,136883L,166403L,182243L,224993L,234083L,262433L,345953L,368633L,392033L,416153L,453683L,466553L,620003L,665633L,712883L,728993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201963Inst : IEnumerable<long>
{
public static readonly long[] Value=A201963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201963.Bytes);
public long this[int i]=>Value[i];

public static A201963Inst Instance=new A201963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201964
{
public static readonly long[] Value={ 31L,151L,241L,631L,991L,1201L,1951L,2551L,4831L,5281L,9601L,11551L,12241L,13681L,14431L,15991L,18481L,24001L,27031L,28081L,30241L,37201L,38431L,48991L,53281L,54751L,57751L,59281L,62401L,67231L,68881L,73951L,77431L,79201L,84631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201964Inst : IEnumerable<long>
{
public static readonly long[] Value=A201964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201964.Bytes);
public long this[int i]=>Value[i];

public static A201964Inst Instance=new A201964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201965
{
public static readonly ulong[] Value={ 101L,103L,107L,109L,1033L,10111L,10333L,101111L,103333L,107777L,10333333L,101111111L,103333333L,1033333333L,10999999999L,101111111111L,1099999999999L,10333333333333L,101111111111111111L,1099999999999999999L,10333333333333333333UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201965Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A201965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201965.Bytes);
public ulong this[int i]=>Value[i];

public static A201965Inst Instance=new A201965Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201966
{
public static readonly BigInteger[] Value={ 11L,113L,11777L,1133333L,1199999L,113333333L,11777777777L,1111111111111111111L,BigInteger.Parse("11111111111111111111111"),BigInteger.Parse("1177777777777777777777777"),BigInteger.Parse("113333333333333333333333333"),BigInteger.Parse("1177777777777777777777777777777777777777777777777") };
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
public class A201966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201966Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201966.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201966.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201966Inst Instance=new A201966Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201967
{
public static readonly long[] Value={ 1L,2L,7L,20L,60L,178L,529L,1572L,4671L,13880L,41244L,122556L,364173L,1082134L,3215543L,9554932L,28392320L,84367302L,250696021L,744939016L,2213573775L,6577597296L,19545219896L,58078292664L,172578671241L,512814623178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201967Inst : IEnumerable<long>
{
public static readonly long[] Value=A201967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201967.Bytes);
public long this[int i]=>Value[i];

public static A201967Inst Instance=new A201967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201968
{
public static readonly BigInteger[] Value={ 1L,1L,3L,9L,33L,157L,1077L,12562L,276361L,12023304L,1019341931L,165104554019L,50503104222056L,29054325051128443L,BigInteger.Parse("31426537149908636858"),BigInteger.Parse("64001044963441537716700"),BigInteger.Parse("245935895697060179316310623"),BigInteger.Parse("1787577789272803153324620542087"),BigInteger.Parse("24637809499317378365431171138790458") };
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
public class A201968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201968Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201968.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201968.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201968Inst Instance=new A201968Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201969
{
public static readonly long[] Value={ 1L,1L,3L,6L,16L,52L,169L,556L,1902L,6667L,23665L,85062L,309444L,1136400L,4205944L,15675690L,58785582L,221644054L,839692735L,3194875093L,12203132521L,46774765206L,179861164503L,693632630011L,2682150035748L,10396942423617L,40393878209664L,157267923352012L,613499893576207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201969Inst : IEnumerable<long>
{
public static readonly long[] Value=A201969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201969.Bytes);
public long this[int i]=>Value[i];

public static A201969Inst Instance=new A201969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201970
{
public static readonly long[] Value={ 1L,1L,3L,4L,11L,53L,146L,366L,1563L,5837L,16720L,59917L,246090L,828157L,2773984L,11056545L,41539923L,142602611L,536781500L,2103092222L,7632057148L,27948758125L,108960963441L,413531196001L,1523673835870L,5833675306068L,22596747340839L,85028853983908L,322415760345476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201970Inst : IEnumerable<long>
{
public static readonly long[] Value=A201970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201970.Bytes);
public long this[int i]=>Value[i];

public static A201970Inst Instance=new A201970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201971
{
public static readonly long[] Value={ 5L,6L,7L,8L,9L,10L,5L,6L,6L,7L,7L,8L,5L,9L,6L,6L,7L,7L,5L,8L,8L,6L,6L,9L,5L,7L,7L,8L,6L,6L,5L,9L,7L,7L,7L,6L,5L,8L,8L,8L,7L,7L,5L,6L,9L,8L,8L,8L,5L,6L,6L,9L,9L,9L,5L,8L,6L,6L,7L,10L,5L,9L,9L,6L,6L,7L,5L,10L,10L,10L,6L,6L,5L,7L,7L,8L,11L,6L,5L,10L,7L,7L,7L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201971Inst : IEnumerable<long>
{
public static readonly long[] Value=A201971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201971.Bytes);
public long this[int i]=>Value[i];

public static A201971Inst Instance=new A201971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201972
{
public static readonly long[] Value={ 1L,2L,2L,5L,8L,3L,12L,28L,20L,4L,29L,88L,94L,40L,5L,70L,262L,372L,244L,70L,6L,169L,752L,1333L,1184L,539L,112L,7L,408L,2104L,4472L,5016L,3144L,1064L,168L,8L,985L,5776L,14316L,19408L,15126L,7344L,1932L,240L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201972Inst : IEnumerable<long>
{
public static readonly long[] Value=A201972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201972.Bytes);
public long this[int i]=>Value[i];

public static A201972Inst Instance=new A201972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201973
{
public static readonly long[] Value={ 1L,2L,21L,5097L,71965235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201973Inst : IEnumerable<long>
{
public static readonly long[] Value=A201973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201973.Bytes);
public long this[int i]=>Value[i];

public static A201973Inst Instance=new A201973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201974
{
public static readonly long[] Value={ 4L,30L,1372L,408599L,858105364L,13486744809160L,1716349328902123738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201974Inst : IEnumerable<long>
{
public static readonly long[] Value=A201974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201974.Bytes);
public long this[int i]=>Value[i];

public static A201974Inst Instance=new A201974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201975
{
public static readonly long[] Value={ 4L,30L,72L,131L,208L,304L,420L,557L,716L,898L,1104L,1335L,1592L,1876L,2188L,2529L,2900L,3302L,3736L,4203L,4704L,5240L,5812L,6421L,7068L,7754L,8480L,9247L,10056L,10908L,11804L,12745L,13732L,14766L,15848L,16979L,18160L,19392L,20676L,22013L,23404L,24850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201975Inst : IEnumerable<long>
{
public static readonly long[] Value=A201975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201975.Bytes);
public long this[int i]=>Value[i];

public static A201975Inst Instance=new A201975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201976
{
public static readonly long[] Value={ 4L,72L,1372L,9260L,38112L,117744L,301612L,676792L,1375740L,2589832L,4584684L,7717252L,12454712L,19395120L,29289852L,43067824L,61861492L,87034632L,120211900L,163310172L,218571664L,288598832L,376391052L,485383080L,619485292L,783125704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201976Inst : IEnumerable<long>
{
public static readonly long[] Value=A201976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201976.Bytes);
public long this[int i]=>Value[i];

public static A201976Inst Instance=new A201976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201977
{
public static readonly long[] Value={ 4L,131L,9260L,408599L,8002304L,91893727L,729771318L,4412536785L,21616887220L,89573637672L,323882961806L,1046082959963L,3072688515840L,8324694513560L,21037789421604L,50045713319142L,112903666194660L,243057004503527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201977Inst : IEnumerable<long>
{
public static readonly long[] Value=A201977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201977.Bytes);
public long this[int i]=>Value[i];

public static A201977Inst Instance=new A201977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201978
{
public static readonly BigInteger[] Value={ 4L,208L,38112L,8002304L,858105364L,48452117136L,1706069013928L,41801237632858L,764295988745248L,10946853015640490L,127331263486979692L,1237140566105421398L,10270879068733905810UL,BigInteger.Parse("74243436332274681890") };
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
public class A201978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201978Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201978.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201978.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201978Inst Instance=new A201978Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201979
{
public static readonly BigInteger[] Value={ 4L,304L,117744L,91893727L,48452117136L,13486744809160L,2238761872232964L,248685266018356303L,BigInteger.Parse("19939344176339744246"),BigInteger.Parse("1214420344528171330419"),BigInteger.Parse("58291620982242700295226"),BigInteger.Parse("2267753515670520458933950") };
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
public class A201979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201979Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201979.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201979.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201979Inst Instance=new A201979Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201980
{
public static readonly long[] Value={ 4L,420L,301612L,729771318L,1706069013928L,2238761872232964L,1716349328902123738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201980Inst : IEnumerable<long>
{
public static readonly long[] Value=A201980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201980.Bytes);
public long this[int i]=>Value[i];

public static A201980Inst Instance=new A201980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201981
{
public static readonly long[] Value={ 4L,4L,4L,4L,30L,4L,4L,72L,72L,4L,4L,131L,1372L,131L,4L,4L,208L,9260L,9260L,208L,4L,4L,304L,38112L,408599L,38112L,304L,4L,4L,420L,117744L,8002304L,8002304L,117744L,420L,4L,4L,557L,301612L,91893727L,858105364L,91893727L,301612L,557L,4L,4L,716L,676792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201981Inst : IEnumerable<long>
{
public static readonly long[] Value=A201981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201981.Bytes);
public long this[int i]=>Value[i];

public static A201981Inst Instance=new A201981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201982
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,20L,30L,40L,50L,60L,70L,80L,90L,101L,102L,103L,104L,105L,106L,107L,108L,109L,111L,121L,131L,141L,151L,161L,171L,181L,191L,202L,203L,204L,205L,206L,207L,208L,209L,212L,222L,232L,242L,252L,262L,272L,282L,292L,303L,304L,305L,306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201982Inst : IEnumerable<long>
{
public static readonly long[] Value=A201982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201982.Bytes);
public long this[int i]=>Value[i];

public static A201982Inst Instance=new A201982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201983
{
public static readonly long[] Value={ 1L,77L,134217L,7375608084L,13189629907532856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201983Inst : IEnumerable<long>
{
public static readonly long[] Value=A201983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201983.Bytes);
public long this[int i]=>Value[i];

public static A201983Inst Instance=new A201983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201984
{
public static readonly long[] Value={ 4L,77L,1170L,14107L,139471L,1177568L,8721417L,57801225L,347923603L,1924356711L,9871703167L,47329086175L,213435856527L,910247506472L,3688234465315L,14255722610693L,52746861442115L,187406263165391L,641125854338628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201984Inst : IEnumerable<long>
{
public static readonly long[] Value=A201984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201984.Bytes);
public long this[int i]=>Value[i];

public static A201984Inst Instance=new A201984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201985
{
public static readonly BigInteger[] Value={ 8L,1170L,134217L,11648559L,803133854L,46034224561L,2263314310579L,97590406110264L,3751608445033000L,130228399017523112L,4123679601987935141L,BigInteger.Parse("120106074216408355193"),BigInteger.Parse("3240091181028424814518"),BigInteger.Parse("81435648130636028973623") };
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
public class A201985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201985Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201985.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201985.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201985Inst Instance=new A201985Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201986
{
public static readonly BigInteger[] Value={ 18L,14107L,11648559L,7375608084L,3674187761233L,1507315600099908L,526500713340421071L,BigInteger.Parse("160321266022658991751"),BigInteger.Parse("43304255513243305231273"),BigInteger.Parse("10515069913569825177115136"),BigInteger.Parse("2319701107323309166913311672") };
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
public class A201986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201986Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201986.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201986.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201986Inst Instance=new A201986Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201987
{
public static readonly BigInteger[] Value={ 32L,139471L,803133854L,3674187761233L,13189629907532856L,BigInteger.Parse("38785259210265819578") };
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
public class A201987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201987Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201987.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201987.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201987Inst Instance=new A201987Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201988
{
public static readonly BigInteger[] Value={ 58L,1177568L,46034224561L,1507315600099908L,BigInteger.Parse("38785259210265819578") };
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
public class A201988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201988Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201988.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201988.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201988Inst Instance=new A201988Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201989
{
public static readonly long[] Value={ 1L,4L,4L,8L,77L,8L,18L,1170L,1170L,18L,32L,14107L,134217L,14107L,32L,58L,139471L,11648559L,11648559L,139471L,58L,94L,1177568L,803133854L,7375608084L,803133854L,1177568L,94L,151L,8721417L,46034224561L,3674187761233L,3674187761233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201989Inst : IEnumerable<long>
{
public static readonly long[] Value=A201989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201989.Bytes);
public long this[int i]=>Value[i];

public static A201989Inst Instance=new A201989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201990
{
public static readonly BigInteger[] Value={ 1L,1L,7L,95L,1969L,55201L,1956375L,83935039L,4230528353L,245059707841L,16043680004903L,1171567218325151L,94415150206330641L,8323801562833775201L,BigInteger.Parse("796927800013656980791"),BigInteger.Parse("82342529545666235490431"),BigInteger.Parse("9132868398860301753027265"),BigInteger.Parse("1082287792241161814647419265") };
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
public class A201990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201990Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201990.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201990.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201990Inst Instance=new A201990Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201991
{
public static readonly long[] Value={ 0L,11L,44L,55L,77L,868L,69996L,2683862L,6783876L,268969862L,37889398873L,477788989887774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201991Inst : IEnumerable<long>
{
public static readonly long[] Value=A201991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201991.Bytes);
public long this[int i]=>Value[i];

public static A201991Inst Instance=new A201991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201992
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,10L,11L,12L,13L,18L,19L,20L,22L,25L,26L,37L,38L,41L,44L,45L,50L,51L,52L,75L,76L,77L,82L,83L,89L,90L,101L,102L,105L,150L,153L,154L,165L,166L,179L,180L,203L,205L,210L,211L,300L,301L,306L,308L,331L,332L,358L,361L,406L,410L,421L,422L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201992Inst : IEnumerable<long>
{
public static readonly long[] Value=A201992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201992.Bytes);
public long this[int i]=>Value[i];

public static A201992Inst Instance=new A201992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201993
{
public static readonly long[] Value={ 1L,2L,6L,11L,18L,26L,37L,49L,63L,79L,97L,116L,138L,161L,186L,213L,241L,272L,304L,338L,374L,412L,451L,492L,535L,580L,627L,676L,726L,778L,832L,888L,946L,1005L,1066L,1130L,1194L,1261L,1330L,1400L,1472L,1546L,1622L,1699L,1779L,1860L,1943L,2028L,2115L,2203L,2293L,2385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201993Inst : IEnumerable<long>
{
public static readonly long[] Value=A201993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201993.Bytes);
public long this[int i]=>Value[i];

public static A201993Inst Instance=new A201993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201994
{
public static readonly long[] Value={ 1L,9L,8L,9L,2L,8L,0L,2L,3L,4L,2L,9L,8L,9L,0L,1L,0L,2L,3L,4L,2L,0L,8L,5L,8L,6L,8L,7L,4L,2L,1L,5L,1L,6L,3L,8L,1L,4L,9L,4L,4L,6L,0L,7L,7L,0L,7L,4L,2L,5L,0L,2L,7L,0L,9L,0L,7L,8L,1L,5L,3L,9L,9L,2L,9L,2L,3L,0L,2L,5L,9L,4L,9L,3L,6L,3L,2L,3L,5L,4L,0L,2L,1L,1L,2L,6L,6L,8L,8L,8L,3L,4L,9L,0L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201994Inst : IEnumerable<long>
{
public static readonly long[] Value=A201994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201994.Bytes);
public long this[int i]=>Value[i];

public static A201994Inst Instance=new A201994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201995
{
public static readonly long[] Value={ 6L,0L,0L,0L,1L,4L,5L,8L,0L,2L,8L,4L,3L,0L,4L,4L,8L,6L,5L,6L,4L,3L,9L,4L,1L,2L,1L,7L,5L,3L,7L,8L,4L,8L,3L,8L,3L,7L,4L,0L,5L,8L,8L,6L,1L,5L,9L,4L,4L,5L,6L,8L,5L,8L,5L,0L,3L,5L,1L,0L,7L,9L,5L,0L,0L,8L,5L,9L,7L,4L,1L,6L,7L,4L,7L,5L,1L,0L,0L,3L,5L,9L,2L,4L,1L,5L,0L,3L,4L,2L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201995Inst : IEnumerable<long>
{
public static readonly long[] Value=A201995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201995.Bytes);
public long this[int i]=>Value[i];

public static A201995Inst Instance=new A201995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201996
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,252L,3000L,43380L,737730L,14419440L,318381840L,7835486400L,212634298800L,6307073942400L,202983948367200L,7044249755743200L,262198957638618000L,10419369722457696000UL,BigInteger.Parse("440257835691561888000"),BigInteger.Parse("19709455059507717504000"),BigInteger.Parse("931885122471464345184000"),BigInteger.Parse("46401644730376725229440000") };
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
public class A201996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201996Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201996.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201996.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201996Inst Instance=new A201996Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201997
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,16L,17L,18L,20L,21L,22L,23L,24L,25L,26L,32L,33L,34L,36L,37L,38L,39L,40L,41L,42L,44L,45L,46L,48L,49L,50L,52L,53L,54L,55L,56L,57L,58L,60L,64L,65L,66L,68L,69L,70L,71L,72L,73L,74L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201997Inst : IEnumerable<long>
{
public static readonly long[] Value=A201997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201997.Bytes);
public long this[int i]=>Value[i];

public static A201997Inst Instance=new A201997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201998
{
public static readonly long[] Value={ 244L,249L,251L,266L,270L,295L,301L,336L,344L,389L,399L,407L,416L,418L,445L,449L,454L,466L,489L,494L,496L,500L,506L,527L,531L,545L,547L,563L,570L,571L,582L,583L,585L,611L,612L,620L,622L,624L,628L,630L,636L,652L,661L,662L,663L,679L,693L,699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201998Inst : IEnumerable<long>
{
public static readonly long[] Value=A201998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201998.Bytes);
public long this[int i]=>Value[i];

public static A201998Inst Instance=new A201998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201999
{
public static readonly long[] Value={ 1L,9L,11L,43L,85L,329L,577L,1921L,4115L,14331L,32631L,106527L,262481L,833225L,2118711L,6523351L,17225857L,52322449L,141538657L,424472841L,1171251495L,3484084667L,9746606361L,28817241129L,81509487175L,240107776015L,684814280371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201999Inst : IEnumerable<long>
{
public static readonly long[] Value=A201999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201999.Bytes);
public long this[int i]=>Value[i];

public static A201999Inst Instance=new A201999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202000
{
public static readonly long[] Value={ 1L,25L,31L,247L,799L,4281L,15751L,61581L,267037L,1298599L,5618731L,25891377L,121559461L,569107129L,2632371325L,12330807475L,58079266349L,275266138925L,1306176923689L,6218631031361L,29703202000153L,142156751690535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202000Inst : IEnumerable<long>
{
public static readonly long[] Value=A202000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202000.Bytes);
public long this[int i]=>Value[i];

public static A202000Inst Instance=new A202000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202001
{
public static readonly long[] Value={ 1L,49L,61L,601L,2605L,22865L,101395L,657871L,3603821L,25726609L,150646627L,1027976993L,6463089721L,43715824593L,278513680357L,1863303355141L,12132105992613L,81455933000439L,537677650826359L,3614341859258835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202001Inst : IEnumerable<long>
{
public static readonly long[] Value=A202001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202001.Bytes);
public long this[int i]=>Value[i];

public static A202001Inst Instance=new A202001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202002
{
public static readonly long[] Value={ 1L,81L,101L,1357L,7463L,80065L,490879L,3697331L,28156261L,240962805L,1907124597L,16026836953L,133898693111L,1130246507329L,9448228560881L,79776887571979L,675881669398761L,5767799951404371L,49328839761741989L,423380827767076411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202002Inst : IEnumerable<long>
{
public static readonly long[] Value=A202002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202002.Bytes);
public long this[int i]=>Value[i];

public static A202002Inst Instance=new A202002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202003
{
public static readonly long[] Value={ 1L,121L,111L,2467L,14365L,221433L,1519417L,14540551L,130169953L,1459090675L,13589734965L,144206621427L,1452277199421L,15257211367065L,154052512468551L,1608600212618455L,16545700784493591L,173783329255817551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202003Inst : IEnumerable<long>
{
public static readonly long[] Value=A202003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202003.Bytes);
public long this[int i]=>Value[i];

public static A202003Inst Instance=new A202003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202004
{
public static readonly long[] Value={ 1L,169L,231L,4327L,33699L,511257L,4460689L,48525711L,529141383L,6524977447L,74784050095L,908188232827L,10930623434631L,133367299797625L,1609848080492237L,19647665104267177L,240376888100965909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202004Inst : IEnumerable<long>
{
public static readonly long[] Value=A202004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202004.Bytes);
public long this[int i]=>Value[i];

public static A202004Inst Instance=new A202004Inst();

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