using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A046568
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,5L,5L,1L,1L,9L,5L,9L,1L,1L,13L,19L,19L,13L,1L,1L,17L,8L,19L,8L,17L,1L,1L,21L,49L,35L,35L,49L,21L,1L,1L,25L,35L,119L,35L,119L,35L,25L,1L,1L,29L,95L,189L,259L,259L,189L,95L,29L,1L,1L,33L,31L,71L,112L,259L,112L,71L,31L,33L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046568Inst : IEnumerable<long>
{
public static readonly long[] Value=A046568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046568.Bytes);
public long this[int i]=>Value[i];

public static A046568Inst Instance=new A046568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046569
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,4L,4L,1L,1L,4L,2L,4L,1L,1L,4L,4L,4L,4L,1L,1L,4L,1L,2L,1L,4L,1L,1L,4L,4L,2L,2L,4L,4L,1L,1L,4L,2L,4L,1L,4L,2L,4L,1L,1L,4L,4L,4L,4L,4L,4L,4L,4L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,4L,4L,1L,1L,2L,2L,1L,1L,4L,4L,1L,1L,4L,2L,4L,1L,2L,1L,2L,1L,4L,2L,4L,1L,1L,4L,4L,4L,4L,2L,2L,2L,2L,4L,4L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046569Inst : IEnumerable<long>
{
public static readonly long[] Value=A046569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046569.Bytes);
public long this[int i]=>Value[i];

