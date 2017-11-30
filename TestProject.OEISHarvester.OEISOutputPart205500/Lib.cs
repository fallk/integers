using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A243882
{
public static readonly long[] Value={ 1L,21L,124L,636L,2749L,11265L,44028L,168673L,636526L,2385703L,8903294L,33177968L,123602040L,460821006L,1720240295L,6432225711L,24095079682L,90435264009L,340097165156L,1281506663877L,4838093967400L,18299480354681L,69340086808691L,263195643048634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243882Inst : IEnumerable<long>
{
public static readonly long[] Value=A243882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243882.Bytes);
public long this[int i]=>Value[i];

public static A243882Inst Instance=new A243882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243883
{
public static readonly long[] Value={ 5L,1L,13L,5L,29L,5L,53L,17L,85L,13L,125L,37L,173L,25L,229L,65L,293L,41L,365L,101L,445L,61L,533L,145L,629L,85L,733L,197L,845L,113L,965L,257L,1093L,145L,1229L,325L,1373L,181L,1525L,401L,1685L,221L,1853L,485L,2029L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243883Inst : IEnumerable<long>
{
public static readonly long[] Value=A243883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243883.Bytes);
public long this[int i]=>Value[i];

public static A243883Inst Instance=new A243883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243884
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,2L,4L,1L,2L,1L,2L,3L,1L,2L,1L,4L,2L,1L,3L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243884Inst : IEnumerable<long>
{
public static readonly long[] Value=A243884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243884.Bytes);
public long this[int i]=>Value[i];

public static A243884Inst Instance=new A243884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243885
{
public static readonly long[] Value={ 7L,11L,11L,971L,71394923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243885Inst : IEnumerable<long>
{
public static readonly long[] Value=A243885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243885.Bytes);
public long this[int i]=>Value[i];

public static A243885Inst Instance=new A243885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243886
{
public static readonly long[] Value={ 661L,1051L,1999L,2179L,3433L,3593L,3719L,4073L,4591L,4733L,5449L,5503L,6079L,6481L,7109L,7211L,7489L,8293L,8513L,9901L,10273L,10529L,11821L,12721L,14107L,14591L,14879L,15263L,15877L,18149L,19559L,22027L,22129L,22571L,23339L,24527L,25357L,26881L,27337L,34259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243886Inst : IEnumerable<long>
{
public static readonly long[] Value=A243886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243886.Bytes);
public long this[int i]=>Value[i];

public static A243886Inst Instance=new A243886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243887
{
public static readonly long[] Value={ 3L,11L,23L,59L,83L,143L,179L,263L,419L,479L,683L,839L,923L,1103L,1403L,1739L,1859L,2243L,2519L,2663L,3119L,3443L,3959L,4703L,5099L,5303L,5723L,5939L,6383L,8063L,8579L,9383L,9659L,11099L,11399L,12323L,13283L,13943L,14963L,16019L,16379L,18239L,18623L,19403L,19799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243887Inst : IEnumerable<long>
{
public static readonly long[] Value=A243887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243887.Bytes);
public long this[int i]=>Value[i];

public static A243887Inst Instance=new A243887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243888
{
public static readonly long[] Value={ 71L,107L,191L,239L,347L,1031L,1439L,1667L,1787L,2039L,2447L,2591L,3371L,3539L,5231L,5651L,5867L,6311L,7247L,9311L,9587L,10151L,11027L,11939L,12251L,14207L,14891L,19727L,20939L,21767L,23039L,27539L,30431L,34511L,36107L,39971L,41687L,46439L,47051L,56039L,56711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243888Inst : IEnumerable<long>
{
public static readonly long[] Value=A243888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243888.Bytes);
public long this[int i]=>Value[i];

public static A243888Inst Instance=new A243888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243889
{
public static readonly long[] Value={ 661L,1201L,2281L,2713L,3181L,4801L,5413L,8221L,9013L,12541L,13513L,17761L,18913L,20101L,32413L,33961L,38821L,51421L,72481L,91921L,94513L,108013L,110821L,134581L,137713L,153913L,167521L,211801L,223681L,265621L,274441L,335281L,345181L,365413L,370561L,440761L,560641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243889Inst : IEnumerable<long>
{
public static readonly long[] Value=A243889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243889.Bytes);
public long this[int i]=>Value[i];

public static A243889Inst Instance=new A243889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243890
{
public static readonly long[] Value={ 101L,149L,257L,317L,449L,521L,677L,761L,941L,1697L,1949L,2081L,2357L,2801L,2957L,3449L,3797L,4349L,4937L,6221L,6449L,6917L,7649L,7901L,8681L,9221L,9497L,10061L,10937L,12161L,13121L,13781L,15149L,16217L,17321L,18077L,18461L,20441L,20849L,25601L,26981L,27449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243890Inst : IEnumerable<long>
{
public static readonly long[] Value=A243890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243890.Bytes);
public long this[int i]=>Value[i];

public static A243890Inst Instance=new A243890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243891
{
public static readonly long[] Value={ 233L,389L,653L,953L,1061L,1289L,1409L,2069L,2213L,4253L,4649L,5273L,6869L,8933L,9209L,10061L,10949L,13829L,15569L,16661L,17033L,17789L,24413L,26693L,28109L,32573L,35729L,36269L,37361L,42473L,44249L,46061L,48533L,51713L,52361L,55661L,56333L,57689L,59753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243891Inst : IEnumerable<long>
{
public static readonly long[] Value=A243891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243891.Bytes);
public long this[int i]=>Value[i];

public static A243891Inst Instance=new A243891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243892
{
public static readonly long[] Value={ 11L,41L,139L,313L,839L,1259L,2273L,2953L,4493L,7417L,8689L,12659L,15881L,17837L,21683L,28097L,35401L,38321L,46993L,53353L,56909L,67499L,75277L,87539L,105167L,115061L,120431L,130817L,136559L,147881L,189127L,202493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243892Inst : IEnumerable<long>
{
public static readonly long[] Value=A243892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243892.Bytes);
public long this[int i]=>Value[i];

public static A243892Inst Instance=new A243892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243893
{
public static readonly long[] Value={ 7L,37L,137L,311L,829L,1249L,2269L,2939L,4483L,7411L,8681L,12653L,15877L,17827L,21673L,28087L,35393L,38317L,46957L,53327L,56897L,67493L,75269L,87523L,105143L,115057L,120427L,130811L,136547L,147863L,189067L,202481L,222991L,230393L,267401L,275677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243893Inst : IEnumerable<long>
{
public static readonly long[] Value=A243893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243893.Bytes);
public long this[int i]=>Value[i];

public static A243893Inst Instance=new A243893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243894
{
public static readonly long[] Value={ 13L,43L,149L,317L,853L,1277L,2281L,2957L,4507L,7433L,8693L,12671L,15887L,17839L,21701L,28099L,35407L,38327L,46997L,53359L,56911L,67511L,75289L,87541L,105173L,115067L,120473L,130829L,136573L,147919L,189139L,202519L,223009L,230449L,267413L,275711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243894Inst : IEnumerable<long>
{
public static readonly long[] Value=A243894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243894.Bytes);
public long this[int i]=>Value[i];

public static A243894Inst Instance=new A243894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243895
{
public static readonly long[] Value={ 5L,19L,47L,89L,149L,223L,307L,409L,523L,659L,823L,997L,1187L,1423L,1613L,1877L,2141L,2423L,2731L,3079L,3457L,3797L,4201L,4621L,5039L,5507L,5987L,6473L,6991L,7561L,8147L,8731L,9337L,9929L,10613L,11317L,12043L,12739L,13487L,14323L,15091L,15859L,16741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243895Inst : IEnumerable<long>
{
public static readonly long[] Value=A243895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243895.Bytes);
public long this[int i]=>Value[i];

public static A243895Inst Instance=new A243895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243896
{
public static readonly long[] Value={ 2L,3L,11L,29L,59L,101L,157L,229L,313L,421L,547L,673L,829L,1013L,1201L,1429L,1621L,1889L,2153L,2441L,2749L,3089L,3463L,3821L,4217L,4639L,5059L,5521L,6011L,6491L,7001L,7577L,8167L,8741L,9343L,9941L,10631L,11329L,12071L,12757L,13513L,14341L,15107L,15881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243896Inst : IEnumerable<long>
{
public static readonly long[] Value=A243896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243896.Bytes);
public long this[int i]=>Value[i];

public static A243896Inst Instance=new A243896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243897
{
public static readonly long[] Value={ 3L,5L,11L,13L,23L,43L,131L,311L,353L,401L,491L,761L,1051L,1063L,1091L,1151L,1201L,1433L,1523L,1531L,1723L,1733L,1811L,1831L,1951L,1973L,2053L,2081L,2221L,2333L,2543L,2591L,2621L,2663L,2953L,2963L,3191L,3433L,3571L,3623L,3643L,3821L,3911L,4051L,4273L,4391L,4973L,5273L,5393L,5591L,6101L,6131L,6173L,6203L,6263L,6473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243897Inst : IEnumerable<long>
{
public static readonly long[] Value=A243897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243897.Bytes);
public long this[int i]=>Value[i];

public static A243897Inst Instance=new A243897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243898
{
public static readonly long[] Value={ 3L,5L,19L,23L,41L,59L,101L,109L,137L,139L,191L,223L,229L,233L,277L,293L,307L,311L,331L,349L,419L,499L,563L,599L,641L,647L,751L,797L,811L,839L,859L,881L,1021L,1117L,1181L,1193L,1259L,1301L,1427L,1453L,1549L,1571L,1609L,1619L,1621L,1637L,1697L,1721L,1811L,1871L,1889L,1907L,1949L,1973L,2039L,2153L,2309L,2579L,2609L,2663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243898Inst : IEnumerable<long>
{
public static readonly long[] Value=A243898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243898.Bytes);
public long this[int i]=>Value[i];

public static A243898Inst Instance=new A243898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243899
{
public static readonly long[] Value={ 3L,5L,11L,19L,23L,37L,43L,103L,127L,193L,199L,239L,269L,277L,283L,373L,397L,457L,467L,509L,751L,761L,887L,919L,947L,977L,1019L,1039L,1051L,1069L,1087L,1277L,1307L,1481L,1531L,1549L,1559L,1613L,1759L,2003L,2017L,2243L,2311L,2357L,2417L,2447L,2467L,2473L,2671L,2851L,2963L,3089L,3253L,3257L,3323L,3433L,3463L,3511L,3539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243899Inst : IEnumerable<long>
{
public static readonly long[] Value=A243899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243899.Bytes);
public long this[int i]=>Value[i];

public static A243899Inst Instance=new A243899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243900
{
public static readonly long[] Value={ 3L,5L,19L,23L,277L,751L,1549L,2851L,2963L,3089L,3463L,3511L,4057L,6067L,6619L,7873L,9257L,10937L,11161L,11321L,11483L,12589L,13997L,15139L,25121L,25939L,26113L,26861L,30971L,33889L,37139L,38119L,39251L,39979L,40763L,41851L,42359L,44293L,50753L,50867L,51907L,54331L,54401L,55871L,56921L,58321L,60611L,62459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243900Inst : IEnumerable<long>
{
public static readonly long[] Value=A243900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243900.Bytes);
public long this[int i]=>Value[i];

public static A243900Inst Instance=new A243900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243901
{
public static readonly long[] Value={ 178633L,2355662L,4892172L,5702347L,9256159L,9572343L,13837265L,15147032L,15429648L,15822376L,16603935L,20925043L,22128672L,22462201L,22689295L,27145167L,28031877L,28470899L,29246422L,30772941L,31211796L,32372758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243901Inst : IEnumerable<long>
{
public static readonly long[] Value=A243901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243901.Bytes);
public long this[int i]=>Value[i];

public static A243901Inst Instance=new A243901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243902
{
public static readonly long[] Value={ 2L,3L,4L,9L,18L,45L,146L,469L,1655L,6095L,23775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243902Inst : IEnumerable<long>
{
public static readonly long[] Value=A243902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243902.Bytes);
public long this[int i]=>Value[i];

public static A243902Inst Instance=new A243902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243903
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,29L,30L,31L,32L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243903Inst : IEnumerable<long>
{
public static readonly long[] Value=A243903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243903.Bytes);
public long this[int i]=>Value[i];

public static A243903Inst Instance=new A243903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243904
{
public static readonly long[] Value={ 49L,247L,679L,973L,2701L,5293L,7509L,10801L,12297L,15553L,17337L,25963L,29407L,33079L,34993L,36967L,43249L,53877L,67501L,71157L,76809L,97201L,117613L,155953L,181573L,225237L,270049L,292033L,297679L,314977L,350917L,380217L,477607L,492091L,514213L,632047L,648679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243904Inst : IEnumerable<long>
{
public static readonly long[] Value=A243904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243904.Bytes);
public long this[int i]=>Value[i];

public static A243904Inst Instance=new A243904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243905
{
public static readonly long[] Value={ 6L,20L,21L,110L,156L,136L,342L,253L,812L,155L,1332L,820L,602L,1081L,2756L,3422L,3660L,4422L,2485L,657L,3081L,6806L,979L,4656L,10100L,5253L,11342L,3924L,3164L,889L,17030L,9316L,19182L,22052L,2265L,8164L,26406L,13861L,29756L,31862L,32580L,18145L,18528L,38612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243905Inst : IEnumerable<long>
{
public static readonly long[] Value=A243905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243905.Bytes);
public long this[int i]=>Value[i];

public static A243905Inst Instance=new A243905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243906
{
public static readonly long[] Value={ 0L,-1L,-2L,-1L,-2L,-1L,-2L,-2L,-1L,0L,-1L,-1L,-2L,-1L,0L,0L,-1L,-1L,-2L,-2L,-1L,0L,-1L,-1L,0L,1L,1L,1L,0L,0L,-1L,-1L,0L,1L,2L,2L,1L,2L,3L,3L,2L,2L,1L,1L,1L,2L,1L,1L,2L,2L,3L,3L,2L,2L,3L,3L,4L,5L,4L,4L,3L,4L,4L,4L,5L,5L,4L,4L,5L,5L,4L,4L,3L,4L,4L,4L,5L,5L,4L,4L,4L,5L,4L,4L,5L,6L,7L,7L,6L,6L,7L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243906Inst : IEnumerable<long>
{
public static readonly long[] Value=A243906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243906.Bytes);
public long this[int i]=>Value[i];

public static A243906Inst Instance=new A243906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243907
{
public static readonly long[] Value={ 23L,32L,38L,41L,50L,53L,59L,68L,74L,77L,83L,86L,88L,95L,98L,104L,113L,116L,122L,123L,128L,131L,137L,138L,140L,143L,149L,158L,163L,167L,173L,176L,179L,182L,185L,188L,193L,194L,200L,203L,212L,213L,215L,218L,221L,228L,230L,233L,238L,239L,242L,248L,254L,257L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243907Inst : IEnumerable<long>
{
public static readonly long[] Value=A243907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243907.Bytes);
public long this[int i]=>Value[i];

public static A243907Inst Instance=new A243907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243908
{
public static readonly long[] Value={ 7L,0L,1L,6L,3L,9L,7L,0L,0L,3L,7L,0L,3L,3L,9L,2L,1L,4L,2L,8L,2L,8L,4L,0L,5L,4L,3L,5L,1L,5L,7L,4L,4L,6L,2L,7L,4L,7L,2L,6L,8L,4L,2L,0L,1L,4L,2L,3L,9L,2L,9L,7L,3L,6L,9L,2L,9L,0L,2L,1L,8L,1L,4L,1L,3L,4L,8L,9L,1L,9L,8L,8L,9L,8L,3L,3L,7L,8L,5L,0L,3L,6L,1L,6L,9L,5L,0L,2L,8L,2L,7L,2L,2L,7L,8L,2L,5L,5L,9L,2L,5L,4L,7L,4L,1L,9L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243908Inst : IEnumerable<long>
{
public static readonly long[] Value=A243908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243908.Bytes);
public long this[int i]=>Value[i];

public static A243908Inst Instance=new A243908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243909
{
public static readonly long[] Value={ 1L,4L,7L,10L,14L,21L,20L,37L,29L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243909Inst : IEnumerable<long>
{
public static readonly long[] Value=A243909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243909.Bytes);
public long this[int i]=>Value[i];

public static A243909Inst Instance=new A243909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243910
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,13L,15L,24L,30L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243910Inst : IEnumerable<long>
{
public static readonly long[] Value=A243910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243910.Bytes);
public long this[int i]=>Value[i];

public static A243910Inst Instance=new A243910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243911
{
public static readonly long[] Value={ 18L,0L,9L,0L,0L,0L,6L,0L,2L,1L,2L,17L,3L,0L,0L,11L,0L,5L,2L,0L,1L,0L,0L,0L,0L,0L,14L,0L,2L,7L,0L,1L,7L,0L,0L,7L,2L,5L,2L,0L,3L,0L,1L,0L,0L,0L,9L,0L,2L,0L,18L,3L,9L,1L,0L,0L,6L,5L,2L,0L,2L,0L,3L,0L,1L,0L,0L,0L,2L,3L,7L,11L,0L,0L,0L,1L,14L,5L,2L,0L,0L,0L,7L,0L,0L,0L,1L,0L,2L,9L,3L,0L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243911Inst : IEnumerable<long>
{
public static readonly long[] Value=A243911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243911.Bytes);
public long this[int i]=>Value[i];

public static A243911Inst Instance=new A243911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243912
{
public static readonly long[] Value={ 3L,5L,6L,7L,9L,15L,16L,18L,21L,23L,24L,25L,26L,27L,29L,32L,35L,36L,41L,43L,45L,46L,47L,49L,51L,56L,57L,61L,63L,65L,67L,68L,69L,74L,75L,76L,81L,82L,83L,85L,86L,87L,89L,93L,95L,96L,101L,103L,105L,106L,107L,109L,115L,116L,118L,121L,123L,124L,125L,126L,127L,129L,132L,135L,136L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243912Inst : IEnumerable<long>
{
public static readonly long[] Value=A243912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243912.Bytes);
public long this[int i]=>Value[i];

public static A243912Inst Instance=new A243912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243913
{
public static readonly long[] Value={ 2L,1L,4L,1L,9L,8L,3L,2L,9L,4L,7L,9L,6L,8L,0L,5L,6L,1L,1L,3L,3L,3L,3L,6L,4L,3L,7L,3L,4L,4L,2L,4L,8L,0L,8L,3L,0L,1L,4L,7L,2L,2L,7L,0L,7L,2L,8L,4L,5L,1L,2L,8L,4L,8L,8L,7L,0L,6L,5L,1L,6L,1L,9L,5L,9L,8L,2L,8L,0L,8L,7L,4L,9L,6L,5L,6L,7L,0L,4L,8L,4L,7L,0L,3L,6L,1L,1L,8L,4L,4L,7L,2L,4L,9L,9L,1L,7L,3L,6L,8L,5L,3L,4L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243913Inst : IEnumerable<long>
{
public static readonly long[] Value=A243913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243913.Bytes);
public long this[int i]=>Value[i];

public static A243913Inst Instance=new A243913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243914
{
public static readonly long[] Value={ 16L,24L,792L,1392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243914Inst : IEnumerable<long>
{
public static readonly long[] Value=A243914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243914.Bytes);
public long this[int i]=>Value[i];

public static A243914Inst Instance=new A243914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243915
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,3L,3L,1L,1L,3L,1L,3L,3L,3L,1L,3L,1L,3L,1L,3L,1L,4L,1L,1L,3L,3L,3L,3L,1L,3L,3L,3L,1L,4L,1L,3L,3L,3L,1L,3L,1L,3L,3L,3L,1L,3L,3L,3L,3L,3L,1L,4L,1L,3L,3L,1L,3L,4L,1L,3L,3L,4L,1L,3L,1L,3L,3L,3L,3L,4L,1L,3L,1L,3L,1L,4L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243915Inst : IEnumerable<long>
{
public static readonly long[] Value=A243915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243915.Bytes);
public long this[int i]=>Value[i];

public static A243915Inst Instance=new A243915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243916
{
public static readonly long[] Value={ 7L,11L,23L,59L,107L,227L,503L,1019L,2039L,4079L,8147L,16223L,32603L,65267L,130787L,262127L,524243L,1048343L,2097143L,4194287L,8388287L,16776899L,33553799L,67108187L,134217323L,268435019L,536870723L,1073740439L,2147483579L,4294967087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243916Inst : IEnumerable<long>
{
public static readonly long[] Value=A243916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243916.Bytes);
public long this[int i]=>Value[i];

public static A243916Inst Instance=new A243916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243917
{
public static readonly long[] Value={ 1L,2L,0L,1L,2L,2L,2L,2L,1L,4L,2L,1L,2L,4L,1L,3L,2L,4L,2L,4L,2L,4L,2L,2L,3L,4L,2L,4L,2L,5L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,6L,2L,4L,3L,4L,2L,4L,3L,6L,2L,4L,2L,6L,4L,6L,2L,4L,2L,4L,2L,4L,2L,5L,4L,6L,2L,4L,2L,6L,2L,6L,2L,4L,3L,4L,4L,6L,2L,6L,3L,4L,2L,5L,4L,4L,2L,6L,2L,9L,4L,4L,2L,4L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243917Inst : IEnumerable<long>
{
public static readonly long[] Value=A243917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243917.Bytes);
public long this[int i]=>Value[i];

public static A243917Inst Instance=new A243917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243918
{
public static readonly BigInteger[] Value={ 1L,4L,32L,814L,86600L,39560554L,75654970772L,594996059517934L,BigInteger.Parse("19035905851947436400"),BigInteger.Parse("2460857798358946973785234"),BigInteger.Parse("1280109151917797032199865564812"),BigInteger.Parse("2672783800502564772495577135824089014"),BigInteger.Parse("22366199286781599568269093307412768076442280") };
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
public class A243918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243918Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243918.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243918Inst Instance=new A243918Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243919
{
public static readonly long[] Value={ 1L,0L,1L,2L,1L,-2L,-3L,1L,9L,13L,6L,-13L,-33L,-39L,-18L,33L,102L,159L,158L,46L,-199L,-525L,-781L,-744L,-221L,808L,2089L,3101L,3212L,1933L,-831L,-4650L,-8635L,-11669L,-12652L,-10615L,-4635L,6314L,23181L,45855L,71241L,91000L,90501L,51044L,-43113L,-193400L,-374830L,-529580L,-573509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243919Inst : IEnumerable<long>
{
public static readonly long[] Value=A243919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243919.Bytes);
public long this[int i]=>Value[i];

public static A243919Inst Instance=new A243919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243920
{
public static readonly long[] Value={ 0L,1L,0L,1L,3L,0L,4L,3L,5L,0L,27L,18L,5L,7L,0L,254L,159L,40L,7L,9L,0L,3048L,1836L,435L,70L,9L,11L,0L,44328L,26028L,5930L,903L,108L,11L,13L,0L,755681L,435804L,96640L,14168L,1611L,154L,13L,15L,0L,14750646L,8395065L,1825600L,260484L,28566L,2607L,208L,15L,17L,0L,323999500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243920Inst : IEnumerable<long>
{
public static readonly long[] Value=A243920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243920.Bytes);
public long this[int i]=>Value[i];

public static A243920Inst Instance=new A243920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243921
{
public static readonly BigInteger[] Value={ 1L,1L,6L,53L,612L,8676L,145268L,2798355L,60852004L,1472460760L,39202586348L,1138006266618L,35750917265544L,1207874695612336L,43655110115967528L,1680097198812367783L,BigInteger.Parse("68578132320350944324"),BigInteger.Parse("2958457556868808457800"),BigInteger.Parse("134469635178557071054492"),BigInteger.Parse("6421829932908536633173110") };
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
public class A243921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243921Inst Instance=new A243921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243922
{
public static readonly BigInteger[] Value={ 1L,1L,8L,87L,1186L,19328L,365120L,7824589L,187217370L,4940474068L,142398668848L,4447556785374L,149541503654196L,5382913372109528L,206455211385309248L,8402342525589672769L,BigInteger.Parse("361557591510622222090"),BigInteger.Parse("16397474363912261372852"),BigInteger.Parse("781575694749373121466960"),BigInteger.Parse("39053517651541054156854082") };
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
public class A243922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243922Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243922.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243922Inst Instance=new A243922Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243923
{
public static readonly BigInteger[] Value={ 0L,1L,4L,12L,57L,469L,5409L,77321L,1304086L,25263208L,551790014L,13398776948L,357740951660L,10409057421898L,327640162774856L,11087710302096702L,401290657576717001L,15462394004585328685UL,BigInteger.Parse("631795378164538352085"),BigInteger.Parse("27280160237622374011469"),BigInteger.Parse("1240933576265292837746859") };
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
public class A243923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243923Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243923.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243923Inst Instance=new A243923Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243924
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L,3L,3L,4L,2L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,3L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,6L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,8L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243924Inst : IEnumerable<long>
{
public static readonly long[] Value=A243924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243924.Bytes);
public long this[int i]=>Value[i];

public static A243924Inst Instance=new A243924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243925
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,2L,3L,1L,1L,5L,2L,3L,1L,1L,1L,2L,3L,5L,2L,3L,1L,3L,1L,3L,7L,7L,5L,3L,5L,2L,3L,1L,3L,4L,5L,5L,4L,7L,7L,5L,3L,5L,2L,3L,1L,1L,5L,7L,5L,13L,7L,13L,9L,5L,4L,7L,7L,7L,5L,3L,5L,2L,3L,1L,1L,1L,3L,5L,4L,6L,6L,4L,9L,9L,7L,8L,5L,13L,7L,13L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243925Inst : IEnumerable<long>
{
public static readonly long[] Value=A243925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243925.Bytes);
public long this[int i]=>Value[i];

public static A243925Inst Instance=new A243925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243926
{
public static readonly long[] Value={ 1L,-2L,2L,-1L,3L,-2L,0L,4L,-1L,1L,5L,-6L,-2L,1L,4L,6L,-5L,-4L,-3L,-1L,3L,3L,7L,7L,-10L,-3L,-4L,-6L,-2L,2L,2L,8L,5L,10L,8L,-7L,-5L,-4L,-3L,-1L,1L,5L,7L,5L,13L,7L,13L,9L,-14L,-14L,-10L,-6L,-10L,-4L,-6L,-2L,1L,3L,6L,8L,12L,12L,8L,18L,9L,16L,10L,-13L,-10L,-8L,-9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243926Inst : IEnumerable<long>
{
public static readonly long[] Value=A243926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243926.Bytes);
public long this[int i]=>Value[i];

public static A243926Inst Instance=new A243926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243927
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,5L,8L,11L,13L,19L,28L,42L,60L,88L,123L,176L,252L,371L,531L,768L,1091L,1581L,2256L,3262L,4685L,6818L,9755L,14167L,20321L,29465L,42275L,61280L,88082L,127736L,183613L,266012L,382840L,554373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243927Inst : IEnumerable<long>
{
public static readonly long[] Value=A243927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243927.Bytes);
public long this[int i]=>Value[i];

public static A243927Inst Instance=new A243927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243928
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,4L,1L,2L,2L,1L,1L,1L,5L,5L,4L,2L,1L,1L,1L,7L,7L,5L,5L,4L,2L,1L,1L,2L,1L,5L,3L,8L,7L,7L,5L,5L,5L,4L,2L,1L,1L,1L,1L,2L,4L,4L,7L,5L,3L,11L,3L,11L,3L,8L,4L,7L,7L,5L,5L,5L,4L,2L,1L,1L,1L,1L,2L,5L,4L,4L,8L,11L,8L,3L,4L,7L,13L,13L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243928Inst : IEnumerable<long>
{
public static readonly long[] Value=A243928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243928.Bytes);
public long this[int i]=>Value[i];

public static A243928Inst Instance=new A243928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243929
{
public static readonly long[] Value={ 1L,-3L,2L,-2L,-3L,3L,-1L,-1L,3L,4L,-3L,0L,1L,5L,5L,6L,-6L,-6L,-3L,1L,7L,7L,-12L,-5L,-6L,-3L,-1L,2L,5L,9L,8L,-11L,-15L,-4L,-12L,-2L,-3L,1L,4L,3L,4L,7L,9L,11L,9L,15L,-21L,-10L,-13L,-21L,-15L,-15L,-7L,-4L,-6L,-1L,3L,1L,5L,3L,8L,11L,8L,9L,12L,13L,13L,10L,16L,-20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243929Inst : IEnumerable<long>
{
public static readonly long[] Value=A243929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243929.Bytes);
public long this[int i]=>Value[i];

public static A243929Inst Instance=new A243929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243930
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,6L,9L,15L,23L,34L,48L,71L,102L,155L,232L,348L,519L,765L,1140L,1691L,2528L,3789L,5634L,8396L,12527L,18709L,27955L,41755L,62410L,93227L,139239L,207939L,310603L,464212L,694207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243930Inst : IEnumerable<long>
{
public static readonly long[] Value=A243930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243930.Bytes);
public long this[int i]=>Value[i];

public static A243930Inst Instance=new A243930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243931
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,31L,120L,594L,4013L,35092L,428080L,6851545L,153025576L,4535778875L,187380634539L,10385121165057L,801710433900516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243931Inst : IEnumerable<long>
{
public static readonly long[] Value=A243931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243931.Bytes);
public long this[int i]=>Value[i];

public static A243931Inst Instance=new A243931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243932
{
public static readonly long[] Value={ 6L,8L,21L,27L,33L,35L,39L,40L,45L,51L,57L,69L,72L,75L,87L,93L,96L,105L,111L,123L,129L,141L,143L,159L,168L,177L,183L,189L,201L,213L,219L,237L,249L,252L,264L,267L,291L,297L,303L,309L,312L,321L,323L,327L,339L,381L,393L,399L,411L,417L,420L,429L,447L,453L,471L,483L,489L,501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243932Inst : IEnumerable<long>
{
public static readonly long[] Value=A243932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243932.Bytes);
public long this[int i]=>Value[i];

public static A243932Inst Instance=new A243932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243933
{
public static readonly long[] Value={ 17L,5L,77L,17L,210L,40L,445L,77L,812L,133L,1339L,210L,2056L,313L,2991L,445L,4175L,610L,5636L,812L,7403L,1054L,9506L,1339L,11973L,1672L,14835L,2056L,18120L,2494L,21856L,2991L,26075L,3550L,30804L,4175L,36073L,4869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243933Inst : IEnumerable<long>
{
public static readonly long[] Value=A243933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243933.Bytes);
public long this[int i]=>Value[i];

public static A243933Inst Instance=new A243933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243934
{
public static readonly long[] Value={ 0L,2L,4L,14L,22L,26L,36L,216L,354L,874L,1018L,2798L,6116L,6574L,6922L,8090L,8398L,12866L,20816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243934Inst : IEnumerable<long>
{
public static readonly long[] Value=A243934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243934.Bytes);
public long this[int i]=>Value[i];

public static A243934Inst Instance=new A243934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243935
{
public static readonly long[] Value={ 4L,7L,9L,14L,18L,19L,23L,24L,27L,29L,34L,38L,39L,44L,49L,54L,58L,59L,61L,64L,66L,68L,69L,71L,74L,79L,82L,84L,89L,94L,97L,99L,103L,104L,109L,114L,119L,120L,124L,127L,128L,129L,130L,134L,136L,139L,140L,142L,144L,149L,154L,159L,163L,164L,165L,169L,170L,173L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243935Inst : IEnumerable<long>
{
public static readonly long[] Value=A243935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243935.Bytes);
public long this[int i]=>Value[i];

public static A243935Inst Instance=new A243935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243936
{
public static readonly long[] Value={ 5L,10L,11L,12L,16L,18L,19L,24L,26L,27L,33L,37L,39L,40L,41L,47L,48L,52L,53L,54L,55L,61L,68L,75L,76L,82L,83L,89L,96L,97L,103L,110L,111L,117L,124L,125L,131L,138L,140L,145L,147L,152L,159L,166L,170L,173L,177L,180L,187L,191L,194L,201L,208L,213L,215L,222L,225L,229L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243936Inst : IEnumerable<long>
{
public static readonly long[] Value=A243936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243936.Bytes);
public long this[int i]=>Value[i];

public static A243936Inst Instance=new A243936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243937
{
public static readonly long[] Value={ 6L,8L,12L,14L,18L,20L,24L,30L,32L,36L,38L,42L,44L,48L,54L,60L,62L,66L,68L,72L,74L,78L,80L,84L,90L,96L,98L,102L,104L,108L,110L,114L,120L,122L,126L,128L,132L,138L,140L,144L,150L,152L,156L,158L,162L,164L,168L,174L,180L,182L,186L,188L,192L,194L,198L,200L,204L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243937Inst : IEnumerable<long>
{
public static readonly long[] Value=A243937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243937.Bytes);
public long this[int i]=>Value[i];

public static A243937Inst Instance=new A243937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243938
{
public static readonly long[] Value={ 1L,2L,5L,10L,20L,26L,45L,60L,85L,100L,156L,172L,240L,270L,365L,376L,517L,520L,705L,740L,932L,942L,1260L,1200L,1510L,1580L,1928L,1880L,2420L,2300L,2861L,2864L,3410L,3310L,4265L,3876L,4780L,4740L,5625L,5300L,6672L,6082L,7460L,7270L,8400L,8026L,10092L,9100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243938Inst : IEnumerable<long>
{
public static readonly long[] Value=A243938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243938.Bytes);
public long this[int i]=>Value[i];

public static A243938Inst Instance=new A243938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243939
{
public static readonly long[] Value={ 1L,-10L,35L,-30L,-105L,240L,-20L,-190L,-225L,-70L,1535L,-820L,-940L,-480L,-960L,5470L,-1185L,-2140L,-3505L,-3600L,14395L,-3820L,-3380L,-3930L,-6300L,23990L,-9070L,-6900L,-10120L,-8900L,47980L,-10420L,-16865L,-14960L,-16010L,66310L,-19485L,-22040L,-19900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243939Inst : IEnumerable<long>
{
public static readonly long[] Value=A243939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243939.Bytes);
public long this[int i]=>Value[i];

public static A243939Inst Instance=new A243939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243940
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,15L,13L,50L,24L,126L,50L,258L,78L,508L,115L,899L,176L,1562L,240L,2383L,299L,3616L,440L,5733L,547L,7585L,664L,10705L,863L,16259L,1033L,19591L,1234L,25943L,1566L,37879L,1860L,43405L,1976L,55700L,2529L,78989L,2942L,86261L,3162L,106212L,3867L,148771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243940Inst : IEnumerable<long>
{
public static readonly long[] Value=A243940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243940.Bytes);
public long this[int i]=>Value[i];

public static A243940Inst Instance=new A243940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243941
{
public static readonly long[] Value={ 1L,2L,2L,5L,5L,3L,6L,3L,6L,8L,5L,6L,7L,6L,10L,10L,9L,8L,15L,10L,13L,8L,23L,5L,16L,21L,10L,20L,13L,30L,12L,14L,26L,16L,35L,16L,21L,22L,23L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243941Inst : IEnumerable<long>
{
public static readonly long[] Value=A243941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243941.Bytes);
public long this[int i]=>Value[i];

public static A243941Inst Instance=new A243941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243942
{
public static readonly BigInteger[] Value={ 1L,1L,8L,121L,2698L,79654L,2929238L,129004633L,6619919386L,387904397222L,25555935470016L,1869945551975658L,150459006927310348L,13203459856456213172UL,BigInteger.Parse("1254972882696473807298"),BigInteger.Parse("128439184335788533011489"),BigInteger.Parse("14082139161229781077548346"),BigInteger.Parse("1646731810035799151750487814") };
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
public class A243942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243942Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243942.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243942Inst Instance=new A243942Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243943
{
public static readonly BigInteger[] Value={ 1L,25L,1369L,93025L,6974881L,553425625L,45558768025L,3848757330625L,331434586569025L,28966516730025625L,2561512789823546329L,BigInteger.Parse("228690489716580520225"),BigInteger.Parse("20579914168308199841761"),BigInteger.Parse("1864413002713001259355225"),BigInteger.Parse("169871744046114667846619929"),BigInteger.Parse("15554069096581207471331850625") };
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
public class A243943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243943Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243943.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243943Inst Instance=new A243943Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243944
{
public static readonly BigInteger[] Value={ 1L,49L,5329L,717409L,106523041L,16735820689L,2727812288881L,456250924320961L,77788137919752001L,13459803510972477169UL,BigInteger.Parse("2356471368269511061009"),BigInteger.Parse("416518496068852312607521"),BigInteger.Parse("74207592486779379593752801"),BigInteger.Parse("13309569813247406938272432721"),BigInteger.Parse("2400816685486139045360488325809") };
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
public class A243944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243944Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243944.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243944Inst Instance=new A243944Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243945
{
public static readonly BigInteger[] Value={ 1L,5L,49L,605L,8281L,120125L,1809025L,27966125L,440790025L,7051890125L,114160867129L,1865975723045L,30743797894681L,509948702030045L,8507207970913729L,142626515754330125L,2401552098016698025L,BigInteger.Parse("40591712338241826125"),BigInteger.Parse("688413807606268692025"),BigInteger.Parse("11710401759994742685125") };
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
public class A243945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243945Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243945.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243945Inst Instance=new A243945Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243946
{
public static readonly BigInteger[] Value={ 1L,7L,91L,1345L,20995L,337877L,5544709L,92234527L,1549694195L,26237641045L,446925926881L,7650344197987L,131489964887341L,2267722252458475L,39224201631222475L,680160975405238145L,11820134678459908115UL,BigInteger.Parse("205812328555924135045"),BigInteger.Parse("3589742656727603141425"),BigInteger.Parse("62707329988264214752675") };
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
public class A243946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243946Inst Instance=new A243946Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243947
{
public static readonly BigInteger[] Value={ 1L,11L,155L,2365L,37555L,610897L,10098997L,168894355L,2849270515L,48395044705L,826479148001L,14177519463191L,244109912494525L,4216385987238575L,73024851218517275L,1267712063327871245L,BigInteger.Parse("22052786911315216595"),BigInteger.Parse("384321597582115655825"),BigInteger.Parse("6708530714274563938225") };
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
public class A243947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243947Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243947.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243947Inst Instance=new A243947Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243948
{
public static readonly long[] Value={ 1L,2L,8L,36L,182L,964L,5296L,29832L,171238L,997244L,5874992L,34937400L,209392796L,1263258760L,7664233696L,46726270992L,286089651718L,1758215706476L,10841476837424L,67049791851672L,415784950498964L,2584585251386296L,16101542183281312L,100511325748165488L,628579719997550044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243948Inst : IEnumerable<long>
{
public static readonly long[] Value=A243948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243948.Bytes);
public long this[int i]=>Value[i];

public static A243948Inst Instance=new A243948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243949
{
public static readonly BigInteger[] Value={ 1L,9L,169L,3969L,103041L,2832489L,80802121L,2365752321L,70611901441L,2139090528969L,65568745087209L,2029206892664961L,63300531617048961L,1987912809986437161L,BigInteger.Parse("62787371136571152009"),BigInteger.Parse("1992942254830520803329"),BigInteger.Parse("63531842302018973818881"),BigInteger.Parse("2033004661359005674887561") };
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
public class A243949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243949Inst Instance=new A243949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243950
{
public static readonly BigInteger[] Value={ 1L,2L,11L,100L,1677L,49974L,2801567L,293257480L,59426801521L,23154622451162L,17786849024835651L,BigInteger.Parse("26694462878992491180"),BigInteger.Parse("79786045619298591331605"),BigInteger.Parse("469805503062346255040726910"),BigInteger.Parse("5538428985758278544518994721255"),BigInteger.Parse("129179377104085570277109465712798800"),BigInteger.Parse("6048537751321912538368011648067930447545") };
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
public class A243950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243950Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243950.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243950Inst Instance=new A243950Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243951
{
public static readonly BigInteger[] Value={ 1L,1L,5L,45L,781L,23981L,1371885L,145101805L,29560055405L,11546945197165L,8881721878376045L,13338290506465706605UL,BigInteger.Parse("39879639563413780322925"),BigInteger.Parse("234862804790553590007179885"),BigInteger.Parse("2768979430068663216466330446445"),BigInteger.Parse("64586918396493458414460474344516205"),BigInteger.Parse("3024204274887062319005574660727125346925") };
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
public class A243951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243951Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243951.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243951Inst Instance=new A243951Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243952
{
public static readonly BigInteger[] Value={ 1L,1L,5L,29L,217L,2185L,27965L,424325L,7379185L,145153105L,3196294325L,77897895725L,2079802839625L,60350978376025L,1891418286217325L,63678498456207125L,2292013408161318625L,BigInteger.Parse("87825945807276510625"),BigInteger.Parse("3569447845239610305125"),BigInteger.Parse("153366779265711453624125") };
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
public class A243952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243952Inst Instance=new A243952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243953
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,56L,592L,8512L,155584L,3456896L,90501632L,2728876544L,93143809024L,3550380249088L,149488545697792L,6890674623094784L,345131685337530368L,BigInteger.Parse("18664673706719019008"),BigInteger.Parse("1083931601731053223936"),BigInteger.Parse("67278418002152175960064"),BigInteger.Parse("4444711314548967826259968") };
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
public class A243953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243953Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243953.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243953Inst Instance=new A243953Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243954
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,-8L,-95L,-144L,5299L,51584L,-263007L,-11283200L,-61279229L,2321353728L,49471727617L,-217783810048L,-25824369466125L,-298783278792704L,10591512134358721L,400315590893961216L,-536860171776183677L,BigInteger.Parse("-362306852971970560000"),BigInteger.Parse("-7292410691309793586719"),BigInteger.Parse("227379942363338919903232") };
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
public class A243954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243954Inst Instance=new A243954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243955
{
public static readonly long[] Value={ 12L,79L,761L,761L,761L,761L,761L,36356642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243955Inst : IEnumerable<long>
{
public static readonly long[] Value=A243955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243955.Bytes);
public long this[int i]=>Value[i];

public static A243955Inst Instance=new A243955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243956
{
public static readonly long[] Value={ 1L,16L,67L,86L,131L,151L,186L,191L,211L,226L,541L,701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243956Inst : IEnumerable<long>
{
public static readonly long[] Value=A243956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243956.Bytes);
public long this[int i]=>Value[i];

public static A243956Inst Instance=new A243956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243957
{
public static readonly long[] Value={ 499L,787L,1471L,1867L,2767L,3271L,4999L,5647L,8599L,13099L,14107L,16231L,19687L,22171L,24799L,33547L,40099L,43591L,52951L,63211L,65371L,67567L,79087L,88951L,94099L,99391L,104827L,107599L,116131L,119047L,124987L,131071L,153499L,160231L,167107L,177691L,192307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243957Inst : IEnumerable<long>
{
public static readonly long[] Value=A243957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243957.Bytes);
public long this[int i]=>Value[i];

public static A243957Inst Instance=new A243957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243958
{
public static readonly long[] Value={ 317L,521L,857L,977L,1229L,1361L,1637L,2081L,2237L,2729L,3257L,3821L,4217L,4421L,5501L,6197L,8501L,9341L,9629L,12401L,13397L,14081L,15137L,15497L,16229L,18521L,18917L,20129L,21377L,22229L,23537L,23981L,26261L,26729L,29129L,31121L,32141L,35837L,36929L,39161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243958Inst : IEnumerable<long>
{
public static readonly long[] Value=A243958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243958.Bytes);
public long this[int i]=>Value[i];

public static A243958Inst Instance=new A243958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243959
{
public static readonly long[] Value={ 75898L,341112L,356926L,475856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243959Inst : IEnumerable<long>
{
public static readonly long[] Value=A243959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243959.Bytes);
public long this[int i]=>Value[i];

public static A243959Inst Instance=new A243959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243960
{
public static readonly long[] Value={ 2L,11L,17L,23L,31L,41L,53L,59L,79L,83L,101L,113L,137L,149L,167L,179L,197L,229L,251L,263L,269L,281L,283L,311L,317L,331L,349L,383L,433L,439L,457L,461L,463L,479L,487L,499L,503L,509L,521L,547L,577L,593L,599L,619L,641L,661L,673L,683L,691L,709L,739L,769L,787L,809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243960Inst : IEnumerable<long>
{
public static readonly long[] Value=A243960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243960.Bytes);
public long this[int i]=>Value[i];

public static A243960Inst Instance=new A243960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243961
{
public static readonly long[] Value={ 1L,4L,2L,3L,6L,0L,0L,3L,0L,6L,0L,4L,5L,2L,7L,7L,7L,5L,3L,0L,7L,8L,3L,2L,4L,6L,4L,9L,3L,0L,6L,2L,5L,7L,2L,5L,3L,0L,8L,6L,7L,2L,5L,2L,7L,0L,6L,9L,4L,8L,3L,1L,4L,3L,2L,2L,2L,5L,9L,1L,7L,5L,5L,4L,7L,8L,3L,5L,5L,5L,1L,2L,6L,8L,5L,2L,8L,1L,4L,2L,1L,6L,4L,2L,8L,9L,8L,8L,6L,5L,9L,7L,6L,9L,2L,7L,5L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243961Inst : IEnumerable<long>
{
public static readonly long[] Value=A243961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243961.Bytes);
public long this[int i]=>Value[i];

public static A243961Inst Instance=new A243961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243962
{
public static readonly long[] Value={ 7L,13L,19L,103L,823L,1021L,1579L,1867L,2503L,3331L,5779L,6871L,6949L,9007L,10093L,10399L,11317L,11743L,13327L,13381L,15859L,16657L,17539L,17659L,22189L,26317L,26557L,26821L,27397L,27943L,29209L,29383L,30211L,32443L,37309L,38287L,40213L,40507L,44497L,47569L,47977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243962Inst : IEnumerable<long>
{
public static readonly long[] Value=A243962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243962.Bytes);
public long this[int i]=>Value[i];

public static A243962Inst Instance=new A243962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243963
{
public static readonly long[] Value={ 0L,0L,2L,3L,-8L,-25L,96L,427L,-2176L,-12465L,79360L,555731L,-4245504L,-35135945L,313155584L,2990414715L,-30460116992L,-329655706465L,3777576173568L,45692713833379L,-581777702256640L,-7777794952988025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243963Inst : IEnumerable<long>
{
public static readonly long[] Value=A243963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243963.Bytes);
public long this[int i]=>Value[i];

public static A243963Inst Instance=new A243963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243964
{
public static readonly long[] Value={ 3L,7L,2L,8L,9L,7L,1L,4L,3L,2L,8L,6L,7L,2L,8L,9L,9L,4L,2L,2L,0L,2L,1L,1L,2L,2L,8L,7L,6L,2L,1L,1L,4L,6L,0L,2L,1L,7L,6L,3L,5L,9L,2L,9L,2L,0L,0L,0L,4L,6L,7L,3L,7L,5L,7L,9L,5L,7L,8L,4L,9L,1L,7L,6L,7L,2L,4L,8L,9L,4L,6L,2L,1L,5L,3L,8L,5L,0L,7L,7L,7L,9L,6L,3L,0L,6L,7L,5L,7L,3L,9L,8L,0L,1L,0L,4L,5L,7L,6L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243964Inst : IEnumerable<long>
{
public static readonly long[] Value=A243964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243964.Bytes);
public long this[int i]=>Value[i];

public static A243964Inst Instance=new A243964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243965
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,10L,44L,179L,702L,2701L,10278L,38866L,146450L,550817L,2070116L,7779655L,29248932L,110047905L,414446256L,1562538171L,5898049688L,22290789562L,84351810044L,319609669957L,1212552963576L,4606078246284L,17518748817596L,66712192842068L,254346235738120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243965Inst : IEnumerable<long>
{
public static readonly long[] Value=A243965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243965.Bytes);
public long this[int i]=>Value[i];

public static A243965Inst Instance=new A243965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243966
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,12L,138L,1152L,8166L,52098L,308964L,1733444L,9311300L,48280464L,243112106L,1194286106L,5744306228L,27129749648L,126111332862L,578106334718L,2617667137358L,11723920607410L,51998857149406L,228621028644376L,997286152915772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243966Inst : IEnumerable<long>
{
public static readonly long[] Value=A243966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243966.Bytes);
public long this[int i]=>Value[i];

public static A243966Inst Instance=new A243966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243967
{
public static readonly long[] Value={ 1L,3L,5L,0L,5L,0L,6L,1L,2L,5L,1L,3L,1L,1L,7L,1L,5L,3L,0L,3L,3L,1L,8L,3L,7L,6L,7L,7L,2L,2L,6L,2L,4L,1L,5L,9L,7L,2L,5L,2L,3L,0L,6L,9L,8L,0L,3L,1L,3L,0L,1L,9L,2L,5L,5L,8L,6L,0L,9L,7L,8L,4L,0L,6L,1L,6L,4L,5L,0L,7L,4L,0L,0L,8L,8L,8L,8L,1L,5L,1L,3L,5L,8L,8L,9L,8L,3L,4L,8L,3L,5L,5L,6L,8L,5L,1L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243967Inst : IEnumerable<long>
{
public static readonly long[] Value=A243967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243967.Bytes);
public long this[int i]=>Value[i];

public static A243967Inst Instance=new A243967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243968
{
public static readonly long[] Value={ 1L,4L,2L,9L,8L,1L,5L,4L,9L,9L,9L,0L,0L,9L,9L,4L,5L,1L,9L,7L,0L,3L,9L,0L,6L,4L,4L,3L,7L,6L,2L,7L,6L,0L,9L,3L,1L,2L,6L,9L,2L,3L,8L,1L,5L,8L,8L,4L,7L,2L,5L,2L,4L,2L,3L,9L,5L,4L,8L,2L,1L,9L,4L,9L,6L,9L,6L,3L,6L,2L,6L,5L,4L,5L,4L,3L,7L,2L,8L,5L,6L,8L,8L,1L,1L,5L,8L,3L,6L,8L,9L,3L,8L,4L,7L,8L,1L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243968Inst : IEnumerable<long>
{
public static readonly long[] Value=A243968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243968.Bytes);
public long this[int i]=>Value[i];

public static A243968Inst Instance=new A243968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243969
{
public static readonly long[] Value={ 9175L,9351L,17676L,24826L,26038L,28612L,38026L,38158L,46212L,46927L,48247L,56473L,61863L,63075L,63898L,65649L,75063L,75195L,83425L,83964L,85284L,91750L,93510L,100935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243969Inst : IEnumerable<long>
{
public static readonly long[] Value=A243969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243969.Bytes);
public long this[int i]=>Value[i];

public static A243969Inst Instance=new A243969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243970
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,5L,4L,4L,7L,6L,10L,6L,6L,9L,8L,8L,16L,10L,10L,19L,15L,14L,12L,14L,14L,12L,26L,12L,12L,29L,16L,16L,21L,18L,34L,20L,18L,37L,18L,18L,27L,20L,20L,43L,24L,30L,46L,33L,32L,28L,24L,34L,39L,28L,24L,28L,28L,24L,58L,24L,24L,30L,32L,32L,64L,65L,30L,67L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243970Inst : IEnumerable<long>
{
public static readonly long[] Value=A243970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243970.Bytes);
public long this[int i]=>Value[i];

public static A243970Inst Instance=new A243970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243971
{
public static readonly long[] Value={ 1L,2L,5L,10L,16L,19L,26L,29L,34L,37L,43L,46L,58L,64L,65L,67L,73L,82L,86L,94L,101L,109L,122L,130L,134L,142L,145L,146L,149L,157L,163L,190L,193L,197L,199L,202L,206L,211L,229L,257L,262L,281L,283L,290L,298L,302L,310L,334L,337L,347L,349L,367L,401L,409L,421L,430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243971Inst : IEnumerable<long>
{
public static readonly long[] Value=A243971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243971.Bytes);
public long this[int i]=>Value[i];

public static A243971Inst Instance=new A243971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243972
{
public static readonly long[] Value={ 1L,16L,22L,23L,53L,70L,74L,93L,122L,147L,156L,167L,168L,222L,214L,221L,283L,315L,311L,312L,313L,314L,426L,466L,427L,474L,439L,563L,630L,576L,554L,575L,626L,627L,793L,722L,809L,766L,861L,889L,925L,893L,989L,890L,1077L,891L,983L,892L,1130L,1128L,1135L,1134L,1217L,1129L,1238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243972Inst : IEnumerable<long>
{
public static readonly long[] Value=A243972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243972.Bytes);
public long this[int i]=>Value[i];

public static A243972Inst Instance=new A243972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243973
{
public static readonly long[] Value={ 2L,5L,4L,8L,9L,1L,8L,9L,1L,8L,3L,5L,1L,6L,7L,3L,1L,4L,7L,5L,1L,2L,8L,0L,7L,7L,8L,1L,4L,1L,8L,5L,7L,5L,9L,4L,8L,1L,6L,7L,3L,5L,0L,4L,9L,8L,6L,7L,4L,1L,6L,3L,0L,2L,9L,8L,4L,5L,8L,9L,2L,3L,0L,3L,3L,5L,1L,6L,3L,4L,6L,6L,8L,6L,4L,8L,4L,6L,5L,7L,4L,1L,1L,7L,1L,1L,9L,3L,2L,5L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243973Inst : IEnumerable<long>
{
public static readonly long[] Value=A243973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243973.Bytes);
public long this[int i]=>Value[i];

public static A243973Inst Instance=new A243973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243974
{
public static readonly long[] Value={ 10176L,17601L,19361L,25827L,27147L,27686L,35916L,36048L,45462L,47213L,48036L,49248L,54638L,62864L,64184L,64899L,72953L,73085L,82499L,85073L,86285L,93435L,101760L,101936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243974Inst : IEnumerable<long>
{
public static readonly long[] Value=A243974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243974.Bytes);
public long this[int i]=>Value[i];

public static A243974Inst Instance=new A243974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243975
{
public static readonly long[] Value={ 1L,8L,11L,29L,32L,47L,34L,33L,90L,98L,112L,136L,128L,172L,111L,168L,146L,211L,241L,218L,220L,290L,278L,298L,323L,355L,329L,316L,344L,446L,427L,395L,410L,528L,481L,443L,498L,523L,574L,540L,531L,538L,618L,549L,694L,669L,733L,717L,788L,707L,740L,734L,831L,743L,857L,850L,864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243975Inst : IEnumerable<long>
{
public static readonly long[] Value=A243975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243975.Bytes);
public long this[int i]=>Value[i];

public static A243975Inst Instance=new A243975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243976
{
public static readonly long[] Value={ 3L,6L,7L,3L,8L,8L,6L,5L,7L,8L,3L,4L,1L,3L,1L,7L,7L,7L,5L,4L,9L,8L,9L,1L,9L,6L,3L,2L,7L,0L,3L,3L,8L,1L,8L,2L,7L,7L,3L,0L,3L,5L,7L,0L,0L,3L,9L,7L,1L,7L,2L,9L,6L,1L,1L,3L,0L,9L,3L,0L,0L,9L,5L,9L,5L,0L,1L,6L,6L,2L,0L,9L,2L,1L,5L,6L,4L,6L,8L,6L,9L,9L,3L,2L,7L,7L,7L,0L,3L,1L,8L,5L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243976Inst : IEnumerable<long>
{
public static readonly long[] Value=A243976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243976.Bytes);
public long this[int i]=>Value[i];

public static A243976Inst Instance=new A243976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243977
{
public static readonly long[] Value={ 3L,1L,2L,1L,1L,1L,3L,1L,0L,2L,3L,3L,2L,1L,1L,5L,1L,2L,0L,1L,3L,1L,1L,1L,1L,1L,3L,1L,0L,3L,1L,4L,2L,1L,1L,3L,3L,3L,0L,1L,3L,1L,2L,1L,1L,1L,3L,1L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243977Inst : IEnumerable<long>
{
public static readonly long[] Value=A243977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243977.Bytes);
public long this[int i]=>Value[i];

public static A243977Inst Instance=new A243977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243978
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,0L,1L,0L,3L,1L,0L,1L,0L,6L,0L,0L,0L,1L,0L,7L,2L,1L,0L,0L,1L,0L,13L,1L,0L,0L,0L,0L,1L,0L,16L,4L,0L,1L,0L,0L,0L,1L,0L,25L,2L,2L,0L,0L,0L,0L,0L,1L,0L,33L,6L,1L,0L,1L,0L,0L,0L,0L,1L,0L,49L,4L,2L,0L,0L,0L,0L,0L,0L,0L,1L,0L,61L,9L,3L,2L,0L,1L,0L,0L,0L,0L,0L,1L,0L,90L,6L,3L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,113L,16L,2L,2L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,156L,9L,7L,1L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243978Inst : IEnumerable<long>
{
public static readonly long[] Value=A243978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243978.Bytes);
public long this[int i]=>Value[i];

public static A243978Inst Instance=new A243978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243979
{
public static readonly long[] Value={ 2L,5L,14L,124L,399L,4552L,15898L,203095L,37029521L,105973558438L,19140185454656173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243979Inst : IEnumerable<long>
{
public static readonly long[] Value=A243979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243979.Bytes);
public long this[int i]=>Value[i];

public static A243979Inst Instance=new A243979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243980
{
public static readonly long[] Value={ 4L,16L,32L,60L,84L,132L,164L,224L,276L,348L,396L,508L,564L,660L,756L,880L,952L,1108L,1188L,1356L,1484L,1628L,1724L,1964L,2088L,2256L,2416L,2640L,2760L,3048L,3176L,3428L,3620L,3836L,4028L,4392L,4544L,4784L,5008L,5368L,5536L,5920L,6096L,6432L,6744L,7032L,7224L,7720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243980Inst : IEnumerable<long>
{
public static readonly long[] Value=A243980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243980.Bytes);
public long this[int i]=>Value[i];

public static A243980Inst Instance=new A243980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243981
{
public static readonly long[] Value={ 1L,2L,0L,4L,1L,6L,0L,0L,3L,10L,1L,12L,5L,2L,0L,16L,1L,18L,1L,4L,9L,22L,1L,0L,11L,0L,3L,28L,1L,30L,0L,8L,15L,2L,0L,36L,17L,10L,3L,40L,1L,42L,7L,2L,21L,46L,1L,0L,3L,14L,9L,52L,1L,6L,1L,16L,27L,58L,2L,60L,29L,2L,0L,8L,5L,66L,13L,20L,3L,70L,1L,72L,35L,2L,15L,4L,7L,78L,1L,0L,39L,82L,4L,12L,41L,26L,3L,88L,1L,6L,19L,28L,45L,14L,1L,96L,5L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243981Inst : IEnumerable<long>
{
public static readonly long[] Value=A243981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243981.Bytes);
public long this[int i]=>Value[i];

public static A243981Inst Instance=new A243981Inst();

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