using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A020029
{
public static readonly long[] Value={ 1L,1L,2L,5L,18L,85L,499L,3422L,26889L,238158L,2347553L,25487720L,302211543L,3885576978L,53842995268L,799953072548L,12684970150411L,213832353964067L,3818434892215474L,72004772253206073L,1429809049027949160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020029Inst : IEnumerable<long>
{
public static readonly long[] Value=A020029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020029.Bytes);
public long this[int i]=>Value[i];

public static A020029Inst Instance=new A020029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020028
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,4L,20L,121L,862L,7000L,63876L,646743L,7195013L,87239530L,1145018832L,16173391002L,244622538903L,3944538439806L,67550220781672L,1224347751667801L,23415650750646696L,471239971356764754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020028Inst : IEnumerable<long>
{
public static readonly long[] Value=A020028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020028.Bytes);
public long this[int i]=>Value[i];

public static A020028Inst Instance=new A020028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020027
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,18L,97L,620L,4570L,38270L,358778L,3722325L,42341447L,523975411L,7008171125L,100742459918L,1548915321246L,25363488385399L,440690610696307L,8097689971544645L,156892743198677493L,3196689642673053919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020027Inst : IEnumerable<long>
{
public static readonly long[] Value=A020027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020027.Bytes);
public long this[int i]=>Value[i];

public static A020027Inst Instance=new A020027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020026
{
public static readonly long[] Value={ 1L,1L,1L,3L,10L,45L,251L,1666L,12701L,109544L,1054364L,11202617L,130230419L,1644159040L,22401666926L,327624378798L,5119130918712L,85105551523595L,1499985345603354L,27937227061862467L,548268081089050918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020026Inst : IEnumerable<long>
{
public static readonly long[] Value=A020026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020026.Bytes);
public long this[int i]=>Value[i];

public static A020026Inst Instance=new A020026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020025
{
public static readonly long[] Value={ 1L,1L,2L,5L,18L,89L,523L,3599L,28342L,251532L,2483877L,27012163L,320769441L,4129906549L,57302453361L,852373993744L,13531437150692L,228343001917932L,4081631159283027L,77040788131467135L,1531185664112909315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020025Inst : IEnumerable<long>
{
public static readonly long[] Value=A020025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020025.Bytes);
public long this[int i]=>Value[i];

public static A020025Inst Instance=new A020025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020024
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,3L,17L,104L,740L,6006L,54717L,553254L,6147264L,74450194L,976124761L,13774204959L,208143541601L,3353423725801L,57380805974819L,1039230152655058L,19860842917407766L,399423618672311730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020024Inst : IEnumerable<long>
{
public static readonly long[] Value=A020024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020024.Bytes);
public long this[int i]=>Value[i];

public static A020024Inst Instance=new A020024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020023
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,8L,43L,267L,1927L,15845L,146123L,1493701L,16762640L,204876709L,2708925368L,38526938568L,586465620430L,9513775620310L,163848357905336L,2985681188497227L,57391427290002261L,1160582196308934615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020023Inst : IEnumerable<long>
{
public static readonly long[] Value=A020023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020023.Bytes);
public long this[int i]=>Value[i];

public static A020023Inst Instance=new A020023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020022
{
public static readonly long[] Value={ 1L,0L,1L,2L,5L,24L,131L,843L,6275L,52988L,500442L,5226842L,59818300L,744405515L,10008118595L,144561713037L,2232675345794L,36715105686391L,640474621418148L,11813198572823623L,229701083360459334L,4696111037591613052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020022Inst : IEnumerable<long>
{
public static readonly long[] Value=A020022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020022.Bytes);
public long this[int i]=>Value[i];

public static A020022Inst Instance=new A020022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020021
{
public static readonly long[] Value={ 1L,1L,1L,2L,8L,36L,199L,1303L,9844L,84217L,804738L,8494461L,98158214L,1232430908L,16706285647L,243169268857L,3782633071104L,62623591954943L,1099391947653438L,20399828362013787L,398929976857158503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020021Inst : IEnumerable<long>
{
public static readonly long[] Value=A020021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020021.Bytes);
public long this[int i]=>Value[i];

public static A020021Inst Instance=new A020021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020020
{
public static readonly long[] Value={ 1L,1L,1L,4L,15L,69L,401L,2715L,21115L,185345L,1812263L,19532171L,230045569L,2939471158L,40499380397L,598490843643L,9442855533027L,158430131720783L,2816535675036147L,52888281009012092L,1046012668844905826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020020Inst : IEnumerable<long>
{
public static readonly long[] Value=A020020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020020.Bytes);
public long this[int i]=>Value[i];

public static A020020Inst Instance=new A020020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020019
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,19L,92L,543L,3741L,29513L,262341L,2594262L,28248627L,335844793L,4328666215L,60120364101L,895125421053L,14222548356739L,240203038913808L,4296965473902563L,81164903395937306L,1614279745319197539L,BigInteger.Parse("33720510235556570814") };
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
public class A020019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020019Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A020019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020019.Bytes);
public BigInteger this[int i]=>Value[i];

public static A020019Inst Instance=new A020019Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020018
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,3L,15L,91L,649L,5253L,47802L,482796L,5359036L,64844333L,849460756L,11977396665L,180858689642L,2911824903230L,49792205845229L,901238925798638L,17213663482753993L,345994636003355265L,7300486819670796088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020018Inst : IEnumerable<long>
{
public static readonly long[] Value=A020018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020018.Bytes);
public long this[int i]=>Value[i];

public static A020018Inst Instance=new A020018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020017
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,13L,67L,425L,3103L,25751L,239483L,2466678L,27873456L,342843514L,4559818741L,65205407995L,997642742322L,16261576699844L,281325276907304L,5148252567403659L,99361274550890613L,2017033873383079454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020017Inst : IEnumerable<long>
{
public static readonly long[] Value=A020017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020017.Bytes);
public long this[int i]=>Value[i];

public static A020017Inst Instance=new A020017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020016
{
public static readonly long[] Value={ 1L,1L,1L,3L,12L,56L,318L,2134L,16430L,142945L,1386570L,14836295L,173584650L,2204525052L,30201993206L,443969300123L,6970318011936L,116404310799339L,2060356301148292L,38528662831473069L,759014657780019468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020016Inst : IEnumerable<long>
{
public static readonly long[] Value=A020016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020016.Bytes);
public long this[int i]=>Value[i];

public static A020016Inst Instance=new A020016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020015
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,19L,95L,559L,3858L,30478L,271252L,2685395L,29270806L,348322597L,4493361500L,62457724854L,930620100318L,14796859595058L,250066927156482L,4476197996101023L,84600142126309335L,1683542828313555775L,BigInteger.Parse("35186045111753315688") };
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
public class A020015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020015Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A020015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020015.Bytes);
public BigInteger this[int i]=>Value[i];

public static A020015Inst Instance=new A020015Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020014
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,3L,13L,81L,577L,4665L,42405L,427909L,4745900L,57382240L,751185683L,10584889175L,159735600270L,2570291022522L,43928610203109L,794708493674422L,15171707606511701L,304813398276280545L,6428791672736098775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020014Inst : IEnumerable<long>
{
public static readonly long[] Value=A020014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020014.Bytes);
public long this[int i]=>Value[i];

public static A020014Inst Instance=new A020014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019997
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,10L,17L,25L,88L,102L,108L,148L,194L,205L,548L,640L,746L,2135L,3658L,5689L,12200L,16992L,17460L,38961L,44699L,85493L,138435L,256776L,810597L,932623L,2457564L,2674604L,2890162L,3618191L,3950533L,4103765L,4233447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019997Inst : IEnumerable<long>
{
public static readonly long[] Value=A019997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019997.Bytes);
public long this[int i]=>Value[i];

public static A019997Inst Instance=new A019997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019996
{
public static readonly long[] Value={ 2L,24L,39L,104L,388L,578L,669L,2746L,2819L,3013L,5169L,17398L,19094L,21359L,23116L,24950L,48267L,48487L,105621L,215513L,4706574L,16400064L,106043719L,137338247L,243888200L,478287113L,673135223L,3077440133L,6453969104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019996Inst : IEnumerable<long>
{
public static readonly long[] Value=A019996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019996.Bytes);
public long this[int i]=>Value[i];

public static A019996Inst Instance=new A019996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019995
{
public static readonly long[] Value={ 1L,2L,5L,8L,10L,27L,31L,37L,38L,102L,110L,126L,219L,245L,309L,389L,474L,648L,653L,719L,979L,4642L,8745L,17984L,27374L,33806L,47578L,63375L,155060L,214982L,222936L,774303L,1212989L,1314605L,1914365L,2148329L,4213072L,7179881L,27679209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019995Inst : IEnumerable<long>
{
public static readonly long[] Value=A019995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019995.Bytes);
public long this[int i]=>Value[i];

public static A019995Inst Instance=new A019995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019994
{
public static readonly long[] Value={ 2L,21L,929L,3380L,44668L,45653L,90314L,442076L,1511645L,2108657L,6512625L,59305467L,268601019L,418467213L,680269244L,712120382L,838792718L,1067470406L,1095301586L,53830654373L,62793395990L,137694158842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019994Inst : IEnumerable<long>
{
public static readonly long[] Value=A019994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019994.Bytes);
public long this[int i]=>Value[i];

public static A019994Inst Instance=new A019994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019993
{
public static readonly long[] Value={ 1L,2L,6L,74L,76L,479L,658L,749L,1029L,1722L,3693L,5431L,17081L,26611L,89702L,93902L,132726L,140759L,144429L,154292L,928663L,1178463L,1625140L,2053165L,2690949L,2935639L,3643165L,8402288L,11566624L,11599521L,54349600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019993Inst : IEnumerable<long>
{
public static readonly long[] Value=A019993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019993.Bytes);
public long this[int i]=>Value[i];

public static A019993Inst Instance=new A019993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019992
{
public static readonly long[] Value={ 5L,21L,88L,368L,1538L,6427L,26857L,112229L,468978L,1959746L,8189306L,34221135L,143001871L,597570335L,2497102330L,10434788478L,43604464772L,182212543365L,761422279419L,3181800093939L,13295975323332L,55560674643076L,232174661258332L,970201922073653L,4054239874815929L,16941690784755705L,70795240417122020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019992Inst : IEnumerable<long>
{
public static readonly long[] Value=A019992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019992.Bytes);
public long this[int i]=>Value[i];

public static A019992Inst Instance=new A019992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019991
{
public static readonly long[] Value={ 10L,17L,28L,30L,31L,37L,44L,50L,51L,53L,64L,71L,82L,84L,85L,88L,90L,92L,93L,94L,100L,109L,111L,112L,118L,125L,131L,132L,134L,143L,149L,150L,151L,153L,155L,158L,159L,161L,172L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019991Inst : IEnumerable<long>
{
public static readonly long[] Value=A019991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019991.Bytes);
public long this[int i]=>Value[i];

public static A019991Inst Instance=new A019991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019990
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,11L,12L,13L,19L,21L,22L,25L,27L,29L,32L,33L,34L,36L,38L,39L,40L,46L,55L,57L,58L,61L,63L,65L,66L,67L,73L,75L,76L,79L,81L,83L,86L,87L,89L,95L,96L,97L,99L,101L,102L,103L,106L,108L,110L,113L,114L,115L,117L,119L,120L,121L,127L,136L,138L,139L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019990Inst : IEnumerable<long>
{
public static readonly long[] Value=A019990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019990.Bytes);
public long this[int i]=>Value[i];

public static A019990Inst Instance=new A019990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019989
{
public static readonly long[] Value={ 2L,5L,6L,8L,14L,15L,16L,18L,20L,23L,24L,26L,35L,41L,42L,43L,45L,47L,48L,49L,52L,54L,56L,59L,60L,62L,68L,69L,70L,72L,74L,77L,78L,80L,91L,98L,104L,105L,107L,116L,122L,123L,124L,126L,128L,129L,130L,133L,135L,137L,140L,141L,142L,144L,146L,147L,148L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019989Inst : IEnumerable<long>
{
public static readonly long[] Value=A019989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019989.Bytes);
public long this[int i]=>Value[i];

public static A019989Inst Instance=new A019989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019988
{
public static readonly long[] Value={ 1L,2L,5L,16L,55L,222L,950L,4265L,19591L,91678L,434005L,2073783L,9979772L,48315186L,235088794L,1148891118L,5636168859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019988Inst : IEnumerable<long>
{
public static readonly long[] Value=A019988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019988.Bytes);
public long this[int i]=>Value[i];

public static A019988Inst Instance=new A019988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019987
{
public static readonly long[] Value={ 5L,7L,2L,8L,9L,9L,6L,1L,6L,3L,0L,7L,5L,9L,4L,2L,4L,6L,8L,7L,2L,7L,8L,1L,4L,7L,5L,3L,7L,1L,1L,2L,5L,7L,7L,9L,8L,0L,2L,1L,7L,5L,2L,2L,2L,3L,5L,1L,4L,3L,9L,2L,6L,4L,7L,2L,5L,8L,1L,1L,0L,3L,6L,0L,6L,5L,2L,9L,2L,2L,8L,9L,3L,6L,4L,7L,9L,1L,9L,3L,0L,6L,7L,2L,4L,1L,6L,2L,8L,2L,2L,0L,6L,8L,3L,8L,8L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019987Inst : IEnumerable<long>
{
public static readonly long[] Value=A019987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019987.Bytes);
public long this[int i]=>Value[i];

public static A019987Inst Instance=new A019987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019986
{
public static readonly long[] Value={ 2L,8L,6L,3L,6L,2L,5L,3L,2L,8L,2L,9L,1L,5L,6L,0L,3L,5L,5L,0L,7L,5L,6L,5L,0L,9L,3L,2L,0L,9L,4L,6L,4L,2L,5L,0L,7L,7L,9L,5L,1L,7L,1L,0L,3L,2L,3L,1L,5L,2L,0L,2L,5L,5L,9L,7L,8L,3L,8L,1L,9L,6L,0L,8L,9L,7L,1L,3L,5L,6L,2L,0L,4L,0L,8L,1L,1L,3L,6L,5L,3L,4L,9L,8L,0L,9L,3L,6L,9L,2L,6L,5L,7L,6L,2L,7L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019986Inst : IEnumerable<long>
{
public static readonly long[] Value=A019986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019986.Bytes);
public long this[int i]=>Value[i];

public static A019986Inst Instance=new A019986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019985
{
public static readonly long[] Value={ 1L,9L,0L,8L,1L,1L,3L,6L,6L,8L,7L,7L,2L,8L,2L,1L,1L,0L,6L,3L,4L,0L,6L,7L,4L,8L,7L,3L,4L,3L,6L,5L,3L,4L,9L,3L,0L,8L,2L,5L,0L,9L,6L,1L,2L,1L,8L,1L,1L,1L,2L,6L,5L,8L,3L,9L,0L,9L,5L,9L,7L,4L,6L,9L,8L,2L,9L,2L,6L,5L,7L,5L,6L,0L,8L,8L,8L,0L,7L,3L,0L,6L,8L,9L,9L,9L,7L,1L,2L,4L,1L,7L,5L,6L,6L,2L,8L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019985Inst : IEnumerable<long>
{
public static readonly long[] Value=A019985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019985.Bytes);
public long this[int i]=>Value[i];

public static A019985Inst Instance=new A019985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019984
{
public static readonly long[] Value={ 1L,4L,3L,0L,0L,6L,6L,6L,2L,5L,6L,7L,1L,1L,9L,2L,7L,9L,1L,0L,1L,2L,8L,0L,5L,3L,3L,4L,7L,5L,8L,6L,3L,4L,9L,8L,8L,1L,0L,3L,6L,2L,6L,8L,0L,1L,2L,6L,8L,3L,7L,0L,5L,1L,7L,3L,6L,6L,6L,6L,1L,3L,0L,0L,3L,2L,6L,1L,6L,0L,4L,7L,5L,3L,3L,1L,2L,1L,5L,3L,1L,7L,5L,5L,4L,6L,9L,2L,7L,3L,7L,3L,0L,3L,3L,8L,6L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019984Inst : IEnumerable<long>
{
public static readonly long[] Value=A019984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019984.Bytes);
public long this[int i]=>Value[i];

public static A019984Inst Instance=new A019984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019983
{
public static readonly long[] Value={ 1L,1L,4L,3L,0L,0L,5L,2L,3L,0L,2L,7L,6L,1L,3L,4L,3L,0L,6L,7L,2L,1L,0L,8L,5L,5L,5L,4L,9L,1L,6L,2L,8L,9L,0L,3L,0L,1L,3L,7L,0L,2L,1L,0L,7L,9L,7L,7L,4L,7L,6L,0L,8L,8L,3L,5L,5L,7L,7L,0L,5L,6L,6L,3L,9L,9L,7L,2L,1L,2L,8L,2L,6L,0L,6L,6L,4L,5L,0L,2L,8L,2L,9L,9L,7L,8L,8L,4L,3L,3L,8L,6L,3L,3L,3L,5L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019983Inst : IEnumerable<long>
{
public static readonly long[] Value=A019983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019983.Bytes);
public long this[int i]=>Value[i];

public static A019983Inst Instance=new A019983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019982
{
public static readonly long[] Value={ 9L,5L,1L,4L,3L,6L,4L,4L,5L,4L,2L,2L,2L,5L,8L,4L,9L,2L,9L,6L,8L,3L,9L,7L,1L,4L,5L,4L,9L,4L,5L,6L,8L,2L,4L,6L,6L,6L,4L,8L,7L,6L,8L,1L,4L,5L,1L,5L,0L,6L,5L,9L,2L,2L,7L,3L,1L,1L,2L,6L,4L,8L,9L,1L,4L,6L,9L,8L,1L,0L,6L,9L,9L,9L,9L,7L,1L,6L,7L,4L,9L,4L,2L,7L,3L,5L,4L,2L,3L,1L,2L,1L,7L,3L,9L,3L,7L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019982Inst : IEnumerable<long>
{
public static readonly long[] Value=A019982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019982.Bytes);
public long this[int i]=>Value[i];

public static A019982Inst Instance=new A019982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019981
{
public static readonly long[] Value={ 8L,1L,4L,4L,3L,4L,6L,4L,2L,7L,9L,7L,4L,5L,9L,4L,0L,2L,3L,8L,2L,5L,6L,6L,1L,3L,9L,4L,9L,7L,9L,6L,9L,5L,7L,5L,2L,3L,2L,2L,5L,5L,0L,1L,8L,0L,6L,8L,0L,4L,4L,4L,6L,6L,0L,0L,1L,0L,3L,3L,3L,3L,3L,1L,9L,8L,6L,1L,7L,2L,8L,6L,9L,3L,5L,0L,0L,0L,3L,7L,4L,0L,2L,8L,6L,1L,7L,5L,5L,6L,6L,3L,6L,2L,7L,6L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019981Inst : IEnumerable<long>
{
public static readonly long[] Value=A019981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019981.Bytes);
public long this[int i]=>Value[i];

public static A019981Inst Instance=new A019981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019980
{
public static readonly long[] Value={ 7L,1L,1L,5L,3L,6L,9L,7L,2L,2L,3L,8L,4L,2L,0L,8L,7L,4L,8L,2L,3L,0L,5L,6L,6L,1L,4L,3L,6L,3L,1L,5L,8L,4L,0L,6L,2L,5L,3L,4L,1L,6L,8L,8L,8L,3L,3L,5L,7L,5L,1L,2L,2L,8L,1L,9L,8L,4L,1L,2L,0L,2L,5L,2L,6L,9L,1L,6L,2L,3L,8L,7L,6L,3L,6L,0L,8L,8L,8L,2L,5L,1L,4L,7L,1L,1L,9L,1L,5L,1L,3L,1L,2L,3L,4L,9L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019980Inst : IEnumerable<long>
{
public static readonly long[] Value=A019980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019980.Bytes);
public long this[int i]=>Value[i];

public static A019980Inst Instance=new A019980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019979
{
public static readonly long[] Value={ 6L,3L,1L,3L,7L,5L,1L,5L,1L,4L,6L,7L,5L,0L,4L,3L,0L,9L,8L,9L,7L,9L,4L,6L,4L,2L,4L,4L,7L,6L,8L,1L,8L,6L,0L,5L,9L,4L,4L,7L,3L,2L,0L,5L,0L,3L,1L,4L,9L,3L,1L,8L,1L,5L,1L,3L,1L,0L,0L,5L,3L,4L,9L,5L,7L,8L,5L,3L,8L,4L,2L,1L,4L,1L,3L,2L,8L,9L,5L,8L,1L,7L,8L,6L,9L,0L,0L,8L,1L,3L,0L,0L,4L,5L,8L,8L,7L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019979Inst : IEnumerable<long>
{
public static readonly long[] Value=A019979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019979.Bytes);
public long this[int i]=>Value[i];

public static A019979Inst Instance=new A019979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019978
{
public static readonly long[] Value={ 5L,6L,7L,1L,2L,8L,1L,8L,1L,9L,6L,1L,7L,7L,0L,9L,5L,3L,0L,9L,9L,4L,4L,1L,8L,4L,3L,9L,8L,6L,3L,9L,6L,4L,4L,2L,1L,6L,2L,5L,3L,7L,8L,2L,6L,0L,6L,8L,9L,7L,5L,0L,3L,0L,3L,2L,1L,5L,9L,0L,9L,9L,8L,8L,8L,7L,5L,2L,4L,3L,4L,1L,6L,6L,8L,0L,9L,4L,4L,9L,9L,4L,1L,7L,9L,8L,5L,9L,8L,2L,6L,9L,8L,1L,7L,2L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019978Inst : IEnumerable<long>
{
public static readonly long[] Value=A019978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019978.Bytes);
public long this[int i]=>Value[i];

public static A019978Inst Instance=new A019978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019977
{
public static readonly long[] Value={ 5L,1L,4L,4L,5L,5L,4L,0L,1L,5L,9L,7L,0L,3L,1L,0L,1L,3L,4L,7L,2L,3L,2L,2L,0L,7L,1L,7L,1L,2L,9L,1L,7L,3L,5L,9L,8L,0L,0L,8L,2L,9L,3L,4L,4L,2L,9L,7L,3L,5L,9L,6L,9L,7L,2L,2L,7L,0L,8L,4L,5L,9L,5L,4L,2L,9L,2L,4L,4L,9L,9L,6L,3L,2L,3L,0L,5L,7L,8L,0L,5L,2L,2L,9L,3L,5L,3L,8L,4L,9L,2L,9L,4L,7L,1L,3L,9L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019977Inst : IEnumerable<long>
{
public static readonly long[] Value=A019977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019977.Bytes);
public long this[int i]=>Value[i];

public static A019977Inst Instance=new A019977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019976
{
public static readonly long[] Value={ 4L,7L,0L,4L,6L,3L,0L,1L,0L,9L,4L,7L,8L,4L,5L,4L,2L,3L,3L,5L,8L,6L,2L,3L,4L,5L,3L,7L,4L,0L,2L,9L,0L,0L,2L,7L,5L,6L,9L,9L,2L,6L,0L,7L,4L,7L,8L,0L,2L,4L,8L,6L,1L,7L,2L,2L,1L,6L,3L,0L,1L,6L,6L,1L,6L,4L,3L,0L,1L,4L,3L,9L,4L,5L,9L,3L,2L,7L,6L,5L,3L,8L,7L,3L,7L,8L,0L,2L,4L,0L,3L,7L,4L,9L,5L,8L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019976Inst : IEnumerable<long>
{
public static readonly long[] Value=A019976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019976.Bytes);
public long this[int i]=>Value[i];

public static A019976Inst Instance=new A019976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019975
{
public static readonly long[] Value={ 4L,3L,3L,1L,4L,7L,5L,8L,7L,4L,2L,8L,4L,1L,5L,5L,5L,4L,5L,5L,4L,6L,1L,6L,7L,7L,5L,4L,5L,5L,7L,4L,4L,1L,3L,5L,8L,3L,6L,8L,1L,6L,3L,8L,3L,0L,3L,4L,0L,8L,3L,6L,3L,5L,0L,1L,8L,9L,2L,3L,6L,3L,2L,7L,3L,7L,4L,8L,9L,7L,8L,4L,3L,7L,9L,8L,4L,6L,6L,2L,8L,9L,0L,6L,1L,3L,7L,8L,3L,3L,9L,7L,0L,6L,7L,5L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019975Inst : IEnumerable<long>
{
public static readonly long[] Value=A019975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019975.Bytes);
public long this[int i]=>Value[i];

public static A019975Inst Instance=new A019975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019974
{
public static readonly long[] Value={ 4L,0L,1L,0L,7L,8L,0L,9L,3L,3L,5L,3L,5L,8L,4L,4L,7L,1L,6L,3L,4L,5L,7L,1L,5L,1L,2L,9L,4L,6L,3L,4L,1L,8L,0L,7L,8L,5L,2L,0L,1L,2L,1L,2L,3L,8L,0L,0L,9L,8L,3L,4L,9L,5L,0L,2L,7L,2L,9L,8L,9L,0L,8L,2L,2L,1L,7L,3L,8L,2L,5L,8L,4L,5L,9L,1L,3L,5L,3L,8L,9L,8L,1L,4L,9L,5L,3L,7L,6L,9L,6L,9L,6L,2L,4L,0L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019974Inst : IEnumerable<long>
{
public static readonly long[] Value=A019974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019974.Bytes);
public long this[int i]=>Value[i];

public static A019974Inst Instance=new A019974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019973
{
public static readonly long[] Value={ 3L,7L,3L,2L,0L,5L,0L,8L,0L,7L,5L,6L,8L,8L,7L,7L,2L,9L,3L,5L,2L,7L,4L,4L,6L,3L,4L,1L,5L,0L,5L,8L,7L,2L,3L,6L,6L,9L,4L,2L,8L,0L,5L,2L,5L,3L,8L,1L,0L,3L,8L,0L,6L,2L,8L,0L,5L,5L,8L,0L,6L,9L,7L,9L,4L,5L,1L,9L,3L,3L,0L,1L,6L,9L,0L,8L,8L,0L,0L,0L,3L,7L,0L,8L,1L,1L,4L,6L,1L,8L,6L,7L,5L,7L,2L,4L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019973Inst : IEnumerable<long>
{
public static readonly long[] Value=A019973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019973.Bytes);
public long this[int i]=>Value[i];

public static A019973Inst Instance=new A019973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019972
{
public static readonly long[] Value={ 3L,4L,8L,7L,4L,1L,4L,4L,4L,3L,8L,4L,0L,9L,0L,8L,6L,5L,0L,6L,9L,6L,2L,2L,4L,2L,2L,5L,0L,9L,9L,3L,8L,4L,9L,6L,3L,4L,3L,0L,4L,9L,0L,8L,0L,4L,0L,9L,1L,3L,6L,9L,9L,5L,3L,5L,4L,4L,3L,7L,9L,9L,4L,5L,4L,8L,9L,7L,8L,5L,3L,2L,1L,8L,5L,7L,5L,5L,4L,4L,5L,1L,8L,0L,2L,4L,1L,1L,7L,7L,3L,0L,4L,2L,8L,5L,1L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019972Inst : IEnumerable<long>
{
public static readonly long[] Value=A019972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019972.Bytes);
public long this[int i]=>Value[i];

public static A019972Inst Instance=new A019972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019971
{
public static readonly long[] Value={ 3L,2L,7L,0L,8L,5L,2L,6L,1L,8L,4L,8L,4L,1L,4L,0L,8L,6L,5L,3L,0L,8L,8L,5L,6L,2L,5L,7L,3L,0L,5L,4L,1L,0L,7L,7L,7L,1L,0L,5L,9L,4L,2L,6L,8L,4L,3L,1L,8L,8L,1L,0L,7L,0L,3L,6L,4L,0L,0L,8L,8L,0L,3L,4L,8L,2L,3L,6L,6L,1L,1L,6L,1L,0L,0L,9L,2L,6L,7L,9L,9L,4L,3L,4L,1L,5L,8L,5L,5L,4L,2L,5L,1L,2L,0L,4L,8L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019971Inst : IEnumerable<long>
{
public static readonly long[] Value=A019971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019971.Bytes);
public long this[int i]=>Value[i];

public static A019971Inst Instance=new A019971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019970
{
public static readonly long[] Value={ 3L,0L,7L,7L,6L,8L,3L,5L,3L,7L,1L,7L,5L,2L,5L,3L,4L,0L,2L,5L,7L,0L,2L,9L,0L,5L,7L,6L,0L,3L,6L,9L,0L,9L,8L,2L,4L,0L,0L,6L,7L,0L,2L,1L,4L,3L,5L,3L,7L,7L,9L,2L,4L,2L,7L,0L,3L,9L,1L,5L,6L,2L,5L,0L,3L,7L,4L,8L,6L,3L,2L,8L,8L,4L,9L,5L,0L,9L,0L,9L,1L,8L,4L,5L,4L,5L,9L,3L,7L,2L,1L,6L,6L,7L,1L,0L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019970Inst : IEnumerable<long>
{
public static readonly long[] Value=A019970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019970.Bytes);
public long this[int i]=>Value[i];

public static A019970Inst Instance=new A019970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019969
{
public static readonly long[] Value={ 2L,9L,0L,4L,2L,1L,0L,8L,7L,7L,6L,7L,5L,8L,2L,2L,8L,0L,2L,5L,7L,9L,3L,2L,5L,5L,3L,4L,5L,2L,7L,0L,9L,1L,2L,5L,4L,0L,3L,1L,2L,6L,1L,9L,2L,1L,8L,4L,6L,2L,2L,1L,6L,6L,8L,3L,6L,3L,0L,2L,4L,7L,1L,1L,3L,9L,3L,7L,3L,9L,8L,9L,5L,2L,7L,7L,3L,0L,3L,3L,9L,8L,5L,0L,1L,1L,1L,4L,3L,0L,9L,6L,7L,6L,8L,8L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019969Inst : IEnumerable<long>
{
public static readonly long[] Value=A019969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019969.Bytes);
public long this[int i]=>Value[i];

public static A019969Inst Instance=new A019969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019968
{
public static readonly long[] Value={ 2L,7L,4L,7L,4L,7L,7L,4L,1L,9L,4L,5L,4L,6L,2L,2L,2L,7L,8L,7L,6L,1L,6L,6L,4L,0L,2L,6L,4L,9L,7L,6L,7L,2L,7L,1L,7L,7L,5L,1L,8L,7L,2L,5L,9L,9L,1L,7L,0L,8L,2L,5L,8L,2L,1L,5L,0L,5L,2L,7L,3L,0L,0L,2L,5L,1L,9L,8L,9L,8L,2L,5L,3L,8L,8L,1L,5L,9L,3L,1L,8L,4L,3L,4L,0L,6L,0L,4L,2L,4L,5L,9L,5L,0L,7L,0L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019968Inst : IEnumerable<long>
{
public static readonly long[] Value=A019968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019968.Bytes);
public long this[int i]=>Value[i];

public static A019968Inst Instance=new A019968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019967
{
public static readonly long[] Value={ 2L,6L,0L,5L,0L,8L,9L,0L,6L,4L,6L,9L,3L,8L,0L,1L,5L,3L,6L,2L,5L,8L,4L,1L,2L,3L,3L,6L,4L,3L,3L,5L,4L,1L,1L,8L,6L,0L,9L,3L,2L,8L,7L,2L,6L,7L,9L,4L,3L,1L,9L,5L,0L,2L,3L,7L,5L,2L,0L,1L,0L,9L,6L,8L,0L,0L,2L,4L,1L,4L,2L,6L,5L,5L,8L,1L,3L,9L,1L,6L,6L,6L,1L,4L,4L,8L,1L,8L,6L,7L,5L,8L,4L,0L,6L,0L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019967Inst : IEnumerable<long>
{
public static readonly long[] Value=A019967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019967.Bytes);
public long this[int i]=>Value[i];

public static A019967Inst Instance=new A019967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019966
{
public static readonly long[] Value={ 2L,4L,7L,5L,0L,8L,6L,8L,5L,3L,4L,1L,6L,2L,9L,5L,8L,2L,5L,2L,4L,0L,0L,1L,3L,2L,4L,6L,0L,7L,6L,1L,7L,4L,3L,2L,1L,4L,1L,2L,2L,5L,6L,6L,4L,5L,3L,7L,9L,4L,6L,6L,5L,5L,5L,4L,7L,3L,7L,4L,1L,2L,9L,5L,4L,2L,9L,9L,5L,4L,4L,5L,5L,1L,3L,7L,9L,2L,2L,0L,3L,9L,9L,5L,1L,9L,2L,3L,2L,0L,1L,9L,8L,5L,2L,0L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019966Inst : IEnumerable<long>
{
public static readonly long[] Value=A019966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019966.Bytes);
public long this[int i]=>Value[i];

public static A019966Inst Instance=new A019966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019965
{
public static readonly long[] Value={ 2L,3L,5L,5L,8L,5L,2L,3L,6L,5L,8L,2L,3L,7L,5L,2L,8L,3L,3L,9L,3L,9L,5L,8L,6L,6L,6L,2L,3L,4L,3L,8L,8L,3L,1L,8L,7L,4L,4L,1L,8L,3L,8L,3L,3L,2L,4L,1L,1L,2L,7L,9L,0L,3L,8L,8L,9L,3L,0L,0L,0L,0L,9L,7L,2L,3L,1L,9L,5L,8L,2L,2L,1L,6L,3L,7L,0L,9L,3L,7L,6L,0L,3L,8L,8L,8L,1L,5L,1L,7L,6L,5L,5L,4L,0L,1L,5L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019965Inst : IEnumerable<long>
{
public static readonly long[] Value=A019965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019965.Bytes);
public long this[int i]=>Value[i];

public static A019965Inst Instance=new A019965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019964
{
public static readonly long[] Value={ 2L,2L,4L,6L,0L,3L,6L,7L,7L,3L,9L,0L,4L,2L,1L,6L,0L,5L,4L,1L,6L,3L,3L,2L,1L,4L,3L,8L,4L,1L,6L,4L,0L,9L,1L,5L,9L,1L,4L,0L,3L,6L,3L,1L,0L,1L,0L,2L,6L,8L,9L,7L,0L,8L,1L,4L,1L,0L,4L,2L,8L,3L,5L,4L,8L,4L,5L,3L,3L,1L,9L,8L,5L,8L,3L,8L,7L,9L,3L,4L,1L,3L,2L,3L,6L,0L,7L,8L,6L,9L,4L,7L,7L,6L,1L,9L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019964Inst : IEnumerable<long>
{
public static readonly long[] Value=A019964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019964.Bytes);
public long this[int i]=>Value[i];

public static A019964Inst Instance=new A019964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019963
{
public static readonly long[] Value={ 2L,1L,4L,4L,5L,0L,6L,9L,2L,0L,5L,0L,9L,5L,5L,8L,6L,1L,6L,3L,5L,6L,2L,6L,0L,7L,9L,1L,0L,4L,5L,9L,2L,2L,1L,8L,0L,6L,8L,5L,9L,3L,1L,5L,7L,4L,2L,7L,6L,0L,6L,8L,9L,8L,4L,2L,9L,9L,1L,3L,6L,5L,2L,6L,7L,0L,4L,2L,5L,5L,0L,3L,9L,4L,9L,8L,9L,7L,5L,5L,8L,0L,0L,7L,4L,7L,4L,0L,2L,7L,1L,4L,8L,3L,5L,3L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019963Inst : IEnumerable<long>
{
public static readonly long[] Value=A019963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019963.Bytes);
public long this[int i]=>Value[i];

public static A019963Inst Instance=new A019963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019962
{
public static readonly long[] Value={ 2L,0L,5L,0L,3L,0L,3L,8L,4L,1L,5L,7L,9L,2L,9L,6L,2L,1L,6L,8L,9L,9L,0L,1L,1L,0L,7L,0L,5L,4L,1L,4L,9L,4L,1L,4L,6L,7L,6L,7L,5L,1L,9L,6L,2L,2L,7L,4L,3L,2L,4L,2L,4L,2L,3L,4L,7L,2L,6L,6L,6L,0L,9L,6L,7L,8L,5L,4L,8L,1L,1L,4L,4L,7L,7L,0L,6L,5L,7L,7L,4L,2L,9L,4L,9L,7L,7L,0L,8L,8L,6L,9L,4L,2L,9L,1L,6L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019962Inst : IEnumerable<long>
{
public static readonly long[] Value=A019962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019962.Bytes);
public long this[int i]=>Value[i];

public static A019962Inst Instance=new A019962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019961
{
public static readonly long[] Value={ 1L,9L,6L,2L,6L,1L,0L,5L,0L,5L,5L,0L,5L,1L,5L,0L,5L,8L,2L,3L,0L,4L,6L,4L,0L,4L,2L,6L,2L,1L,1L,8L,9L,4L,9L,8L,5L,0L,5L,6L,7L,1L,0L,7L,5L,2L,5L,7L,6L,7L,3L,4L,1L,8L,7L,0L,2L,0L,9L,6L,3L,5L,7L,2L,7L,5L,6L,2L,7L,0L,3L,1L,7L,4L,8L,3L,4L,8L,7L,9L,8L,7L,8L,3L,4L,9L,9L,1L,9L,3L,0L,5L,9L,4L,9L,2L,2L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019961Inst : IEnumerable<long>
{
public static readonly long[] Value=A019961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019961.Bytes);
public long this[int i]=>Value[i];

public static A019961Inst Instance=new A019961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019960
{
public static readonly long[] Value={ 1L,8L,8L,0L,7L,2L,6L,4L,6L,5L,3L,4L,6L,3L,3L,2L,0L,1L,2L,3L,6L,0L,8L,3L,7L,5L,9L,5L,8L,2L,9L,2L,7L,7L,9L,5L,5L,3L,7L,5L,6L,3L,7L,4L,9L,7L,7L,7L,5L,2L,0L,4L,5L,4L,6L,5L,4L,2L,5L,1L,4L,8L,5L,1L,0L,8L,4L,8L,3L,8L,9L,2L,6L,4L,1L,0L,8L,2L,2L,3L,7L,7L,8L,8L,6L,5L,7L,7L,1L,4L,3L,9L,5L,3L,2L,9L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019960Inst : IEnumerable<long>
{
public static readonly long[] Value=A019960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019960.Bytes);
public long this[int i]=>Value[i];

public static A019960Inst Instance=new A019960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019959
{
public static readonly long[] Value={ 1L,8L,0L,4L,0L,4L,7L,7L,5L,5L,2L,7L,1L,4L,2L,3L,9L,3L,7L,3L,8L,1L,7L,8L,4L,7L,4L,8L,2L,3L,7L,0L,0L,7L,7L,2L,4L,3L,1L,5L,6L,5L,7L,0L,5L,5L,6L,9L,8L,5L,2L,1L,7L,6L,9L,4L,5L,6L,6L,7L,7L,8L,6L,4L,5L,8L,1L,4L,4L,5L,2L,9L,9L,9L,9L,3L,2L,2L,4L,9L,4L,0L,1L,6L,4L,1L,3L,4L,0L,9L,2L,7L,7L,8L,5L,8L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019959Inst : IEnumerable<long>
{
public static readonly long[] Value=A019959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019959.Bytes);
public long this[int i]=>Value[i];

public static A019959Inst Instance=new A019959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019958
{
public static readonly long[] Value={ 1L,22L,329L,4178L,48621L,537222L,5744929L,60136378L,620564021L,6341995022L,64384199529L,650640568578L,6554239839421L,65878458172822L,661143103694129L,6627971208280778L,66395645870074821L,664768758151070622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019958Inst : IEnumerable<long>
{
public static readonly long[] Value=A019958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019958.Bytes);
public long this[int i]=>Value[i];

public static A019958Inst Instance=new A019958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019957
{
public static readonly long[] Value={ 1L,6L,6L,4L,2L,7L,9L,4L,8L,2L,3L,5L,0L,5L,1L,7L,9L,1L,1L,0L,3L,0L,4L,9L,6L,1L,7L,0L,0L,3L,4L,7L,8L,2L,4L,2L,3L,7L,6L,9L,4L,8L,3L,8L,6L,1L,1L,0L,8L,5L,5L,4L,8L,9L,2L,9L,4L,1L,0L,5L,4L,5L,4L,5L,6L,2L,4L,4L,4L,1L,6L,7L,2L,1L,6L,8L,4L,7L,3L,0L,6L,6L,4L,2L,9L,1L,4L,0L,4L,0L,2L,2L,8L,1L,6L,7L,3L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019957Inst : IEnumerable<long>
{
public static readonly long[] Value=A019957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019957.Bytes);
public long this[int i]=>Value[i];

public static A019957Inst Instance=new A019957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019956
{
public static readonly long[] Value={ 1L,6L,0L,0L,3L,3L,4L,5L,2L,9L,0L,4L,1L,0L,5L,0L,3L,5L,5L,3L,2L,6L,7L,3L,3L,0L,8L,1L,1L,8L,3L,3L,5L,7L,5L,2L,5L,5L,0L,4L,0L,7L,1L,8L,4L,6L,9L,2L,2L,7L,5L,9L,1L,4L,8L,4L,1L,1L,5L,0L,0L,2L,2L,9L,7L,2L,3L,8L,4L,5L,7L,2L,8L,1L,6L,6L,0L,3L,8L,1L,2L,6L,2L,0L,8L,2L,7L,9L,1L,4L,9L,6L,2L,4L,0L,4L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019956Inst : IEnumerable<long>
{
public static readonly long[] Value=A019956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019956.Bytes);
public long this[int i]=>Value[i];

public static A019956Inst Instance=new A019956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019955
{
public static readonly long[] Value={ 1L,5L,3L,9L,8L,6L,4L,9L,6L,3L,8L,1L,4L,5L,8L,2L,9L,0L,4L,8L,2L,6L,7L,9L,6L,9L,7L,2L,6L,0L,2L,7L,8L,0L,1L,2L,5L,7L,0L,8L,3L,8L,7L,0L,3L,2L,1L,6L,5L,4L,8L,1L,6L,7L,9L,7L,9L,9L,1L,8L,5L,5L,0L,3L,0L,0L,2L,3L,3L,3L,5L,6L,6L,9L,4L,9L,0L,8L,4L,1L,2L,5L,4L,0L,8L,1L,5L,7L,6L,6L,3L,6L,7L,8L,2L,9L,6L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019955Inst : IEnumerable<long>
{
public static readonly long[] Value=A019955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019955.Bytes);
public long this[int i]=>Value[i];

public static A019955Inst Instance=new A019955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019954
{
public static readonly long[] Value={ 1L,4L,8L,2L,5L,6L,0L,9L,6L,8L,5L,1L,2L,7L,4L,0L,2L,5L,4L,7L,8L,7L,1L,5L,7L,1L,4L,9L,1L,5L,4L,4L,3L,0L,0L,3L,0L,4L,7L,9L,8L,4L,6L,2L,3L,1L,4L,6L,5L,8L,4L,7L,0L,0L,4L,9L,8L,4L,7L,0L,3L,7L,3L,8L,8L,0L,6L,7L,8L,6L,8L,7L,6L,6L,1L,3L,9L,6L,5L,2L,7L,8L,7L,5L,7L,3L,8L,0L,1L,9L,1L,1L,3L,8L,2L,0L,8L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019954Inst : IEnumerable<long>
{
public static readonly long[] Value=A019954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019954.Bytes);
public long this[int i]=>Value[i];

public static A019954Inst Instance=new A019954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019953
{
public static readonly long[] Value={ 1L,4L,2L,8L,1L,4L,8L,0L,0L,6L,7L,4L,2L,1L,1L,4L,5L,0L,2L,1L,6L,0L,6L,1L,8L,4L,8L,4L,9L,9L,8L,5L,0L,0L,7L,3L,9L,6L,3L,3L,8L,0L,1L,6L,1L,2L,0L,7L,5L,3L,1L,9L,0L,9L,7L,6L,1L,1L,7L,9L,4L,1L,2L,7L,2L,8L,1L,6L,9L,5L,5L,1L,7L,5L,2L,7L,9L,8L,8L,5L,3L,2L,9L,3L,7L,3L,0L,2L,5L,6L,4L,1L,2L,5L,3L,4L,0L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019953Inst : IEnumerable<long>
{
public static readonly long[] Value=A019953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019953.Bytes);
public long this[int i]=>Value[i];

public static A019953Inst Instance=new A019953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019952
{
public static readonly long[] Value={ 1L,3L,7L,6L,3L,8L,1L,9L,2L,0L,4L,7L,1L,1L,7L,3L,5L,3L,8L,2L,0L,7L,2L,0L,9L,5L,8L,1L,9L,1L,0L,8L,8L,7L,6L,7L,9L,5L,2L,5L,8L,9L,9L,3L,3L,6L,0L,0L,8L,1L,5L,8L,6L,6L,3L,3L,6L,5L,6L,7L,5L,7L,6L,5L,6L,1L,9L,0L,9L,5L,1L,9L,3L,7L,6L,7L,1L,7L,2L,9L,8L,5L,0L,6L,5L,9L,5L,2L,9L,9L,3L,1L,1L,0L,0L,7L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019952Inst : IEnumerable<long>
{
public static readonly long[] Value=A019952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019952.Bytes);
public long this[int i]=>Value[i];

public static A019952Inst Instance=new A019952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019951
{
public static readonly long[] Value={ 1L,3L,2L,7L,0L,4L,4L,8L,2L,1L,6L,2L,0L,4L,1L,0L,0L,3L,7L,1L,5L,9L,4L,7L,2L,5L,7L,4L,0L,8L,6L,9L,3L,2L,4L,1L,9L,9L,0L,6L,0L,4L,1L,2L,9L,5L,5L,8L,7L,6L,2L,3L,0L,1L,6L,2L,0L,7L,7L,3L,5L,6L,8L,2L,5L,1L,5L,9L,1L,6L,3L,4L,0L,3L,0L,2L,6L,0L,2L,8L,9L,8L,6L,9L,2L,4L,9L,6L,3L,3L,6L,7L,6L,5L,4L,3L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019951Inst : IEnumerable<long>
{
public static readonly long[] Value=A019951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019951.Bytes);
public long this[int i]=>Value[i];

public static A019951Inst Instance=new A019951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019950
{
public static readonly long[] Value={ 1L,2L,7L,9L,9L,4L,1L,6L,3L,2L,1L,9L,3L,0L,7L,8L,7L,8L,0L,3L,1L,1L,0L,2L,9L,8L,4L,7L,5L,7L,1L,9L,9L,1L,1L,9L,2L,1L,2L,3L,1L,5L,1L,8L,8L,5L,2L,7L,0L,4L,5L,9L,3L,8L,0L,7L,0L,0L,2L,9L,1L,0L,9L,6L,1L,4L,0L,4L,2L,2L,0L,1L,5L,7L,8L,2L,3L,3L,6L,3L,3L,9L,2L,8L,5L,8L,4L,2L,0L,4L,3L,8L,9L,2L,4L,4L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019950Inst : IEnumerable<long>
{
public static readonly long[] Value=A019950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019950.Bytes);
public long this[int i]=>Value[i];

public static A019950Inst Instance=new A019950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019949
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,9L,7L,1L,5L,6L,5L,3L,5L,0L,5L,1L,3L,9L,8L,5L,5L,6L,1L,7L,4L,6L,9L,5L,3L,7L,5L,9L,3L,5L,1L,4L,0L,0L,5L,3L,6L,2L,5L,5L,8L,4L,0L,7L,7L,9L,7L,6L,5L,3L,6L,4L,2L,1L,2L,5L,9L,2L,0L,8L,8L,4L,3L,7L,5L,7L,3L,0L,1L,3L,4L,7L,7L,4L,0L,2L,1L,4L,1L,2L,3L,1L,2L,8L,7L,0L,4L,0L,6L,4L,3L,5L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019949Inst : IEnumerable<long>
{
public static readonly long[] Value=A019949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019949.Bytes);
public long this[int i]=>Value[i];

public static A019949Inst Instance=new A019949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019948
{
public static readonly long[] Value={ 1L,1L,9L,1L,7L,5L,3L,5L,9L,2L,5L,9L,4L,2L,0L,9L,9L,5L,8L,7L,0L,5L,3L,0L,8L,0L,7L,1L,8L,6L,0L,4L,1L,9L,3L,3L,6L,9L,3L,0L,7L,0L,0L,4L,0L,7L,7L,0L,8L,5L,4L,3L,8L,5L,3L,6L,5L,4L,8L,3L,0L,0L,0L,6L,9L,0L,3L,4L,1L,2L,1L,4L,5L,8L,9L,0L,5L,5L,1L,7L,7L,2L,7L,5L,8L,1L,0L,9L,3L,9L,4L,2L,7L,3L,7L,7L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019948Inst : IEnumerable<long>
{
public static readonly long[] Value=A019948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019948.Bytes);
public long this[int i]=>Value[i];

public static A019948Inst Instance=new A019948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019947
{
public static readonly long[] Value={ 1L,1L,5L,0L,3L,6L,8L,4L,0L,7L,2L,2L,1L,0L,0L,9L,5L,5L,5L,8L,7L,6L,3L,3L,1L,0L,2L,5L,5L,6L,9L,5L,7L,0L,3L,6L,2L,0L,1L,4L,4L,6L,5L,0L,4L,8L,1L,3L,1L,9L,9L,9L,5L,8L,9L,6L,2L,6L,4L,5L,2L,6L,8L,7L,8L,2L,2L,4L,5L,1L,5L,9L,1L,3L,8L,7L,5L,1L,5L,0L,9L,1L,7L,3L,1L,2L,3L,1L,6L,5L,7L,8L,7L,9L,8L,3L,8L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019947Inst : IEnumerable<long>
{
public static readonly long[] Value=A019947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019947.Bytes);
public long this[int i]=>Value[i];

public static A019947Inst Instance=new A019947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019946
{
public static readonly long[] Value={ 1L,1L,1L,0L,6L,1L,2L,5L,1L,4L,8L,2L,9L,1L,9L,2L,8L,7L,0L,1L,4L,3L,4L,8L,1L,9L,6L,4L,1L,6L,5L,1L,3L,5L,5L,3L,2L,5L,7L,6L,9L,5L,9L,5L,1L,0L,3L,9L,0L,8L,5L,9L,0L,4L,8L,1L,8L,4L,4L,0L,2L,2L,2L,0L,2L,8L,9L,9L,6L,5L,5L,3L,5L,8L,7L,3L,7L,3L,1L,3L,6L,5L,4L,5L,8L,5L,0L,6L,1L,6L,9L,2L,1L,5L,8L,7L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019946Inst : IEnumerable<long>
{
public static readonly long[] Value=A019946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019946.Bytes);
public long this[int i]=>Value[i];

public static A019946Inst Instance=new A019946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019945
{
public static readonly long[] Value={ 1L,0L,7L,2L,3L,6L,8L,7L,1L,0L,0L,2L,4L,6L,8L,2L,5L,3L,2L,9L,4L,6L,0L,2L,7L,7L,4L,8L,0L,7L,2L,5L,5L,0L,1L,6L,6L,2L,8L,9L,3L,9L,7L,7L,9L,1L,4L,3L,1L,3L,8L,4L,6L,5L,3L,9L,9L,2L,8L,8L,4L,2L,5L,3L,8L,1L,0L,4L,2L,7L,3L,4L,8L,7L,1L,7L,3L,3L,6L,4L,2L,8L,7L,2L,7L,9L,0L,6L,0L,8L,1L,3L,2L,3L,0L,6L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019945Inst : IEnumerable<long>
{
public static readonly long[] Value=A019945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019945.Bytes);
public long this[int i]=>Value[i];

public static A019945Inst Instance=new A019945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019944
{
public static readonly long[] Value={ 1L,0L,3L,5L,5L,3L,0L,3L,1L,3L,7L,9L,0L,5L,6L,9L,5L,0L,6L,9L,5L,8L,8L,3L,2L,5L,5L,1L,2L,4L,8L,1L,3L,2L,0L,2L,4L,9L,6L,9L,9L,3L,8L,4L,1L,2L,6L,5L,2L,3L,3L,9L,9L,6L,3L,4L,5L,1L,1L,0L,2L,0L,7L,3L,7L,7L,0L,2L,8L,4L,9L,1L,0L,8L,6L,9L,7L,5L,5L,9L,9L,8L,5L,9L,0L,9L,0L,1L,7L,0L,2L,4L,9L,9L,6L,5L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019944Inst : IEnumerable<long>
{
public static readonly long[] Value=A019944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019944.Bytes);
public long this[int i]=>Value[i];

public static A019944Inst Instance=new A019944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019943
{
public static readonly ulong[] Value={ 1L,21L,298L,3570L,38971L,401751L,3988468L,38583300L,366449941L,3434404281L,31873887838L,293663563830L,2690806228111L,24553315831611L,223338364450408L,2026585451393160L,18355202849805481L,166009125098571741L,1499772036736668178L,13537796780062999290UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019943Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A019943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019943.Bytes);
public ulong this[int i]=>Value[i];

public static A019943Inst Instance=new A019943Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019942
{
public static readonly long[] Value={ 9L,6L,5L,6L,8L,8L,7L,7L,4L,8L,0L,7L,0L,7L,4L,0L,4L,5L,9L,5L,8L,0L,2L,7L,2L,9L,9L,7L,0L,0L,6L,8L,1L,3L,9L,3L,2L,1L,1L,5L,8L,9L,8L,1L,7L,0L,8L,3L,1L,0L,9L,4L,6L,2L,4L,4L,1L,1L,6L,1L,9L,0L,7L,3L,8L,9L,5L,7L,9L,8L,4L,2L,4L,9L,5L,6L,3L,8L,0L,0L,1L,1L,5L,9L,8L,7L,2L,6L,6L,3L,1L,0L,9L,5L,3L,0L,6L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019942Inst : IEnumerable<long>
{
public static readonly long[] Value=A019942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019942.Bytes);
public long this[int i]=>Value[i];

public static A019942Inst Instance=new A019942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019941
{
public static readonly long[] Value={ 9L,3L,2L,5L,1L,5L,0L,8L,6L,1L,3L,7L,6L,6L,1L,7L,0L,5L,6L,1L,2L,1L,8L,5L,6L,2L,7L,4L,2L,6L,1L,8L,6L,6L,5L,4L,3L,5L,3L,5L,3L,7L,2L,9L,9L,4L,9L,4L,0L,2L,3L,4L,3L,4L,5L,9L,6L,1L,3L,9L,2L,5L,8L,0L,5L,3L,7L,1L,3L,3L,4L,7L,5L,3L,6L,5L,8L,3L,0L,8L,3L,5L,1L,8L,8L,1L,7L,3L,8L,7L,7L,4L,9L,3L,2L,5L,1L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019941Inst : IEnumerable<long>
{
public static readonly long[] Value=A019941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019941.Bytes);
public long this[int i]=>Value[i];

public static A019941Inst Instance=new A019941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019940
{
public static readonly long[] Value={ 9L,0L,0L,4L,0L,4L,0L,4L,4L,2L,9L,7L,8L,3L,9L,9L,4L,5L,1L,2L,0L,4L,7L,7L,2L,0L,3L,8L,8L,5L,3L,7L,1L,7L,0L,2L,0L,7L,6L,4L,6L,6L,2L,1L,1L,2L,9L,9L,4L,8L,5L,2L,8L,2L,4L,2L,7L,0L,7L,9L,0L,8L,3L,9L,2L,2L,4L,0L,1L,7L,1L,4L,2L,5L,2L,5L,0L,2L,5L,3L,1L,8L,6L,2L,6L,3L,1L,1L,5L,9L,8L,6L,6L,3L,3L,8L,2L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019940Inst : IEnumerable<long>
{
public static readonly long[] Value=A019940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019940.Bytes);
public long this[int i]=>Value[i];

public static A019940Inst Instance=new A019940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019939
{
public static readonly long[] Value={ 8L,6L,9L,2L,8L,6L,7L,3L,7L,8L,1L,6L,2L,2L,6L,6L,6L,2L,2L,0L,0L,0L,9L,5L,6L,3L,8L,7L,0L,3L,9L,4L,2L,0L,9L,0L,6L,6L,8L,0L,9L,0L,4L,9L,7L,7L,8L,2L,4L,5L,4L,8L,3L,9L,8L,3L,5L,7L,3L,1L,9L,6L,4L,3L,9L,8L,3L,4L,5L,1L,2L,6L,0L,9L,5L,9L,5L,6L,3L,9L,5L,9L,9L,8L,4L,9L,5L,7L,2L,3L,8L,0L,4L,2L,5L,1L,5L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019939Inst : IEnumerable<long>
{
public static readonly long[] Value=A019939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019939.Bytes);
public long this[int i]=>Value[i];

public static A019939Inst Instance=new A019939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019938
{
public static readonly long[] Value={ 8L,3L,9L,0L,9L,9L,6L,3L,1L,1L,7L,7L,2L,8L,0L,0L,1L,1L,7L,6L,3L,1L,2L,7L,2L,9L,8L,1L,2L,3L,1L,8L,1L,3L,6L,4L,6L,8L,7L,4L,3L,4L,2L,8L,3L,0L,1L,2L,3L,4L,6L,5L,3L,3L,2L,4L,4L,1L,0L,2L,0L,3L,9L,2L,3L,2L,5L,1L,8L,3L,2L,8L,0L,5L,5L,0L,3L,4L,5L,2L,1L,7L,6L,0L,8L,0L,6L,7L,2L,4L,1L,1L,3L,1L,2L,8L,8L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019938Inst : IEnumerable<long>
{
public static readonly long[] Value=A019938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019938.Bytes);
public long this[int i]=>Value[i];

public static A019938Inst Instance=new A019938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019937
{
public static readonly long[] Value={ 8L,0L,9L,7L,8L,4L,0L,3L,3L,1L,9L,5L,0L,0L,7L,1L,4L,8L,0L,3L,6L,9L,9L,1L,3L,7L,4L,2L,3L,5L,7L,7L,1L,2L,2L,5L,2L,1L,6L,5L,5L,6L,4L,9L,2L,5L,8L,0L,5L,9L,2L,5L,1L,7L,6L,3L,0L,3L,6L,9L,3L,0L,4L,9L,3L,9L,0L,5L,6L,4L,5L,5L,5L,1L,6L,3L,6L,0L,7L,8L,9L,5L,9L,1L,8L,3L,8L,6L,7L,5L,6L,6L,9L,9L,6L,6L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019937Inst : IEnumerable<long>
{
public static readonly long[] Value=A019937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019937.Bytes);
public long this[int i]=>Value[i];

public static A019937Inst Instance=new A019937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019936
{
public static readonly long[] Value={ 7L,8L,1L,2L,8L,5L,6L,2L,6L,5L,0L,6L,7L,1L,7L,3L,9L,7L,0L,6L,2L,9L,4L,9L,9L,7L,1L,9L,6L,2L,2L,6L,6L,8L,5L,6L,5L,8L,5L,4L,5L,9L,4L,0L,0L,3L,5L,1L,6L,0L,7L,6L,6L,6L,3L,2L,4L,3L,7L,2L,3L,3L,6L,0L,4L,5L,0L,1L,2L,5L,5L,2L,2L,4L,2L,9L,1L,8L,0L,5L,4L,5L,3L,3L,0L,7L,5L,2L,2L,5L,7L,8L,0L,8L,1L,4L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019936Inst : IEnumerable<long>
{
public static readonly long[] Value=A019936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019936.Bytes);
public long this[int i]=>Value[i];

public static A019936Inst Instance=new A019936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019935
{
public static readonly long[] Value={ 7L,5L,3L,5L,5L,4L,0L,5L,0L,1L,0L,2L,7L,9L,4L,1L,5L,7L,0L,7L,3L,9L,5L,6L,4L,4L,8L,6L,2L,1L,5L,9L,2L,5L,9L,5L,0L,6L,1L,3L,4L,7L,0L,7L,5L,0L,9L,5L,9L,1L,9L,7L,0L,2L,7L,6L,4L,9L,7L,6L,7L,1L,0L,4L,3L,1L,7L,2L,8L,6L,0L,9L,2L,5L,1L,6L,4L,6L,4L,9L,9L,9L,2L,0L,7L,8L,9L,3L,8L,9L,1L,7L,5L,9L,0L,4L,6L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019935Inst : IEnumerable<long>
{
public static readonly long[] Value=A019935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019935.Bytes);
public long this[int i]=>Value[i];

public static A019935Inst Instance=new A019935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019934
{
public static readonly long[] Value={ 7L,2L,6L,5L,4L,2L,5L,2L,8L,0L,0L,5L,3L,6L,0L,8L,8L,5L,8L,9L,5L,4L,6L,6L,7L,5L,7L,4L,8L,0L,6L,1L,8L,7L,4L,9L,6L,1L,6L,0L,9L,2L,3L,9L,2L,9L,6L,5L,2L,0L,8L,4L,6L,2L,7L,5L,0L,0L,6L,6L,3L,2L,7L,3L,4L,5L,7L,4L,9L,3L,9L,1L,8L,4L,5L,6L,8L,3L,0L,8L,8L,4L,2L,0L,5L,7L,7L,5L,2L,2L,2L,1L,6L,1L,4L,0L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019934Inst : IEnumerable<long>
{
public static readonly long[] Value=A019934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019934.Bytes);
public long this[int i]=>Value[i];

public static A019934Inst Instance=new A019934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019917
{
public static readonly long[] Value={ 3L,4L,4L,3L,2L,7L,6L,1L,3L,2L,8L,9L,6L,6L,5L,2L,4L,1L,9L,5L,7L,2L,6L,5L,8L,3L,9L,3L,8L,3L,1L,0L,8L,8L,6L,9L,7L,8L,4L,9L,5L,8L,1L,5L,1L,3L,0L,5L,3L,0L,2L,9L,0L,6L,9L,6L,2L,4L,4L,2L,5L,1L,9L,1L,1L,2L,8L,9L,5L,8L,6L,3L,7L,1L,2L,6L,3L,0L,7L,1L,9L,9L,2L,9L,4L,3L,0L,2L,2L,1L,8L,9L,2L,0L,0L,1L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019917Inst : IEnumerable<long>
{
public static readonly long[] Value=A019917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019917.Bytes);
public long this[int i]=>Value[i];

public static A019917Inst Instance=new A019917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019916
{
public static readonly long[] Value={ 3L,2L,4L,9L,1L,9L,6L,9L,6L,2L,3L,2L,9L,0L,6L,3L,2L,6L,1L,5L,5L,8L,7L,1L,4L,1L,2L,2L,1L,5L,1L,3L,4L,4L,6L,4L,9L,5L,4L,9L,0L,3L,4L,7L,1L,5L,2L,1L,4L,7L,5L,1L,0L,0L,3L,0L,7L,8L,0L,4L,7L,1L,9L,1L,3L,6L,6L,7L,2L,9L,0L,0L,9L,6L,0L,7L,4L,4L,9L,4L,8L,3L,2L,2L,6L,8L,7L,7L,3L,5L,4L,4L,6L,9L,6L,5L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019916Inst : IEnumerable<long>
{
public static readonly long[] Value=A019916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019916.Bytes);
public long this[int i]=>Value[i];

public static A019916Inst Instance=new A019916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019915
{
public static readonly long[] Value={ 3L,0L,5L,7L,3L,0L,6L,8L,1L,4L,5L,8L,6L,6L,0L,3L,5L,5L,7L,3L,4L,5L,4L,1L,9L,5L,8L,9L,9L,6L,5L,5L,0L,7L,1L,6L,1L,4L,6L,2L,5L,0L,2L,2L,1L,3L,8L,7L,1L,1L,6L,6L,9L,3L,6L,7L,0L,6L,8L,0L,5L,5L,7L,2L,1L,0L,0L,8L,7L,4L,0L,7L,7L,8L,1L,3L,3L,7L,4L,3L,6L,8L,2L,6L,8L,2L,5L,1L,6L,0L,2L,3L,5L,6L,3L,2L,0L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019915Inst : IEnumerable<long>
{
public static readonly long[] Value=A019915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019915.Bytes);
public long this[int i]=>Value[i];

public static A019915Inst Instance=new A019915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019914
{
public static readonly long[] Value={ 2L,8L,6L,7L,4L,5L,3L,8L,5L,7L,5L,8L,8L,0L,7L,9L,4L,0L,0L,4L,2L,7L,5L,8L,0L,6L,2L,7L,3L,2L,6L,6L,9L,9L,1L,2L,4L,2L,2L,3L,4L,7L,1L,1L,0L,2L,4L,5L,8L,5L,1L,6L,5L,6L,7L,2L,1L,3L,7L,9L,4L,8L,6L,0L,4L,2L,0L,9L,3L,8L,6L,5L,5L,2L,5L,4L,7L,8L,1L,9L,9L,3L,8L,5L,8L,5L,3L,4L,7L,3L,7L,9L,4L,7L,6L,3L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019914Inst : IEnumerable<long>
{
public static readonly long[] Value=A019914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019914.Bytes);
public long this[int i]=>Value[i];

public static A019914Inst Instance=new A019914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019913
{
public static readonly long[] Value={ 2L,6L,7L,9L,4L,9L,1L,9L,2L,4L,3L,1L,1L,2L,2L,7L,0L,6L,4L,7L,2L,5L,5L,3L,6L,5L,8L,4L,9L,4L,1L,2L,7L,6L,3L,3L,0L,5L,7L,1L,9L,4L,7L,4L,6L,1L,8L,9L,6L,1L,9L,3L,7L,1L,9L,4L,4L,1L,9L,3L,0L,2L,0L,5L,4L,8L,0L,6L,6L,9L,8L,3L,0L,9L,1L,1L,9L,9L,9L,6L,2L,9L,1L,8L,8L,5L,3L,8L,1L,3L,2L,4L,2L,7L,5L,1L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019913Inst : IEnumerable<long>
{
public static readonly long[] Value=A019913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019913.Bytes);
public long this[int i]=>Value[i];

public static A019913Inst Instance=new A019913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019912
{
public static readonly long[] Value={ 2L,4L,9L,3L,2L,8L,0L,0L,2L,8L,4L,3L,1L,8L,0L,6L,9L,1L,6L,2L,4L,0L,3L,9L,9L,3L,7L,8L,0L,4L,8L,6L,2L,1L,6L,7L,7L,6L,8L,8L,4L,6L,2L,4L,2L,4L,5L,9L,4L,2L,5L,8L,5L,7L,1L,8L,7L,9L,5L,9L,3L,8L,0L,0L,4L,7L,7L,0L,4L,7L,3L,1L,7L,6L,9L,7L,0L,9L,1L,4L,2L,3L,7L,6L,3L,8L,3L,4L,0L,9L,0L,5L,5L,8L,1L,3L,3L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019912Inst : IEnumerable<long>
{
public static readonly long[] Value=A019912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019912.Bytes);
public long this[int i]=>Value[i];

public static A019912Inst Instance=new A019912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019911
{
public static readonly long[] Value={ 2L,3L,0L,8L,6L,8L,1L,9L,1L,1L,2L,5L,5L,6L,3L,1L,1L,1L,7L,4L,8L,1L,4L,5L,6L,1L,3L,4L,7L,4L,4L,5L,3L,0L,6L,4L,8L,3L,3L,1L,2L,4L,5L,8L,4L,8L,5L,4L,3L,5L,1L,5L,0L,3L,2L,4L,3L,9L,0L,4L,1L,3L,3L,8L,0L,3L,9L,3L,5L,5L,5L,4L,2L,5L,7L,1L,5L,0L,8L,0L,3L,1L,6L,1L,8L,3L,6L,5L,6L,5L,8L,2L,0L,9L,2L,0L,8L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019911Inst : IEnumerable<long>
{
public static readonly long[] Value=A019911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019911.Bytes);
public long this[int i]=>Value[i];

public static A019911Inst Instance=new A019911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019910
{
public static readonly long[] Value={ 2L,1L,2L,5L,5L,6L,5L,6L,1L,6L,7L,0L,0L,2L,2L,1L,2L,5L,2L,5L,9L,5L,9L,1L,6L,6L,0L,5L,7L,0L,0L,8L,1L,9L,5L,7L,4L,1L,8L,5L,3L,4L,5L,4L,5L,7L,4L,8L,6L,9L,2L,0L,0L,9L,3L,9L,5L,4L,4L,4L,9L,5L,1L,9L,5L,2L,3L,5L,0L,4L,2L,2L,9L,1L,5L,6L,8L,9L,7L,1L,2L,2L,6L,5L,6L,4L,5L,0L,1L,4L,1L,9L,7L,1L,9L,3L,5L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019910Inst : IEnumerable<long>
{
public static readonly long[] Value=A019910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019910.Bytes);
public long this[int i]=>Value[i];

public static A019910Inst Instance=new A019910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019909
{
public static readonly long[] Value={ 1L,9L,4L,3L,8L,0L,3L,0L,9L,1L,3L,7L,7L,1L,8L,4L,8L,4L,2L,4L,3L,1L,9L,4L,2L,2L,4L,9L,7L,6L,8L,2L,4L,9L,5L,5L,1L,8L,3L,7L,8L,0L,1L,5L,2L,2L,1L,4L,6L,6L,3L,8L,6L,1L,3L,2L,3L,3L,6L,3L,3L,6L,3L,4L,3L,2L,5L,4L,1L,0L,5L,2L,9L,5L,4L,7L,3L,3L,9L,7L,2L,3L,8L,9L,6L,9L,2L,0L,8L,8L,9L,7L,6L,7L,3L,3L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019909Inst : IEnumerable<long>
{
public static readonly long[] Value=A019909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019909.Bytes);
public long this[int i]=>Value[i];

public static A019909Inst Instance=new A019909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019908
{
public static readonly long[] Value={ 1L,7L,6L,3L,2L,6L,9L,8L,0L,7L,0L,8L,4L,6L,4L,9L,7L,3L,4L,7L,1L,0L,9L,0L,3L,8L,6L,8L,6L,8L,6L,1L,8L,9L,8L,6L,1L,2L,1L,6L,3L,3L,0L,6L,2L,3L,4L,8L,0L,9L,8L,6L,6L,0L,2L,0L,5L,3L,6L,3L,9L,8L,3L,8L,3L,5L,4L,4L,6L,9L,0L,8L,9L,1L,7L,7L,5L,8L,6L,2L,5L,4L,9L,8L,6L,5L,1L,3L,3L,5L,0L,8L,0L,3L,2L,4L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019908Inst : IEnumerable<long>
{
public static readonly long[] Value=A019908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019908.Bytes);
public long this[int i]=>Value[i];

public static A019908Inst Instance=new A019908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019907
{
public static readonly long[] Value={ 1L,5L,8L,3L,8L,4L,4L,4L,0L,3L,2L,4L,5L,3L,6L,2L,9L,3L,8L,3L,8L,8L,8L,3L,0L,9L,2L,6L,9L,4L,3L,6L,6L,4L,1L,1L,4L,3L,3L,9L,1L,6L,2L,1L,6L,0L,7L,3L,7L,3L,3L,2L,9L,7L,2L,3L,1L,7L,4L,0L,9L,9L,5L,0L,3L,5L,6L,5L,7L,6L,3L,7L,1L,4L,2L,7L,1L,3L,9L,8L,0L,9L,5L,9L,8L,2L,0L,6L,8L,6L,7L,1L,1L,6L,7L,6L,8L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019907Inst : IEnumerable<long>
{
public static readonly long[] Value=A019907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019907.Bytes);
public long this[int i]=>Value[i];

public static A019907Inst Instance=new A019907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019906
{
public static readonly long[] Value={ 1L,4L,0L,5L,4L,0L,8L,3L,4L,7L,0L,2L,3L,9L,1L,4L,4L,6L,8L,3L,8L,1L,1L,7L,6L,9L,3L,4L,3L,2L,8L,1L,4L,1L,3L,5L,6L,7L,3L,1L,8L,7L,2L,7L,5L,1L,7L,4L,7L,7L,2L,3L,7L,4L,8L,9L,5L,3L,6L,0L,3L,6L,1L,7L,1L,2L,0L,5L,3L,2L,3L,2L,6L,4L,5L,7L,7L,9L,3L,4L,7L,8L,6L,6L,3L,6L,7L,9L,6L,7L,0L,3L,7L,7L,9L,3L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019906Inst : IEnumerable<long>
{
public static readonly long[] Value=A019906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019906.Bytes);
public long this[int i]=>Value[i];

public static A019906Inst Instance=new A019906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019905
{
public static readonly long[] Value={ 1L,2L,2L,7L,8L,4L,5L,6L,0L,9L,0L,2L,9L,0L,4L,5L,9L,1L,1L,3L,4L,2L,3L,1L,1L,3L,6L,0L,5L,2L,8L,5L,9L,5L,9L,5L,2L,8L,2L,3L,0L,7L,7L,0L,4L,6L,6L,0L,7L,7L,4L,7L,5L,9L,4L,6L,4L,3L,5L,5L,1L,6L,7L,5L,5L,1L,4L,0L,7L,7L,0L,0L,1L,6L,7L,2L,9L,5L,9L,4L,3L,9L,8L,7L,1L,0L,0L,1L,7L,2L,4L,3L,7L,9L,5L,4L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019905Inst : IEnumerable<long>
{
public static readonly long[] Value=A019905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019905.Bytes);
public long this[int i]=>Value[i];

public static A019905Inst Instance=new A019905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019904
{
public static readonly long[] Value={ 1L,0L,5L,1L,0L,4L,2L,3L,5L,2L,6L,5L,6L,7L,6L,4L,6L,2L,5L,1L,1L,5L,0L,2L,3L,8L,0L,1L,3L,9L,8L,8L,1L,9L,1L,5L,2L,5L,0L,2L,4L,6L,6L,4L,9L,5L,4L,5L,6L,8L,6L,8L,8L,2L,8L,7L,8L,6L,6L,1L,5L,6L,8L,1L,8L,3L,7L,8L,1L,9L,1L,0L,8L,1L,0L,6L,1L,4L,4L,1L,6L,7L,9L,7L,9L,3L,7L,5L,0L,4L,6L,7L,4L,7L,7L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019904Inst : IEnumerable<long>
{
public static readonly long[] Value=A019904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019904.Bytes);
public long this[int i]=>Value[i];

public static A019904Inst Instance=new A019904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019903
{
public static readonly long[] Value={ 0L,8L,7L,4L,8L,8L,6L,6L,3L,5L,2L,5L,9L,2L,4L,0L,0L,5L,2L,2L,2L,0L,1L,8L,6L,6L,9L,4L,3L,4L,9L,6L,1L,4L,5L,8L,1L,1L,9L,4L,5L,4L,2L,7L,6L,3L,6L,8L,1L,0L,8L,2L,2L,9L,1L,4L,5L,2L,3L,6L,6L,6L,2L,2L,2L,1L,6L,4L,1L,4L,2L,7L,3L,0L,2L,6L,1L,2L,8L,4L,1L,6L,1L,9L,1L,2L,3L,7L,3L,2L,3L,7L,0L,0L,6L,4L,0L,9L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019903Inst : IEnumerable<long>
{
public static readonly long[] Value=A019903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019903.Bytes);
public long this[int i]=>Value[i];

public static A019903Inst Instance=new A019903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019902
{
public static readonly long[] Value={ 0L,6L,9L,9L,2L,6L,8L,1L,1L,9L,4L,3L,5L,1L,0L,4L,1L,3L,6L,6L,6L,9L,2L,1L,0L,6L,0L,3L,2L,3L,1L,8L,1L,7L,5L,5L,9L,6L,7L,9L,3L,0L,2L,4L,5L,9L,6L,8L,6L,8L,0L,6L,0L,9L,6L,9L,8L,3L,7L,2L,4L,9L,7L,8L,7L,8L,3L,5L,7L,0L,0L,0L,5L,9L,0L,3L,7L,6L,6L,7L,2L,6L,0L,4L,5L,4L,4L,3L,4L,6L,7L,8L,6L,8L,7L,1L,8L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019902Inst : IEnumerable<long>
{
public static readonly long[] Value=A019902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019902.Bytes);
public long this[int i]=>Value[i];

public static A019902Inst Instance=new A019902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019869
{
public static readonly long[] Value={ 1L,23L,367L,5075L,65551L,817643L,10013527L,121451315L,1465540351L,17637184763L,211960186087L,2545454874755L,30557298487951L,366759842503883L,4401557777453047L,52821361851453395L,633872505937432351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019869Inst : IEnumerable<long>
{
public static readonly long[] Value=A019869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019869.Bytes);
public long this[int i]=>Value[i];

public static A019869Inst Instance=new A019869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019868
{
public static readonly long[] Value={ 8L,5L,7L,1L,6L,7L,3L,0L,0L,7L,0L,2L,1L,1L,2L,2L,8L,7L,4L,6L,5L,2L,1L,7L,9L,8L,0L,1L,4L,4L,7L,6L,3L,3L,1L,4L,3L,8L,4L,0L,5L,3L,6L,6L,4L,8L,0L,6L,0L,7L,0L,6L,3L,5L,7L,4L,4L,0L,0L,5L,6L,4L,5L,7L,5L,1L,4L,7L,9L,0L,2L,3L,1L,9L,7L,6L,8L,1L,9L,4L,0L,5L,4L,9L,6L,5L,9L,1L,1L,0L,9L,9L,7L,3L,4L,2L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019868Inst : IEnumerable<long>
{
public static readonly long[] Value=A019868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019868.Bytes);
public long this[int i]=>Value[i];

public static A019868Inst Instance=new A019868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019867
{
public static readonly long[] Value={ 8L,4L,8L,0L,4L,8L,0L,9L,6L,1L,5L,6L,4L,2L,5L,9L,7L,0L,3L,8L,6L,1L,7L,6L,1L,7L,8L,6L,9L,0L,3L,8L,6L,4L,4L,8L,7L,2L,8L,7L,1L,2L,0L,5L,5L,9L,5L,6L,2L,4L,5L,3L,5L,9L,0L,5L,1L,8L,6L,1L,9L,6L,1L,1L,2L,8L,3L,1L,3L,2L,3L,1L,5L,9L,6L,4L,2L,4L,9L,2L,2L,8L,4L,8L,0L,4L,8L,5L,2L,9L,0L,4L,4L,7L,2L,7L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019867Inst : IEnumerable<long>
{
public static readonly long[] Value=A019867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019867.Bytes);
public long this[int i]=>Value[i];

public static A019867Inst Instance=new A019867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019866
{
public static readonly long[] Value={ 8L,3L,8L,6L,7L,0L,5L,6L,7L,9L,4L,5L,4L,2L,4L,0L,2L,9L,6L,3L,7L,5L,9L,0L,9L,4L,1L,8L,0L,4L,5L,4L,7L,8L,9L,4L,0L,3L,9L,5L,0L,0L,2L,6L,5L,0L,9L,5L,9L,2L,3L,8L,2L,4L,9L,2L,2L,0L,1L,2L,9L,0L,2L,9L,2L,2L,6L,3L,5L,1L,6L,9L,5L,3L,4L,3L,8L,0L,6L,7L,7L,5L,1L,3L,4L,7L,3L,9L,8L,3L,9L,2L,2L,9L,7L,4L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019866Inst : IEnumerable<long>
{
public static readonly long[] Value=A019866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019866.Bytes);
public long this[int i]=>Value[i];

public static A019866Inst Instance=new A019866Inst();

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