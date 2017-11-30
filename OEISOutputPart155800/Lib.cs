using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198905
{
public static readonly BigInteger[] Value={ 187L,804833L,3794115705L,17895005957823L,84402688527136201L,BigInteger.Parse("398089706066811447174"),BigInteger.Parse("1877611081501313948217870"),BigInteger.Parse("8855851690895754550489882369"),BigInteger.Parse("41769091588504560613470987916898") };
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
public class A198905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198905Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198905.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198905Inst Instance=new A198905Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198906
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,5L,33L,33L,5L,15L,380L,1211L,380L,15L,51L,4801L,50384L,50384L,4801L,51L,187L,62004L,2125425L,6907736L,2125425L,62004L,187L,715L,804833L,89793204L,948656912L,948656912L,89793204L,804833L,715L,2795L,10459180L,3794115705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198906Inst : IEnumerable<long>
{
public static readonly long[] Value=A198906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198906.Bytes);
public long this[int i]=>Value[i];

public static A198906Inst Instance=new A198906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198907
{
public static readonly BigInteger[] Value={ 1L,4L,2051L,319608038L,4717456775959530L,BigInteger.Parse("2869765342757082981876352") };
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
public class A198907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198907Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198907.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198907Inst Instance=new A198907Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198908
{
public static readonly BigInteger[] Value={ 1L,4L,34L,500L,10867L,313132L,10856948L,418689772L,17067989413L,715189507700L,30371156968582L,1298083132473604L,55654030558406039L,2389712969490386908L,BigInteger.Parse("102686352402421016536"),BigInteger.Parse("4414019789796312628796"),BigInteger.Parse("189771542890022982723145") };
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
public class A198908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198908Inst Instance=new A198908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198909
{
public static readonly BigInteger[] Value={ 2L,34L,2051L,269940L,54381563L,13088156547L,3352514013159L,876632051686733L,230783525290600476L,BigInteger.Parse("60892298359864756053"),BigInteger.Parse("16078352442288906898825"),BigInteger.Parse("4246466444504000973551502"),BigInteger.Parse("1121629692628918068552449185") };
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
public class A198909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198909Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198909.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198909Inst Instance=new A198909Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198910
{
public static readonly BigInteger[] Value={ 5L,500L,269940L,319608038L,481871809749L,769126451071174L,1243368053336112649L,BigInteger.Parse("2015791720035206825303"),BigInteger.Parse("3270193421121063659774745"),BigInteger.Parse("5305976942994216714747844079"),BigInteger.Parse("8609380449975858170849466245738") };
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
public class A198910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198910Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198910.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198910Inst Instance=new A198910Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198911
{
public static readonly BigInteger[] Value={ 15L,10867L,54381563L,481871809749L,4717456775959530L,BigInteger.Parse("46891073386615240710"),BigInteger.Parse("467181941240736711604077"),BigInteger.Parse("4656280284540702751242128730"),BigInteger.Parse("46410545076265038917843608182171"),BigInteger.Parse("462591920649454036671348839366018986") };
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
public class A198911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198911Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198911.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198911Inst Instance=new A198911Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198912
{
public static readonly BigInteger[] Value={ 52L,313132L,13088156547L,769126451071174L,BigInteger.Parse("46891073386615240710"),BigInteger.Parse("2869765342757082981876352") };
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
public class A198912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198912Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198912.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198912Inst Instance=new A198912Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198913
{
public static readonly BigInteger[] Value={ 203L,10856948L,3352514013159L,1243368053336112649L,BigInteger.Parse("467181941240736711604077") };
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
public class A198913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198913Inst Instance=new A198913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198914
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,5L,34L,34L,5L,15L,500L,2051L,500L,15L,52L,10867L,269940L,269940L,10867L,52L,203L,313132L,54381563L,319608038L,54381563L,313132L,203L,877L,10856948L,13088156547L,481871809749L,481871809749L,13088156547L,10856948L,877L,4139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198914Inst : IEnumerable<long>
{
public static readonly long[] Value=A198914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198914.Bytes);
public long this[int i]=>Value[i];

public static A198914Inst Instance=new A198914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198915
{
public static readonly BigInteger[] Value={ 3L,57L,261633L,18014398375264257L,BigInteger.Parse("5846006549323611672814736913013492849365380759553") };
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
public class A198915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198915Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198915.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198915Inst Instance=new A198915Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198916
{
public static readonly BigInteger[] Value={ 1L,1L,4L,23L,158L,1212L,10058L,88811L,826982L,8085950L,82922624L,893003234L,10129641140L,121552747370L,1550460365622L,21115793548491L,308004022741254L,4817224946243142L,80703099826887368L,1444218797390453282L,BigInteger.Parse("27501426760092853796"),BigInteger.Parse("554910390616969332656") };
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
public class A198916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198916Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198916.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198916Inst Instance=new A198916Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198917
{
public static readonly long[] Value={ 8L,8L,8L,7L,4L,7L,2L,4L,2L,9L,3L,1L,7L,4L,1L,0L,3L,0L,5L,9L,6L,1L,0L,6L,1L,7L,7L,6L,5L,2L,4L,0L,1L,0L,9L,1L,6L,7L,2L,2L,9L,6L,0L,1L,7L,5L,9L,8L,3L,5L,2L,1L,0L,9L,0L,0L,7L,0L,2L,8L,6L,8L,3L,2L,0L,2L,4L,0L,1L,9L,3L,1L,2L,3L,1L,1L,9L,1L,3L,4L,2L,7L,9L,0L,7L,7L,5L,8L,1L,9L,9L,6L,6L,5L,1L,8L,0L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198917Inst : IEnumerable<long>
{
public static readonly long[] Value=A198917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198917.Bytes);
public long this[int i]=>Value[i];

public static A198917Inst Instance=new A198917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198918
{
public static readonly long[] Value={ 1L,0L,8L,5L,2L,5L,1L,0L,1L,3L,1L,3L,9L,7L,5L,8L,0L,2L,0L,5L,1L,2L,0L,9L,3L,9L,4L,8L,3L,2L,7L,6L,0L,5L,7L,9L,1L,8L,8L,9L,8L,4L,5L,7L,3L,6L,3L,5L,1L,2L,4L,7L,5L,3L,6L,8L,1L,7L,9L,2L,7L,2L,9L,9L,0L,5L,7L,1L,1L,2L,1L,4L,8L,5L,4L,4L,4L,2L,7L,8L,0L,4L,6L,9L,7L,9L,1L,9L,4L,3L,7L,8L,3L,5L,9L,0L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198918Inst : IEnumerable<long>
{
public static readonly long[] Value=A198918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198918.Bytes);
public long this[int i]=>Value[i];

public static A198918Inst Instance=new A198918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198919
{
public static readonly long[] Value={ 7L,0L,0L,1L,0L,8L,3L,9L,5L,0L,4L,1L,6L,3L,1L,4L,3L,1L,5L,3L,1L,5L,6L,1L,9L,4L,0L,3L,6L,5L,4L,1L,4L,6L,1L,3L,5L,5L,7L,2L,0L,0L,9L,9L,9L,6L,3L,3L,2L,6L,5L,3L,0L,6L,7L,0L,4L,0L,9L,6L,6L,2L,6L,2L,8L,7L,9L,6L,8L,2L,3L,8L,9L,8L,0L,7L,4L,1L,3L,5L,2L,0L,6L,5L,0L,8L,2L,9L,2L,6L,3L,6L,0L,2L,0L,1L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198919Inst : IEnumerable<long>
{
public static readonly long[] Value=A198919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198919.Bytes);
public long this[int i]=>Value[i];

public static A198919Inst Instance=new A198919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198920
{
public static readonly long[] Value={ 9L,8L,1L,1L,2L,6L,2L,8L,6L,1L,2L,9L,8L,8L,1L,3L,0L,3L,9L,4L,1L,3L,7L,9L,5L,4L,3L,1L,7L,8L,2L,7L,7L,3L,1L,0L,6L,2L,2L,6L,8L,7L,1L,6L,2L,7L,1L,7L,8L,0L,4L,4L,2L,6L,3L,3L,5L,4L,2L,8L,3L,6L,0L,4L,5L,5L,9L,0L,1L,5L,3L,7L,3L,9L,7L,2L,6L,3L,7L,3L,9L,1L,1L,0L,1L,7L,7L,4L,8L,3L,5L,6L,9L,0L,3L,7L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198920Inst : IEnumerable<long>
{
public static readonly long[] Value=A198920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198920.Bytes);
public long this[int i]=>Value[i];

public static A198920Inst Instance=new A198920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198921
{
public static readonly long[] Value={ 7L,9L,6L,1L,6L,7L,2L,6L,3L,0L,8L,3L,4L,1L,6L,0L,4L,4L,9L,9L,6L,7L,0L,6L,2L,1L,3L,3L,3L,2L,0L,5L,7L,0L,1L,3L,8L,1L,2L,9L,7L,9L,7L,9L,3L,2L,6L,4L,2L,0L,0L,9L,3L,5L,1L,5L,6L,3L,6L,4L,4L,5L,2L,9L,7L,4L,3L,1L,1L,7L,2L,2L,3L,6L,9L,0L,7L,6L,4L,0L,1L,5L,3L,9L,9L,3L,5L,9L,6L,2L,4L,3L,0L,4L,8L,0L,8L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198921Inst : IEnumerable<long>
{
public static readonly long[] Value=A198921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198921.Bytes);
public long this[int i]=>Value[i];

public static A198921Inst Instance=new A198921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198922
{
public static readonly long[] Value={ 7L,5L,8L,4L,8L,1L,2L,6L,0L,3L,1L,2L,6L,5L,2L,8L,0L,0L,6L,1L,1L,7L,4L,7L,6L,5L,6L,4L,9L,3L,5L,6L,8L,6L,3L,6L,5L,8L,2L,3L,7L,2L,7L,5L,7L,7L,0L,9L,7L,3L,2L,9L,7L,9L,6L,6L,8L,5L,5L,9L,4L,5L,1L,9L,3L,8L,1L,2L,9L,9L,4L,6L,4L,0L,8L,5L,4L,7L,4L,0L,9L,3L,4L,6L,7L,0L,0L,5L,9L,4L,5L,4L,9L,1L,1L,4L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198922Inst : IEnumerable<long>
{
public static readonly long[] Value=A198922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198922.Bytes);
public long this[int i]=>Value[i];

public static A198922Inst Instance=new A198922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198923
{
public static readonly long[] Value={ 5L,3L,3L,6L,2L,7L,2L,8L,4L,4L,2L,5L,2L,3L,2L,7L,8L,7L,5L,6L,0L,5L,6L,7L,8L,6L,5L,9L,9L,4L,0L,3L,5L,8L,8L,3L,9L,2L,4L,2L,9L,7L,4L,2L,6L,9L,6L,0L,6L,6L,7L,0L,8L,2L,5L,0L,7L,3L,1L,4L,5L,3L,3L,5L,0L,5L,3L,8L,6L,0L,3L,6L,5L,0L,7L,0L,6L,9L,5L,1L,3L,9L,4L,0L,2L,1L,9L,3L,8L,4L,8L,1L,7L,0L,0L,6L,6L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198923Inst : IEnumerable<long>
{
public static readonly long[] Value=A198923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198923.Bytes);
public long this[int i]=>Value[i];

public static A198923Inst Instance=new A198923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198924
{
public static readonly long[] Value={ 9L,3L,0L,4L,9L,0L,9L,7L,0L,4L,9L,3L,6L,2L,2L,7L,5L,6L,5L,8L,4L,6L,2L,8L,0L,6L,6L,9L,7L,0L,8L,3L,4L,7L,9L,9L,3L,6L,4L,1L,0L,7L,6L,1L,2L,0L,0L,7L,9L,8L,2L,3L,2L,4L,7L,5L,4L,8L,1L,4L,7L,9L,5L,6L,8L,2L,9L,0L,7L,5L,3L,3L,3L,4L,4L,0L,2L,8L,9L,4L,2L,2L,6L,5L,7L,9L,9L,6L,0L,1L,3L,3L,1L,5L,0L,0L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198924Inst : IEnumerable<long>
{
public static readonly long[] Value=A198924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198924.Bytes);
public long this[int i]=>Value[i];

public static A198924Inst Instance=new A198924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198925
{
public static readonly long[] Value={ 1L,0L,7L,6L,2L,0L,7L,7L,7L,8L,3L,5L,4L,6L,7L,6L,6L,6L,6L,1L,8L,6L,2L,2L,7L,8L,7L,9L,7L,0L,8L,3L,4L,9L,7L,7L,8L,3L,1L,6L,7L,0L,0L,6L,3L,7L,3L,7L,5L,7L,4L,9L,8L,2L,0L,2L,1L,6L,4L,2L,8L,3L,4L,2L,1L,8L,3L,6L,6L,1L,7L,4L,1L,7L,9L,6L,9L,6L,4L,1L,7L,2L,8L,1L,0L,4L,8L,1L,6L,0L,2L,5L,9L,9L,2L,8L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198925Inst : IEnumerable<long>
{
public static readonly long[] Value=A198925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198925.Bytes);
public long this[int i]=>Value[i];

public static A198925Inst Instance=new A198925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198926
{
public static readonly long[] Value={ 1L,2L,0L,5L,1L,9L,8L,1L,8L,1L,7L,7L,5L,4L,6L,5L,2L,5L,7L,6L,8L,6L,1L,0L,3L,9L,7L,5L,4L,9L,5L,2L,8L,2L,7L,6L,5L,0L,4L,3L,3L,1L,4L,1L,5L,9L,2L,2L,6L,4L,2L,8L,1L,2L,4L,9L,8L,7L,7L,2L,4L,5L,2L,0L,9L,9L,6L,1L,1L,6L,4L,4L,4L,5L,0L,5L,4L,7L,3L,6L,0L,3L,5L,7L,4L,7L,0L,7L,5L,5L,3L,0L,2L,7L,7L,1L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198926Inst : IEnumerable<long>
{
public static readonly long[] Value=A198926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198926.Bytes);
public long this[int i]=>Value[i];

public static A198926Inst Instance=new A198926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198927
{
public static readonly long[] Value={ 5L,0L,1L,3L,0L,3L,0L,3L,9L,7L,5L,5L,1L,2L,4L,8L,7L,8L,3L,2L,2L,1L,2L,0L,7L,9L,5L,6L,8L,8L,6L,4L,7L,6L,4L,7L,1L,8L,1L,5L,9L,5L,8L,3L,7L,2L,0L,8L,9L,4L,4L,4L,7L,1L,0L,6L,1L,5L,0L,7L,4L,8L,8L,4L,3L,4L,5L,3L,7L,5L,0L,0L,9L,6L,2L,1L,3L,8L,0L,2L,2L,3L,2L,6L,9L,5L,7L,9L,3L,6L,6L,9L,0L,3L,1L,7L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198927Inst : IEnumerable<long>
{
public static readonly long[] Value=A198927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198927.Bytes);
public long this[int i]=>Value[i];

public static A198927Inst Instance=new A198927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198928
{
public static readonly long[] Value={ 8L,7L,2L,8L,0L,4L,1L,7L,8L,2L,0L,3L,9L,0L,8L,2L,7L,1L,7L,4L,8L,5L,4L,3L,3L,8L,9L,3L,2L,0L,5L,1L,4L,8L,9L,2L,1L,9L,5L,2L,4L,4L,8L,5L,3L,4L,1L,4L,2L,0L,7L,4L,5L,6L,5L,0L,7L,9L,0L,9L,4L,4L,8L,8L,9L,6L,8L,3L,7L,1L,8L,9L,4L,9L,3L,9L,0L,6L,6L,3L,0L,8L,2L,2L,0L,8L,0L,7L,0L,6L,2L,7L,8L,3L,1L,3L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198928Inst : IEnumerable<long>
{
public static readonly long[] Value=A198928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198928.Bytes);
public long this[int i]=>Value[i];

public static A198928Inst Instance=new A198928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198929
{
public static readonly long[] Value={ 1L,0L,1L,0L,4L,4L,1L,1L,7L,9L,2L,2L,4L,6L,6L,5L,0L,3L,7L,2L,5L,6L,9L,3L,1L,5L,7L,6L,9L,6L,7L,0L,3L,0L,6L,6L,3L,1L,3L,4L,4L,6L,5L,0L,7L,4L,7L,5L,7L,1L,8L,0L,0L,1L,2L,8L,9L,5L,5L,5L,2L,7L,2L,7L,0L,8L,4L,4L,5L,2L,8L,6L,9L,1L,1L,6L,7L,3L,4L,5L,3L,0L,5L,2L,5L,4L,6L,1L,0L,4L,1L,1L,5L,2L,9L,5L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198929Inst : IEnumerable<long>
{
public static readonly long[] Value=A198929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198929.Bytes);
public long this[int i]=>Value[i];

public static A198929Inst Instance=new A198929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198930
{
public static readonly long[] Value={ 1L,1L,3L,2L,6L,3L,0L,8L,4L,9L,4L,8L,2L,7L,8L,0L,7L,0L,8L,0L,8L,7L,8L,0L,0L,6L,5L,1L,5L,7L,2L,8L,7L,7L,8L,9L,8L,9L,6L,0L,2L,6L,5L,9L,4L,4L,7L,7L,7L,6L,8L,1L,5L,6L,9L,7L,7L,2L,0L,5L,3L,7L,5L,7L,1L,5L,4L,8L,1L,8L,2L,3L,7L,8L,8L,7L,6L,0L,3L,2L,9L,6L,9L,3L,2L,9L,4L,5L,5L,2L,3L,4L,1L,5L,2L,6L,4L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198930Inst : IEnumerable<long>
{
public static readonly long[] Value=A198930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198930.Bytes);
public long this[int i]=>Value[i];

public static A198930Inst Instance=new A198930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198931
{
public static readonly long[] Value={ 1L,2L,4L,3L,9L,3L,7L,2L,8L,5L,3L,9L,7L,2L,3L,6L,5L,5L,2L,7L,3L,1L,0L,1L,5L,8L,7L,7L,5L,2L,0L,5L,7L,2L,2L,0L,1L,5L,4L,5L,8L,8L,8L,2L,7L,1L,2L,2L,5L,1L,0L,8L,3L,3L,3L,5L,6L,6L,5L,6L,5L,3L,1L,9L,9L,4L,7L,9L,7L,5L,1L,7L,2L,1L,9L,0L,1L,6L,1L,7L,1L,3L,5L,2L,5L,3L,5L,1L,5L,1L,8L,7L,1L,6L,7L,1L,4L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198931Inst : IEnumerable<long>
{
public static readonly long[] Value=A198931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198931.Bytes);
public long this[int i]=>Value[i];

public static A198931Inst Instance=new A198931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198932
{
public static readonly long[] Value={ 6L,7L,0L,8L,0L,9L,5L,0L,1L,1L,9L,2L,0L,7L,4L,3L,9L,7L,2L,6L,1L,1L,5L,6L,3L,7L,8L,3L,9L,2L,4L,7L,4L,2L,2L,6L,0L,1L,5L,6L,7L,0L,7L,0L,9L,9L,2L,3L,1L,1L,4L,7L,2L,2L,8L,9L,5L,4L,0L,4L,7L,7L,1L,7L,3L,0L,2L,1L,0L,1L,9L,9L,4L,4L,4L,0L,3L,2L,3L,8L,9L,5L,7L,8L,1L,1L,3L,7L,6L,7L,8L,7L,6L,8L,5L,9L,5L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198932Inst : IEnumerable<long>
{
public static readonly long[] Value=A198932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198932.Bytes);
public long this[int i]=>Value[i];

public static A198932Inst Instance=new A198932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198933
{
public static readonly long[] Value={ 9L,5L,4L,6L,0L,2L,7L,1L,9L,1L,5L,4L,7L,3L,6L,2L,1L,4L,3L,9L,9L,6L,8L,0L,8L,2L,2L,6L,2L,5L,4L,8L,6L,4L,8L,0L,8L,5L,9L,8L,3L,5L,4L,0L,7L,5L,7L,1L,8L,6L,7L,0L,1L,5L,1L,2L,4L,4L,6L,7L,8L,7L,0L,5L,0L,5L,4L,0L,3L,8L,4L,8L,3L,7L,2L,8L,9L,4L,1L,7L,9L,6L,0L,9L,3L,4L,0L,5L,7L,2L,8L,9L,0L,1L,3L,1L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198933Inst : IEnumerable<long>
{
public static readonly long[] Value=A198933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198933.Bytes);
public long this[int i]=>Value[i];

public static A198933Inst Instance=new A198933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198934
{
public static readonly long[] Value={ 1L,0L,7L,0L,6L,2L,6L,5L,4L,4L,0L,2L,0L,8L,2L,7L,3L,2L,3L,0L,9L,3L,1L,1L,9L,2L,9L,2L,3L,6L,5L,1L,7L,1L,9L,8L,1L,4L,6L,0L,6L,5L,6L,1L,7L,4L,5L,2L,7L,8L,3L,7L,7L,1L,8L,4L,2L,6L,4L,1L,4L,2L,8L,0L,1L,2L,1L,4L,8L,2L,5L,9L,9L,5L,7L,1L,3L,1L,6L,1L,2L,0L,8L,2L,1L,3L,3L,6L,7L,9L,5L,6L,5L,5L,5L,1L,6L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198934Inst : IEnumerable<long>
{
public static readonly long[] Value=A198934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198934.Bytes);
public long this[int i]=>Value[i];

public static A198934Inst Instance=new A198934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198935
{
public static readonly long[] Value={ 1L,2L,7L,4L,7L,7L,4L,6L,9L,7L,2L,9L,2L,4L,4L,9L,5L,6L,0L,6L,0L,1L,9L,2L,6L,0L,6L,4L,0L,1L,0L,6L,3L,8L,0L,9L,7L,0L,8L,4L,7L,1L,2L,6L,1L,6L,5L,2L,3L,7L,3L,0L,0L,4L,2L,0L,3L,1L,6L,6L,5L,7L,2L,3L,0L,1L,3L,9L,6L,5L,5L,5L,3L,5L,4L,7L,1L,7L,7L,6L,2L,3L,7L,4L,4L,4L,0L,2L,0L,1L,6L,2L,9L,8L,1L,7L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198935Inst : IEnumerable<long>
{
public static readonly long[] Value=A198935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198935.Bytes);
public long this[int i]=>Value[i];

public static A198935Inst Instance=new A198935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198936
{
public static readonly long[] Value={ 4L,4L,8L,7L,1L,1L,7L,7L,1L,1L,5L,9L,0L,9L,8L,4L,8L,0L,9L,4L,3L,9L,4L,0L,7L,6L,3L,7L,1L,9L,7L,1L,0L,6L,0L,5L,0L,1L,7L,4L,5L,0L,0L,1L,7L,4L,3L,9L,1L,1L,4L,1L,8L,3L,0L,2L,5L,7L,4L,1L,9L,0L,2L,3L,0L,0L,4L,1L,5L,4L,6L,2L,9L,4L,7L,7L,8L,0L,1L,0L,6L,5L,1L,4L,1L,4L,0L,5L,8L,2L,6L,0L,3L,3L,8L,4L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198936Inst : IEnumerable<long>
{
public static readonly long[] Value=A198936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198936.Bytes);
public long this[int i]=>Value[i];

public static A198936Inst Instance=new A198936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198937
{
public static readonly long[] Value={ 6L,3L,6L,7L,1L,4L,1L,7L,4L,1L,0L,4L,2L,3L,6L,7L,1L,3L,8L,6L,4L,2L,0L,9L,0L,7L,1L,7L,5L,8L,4L,5L,2L,8L,7L,9L,7L,3L,2L,4L,8L,8L,3L,8L,5L,7L,7L,4L,3L,7L,3L,2L,8L,8L,6L,1L,3L,6L,7L,7L,7L,3L,5L,7L,4L,8L,1L,0L,5L,8L,0L,0L,4L,1L,7L,2L,0L,1L,7L,4L,8L,6L,5L,1L,7L,1L,9L,7L,2L,6L,5L,6L,7L,5L,6L,4L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198937Inst : IEnumerable<long>
{
public static readonly long[] Value=A198937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198937.Bytes);
public long this[int i]=>Value[i];

public static A198937Inst Instance=new A198937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198938
{
public static readonly long[] Value={ 7L,8L,2L,4L,5L,9L,2L,4L,5L,5L,5L,0L,8L,7L,9L,2L,6L,8L,1L,0L,9L,7L,7L,1L,9L,5L,1L,8L,5L,3L,5L,3L,5L,5L,0L,2L,6L,1L,2L,0L,3L,7L,2L,3L,0L,1L,5L,1L,9L,8L,4L,4L,3L,3L,3L,4L,0L,4L,7L,0L,2L,6L,7L,3L,4L,0L,5L,3L,9L,2L,2L,4L,0L,9L,2L,1L,5L,3L,6L,8L,4L,5L,8L,6L,8L,6L,5L,7L,9L,7L,8L,8L,5L,8L,3L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198938Inst : IEnumerable<long>
{
public static readonly long[] Value=A198938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198938.Bytes);
public long this[int i]=>Value[i];

public static A198938Inst Instance=new A198938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198939
{
public static readonly long[] Value={ 1L,0L,1L,7L,0L,8L,5L,5L,0L,3L,3L,7L,4L,3L,8L,3L,1L,3L,0L,7L,2L,2L,0L,7L,2L,0L,1L,6L,7L,7L,1L,6L,2L,6L,0L,8L,9L,5L,6L,6L,4L,6L,1L,3L,4L,2L,9L,6L,5L,5L,5L,0L,5L,7L,5L,6L,2L,2L,6L,6L,3L,8L,0L,6L,9L,1L,6L,6L,6L,5L,9L,1L,8L,6L,4L,6L,7L,0L,0L,4L,5L,6L,7L,6L,5L,0L,5L,7L,9L,3L,4L,2L,2L,8L,1L,5L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198939Inst : IEnumerable<long>
{
public static readonly long[] Value=A198939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198939.Bytes);
public long this[int i]=>Value[i];

public static A198939Inst Instance=new A198939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198940
{
public static readonly long[] Value={ 1L,1L,1L,8L,0L,1L,5L,0L,5L,0L,8L,3L,7L,0L,2L,0L,2L,5L,5L,8L,4L,4L,1L,3L,1L,2L,6L,5L,4L,8L,7L,6L,4L,2L,4L,2L,6L,6L,3L,7L,0L,5L,5L,7L,7L,4L,1L,4L,0L,7L,6L,6L,1L,6L,7L,8L,2L,5L,7L,9L,9L,4L,8L,9L,0L,5L,0L,3L,6L,2L,0L,5L,1L,4L,4L,7L,3L,6L,1L,1L,9L,7L,0L,5L,8L,9L,4L,1L,0L,3L,1L,3L,1L,8L,3L,9L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198940Inst : IEnumerable<long>
{
public static readonly long[] Value=A198940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198940.Bytes);
public long this[int i]=>Value[i];

public static A198940Inst Instance=new A198940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198941
{
public static readonly long[] Value={ 1L,2L,1L,1L,7L,9L,6L,4L,7L,4L,6L,7L,1L,9L,7L,7L,5L,7L,7L,4L,8L,1L,4L,0L,7L,2L,1L,2L,9L,1L,6L,5L,4L,8L,0L,2L,2L,5L,0L,0L,2L,8L,1L,2L,7L,0L,2L,6L,0L,6L,1L,4L,0L,2L,2L,3L,6L,4L,0L,4L,3L,2L,6L,7L,3L,4L,7L,8L,2L,4L,5L,1L,0L,0L,7L,9L,1L,2L,0L,8L,9L,9L,5L,0L,6L,2L,7L,1L,8L,9L,8L,4L,2L,2L,7L,4L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198941Inst : IEnumerable<long>
{
public static readonly long[] Value=A198941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198941.Bytes);
public long this[int i]=>Value[i];

public static A198941Inst Instance=new A198941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198942
{
public static readonly long[] Value={ 1L,2L,9L,9L,9L,9L,9L,5L,9L,7L,9L,5L,7L,0L,4L,0L,5L,3L,4L,1L,8L,4L,7L,9L,3L,2L,7L,7L,0L,5L,9L,1L,7L,9L,1L,3L,9L,9L,9L,5L,9L,1L,1L,1L,1L,6L,4L,7L,4L,6L,2L,0L,5L,3L,2L,4L,6L,1L,4L,4L,2L,4L,5L,8L,5L,4L,4L,9L,6L,1L,0L,1L,7L,0L,1L,8L,0L,1L,7L,0L,0L,3L,6L,1L,9L,0L,2L,9L,6L,6L,7L,6L,6L,7L,3L,9L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198942Inst : IEnumerable<long>
{
public static readonly long[] Value=A198942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198942.Bytes);
public long this[int i]=>Value[i];

public static A198942Inst Instance=new A198942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198943
{
public static readonly long[] Value={ 1L,9L,41L,79L,351L,1559L,3001L,13329L,59201L,113959L,506151L,2248079L,4327441L,19220409L,85367801L,164328799L,729869391L,3241728359L,6240166921L,27715816449L,123100309841L,236962014199L,1052471155671L,4674570045599L,8998316372641L,39966188099049L,177510561422921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198943Inst : IEnumerable<long>
{
public static readonly long[] Value=A198943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198943.Bytes);
public long this[int i]=>Value[i];

public static A198943Inst Instance=new A198943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198944
{
public static readonly long[] Value={ 1L,1L,2L,7L,23L,78L,291L,1126L,4436L,17910L,73773L,308188L,1303402L,5573133L,24050795L,104620985L,458324429L,2020417339L,8956142180L,39899217350L,178549985024L,802275736073L,3618237414959L,16373514195570L,74325340129430L,338356926399193L,1544406450870590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198944Inst : IEnumerable<long>
{
public static readonly long[] Value=A198944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198944.Bytes);
public long this[int i]=>Value[i];

public static A198944Inst Instance=new A198944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198945
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,19L,114L,1213L,30838L,2121309L,276352623L,57301231426L,23565649037533L,26695112293671042L,BigInteger.Parse("64176655598885762420"),BigInteger.Parse("241858766657669843853891"),BigInteger.Parse("1532114965167989470245178816"),BigInteger.Parse("24647864257364414796375879195305"),BigInteger.Parse("1038222828395065545608332107235286628") };
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
public class A198945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198945Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198945.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198945Inst Instance=new A198945Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198946
{
public static readonly BigInteger[] Value={ 1L,2L,7L,43L,661L,45503L,14835966L,19030289368L,96523753164218L,1826134533496656481L,BigInteger.Parse("136782939777235335759015"),BigInteger.Parse("38134547664565961218637677016"),BigInteger.Parse("42464787999263932204904982967955033"),BigInteger.Parse("176203582974534986934299369142808689004350") };
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
public class A198946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198946Inst Instance=new A198946Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198947
{
public static readonly long[] Value={ 1L,7L,13L,139L,259L,2773L,5167L,55321L,103081L,1103647L,2056453L,22017619L,41025979L,439248733L,818463127L,8762957041L,16328236561L,174819892087L,325746268093L,3487634884699L,6498597125299L,69577877801893L,129646196237887L,1388069921153161L,2586425327632441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198947Inst : IEnumerable<long>
{
public static readonly long[] Value=A198947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198947.Bytes);
public long this[int i]=>Value[i];

public static A198947Inst Instance=new A198947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198948
{
public static readonly long[] Value={ 1L,-56L,-2296L,-13664L,-73976L,-175056L,-560224L,-941248L,-2367736L,-3320408L,-7177296L,-9018912L,-18050144L,-20792464L,-38591168L,-42713664L,-75768056L,-79512048L,-136136728L,-138661600L,-231248976L,-229664512L,-369775392L,-360435264L,-577727584L,-547050056L,-852491024L,-806859200L,-1243388608L,-1148624400L,-1751260224L,-1603232512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198948Inst : IEnumerable<long>
{
public static readonly long[] Value=A198948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198948.Bytes);
public long this[int i]=>Value[i];

public static A198948Inst Instance=new A198948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198949
{
public static readonly long[] Value={ 1L,23L,43L,461L,859L,9197L,17137L,183479L,341881L,3660383L,6820483L,73024181L,136067779L,1456823237L,2714535097L,29063440559L,54154634161L,579811987943L,1080378148123L,11567176318301L,21553408328299L,230763714378077L,429987788417857L,4603707111243239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198949Inst : IEnumerable<long>
{
public static readonly long[] Value=A198949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198949.Bytes);
public long this[int i]=>Value[i];

public static A198949Inst Instance=new A198949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198950
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,22L,58L,150L,392L,1097L,3139L,9069L,26903L,81299L,248305L,768521L,2407340L,7607947L,24248690L,77906841L,251995121L,820096599L,2684160567L,8830103123L,29183369411L,96865043941L,322780531149L,1079491353973L,3622338207474L,12193038599714L,41161594789286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198950Inst : IEnumerable<long>
{
public static readonly long[] Value=A198950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198950.Bytes);
public long this[int i]=>Value[i];

public static A198950Inst Instance=new A198950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198951
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,16L,39L,99L,271L,763L,2146L,6062L,17359L,50337L,147057L,431874L,1275273L,3786649L,11298031L,33846202L,101762937L,306997821L,929038518L,2819426688L,8578433304L,26163061776L,79970186791L,244938841096L,751646959402L,2310683396056L,7115199919151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198951Inst : IEnumerable<long>
{
public static readonly long[] Value=A198951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198951.Bytes);
public long this[int i]=>Value[i];

public static A198951Inst Instance=new A198951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198952
{
public static readonly BigInteger[] Value={ 1L,1L,3L,45L,3267L,991845L,1155605211L,4910640919821L,73614877173054099L,BigInteger.Parse("3802910817051064124469"),BigInteger.Parse("665332303024345700007225099"),BigInteger.Parse("388955052253927480089824057425437"),BigInteger.Parse("751710022839628223241451188902204177091") };
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
public class A198952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198952Inst Instance=new A198952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198953
{
public static readonly long[] Value={ 1L,2L,9L,56L,400L,3095L,25240L,213633L,1859006L,16527544L,149472480L,1370794835L,12718060947L,119158146283L,1125816405458L,10714275588727L,102615375322564L,988302823695146L,9565859385140272L,93000625498797314L,907782305262566776L,8892941663606408172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198953Inst : IEnumerable<long>
{
public static readonly long[] Value=A198953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198953.Bytes);
public long this[int i]=>Value[i];

public static A198953Inst Instance=new A198953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198954
{
public static readonly long[] Value={ 1L,3L,0L,5L,0L,0L,7L,0L,0L,0L,9L,0L,0L,0L,0L,11L,0L,0L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,15L,0L,0L,0L,0L,0L,0L,0L,17L,0L,0L,0L,0L,0L,0L,0L,0L,19L,0L,0L,0L,0L,0L,0L,0L,0L,0L,21L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,23L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,25L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,27L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198954Inst : IEnumerable<long>
{
public static readonly long[] Value=A198954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198954.Bytes);
public long this[int i]=>Value[i];

public static A198954Inst Instance=new A198954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198955
{
public static readonly long[] Value={ 1L,15L,54L,-76L,-243L,1188L,-1384L,-2916L,11934L,-11580L,-21870L,79704L,-71022L,-123444L,421308L,-352544L,-581013L,1885572L,-1510236L,-2388204L,7469928L,-5777672L,-8852004L,26869968L,-20218587L,-30177684L,89408826L,-65743304L,-96033357L,278737632L,-201031888L,-288281592L,822239532L,-583185916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198955Inst : IEnumerable<long>
{
public static readonly long[] Value=A198955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198955.Bytes);
public long this[int i]=>Value[i];

public static A198955Inst Instance=new A198955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198956
{
public static readonly long[] Value={ 0L,1L,9L,27L,73L,126L,243L,344L,585L,729L,1134L,1332L,1971L,2198L,3096L,3402L,4681L,4914L,6561L,6860L,9198L,9288L,11988L,12168L,15795L,15751L,19782L,19683L,25112L,24390L,30618L,29792L,37449L,35964L,44226L,43344L,53217L,50654L,61740L,59346L,73710L,68922L,83592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198956Inst : IEnumerable<long>
{
public static readonly long[] Value=A198956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198956.Bytes);
public long this[int i]=>Value[i];

public static A198956Inst Instance=new A198956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198957
{
public static readonly long[] Value={ 1L,1L,2L,7L,26L,102L,424L,1827L,8078L,36466L,167376L,778718L,3664164L,17407068L,83375616L,402198915L,1952296598L,9528757098L,46735576816L,230227356906L,1138609205372L,5651170500612L,28138939936704L,140527262919342L,703704207921932L,3532664478314484L,17775185122527776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198957Inst : IEnumerable<long>
{
public static readonly long[] Value=A198957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198957.Bytes);
public long this[int i]=>Value[i];

public static A198957Inst Instance=new A198957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198958
{
public static readonly long[] Value={ 0L,0L,1L,6L,27L,80L,207L,432L,863L,1512L,2646L,4144L,6585L,9504L,14216L,19476L,27783L,36384L,49977L,63504L,84722L,104736L,136188L,165056L,210717L,250560L,314270L,367902L,455544L,525808L,642762L,733968L,888087L,1003608L,1201554L,1347232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198958Inst : IEnumerable<long>
{
public static readonly long[] Value=A198958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198958.Bytes);
public long this[int i]=>Value[i];

public static A198958Inst Instance=new A198958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198959
{
public static readonly BigInteger[] Value={ 2L,3L,7L,46L,2112L,4460539L,19896408170515L,BigInteger.Parse("395867058087736049315365218"),BigInteger.Parse("156710727679038987453730700439845485538142584724187516") };
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
public class A198959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198959Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198959.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198959Inst Instance=new A198959Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198960
{
public static readonly long[] Value={ 2L,26L,242L,2186L,19682L,177146L,1594322L,14348906L,129140162L,1162261466L,10460353202L,94143178826L,847288609442L,7625597484986L,68630377364882L,617673396283946L,5559060566555522L,50031545098999706L,450283905890997362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198960Inst : IEnumerable<long>
{
public static readonly long[] Value=A198960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198960.Bytes);
public long this[int i]=>Value[i];

public static A198960Inst Instance=new A198960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198961
{
public static readonly long[] Value={ 3L,35L,323L,2915L,26243L,236195L,2125763L,19131875L,172186883L,1549681955L,13947137603L,125524238435L,1129718145923L,10167463313315L,91507169819843L,823564528378595L,7412080755407363L,66708726798666275L,600378541187996483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198961Inst : IEnumerable<long>
{
public static readonly long[] Value=A198961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198961.Bytes);
public long this[int i]=>Value[i];

public static A198961Inst Instance=new A198961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198962
{
public static readonly long[] Value={ 4L,44L,404L,3644L,32804L,295244L,2657204L,23914844L,215233604L,1937102444L,17433922004L,156905298044L,1412147682404L,12709329141644L,114383962274804L,1029455660473244L,9265100944259204L,83385908498332844L,750473176484995604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198962Inst : IEnumerable<long>
{
public static readonly long[] Value=A198962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198962.Bytes);
public long this[int i]=>Value[i];

public static A198962Inst Instance=new A198962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198963
{
public static readonly long[] Value={ 5L,53L,485L,4373L,39365L,354293L,3188645L,28697813L,258280325L,2324522933L,20920706405L,188286357653L,1694577218885L,15251194969973L,137260754729765L,1235346792567893L,11118121133111045L,100063090197999413L,900567811781994725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198963Inst : IEnumerable<long>
{
public static readonly long[] Value=A198963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198963.Bytes);
public long this[int i]=>Value[i];

public static A198963Inst Instance=new A198963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198964
{
public static readonly long[] Value={ 3L,31L,283L,2551L,22963L,206671L,1860043L,16740391L,150663523L,1355971711L,12203745403L,109833708631L,988503377683L,8896530399151L,80068773592363L,720618962331271L,6485570660981443L,58370135948832991L,525331223539496923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198964Inst : IEnumerable<long>
{
public static readonly long[] Value=A198964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198964.Bytes);
public long this[int i]=>Value[i];

public static A198964Inst Instance=new A198964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198965
{
public static readonly long[] Value={ 6L,62L,566L,5102L,45926L,413342L,3720086L,33480782L,301327046L,2711943422L,24407490806L,219667417262L,1977006755366L,17793060798302L,160137547184726L,1441237924662542L,12971141321962886L,116740271897665982L,1050662447078993846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198965Inst : IEnumerable<long>
{
public static readonly long[] Value=A198965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198965.Bytes);
public long this[int i]=>Value[i];

public static A198965Inst Instance=new A198965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198966
{
public static readonly long[] Value={ 7L,71L,647L,5831L,52487L,472391L,4251527L,38263751L,344373767L,3099363911L,27894275207L,251048476871L,2259436291847L,20334926626631L,183014339639687L,1647129056757191L,14824161510814727L,133417453597332551L,1200757082375992967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198966Inst : IEnumerable<long>
{
public static readonly long[] Value=A198966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198966.Bytes);
public long this[int i]=>Value[i];

public static A198966Inst Instance=new A198966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198967
{
public static readonly long[] Value={ 9L,89L,809L,7289L,65609L,590489L,5314409L,47829689L,430467209L,3874204889L,34867844009L,313810596089L,2824295364809L,25418658283289L,228767924549609L,2058911320946489L,18530201888518409L,166771816996665689L,1500946352969991209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198967Inst : IEnumerable<long>
{
public static readonly long[] Value=A198967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198967.Bytes);
public long this[int i]=>Value[i];

public static A198967Inst Instance=new A198967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198968
{
public static readonly long[] Value={ 10L,98L,890L,8018L,72170L,649538L,5845850L,52612658L,473513930L,4261625378L,38354628410L,345191655698L,3106724901290L,27960524111618L,251644717004570L,2264802453041138L,20383222077370250L,183448998696332258L,1651040988266990330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198968Inst : IEnumerable<long>
{
public static readonly long[] Value=A198968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198968.Bytes);
public long this[int i]=>Value[i];

public static A198968Inst Instance=new A198968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198969
{
public static readonly long[] Value={ 5L,49L,445L,4009L,36085L,324769L,2922925L,26306329L,236756965L,2130812689L,19177314205L,172595827849L,1553362450645L,13980262055809L,125822358502285L,1132401226520569L,10191611038685125L,91724499348166129L,825520494133495165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198969Inst : IEnumerable<long>
{
public static readonly long[] Value=A198969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198969.Bytes);
public long this[int i]=>Value[i];

public static A198969Inst Instance=new A198969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198970
{
public static readonly long[] Value={ 3L,39L,399L,3999L,39999L,399999L,3999999L,39999999L,399999999L,3999999999L,39999999999L,399999999999L,3999999999999L,39999999999999L,399999999999999L,3999999999999999L,39999999999999999L,399999999999999999L,3999999999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198970Inst : IEnumerable<long>
{
public static readonly long[] Value=A198970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198970.Bytes);
public long this[int i]=>Value[i];

public static A198970Inst Instance=new A198970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198971
{
public static readonly long[] Value={ 4L,49L,499L,4999L,49999L,499999L,4999999L,49999999L,499999999L,4999999999L,49999999999L,499999999999L,4999999999999L,49999999999999L,499999999999999L,4999999999999999L,49999999999999999L,499999999999999999L,4999999999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198971Inst : IEnumerable<long>
{
public static readonly long[] Value=A198971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198971.Bytes);
public long this[int i]=>Value[i];

public static A198971Inst Instance=new A198971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198972
{
public static readonly long[] Value={ 2L,23L,233L,2333L,23333L,233333L,2333333L,23333333L,233333333L,2333333333L,23333333333L,233333333333L,2333333333333L,23333333333333L,233333333333333L,2333333333333333L,23333333333333333L,233333333333333333L,2333333333333333333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198972Inst : IEnumerable<long>
{
public static readonly long[] Value=A198972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198972.Bytes);
public long this[int i]=>Value[i];

public static A198972Inst Instance=new A198972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198973
{
public static readonly long[] Value={ 7L,79L,799L,7999L,79999L,799999L,7999999L,79999999L,799999999L,7999999999L,79999999999L,799999999999L,7999999999999L,79999999999999L,799999999999999L,7999999999999999L,79999999999999999L,799999999999999999L,7999999999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198973Inst : IEnumerable<long>
{
public static readonly long[] Value=A198973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198973.Bytes);
public long this[int i]=>Value[i];

public static A198973Inst Instance=new A198973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198974
{
public static readonly ulong[] Value={ 1L,21L,241L,2661L,29281L,322101L,3543121L,38974341L,428717761L,4715895381L,51874849201L,570623341221L,6276856753441L,69045424287861L,759499667166481L,8354496338831301L,91899459727144321L,1010894056998587541L,11119834626984462961UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198974Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A198974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198974.Bytes);
public ulong this[int i]=>Value[i];

public static A198974Inst Instance=new A198974Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198975
{
public static readonly BigInteger[] Value={ 1L,4L,1835L,53082012L,30525244435834L,BigInteger.Parse("310387893630465965693"),BigInteger.Parse("55676868201599759013090066735") };
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
public class A198975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198975Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198975.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198975Inst Instance=new A198975Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198976
{
public static readonly BigInteger[] Value={ 1L,4L,34L,481L,8731L,174454L,3603244L,75251971L,1577395861L,33105096904L,695065679254L,14595390246661L,306496273473391L,6436373295247354L,135163500079092064L,2838431127851480551L,BigInteger.Parse("59607037068329713321") };
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
public class A198976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198976Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198976.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198976Inst Instance=new A198976Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198977
{
public static readonly BigInteger[] Value={ 2L,34L,1835L,146286L,12662226L,1112962873L,98102456246L,8651794282083L,763087851014929L,67305520316532514L,5936469991284318525L,BigInteger.Parse("523607833526831199696"),BigInteger.Parse("46183202315902474606576"),BigInteger.Parse("4073445973766659727007243") };
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
public class A198977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198977Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198977.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198977Inst Instance=new A198977Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198978
{
public static readonly BigInteger[] Value={ 5L,481L,146286L,53082012L,19622872903L,7267830860056L,2692353648978984L,997397244990907738L,BigInteger.Parse("369492074075459555844"),BigInteger.Parse("136880688981914387733120"),BigInteger.Parse("50708322978926251631508008"),BigInteger.Parse("18785221234054066344117511329") };
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
public class A198978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198978Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198978.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198978Inst Instance=new A198978Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198979
{
public static readonly BigInteger[] Value={ 15L,8731L,12662226L,19622872903L,30525244435834L,47495195899845037L,BigInteger.Parse("73900197917712351603"),BigInteger.Parse("114985169155743145765664"),BigInteger.Parse("178911424288565716160545667"),BigInteger.Parse("278377620790460864731769016202") };
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
public class A198979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198979Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198979.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198979Inst Instance=new A198979Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198980
{
public static readonly BigInteger[] Value={ 52L,174454L,1112962873L,7267830860056L,47495195899845037L,BigInteger.Parse("310387893630465965693"),BigInteger.Parse("2028430770889558380053172"),BigInteger.Parse("13256095277348005849607178346"),BigInteger.Parse("86630544487196927129344081838138") };
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
public class A198980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198980Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198980.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198980Inst Instance=new A198980Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198981
{
public static readonly BigInteger[] Value={ 202L,3603244L,98102456246L,2692353648978984L,BigInteger.Parse("73900197917712351603"),BigInteger.Parse("2028430770889558380053172"),BigInteger.Parse("55676868201599759013090066735"),BigInteger.Parse("1528232414884966866457407229662199") };
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
public class A198981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198981Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198981.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198981Inst Instance=new A198981Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198982
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,5L,34L,34L,5L,15L,481L,1835L,481L,15L,52L,8731L,146286L,146286L,8731L,52L,202L,174454L,12662226L,53082012L,12662226L,174454L,202L,855L,3603244L,1112962873L,19622872903L,19622872903L,1112962873L,3603244L,855L,3845L,75251971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198982Inst : IEnumerable<long>
{
public static readonly long[] Value=A198982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198982.Bytes);
public long this[int i]=>Value[i];

public static A198982Inst Instance=new A198982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198983
{
public static readonly long[] Value={ 7L,5L,3L,4L,3L,4L,9L,3L,9L,2L,5L,8L,6L,6L,6L,2L,5L,2L,6L,7L,6L,9L,5L,1L,9L,9L,5L,8L,3L,1L,5L,6L,3L,3L,0L,0L,4L,9L,9L,5L,8L,8L,7L,4L,9L,7L,1L,2L,5L,9L,0L,8L,3L,5L,1L,2L,8L,2L,4L,8L,1L,9L,9L,0L,3L,5L,7L,3L,3L,5L,3L,5L,3L,3L,9L,7L,4L,7L,2L,4L,9L,5L,5L,8L,0L,7L,3L,5L,8L,2L,5L,3L,2L,1L,5L,9L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198983Inst : IEnumerable<long>
{
public static readonly long[] Value=A198983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198983.Bytes);
public long this[int i]=>Value[i];

public static A198983Inst Instance=new A198983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198984
{
public static readonly long[] Value={ 9L,2L,1L,3L,0L,6L,0L,6L,5L,8L,4L,7L,8L,0L,8L,9L,9L,3L,0L,4L,7L,8L,6L,8L,1L,2L,9L,7L,4L,7L,8L,4L,7L,4L,8L,2L,7L,5L,7L,1L,7L,9L,8L,0L,8L,3L,1L,1L,4L,4L,1L,6L,7L,1L,7L,5L,9L,2L,4L,4L,0L,0L,0L,7L,1L,8L,1L,7L,7L,1L,5L,9L,0L,8L,0L,2L,4L,7L,1L,8L,9L,9L,3L,4L,3L,0L,5L,9L,4L,4L,0L,6L,9L,7L,6L,6L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198984Inst : IEnumerable<long>
{
public static readonly long[] Value=A198984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198984.Bytes);
public long this[int i]=>Value[i];

public static A198984Inst Instance=new A198984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198985
{
public static readonly long[] Value={ 5L,7L,4L,7L,4L,8L,0L,8L,5L,9L,3L,7L,2L,5L,4L,0L,8L,5L,7L,8L,8L,8L,3L,6L,9L,3L,6L,5L,0L,9L,0L,8L,0L,2L,4L,1L,0L,0L,1L,9L,1L,6L,9L,4L,9L,9L,3L,9L,2L,4L,4L,9L,2L,9L,6L,7L,4L,3L,8L,2L,6L,6L,3L,0L,7L,1L,7L,5L,4L,0L,3L,8L,3L,0L,9L,4L,3L,0L,5L,1L,2L,3L,4L,1L,0L,5L,4L,7L,6L,0L,9L,3L,3L,8L,0L,8L,9L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198985Inst : IEnumerable<long>
{
public static readonly long[] Value=A198985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198985.Bytes);
public long this[int i]=>Value[i];

public static A198985Inst Instance=new A198985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198986
{
public static readonly long[] Value={ 6L,2L,6L,4L,1L,9L,2L,4L,4L,3L,8L,2L,3L,3L,8L,2L,3L,8L,2L,8L,4L,6L,0L,4L,5L,1L,5L,4L,3L,9L,7L,2L,5L,1L,1L,8L,6L,0L,0L,3L,3L,3L,2L,8L,8L,8L,3L,2L,6L,8L,4L,1L,3L,0L,5L,5L,6L,8L,1L,9L,0L,2L,6L,2L,2L,5L,1L,8L,5L,6L,9L,6L,6L,0L,6L,7L,4L,4L,0L,1L,2L,8L,9L,1L,8L,1L,0L,1L,0L,8L,0L,7L,3L,1L,7L,9L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198986Inst : IEnumerable<long>
{
public static readonly long[] Value=A198986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198986.Bytes);
public long this[int i]=>Value[i];

public static A198986Inst Instance=new A198986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198987
{
public static readonly long[] Value={ 6L,6L,8L,0L,2L,7L,8L,4L,7L,4L,5L,3L,0L,5L,4L,0L,7L,4L,5L,0L,2L,2L,2L,0L,0L,5L,6L,3L,7L,3L,9L,8L,6L,8L,5L,1L,2L,1L,5L,7L,9L,0L,2L,6L,8L,8L,8L,4L,0L,9L,1L,8L,5L,4L,6L,5L,4L,3L,7L,6L,9L,1L,1L,6L,4L,6L,9L,0L,9L,7L,0L,4L,3L,4L,0L,1L,0L,5L,4L,1L,5L,5L,4L,1L,4L,6L,8L,1L,7L,2L,3L,5L,5L,4L,3L,3L,0L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198987Inst : IEnumerable<long>
{
public static readonly long[] Value=A198987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198987.Bytes);
public long this[int i]=>Value[i];

public static A198987Inst Instance=new A198987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198988
{
public static readonly long[] Value={ 8L,1L,8L,9L,8L,7L,3L,6L,8L,4L,4L,8L,7L,3L,3L,4L,3L,7L,7L,4L,7L,8L,2L,4L,3L,5L,5L,1L,6L,7L,7L,0L,6L,6L,4L,4L,3L,6L,9L,2L,5L,9L,8L,9L,2L,5L,4L,8L,1L,8L,5L,0L,3L,4L,8L,8L,4L,1L,2L,2L,9L,0L,2L,9L,3L,4L,8L,7L,3L,7L,2L,2L,9L,3L,4L,8L,1L,0L,7L,1L,8L,1L,4L,5L,1L,7L,8L,4L,0L,5L,2L,0L,4L,7L,3L,0L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198988Inst : IEnumerable<long>
{
public static readonly long[] Value=A198988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198988.Bytes);
public long this[int i]=>Value[i];

public static A198988Inst Instance=new A198988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198989
{
public static readonly long[] Value={ 9L,4L,6L,6L,2L,8L,5L,1L,6L,7L,6L,8L,7L,8L,1L,1L,7L,4L,9L,2L,2L,2L,5L,4L,2L,2L,9L,6L,4L,8L,4L,8L,7L,2L,4L,7L,0L,4L,1L,1L,9L,9L,9L,4L,8L,3L,6L,3L,0L,0L,8L,7L,7L,5L,0L,0L,2L,2L,0L,5L,3L,5L,4L,6L,6L,5L,3L,1L,1L,5L,9L,3L,3L,3L,6L,2L,9L,5L,6L,7L,3L,7L,3L,6L,0L,4L,1L,7L,4L,0L,0L,0L,7L,0L,0L,3L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198989Inst : IEnumerable<long>
{
public static readonly long[] Value=A198989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198989.Bytes);
public long this[int i]=>Value[i];

public static A198989Inst Instance=new A198989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198990
{
public static readonly long[] Value={ 1L,0L,5L,9L,4L,0L,8L,7L,6L,9L,0L,7L,0L,0L,3L,7L,4L,7L,8L,4L,5L,4L,1L,9L,3L,2L,2L,5L,6L,9L,2L,3L,6L,5L,3L,2L,5L,0L,6L,7L,9L,6L,1L,1L,7L,9L,2L,4L,6L,0L,8L,4L,1L,1L,2L,7L,4L,3L,5L,1L,3L,4L,5L,1L,3L,2L,9L,8L,1L,2L,6L,1L,3L,0L,5L,6L,8L,6L,3L,5L,6L,1L,1L,1L,4L,2L,4L,4L,9L,1L,4L,0L,0L,3L,3L,7L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198990Inst : IEnumerable<long>
{
public static readonly long[] Value=A198990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198990.Bytes);
public long this[int i]=>Value[i];

public static A198990Inst Instance=new A198990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198991
{
public static readonly long[] Value={ 4L,4L,7L,9L,5L,8L,3L,0L,7L,6L,4L,7L,4L,0L,6L,8L,7L,2L,3L,0L,9L,7L,6L,4L,1L,8L,4L,0L,4L,5L,1L,8L,5L,4L,0L,2L,3L,5L,3L,8L,9L,7L,5L,3L,4L,8L,4L,0L,6L,5L,7L,1L,0L,0L,2L,3L,4L,2L,3L,1L,3L,8L,3L,0L,3L,0L,3L,7L,2L,8L,4L,0L,6L,0L,4L,2L,6L,0L,1L,4L,5L,3L,0L,7L,9L,0L,7L,1L,7L,8L,0L,9L,7L,8L,3L,7L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198991Inst : IEnumerable<long>
{
public static readonly long[] Value=A198991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198991.Bytes);
public long this[int i]=>Value[i];

public static A198991Inst Instance=new A198991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198992
{
public static readonly long[] Value={ 7L,7L,8L,4L,5L,8L,8L,9L,9L,8L,1L,9L,6L,9L,4L,6L,8L,0L,4L,5L,3L,2L,2L,4L,8L,6L,5L,8L,4L,0L,5L,8L,9L,2L,7L,5L,2L,6L,5L,8L,4L,1L,2L,6L,2L,9L,3L,0L,8L,3L,3L,6L,3L,2L,4L,3L,8L,4L,7L,7L,2L,4L,6L,9L,3L,1L,6L,6L,9L,5L,8L,7L,3L,4L,2L,6L,8L,8L,6L,8L,5L,4L,3L,2L,6L,5L,8L,1L,0L,9L,2L,5L,4L,0L,4L,6L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198992Inst : IEnumerable<long>
{
public static readonly long[] Value=A198992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198992.Bytes);
public long this[int i]=>Value[i];

public static A198992Inst Instance=new A198992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198993
{
public static readonly long[] Value={ 1L,0L,0L,8L,2L,9L,2L,1L,6L,7L,8L,8L,8L,8L,3L,5L,4L,7L,1L,4L,2L,7L,8L,0L,9L,8L,5L,3L,9L,9L,1L,6L,8L,6L,6L,4L,7L,3L,3L,4L,3L,7L,8L,4L,2L,3L,3L,7L,0L,5L,6L,4L,7L,5L,8L,9L,0L,9L,4L,7L,0L,9L,9L,4L,1L,4L,9L,0L,7L,7L,0L,2L,7L,0L,2L,1L,1L,3L,1L,6L,0L,4L,8L,7L,8L,2L,8L,5L,2L,0L,9L,5L,5L,3L,8L,6L,2L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198993Inst : IEnumerable<long>
{
public static readonly long[] Value=A198993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198993.Bytes);
public long this[int i]=>Value[i];

public static A198993Inst Instance=new A198993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198994
{
public static readonly long[] Value={ 4L,2L,7L,2L,8L,3L,4L,3L,8L,7L,6L,8L,8L,5L,5L,3L,6L,4L,0L,0L,5L,4L,4L,7L,7L,8L,3L,5L,6L,9L,8L,1L,1L,7L,2L,4L,9L,1L,4L,0L,6L,9L,6L,7L,9L,9L,8L,9L,0L,2L,5L,1L,1L,8L,8L,9L,1L,1L,1L,1L,7L,2L,4L,8L,9L,4L,0L,8L,5L,5L,1L,4L,4L,9L,9L,3L,8L,0L,4L,3L,7L,2L,2L,6L,2L,5L,2L,7L,8L,4L,8L,7L,7L,7L,2L,7L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198994Inst : IEnumerable<long>
{
public static readonly long[] Value=A198994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198994.Bytes);
public long this[int i]=>Value[i];

public static A198994Inst Instance=new A198994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198995
{
public static readonly long[] Value={ 6L,0L,5L,5L,2L,0L,1L,2L,3L,4L,6L,2L,2L,5L,3L,5L,2L,3L,9L,5L,8L,2L,9L,0L,7L,0L,5L,9L,6L,5L,7L,4L,3L,8L,9L,7L,5L,7L,3L,8L,4L,9L,3L,0L,3L,7L,7L,2L,4L,0L,4L,8L,2L,8L,2L,3L,8L,4L,3L,5L,8L,5L,6L,0L,8L,2L,1L,2L,9L,4L,8L,5L,0L,1L,1L,2L,2L,2L,9L,1L,5L,6L,2L,8L,0L,1L,5L,4L,5L,6L,7L,2L,6L,8L,4L,0L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198995Inst : IEnumerable<long>
{
public static readonly long[] Value=A198995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198995.Bytes);
public long this[int i]=>Value[i];

public static A198995Inst Instance=new A198995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198996
{
public static readonly long[] Value={ 8L,5L,9L,8L,8L,1L,1L,7L,5L,2L,3L,2L,0L,2L,6L,4L,4L,9L,5L,7L,8L,0L,4L,6L,0L,5L,2L,6L,3L,6L,4L,2L,8L,3L,4L,2L,2L,1L,5L,5L,5L,9L,0L,9L,1L,0L,5L,3L,6L,9L,7L,1L,3L,2L,9L,2L,3L,5L,9L,7L,3L,9L,4L,9L,5L,1L,6L,3L,6L,5L,7L,4L,4L,5L,9L,1L,7L,1L,5L,4L,0L,9L,1L,1L,7L,9L,5L,3L,2L,8L,5L,8L,5L,3L,5L,4L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198996Inst : IEnumerable<long>
{
public static readonly long[] Value=A198996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198996.Bytes);
public long this[int i]=>Value[i];

public static A198996Inst Instance=new A198996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198997
{
public static readonly long[] Value={ 9L,6L,3L,3L,6L,4L,2L,1L,3L,4L,8L,2L,5L,1L,6L,6L,6L,6L,6L,0L,5L,9L,9L,9L,3L,3L,4L,7L,8L,9L,9L,4L,3L,7L,5L,2L,3L,6L,1L,3L,3L,0L,0L,4L,9L,8L,4L,2L,6L,8L,7L,7L,5L,1L,8L,9L,7L,3L,9L,8L,7L,0L,1L,5L,2L,3L,9L,2L,3L,5L,1L,5L,6L,0L,0L,5L,8L,6L,0L,6L,0L,8L,2L,7L,6L,6L,5L,8L,5L,7L,3L,7L,9L,4L,6L,4L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198997Inst : IEnumerable<long>
{
public static readonly long[] Value=A198997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198997.Bytes);
public long this[int i]=>Value[i];

public static A198997Inst Instance=new A198997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198998
{
public static readonly long[] Value={ 1L,0L,5L,7L,4L,9L,3L,6L,1L,7L,2L,6L,8L,8L,4L,0L,3L,6L,5L,4L,9L,7L,9L,5L,2L,6L,8L,3L,6L,5L,8L,5L,6L,1L,5L,0L,5L,1L,5L,1L,1L,3L,0L,6L,7L,1L,6L,3L,0L,5L,2L,1L,0L,9L,2L,9L,3L,1L,8L,6L,1L,8L,5L,3L,1L,3L,7L,0L,6L,0L,5L,2L,6L,4L,5L,7L,5L,2L,6L,6L,7L,2L,9L,8L,1L,4L,2L,7L,7L,0L,6L,8L,7L,0L,3L,8L,1L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198998Inst : IEnumerable<long>
{
public static readonly long[] Value=A198998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198998.Bytes);
public long this[int i]=>Value[i];

public static A198998Inst Instance=new A198998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198999
{
public static readonly long[] Value={ 1L,1L,4L,4L,5L,8L,2L,7L,1L,5L,8L,1L,0L,2L,6L,2L,2L,5L,8L,7L,5L,2L,4L,8L,4L,7L,8L,6L,5L,5L,3L,2L,6L,9L,1L,6L,3L,1L,7L,5L,0L,6L,3L,0L,6L,4L,9L,6L,1L,6L,0L,6L,2L,2L,9L,9L,0L,1L,9L,0L,9L,7L,6L,1L,1L,7L,9L,6L,5L,6L,1L,5L,7L,5L,0L,6L,9L,0L,2L,6L,3L,5L,6L,9L,8L,9L,4L,2L,2L,3L,4L,4L,7L,2L,4L,2L,8L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198999Inst : IEnumerable<long>
{
public static readonly long[] Value=A198999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198999.Bytes);
public long this[int i]=>Value[i];

public static A198999Inst Instance=new A198999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199000
{
public static readonly long[] Value={ 4L,0L,9L,1L,9L,5L,7L,0L,5L,5L,2L,8L,4L,3L,0L,3L,9L,3L,7L,1L,2L,0L,4L,0L,4L,6L,0L,6L,0L,7L,2L,6L,7L,1L,5L,0L,3L,8L,3L,1L,2L,8L,0L,4L,9L,4L,7L,8L,2L,9L,4L,7L,6L,4L,7L,6L,1L,7L,7L,7L,3L,1L,2L,6L,6L,8L,3L,1L,1L,9L,2L,4L,7L,0L,7L,1L,9L,6L,6L,6L,0L,0L,8L,8L,5L,2L,0L,6L,5L,0L,2L,2L,7L,7L,3L,2L,2L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199000Inst : IEnumerable<long>
{
public static readonly long[] Value=A199000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199000.Bytes);
public long this[int i]=>Value[i];

public static A199000Inst Instance=new A199000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199001
{
public static readonly long[] Value={ 7L,1L,2L,0L,5L,4L,2L,4L,6L,3L,1L,4L,6L,4L,9L,9L,4L,1L,7L,2L,1L,2L,6L,8L,9L,9L,4L,5L,6L,1L,0L,4L,2L,6L,0L,4L,9L,6L,5L,7L,7L,1L,0L,1L,1L,5L,1L,6L,9L,5L,8L,0L,7L,3L,8L,3L,0L,0L,9L,8L,8L,9L,4L,8L,7L,9L,5L,0L,0L,2L,4L,2L,0L,8L,9L,7L,4L,7L,7L,6L,1L,4L,2L,7L,9L,1L,7L,4L,3L,9L,5L,6L,5L,0L,5L,9L,6L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199001Inst : IEnumerable<long>
{
public static readonly long[] Value=A199001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199001.Bytes);
public long this[int i]=>Value[i];

public static A199001Inst Instance=new A199001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199002
{
public static readonly long[] Value={ 9L,2L,3L,5L,6L,7L,9L,0L,5L,1L,8L,7L,8L,9L,4L,5L,4L,1L,8L,5L,8L,5L,9L,2L,9L,7L,3L,9L,7L,8L,4L,1L,0L,1L,6L,3L,8L,9L,9L,0L,4L,8L,6L,4L,1L,1L,7L,7L,7L,2L,1L,0L,4L,7L,0L,7L,6L,1L,8L,0L,9L,1L,3L,8L,2L,3L,5L,1L,4L,1L,9L,7L,8L,7L,4L,4L,0L,1L,2L,4L,3L,6L,7L,8L,9L,1L,4L,8L,5L,0L,0L,6L,4L,5L,5L,3L,6L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199002Inst : IEnumerable<long>
{
public static readonly long[] Value=A199002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199002.Bytes);
public long this[int i]=>Value[i];

public static A199002Inst Instance=new A199002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199003
{
public static readonly long[] Value={ 1L,0L,9L,7L,9L,2L,6L,6L,5L,0L,3L,7L,1L,5L,9L,9L,4L,3L,3L,1L,4L,4L,0L,9L,4L,9L,0L,9L,6L,7L,1L,0L,9L,6L,7L,0L,6L,9L,2L,0L,4L,4L,3L,7L,2L,4L,4L,0L,9L,0L,8L,1L,0L,1L,7L,7L,9L,1L,4L,0L,8L,7L,2L,1L,9L,3L,0L,5L,6L,0L,4L,1L,7L,7L,1L,5L,3L,4L,2L,7L,2L,3L,3L,7L,2L,1L,9L,3L,9L,7L,7L,5L,4L,4L,7L,4L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199003Inst : IEnumerable<long>
{
public static readonly long[] Value=A199003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199003.Bytes);
public long this[int i]=>Value[i];

public static A199003Inst Instance=new A199003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199004
{
public static readonly long[] Value={ 1L,2L,7L,8L,9L,35L,49L,55L,75L,76L,82L,84L,115L,124L,133L,140L,144L,153L,167L,172L,177L,200L,201L,202L,203L,211L,213L,232L,235L,237L,240L,243L,245L,252L,256L,262L,276L,281L,285L,297L,305L,319L,322L,325L,331L,349L,352L,353L,374L,377L,379L,380L,399L,407L,415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199004Inst : IEnumerable<long>
{
public static readonly long[] Value=A199004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199004.Bytes);
public long this[int i]=>Value[i];

public static A199004Inst Instance=new A199004Inst();

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