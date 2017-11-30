using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A118141
{
public static readonly long[] Value={ 2L,3L,5L,4L,23L,8L,11L,27L,29L,30L,47L,62L,17L,339L,23L,254L,167L,512L,59L,2339L,185L,2046L,95L,1024L,125L,2043L,35L,3276L,2039L,340L,47L,4091L,509L,4094L,335L,3590L,1025L,16379L,119L,1048574L,4679L,16382L,371L,92819L,12281L,8388606L,191L,2097152L,6149L,262139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118141Inst : IEnumerable<long>
{
public static readonly long[] Value=A118141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118141.Bytes);
public long this[int i]=>Value[i];

public static A118141Inst Instance=new A118141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118142
{
public static readonly long[] Value={ 4L,5L,9L,11L,16L,19L,23L,29L,30L,32L,33L,39L,47L,59L,61L,62L,64L,65L,67L,79L,84L,95L,101L,119L,123L,125L,126L,128L,129L,131L,135L,154L,159L,164L,169L,170L,185L,191L,203L,204L,239L,247L,251L,253L,254L,256L,257L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118142Inst : IEnumerable<long>
{
public static readonly long[] Value=A118142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118142.Bytes);
public long this[int i]=>Value[i];

public static A118142Inst Instance=new A118142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118143
{
public static readonly long[] Value={ 4L,5L,11L,16L,23L,29L,30L,32L,47L,59L,62L,64L,65L,84L,95L,101L,119L,125L,126L,128L,131L,154L,164L,170L,185L,191L,203L,204L,239L,251L,254L,256L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118143Inst : IEnumerable<long>
{
public static readonly long[] Value=A118143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118143.Bytes);
public long this[int i]=>Value[i];

public static A118143Inst Instance=new A118143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118144
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,2L,2L,2L,1L,3L,2L,2L,2L,2L,1L,1L,2L,2L,3L,2L,1L,3L,2L,4L,2L,3L,3L,3L,3L,3L,2L,3L,4L,2L,3L,2L,1L,2L,2L,1L,2L,3L,4L,4L,3L,2L,1L,2L,4L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118144Inst : IEnumerable<long>
{
public static readonly long[] Value=A118144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118144.Bytes);
public long this[int i]=>Value[i];

public static A118144Inst Instance=new A118144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118145
{
public static readonly long[] Value={ 1L,48L,131L,178L,918L,866L,715L,564L,512L,262L,309L,950L,106L,648L,893L,445L,591L,242L,289L,1029L,9248L,8476L,6795L,6023L,3253L,3570L,800L,55L,102L,248L,889L,1035L,5348L,8482L,2895L,6029L,9253L,3576L,6800L,133L,378L,920L,76L,114L,458L,901L,156L,698L,943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118145Inst : IEnumerable<long>
{
public static readonly long[] Value=A118145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118145.Bytes);
public long this[int i]=>Value[i];

public static A118145Inst Instance=new A118145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118146
{
public static readonly long[] Value={ 1L,50L,54L,94L,98L,138L,880L,137L,780L,136L,680L,135L,580L,134L,480L,133L,380L,132L,280L,131L,180L,130L,80L,57L,124L,470L,123L,370L,122L,270L,121L,170L,120L,70L,56L,114L,460L,113L,360L,112L,260L,111L,160L,110L,60L,55L,104L,450L,103L,350L,102L,250L,101L,150L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118146Inst : IEnumerable<long>
{
public static readonly long[] Value=A118146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118146.Bytes);
public long this[int i]=>Value[i];

public static A118146Inst Instance=new A118146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118147
{
public static readonly long[] Value={ 1L,51L,65L,106L,651L,206L,652L,306L,653L,406L,654L,506L,655L,606L,656L,706L,657L,806L,658L,906L,659L,1006L,6051L,1556L,6601L,1116L,6161L,1666L,6711L,1226L,6271L,1776L,6821L,1336L,6381L,1886L,6931L,1446L,6491L,1996L,7041L,1457L,7591L,2007L,7052L,2557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118147Inst : IEnumerable<long>
{
public static readonly long[] Value=A118147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118147.Bytes);
public long this[int i]=>Value[i];

public static A118147Inst Instance=new A118147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118148
{
public static readonly long[] Value={ 1L,52L,76L,118L,862L,319L,964L,520L,76L,118L,862L,319L,964L,520L,76L,118L,862L,319L,964L,520L,76L,118L,862L,319L,964L,520L,76L,118L,862L,319L,964L,520L,76L,118L,862L,319L,964L,520L,76L,118L,862L,319L,964L,520L,76L,118L,862L,319L,964L,520L,76L,118L,862L,319L,964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118148Inst : IEnumerable<long>
{
public static readonly long[] Value=A118148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118148.Bytes);
public long this[int i]=>Value[i];

public static A118148Inst Instance=new A118148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118149
{
public static readonly long[] Value={ 1L,53L,87L,130L,83L,90L,61L,68L,138L,883L,440L,96L,121L,173L,423L,376L,725L,579L,1027L,7253L,3579L,9805L,5141L,1467L,7693L,4019L,9156L,6571L,1808L,8133L,3370L,785L,639L,988L,941L,201L,154L,503L,357L,805L,560L,117L,763L,419L,966L,721L,179L,1023L,3253L,3575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118149Inst : IEnumerable<long>
{
public static readonly long[] Value=A118149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118149.Bytes);
public long this[int i]=>Value[i];

public static A118149Inst Instance=new A118149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118150
{
public static readonly long[] Value={ 1L,54L,98L,142L,294L,545L,598L,948L,902L,262L,315L,566L,718L,870L,131L,184L,534L,488L,937L,792L,350L,106L,654L,509L,958L,912L,272L,325L,576L,728L,880L,141L,194L,544L,498L,947L,802L,261L,215L,565L,618L,869L,1021L,1254L,4574L,4807L,7137L,7370L,790L,150L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118150Inst : IEnumerable<long>
{
public static readonly long[] Value=A118150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118150.Bytes);
public long this[int i]=>Value[i];

public static A118150Inst Instance=new A118150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118151
{
public static readonly long[] Value={ 1L,55L,109L,955L,613L,370L,127L,775L,631L,190L,145L,595L,649L,1000L,55L,109L,955L,613L,370L,127L,775L,631L,190L,145L,595L,649L,1000L,55L,109L,955L,613L,370L,127L,775L,631L,190L,145L,595L,649L,1000L,55L,109L,955L,613L,370L,127L,775L,631L,190L,145L,595L,649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118151Inst : IEnumerable<long>
{
public static readonly long[] Value=A118151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118151.Bytes);
public long this[int i]=>Value[i];

public static A118151Inst Instance=new A118151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118152
{
public static readonly long[] Value={ 1L,57L,131L,187L,837L,794L,553L,411L,170L,127L,777L,833L,394L,549L,1001L,1057L,7557L,7613L,3223L,3279L,9779L,9835L,5445L,5501L,1111L,1167L,7667L,7723L,3333L,3389L,9889L,9945L,5555L,5611L,1221L,1277L,7777L,7833L,3443L,3499L,9999L,10055L,55057L,75111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118152Inst : IEnumerable<long>
{
public static readonly long[] Value=A118152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118152.Bytes);
public long this[int i]=>Value[i];

public static A118152Inst Instance=new A118152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118153
{
public static readonly long[] Value={ 1L,58L,142L,298L,949L,1006L,6058L,8563L,3715L,5230L,382L,340L,100L,58L,142L,298L,949L,1006L,6058L,8563L,3715L,5230L,382L,340L,100L,58L,142L,298L,949L,1006L,6058L,8563L,3715L,5230L,382L,340L,100L,58L,142L,298L,949L,1006L,6058L,8563L,3715L,5230L,382L,340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118153Inst : IEnumerable<long>
{
public static readonly long[] Value=A118153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118153.Bytes);
public long this[int i]=>Value[i];

public static A118153Inst Instance=new A118153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118154
{
public static readonly long[] Value={ 1L,59L,153L,409L,962L,327L,781L,245L,600L,64L,104L,459L,1012L,2159L,9570L,817L,776L,735L,595L,653L,414L,472L,332L,291L,250L,110L,69L,154L,509L,963L,427L,782L,345L,601L,164L,519L,973L,437L,792L,355L,611L,174L,529L,983L,447L,802L,266L,720L,85L,116L,669L,1024L,4259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118154Inst : IEnumerable<long>
{
public static readonly long[] Value=A118154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118154.Bytes);
public long this[int i]=>Value[i];

public static A118154Inst Instance=new A118154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118155
{
public static readonly long[] Value={ 1L,60L,65L,115L,570L,134L,490L,153L,410L,73L,96L,128L,880L,147L,800L,67L,135L,590L,154L,510L,74L,106L,660L,125L,580L,144L,500L,64L,105L,560L,124L,480L,143L,400L,63L,95L,118L,870L,137L,790L,156L,710L,76L,126L,680L,145L,600L,65L,115L,570L,134L,490L,153L,410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118155Inst : IEnumerable<long>
{
public static readonly long[] Value=A118155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118155.Bytes);
public long this[int i]=>Value[i];

public static A118155Inst Instance=new A118155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118156
{
public static readonly long[] Value={ 1L,62L,87L,139L,992L,360L,124L,482L,345L,604L,467L,825L,589L,1046L,6462L,2707L,7133L,3378L,8794L,5039L,9366L,6700L,137L,792L,358L,914L,480L,145L,602L,267L,823L,389L,1044L,4462L,2705L,5133L,3379L,6794L,5037L,7366L,6698L,9027L,7270L,788L,948L,910L,80L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118156Inst : IEnumerable<long>
{
public static readonly long[] Value=A118156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118156.Bytes);
public long this[int i]=>Value[i];

public static A118156Inst Instance=new A118156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118157
{
public static readonly long[] Value={ 1L,63L,98L,151L,213L,374L,535L,597L,857L,820L,90L,71L,79L,459L,1013L,3163L,3675L,5825L,5347L,7497L,8009L,9070L,771L,239L,994L,561L,227L,784L,549L,1007L,7063L,3669L,9725L,5341L,1497L,8003L,3070L,765L,629L,988L,951L,221L,184L,543L,407L,766L,729L,989L,1051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118157Inst : IEnumerable<long>
{
public static readonly long[] Value=A118157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118157.Bytes);
public long this[int i]=>Value[i];

public static A118157Inst Instance=new A118157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118158
{
public static readonly long[] Value={ 1L,64L,109L,964L,532L,298L,955L,622L,289L,1045L,5464L,4708L,8137L,7381L,1900L,154L,514L,478L,937L,802L,271L,235L,595L,658L,919L,982L,352L,316L,676L,739L,1000L,64L,109L,964L,532L,298L,955L,622L,289L,1045L,5464L,4708L,8137L,7381L,1900L,154L,514L,478L,937L,802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118158Inst : IEnumerable<long>
{
public static readonly long[] Value=A118158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118158.Bytes);
public long this[int i]=>Value[i];

public static A118158Inst Instance=new A118158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118159
{
public static readonly long[] Value={ 1L,65L,120L,85L,122L,285L,646L,710L,81L,82L,92L,93L,103L,365L,627L,790L,161L,225L,586L,749L,1011L,1165L,5675L,5829L,9349L,9503L,3123L,3277L,7787L,7941L,1564L,1715L,5235L,5389L,9899L,10053L,35065L,56117L,71229L,92281L,18293L,39345L,54457L,75509L,90621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118159Inst : IEnumerable<long>
{
public static readonly long[] Value=A118159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118159.Bytes);
public long this[int i]=>Value[i];

public static A118159Inst Instance=new A118159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118160
{
public static readonly long[] Value={ 1L,49L,142L,289L,1030L,349L,991L,247L,790L,145L,589L,1033L,3349L,9481L,1897L,8029L,9256L,6577L,7804L,4135L,5362L,2683L,3910L,241L,190L,139L,979L,1027L,7249L,9475L,7597L,8023L,3256L,6571L,1804L,4129L,9262L,2677L,7810L,235L,580L,133L,379L,1021L,1249L,9469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118160Inst : IEnumerable<long>
{
public static readonly long[] Value=A118160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118160.Bytes);
public long this[int i]=>Value[i];

public static A118160Inst Instance=new A118160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118161
{
public static readonly long[] Value={ 1L,56L,120L,76L,276L,727L,782L,342L,298L,947L,804L,463L,419L,969L,1024L,4256L,6579L,9811L,1244L,4476L,6799L,10031L,31056L,56068L,86120L,2223L,3277L,7778L,8832L,2443L,3497L,7998L,9052L,2564L,4707L,7129L,9272L,2784L,4927L,7349L,9492L,3004L,4058L,8559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118161Inst : IEnumerable<long>
{
public static readonly long[] Value=A118161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118161.Bytes);
public long this[int i]=>Value[i];

public static A118161Inst Instance=new A118161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118162
{
public static readonly long[] Value={ 1L,61L,76L,127L,781L,247L,802L,268L,922L,289L,1042L,2461L,1702L,2131L,1372L,2791L,2032L,2362L,2692L,3022L,2263L,3682L,2923L,3352L,2593L,4012L,2164L,4672L,2824L,4342L,2494L,5002L,2065L,5662L,2725L,5332L,2395L,5992L,3055L,5563L,3715L,5233L,3385L,5893L,4045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118162Inst : IEnumerable<long>
{
public static readonly long[] Value=A118162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118162.Bytes);
public long this[int i]=>Value[i];

public static A118162Inst Instance=new A118162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118163
{
public static readonly long[] Value={ 1L,66L,131L,196L,756L,722L,292L,357L,818L,883L,453L,419L,979L,1044L,4466L,6709L,9141L,1484L,4906L,6159L,9581L,1924L,4356L,6599L,10021L,12066L,66086L,68131L,13251L,15296L,69316L,61461L,16481L,18526L,62646L,64691L,19711L,11856L,65876L,67921L,13041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118163Inst : IEnumerable<long>
{
public static readonly long[] Value=A118163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118163.Bytes);
public long this[int i]=>Value[i];

public static A118163Inst Instance=new A118163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118164
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,4L,1L,2L,1L,3L,1L,2L,1L,2L,2L,3L,1L,2L,3L,1L,2L,3L,2L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,3L,2L,2L,1L,2L,1L,1L,1L,3L,1L,1L,4L,1L,2L,1L,3L,1L,2L,1L,2L,1L,1L,2L,2L,1L,3L,1L,3L,4L,2L,1L,3L,1L,2L,2L,2L,3L,1L,1L,1L,2L,2L,1L,3L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118164Inst : IEnumerable<long>
{
public static readonly long[] Value=A118164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118164.Bytes);
public long this[int i]=>Value[i];

public static A118164Inst Instance=new A118164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118165
{
public static readonly long[] Value={ 1L,3L,8L,27L,23L,112L,236L,1050L,2210L,2561L,4016L,5504L,9325L,18328L,13506L,40150L,38789L,60881L,44541L,74499L,106766L,53339L,158352L,238255L,196734L,224410L,136750L,620509L,372124L,632976L,810969L,411364L,1034731L,1117857L,882335L,1672055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118165Inst : IEnumerable<long>
{
public static readonly long[] Value=A118165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118165.Bytes);
public long this[int i]=>Value[i];

public static A118165Inst Instance=new A118165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118166
{
public static readonly long[] Value={ 1L,3L,11L,43L,35L,162L,311L,1203L,2405L,2769L,4257L,5772L,9639L,18711L,13860L,40635L,39270L,61425L,45045L,75075L,107415L,53865L,159075L,239085L,197505L,225225L,137445L,621621L,373065L,634095L,812175L,412335L,1036035L,1119195L,883575L,1673595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118166Inst : IEnumerable<long>
{
public static readonly long[] Value=A118166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118166.Bytes);
public long this[int i]=>Value[i];

public static A118166Inst Instance=new A118166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118167
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,93L,464L,1915L,6336L,316224L,2805257L,23139584L,91581111L,3772979200L,77178291200L,1022362697389L,12006689439744L,52812321503747L,4709633119830016L,110533093583273984L,1995008117795780625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118167Inst : IEnumerable<long>
{
public static readonly long[] Value=A118167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118167.Bytes);
public long this[int i]=>Value[i];

public static A118167Inst Instance=new A118167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118168
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,4L,5L,6L,6L,7L,8L,9L,10L,10L,11L,12L,13L,14L,14L,15L,16L,17L,18L,18L,19L,20L,21L,22L,22L,23L,24L,25L,26L,27L,27L,28L,29L,30L,31L,32L,32L,33L,34L,35L,36L,37L,37L,38L,39L,40L,41L,42L,42L,43L,44L,45L,46L,47L,47L,48L,49L,50L,51L,52L,52L,53L,54L,55L,56L,57L,57L,58L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118168Inst : IEnumerable<long>
{
public static readonly long[] Value=A118168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118168.Bytes);
public long this[int i]=>Value[i];

public static A118168Inst Instance=new A118168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118169
{
public static readonly BigInteger[] Value={ 0L,0L,2L,3L,136L,1915L,6336L,460663L,13148416L,91581111L,3772979200L,198133379411L,7608426080256L,52812321503747L,4709633119830016L,316248789972027375L,16013842065532911616UL,BigInteger.Parse("296760465891270915823"),BigInteger.Parse("13494391336411560935424") };
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
public class A118169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118169Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118169.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118169Inst Instance=new A118169Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118170
{
public static readonly long[] Value={ 1L,1L,3L,4L,5L,7L,8L,9L,10L,12L,13L,14L,15L,17L,18L,19L,20L,22L,23L,24L,25L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,63L,64L,65L,66L,67L,68L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L,83L,84L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118170Inst : IEnumerable<long>
{
public static readonly long[] Value=A118170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118170.Bytes);
public long this[int i]=>Value[i];

public static A118170Inst Instance=new A118170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118171
{
public static readonly long[] Value={ 1L,7L,29L,115L,477L,1843L,7645L,29491L,122333L,471859L,1957341L,7549747L,31317469L,120795955L,501079517L,1932735283L,8017272285L,30923764531L,128276356573L,494780232499L,2052421705181L,7916483719987L,32838747282909L,126663739519795L,525419956526557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118171Inst : IEnumerable<long>
{
public static readonly long[] Value=A118171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118171.Bytes);
public long this[int i]=>Value[i];

public static A118171Inst Instance=new A118171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118172
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118172Inst : IEnumerable<long>
{
public static readonly long[] Value=A118172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118172.Bytes);
public long this[int i]=>Value[i];

public static A118172Inst Instance=new A118172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118173
{
public static readonly long[] Value={ 1L,3L,5L,15L,29L,55L,93L,247L,477L,887L,1501L,3959L,7645L,14199L,24029L,63351L,122333L,227191L,384477L,1013623L,1957341L,3635063L,6151645L,16217975L,31317469L,58161015L,98426333L,259487607L,501079517L,930576247L,1574821341L,4151801719L,8017272285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118173Inst : IEnumerable<long>
{
public static readonly long[] Value=A118173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118173.Bytes);
public long this[int i]=>Value[i];

public static A118173Inst Instance=new A118173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118174
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118174Inst : IEnumerable<long>
{
public static readonly long[] Value=A118174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118174.Bytes);
public long this[int i]=>Value[i];

public static A118174Inst Instance=new A118174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118175
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118175Inst : IEnumerable<long>
{
public static readonly long[] Value=A118175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118175.Bytes);
public long this[int i]=>Value[i];

public static A118175Inst Instance=new A118175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118176
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,2L,7L,8L,8L,4L,11L,5L,11L,12L,15L,7L,16L,8L,18L,16L,17L,11L,23L,23L,21L,21L,25L,14L,29L,15L,29L,24L,25L,26L,35L,20L,27L,27L,38L,24L,39L,26L,40L,41L,30L,29L,47L,45L,45L,35L,46L,33L,49L,36L,51L,37L,38L,38L,59L,39L,39L,57L,63L,40L,60L,45L,60L,44L,64L,49L,69L,51L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118176Inst : IEnumerable<long>
{
public static readonly long[] Value=A118176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118176.Bytes);
public long this[int i]=>Value[i];

public static A118176Inst Instance=new A118176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118177
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,2L,4L,4L,3L,2L,2L,2L,6L,4L,2L,5L,4L,6L,5L,2L,2L,2L,2L,4L,4L,3L,4L,2L,4L,2L,8L,3L,4L,4L,6L,4L,4L,4L,8L,4L,4L,8L,2L,8L,2L,2L,6L,6L,4L,4L,4L,3L,9L,4L,2L,4L,4L,2L,4L,4L,4L,6L,8L,12L,6L,12L,6L,7L,3L,4L,4L,2L,8L,2L,6L,2L,8L,2L,8L,4L,4L,5L,8L,4L,4L,8L,6L,4L,2L,5L,2L,4L,4L,4L,4L,4L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118177Inst : IEnumerable<long>
{
public static readonly long[] Value=A118177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118177.Bytes);
public long this[int i]=>Value[i];

public static A118177Inst Instance=new A118177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118178
{
public static readonly long[] Value={ 6L,0L,9L,7L,2L,2L,3L,4L,7L,0L,1L,0L,4L,9L,1L,6L,0L,4L,6L,4L,3L,0L,3L,7L,4L,2L,0L,5L,6L,7L,3L,9L,9L,7L,8L,3L,3L,4L,9L,2L,3L,3L,7L,8L,1L,8L,3L,8L,6L,5L,5L,5L,1L,1L,4L,8L,6L,6L,1L,7L,3L,2L,1L,0L,0L,8L,2L,0L,4L,3L,7L,5L,4L,9L,4L,4L,1L,4L,0L,9L,3L,2L,0L,1L,3L,5L,4L,9L,6L,1L,4L,3L,3L,6L,5L,9L,1L,7L,6L,1L,0L,7L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118178Inst : IEnumerable<long>
{
public static readonly long[] Value=A118178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118178.Bytes);
public long this[int i]=>Value[i];

public static A118178Inst Instance=new A118178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118179
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,11L,13L,14L,15L,18L,21L,22L,23L,25L,27L,28L,31L,32L,33L,34L,35L,38L,40L,41L,42L,44L,47L,48L,49L,50L,51L,52L,55L,56L,57L,60L,61L,62L,65L,67L,68L,70L,71L,72L,73L,74L,75L,76L,79L,82L,83L,84L,86L,88L,89L,90L,91L,96L,98L,99L,100L,101L,103L,104L,105L,106L,107L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118179Inst : IEnumerable<long>
{
public static readonly long[] Value=A118179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118179.Bytes);
public long this[int i]=>Value[i];

public static A118179Inst Instance=new A118179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118180
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,9L,9L,1L,1L,27L,81L,27L,1L,1L,81L,729L,729L,81L,1L,1L,243L,6561L,19683L,6561L,243L,1L,1L,729L,59049L,531441L,531441L,59049L,729L,1L,1L,2187L,531441L,14348907L,43046721L,14348907L,531441L,2187L,1L,1L,6561L,4782969L,387420489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118180Inst : IEnumerable<long>
{
public static readonly long[] Value=A118180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118180.Bytes);
public long this[int i]=>Value[i];

public static A118180Inst Instance=new A118180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118181
{
public static readonly BigInteger[] Value={ 1L,2L,5L,20L,137L,1622L,33293L,1182440L,72811793L,7757988842L,1433154521621L,458101483131260L,253879024041595289L,BigInteger.Parse("243453910296759945662"),BigInteger.Parse("404765167247068325944349"),BigInteger.Parse("1164432505878183620543030480") };
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
public class A118181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118181Inst Instance=new A118181Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118182
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,11L,37L,164L,1000L,8021L,81001L,1076006L,19683244L,473632031L,14349084877L,571833704648L,31381448626000L,2265367321680041L,205893684435186001L,BigInteger.Parse("24615565942378859210"),BigInteger.Parse("4052605390737766057684") };
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
public class A118182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118182Inst Instance=new A118182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118183
{
public static readonly BigInteger[] Value={ 1L,-1L,2L,-10L,134L,-4942L,505682L,-142838074L,108933186230L,-210663798566302L,812745803173573538L,BigInteger.Parse("6022271614633142122646"),BigInteger.Parse("-2489044042602910169970590746"),BigInteger.Parse("996768343710992528631250678460690"),BigInteger.Parse("-928936693384587466168289179772677376782") };
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
public class A118183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118183Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118183.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118183Inst Instance=new A118183Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118184
{
public static readonly BigInteger[] Value={ 0L,1L,-1L,3L,-23L,329L,18231L,-22030373L,34718491601L,-130548608723439L,1300095260497408879L,BigInteger.Parse("-35497483240662990289357"),BigInteger.Parse("2687397326811421691366217657"),BigInteger.Parse("-562747611676887059779727492799911"),BigInteger.Parse("320110532506391993959111359699070808231") };
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
public class A118184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118184Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118184.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118184Inst Instance=new A118184Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118185
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,16L,16L,1L,1L,64L,256L,64L,1L,1L,256L,4096L,4096L,256L,1L,1L,1024L,65536L,262144L,65536L,1024L,1L,1L,4096L,1048576L,16777216L,16777216L,1048576L,4096L,1L,1L,16384L,16777216L,1073741824L,4294967296L,1073741824L,16777216L,16384L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118185Inst : IEnumerable<long>
{
public static readonly long[] Value=A118185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118185.Bytes);
public long this[int i]=>Value[i];

public static A118185Inst Instance=new A118185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118186
{
public static readonly BigInteger[] Value={ 1L,2L,6L,34L,386L,8706L,395266L,35659778L,6476038146L,2336999211010L,1697654543745026L,2450521284684021762L,BigInteger.Parse("7120479243447937531906"),BigInteger.Parse("41112924905741324849774594"),BigInteger.Parse("477847273163370530909175414786") };
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
public class A118186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118186Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118186.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118186Inst Instance=new A118186Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118187
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,18L,81L,514L,5185L,73730L,1327361L,33685506L,1359217665L,77311508482L,5567355555841L,565149010231298L,91215553426898945L,BigInteger.Parse("20753150033413537794"),BigInteger.Parse("5977902509385249259521"),BigInteger.Parse("2427296516310194305630210") };
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
public class A118187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118187Inst Instance=new A118187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118188
{
public static readonly BigInteger[] Value={ 1L,-1L,3L,-33L,1407L,-237057L,158992383L,-425715556353L,4556004503093247L,BigInteger.Parse("-194971932801554579457"),BigInteger.Parse("33370662957719457037287423"),BigInteger.Parse("-22845215336421444625717664940033"),BigInteger.Parse("62557106610069521429900219032249827327"),BigInteger.Parse("-685195337175488637158242110253091749621661697") };
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
public class A118188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118188Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118188.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118188Inst Instance=new A118188Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118189
{
public static readonly BigInteger[] Value={ 0L,1L,-2L,19L,-764L,125701L,-83499002L,222705979399L,-2379643407695864L,BigInteger.Parse("101770765968904486921"),BigInteger.Parse("-17414214749792087566712822"),BigInteger.Parse("11920352399707142353576549941259"),BigInteger.Parse("-32640155138015817553201240150152052724"),BigInteger.Parse("357505372216293786145503061380504161718632461") };
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
public class A118189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118189Inst Instance=new A118189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118190
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,25L,25L,1L,1L,125L,625L,125L,1L,1L,625L,15625L,15625L,625L,1L,1L,3125L,390625L,1953125L,390625L,3125L,1L,1L,15625L,9765625L,244140625L,244140625L,9765625L,15625L,1L,1L,78125L,244140625L,30517578125L,152587890625L,30517578125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118190Inst : IEnumerable<long>
{
public static readonly long[] Value=A118190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118190.Bytes);
public long this[int i]=>Value[i];

public static A118190Inst Instance=new A118190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118191
{
public static readonly BigInteger[] Value={ 1L,2L,7L,52L,877L,32502L,2740627L,507843752L,214111484377L,198376465625002L,418186492923828127L,BigInteger.Parse("1937270172119160156252"),BigInteger.Parse("20419262349796295263671877"),BigInteger.Parse("472966350615029335022460937502"),BigInteger.Parse("24925857360591180741786959228515627") };
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
public class A118191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118191Inst Instance=new A118191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118192
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,27L,151L,1252L,18876L,421877L,11797501L,489062502L,36867190626L,4119892578127L,576049853531251L,119400024902343752L,BigInteger.Parse("45003894807128984376"),BigInteger.Parse("25145828723919677734377"),BigInteger.Parse("17579646409034759521875001") };
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
public class A118192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118192Inst Instance=new A118192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118193
{
public static readonly BigInteger[] Value={ 1L,-1L,4L,-76L,7124L,-3326876L,7760553124L,-90490361296876L,5275336666748203124L,BigInteger.Parse("-1537656615631182860546876"),BigInteger.Parse("2240970675863910673065189453124"),BigInteger.Parse("-16329855533286908545970966339091796876"),BigInteger.Parse("594974481262862479448134839533519744970703124") };
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
public class A118193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118193Inst Instance=new A118193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118194
{
public static readonly BigInteger[] Value={ 0L,1L,-3L,53L,-4871L,2262505L,-5269940619L,61424345593757L,-3580474937256484367L,BigInteger.Parse("1043606492389898678125009"),BigInteger.Parse("-1520932783784930699920673828115"),BigInteger.Parse("11082945991224258678496051788222656261"),BigInteger.Parse("-403804307486446123171767495567989349951171863") };
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
public class A118194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118194Inst Instance=new A118194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118195
{
public static readonly BigInteger[] Value={ 1L,1L,3L,23L,411L,15771L,1353045L,252512065L,106798723795L,99080638950595L,208993838938550873L,BigInteger.Parse("968425792397232696773"),BigInteger.Parse("10208662119796586878979989"),BigInteger.Parse("236472963735267887311598074949"),BigInteger.Parse("12462692176683507314938059670486683") };
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
public class A118195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118195Inst Instance=new A118195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118196
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,-1L,-1L,31L,-449L,4223L,377087L,-79232513L,13509592063L,-74458331137L,-5113818652864513L,11766261105083555839UL,BigInteger.Parse("-22128578595003966668801"),BigInteger.Parse("-88147548436159218430476289"),BigInteger.Parse("3787186430286106428653327941631"),BigInteger.Parse("-103331603080469761480767867413463041") };
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
public class A118196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118196Inst Instance=new A118196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118197
{
public static readonly BigInteger[] Value={ 0L,1L,0L,-1L,4L,-11L,-186L,10823L,-492536L,5125897L,10381552650L,-6405856963573L,3302055158456332L,2338316177882689549L,BigInteger.Parse("-30991279275364493410290"),BigInteger.Parse("224870687441604081662836751"),BigInteger.Parse("-1045565401111374322223949545456"),BigInteger.Parse("-50507259999091315834370754855632879") };
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
public class A118197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118197Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118197.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118197Inst Instance=new A118197Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118198
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,2L,0L,1L,1L,2L,2L,1L,0L,1L,2L,3L,2L,2L,1L,0L,1L,3L,4L,3L,2L,1L,1L,0L,1L,5L,6L,4L,2L,2L,1L,1L,0L,1L,7L,8L,5L,4L,2L,1L,1L,1L,0L,1L,10L,11L,8L,5L,2L,2L,1L,1L,1L,0L,1L,13L,15L,11L,7L,3L,2L,1L,1L,1L,1L,0L,1L,18L,20L,16L,9L,5L,2L,2L,1L,1L,1L,1L,0L,1L,23L,27L,21L,13L,6L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118198Inst : IEnumerable<long>
{
public static readonly long[] Value=A118198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118198.Bytes);
public long this[int i]=>Value[i];

public static A118198Inst Instance=new A118198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118199
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,3L,5L,7L,10L,13L,18L,23L,31L,40L,53L,68L,89L,113L,146L,184L,234L,293L,369L,458L,572L,706L,874L,1073L,1320L,1611L,1970L,2393L,2909L,3518L,4255L,5122L,6167L,7394L,8862L,10585L,12637L,15038L,17886L,21213L,25141L,29723L,35112L,41383L,48737L,57278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118199Inst : IEnumerable<long>
{
public static readonly long[] Value=A118199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118199.Bytes);
public long this[int i]=>Value[i];

public static A118199Inst Instance=new A118199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118200
{
public static readonly long[] Value={ 1L,67L,142L,307L,769L,1033L,3367L,7699L,10033L,33067L,76099L,99133L,33265L,56299L,99331L,13465L,56497L,79531L,13663L,36697L,79729L,92863L,36895L,59929L,93061L,16105L,50227L,72271L,17293L,39337L,73459L,95506L,30625L,52669L,96691L,19735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118200Inst : IEnumerable<long>
{
public static readonly long[] Value=A118200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118200.Bytes);
public long this[int i]=>Value[i];

public static A118200Inst Instance=new A118200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118201
{
public static readonly long[] Value={ 0L,1L,3L,6L,2L,7L,13L,20L,12L,21L,11L,22L,10L,23L,9L,24L,8L,25L,43L,62L,42L,63L,41L,18L,44L,68L,93L,66L,38L,67L,37L,5L,36L,69L,35L,70L,34L,71L,33L,72L,32L,73L,31L,74L,30L,75L,29L,76L,28L,77L,27L,78L,26L,79L,133L,188L,132L,189L,131L,190L,130L,191L,129L,192L,128L,193L,127L,60L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118201Inst : IEnumerable<long>
{
public static readonly long[] Value=A118201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118201.Bytes);
public long this[int i]=>Value[i];

public static A118201Inst Instance=new A118201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118202
{
public static readonly long[] Value={ 0L,1L,4L,2L,1715L,31L,3L,5L,16L,14L,12L,10L,8L,6L,476L,101L,99L,97L,23L,303L,7L,9L,11L,13L,15L,17L,52L,50L,48L,46L,44L,42L,40L,38L,36L,34L,32L,30L,28L,683L,681L,22L,20L,18L,24L,77L,699L,697L,703L,695L,693L,691L,689L,687L,1723L,1725L,1721L,267L,269L,2686L,67L,263L,19L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118202Inst : IEnumerable<long>
{
public static readonly long[] Value=A118202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118202.Bytes);
public long this[int i]=>Value[i];

public static A118202Inst Instance=new A118202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118203
{
public static readonly long[] Value={ 2L,3L,7L,10L,83L,203L,2459L,143L,27479L,206053L,12363637L,9714229L,326398337L,5303972629L,99007489223L,2227668509351L,71285392284151L,201975278145317L,21813330039599177L,11512590854238337L,212540138847467483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118203Inst : IEnumerable<long>
{
public static readonly long[] Value=A118203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118203.Bytes);
public long this[int i]=>Value[i];

public static A118203Inst Instance=new A118203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118204
{
public static readonly long[] Value={ 1L,1L,2L,3L,24L,60L,720L,42L,8064L,60480L,3628800L,2851200L,95800320L,1556755200L,29059430400L,653837184000L,20922789888000L,59281238016000L,6402373705728000L,3379030566912000L,62382102773760000L,91233825306624000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118204Inst : IEnumerable<long>
{
public static readonly long[] Value=A118204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118204.Bytes);
public long this[int i]=>Value[i];

public static A118204Inst Instance=new A118204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118205
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-1L,2L,-2L,2L,0L,-2L,3L,-2L,1L,2L,-3L,3L,-2L,0L,3L,-2L,3L,-2L,0L,2L,-2L,3L,-1L,0L,1L,-2L,5L,0L,0L,1L,-2L,1L,1L,2L,0L,1L,-2L,1L,4L,-1L,4L,-2L,-3L,6L,-2L,5L,6L,-8L,6L,-4L,2L,9L,-8L,7L,-4L,-1L,11L,-1L,5L,1L,-8L,5L,2L,4L,7L,-8L,4L,2L,1L,14L,-2L,0L,-1L,-6L,19L,2L,5L,6L,-15L,12L,1L,3L,18L,-17L,1L,9L,0L,29L,-4L,-3L,4L,-13L,14L,17L,2L,0L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118205Inst : IEnumerable<long>
{
public static readonly long[] Value=A118205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118205.Bytes);
public long this[int i]=>Value[i];

public static A118205Inst Instance=new A118205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118206
{
public static readonly long[] Value={ 1L,1L,0L,-1L,0L,0L,0L,-1L,-1L,0L,2L,0L,-2L,-2L,1L,2L,2L,-2L,-2L,0L,2L,-1L,-1L,-2L,2L,5L,4L,-5L,-5L,-2L,4L,2L,-2L,-7L,3L,8L,5L,-7L,-6L,1L,14L,4L,-9L,-14L,2L,5L,5L,-10L,-7L,6L,22L,3L,-12L,-20L,1L,15L,15L,-16L,-12L,4L,25L,6L,-14L,-31L,13L,33L,14L,-39L,-32L,-6L,39L,15L,-20L,-31L,33L,41L,14L,-53L,-44L,3L,66L,12L,-35L,-51L,22L,48L,36L,-60L,-43L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118206Inst : IEnumerable<long>
{
public static readonly long[] Value=A118206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118206.Bytes);
public long this[int i]=>Value[i];

public static A118206Inst Instance=new A118206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118207
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,1L,2L,0L,-2L,-2L,0L,5L,2L,-7L,-6L,7L,9L,0L,-10L,-9L,4L,17L,2L,-18L,-12L,14L,21L,5L,-26L,-25L,14L,41L,4L,-38L,-35L,18L,53L,23L,-56L,-54L,31L,86L,15L,-78L,-85L,34L,112L,41L,-110L,-102L,49L,158L,40L,-138L,-150L,68L,195L,68L,-191L,-190L,69L,279L,89L,-217L,-253L,102L,327L,122L,-336L,-335L,118L,462L,142L,-361L,-430L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118207Inst : IEnumerable<long>
{
public static readonly long[] Value=A118207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118207.Bytes);
public long this[int i]=>Value[i];

public static A118207Inst Instance=new A118207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118208
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,0L,2L,-4L,5L,-3L,0L,4L,-6L,6L,-2L,-3L,8L,-10L,6L,0L,-6L,14L,-13L,9L,0L,-12L,17L,-18L,11L,3L,-18L,28L,-22L,14L,7L,-25L,30L,-31L,11L,12L,-23L,34L,-28L,9L,12L,-30L,35L,-31L,10L,11L,-30L,56L,-35L,26L,-4L,-41L,51L,-65L,48L,-8L,-28L,65L,-74L,70L,-9L,-49L,71L,-112L,69L,-4L,-48L,135L,-129L,82L,-21L,-83L,155L,-176L,99L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118208Inst : IEnumerable<long>
{
public static readonly long[] Value=A118208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118208.Bytes);
public long this[int i]=>Value[i];

public static A118208Inst Instance=new A118208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118209
{
public static readonly long[] Value={ 1L,-3L,-2L,5L,-4L,6L,-6L,-11L,7L,12L,-10L,-10L,-12L,18L,8L,21L,-16L,-21L,-18L,-20L,12L,30L,-22L,22L,21L,36L,-20L,-30L,-28L,-24L,-30L,-43L,20L,48L,24L,35L,-36L,54L,24L,44L,-40L,-36L,-42L,-50L,-28L,66L,-46L,-42L,43L,-63L,32L,-60L,-52L,60L,40L,66L,36L,84L,-58L,40L,-60L,90L,-42L,85L,48L,-60L,-66L,-80L,44L,-72L,-70L,-77L,-72L,108L,-42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118209Inst : IEnumerable<long>
{
public static readonly long[] Value=A118209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118209.Bytes);
public long this[int i]=>Value[i];

public static A118209Inst Instance=new A118209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118210
{
public static readonly long[] Value={ 2L,1L,1L,-1L,1L,-3L,23L,-53L,23L,-79L,457L,-89L,1213L,-463L,89L,3667L,-457L,1181L,-95059L,27967L,-123601L,93209L,-10741L,29L,-392351L,1560269L,73789L,-1224791L,36000427L,-339667L,280099L,-64339153L,22544987L,-1599245737L,42785159L,-133486139L,5539281131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118210Inst : IEnumerable<long>
{
public static readonly long[] Value=A118210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118210.Bytes);
public long this[int i]=>Value[i];

public static A118210Inst Instance=new A118210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118211
{
public static readonly long[] Value={ 1L,1L,2L,6L,8L,40L,720L,5040L,8064L,120960L,3628800L,4435200L,479001600L,2075673600L,17435658240L,1307674368000L,634023936000L,10162497945600L,6402373705728000L,17377871486976000L,810967336058880000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118211Inst : IEnumerable<long>
{
public static readonly long[] Value=A118211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118211.Bytes);
public long this[int i]=>Value[i];

public static A118211Inst Instance=new A118211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118212
{
public static readonly long[] Value={ 3244L,32440L,324400L,324886L,1109311L,1979137L,3244000L,3248860L,10212316L,10255493L,10282339L,10306511L,10503781L,10573126L,10657861L,10692107L,11093110L,11145841L,11171452L,19791370L,19855967L,19875058L,19912073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118212Inst : IEnumerable<long>
{
public static readonly long[] Value=A118212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118212.Bytes);
public long this[int i]=>Value[i];

public static A118212Inst Instance=new A118212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118213
{
public static readonly long[] Value={ 10282339L,10306511L,32667367L,102615679L,105709573L,107647367L,107776891L,113265953L,198471113L,324580307L,981466259L,982322251L,983075549L,1001315129L,1002340429L,1004157421L,1005362971L,1007811719L,1008125953L,1099887589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118213Inst : IEnumerable<long>
{
public static readonly long[] Value=A118213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118213.Bytes);
public long this[int i]=>Value[i];

public static A118213Inst Instance=new A118213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118214
{
public static readonly long[] Value={ 1L,68L,153L,418L,881L,255L,619L,983L,456L,721L,194L,558L,922L,296L,759L,1024L,4268L,8691L,2035L,5369L,9702L,2146L,6479L,9813L,3256L,6590L,1023L,3268L,8690L,1035L,5368L,8702L,2145L,5479L,9812L,2256L,6589L,9923L,3366L,6700L,143L,408L,871L,245L,609L,973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118214Inst : IEnumerable<long>
{
public static readonly long[] Value=A118214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118214.Bytes);
public long this[int i]=>Value[i];

public static A118214Inst Instance=new A118214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118215
{
public static readonly long[] Value={ 1L,69L,164L,529L,993L,467L,832L,306L,671L,244L,510L,83L,106L,669L,1034L,4369L,9702L,2147L,7480L,915L,587L,853L,426L,692L,364L,531L,203L,370L,141L,209L,970L,147L,809L,976L,747L,815L,586L,753L,425L,592L,363L,431L,202L,270L,140L,109L,969L,1037L,7369L,9705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118215Inst : IEnumerable<long>
{
public static readonly long[] Value=A118215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118215.Bytes);
public long this[int i]=>Value[i];

public static A118215Inst Instance=new A118215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118216
{
public static readonly long[] Value={ 1L,70L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L,700L,76L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118216Inst : IEnumerable<long>
{
public static readonly long[] Value=A118216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118216.Bytes);
public long this[int i]=>Value[i];

public static A118216Inst Instance=new A118216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118217
{
public static readonly long[] Value={ 1L,71L,87L,148L,911L,189L,1051L,1571L,1821L,1351L,1601L,1131L,1381L,1901L,1161L,1681L,1931L,1461L,1711L,1241L,1491L,2011L,1172L,2781L,1942L,2561L,1722L,2341L,1502L,2121L,1282L,2891L,2052L,2572L,2822L,2352L,2602L,2132L,2382L,2902L,2162L,2682L,2932L,2462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118217Inst : IEnumerable<long>
{
public static readonly long[] Value=A118217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118217.Bytes);
public long this[int i]=>Value[i];

public static A118217Inst Instance=new A118217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118218
{
public static readonly long[] Value={ 1L,72L,98L,160L,132L,302L,274L,543L,416L,685L,657L,827L,799L,1068L,8672L,2839L,9453L,3620L,334L,504L,476L,745L,618L,887L,859L,1029L,9272L,2800L,153L,422L,295L,663L,437L,805L,579L,1046L,6472L,2817L,7253L,3598L,9024L,4280L,895L,669L,1037L,7372L,2808L,8153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118218Inst : IEnumerable<long>
{
public static readonly long[] Value=A118218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118218.Bytes);
public long this[int i]=>Value[i];

public static A118218Inst Instance=new A118218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118219
{
public static readonly long[] Value={ 3L,30L,17L,248L,515L,49682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118219Inst : IEnumerable<long>
{
public static readonly long[] Value=A118219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118219.Bytes);
public long this[int i]=>Value[i];

public static A118219Inst Instance=new A118219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118220
{
public static readonly long[] Value={ 1L,73L,109L,973L,451L,226L,694L,568L,937L,811L,190L,163L,433L,406L,676L,749L,919L,991L,271L,244L,514L,487L,856L,730L,109L,973L,451L,226L,694L,568L,937L,811L,190L,163L,433L,406L,676L,749L,919L,991L,271L,244L,514L,487L,856L,730L,109L,973L,451L,226L,694L,568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118220Inst : IEnumerable<long>
{
public static readonly long[] Value=A118220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118220.Bytes);
public long this[int i]=>Value[i];

public static A118220Inst Instance=new A118220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118221
{
public static readonly long[] Value={ 1L,74L,120L,94L,122L,294L,565L,638L,909L,982L,362L,336L,706L,680L,159L,1024L,4274L,4797L,8047L,7481L,1920L,364L,536L,708L,880L,161L,234L,505L,578L,948L,922L,302L,276L,745L,620L,99L,172L,344L,516L,688L,959L,1032L,2374L,4805L,5157L,7588L,8930L,471L,247L,815L,591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118221Inst : IEnumerable<long>
{
public static readonly long[] Value=A118221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118221.Bytes);
public long this[int i]=>Value[i];

public static A118221Inst Instance=new A118221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118222
{
public static readonly long[] Value={ 1L,2L,3L,48L,151L,312L,445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118222Inst : IEnumerable<long>
{
public static readonly long[] Value=A118222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118222.Bytes);
public long this[int i]=>Value[i];

public static A118222Inst Instance=new A118222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118223
{
public static readonly long[] Value={ 2L,3L,4L,9L,11L,12L,13L,50L,73L,81L,82L,115L,308L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118223Inst : IEnumerable<long>
{
public static readonly long[] Value=A118223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118223.Bytes);
public long this[int i]=>Value[i];

public static A118223Inst Instance=new A118223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118224
{
public static readonly long[] Value={ 2L,6L,12L,24L,48L,60L,120L,120L,180L,240L,360L,360L,720L,720L,720L,840L,1260L,1260L,1680L,1680L,2520L,2520L,2520L,2520L,5040L,5040L,5040L,5040L,5040L,5040L,7560L,7560L,10080L,10080L,10080L,10080L,15120L,15120L,15120L,15120L,20160L,20160L,25200L,25200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118224Inst : IEnumerable<long>
{
public static readonly long[] Value=A118224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118224.Bytes);
public long this[int i]=>Value[i];

public static A118224Inst Instance=new A118224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118225
{
public static readonly long[] Value={ 1L,75L,131L,205L,576L,749L,1021L,1275L,5795L,6049L,9480L,923L,403L,379L,947L,823L,402L,278L,946L,723L,401L,178L,945L,623L,400L,78L,161L,235L,606L,680L,160L,135L,605L,580L,159L,1025L,5275L,5799L,10049L,94075L,57123L,32249L,94297L,79323L,32471L,17497L,79545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118225Inst : IEnumerable<long>
{
public static readonly long[] Value=A118225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118225.Bytes);
public long this[int i]=>Value[i];

public static A118225Inst Instance=new A118225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118226
{
public static readonly long[] Value={ 1L,77L,153L,427L,800L,84L,124L,497L,870L,154L,527L,801L,184L,557L,831L,214L,488L,960L,145L,617L,792L,373L,449L,1020L,277L,848L,924L,505L,581L,261L,238L,908L,885L,664L,542L,321L,199L,1067L,7677L,7843L,3563L,3729L,9349L,9515L,5235L,5401L,1121L,1287L,7897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118226Inst : IEnumerable<long>
{
public static readonly long[] Value=A118226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118226.Bytes);
public long this[int i]=>Value[i];

public static A118226Inst Instance=new A118226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118227
{
public static readonly long[] Value={ 6L,4L,3L,4L,1L,0L,5L,4L,6L,2L,8L,8L,3L,3L,8L,0L,2L,6L,1L,8L,2L,2L,5L,4L,3L,0L,7L,7L,5L,7L,5L,6L,4L,7L,6L,3L,2L,8L,6L,5L,8L,7L,8L,6L,0L,2L,6L,8L,2L,3L,9L,5L,0L,5L,9L,8L,7L,0L,3L,0L,9L,2L,0L,3L,0L,7L,4L,9L,2L,7L,7L,6L,4L,6L,1L,8L,3L,2L,6L,1L,0L,8L,4L,8L,4L,4L,0L,8L,9L,5L,5L,5L,0L,4L,6L,3L,4L,3L,1L,9L,5L,4L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118227Inst : IEnumerable<long>
{
public static readonly long[] Value=A118227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118227.Bytes);
public long this[int i]=>Value[i];

public static A118227Inst Instance=new A118227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118228
{
public static readonly long[] Value={ 0L,0L,1L,3L,1L,7L,6L,4L,1L,1L,5L,4L,8L,5L,3L,1L,7L,8L,1L,0L,9L,8L,1L,7L,3L,5L,2L,3L,2L,2L,5L,1L,3L,5L,8L,5L,9L,5L,1L,2L,5L,0L,7L,3L,4L,3L,2L,3L,2L,9L,5L,2L,5L,1L,6L,7L,8L,7L,9L,2L,5L,4L,7L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118228Inst : IEnumerable<long>
{
public static readonly long[] Value=A118228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118228.Bytes);
public long this[int i]=>Value[i];

public static A118228Inst Instance=new A118228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118229
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,1L,1L,-1L,-1L,1L,-1L,0L,0L,0L,1L,1L,0L,0L,-1L,-1L,1L,1L,0L,-1L,0L,-1L,0L,1L,-1L,0L,2L,-1L,0L,0L,-1L,1L,-1L,0L,0L,0L,1L,0L,-1L,0L,1L,1L,0L,-1L,1L,0L,-1L,1L,-1L,-1L,1L,-1L,0L,1L,0L,0L,0L,-1L,0L,0L,0L,1L,1L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,-1L,1L,3L,0L,-2L,0L,-2L,0L,2L,0L,-1L,0L,-1L,0L,1L,-3L,0L,1L,0L,3L,0L,-1L,-1L,1L,0L,0L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118229Inst : IEnumerable<long>
{
public static readonly long[] Value=A118229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118229.Bytes);
public long this[int i]=>Value[i];

public static A118229Inst Instance=new A118229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118230
{
public static readonly long[] Value={ 0L,0L,1L,-1L,0L,0L,-1L,2L,0L,-1L,1L,-1L,-2L,1L,1L,0L,2L,-2L,-1L,0L,0L,1L,1L,-1L,-4L,2L,1L,1L,0L,0L,1L,0L,2L,-6L,3L,0L,-6L,7L,1L,-2L,8L,-8L,-5L,-5L,-2L,12L,3L,-7L,-6L,-9L,1L,18L,6L,-21L,-9L,-5L,4L,25L,-1L,1L,2L,-39L,-1L,35L,0L,3L,3L,-18L,-22L,37L,5L,-5L,8L,-48L,9L,45L,-10L,-4L,5L,-55L,10L,40L,-17L,-35L,4L,-2L,-11L,61L,4L,-13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118230Inst : IEnumerable<long>
{
public static readonly long[] Value=A118230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118230.Bytes);
public long this[int i]=>Value[i];

public static A118230Inst Instance=new A118230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118231
{
public static readonly long[] Value={ 1L,-2L,1L,-2L,0L,1L,4L,-2L,-2L,1L,-2L,0L,0L,0L,1L,2L,1L,1L,-2L,-2L,1L,4L,0L,-2L,0L,-2L,0L,1L,-6L,1L,6L,-2L,1L,0L,-2L,1L,-4L,0L,1L,0L,3L,0L,-2L,0L,1L,6L,-1L,-6L,4L,-1L,-2L,4L,-2L,-2L,1L,-4L,0L,3L,0L,1L,0L,-2L,0L,0L,0L,1L,4L,0L,-3L,-1L,-1L,1L,2L,1L,1L,-2L,-2L,1L,14L,0L,-7L,0L,-7L,0L,6L,0L,-2L,0L,-2L,0L,1L,-14L,0L,3L,1L,10L,0L,-4L,-2L,3L,0L,1L,0L,-2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118231Inst : IEnumerable<long>
{
public static readonly long[] Value=A118231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118231.Bytes);
public long this[int i]=>Value[i];

public static A118231Inst Instance=new A118231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118232
{
public static readonly long[] Value={ 1L,-2L,-2L,4L,-2L,2L,4L,-6L,-4L,6L,-4L,4L,14L,-14L,-8L,8L,-16L,18L,8L,-12L,6L,-6L,-6L,-10L,28L,-6L,-10L,4L,-2L,4L,-8L,-2L,-18L,48L,-20L,0L,54L,-70L,-18L,32L,-76L,86L,62L,14L,14L,-110L,-40L,124L,62L,94L,-24L,-224L,-66L,224L,134L,62L,-72L,-286L,14L,8L,-14L,474L,10L,-458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118232Inst : IEnumerable<long>
{
public static readonly long[] Value=A118232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118232.Bytes);
public long this[int i]=>Value[i];

public static A118232Inst Instance=new A118232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118233
{
public static readonly long[] Value={ 1L,2L,1L,2L,0L,1L,4L,2L,2L,1L,2L,0L,0L,0L,1L,6L,3L,3L,2L,2L,1L,4L,0L,2L,0L,2L,0L,1L,6L,3L,2L,2L,3L,0L,2L,1L,4L,0L,3L,0L,1L,0L,2L,0L,1L,10L,5L,6L,4L,5L,2L,4L,2L,2L,1L,4L,0L,1L,0L,3L,0L,2L,0L,0L,0L,1L,12L,6L,7L,5L,7L,3L,6L,3L,3L,2L,2L,1L,6L,0L,3L,0L,3L,0L,2L,0L,2L,0L,2L,0L,1L,8L,4L,3L,3L,4L,0L,4L,2L,1L,0L,3L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118233Inst : IEnumerable<long>
{
public static readonly long[] Value=A118233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118233.Bytes);
public long this[int i]=>Value[i];

public static A118233Inst Instance=new A118233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118234
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,3L,2L,2L,3L,6L,1L,7L,3L,3L,5L,10L,2L,11L,5L,5L,7L,14L,3L,13L,7L,8L,7L,18L,3L,19L,10L,9L,11L,15L,5L,23L,11L,11L,11L,26L,5L,27L,13L,11L,15L,30L,7L,27L,13L,15L,15L,34L,8L,27L,15L,17L,19L,38L,7L,39L,19L,17L,21L,31L,9L,43L,21L,21L,15L,46L,11L,47L,23L,19L,23L,39L,11L,51L,21L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118234Inst : IEnumerable<long>
{
public static readonly long[] Value=A118234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118234.Bytes);
public long this[int i]=>Value[i];

public static A118234Inst Instance=new A118234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118235
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,3L,8L,2L,1L,5L,3L,6L,2L,1L,16L,8L,3L,9L,2L,1L,4L,11L,7L,3L,5L,2L,1L,14L,4L,15L,32L,3L,7L,2L,1L,18L,8L,4L,6L,20L,3L,21L,2L,1L,10L,23L,15L,4L,8L,6L,3L,26L,2L,1L,5L,7L,13L,29L,4L,30L,14L,3L,64L,2L,1L,33L,5L,9L,7L,35L,4L,36L,17L,3L,6L,2L,1L,39L,14L,5L,19L,41L,7L,4L,20L,12L,3L,44L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118235Inst : IEnumerable<long>
{
public static readonly long[] Value=A118235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118235.Bytes);
public long this[int i]=>Value[i];

public static A118235Inst Instance=new A118235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118236
{
public static readonly long[] Value={ 9L,15L,18L,21L,30L,35L,42L,45L,50L,55L,60L,63L,65L,70L,75L,77L,81L,84L,90L,91L,99L,105L,108L,117L,119L,126L,132L,133L,135L,140L,143L,147L,150L,153L,154L,156L,162L,165L,171L,175L,180L,187L,189L,195L,196L,198L,207L,209L,210L,216L,220L,221L,225L,231L,234L,245L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118236Inst : IEnumerable<long>
{
public static readonly long[] Value=A118236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118236.Bytes);
public long this[int i]=>Value[i];

public static A118236Inst Instance=new A118236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118237
{
public static readonly long[] Value={ 14L,42L,25L,53L,36L,64L,47L,75L,58L,86L,69L,97L,80L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118237Inst : IEnumerable<long>
{
public static readonly long[] Value=A118237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118237.Bytes);
public long this[int i]=>Value[i];

public static A118237Inst Instance=new A118237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118238
{
public static readonly long[] Value={ 15L,52L,26L,63L,37L,74L,48L,85L,59L,96L,70L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118238Inst : IEnumerable<long>
{
public static readonly long[] Value=A118238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118238.Bytes);
public long this[int i]=>Value[i];

public static A118238Inst Instance=new A118238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118239
{
public static readonly long[] Value={ 1L,2L,12L,30L,56L,90L,132L,182L,240L,306L,380L,462L,552L,650L,756L,870L,992L,1122L,1260L,1406L,1560L,1722L,1892L,2070L,2256L,2450L,2652L,2862L,3080L,3306L,3540L,3782L,4032L,4290L,4556L,4830L,5112L,5402L,5700L,6006L,6320L,6642L,6972L,7310L,7656L,8010L,8372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118239Inst : IEnumerable<long>
{
public static readonly long[] Value=A118239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118239.Bytes);
public long this[int i]=>Value[i];

public static A118239Inst Instance=new A118239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118240
{
public static readonly long[] Value={ 0L,0L,1L,10L,11L,101L,111L,1010L,1011L,1101L,1110L,1111L,10101L,10111L,11010L,11011L,11101L,11111L,101010L,101011L,101101L,101110L,101111L,110101L,110111L,111010L,111011L,111101L,111110L,111111L,1010101L,1010111L,1011010L,1011011L,1011101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A118240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118240Inst : IEnumerable<long>
{
public static readonly long[] Value=A118240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A118240.Bytes);
public long this[int i]=>Value[i];

public static A118240Inst Instance=new A118240Inst();

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