public static A046569Inst Instance=new A046569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046570
{
public static readonly long[] Value={ 1L,4L,5L,9L,2L,13L,19L,17L,8L,21L,49L,35L,25L,119L,29L,95L,189L,259L,33L,31L,71L,112L,37L,157L,102L,183L,483L,41L,97L,565L,285L,849L,45L,235L,759L,1705L,1419L,1815L,70L,497L,616L,4543L,1617L,53L,329L,637L,1729L,7007L,11011L,3432L,57L,191L,1603L,1183L,10465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046570Inst : IEnumerable<long>
{
public static readonly long[] Value=A046570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046570.Bytes);
public long this[int i]=>Value[i];

public static A046570Inst Instance=new A046570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046571
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,5L,5L,1L,1L,9L,5L,9L,1L,1L,13L,19L,19L,13L,1L,1L,17L,19L,17L,1L,1L,21L,49L,35L,35L,49L,21L,1L,1L,25L,35L,119L,35L,119L,35L,25L,1L,1L,29L,95L,189L,259L,259L,189L,95L,29L,1L,1L,33L,31L,71L,259L,71L,31L,33L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046571Inst : IEnumerable<long>
{
public static readonly long[] Value=A046571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046571.Bytes);
public long this[int i]=>Value[i];

public static A046571Inst Instance=new A046571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046572
{
public static readonly long[] Value={ 1L,1L,1L,4L,5L,2L,19L,2L,35L,1L,259L,2L,483L,1L,1815L,1L,6864L,1L,52195L,2L,99671L,1L,382109L,1L,1469650L,1L,5668327L,1L,21915550L,1L,84913470L,1L,329624730L,1L,2563431075L,2L,4991324415L,1L,19463777025L,1L,75992317170L,1L,297026449005L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046572Inst : IEnumerable<long>
{
public static readonly long[] Value=A046572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046572.Bytes);
public long this[int i]=>Value[i];

public static A046572Inst Instance=new A046572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046573
{
public static readonly long[] Value={ 1L,1L,4L,1L,2L,5L,2L,19L,1L,35L,2L,259L,1L,483L,1L,1815L,1L,6864L,2L,52195L,1L,99671L,1L,382109L,1L,1469650L,1L,5668327L,1L,21915550L,1L,84913470L,1L,329624730L,2L,2563431075L,1L,4991324415L,1L,19463777025L,1L,75992317170L,1L,297026449005L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046573Inst : IEnumerable<long>
{
public static readonly long[] Value=A046573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046573.Bytes);
public long this[int i]=>Value[i];

public static A046573Inst Instance=new A046573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046574
{
public static readonly long[] Value={ 1L,4L,5L,2L,19L,35L,259L,483L,1815L,6864L,52195L,99671L,382109L,1469650L,5668327L,21915550L,84913470L,329624730L,2563431075L,4991324415L,19463777025L,75992317170L,297026449005L,1162147683450L,4551257541090L,17839099909800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046574Inst : IEnumerable<long>
{
public static readonly long[] Value=A046574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046574.Bytes);
public long this[int i]=>Value[i];

public static A046574Inst Instance=new A046574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046575
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,4L,1L,1L,9L,4L,1L,1L,19L,4L,13L,4L,1L,1L,8L,1L,17L,4L,1L,1L,35L,2L,49L,4L,21L,4L,1L,1L,119L,4L,35L,2L,25L,4L,1L,1L,259L,4L,189L,4L,95L,4L,29L,4L,1L,1L,112L,1L,71L,1L,31L,1L,33L,4L,1L,1L,483L,2L,183L,1L,102L,1L,157L,4L,37L,4L,1L,1L,849L,2L,285L,1L,565L,4L,97L,2L,41L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046575Inst : IEnumerable<long>
{
public static readonly long[] Value=A046575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046575.Bytes);
public long this[int i]=>Value[i];

public static A046575Inst Instance=new A046575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046576
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,5L,1L,1L,4L,9L,1L,1L,4L,19L,4L,13L,1L,1L,1L,8L,4L,17L,1L,1L,2L,35L,4L,49L,4L,21L,1L,1L,4L,119L,2L,35L,4L,25L,1L,1L,4L,259L,4L,189L,4L,95L,4L,29L,1L,1L,1L,112L,1L,71L,1L,31L,4L,33L,1L,1L,2L,483L,1L,183L,1L,102L,4L,157L,4L,37L,1L,1L,2L,849L,1L,285L,4L,565L,2L,97L,4L,41L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046576Inst : IEnumerable<long>
{
public static readonly long[] Value=A046576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046576.Bytes);
public long this[int i]=>Value[i];

public static A046576Inst Instance=new A046576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046577
{
public static readonly long[] Value={ 4L,5L,4L,9L,4L,19L,4L,13L,8L,4L,17L,2L,35L,4L,49L,4L,21L,4L,119L,2L,35L,4L,25L,4L,259L,4L,189L,4L,95L,4L,29L,112L,71L,31L,4L,33L,2L,483L,183L,102L,4L,157L,4L,37L,2L,849L,285L,4L,565L,2L,97L,4L,41L,2L,1815L,2L,1419L,4L,1705L,4L,759L,4L,235L,4L,45L,1617L,4L,4543L,616L,2L,497L,70L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046577Inst : IEnumerable<long>
{
public static readonly long[] Value=A046577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046577.Bytes);
public long this[int i]=>Value[i];

public static A046577Inst Instance=new A046577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046578
{
public static readonly long[] Value={ 5L,9L,19L,13L,8L,17L,2L,35L,49L,21L,119L,2L,35L,25L,259L,189L,95L,29L,112L,71L,31L,33L,2L,483L,183L,102L,157L,37L,2L,849L,285L,565L,2L,97L,41L,2L,1815L,2L,1419L,1705L,759L,235L,45L,1617L,4543L,616L,2L,497L,70L,49L,3432L,11011L,7007L,2L,1729L,2L,637L,329L,53L,24739L,2L,9009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046578Inst : IEnumerable<long>
{
public static readonly long[] Value=A046578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046578.Bytes);
public long this[int i]=>Value[i];

public static A046578Inst Instance=new A046578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046579
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,9L,1L,1L,19L,13L,1L,1L,8L,1L,17L,1L,1L,35L,2L,49L,21L,1L,1L,119L,35L,2L,25L,1L,1L,259L,189L,95L,29L,1L,1L,112L,1L,71L,1L,31L,1L,33L,1L,1L,483L,2L,183L,1L,102L,1L,157L,37L,1L,1L,849L,2L,285L,1L,565L,97L,2L,41L,1L,1L,1815L,2L,1419L,2L,1705L,759L,235L,45L,1L,1L,1617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046579Inst : IEnumerable<long>
{
public static readonly long[] Value=A046579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046579.Bytes);
public long this[int i]=>Value[i];

public static A046579Inst Instance=new A046579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046580
{
public static readonly long[] Value={ 1L,1L,5L,1L,9L,1L,19L,13L,1L,8L,17L,1L,35L,49L,21L,1L,119L,35L,25L,1L,259L,189L,95L,29L,1L,112L,71L,31L,33L,1L,483L,189L,102L,157L,37L,1L,861L,291L,565L,97L,41L,1L,1827L,1443L,1729L,759L,235L,45L,1L,1635L,4615L,622L,497L,70L,49L,1L,3462L,11155L,7103L,1119L,567L,329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046580Inst : IEnumerable<long>
{
public static readonly long[] Value=A046580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046580.Bytes);
public long this[int i]=>Value[i];

public static A046580Inst Instance=new A046580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046581
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,5L,1L,1L,1L,1L,9L,5L,2L,9L,1L,1L,1L,1L,13L,19L,19L,13L,1L,1L,1L,1L,17L,8L,1L,19L,2L,8L,1L,17L,1L,1L,1L,1L,21L,49L,35L,2L,35L,2L,49L,21L,1L,1L,1L,1L,25L,35L,2L,119L,35L,1L,119L,35L,2L,25L,1L,1L,1L,1L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046581Inst : IEnumerable<long>
{
public static readonly long[] Value=A046581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046581.Bytes);
public long this[int i]=>Value[i];

public static A046581Inst Instance=new A046581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046582
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,5L,1L,1L,1L,1L,9L,2L,5L,9L,1L,1L,1L,1L,13L,19L,19L,13L,1L,1L,1L,1L,17L,1L,8L,2L,19L,1L,8L,17L,1L,1L,1L,1L,21L,49L,2L,35L,2L,35L,49L,21L,1L,1L,1L,1L,25L,2L,35L,119L,1L,35L,119L,2L,35L,25L,1L,1L,1L,1L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046582Inst : IEnumerable<long>
{
public static readonly long[] Value=A046582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046582.Bytes);
public long this[int i]=>Value[i];

public static A046582Inst Instance=new A046582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046583
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,9L,1L,1L,19L,13L,1L,1L,1L,8L,17L,1L,1L,2L,35L,49L,21L,1L,1L,119L,2L,35L,25L,1L,1L,259L,189L,95L,29L,1L,1L,1L,112L,1L,71L,1L,31L,33L,1L,1L,2L,483L,1L,183L,1L,102L,157L,37L,1L,1L,2L,849L,1L,285L,565L,2L,97L,41L,1L,1L,2L,1815L,2L,1419L,1705L,759L,235L,45L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046583Inst : IEnumerable<long>
{
public static readonly long[] Value=A046583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046583.Bytes);
public long this[int i]=>Value[i];

public static A046583Inst Instance=new A046583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046584
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,5L,1L,1L,1L,1L,9L,5L,9L,1L,1L,1L,1L,13L,19L,19L,13L,1L,1L,1L,1L,17L,1L,19L,1L,17L,1L,1L,1L,1L,21L,49L,35L,35L,49L,21L,1L,1L,1L,1L,25L,35L,119L,35L,1L,119L,35L,25L,1L,1L,1L,1L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046584Inst : IEnumerable<long>
{
public static readonly long[] Value=A046584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046584.Bytes);
public long this[int i]=>Value[i];

public static A046584Inst Instance=new A046584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046585
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,5L,1L,1L,1L,1L,9L,5L,9L,1L,1L,1L,1L,13L,19L,19L,13L,1L,1L,1L,1L,17L,1L,19L,1L,17L,1L,1L,1L,1L,21L,49L,35L,35L,49L,21L,1L,1L,1L,1L,25L,35L,119L,1L,35L,119L,35L,25L,1L,1L,1L,1L,29L,95L,189L,259L,259L,189L,95L,29L,1L,1L,1L,1L,33L,1L,31L,1L,71L,1L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046585Inst : IEnumerable<long>
{
public static readonly long[] Value=A046585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046585.Bytes);
public long this[int i]=>Value[i];

public static A046585Inst Instance=new A046585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046586
{
public static readonly long[] Value={ 1L,5L,9L,13L,19L,17L,21L,49L,35L,25L,119L,29L,95L,189L,259L,33L,31L,71L,37L,157L,183L,483L,41L,97L,565L,285L,849L,45L,235L,759L,1705L,1419L,1815L,497L,4543L,1617L,53L,329L,637L,1729L,7007L,11011L,57L,191L,1603L,1183L,10465L,9009L,24739L,61L,439L,1985L,6335L,15197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046586Inst : IEnumerable<long>
{
public static readonly long[] Value=A046586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046586.Bytes);
public long this[int i]=>Value[i];

public static A046586Inst Instance=new A046586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046587
{
public static readonly long[] Value={ 4L,4L,4L,4L,2L,4L,4L,4L,4L,4L,4L,8L,2L,8L,4L,4L,4L,2L,2L,4L,4L,4L,2L,4L,4L,2L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,112L,2L,112L,4L,4L,4L,102L,2L,2L,102L,4L,4L,4L,2L,4L,2L,2L,4L,2L,4L,4L,4L,4L,4L,2L,2L,2L,2L,4L,4L,4L,4L,4L,70L,2L,616L,4L,4L,616L,2L,70L,4L,4L,4L,2L,2L,4L,4L,3432L,3432L,4L,4L,2L,2L,4L,4L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046587Inst : IEnumerable<long>
{
public static readonly long[] Value=A046587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046587.Bytes);
public long this[int i]=>Value[i];

public static A046587Inst Instance=new A046587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046588
{
public static readonly long[] Value={ 1L,5L,4L,9L,19L,13L,8L,17L,35L,2L,49L,21L,119L,25L,259L,189L,95L,29L,112L,71L,31L,33L,483L,183L,102L,157L,37L,849L,285L,565L,97L,41L,1815L,1419L,1705L,759L,235L,45L,1617L,4543L,616L,497L,70L,3432L,11011L,7007L,1729L,637L,329L,53L,24739L,9009L,10465L,1183L,1603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046588Inst : IEnumerable<long>
{
public static readonly long[] Value=A046588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046588.Bytes);
public long this[int i]=>Value[i];

public static A046588Inst Instance=new A046588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046605
{
public static readonly long[] Value={ 6L,6L,11L,12L,11L,16L,23L,23L,16L,21L,39L,46L,39L,21L,26L,12L,17L,17L,12L,26L,31L,86L,29L,34L,29L,86L,31L,36L,117L,231L,63L,63L,231L,117L,36L,41L,153L,348L,546L,126L,546L,348L,153L,41L,46L,199L,501L,894L,1176L,1176L,894L,501L,199L,46L,51L,49L,140L,279L,414L,2352L,414L,279L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046605Inst : IEnumerable<long>
{
public static readonly long[] Value=A046605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046605.Bytes);
public long this[int i]=>Value[i];

public static A046605Inst Instance=new A046605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046606
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,6L,6L,1L,1L,11L,12L,11L,1L,1L,16L,23L,23L,16L,1L,1L,21L,39L,46L,39L,21L,1L,1L,26L,12L,17L,17L,12L,26L,1L,1L,31L,86L,29L,34L,29L,86L,31L,1L,1L,36L,117L,231L,63L,63L,231L,117L,36L,1L,1L,41L,153L,348L,546L,126L,546L,348L,153L,41L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046606Inst : IEnumerable<long>
{
public static readonly long[] Value=A046606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046606.Bytes);
public long this[int i]=>Value[i];

public static A046606Inst Instance=new A046606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046607
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,5L,5L,1L,1L,5L,5L,5L,1L,1L,5L,5L,5L,5L,1L,1L,5L,5L,5L,5L,5L,1L,1L,5L,1L,1L,1L,1L,5L,1L,1L,5L,5L,1L,1L,1L,5L,5L,1L,1L,5L,5L,5L,1L,1L,5L,5L,5L,1L,1L,5L,5L,5L,5L,1L,5L,5L,5L,5L,1L,1L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,1L,1L,5L,1L,1L,1L,1L,5L,1L,1L,1L,1L,5L,1L,1L,5L,5L,1L,1L,1L,5L,5L,1L,1L,1L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046607Inst : IEnumerable<long>
{
public static readonly long[] Value=A046607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046607.Bytes);
public long this[int i]=>Value[i];

public static A046607Inst Instance=new A046607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046608
{
public static readonly long[] Value={ 1L,5L,6L,11L,12L,16L,23L,21L,39L,46L,26L,17L,31L,86L,29L,34L,36L,117L,231L,63L,41L,153L,348L,546L,126L,194L,501L,894L,1176L,51L,48L,139L,279L,414L,2352L,56L,291L,187L,418L,693L,4422L,61L,347L,1226L,605L,1111L,7887L,8844L,66L,408L,1573L,4251L,1716L,13442L,16731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046608Inst : IEnumerable<long>
{
public static readonly long[] Value=A046608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046608.Bytes);
public long this[int i]=>Value[i];

public static A046608Inst Instance=new A046608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046609
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,11L,11L,1L,1L,23L,23L,1L,1L,21L,39L,39L,21L,1L,1L,17L,17L,1L,1L,31L,29L,29L,31L,1L,1L,117L,231L,63L,63L,231L,117L,1L,1L,41L,153L,153L,41L,1L,1L,501L,501L,1L,1L,51L,139L,279L,279L,139L,51L,1L,1L,291L,187L,693L,693L,187L,291L,1L,1L,61L,347L,605L,1111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046609Inst : IEnumerable<long>
{
public static readonly long[] Value=A046609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046609.Bytes);
public long this[int i]=>Value[i];

public static A046609Inst Instance=new A046609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046610
{
public static readonly long[] Value={ 1L,1L,1L,5L,12L,5L,46L,5L,34L,1L,126L,1L,2352L,5L,8844L,5L,33462L,5L,25454L,1L,97240L,1L,1864356L,5L,7171892L,5L,27665596L,5L,21395520L,1L,82907640L,1L,321868854L,1L,1251661518L,1L,4874644104L,1L,19010020260L,1L,74225053980L,1L,290134122564L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046610Inst : IEnumerable<long>
{
public static readonly long[] Value=A046610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046610.Bytes);
public long this[int i]=>Value[i];

public static A046610Inst Instance=new A046610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046611
{
public static readonly long[] Value={ 1L,1L,5L,1L,5L,12L,5L,46L,1L,34L,1L,126L,5L,2352L,5L,8844L,5L,33462L,1L,25454L,1L,97240L,5L,1864356L,5L,7171892L,5L,27665596L,1L,21395520L,1L,82907640L,1L,321868854L,1L,1251661518L,1L,4874644104L,1L,19010020260L,1L,74225053980L,1L,290134122564L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046611Inst : IEnumerable<long>
{
public static readonly long[] Value=A046611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046611.Bytes);
public long this[int i]=>Value[i];

public static A046611Inst Instance=new A046611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046612
{
public static readonly long[] Value={ 1L,5L,12L,46L,34L,126L,2352L,8844L,33462L,25454L,97240L,1864356L,7171892L,27665596L,21395520L,82907640L,321868854L,1251661518L,4874644104L,19010020260L,74225053980L,290134122564L,1135234789728L,4446052592904L,17427428373420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046612Inst : IEnumerable<long>
{
public static readonly long[] Value=A046612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046612.Bytes);
public long this[int i]=>Value[i];

public static A046612Inst Instance=new A046612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046613
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,5L,1L,1L,11L,5L,1L,1L,23L,5L,16L,5L,1L,1L,39L,5L,21L,5L,1L,1L,17L,1L,12L,1L,26L,5L,1L,1L,29L,1L,86L,5L,31L,5L,1L,1L,63L,1L,231L,5L,117L,5L,36L,5L,1L,1L,546L,5L,348L,5L,153L,5L,41L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046613Inst : IEnumerable<long>
{
public static readonly long[] Value=A046613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046613.Bytes);
public long this[int i]=>Value[i];

public static A046613Inst Instance=new A046613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046614
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,6L,1L,1L,5L,11L,1L,1L,5L,23L,5L,16L,1L,1L,5L,39L,5L,21L,1L,1L,1L,17L,1L,12L,5L,26L,1L,1L,1L,29L,5L,86L,5L,31L,1L,1L,1L,63L,5L,231L,5L,117L,5L,36L,1L,1L,5L,546L,5L,348L,5L,153L,5L,41L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046614Inst : IEnumerable<long>
{
public static readonly long[] Value=A046614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046614.Bytes);
public long this[int i]=>Value[i];

public static A046614Inst Instance=new A046614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046615
{
public static readonly long[] Value={ 6L,5L,11L,5L,23L,5L,16L,5L,39L,5L,21L,5L,17L,12L,26L,5L,29L,86L,5L,31L,5L,63L,231L,5L,117L,5L,36L,5L,546L,5L,348L,5L,153L,5L,41L,5L,1176L,5L,894L,5L,501L,5L,194L,5L,46L,5L,414L,279L,139L,48L,51L,5L,4422L,5L,693L,418L,187L,291L,5L,56L,5L,7887L,5L,1111L,605L,1226L,5L,347L,5L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046615Inst : IEnumerable<long>
{
public static readonly long[] Value=A046615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046615.Bytes);
public long this[int i]=>Value[i];

public static A046615Inst Instance=new A046615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046616
{
public static readonly long[] Value={ 6L,11L,23L,16L,39L,21L,17L,12L,26L,29L,86L,31L,63L,231L,117L,36L,546L,348L,153L,41L,1176L,894L,501L,194L,46L,414L,279L,139L,48L,51L,4422L,693L,418L,187L,291L,56L,7887L,1111L,605L,1226L,347L,61L,16731L,13442L,1716L,4251L,1573L,408L,66L,30173L,22022L,12831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046616Inst : IEnumerable<long>
{
public static readonly long[] Value=A046616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046616.Bytes);
public long this[int i]=>Value[i];

public static A046616Inst Instance=new A046616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046617
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,11L,1L,1L,23L,16L,1L,1L,39L,21L,1L,1L,17L,1L,12L,1L,26L,1L,1L,29L,1L,86L,31L,1L,1L,63L,1L,231L,117L,36L,1L,1L,546L,348L,153L,41L,1L,1L,1176L,894L,501L,194L,46L,1L,1L,414L,1L,279L,1L,139L,1L,48L,1L,51L,1L,1L,4422L,693L,1L,418L,1L,187L,1L,291L,56L,1L,1L,7887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046617Inst : IEnumerable<long>
{
public static readonly long[] Value=A046617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046617.Bytes);
public long this[int i]=>Value[i];

public static A046617Inst Instance=new A046617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046618
{
public static readonly long[] Value={ 1L,1L,6L,1L,11L,1L,23L,16L,1L,39L,21L,1L,17L,12L,26L,1L,29L,86L,31L,1L,63L,231L,117L,36L,1L,546L,348L,153L,41L,1L,1176L,894L,501L,194L,46L,1L,414L,279L,139L,48L,51L,1L,4422L,693L,418L,187L,291L,56L,1L,7887L,1111L,605L,1226L,347L,61L,1L,16731L,13442L,1716L,4251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046618Inst : IEnumerable<long>
{
public static readonly long[] Value=A046618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046618.Bytes);
public long this[int i]=>Value[i];

public static A046618Inst Instance=new A046618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046619
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,6L,6L,1L,1L,1L,1L,11L,12L,11L,1L,1L,1L,1L,16L,23L,23L,16L,1L,1L,1L,1L,21L,39L,46L,39L,21L,1L,1L,1L,1L,26L,12L,1L,17L,1L,17L,1L,12L,1L,26L,1L,1L,1L,1L,31L,86L,29L,1L,34L,1L,29L,1L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046619Inst : IEnumerable<long>
{
public static readonly long[] Value=A046619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046619.Bytes);
public long this[int i]=>Value[i];

public static A046619Inst Instance=new A046619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046620
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,6L,6L,1L,1L,1L,1L,11L,12L,11L,1L,1L,1L,1L,16L,23L,23L,16L,1L,1L,1L,1L,21L,39L,46L,39L,21L,1L,1L,1L,1L,26L,1L,12L,1L,17L,1L,17L,1L,12L,26L,1L,1L,1L,1L,31L,86L,1L,29L,1L,34L,1L,29L,86L,31L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046620Inst : IEnumerable<long>
{
public static readonly long[] Value=A046620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046620.Bytes);
public long this[int i]=>Value[i];

public static A046620Inst Instance=new A046620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046669
{
public static readonly long[] Value={ 1L,3L,6L,8L,13L,15L,22L,24L,27L,29L,40L,42L,55L,57L,60L,62L,79L,81L,100L,102L,105L,107L,130L,132L,137L,139L,142L,144L,173L,175L,206L,208L,211L,213L,218L,220L,257L,259L,262L,264L,305L,307L,350L,352L,355L,357L,404L,406L,413L,415L,418L,420L,473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046669Inst : IEnumerable<long>
{
public static readonly long[] Value=A046669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046669.Bytes);
public long this[int i]=>Value[i];

public static A046669Inst Instance=new A046669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046670
{
public static readonly long[] Value={ 1L,3L,6L,8L,13L,16L,23L,25L,28L,33L,44L,47L,60L,67L,72L,74L,91L,94L,113L,118L,125L,136L,159L,162L,167L,180L,183L,190L,219L,224L,255L,257L,268L,285L,292L,295L,332L,351L,364L,369L,410L,417L,460L,471L,476L,499L,546L,549L,556L,561L,578L,591L,644L,647L,658L,665L,684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046670Inst : IEnumerable<long>
{
public static readonly long[] Value=A046670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046670.Bytes);
public long this[int i]=>Value[i];

public static A046670Inst Instance=new A046670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046671
{
public static readonly long[] Value={ 2L,3L,1L,4L,6L,1L,7L,8L,1L,9L,11L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046671Inst : IEnumerable<long>
{
public static readonly long[] Value=A046671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046671.Bytes);
public long this[int i]=>Value[i];

public static A046671Inst Instance=new A046671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046672
{
public static readonly long[] Value={ 1L,2L,7L,18L,53L,146L,415L,1162L,3277L,9210L,25927L,72930L,205221L,577378L,1624559L,4570810L,12860541L,36184394L,101808791L,286449682L,805956949L,2267645362L,6380262207L,17951546602L,50508589101L,142111293594L,399845261287L,1125007225154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046672Inst : IEnumerable<long>
{
public static readonly long[] Value=A046672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046672.Bytes);
public long this[int i]=>Value[i];

public static A046672Inst Instance=new A046672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046673
{
public static readonly BigInteger[] Value={ 2L,36L,1320L,84000L,8285760L,1173553920L,226040855040L,56865153945600L,18112111963545600L,7125892746964992000L,BigInteger.Parse("3394344333441245184000"),BigInteger.Parse("1925382105537337294848000"),BigInteger.Parse("1282520788685931213619200000"),BigInteger.Parse("991363455147400701817651200000"),BigInteger.Parse("880169729965718014490443776000000") };
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
public class A046673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046673Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046673.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046673Inst Instance=new A046673Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046674
{
public static readonly BigInteger[] Value={ 1L,18L,660L,42000L,4142880L,586776960L,113020427520L,28432576972800L,9056055981772800L,3562946373482496000L,BigInteger.Parse("1697172166720622592000"),BigInteger.Parse("962691052768668647424000"),BigInteger.Parse("641260394342965606809600000"),BigInteger.Parse("495681727573700350908825600000"),BigInteger.Parse("440084864982859007245221888000000") };
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
public class A046674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046674Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046674.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046674Inst Instance=new A046674Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046675
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,0L,0L,0L,0L,1L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,-1L,1L,1L,0L,-1L,0L,-1L,0L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,2L,0L,1L,-1L,1L,0L,0L,-3L,2L,1L,1L,-2L,1L,-2L,1L,-2L,1L,0L,2L,-3L,3L,-1L,0L,-2L,4L,-1L,2L,-4L,1L,-1L,3L,-5L,4L,-1L,2L,-3L,4L,-4L,3L,-5L,3L,-1L,4L,-8L,6L,-1L,2L,-7L,6L,-4L,8L,-6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046675Inst : IEnumerable<long>
{
public static readonly long[] Value=A046675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046675.Bytes);
public long this[int i]=>Value[i];

public static A046675Inst Instance=new A046675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046676
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,2L,3L,3L,4L,5L,6L,7L,9L,10L,12L,14L,17L,19L,23L,26L,31L,35L,41L,46L,54L,60L,69L,78L,89L,99L,113L,126L,143L,159L,179L,199L,224L,248L,277L,307L,343L,378L,421L,464L,515L,567L,628L,690L,763L,837L,923L,1012L,1115L,1219L,1340L,1465L,1607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046676Inst : IEnumerable<long>
{
public static readonly long[] Value=A046676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046676.Bytes);
public long this[int i]=>Value[i];

public static A046676Inst Instance=new A046676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046677
{
public static readonly long[] Value={ 2L,3L,3L,2L,3L,4L,5L,6L,4L,7L,7L,4L,4L,8L,6L,5L,6L,10L,6L,4L,10L,5L,12L,7L,11L,13L,9L,13L,11L,10L,10L,17L,8L,12L,12L,14L,16L,14L,14L,19L,10L,9L,17L,15L,19L,17L,17L,17L,13L,18L,16L,22L,15L,20L,20L,11L,16L,20L,18L,15L,16L,19L,15L,18L,16L,17L,18L,25L,17L,24L,20L,22L,26L,21L,18L,20L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046677Inst : IEnumerable<long>
{
public static readonly long[] Value=A046677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046677.Bytes);
public long this[int i]=>Value[i];

public static A046677Inst Instance=new A046677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046678
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,16L,25L,36L,64L,81L,100L,121L,128L,144L,162L,225L,256L,289L,324L,400L,484L,512L,529L,576L,625L,729L,841L,900L,1024L,1089L,1156L,1250L,1296L,1458L,1600L,1681L,1936L,2025L,2116L,2209L,2304L,2401L,2500L,2601L,2809L,3025L,3364L,3481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046678Inst : IEnumerable<long>
{
public static readonly long[] Value=A046678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046678.Bytes);
public long this[int i]=>Value[i];

public static A046678Inst Instance=new A046678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046679
{
public static readonly long[] Value={ 2L,8L,9L,16L,18L,64L,72L,81L,128L,144L,625L,729L,1024L,1152L,1296L,1458L,2401L,4096L,5184L,5625L,5832L,6561L,8192L,9216L,10000L,11664L,13122L,15625L,21609L,28561L,31250L,32768L,38416L,40000L,46656L,50625L,52488L,59049L,65536L,83521L,90000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046679Inst : IEnumerable<long>
{
public static readonly long[] Value=A046679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046679.Bytes);
public long this[int i]=>Value[i];

public static A046679Inst Instance=new A046679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046680
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,16L,25L,36L,81L,100L,121L,128L,144L,162L,225L,256L,289L,324L,400L,484L,512L,529L,625L,729L,841L,900L,1024L,1089L,1156L,1250L,1296L,1458L,1681L,1936L,2025L,2116L,2209L,2304L,2401L,2500L,2601L,2809L,2916L,3025L,3364L,3481L,3600L,4096L,4356L,4624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046680Inst : IEnumerable<long>
{
public static readonly long[] Value=A046680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046680.Bytes);
public long this[int i]=>Value[i];

public static A046680Inst Instance=new A046680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046681
{
public static readonly long[] Value={ 1L,2L,8L,9L,18L,64L,72L,128L,625L,729L,1024L,1152L,1250L,1458L,4096L,5000L,5625L,5832L,6561L,8192L,9216L,11250L,13122L,15625L,31250L,32768L,40000L,45000L,46656L,52488L,59049L,65536L,80000L,93312L,117649L,118098L,125000L,235298L,262144L,294912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046681Inst : IEnumerable<long>
{
public static readonly long[] Value=A046681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046681.Bytes);
public long this[int i]=>Value[i];

public static A046681Inst Instance=new A046681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046682
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,8L,12L,16L,22L,29L,40L,52L,69L,90L,118L,151L,195L,248L,317L,400L,505L,632L,793L,985L,1224L,1512L,1867L,2291L,2811L,3431L,4186L,5084L,6168L,7456L,9005L,10836L,13026L,15613L,18692L,22316L,26613L,31659L,37619L,44601L,52815L,62416L,73680L,86809L,102162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046682Inst : IEnumerable<long>
{
public static readonly long[] Value=A046682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046682.Bytes);
public long this[int i]=>Value[i];

public static A046682Inst Instance=new A046682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046683
{
public static readonly long[] Value={ 1L,2L,4L,9L,18L,25L,36L,100L,121L,225L,289L,484L,529L,841L,900L,1089L,1156L,1681L,2116L,2209L,2601L,2809L,3364L,3481L,4356L,4761L,5041L,6724L,6889L,7225L,7569L,7921L,8836L,10201L,10404L,11236L,11449L,12769L,13225L,13924L,15129L,17161L,18769L,19044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046683Inst : IEnumerable<long>
{
public static readonly long[] Value=A046683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046683.Bytes);
public long this[int i]=>Value[i];

public static A046683Inst Instance=new A046683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046684
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,13L,16L,17L,18L,19L,21L,23L,25L,27L,29L,31L,32L,33L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,64L,67L,69L,71L,72L,73L,77L,79L,81L,83L,87L,89L,91L,93L,95L,97L,98L,99L,100L,101L,103L,107L,109L,111L,113L,119L,121L,123L,125L,127L,128L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046684Inst : IEnumerable<long>
{
public static readonly long[] Value=A046684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046684.Bytes);
public long this[int i]=>Value[i];

public static A046684Inst Instance=new A046684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046701
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,3L,4L,4L,8L,5L,6L,5L,8L,7L,12L,6L,14L,6L,13L,8L,15L,8L,19L,8L,20L,6L,21L,8L,23L,8L,27L,8L,28L,6L,29L,8L,31L,8L,35L,8L,36L,6L,37L,8L,39L,8L,43L,8L,44L,6L,45L,8L,47L,8L,51L,8L,52L,6L,53L,8L,55L,8L,59L,8L,60L,6L,61L,8L,63L,8L,67L,8L,68L,6L,69L,8L,71L,8L,75L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046701Inst : IEnumerable<long>
{
public static readonly long[] Value=A046701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046701.Bytes);
public long this[int i]=>Value[i];

public static A046701Inst Instance=new A046701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046702
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,5L,5L,7L,5L,7L,7L,9L,9L,9L,11L,11L,13L,11L,15L,13L,17L,13L,17L,15L,19L,17L,19L,17L,21L,19L,23L,19L,23L,21L,25L,23L,25L,25L,27L,27L,27L,29L,29L,31L,29L,33L,31L,35L,31L,37L,33L,39L,33L,41L,35L,43L,35L,43L,37L,45L,39L,45L,39L,47L,41L,49L,41L,49L,43L,51L,45L,51L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046702Inst : IEnumerable<long>
{
public static readonly long[] Value=A046702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046702.Bytes);
public long this[int i]=>Value[i];

public static A046702Inst Instance=new A046702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046703
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,31L,71L,113L,131L,151L,211L,311L,1117L,1151L,1171L,1511L,2111L,11113L,11117L,11131L,11171L,11311L,111121L,111211L,112111L,113111L,131111L,311111L,511111L,1111151L,1111211L,1111711L,1117111L,1171111L,11111117L,11111131L,11111171L,11111311L,11113111L,11131111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046703Inst : IEnumerable<long>
{
public static readonly long[] Value=A046703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046703.Bytes);
public long this[int i]=>Value[i];

public static A046703Inst Instance=new A046703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046704
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,23L,29L,41L,43L,47L,61L,67L,83L,89L,101L,113L,131L,137L,139L,151L,157L,173L,179L,191L,193L,197L,199L,223L,227L,229L,241L,263L,269L,281L,283L,311L,313L,317L,331L,337L,353L,359L,373L,379L,397L,401L,409L,421L,443L,449L,461L,463L,467L,487L,557L,571L,577L,593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046704Inst : IEnumerable<long>
{
public static readonly long[] Value=A046704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046704.Bytes);
public long this[int i]=>Value[i];

public static A046704Inst Instance=new A046704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046705
{
public static readonly BigInteger[] Value={ 2L,3L,5L,7L,131L,151L,11311L,1117111L,111111151111111L,BigInteger.Parse("111111111111111111131111111111111111111"),BigInteger.Parse("1111111111111111111111111111111117111111111111111111111111111111111"),BigInteger.Parse("1111111111111111111111111111111111111111111115111111111111111111111111111111111111111111111") };
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
public class A046705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046705Inst Instance=new A046705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046706
{
public static readonly BigInteger[] Value={ 0L,1L,10L,90L,1392L,18675L,409104L,7411348L,209085952L,4788571365L,164757984000L,4571341663086L,185247857018880L,6045063784869655L,281596888593405952L,10574853536725785000UL,BigInteger.Parse("556202715633735696384"),BigInteger.Parse("23639922913364842592457") };
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
public class A046706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046706Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046706.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046706Inst Instance=new A046706Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046707
{
public static readonly BigInteger[] Value={ 1L,6L,33L,472L,4745L,99216L,1456273L,39669120L,769528593L,25737068800L,622548099041L,24632715009024L,715109889035737L,32630102257170432L,1106618435304908625L,BigInteger.Parse("57151019891266256896"),BigInteger.Parse("2219208490411286184737"),BigInteger.Parse("127876294410780326952960") };
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
public class A046707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046707Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046707.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046707Inst Instance=new A046707Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046708
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,4L,8L,8L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046708Inst : IEnumerable<long>
{
public static readonly long[] Value=A046708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046708.Bytes);
public long this[int i]=>Value[i];

public static A046708Inst Instance=new A046708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046709
{
public static readonly BigInteger[] Value={ 25200L,982800L,1562400L,60933600L,6854400L,267321600L,798939187200L,31158628300800L,450964684800L,17587622707200L,118216784402841600L,459775632811622400L,BigInteger.Parse("1936908127288531353600"),BigInteger.Parse("75539416964252722790400") };
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
public class A046709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046709Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046709.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046709Inst Instance=new A046709Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046710
{
public static readonly BigInteger[] Value={ 26640L,1038960L,1651680L,64415520L,7246080L,282597120L,844592855040L,32939121346560L,476734095360L,18592629719040L,124972029225861120L,486048526115143680L,BigInteger.Parse("2047588591705018859520"),BigInteger.Parse("79855955076495735521280") };
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
public class A046710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046710Inst Instance=new A046710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046711
{
public static readonly long[] Value={ 1L,2L,5L,9L,10L,13L,17L,18L,25L,26L,29L,34L,37L,41L,45L,49L,50L,53L,58L,61L,65L,73L,74L,81L,82L,85L,89L,90L,97L,98L,101L,106L,109L,113L,117L,121L,122L,125L,130L,137L,145L,146L,149L,153L,157L,162L,169L,170L,173L,178L,181L,185L,193L,194L,197L,202L,205L,218L,221L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046711Inst : IEnumerable<long>
{
public static readonly long[] Value=A046711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046711.Bytes);
public long this[int i]=>Value[i];

public static A046711Inst Instance=new A046711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046712
{
public static readonly long[] Value={ 6L,14L,21L,22L,30L,33L,38L,42L,46L,54L,57L,62L,66L,69L,70L,77L,78L,86L,93L,94L,102L,105L,110L,114L,118L,126L,129L,133L,134L,138L,141L,142L,150L,154L,158L,161L,165L,166L,174L,177L,182L,186L,189L,190L,198L,201L,206L,209L,210L,213L,214L,217L,222L,230L,237L,238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046712Inst : IEnumerable<long>
{
public static readonly long[] Value=A046712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046712.Bytes);
public long this[int i]=>Value[i];

public static A046712Inst Instance=new A046712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046713
{
public static readonly long[] Value={ 2L,3L,5L,7L,113L,131L,151L,311L,2111L,11113L,11117L,11131L,11171L,11311L,111121L,111211L,112111L,1111151L,1111711L,1117111L,1171111L,111111113L,111111131L,111113111L,115111111L,131111111L,1111111121L,1111211111L,1121111111L,11111111113L,11111111131L,11113111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046713Inst : IEnumerable<long>
{
public static readonly long[] Value=A046713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046713.Bytes);
public long this[int i]=>Value[i];

public static A046713Inst Instance=new A046713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046714
{
public static readonly long[] Value={ 1L,6L,32L,165L,839L,4237L,21317L,107014L,536500L,2687362L,13453606L,67326816L,336842092L,1684953360L,8427441240L,42146901045L,210769862895L,1053978959265L,5270372435025L,26353629438315L,131774711311995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046714Inst : IEnumerable<long>
{
public static readonly long[] Value=A046714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046714.Bytes);
public long this[int i]=>Value[i];

public static A046714Inst Instance=new A046714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046715
{
public static readonly BigInteger[] Value={ 0L,1L,10L,105L,1176L,13860L,169884L,2147145L,27810640L,367479684L,4936848280L,67255063876L,927192688800L,12914469594000L,181497968832600L,2570903476583625L,36671501616314400L,526348636137670500L,7597019633665077000L,BigInteger.Parse("110205019733436728100") };
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
public class A046715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046715Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046715.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046715Inst Instance=new A046715Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046716
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,8L,1L,1L,10L,29L,24L,1L,1L,15L,75L,145L,89L,1L,1L,21L,160L,545L,814L,415L,1L,1L,28L,301L,1575L,4179L,5243L,2372L,1L,1L,36L,518L,3836L,15659L,34860L,38618L,16072L,1L,1L,45L,834L,8274L,47775L,163191L,318926L,321690L,125673L,1L,1L,55L,1275L,16290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046716Inst : IEnumerable<long>
{
public static readonly long[] Value=A046716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046716.Bytes);
public long this[int i]=>Value[i];

public static A046716Inst Instance=new A046716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046717
{
public static readonly long[] Value={ 1L,1L,5L,13L,41L,121L,365L,1093L,3281L,9841L,29525L,88573L,265721L,797161L,2391485L,7174453L,21523361L,64570081L,193710245L,581130733L,1743392201L,5230176601L,15690529805L,47071589413L,141214768241L,423644304721L,1270932914165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046717Inst : IEnumerable<long>
{
public static readonly long[] Value=A046717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046717.Bytes);
public long this[int i]=>Value[i];

public static A046717Inst Instance=new A046717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046718
{
public static readonly long[] Value={ 1L,4L,14L,47L,152L,472L,1408L,4048L,11264L,30464L,80384L,207616L,526336L,1312768L,3227648L,7835648L,18808832L,44695552L,105250816L,245825536L,569901056L,1312292864L,3003121664L,6833569792L,15468593152L,34846277632L,78148272128L,174533378048L,388291887104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046718Inst : IEnumerable<long>
{
public static readonly long[] Value=A046718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046718.Bytes);
public long this[int i]=>Value[i];

public static A046718Inst Instance=new A046718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046719
{
public static readonly long[] Value={ 4L,42L,429L,4244L,41815L,413436L,4102567L,40775008L,405774711L,4042049770L,40293025322L,401878286460L,4009949122673L,40024266995482L,399594430078005L,3990300329780096L,39853419882545236L,398095148341559286L,3977036546783471193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046719Inst : IEnumerable<long>
{
public static readonly long[] Value=A046719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046719.Bytes);
public long this[int i]=>Value[i];

public static A046719Inst Instance=new A046719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046720
{
public static readonly long[] Value={ 76667L,700666007L,700000666000007L,70000006660000007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046720Inst : IEnumerable<long>
{
public static readonly long[] Value=A046720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046720.Bytes);
public long this[int i]=>Value[i];

public static A046720Inst Instance=new A046720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046721
{
public static readonly long[] Value={ 1L,2L,6L,16L,48L,140L,428L,1308L,4072L,12796L,40432L,129432L,413900L,1342580L,4335288L,14201804L,46226896L,152594276L,500016036L,1660630740L,5472190206L,18264517264L,60475691308L,202684618564L,673892675030L,2266436498400L,7562707682032L,25510762766704L,85394319699916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046721Inst : IEnumerable<long>
{
public static readonly long[] Value=A046721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046721.Bytes);
public long this[int i]=>Value[i];

public static A046721Inst Instance=new A046721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046722
{
public static readonly long[] Value={ 1L,3L,11L,37L,126L,430L,1454L,4976L,16880L,57824L,197010L,675428L,2310268L,7927778L,27205180L,93448486L,321537086L,1105589516L,3812424912L,13121988240L,45330375774L,156172996170L,540314673678L,1863197292582L,6454265995454L,22275589419432L,77246945788890L,266813803179348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046722Inst : IEnumerable<long>
{
public static readonly long[] Value=A046722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046722.Bytes);
public long this[int i]=>Value[i];

public static A046722Inst Instance=new A046722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046723
{
public static readonly long[] Value={ 1L,4L,17L,66L,254L,956L,3584L,13256L,49052L,179552L,658560L,2394504L,8724464L,31575096L,114451388L,412811544L,1490190544L,5360943684L,19288139802L,69245171564L,248463024330L,890477645192L,3188033497580L,11409453277272L,40771092374710L,145735210316376L,519955750491512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046723Inst : IEnumerable<long>
{
public static readonly long[] Value=A046723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046723.Bytes);
public long this[int i]=>Value[i];

public static A046723Inst Instance=new A046723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046724
{
public static readonly long[] Value={ 1L,5L,24L,104L,438L,1796L,7238L,28848L,113518L,444278L,1720384L,6643492L,25421620L,97136712L,368280210L,1395104236L,5250325378L,19746342212L,73863421894L,276113486146L,1027609657470L,3821478801772L,14161346139866L,52428406903688L,193568833452364L,713860635606784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046724Inst : IEnumerable<long>
{
public static readonly long[] Value=A046724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046724.Bytes);
public long this[int i]=>Value[i];

public static A046724Inst Instance=new A046724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046725
{
public static readonly long[] Value={ 1L,6L,32L,152L,690L,3028L,12996L,54812L,228284L,939148L,3833076L,15487428L,62244564L,247973928L,984221764L,3876113404L,15223550024L,59379645924L,231124139318L,894157177372L,3453279084296L,13266154255196L,50886266714598L,194294744477756L,740816697816046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046725Inst : IEnumerable<long>
{
public static readonly long[] Value=A046725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046725.Bytes);
public long this[int i]=>Value[i];

public static A046725Inst Instance=new A046725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046726
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,6L,4L,1L,4L,11L,16L,10L,1L,5L,17L,37L,48L,24L,1L,6L,24L,66L,126L,140L,66L,1L,7L,32L,104L,254L,430L,428L,174L,1L,8L,41L,152L,438L,956L,1454L,1308L,504L,1L,9L,51L,211L,690L,1796L,3584L,4976L,4072L,1406L,1L,10L,62L,282L,1023L,3028L,7238L,13256L,16880L,12796L,4210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046726Inst : IEnumerable<long>
{
public static readonly long[] Value=A046726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046726.Bytes);
public long this[int i]=>Value[i];

public static A046726Inst Instance=new A046726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046727
{
public static readonly long[] Value={ 0L,3L,21L,119L,697L,4059L,23661L,137903L,803761L,4684659L,27304197L,159140519L,927538921L,5406093003L,31509019101L,183648021599L,1070379110497L,6238626641379L,36361380737781L,211929657785303L,1235216565974041L,7199369738058939L,41961001862379597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046727Inst : IEnumerable<long>
{
public static readonly long[] Value=A046727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046727.Bytes);
public long this[int i]=>Value[i];

public static A046727Inst Instance=new A046727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046728
{
public static readonly long[] Value={ 2L,6L,8L,270L,42L,12L,180L,102L,546L,750L,822L,510L,660L,300L,534L,5208L,7140L,3302L,7800L,1476L,18840L,20706L,9570L,44960L,13986L,5862L,4672L,71118L,14538L,59370L,156348L,17688L,59184L,155736L,1782L,328694L,110370L,119616L,93402L,76116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046728Inst : IEnumerable<long>
{
public static readonly long[] Value=A046728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046728.Bytes);
public long this[int i]=>Value[i];

public static A046728Inst Instance=new A046728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046729
{
public static readonly long[] Value={ 0L,4L,20L,120L,696L,4060L,23660L,137904L,803760L,4684660L,27304196L,159140520L,927538920L,5406093004L,31509019100L,183648021600L,1070379110496L,6238626641380L,36361380737780L,211929657785304L,1235216565974040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046729Inst : IEnumerable<long>
{
public static readonly long[] Value=A046729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046729.Bytes);
public long this[int i]=>Value[i];

public static A046729Inst Instance=new A046729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046730
{
public static readonly long[] Value={ -1L,3L,1L,-5L,-1L,5L,7L,-5L,-3L,5L,9L,-1L,3L,-7L,-11L,7L,11L,-13L,-9L,-7L,-1L,15L,13L,-15L,1L,-13L,-9L,5L,-17L,13L,11L,9L,-5L,17L,7L,-17L,19L,1L,-3L,15L,17L,-7L,21L,19L,-5L,-11L,-21L,19L,13L,1L,-23L,5L,-17L,-19L,25L,-13L,-25L,-23L,-1L,-5L,15L,27L,-9L,-19L,25L,-17L,11L,5L,-25L,27L,23L,29L,-29L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046730Inst : IEnumerable<long>
{
public static readonly long[] Value=A046730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046730.Bytes);
public long this[int i]=>Value[i];

public static A046730Inst Instance=new A046730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046731
{
public static readonly BigInteger[] Value={ 0L,17L,1060L,76127L,5736396L,454396537L,37550402023L,3203324994356L,279209790387276L,24739512092254535L,2220822432581729238L,BigInteger.Parse("201467077743744681014"),BigInteger.Parse("18435588552550705911377"),BigInteger.Parse("1699246443377779418889494"),BigInteger.Parse("157589260710736940541561021"),BigInteger.Parse("14692398516908006398225702366") };
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
public class A046731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046731Inst Instance=new A046731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046732
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,31L,37L,71L,73L,79L,97L,107L,149L,157L,167L,179L,347L,359L,389L,701L,709L,739L,743L,751L,761L,769L,907L,937L,941L,953L,967L,971L,983L,1069L,1097L,1237L,1249L,1259L,1279L,1283L,1409L,1429L,1439L,1453L,1487L,1523L,1583L,1597L,1657L,1723L,1753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046732Inst : IEnumerable<long>
{
public static readonly long[] Value=A046732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046732.Bytes);
public long this[int i]=>Value[i];

public static A046732Inst Instance=new A046732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046813
{
public static readonly long[] Value={ 1L,2L,13L,113L,149L,1127L,1136L,1247L,1123L,1349L,1579L,1237L,11267L,11338L,11248L,11237L,11234L,11389L,11579L,13358L,11347L,11239L,12457L,12679L,12349L,12347L,13678L,12359L,14579L,13489L,111349L,12367L,12389L,23579L,13579L,112468L,12379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046813Inst : IEnumerable<long>
{
public static readonly long[] Value=A046813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046813.Bytes);
public long this[int i]=>Value[i];

public static A046813Inst Instance=new A046813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046814
{
public static readonly long[] Value={ 1L,2L,8L,37L,179L,881L,4369L,21746L,108444L,541362L,2704158L,13512392L,67534828L,337584992L,1687627800L,8437136085L,42182258715L,210899507685L,1054456597965L,5272139698215L,26360193558735L,131799177579015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046814Inst : IEnumerable<long>
{
public static readonly long[] Value=A046814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046814.Bytes);
public long this[int i]=>Value[i];

public static A046814Inst Instance=new A046814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046815
{
public static readonly long[] Value={ 1L,3L,8L,21L,24L,144L,58L,63L,147L,155L,152L,173L,168L,385L,398L,461L,406L,401L,435L,1215L,440L,1016L,1011L,1063L,1053L,1045L,1066L,2608L,1050L,1139L,1160L,2650L,2642L,1155L,2663L,2807L,2647L,6841L,2969L,2749L,2736L,7145L,2757L,2791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046815Inst : IEnumerable<long>
{
public static readonly long[] Value=A046815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046815.Bytes);
public long this[int i]=>Value[i];

public static A046815Inst Instance=new A046815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046816
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,1L,2L,1L,1L,3L,3L,3L,6L,3L,1L,3L,3L,1L,1L,4L,4L,6L,12L,6L,4L,12L,12L,4L,1L,4L,6L,4L,1L,1L,5L,5L,10L,20L,10L,10L,30L,30L,10L,5L,20L,30L,20L,5L,1L,5L,10L,10L,5L,1L,1L,6L,6L,15L,30L,15L,20L,60L,60L,20L,15L,60L,90L,60L,15L,6L,30L,60L,60L,30L,6L,1L,6L,15L,20L,15L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046816Inst : IEnumerable<long>
{
public static readonly long[] Value=A046816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046816.Bytes);
public long this[int i]=>Value[i];

public static A046816Inst Instance=new A046816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046817
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,5L,1L,12L,32L,15L,1L,20L,110L,175L,52L,1L,30L,280L,945L,1012L,203L,1L,42L,595L,3465L,8092L,6230L,877L,1L,56L,1120L,10010L,40992L,70756L,40819L,4140L,1L,72L,1932L,24570L,156072L,479976L,638423L,283944L,21147L,1L,90L,3120L,53550L,487704L,2350950L,5660615L,5971350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046817Inst : IEnumerable<long>
{
public static readonly long[] Value=A046817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046817.Bytes);
public long this[int i]=>Value[i];

public static A046817Inst Instance=new A046817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046818
{
public static readonly long[] Value={ 1L,1L,3L,2L,3L,1L,3L,3L,3L,3L,5L,2L,3L,2L,4L,4L,3L,3L,5L,4L,5L,1L,3L,3L,3L,3L,5L,3L,4L,3L,5L,5L,3L,3L,5L,4L,5L,3L,5L,5L,5L,5L,7L,2L,3L,2L,4L,4L,3L,3L,5L,4L,5L,2L,4L,4L,4L,4L,6L,4L,5L,4L,6L,6L,3L,3L,5L,4L,5L,3L,5L,5L,5L,5L,7L,4L,5L,4L,6L,6L,5L,5L,7L,6L,7L,1L,3L,3L,3L,3L,5L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046818Inst : IEnumerable<long>
{
public static readonly long[] Value=A046818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046818.Bytes);
public long this[int i]=>Value[i];

public static A046818Inst Instance=new A046818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046819
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,2L,2L,4L,3L,4L,1L,3L,3L,3L,3L,5L,3L,4L,3L,5L,5L,2L,2L,4L,3L,4L,2L,4L,4L,4L,4L,6L,3L,4L,3L,5L,5L,4L,4L,6L,5L,6L,1L,3L,3L,3L,3L,5L,3L,4L,3L,5L,5L,3L,3L,5L,4L,5L,3L,5L,5L,5L,5L,7L,3L,4L,3L,5L,5L,4L,4L,6L,5L,6L,3L,5L,5L,5L,5L,7L,5L,6L,5L,7L,7L,2L,2L,4L,3L,4L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046819Inst : IEnumerable<long>
{
public static readonly long[] Value=A046819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046819.Bytes);
public long this[int i]=>Value[i];

public static A046819Inst Instance=new A046819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046820
{
public static readonly long[] Value={ 0L,2L,2L,4L,2L,3L,4L,3L,2L,4L,3L,5L,4L,2L,3L,4L,2L,4L,4L,6L,3L,4L,5L,5L,4L,6L,2L,4L,3L,3L,4L,5L,2L,4L,4L,6L,4L,5L,6L,4L,3L,5L,4L,6L,5L,4L,5L,6L,4L,6L,6L,8L,2L,3L,4L,4L,3L,5L,3L,5L,4L,4L,5L,6L,2L,4L,4L,6L,4L,5L,6L,5L,4L,6L,5L,7L,6L,3L,4L,5L,3L,5L,5L,7L,4L,5L,6L,6L,5L,7L,4L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046820Inst : IEnumerable<long>
{
public static readonly long[] Value=A046820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046820.Bytes);
public long this[int i]=>Value[i];

public static A046820Inst Instance=new A046820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046821
{
public static readonly long[] Value={ 1L,2L,3L,1L,3L,3L,5L,2L,3L,4L,4L,3L,5L,2L,4L,3L,3L,4L,5L,2L,4L,4L,6L,4L,5L,6L,3L,2L,4L,3L,5L,4L,3L,4L,5L,3L,5L,5L,7L,3L,4L,5L,5L,4L,6L,4L,6L,5L,5L,6L,7L,1L,3L,3L,5L,3L,4L,5L,4L,3L,5L,4L,6L,5L,3L,4L,5L,3L,5L,5L,7L,4L,5L,6L,6L,5L,7L,3L,5L,4L,4L,5L,6L,3L,5L,5L,7L,5L,6L,7L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046821Inst : IEnumerable<long>
{
public static readonly long[] Value=A046821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046821.Bytes);
public long this[int i]=>Value[i];

public static A046821Inst Instance=new A046821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046822
{
public static readonly long[] Value={ 1L,3L,2L,2L,3L,4L,1L,3L,3L,5L,3L,4L,5L,3L,2L,4L,3L,5L,4L,3L,4L,5L,3L,5L,5L,7L,2L,3L,4L,4L,3L,5L,3L,5L,4L,4L,5L,6L,2L,4L,4L,6L,4L,5L,6L,5L,4L,6L,5L,7L,6L,2L,3L,4L,2L,4L,4L,6L,3L,4L,5L,5L,4L,6L,3L,5L,4L,4L,5L,6L,3L,5L,5L,7L,5L,6L,7L,4L,3L,5L,4L,6L,5L,4L,5L,6L,4L,6L,6L,8L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046822Inst : IEnumerable<long>
{
public static readonly long[] Value=A046822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046822.Bytes);
public long this[int i]=>Value[i];

public static A046822Inst Instance=new A046822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046823
{
public static readonly long[] Value={ 2L,1L,3L,2L,4L,3L,2L,3L,4L,2L,4L,4L,6L,2L,3L,4L,4L,3L,5L,3L,5L,4L,4L,5L,6L,1L,3L,3L,5L,3L,4L,5L,4L,3L,5L,4L,6L,5L,3L,4L,5L,3L,5L,5L,7L,4L,5L,6L,6L,5L,7L,2L,4L,3L,3L,4L,5L,2L,4L,4L,6L,4L,5L,6L,4L,3L,5L,4L,6L,5L,4L,5L,6L,4L,6L,6L,8L,3L,4L,5L,5L,4L,6L,4L,6L,5L,5L,6L,7L,3L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046823Inst : IEnumerable<long>
{
public static readonly long[] Value=A046823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046823.Bytes);
public long this[int i]=>Value[i];

public static A046823Inst Instance=new A046823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046824
{
public static readonly long[] Value={ 1L,2L,3L,3L,2L,4L,2L,4L,3L,3L,4L,5L,1L,3L,3L,5L,3L,4L,5L,4L,3L,5L,4L,6L,5L,2L,3L,4L,2L,4L,4L,6L,3L,4L,5L,5L,4L,6L,3L,5L,4L,4L,5L,6L,3L,5L,5L,7L,5L,6L,7L,3L,2L,4L,3L,5L,4L,3L,4L,5L,3L,5L,5L,7L,3L,4L,5L,5L,4L,6L,4L,6L,5L,5L,6L,7L,2L,4L,4L,6L,4L,5L,6L,5L,4L,6L,5L,7L,6L,4L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046824Inst : IEnumerable<long>
{
public static readonly long[] Value=A046824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046824.Bytes);
public long this[int i]=>Value[i];

public static A046824Inst Instance=new A046824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046825
{
public static readonly long[] Value={ 1L,2L,5L,8L,8L,13L,151L,256L,83L,146L,1433L,2588L,15341L,28211L,52235L,19456L,19345L,36362L,651745L,6168632L,1463914L,2786599L,122289917L,233836352L,140001721L,268709146L,774885169L,1491969394L,41711914513L,80530073893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046825Inst : IEnumerable<long>
{
public static readonly long[] Value=A046825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046825.Bytes);
public long this[int i]=>Value[i];

public static A046825Inst Instance=new A046825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046826
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,60L,105L,35L,63L,630L,1155L,6930L,12870L,24024L,9009L,9009L,17017L,306306L,2909907L,692835L,1322685L,58198140L,111546435L,66927861L,128707425L,371821450L,717084225L,20078358300L,38818159380L,2329089562800L,4512611027925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046826Inst : IEnumerable<long>
{
public static readonly long[] Value=A046826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046826.Bytes);
public long this[int i]=>Value[i];

public static A046826Inst Instance=new A046826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046827
{
public static readonly long[] Value={ 0L,1L,5L,6L,10L,11L,25L,27L,50L,60L,63L,64L,74L,76L,95L,96L,100L,101L,105L,110L,125L,139L,142L,205L,250L,255L,261L,270L,275L,277L,278L,285L,305L,364L,371L,376L,405L,421L,441L,463L,472L,493L,497L,500L,501L,502L,503L,504L,505L,506L,507L,508L,509L,523L,524L,525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046827Inst : IEnumerable<long>
{
public static readonly long[] Value=A046827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046827.Bytes);
public long this[int i]=>Value[i];

public static A046827Inst Instance=new A046827Inst();

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