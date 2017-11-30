using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A111941
{
public static readonly long[] Value={ 0L,1L,0L,-1L,-1L,0L,1L,1L,1L,0L,-2L,-1L,-1L,-1L,0L,4L,2L,1L,1L,1L,0L,-12L,-4L,-2L,-1L,-1L,-1L,0L,36L,12L,4L,2L,1L,1L,1L,0L,-144L,-36L,-12L,-4L,-2L,-1L,-1L,-1L,0L,576L,144L,36L,12L,4L,2L,1L,1L,1L,0L,-2880L,-576L,-144L,-36L,-12L,-4L,-2L,-1L,-1L,-1L,0L,14400L,2880L,576L,144L,36L,12L,4L,2L,1L,1L,1L,0L,-86400L,-14400L,-2880L,-576L,-144L,-36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111941Inst : IEnumerable<long>
{
public static readonly long[] Value=A111941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111941.Bytes);
public long this[int i]=>Value[i];

public static A111941Inst Instance=new A111941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111942
{
public static readonly long[] Value={ 0L,1L,-1L,1L,-2L,4L,-12L,36L,-144L,576L,-2880L,14400L,-86400L,518400L,-3628800L,25401600L,-203212800L,1625702400L,-14631321600L,131681894400L,-1316818944000L,13168189440000L,-144850083840000L,1593350922240000L,-19120211066880000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111942Inst : IEnumerable<long>
{
public static readonly long[] Value=A111942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111942.Bytes);
public long this[int i]=>Value[i];

public static A111942Inst Instance=new A111942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111943
{
public static readonly long[] Value={ 23L,113L,1327L,31397L,370261L,2010733L,20831323L,25056082087L,2614941710599L,19581334192423L,218209405436543L,1693182318746371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111943Inst : IEnumerable<long>
{
public static readonly long[] Value=A111943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111943.Bytes);
public long this[int i]=>Value[i];

public static A111943Inst Instance=new A111943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111944
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,2L,1L,3L,3L,2L,4L,2L,3L,4L,1L,3L,5L,2L,4L,5L,3L,2L,5L,3L,3L,4L,4L,2L,7L,2L,1L,4L,5L,6L,7L,2L,3L,6L,5L,3L,9L,2L,4L,9L,3L,2L,6L,3L,5L,4L,4L,2L,7L,6L,5L,4L,3L,2L,10L,2L,3L,6L,1L,5L,7L,2L,7L,6L,11L,2L,9L,3L,3L,7L,4L,6L,11L,2L,6L,5L,5L,2L,13L,6L,3L,5L,5L,2L,17L,5L,4L,6L,3L,6L,7L,3L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111944Inst : IEnumerable<long>
{
public static readonly long[] Value=A111944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111944.Bytes);
public long this[int i]=>Value[i];

public static A111944Inst Instance=new A111944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111945
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,5L,3L,1L,7L,5L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111945Inst : IEnumerable<long>
{
public static readonly long[] Value=A111945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111945.Bytes);
public long this[int i]=>Value[i];

public static A111945Inst Instance=new A111945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111946
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,5L,1L,1L,2L,1L,1L,8L,1L,1L,1L,1L,1L,1L,13L,1L,1L,1L,3L,1L,1L,1L,21L,1L,1L,2L,1L,1L,2L,1L,1L,34L,1L,1L,1L,1L,5L,1L,1L,1L,1L,55L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,89L,1L,1L,2L,3L,1L,8L,1L,3L,2L,1L,1L,144L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111946Inst : IEnumerable<long>
{
public static readonly long[] Value=A111946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111946.Bytes);
public long this[int i]=>Value[i];

public static A111946Inst Instance=new A111946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111947
{
public static readonly long[] Value={ 12L,20L,24L,30L,40L,42L,54L,70L,84L,102L,114L,120L,140L,222L,224L,234L,270L,308L,364L,402L,476L,644L,1002L,1148L,1204L,1638L,1652L,2022L,2202L,2212L,3164L,3250L,3472L,4172L,6200L,7588L,8204L,8432L,8596L,9424L,10002L,10014L,10724L,10792L,11202L,11228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111947Inst : IEnumerable<long>
{
public static readonly long[] Value=A111947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111947.Bytes);
public long this[int i]=>Value[i];

public static A111947Inst Instance=new A111947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111948
{
public static readonly long[] Value={ 24L,42L,114L,222L,402L,2022L,2202L,7588L,8596L,10014L,11202L,12102L,17668L,21102L,27748L,29764L,31002L,32788L,39844L,42868L,43876L,45388L,46396L,48916L,49924L,55972L,56476L,57484L,58492L,65548L,66556L,69076L,70588L,71596L,78148L,81676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111948Inst : IEnumerable<long>
{
public static readonly long[] Value=A111948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111948.Bytes);
public long this[int i]=>Value[i];

public static A111948Inst Instance=new A111948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111949
{
public static readonly long[] Value={ 1L,-1L,-2L,1L,1L,2L,-2L,-1L,3L,-1L,0L,-2L,0L,2L,-2L,1L,0L,-3L,0L,1L,4L,0L,-2L,2L,1L,0L,-4L,-2L,2L,2L,0L,-1L,0L,0L,-2L,3L,0L,0L,0L,-1L,2L,-4L,-2L,0L,3L,2L,-2L,-2L,3L,-1L,0L,0L,0L,4L,0L,2L,0L,-2L,0L,-2L,2L,0L,-6L,1L,0L,0L,-2L,0L,4L,2L,0L,-3L,0L,0L,-2L,0L,0L,0L,0L,1L,5L,-2L,-2L,4L,0L,2L,-4L,0L,2L,-3L,0L,-2L,0L,2L,0L,2L,0L,-3L,0L,1L,2L,0L,-2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111949Inst : IEnumerable<long>
{
public static readonly long[] Value=A111949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111949.Bytes);
public long this[int i]=>Value[i];

public static A111949Inst Instance=new A111949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111950
{
public static readonly long[] Value={ 3L,5L,5L,9419L,909287L,325267931L,678771479L,1107819732821L,170669145704411L,3324648277099157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111950Inst : IEnumerable<long>
{
public static readonly long[] Value=A111950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111950.Bytes);
public long this[int i]=>Value[i];

public static A111950Inst Instance=new A111950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111951
{
public static readonly long[] Value={ 0L,3L,1L,2L,2L,1L,3L,0L,0L,3L,1L,2L,2L,1L,3L,0L,0L,3L,1L,2L,2L,1L,3L,0L,0L,3L,1L,2L,2L,1L,3L,0L,0L,3L,1L,2L,2L,1L,3L,0L,0L,3L,1L,2L,2L,1L,3L,0L,0L,3L,1L,2L,2L,1L,3L,0L,0L,3L,1L,2L,2L,1L,3L,0L,0L,3L,1L,2L,2L,1L,3L,0L,0L,3L,1L,2L,2L,1L,3L,0L,0L,3L,1L,2L,2L,1L,3L,0L,0L,3L,1L,2L,2L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111951Inst : IEnumerable<long>
{
public static readonly long[] Value=A111951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111951.Bytes);
public long this[int i]=>Value[i];

public static A111951Inst Instance=new A111951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111952
{
public static readonly long[] Value={ 0L,3L,6L,2L,5L,1L,4L,0L,3L,6L,2L,5L,1L,4L,0L,3L,6L,2L,5L,1L,4L,0L,3L,6L,2L,5L,1L,4L,0L,3L,6L,2L,5L,1L,4L,0L,3L,6L,2L,5L,1L,4L,0L,3L,6L,2L,5L,1L,4L,0L,3L,6L,2L,5L,1L,4L,0L,3L,6L,2L,5L,1L,4L,0L,3L,6L,2L,5L,1L,4L,0L,3L,6L,2L,5L,1L,4L,0L,3L,6L,2L,5L,1L,4L,0L,3L,6L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111952Inst : IEnumerable<long>
{
public static readonly long[] Value=A111952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111952.Bytes);
public long this[int i]=>Value[i];

public static A111952Inst Instance=new A111952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111953
{
public static readonly long[] Value={ 2L,7L,0L,0L,7L,9L,7L,2L,3L,3L,1L,0L,9L,5L,1L,6L,4L,9L,7L,8L,3L,4L,3L,1L,9L,7L,9L,0L,0L,0L,0L,6L,3L,2L,2L,7L,2L,9L,1L,0L,5L,9L,3L,1L,0L,9L,1L,2L,7L,2L,9L,9L,1L,9L,9L,9L,8L,5L,2L,0L,2L,2L,9L,1L,9L,1L,1L,5L,8L,7L,4L,1L,8L,6L,1L,7L,0L,1L,5L,7L,0L,8L,4L,0L,4L,2L,4L,5L,7L,0L,0L,8L,1L,7L,4L,3L,4L,6L,8L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111953Inst : IEnumerable<long>
{
public static readonly long[] Value=A111953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111953.Bytes);
public long this[int i]=>Value[i];

public static A111953Inst Instance=new A111953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111954
{
public static readonly long[] Value={ 1L,0L,3L,4L,13L,28L,71L,168L,409L,984L,2379L,5740L,13861L,33460L,80783L,195024L,470833L,1136688L,2744211L,6625108L,15994429L,38613964L,93222359L,225058680L,543339721L,1311738120L,3166815963L,7645370044L,18457556053L,44560482148L,107578520351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111954Inst : IEnumerable<long>
{
public static readonly long[] Value=A111954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111954.Bytes);
public long this[int i]=>Value[i];

public static A111954Inst Instance=new A111954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111955
{
public static readonly long[] Value={ 0L,1L,4L,7L,20L,45L,112L,267L,648L,1561L,3772L,9103L,21980L,53061L,128104L,309267L,746640L,1802545L,4351732L,10506007L,25363748L,61233501L,147830752L,356895003L,861620760L,2080136521L,5021893804L,12123924127L,29269742060L,70663408245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111955Inst : IEnumerable<long>
{
public static readonly long[] Value=A111955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111955.Bytes);
public long this[int i]=>Value[i];

public static A111955Inst Instance=new A111955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111956
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,4L,1L,1L,1L,7L,1L,1L,1L,1L,11L,1L,3L,2L,1L,1L,18L,1L,1L,1L,1L,1L,1L,29L,1L,1L,1L,1L,1L,1L,1L,47L,1L,1L,4L,1L,1L,2L,1L,1L,76L,1L,3L,1L,1L,1L,3L,1L,1L,1L,123L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,199L,1L,1L,2L,7L,1L,2L,1L,1L,2L,1L,1L,322L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111956Inst : IEnumerable<long>
{
public static readonly long[] Value=A111956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111956.Bytes);
public long this[int i]=>Value[i];

public static A111956Inst Instance=new A111956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111957
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,7L,1L,3L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,11L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,4L,1L,1L,18L,1L,1L,4L,3L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,29L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111957Inst : IEnumerable<long>
{
public static readonly long[] Value=A111957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111957.Bytes);
public long this[int i]=>Value[i];

public static A111957Inst Instance=new A111957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111958
{
public static readonly long[] Value={ 2L,1L,3L,4L,7L,3L,2L,5L,7L,4L,3L,7L,2L,1L,3L,4L,7L,3L,2L,5L,7L,4L,3L,7L,2L,1L,3L,4L,7L,3L,2L,5L,7L,4L,3L,7L,2L,1L,3L,4L,7L,3L,2L,5L,7L,4L,3L,7L,2L,1L,3L,4L,7L,3L,2L,5L,7L,4L,3L,7L,2L,1L,3L,4L,7L,3L,2L,5L,7L,4L,3L,7L,2L,1L,3L,4L,7L,3L,2L,5L,7L,4L,3L,7L,2L,1L,3L,4L,7L,3L,2L,5L,7L,4L,3L,7L,2L,1L,3L,4L,7L,3L,2L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111958Inst : IEnumerable<long>
{
public static readonly long[] Value=A111958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111958.Bytes);
public long this[int i]=>Value[i];

public static A111958Inst Instance=new A111958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111959
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,0L,4L,0L,1L,6L,0L,6L,0L,1L,0L,16L,0L,8L,0L,1L,20L,0L,30L,0L,10L,0L,1L,0L,64L,0L,48L,0L,12L,0L,1L,70L,0L,140L,0L,70L,0L,14L,0L,1L,0L,256L,0L,256L,0L,96L,0L,16L,0L,1L,252L,0L,630L,0L,420L,0L,126L,0L,18L,0L,1L,0L,1024L,0L,1280L,0L,640L,0L,160L,0L,20L,0L,1L,924L,0L,2772L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111959Inst : IEnumerable<long>
{
public static readonly long[] Value=A111959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111959.Bytes);
public long this[int i]=>Value[i];

public static A111959Inst Instance=new A111959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111960
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,7L,7L,3L,1L,19L,20L,12L,4L,1L,51L,61L,40L,18L,5L,1L,141L,182L,135L,68L,25L,6L,1L,393L,547L,441L,251L,105L,33L,7L,1L,1107L,1640L,1428L,888L,420L,152L,42L,8L,1L,3139L,4921L,4572L,3076L,1596L,654L,210L,52L,9L,1L,8953L,14762L,14535L,10456L,5880L,2652L,966L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111960Inst : IEnumerable<long>
{
public static readonly long[] Value=A111960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111960.Bytes);
public long this[int i]=>Value[i];

public static A111960Inst Instance=new A111960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111961
{
public static readonly long[] Value={ 1L,2L,6L,18L,56L,176L,558L,1778L,5686L,18230L,58558L,188366L,606588L,1955044L,6305418L,20347342L,65689088L,212146400L,685342218L,2214556478L,7157409064L,23136645472L,74801223162L,241863933094L,782131232390L,2529458676326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111961Inst : IEnumerable<long>
{
public static readonly long[] Value=A111961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111961.Bytes);
public long this[int i]=>Value[i];

public static A111961Inst Instance=new A111961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111962
{
public static readonly long[] Value={ 1L,1L,4L,9L,27L,74L,215L,619L,1808L,5293L,15579L,45986L,136141L,403937L,1200854L,3575835L,10663105L,31836508L,95156251L,284684303L,852427700L,2554346249L,7659427811L,22981483554L,68992151795L,207223579671L,622697586944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111962Inst : IEnumerable<long>
{
public static readonly long[] Value=A111962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111962.Bytes);
public long this[int i]=>Value[i];

public static A111962Inst Instance=new A111962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111963
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-2L,1L,3L,-1L,-3L,1L,1L,8L,0L,-4L,1L,-9L,-3L,14L,2L,-5L,1L,1L,-26L,-15L,20L,5L,-6L,1L,27L,27L,-45L,-37L,25L,9L,-7L,1L,-13L,76L,98L,-56L,-70L,28L,14L,-8L,1L,-81L,-135L,108L,228L,-46L,-114L,28L,20L,-9L,1L,67L,-202L,-459L,48L,420L,0L,-168L,24L,27L,-10L,1L,243L,567L,-135L,-1035L,-210L,662L,98L,-230L,15L,35L,-11L,1L,-285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111963Inst : IEnumerable<long>
{
public static readonly long[] Value=A111963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111963.Bytes);
public long this[int i]=>Value[i];

public static A111963Inst Instance=new A111963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111964
{
public static readonly long[] Value={ 1L,-1L,0L,1L,1L,-4L,-1L,11L,2L,-35L,-1L,112L,-9L,-369L,66L,1237L,-327L,-4212L,1433L,14527L,-5926L,-50659L,23749L,178356L,-93427L,-633225L,363342L,2264885L,-1402803L,-8154564L,5390861L,29534183L,-20655948L,-107538835L,79005679L,393462584L,-301884895L,-1445937945L,1153012596L,5335046209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111964Inst : IEnumerable<long>
{
public static readonly long[] Value=A111964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111964.Bytes);
public long this[int i]=>Value[i];

public static A111964Inst Instance=new A111964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111965
{
public static readonly long[] Value={ 1L,3L,1L,11L,6L,1L,45L,31L,9L,1L,195L,156L,60L,12L,1L,873L,781L,360L,98L,15L,1L,3989L,3906L,2055L,684L,145L,18L,1L,18483L,19531L,11403L,4395L,1155L,201L,21L,1L,86515L,97656L,62132L,26856L,8260L,1800L,266L,24L,1L,408105L,488281L,334260L,158692L,55188L,14190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111965Inst : IEnumerable<long>
{
public static readonly long[] Value=A111965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111965.Bytes);
public long this[int i]=>Value[i];

public static A111965Inst Instance=new A111965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111966
{
public static readonly long[] Value={ 1L,4L,18L,86L,424L,2128L,10798L,55190L,283510L,1461730L,7557166L,39153338L,203188892L,1055863564L,5492668906L,28598497610L,149012237696L,776904940576L,4052654604042L,21149661562298L,110415949871240L,576636302495488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111966Inst : IEnumerable<long>
{
public static readonly long[] Value=A111966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111966.Bytes);
public long this[int i]=>Value[i];

public static A111966Inst Instance=new A111966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111967
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,1L,-1L,1L,0L,0L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,0L,0L,0L,0L,-1L,1L,0L,1L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111967Inst : IEnumerable<long>
{
public static readonly long[] Value=A111967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111967.Bytes);
public long this[int i]=>Value[i];

public static A111967Inst Instance=new A111967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111968
{
public static readonly BigInteger[] Value={ 1L,9L,325L,17577L,1152501L,84505509L,6664647781L,553268669865L,47710914870133L,4236909872278509L,385139801423145825L,BigInteger.Parse("35681384898462925125"),BigInteger.Parse("3358273513450241419125"),BigInteger.Parse("320308335005997679093125"),BigInteger.Parse("30900030366269721747776325"),BigInteger.Parse("3010365811746267487293617577") };
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
public class A111968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111968Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111968.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111968Inst Instance=new A111968Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111969
{
public static readonly long[] Value={ 6L,7L,4L,9L,8L,1L,4L,4L,2L,9L,3L,0L,1L,0L,4L,7L,0L,3L,6L,8L,8L,4L,9L,5L,8L,3L,1L,8L,5L,1L,4L,0L,0L,2L,8L,8L,9L,8L,0L,2L,9L,7L,7L,3L,2L,2L,7L,8L,0L,2L,6L,6L,1L,0L,7L,2L,2L,7L,9L,3L,8L,7L,9L,2L,4L,4L,6L,4L,9L,8L,1L,1L,1L,3L,1L,3L,2L,4L,1L,3L,4L,0L,5L,2L,6L,3L,9L,3L,7L,8L,2L,5L,5L,5L,1L,3L,3L,7L,7L,1L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111969Inst : IEnumerable<long>
{
public static readonly long[] Value=A111969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111969.Bytes);
public long this[int i]=>Value[i];

public static A111969Inst Instance=new A111969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111970
{
public static readonly long[] Value={ 3L,4L,3L,7L,7L,1L,4L,5L,3L,0L,2L,5L,6L,7L,2L,7L,5L,3L,6L,6L,9L,1L,6L,7L,9L,2L,4L,4L,2L,9L,0L,5L,5L,6L,0L,0L,9L,9L,5L,2L,3L,6L,5L,1L,9L,3L,2L,9L,5L,6L,8L,5L,9L,7L,8L,5L,8L,5L,6L,4L,0L,5L,2L,5L,7L,3L,2L,3L,3L,4L,4L,0L,1L,9L,5L,3L,5L,9L,1L,5L,1L,0L,8L,2L,4L,2L,9L,1L,1L,6L,0L,8L,2L,1L,1L,5L,0L,4L,6L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111970Inst : IEnumerable<long>
{
public static readonly long[] Value=A111970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111970.Bytes);
public long this[int i]=>Value[i];

public static A111970Inst Instance=new A111970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111971
{
public static readonly long[] Value={ 9L,3L,9L,0L,5L,3L,3L,4L,6L,7L,7L,2L,4L,9L,1L,7L,6L,5L,7L,3L,3L,9L,7L,5L,4L,0L,7L,3L,0L,7L,8L,5L,3L,7L,3L,5L,5L,4L,0L,1L,7L,3L,2L,9L,4L,7L,6L,1L,6L,9L,3L,5L,8L,0L,8L,8L,8L,1L,9L,3L,7L,0L,2L,5L,0L,8L,5L,1L,6L,8L,0L,6L,5L,3L,8L,0L,8L,3L,6L,2L,7L,3L,3L,4L,7L,6L,8L,2L,7L,5L,8L,6L,4L,8L,9L,5L,4L,1L,7L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111971Inst : IEnumerable<long>
{
public static readonly long[] Value=A111971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111971.Bytes);
public long this[int i]=>Value[i];

public static A111971Inst Instance=new A111971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111972
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111972Inst : IEnumerable<long>
{
public static readonly long[] Value=A111972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111972.Bytes);
public long this[int i]=>Value[i];

public static A111972Inst Instance=new A111972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111973
{
public static readonly long[] Value={ 1L,2L,4L,6L,6L,8L,8L,6L,13L,12L,12L,24L,14L,16L,24L,6L,18L,26L,20L,36L,32L,24L,24L,24L,31L,28L,40L,48L,30L,48L,32L,6L,48L,36L,48L,78L,38L,40L,56L,36L,42L,64L,44L,72L,78L,48L,48L,24L,57L,62L,72L,84L,54L,80L,72L,48L,80L,60L,60L,144L,62L,64L,104L,6L,84L,96L,68L,108L,96L,96L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111973Inst : IEnumerable<long>
{
public static readonly long[] Value=A111973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111973.Bytes);
public long this[int i]=>Value[i];

public static A111973Inst Instance=new A111973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111974
{
public static readonly BigInteger[] Value={ 3L,7L,19L,163L,487L,1459L,39367L,86093443L,258280327L,411782264189299L,BigInteger.Parse("116299474006080119380780339"),BigInteger.Parse("3140085798164163223281069127"),BigInteger.Parse("84782316550432407028588866403"),BigInteger.Parse("20602102921755074907947094535687") };
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
public class A111974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111974Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111974.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111974Inst Instance=new A111974Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111975
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,4L,4L,4L,1L,16L,16L,16L,8L,1L,96L,96L,96L,64L,16L,1L,896L,896L,896L,704L,256L,32L,1L,13568L,13568L,13568L,11776L,5504L,1024L,64L,1L,345088L,345088L,345088L,317952L,178176L,43776L,4096L,128L,1L,15112192L,15112192L,15112192L,14422016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111975Inst : IEnumerable<long>
{
public static readonly long[] Value=A111975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111975.Bytes);
public long this[int i]=>Value[i];

public static A111975Inst Instance=new A111975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111976
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,16L,96L,896L,13568L,345088L,15112192L,1159913472L,158164664320L,38737429987328L,17197276791701504L,13946909814794223616UL,BigInteger.Parse("20801835304287183306752"),BigInteger.Parse("57394078732651064041930752") };
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
public class A111976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111976Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111976.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111976Inst Instance=new A111976Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111977
{
public static readonly BigInteger[] Value={ 1L,2L,4L,13L,57L,369L,3681L,59073L,1579393L,72188673L,5749089793L,809616264193L,204018868459521L,92907742733348865L,BigInteger.Parse("77097057406948106241"),BigInteger.Parse("117413997231333438701569"),BigInteger.Parse("330195264668839727287861249") };
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
public class A111977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111977Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111977.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111977Inst Instance=new A111977Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111978
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,0L,16L,0L,4L,0L,0L,32L,0L,8L,0L,1536L,0L,64L,0L,16L,0L,0L,3072L,0L,128L,0L,32L,0L,-319488L,0L,6144L,0L,256L,0L,64L,0L,0L,-638976L,0L,12288L,0L,512L,0L,128L,0L,36007575552L,0L,-1277952L,0L,24576L,0L,1024L,0L,256L,0L,0L,72015151104L,0L,-2555904L,0L,49152L,0L,2048L,0L,512L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111978Inst : IEnumerable<long>
{
public static readonly long[] Value=A111978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111978.Bytes);
public long this[int i]=>Value[i];

public static A111978Inst Instance=new A111978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111979
{
public static readonly BigInteger[] Value={ 0L,1L,0L,16L,0L,1536L,0L,-319488L,0L,36007575552L,0L,-53682434054553600L,0L,BigInteger.Parse("1790644857560674043166720"),0L,BigInteger.Parse("-1280831660558056667387645027942400"),0L,BigInteger.Parse("18961467116136182692294341450867551502336000"),0L };
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
public class A111979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111979Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111979.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111979Inst Instance=new A111979Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111980
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,23L,37L,41L,43L,47L,67L,71L,79L,83L,97L,101L,103L,107L,109L,113L,127L,131L,163L,167L,193L,197L,223L,227L,229L,233L,277L,281L,307L,311L,313L,317L,349L,353L,379L,383L,397L,401L,439L,443L,457L,461L,463L,467L,487L,491L,499L,503L,613L,617L,643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111980Inst : IEnumerable<long>
{
public static readonly long[] Value=A111980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111980.Bytes);
public long this[int i]=>Value[i];

public static A111980Inst Instance=new A111980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111981
{
public static readonly long[] Value={ 4L,7L,10L,19L,22L,34L,40L,49L,52L,55L,64L,82L,97L,112L,115L,139L,154L,157L,175L,190L,199L,220L,229L,232L,244L,250L,307L,322L,337L,370L,379L,385L,412L,427L,430L,439L,442L,454L,469L,484L,505L,544L,547L,607L,640L,649L,652L,712L,715L,724L,742L,745L,775L,784L,790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111981Inst : IEnumerable<long>
{
public static readonly long[] Value=A111981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111981.Bytes);
public long this[int i]=>Value[i];

public static A111981Inst Instance=new A111981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111982
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,4L,2L,5L,2L,4L,2L,6L,2L,4L,2L,7L,2L,4L,2L,6L,2L,4L,2L,8L,2L,4L,2L,6L,2L,4L,2L,9L,2L,4L,2L,6L,2L,4L,2L,8L,2L,4L,2L,6L,2L,4L,2L,10L,2L,4L,2L,6L,2L,4L,2L,8L,2L,4L,2L,6L,2L,4L,2L,11L,2L,4L,2L,6L,2L,4L,2L,8L,2L,4L,2L,6L,2L,4L,2L,10L,2L,4L,2L,6L,2L,4L,2L,8L,2L,4L,2L,6L,2L,4L,2L,12L,2L,4L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111982Inst : IEnumerable<long>
{
public static readonly long[] Value=A111982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111982.Bytes);
public long this[int i]=>Value[i];

public static A111982Inst Instance=new A111982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111983
{
public static readonly long[] Value={ 1L,24L,0L,320L,0L,0L,3584L,0L,0L,0L,36864L,0L,0L,0L,0L,360448L,0L,0L,0L,0L,0L,3407872L,0L,0L,0L,0L,0L,0L,31457280L,0L,0L,0L,0L,0L,0L,0L,285212672L,0L,0L,0L,0L,0L,0L,0L,0L,2550136832L,0L,0L,0L,0L,0L,0L,0L,0L,0L,22548578304L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,197568495616L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111983Inst : IEnumerable<long>
{
public static readonly long[] Value=A111983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111983.Bytes);
public long this[int i]=>Value[i];

public static A111983Inst Instance=new A111983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111984
{
public static readonly BigInteger[] Value={ 1L,8L,-64L,960L,-15360L,274432L,-5223936L,103604224L,-2115993600L,44188631040L,-939004514304L,20235083907072L,-441102457372672L,9708551114588160L,-215436164616683520L,4814308934865944576L,BigInteger.Parse("-108243166106365722624"),BigInteger.Parse("2446764246113433157632") };
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
public class A111984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111984Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111984.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111984Inst Instance=new A111984Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111985
{
public static readonly BigInteger[] Value={ 1L,2L,-22L,364L,-6490L,124476L,-2501116L,51848984L,-1099502074L,23722687340L,-518856745492L,11473878455400L,-256044198076836L,5757405060992728L,-130302582530068280L,2965537736183034672L,BigInteger.Parse("-67820940980720843322"),BigInteger.Parse("1557676412999229945932") };
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
public class A111985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111985Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111985.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111985Inst Instance=new A111985Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111986
{
public static readonly long[] Value={ 1L,3L,2L,5L,0L,5L,2L,6L,2L,1L,2L,12L,0L,4L,1L,6L,0L,6L,1L,3L,4L,7L,1L,17L,0L,0L,3L,7L,0L,6L,2L,6L,3L,1L,0L,15L,1L,3L,0L,6L,0L,11L,0L,14L,3L,1L,0L,24L,2L,0L,1L,1L,1L,10L,1L,8L,3L,0L,0L,13L,0L,5L,5L,7L,0L,10L,0L,3L,2L,3L,0L,26L,0L,3L,1L,6L,4L,0L,2L,9L,3L,1L,0L,25L,0L,0L,2L,18L,0L,13L,1L,3L,4L,0L,0L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111986Inst : IEnumerable<long>
{
public static readonly long[] Value=A111986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111986.Bytes);
public long this[int i]=>Value[i];

public static A111986Inst Instance=new A111986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111987
{
public static readonly long[] Value={ 1L,2L,5L,6L,0L,10L,13L,14L,17L,19L,25L,22L,0L,26L,29L,31L,0L,34L,37L,38L,41L,43L,128L,46L,0L,0L,53L,78L,0L,58L,61L,62L,135L,67L,0L,71L,73L,74L,0L,79L,0L,82L,0L,86L,89L,384L,0L,94L,97L,0L,101L,103L,125L,106L,109L,121L,113L,0L,0L,118L,0L,122L,205L,127L,0L,131L,0L,134L,137L,139L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111987Inst : IEnumerable<long>
{
public static readonly long[] Value=A111987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111987.Bytes);
public long this[int i]=>Value[i];

public static A111987Inst Instance=new A111987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111988
{
public static readonly long[] Value={ 1L,4L,8L,16L,0L,24L,32L,48L,40L,19L,27L,80L,0L,96L,29L,144L,0L,120L,37L,76L,160L,108L,128L,240L,0L,0L,136L,288L,0L,152L,81L,336L,216L,67L,0L,360L,73L,148L,0L,304L,0L,480L,0L,432L,232L,384L,0L,720L,416L,0L,101L,103L,125L,440L,109L,672L,296L,0L,0L,464L,0L,324L,544L,1008L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111988Inst : IEnumerable<long>
{
public static readonly long[] Value=A111988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111988.Bytes);
public long this[int i]=>Value[i];

public static A111988Inst Instance=new A111988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111989
{
public static readonly long[] Value={ 1L,6L,36L,208L,1200L,6912L,39808L,229248L,1320192L,7602688L,43782144L,252131328L,1451966464L,8361541632L,48152199168L,277297463296L,1596892446720L,9196137086976L,52958442815488L,304975517319168L,1756284007219200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111989Inst : IEnumerable<long>
{
public static readonly long[] Value=A111989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111989.Bytes);
public long this[int i]=>Value[i];

public static A111989Inst Instance=new A111989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111990
{
public static readonly long[] Value={ 1L,12L,108L,848L,6192L,43200L,292224L,1933056L,12572928L,80702464L,512532480L,3226742784L,20166803456L,125262102528L,773910872064L,4759428268032L,29151365234688L,177913041518592L,1082361265782784L,6565932190138368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111990Inst : IEnumerable<long>
{
public static readonly long[] Value=A111990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111990.Bytes);
public long this[int i]=>Value[i];

public static A111990Inst Instance=new A111990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111991
{
public static readonly long[] Value={ 1L,18L,216L,2136L,18864L,154656L,1203072L,9000576L,65339136L,463112704L,3219204096L,22019254272L,148577427456L,990973034496L,6543595044864L,42832379117568L,278217855664128L,1794871415144448L,11508930723708928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111991Inst : IEnumerable<long>
{
public static readonly long[] Value=A111991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111991.Bytes);
public long this[int i]=>Value[i];

public static A111991Inst Instance=new A111991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111992
{
public static readonly long[] Value={ 1L,5L,10L,77L,26L,223L,988L,3909L,748L,55991L,5084L,785633L,124658L,207061L,1096792L,29889983L,1893246L,197698279L,85352744L,154834887L,47589202L,325333835L,1188897016L,7612795845L,5775510652L,183259245573L,33778670612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111992Inst : IEnumerable<long>
{
public static readonly long[] Value=A111992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111992.Bytes);
public long this[int i]=>Value[i];

public static A111992Inst Instance=new A111992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111993
{
public static readonly long[] Value={ 1L,5L,25L,125L,630L,3206L,16470L,85350L,445775L,2344595L,12408903L,66042795L,353259900L,1898119100L,10240583420L,55454182716L,301307002605L,1642192132625L,8975693643525L,49186242980105L,270186765784210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111993Inst : IEnumerable<long>
{
public static readonly long[] Value=A111993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111993.Bytes);
public long this[int i]=>Value[i];

public static A111993Inst Instance=new A111993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111994
{
public static readonly long[] Value={ 1L,6L,33L,176L,930L,4908L,25954L,137712L,733539L,3922834L,21060099L,113481504L,613619332L,3328768344L,18112655748L,98833261600L,540705999621L,2965360687518L,16299708148901L,89784615643728L,495545294427558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111994Inst : IEnumerable<long>
{
public static readonly long[] Value=A111994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111994.Bytes);
public long this[int i]=>Value[i];

public static A111994Inst Instance=new A111994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111995
{
public static readonly long[] Value={ 1L,7L,42L,238L,1316L,7196L,39158L,212738L,1155889L,6287015L,34249404L,186920468L,1022134288L,5600420336L,30745867316L,169116129308L,931937277257L,5144687596447L,28449040406262L,157571572143538L,874089046798212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111995Inst : IEnumerable<long>
{
public static readonly long[] Value=A111995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111995.Bytes);
public long this[int i]=>Value[i];

public static A111995Inst Instance=new A111995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111996
{
public static readonly long[] Value={ 1L,8L,52L,312L,1802L,10200L,57092L,317544L,1760035L,9738160L,53844184L,297717712L,1646893140L,9116815952L,50514367512L,280173703472L,1555632093093L,8647009926904L,48117998453036L,268057662257096L,1494927614877214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111996Inst : IEnumerable<long>
{
public static readonly long[] Value=A111996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111996.Bytes);
public long this[int i]=>Value[i];

public static A111996Inst Instance=new A111996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111997
{
public static readonly long[] Value={ 1L,9L,63L,399L,2403L,14067L,80949L,460845L,2605590L,14666470L,82320714L,461238282L,2581644378L,14442658074L,80785970838L,451934259654L,2528977211775L,14157983986839L,79302044283297L,444448115168049L,2492468172937125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111997Inst : IEnumerable<long>
{
public static readonly long[] Value=A111997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111997.Bytes);
public long this[int i]=>Value[i];

public static A111997Inst Instance=new A111997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111998
{
public static readonly long[] Value={ 1L,10L,75L,500L,3135L,18962L,112125L,653200L,3766950L,21571500L,122920642L,697994760L,3953743250L,22357130700L,126273263510L,712639689168L,4019975635855L,22671014908550L,127846248597125L,720994336613980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111998Inst : IEnumerable<long>
{
public static readonly long[] Value=A111998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111998.Bytes);
public long this[int i]=>Value[i];

public static A111998Inst Instance=new A111998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111999
{
public static readonly long[] Value={ -1L,3L,2L,-15L,-20L,-6L,105L,210L,130L,24L,-945L,-2520L,-2380L,-924L,-120L,10395L,34650L,44100L,26432L,7308L,720L,-135135L,-540540L,-866250L,-705320L,-303660L,-64224L,-5040L,2027025L,9459450L,18288270L,18858840L,11098780L,3678840L,623376L,40320L,-34459425L,-183783600L,-416215800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111999Inst : IEnumerable<long>
{
public static readonly long[] Value=A111999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111999.Bytes);
public long this[int i]=>Value[i];

public static A111999Inst Instance=new A111999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112000
{
public static readonly BigInteger[] Value={ -3L,65L,-1190L,22050L,-433125L,9144135L,-208107900L,5099994900L,-134219460375L,3781060408125L,-113633468798850L,3631422078033750L,-123022987568105625L,4405418319999571875L,BigInteger.Parse("-166312279434175875000"),BigInteger.Parse("6602853358582065585000"),BigInteger.Parse("-275059081486584416896875") };
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
public class A112000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112000Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112000.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112000Inst Instance=new A112000Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112001
{
public static readonly BigInteger[] Value={ 6L,-231L,6608L,-176330L,4714710L,-130014885L,3745101360L,-113311778580L,3608430175350L,-120977128347075L,4267052705916000L,-158151857368254750L,6150573832264611750L,BigInteger.Parse("-250598489767931930625"),BigInteger.Parse("10680148143520635780000"),BigInteger.Parse("-475373543975596731465000") };
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
public class A112001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112001Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112001.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112001Inst Instance=new A112001Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112002
{
public static readonly long[] Value={ 720L,13068L,118124L,723680L,3416930L,13339535L,44990231L,135036473L,368411615L,928095740L,2185031420L,4853222764L,10246937272L,20692933630L,40171771630L,75289668850L,136717357942L,241276443496L,414908513800L,696829576300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112002Inst : IEnumerable<long>
{
public static readonly long[] Value=A112002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112002.Bytes);
public long this[int i]=>Value[i];

public static A112002Inst Instance=new A112002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112003
{
public static readonly BigInteger[] Value={ -30L,1827L,-75915L,2774695L,-97362265L,3410657250L,-121647896370L,4464233824050L,-169525943987400L,6681570663692925L,-273715584240223125L,11660420923428902625UL,BigInteger.Parse("-516518847915111916875"),BigInteger.Parse("23780637468174359272500"),BigInteger.Parse("-1137205925185934836732500") };
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
public class A112003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112003Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112003.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112003Inst Instance=new A112003Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112004
{
public static readonly BigInteger[] Value={ 90L,-8028L,459855L,-22166430L,991865875L,-43155112000L,1871623083330L,-82074799907100L,3670430981817600L,-168269191527937500L,7933301574849275625L,BigInteger.Parse("-385378337023784354250"),BigInteger.Parse("19309132829440209380625"),BigInteger.Parse("-998382450032876448540000"),BigInteger.Parse("53277504029278691474812500") };
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
public class A112004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112004Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112004.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112004Inst Instance=new A112004Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112005
{
public static readonly BigInteger[] Value={ 0L,1L,0L,1L,-2L,4L,-17L,82L,-384L,2189L,-14850L,107404L,-845537L,7400482L,-70093256L,709888645L,-7721333538L,89774204756L,-1107347563761L,14456268008050L,-199350032354000L,2893615098314941L,-44089764970860290L,703841452185590236L,BigInteger.Parse("-11747695951762870497") };
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
public class A112005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112005Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112005.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112005Inst Instance=new A112005Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112006
{
public static readonly ulong[] Value={ 0L,1L,2L,7L,32L,194L,1473L,13424L,142722L,1734155L,23704880L,360035434L,6015135425L,109631190368L,2164636394634L,46027826357795L,1048622566013472L,25482771281706578L,657965393430769025L,17988006311731338448UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112006Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A112006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112006.Bytes);
public ulong this[int i]=>Value[i];

public static A112006Inst Instance=new A112006Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112007
{
public static readonly long[] Value={ 1L,2L,1L,6L,8L,1L,24L,58L,22L,1L,120L,444L,328L,52L,1L,720L,3708L,4400L,1452L,114L,1L,5040L,33984L,58140L,32120L,5610L,240L,1L,40320L,341136L,785304L,644020L,195800L,19950L,494L,1L,362880L,3733920L,11026296L,12440064L,5765500L,1062500L,67260L,1004L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112007Inst : IEnumerable<long>
{
public static readonly long[] Value=A112007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112007.Bytes);
public long this[int i]=>Value[i];

public static A112007Inst Instance=new A112007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112008
{
public static readonly BigInteger[] Value={ 1L,52L,1452L,32120L,644020L,12440064L,238904904L,4642163952L,92199790224L,1883079661824L,39689578055808L,865023253219584L,19515249341231616L,455924361142656000L,11030149104146035200UL,BigInteger.Parse("276260563641659673600") };
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
public class A112008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112008Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112008.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112008Inst Instance=new A112008Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112009
{
public static readonly long[] Value={ 113724L,116680L,126620L,176453L,236520L,12146841L,12514635L,13334445L,13469331L,13813728L,16473510L,18259344L,20116537L,20119347L,21324832L,23336066L,27923616L,30352728L,34425425L,35424571L,36311184L,37837170L,39171345L,43362816L,45429360L,45449216L,45916416L,46544032L,50713684L,50816880L,61642672L,62193744L,62226711L,62263890L,62288272L,64245272L,64808352L,64832560L,66707233L,66807126L,66827180L,81913446L,84943040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112009Inst : IEnumerable<long>
{
public static readonly long[] Value=A112009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112009.Bytes);
public long this[int i]=>Value[i];

public static A112009Inst Instance=new A112009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112010
{
public static readonly long[] Value={ 24L,1064L,2592L,6520L,106434L,145166L,237165L,262535L,372780L,491520L,531765L,546410L,566250L,636352L,12716544L,12806910L,13666320L,15116832L,15408692L,17473715L,21645616L,23473515L,23726640L,23728264L,26722436L,26757024L,27933192L,30537364L,30869280L,32118177L,33452293L,34114338L,39602752L,42262365L,44373490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112010Inst : IEnumerable<long>
{
public static readonly long[] Value=A112010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112010.Bytes);
public long this[int i]=>Value[i];

public static A112010Inst Instance=new A112010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112011
{
public static readonly long[] Value={ 24L,1064L,2592L,6520L,9234L,145166L,245344L,296480L,372780L,491520L,531765L,546410L,566250L,664062L,12806910L,12826710L,14466530L,15408692L,15621268L,17473715L,19946352L,22297520L,23256720L,30537364L,30869280L,32118177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112011Inst : IEnumerable<long>
{
public static readonly long[] Value=A112011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112011.Bytes);
public long this[int i]=>Value[i];

public static A112011Inst Instance=new A112011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112012
{
public static readonly long[] Value={ 16L,17L,73L,132L,224L,322L,342L,352L,362L,619L,1017L,1117L,1196L,1516L,2163L,2215L,3514L,3714L,5137L,11373L,12012L,12121L,13120L,17116L,21113L,25911L,51045L,64541L,64581L,64591L,64601L,64611L,64651L,64661L,64691L,64701L,64711L,64721L,100967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112012Inst : IEnumerable<long>
{
public static readonly long[] Value=A112012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112012.Bytes);
public long this[int i]=>Value[i];

public static A112012Inst Instance=new A112012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112013
{
public static readonly long[] Value={ 17L,73L,619L,1117L,64591L,64601L,64661L,2077121L,5070613L,8883067L,2121104897L,4387047283L,14304478789L,503890508623L,1547037000637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112013Inst : IEnumerable<long>
{
public static readonly long[] Value=A112013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112013.Bytes);
public long this[int i]=>Value[i];

public static A112013Inst Instance=new A112013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112014
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,736L,15642L,15662L,1680129L,1686394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112014Inst : IEnumerable<long>
{
public static readonly long[] Value=A112014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112014.Bytes);
public long this[int i]=>Value[i];

public static A112014Inst Instance=new A112014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112015
{
public static readonly long[] Value={ 1L,61845L,2165527L,3045365L,4461365L,109182857L,120068526L,132268815L,154514955L,166825505L,194565915L,194621658L,215365427L,216753138L,226262568L,228330759L,243430671L,243771445L,246455605L,276514536L,276751134L,277093299L,286551243L,287337804L,293644185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112015Inst : IEnumerable<long>
{
public static readonly long[] Value=A112015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112015.Bytes);
public long this[int i]=>Value[i];

public static A112015Inst Instance=new A112015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112016
{
public static readonly long[] Value={ 1L,127L,1443572L,2859151L,5272635L,5469390L,5668072L,9662421L,121734535L,124825592L,161367245L,168215370L,185335291L,211254594L,217299630L,225624553L,236125265L,251716960L,271374710L,272433643L,291732835L,292536521L,345267332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112016Inst : IEnumerable<long>
{
public static readonly long[] Value=A112016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112016.Bytes);
public long this[int i]=>Value[i];

public static A112016Inst Instance=new A112016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112017
{
public static readonly long[] Value={ 1843L,2231L,12707L,20003L,58091L,72971L,129899L,153851L,876987L,899991L,909131L,1154535L,1660931L,1835503L,2003303L,2184463L,2200979L,2248307L,2482667L,2518571L,2566463L,2699723L,2978371L,2982815L,3537163L,4814207L,4831439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112017Inst : IEnumerable<long>
{
public static readonly long[] Value=A112017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112017.Bytes);
public long this[int i]=>Value[i];

public static A112017Inst Instance=new A112017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112018
{
public static readonly long[] Value={ 114190259L,6364631939L,10296994891L,10429820759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112018Inst : IEnumerable<long>
{
public static readonly long[] Value=A112018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112018.Bytes);
public long this[int i]=>Value[i];

public static A112018Inst Instance=new A112018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112019
{
public static readonly BigInteger[] Value={ 1L,5L,55L,749L,11251L,178835L,2949115L,49906925L,860905315L,15071939255L,266982872905L,4774722189275L,86070844191775L,1561948324845095L,28507384046515555L,522867506128197869L,9631571375362268515UL,BigInteger.Parse("178094411589895650815"),BigInteger.Parse("3304192479145474141741"),BigInteger.Parse("61487420580006795749999") };
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
public class A112019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112019Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112019.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112019Inst Instance=new A112019Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112020
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,2L,0L,0L,1L,2L,2L,1L,0L,1L,3L,2L,2L,1L,2L,3L,5L,2L,2L,3L,5L,4L,5L,3L,4L,6L,9L,6L,5L,6L,10L,10L,9L,7L,9L,12L,14L,12L,11L,14L,18L,17L,16L,16L,19L,21L,24L,21L,23L,26L,29L,30L,32L,31L,33L,39L,40L,39L,41L,45L,49L,54L,53L,54L,59L,68L,66L,68L,70L,78L,82L,88L,86L,93L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112020Inst : IEnumerable<long>
{
public static readonly long[] Value=A112020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112020.Bytes);
public long this[int i]=>Value[i];

public static A112020Inst Instance=new A112020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112021
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,3L,3L,4L,5L,6L,7L,9L,10L,12L,14L,17L,19L,23L,26L,30L,35L,40L,46L,52L,60L,67L,77L,87L,98L,111L,124L,140L,157L,175L,197L,219L,244L,272L,302L,336L,372L,412L,456L,503L,556L,613L,675L,742L,816L,896L,983L,1078L,1180L,1291L,1411L,1542L,1683L,1836L,2001L,2178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112021Inst : IEnumerable<long>
{
public static readonly long[] Value=A112021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112021.Bytes);
public long this[int i]=>Value[i];

public static A112021Inst Instance=new A112021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112022
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,2L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,4L,3L,4L,4L,4L,5L,5L,5L,6L,5L,6L,7L,6L,9L,7L,9L,9L,9L,11L,11L,11L,13L,12L,14L,15L,14L,17L,15L,17L,19L,18L,21L,21L,21L,24L,24L,26L,28L,27L,30L,30L,32L,35L,34L,37L,37L,39L,41L,43L,45L,46L,48L,51L,53L,56L,58L,59L,61L,64L,66L,70L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112022Inst : IEnumerable<long>
{
public static readonly long[] Value=A112022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112022.Bytes);
public long this[int i]=>Value[i];

public static A112022Inst Instance=new A112022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112023
{
public static readonly long[] Value={ 1000L,72L,5L,25L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112023Inst : IEnumerable<long>
{
public static readonly long[] Value=A112023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112023.Bytes);
public long this[int i]=>Value[i];

public static A112023Inst Instance=new A112023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112024
{
public static readonly long[] Value={ 1L,5L,10L,25L,50L,100L,200L,500L,1000L,2000L,5000L,10000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112024Inst : IEnumerable<long>
{
public static readonly long[] Value=A112024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112024.Bytes);
public long this[int i]=>Value[i];

public static A112024Inst Instance=new A112024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112025
{
public static readonly long[] Value={ 60L,60L,24L,7L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112025Inst : IEnumerable<long>
{
public static readonly long[] Value=A112025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112025.Bytes);
public long this[int i]=>Value[i];

public static A112025Inst Instance=new A112025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112026
{
public static readonly long[] Value={ 30L,28L,32L,38L,40L,42L,46L,52L,60L,60L,64L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112026Inst : IEnumerable<long>
{
public static readonly long[] Value=A112026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112026.Bytes);
public long this[int i]=>Value[i];

public static A112026Inst Instance=new A112026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112027
{
public static readonly long[] Value={ 1L,2L,1L,3L,7L,8L,4L,6L,25L,26L,13L,15L,79L,80L,40L,42L,241L,242L,121L,123L,727L,728L,364L,366L,2185L,2186L,1093L,1095L,6559L,6560L,3280L,3282L,19681L,19682L,9841L,9843L,59047L,59048L,29524L,29526L,177145L,177146L,88573L,88575L,531439L,531440L,265720L,265722L,1594321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112027Inst : IEnumerable<long>
{
public static readonly long[] Value=A112027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112027.Bytes);
public long this[int i]=>Value[i];

public static A112027Inst Instance=new A112027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112028
{
public static readonly BigInteger[] Value={ 1L,9L,244L,9065L,389376L,18188478L,897376152L,46011772521L,2427553965160L,130930630643384L,7186614533569296L,400132290102421214L,BigInteger.Parse("22543708920891189136"),BigInteger.Parse("1282873288801683197250"),BigInteger.Parse("73628947696550668509744"),BigInteger.Parse("4257138240245923453355625"),BigInteger.Parse("247733479854085081062353400") };
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
public class A112028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112028Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112028.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112028Inst Instance=new A112028Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112029
{
public static readonly BigInteger[] Value={ 1L,5L,46L,517L,6376L,82994L,1119210L,15475205L,217994860L,3115374880L,45035696036L,657153097330L,9663914317396L,143050882063262L,2129448324373546L,31853280798384645L,478503774600509620L,7215090439396842572L,BigInteger.Parse("109154411037070011504"),BigInteger.Parse("1656268648035559711392") };
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
public class A112029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112029Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112029.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112029Inst Instance=new A112029Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112030
{
public static readonly long[] Value={ 3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L,-3L,-1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112030Inst : IEnumerable<long>
{
public static readonly long[] Value=A112030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112030.Bytes);
public long this[int i]=>Value[i];

public static A112030Inst Instance=new A112030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112031
{
public static readonly long[] Value={ 3L,1L,5L,1L,11L,3L,21L,5L,43L,11L,85L,21L,171L,43L,341L,85L,683L,171L,1365L,341L,2731L,683L,5461L,1365L,10923L,2731L,21845L,5461L,43691L,10923L,87381L,21845L,174763L,43691L,349525L,87381L,699051L,174763L,1398101L,349525L,2796203L,699051L,5592405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112031Inst : IEnumerable<long>
{
public static readonly long[] Value=A112031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112031.Bytes);
public long this[int i]=>Value[i];

public static A112031Inst Instance=new A112031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112032
{
public static readonly long[] Value={ 4L,1L,8L,2L,16L,4L,32L,8L,64L,16L,128L,32L,256L,64L,512L,128L,1024L,256L,2048L,512L,4096L,1024L,8192L,2048L,16384L,4096L,32768L,8192L,65536L,16384L,131072L,32768L,262144L,65536L,524288L,131072L,1048576L,262144L,2097152L,524288L,4194304L,1048576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112032Inst : IEnumerable<long>
{
public static readonly long[] Value=A112032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112032.Bytes);
public long this[int i]=>Value[i];

public static A112032Inst Instance=new A112032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112033
{
public static readonly long[] Value={ 12L,3L,24L,6L,48L,12L,96L,24L,192L,48L,384L,96L,768L,192L,1536L,384L,3072L,768L,6144L,1536L,12288L,3072L,24576L,6144L,49152L,12288L,98304L,24576L,196608L,49152L,393216L,98304L,786432L,196608L,1572864L,393216L,3145728L,786432L,6291456L,1572864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112033Inst : IEnumerable<long>
{
public static readonly long[] Value=A112033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112033.Bytes);
public long this[int i]=>Value[i];

public static A112033Inst Instance=new A112033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112034
{
public static readonly long[] Value={ 6L,24L,12L,48L,24L,96L,48L,192L,96L,384L,192L,768L,384L,1536L,768L,3072L,1536L,6144L,3072L,12288L,6144L,24576L,12288L,49152L,24576L,98304L,49152L,196608L,98304L,393216L,19660L,8L,786432L,393216L,1572864L,786432L,3145728L,1572864L,6291456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112034Inst : IEnumerable<long>
{
public static readonly long[] Value=A112034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112034.Bytes);
public long this[int i]=>Value[i];

public static A112034Inst Instance=new A112034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112035
{
public static readonly BigInteger[] Value={ 0L,8L,540L,42576L,3675000L,334595040L,31539372732L,3046472028320L,299666635774704L,29894793786770040L,3016010007220052700L,BigInteger.Parse("307083034957464057600"),BigInteger.Parse("31506217163866419507000"),BigInteger.Parse("3253427167078021753747200"),BigInteger.Parse("337821983730064508845772700"),BigInteger.Parse("35246436592815103238009282880") };
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
public class A112035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112035Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112035.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112035Inst Instance=new A112035Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112036
{
public static readonly BigInteger[] Value={ 0L,2L,36L,708L,13800L,275010L,5546016L,112928648L,2316836304L,47818490310L,991809240180L,20655287811972L,431646101898336L,9046910585978538L,190096907348726280L,4003238051096801040L,BigInteger.Parse("84468326787457833888"),BigInteger.Parse("1785362928126983779374"),BigInteger.Parse("37794508394454024115212"),BigInteger.Parse("801183789256961484235340") };
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
public class A112036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112036Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112036.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112036Inst Instance=new A112036Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112037
{
public static readonly long[] Value={ 2L,3L,5L,11L,7L,23L,13L,29L,41L,17L,53L,37L,83L,43L,89L,19L,113L,131L,67L,47L,73L,31L,79L,173L,179L,61L,191L,97L,233L,239L,251L,127L,139L,281L,71L,293L,101L,103L,107L,163L,59L,359L,193L,199L,137L,419L,431L,443L,151L,491L,509L,181L,109L,277L,593L,149L,307L,641L,653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112037Inst : IEnumerable<long>
{
public static readonly long[] Value=A112037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112037.Bytes);
public long this[int i]=>Value[i];

public static A112037Inst Instance=new A112037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112038
{
public static readonly long[] Value={ 3L,7L,11L,23L,29L,47L,53L,59L,83L,103L,107L,149L,167L,173L,179L,191L,227L,263L,269L,283L,293L,311L,317L,347L,359L,367L,383L,389L,467L,479L,503L,509L,557L,563L,569L,587L,607L,619L,643L,653L,709L,719L,773L,797L,823L,839L,863L,887L,907L,983L,1019L,1087L,1091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112038Inst : IEnumerable<long>
{
public static readonly long[] Value=A112038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112038.Bytes);
public long this[int i]=>Value[i];

public static A112038Inst Instance=new A112038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112039
{
public static readonly long[] Value={ 3L,9L,21L,39L,65L,99L,141L,191L,251L,320L,396L,482L,581L,686L,797L,926L,1064L,1214L,1374L,1544L,1724L,1916L,2114L,2331L,2559L,2795L,3041L,3301L,3571L,3850L,4138L,4447L,4762L,5096L,5444L,5800L,6170L,6551L,6944L,7349L,7769L,8201L,8642L,9095L,9557L,10030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112039Inst : IEnumerable<long>
{
public static readonly long[] Value=A112039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112039.Bytes);
public long this[int i]=>Value[i];

public static A112039Inst Instance=new A112039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112040
{
public static readonly long[] Value={ 1L,3L,7L,13L,33L,47L,132L,458L,777L,853L,3845L,4395L,4783L,4983L,6038L,6487L,6719L,6957L,11707L,12030L,12688L,13025L,13365L,13709L,14057L,14409L,15861L,17789L,18598L,19008L,19845L,20272L,20702L,21135L,21570L,22010L,22458L,23378L,23850L,24326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112040Inst : IEnumerable<long>
{
public static readonly long[] Value=A112040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112040.Bytes);
public long this[int i]=>Value[i];

public static A112040Inst Instance=new A112040Inst();

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