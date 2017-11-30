using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A000485
{
public static readonly long[] Value={ 16L,125L,680L,3135L,13155L,51873L,195821L,715614L,2550577L,8911942L,30640888L,103951415L,348724844L,1158722880L,3818514232L,12493703403L,40620949971L,131336770375L,422536529249L,1353341880777L,4317248276746L,13722302173753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000485Inst : IEnumerable<long>
{
public static readonly long[] Value=A000485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000485.Bytes);
public long this[int i]=>Value[i];

public static A000485Inst Instance=new A000485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000486
{
public static readonly long[] Value={ 16L,150L,926L,4788L,22548L,100530L,433162L,1825296L,7577120L,31130190L,126969558L,515183724L,2082553132L,8395437930L,33776903714L,135691891272L,544517772984L,2183315948550L,8748985781230L,35043081823140L,140313684667076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000486Inst : IEnumerable<long>
{
public static readonly long[] Value=A000486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000486.Bytes);
public long this[int i]=>Value[i];

public static A000486Inst Instance=new A000486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000487
{
public static readonly long[] Value={ 16L,272L,2880L,24576L,185856L,1304832L,8728576L,56520704L,357888000L,2230947840L,13754155008L,84134068224L,511780323328L,3100738912256L,18733264797696L,112949304754176L,680032201605120L,4090088616099840L,24582312700149760L,147669797096652800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000487Inst : IEnumerable<long>
{
public static readonly long[] Value=A000487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000487.Bytes);
public long this[int i]=>Value[i];

public static A000487Inst Instance=new A000487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000488
{
public static readonly long[] Value={ 16L,361L,3362L,16384L,55744L,152166L,355688L,739328L,1415232L,2529614L,4261454L,6885376L,10708160L,16054580L,23494584L,33554432L,46698624L,64037790L,86342918L,114163712L,149518720L,193356526L,246232840L,311635968L,390600000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000488Inst : IEnumerable<long>
{
public static readonly long[] Value=A000488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000488.Bytes);
public long this[int i]=>Value[i];

public static A000488Inst Instance=new A000488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000489
{
public static readonly long[] Value={ 1L,16L,435L,7136L,99350L,1234032L,14219212L,155251840L,1628202762L,16550991200L,164111079110L,1594594348800L,15235525651840L,143518352447680L,1335670583147400L,12301278983461376L,112264111607438906L,1016361486936571680L,9136254276320346046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000489Inst : IEnumerable<long>
{
public static readonly long[] Value=A000489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000489.Bytes);
public long this[int i]=>Value[i];

public static A000489Inst Instance=new A000489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000490
{
public static readonly BigInteger[] Value={ 1L,16L,1280L,249856L,90767360L,52975108096L,45344872202240L,53515555843342336L,BigInteger.Parse("83285910482761809920"),BigInteger.Parse("165262072909347030040576"),BigInteger.Parse("407227428060372417275494400"),BigInteger.Parse("1219998300294918683087199010816") };
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
public class A000490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000490Inst Instance=new A000490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000491
{
public static readonly long[] Value={ 7L,19L,47L,97L,189L,339L,589L,975L,1576L,2472L,3804L,5727L,8498L,12400L,17874L,25433L,35818L,49908L,68939L,94378L,128234L,172917L,231630L,308240L,407804L,536412L,701910L,913773L,1184022L,1527165L,1961432L,2508762L,3196473L,4057403L,5132066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000491Inst : IEnumerable<long>
{
public static readonly long[] Value=A000491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000491.Bytes);
public long this[int i]=>Value[i];

public static A000491Inst Instance=new A000491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000492
{
public static readonly BigInteger[] Value={ 20L,154L,1676L,14292L,155690L,1731708L,21264624L,280260864L,3970116255L,60113625680L,969368687752L,16588175089420L,300272980075896L,5733025551810600L,115148956467702600L,2427199940533198992L,BigInteger.Parse("53576182138937428377"),BigInteger.Parse("1235917889588345408586") };
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
public class A000492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000492Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000492.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000492Inst Instance=new A000492Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000493
{
public static readonly long[] Value={ 0L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000493Inst : IEnumerable<long>
{
public static readonly long[] Value=A000493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000493.Bytes);
public long this[int i]=>Value[i];

public static A000493Inst Instance=new A000493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000494
{
public static readonly long[] Value={ 0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000494Inst : IEnumerable<long>
{
public static readonly long[] Value=A000494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000494.Bytes);
public long this[int i]=>Value[i];

public static A000494Inst Instance=new A000494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000495
{
public static readonly long[] Value={ 0L,1L,4L,10L,27L,74L,202L,548L,1490L,4052L,11013L,29937L,81377L,221207L,601302L,1634509L,4443055L,12077476L,32829985L,89241150L,242582598L,659407867L,1792456423L,4872401723L,13244561065L,36002449669L,97864804714L,266024120301L,723128532146L,1965667148572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000495Inst : IEnumerable<long>
{
public static readonly long[] Value=A000495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000495.Bytes);
public long this[int i]=>Value[i];

public static A000495Inst Instance=new A000495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000496
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,44L,80L,144L,260L,476L,872L,1600L,2940L,5404L,9936L,18272L,33604L,61804L,113672L,209072L,384540L,707276L,1300880L,2392688L,4400836L,8094396L,14887912L,27383136L,50365436L,92636476L,170385040L,313386944L,576408452L,1060180428L,1949975816L,3586564688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000496Inst : IEnumerable<long>
{
public static readonly long[] Value=A000496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000496.Bytes);
public long this[int i]=>Value[i];

public static A000496Inst Instance=new A000496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000497
{
public static readonly BigInteger[] Value={ 1L,25L,490L,9450L,190575L,4099095L,94594500L,2343240900L,62199262125L,1764494857125L,53338158823950L,1712934942468750L,58274046742786875L,2094379201311271875L,BigInteger.Parse("79318164037837725000"),BigInteger.Parse("3157886388887074845000") };
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
public class A000497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000497Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000497.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000497Inst Instance=new A000497Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000498
{
public static readonly long[] Value={ 1L,26L,302L,2416L,15619L,88234L,455192L,2203488L,10187685L,45533450L,198410786L,848090912L,3572085255L,14875399450L,61403313100L,251732291184L,1026509354985L,4168403181210L,16871482830550L,68111623139600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000498Inst : IEnumerable<long>
{
public static readonly long[] Value=A000498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000498.Bytes);
public long this[int i]=>Value[i];

public static A000498Inst Instance=new A000498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000499
{
public static readonly long[] Value={ 0L,1L,27L,184L,875L,2700L,7546L,17600L,35721L,72750L,126445L,223776L,353717L,595448L,843750L,1349120L,1827636L,2808837L,3600975L,5306000L,6667920L,9599172L,11509982L,16416000L,19015625L,26605670L,30902310L,41686848L,46948825L,64233000L,70306760L,94089216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000499Inst : IEnumerable<long>
{
public static readonly long[] Value=A000499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000499.Bytes);
public long this[int i]=>Value[i];

public static A000499Inst Instance=new A000499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000500
{
public static readonly BigInteger[] Value={ 31L,304L,4230L,43880L,547338L,6924960L,94714620L,1375878816L,21273204330L,348919244768L,6056244249682L,110955673493568L,2140465858763844L,43379533256972640L,921616584567907176L,BigInteger.Parse("20485188316420940640"),BigInteger.Parse("475499882089797554181"),BigInteger.Parse("11506280235885243825696") };
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
public class A000500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000500Inst Instance=new A000500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000501
{
public static readonly long[] Value={ 1L,1L,3L,10L,27L,74L,201L,548L,1490L,4051L,11013L,29937L,81377L,221206L,601302L,1634508L,4443055L,12077476L,32829984L,89241150L,242582597L,659407867L,1792456423L,4872401723L,13244561064L,36002449668L,97864804714L,266024120300L,723128532145L,1965667148572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000501Inst : IEnumerable<long>
{
public static readonly long[] Value=A000501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000501.Bytes);
public long this[int i]=>Value[i];

public static A000501Inst Instance=new A000501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000502
{
public static readonly BigInteger[] Value={ 42L,1586L,31388L,442610L,5030004L,49145460L,429166584L,3435601554L,25658464260L,181055975100L,1218601601672L,7880146275092L,49238911113224L,298652277299880L,1764885293279472L,10192638073849554L,57674223198273444L,320430129184331628L,1751190732477786600L,9428906326013866076UL,BigInteger.Parse("50084560529695713560"),BigInteger.Parse("262767521450593566680"),BigInteger.Parse("1363049865350949194640"),BigInteger.Parse("6997091408385651436500"),BigInteger.Parse("35574379172542272659688"),BigInteger.Parse("179258908485659235515352"),BigInteger.Parse("895827468451622607205200"),BigInteger.Parse("4442385594472223942397672"),BigInteger.Parse("21871555968464155937448080"),BigInteger.Parse("106958771000949466098945104"),BigInteger.Parse("519767712768164680745022944"),BigInteger.Parse("2510872436703684655047207762"),BigInteger.Parse("12061854932881499884016376036"),BigInteger.Parse("57638984943605113572323531340"),BigInteger.Parse("274068077621341051602455876520") };
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
public class A000502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000502Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000502.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000502Inst Instance=new A000502Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000503
{
public static readonly long[] Value={ 0L,1L,-3L,-1L,1L,-4L,-1L,0L,-7L,-1L,0L,-226L,-1L,0L,7L,-1L,0L,3L,-2L,0L,2L,-2L,0L,1L,-3L,-1L,1L,-4L,-1L,0L,-7L,-1L,0L,-76L,-1L,0L,7L,-1L,0L,3L,-2L,0L,2L,-2L,0L,1L,-3L,-1L,1L,-4L,-1L,0L,-7L,-1L,0L,-46L,-1L,0L,8L,-1L,0L,3L,-2L,0L,2L,-2L,0L,1L,-3L,-1L,1L,-4L,-1L,0L,-6L,-1L,0L,-33L,-1L,0L,9L,-1L,0L,3L,-2L,0L,2L,-2L,0L,1L,-2L,-1L,1L,-3L,-1L,0L,-6L,-1L,0L,-26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000503Inst : IEnumerable<long>
{
public static readonly long[] Value=A000503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000503.Bytes);
public long this[int i]=>Value[i];

public static A000503Inst Instance=new A000503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000504
{
public static readonly BigInteger[] Value={ 1L,56L,1918L,56980L,1636635L,47507460L,1422280860L,44346982680L,1446733012725L,49473074851200L,1774073543492250L,66681131440423500L,2624634287988087375L,BigInteger.Parse("108060337458000427500"),BigInteger.Parse("4647703259223579555000"),BigInteger.Parse("208548093035794902390000"),BigInteger.Parse("9749651260035434678555625") };
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
public class A000504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000504Inst Instance=new A000504Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000505
{
public static readonly long[] Value={ 1L,57L,1191L,15619L,156190L,1310354L,9738114L,66318474L,423281535L,2571742175L,15041229521L,85383238549L,473353301060L,2575022097600L,13796160184500L,73008517581444L,382493246941965L,1987497491971605L,10258045633638475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000505Inst : IEnumerable<long>
{
public static readonly long[] Value=A000505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000505.Bytes);
public long this[int i]=>Value[i];

public static A000505Inst Instance=new A000505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000506
{
public static readonly long[] Value={ 61L,841L,7311L,51663L,325446L,1910706L,10715506L,58258210L,309958755L,1623847695L,8412276585L,43220104041L,220683627988L,1121561317408L,5679711010548L,28683869195556L,144552802373145L,727271783033445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000506Inst : IEnumerable<long>
{
public static readonly long[] Value=A000506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000506.Bytes);
public long this[int i]=>Value[i];

public static A000506Inst Instance=new A000506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000507
{
public static readonly long[] Value={ 61L,1385L,19028L,206276L,1949762L,16889786L,137963364L,1081702420L,8236142455L,61386982075L,450403628440L,3266265481144L,23480284103492L,167687984079924L,1191656966048088L,8436830209386360L,59563995267159825L,419628657826253805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000507Inst : IEnumerable<long>
{
public static readonly long[] Value=A000507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000507.Bytes);
public long this[int i]=>Value[i];

public static A000507Inst Instance=new A000507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000508
{
public static readonly long[] Value={ 61L,2763L,38528L,249856L,1066590L,3487246L,9493504L,22634496L,48649086L,96448478L,179369856L,315621376L,530788622L,860061996L,1346126848L,2046820352L,3038120316L,4403100222L,6254596992L,8737505280L,11992903772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000508Inst : IEnumerable<long>
{
public static readonly long[] Value=A000508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000508.Bytes);
public long this[int i]=>Value[i];

public static A000508Inst Instance=new A000508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000509
{
public static readonly long[] Value={ 6L,6L,8L,10L,12L,13L,14L,14L,17L,21L,22L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000509Inst : IEnumerable<long>
{
public static readonly long[] Value=A000509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000509.Bytes);
public long this[int i]=>Value[i];

public static A000509Inst Instance=new A000509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000526
{
public static readonly long[] Value={ 125L,1296L,8716L,47787L,232154L,1040014L,4395772L,17781210L,69498964L,264248924L,982218072L,3582421612L,12857819052L,45515994861L,159205157535L,551049504784L,1889714853263L,6427147635062L,21698583468717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000526Inst : IEnumerable<long>
{
public static readonly long[] Value=A000526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000526.Bytes);
public long this[int i]=>Value[i];

public static A000526Inst Instance=new A000526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000527
{
public static readonly BigInteger[] Value={ 52L,472L,3224L,18888L,101340L,511120L,2465904L,11496144L,52165892L,231557064L,1009247192L,4331502840L,18346242492L,76822836544L,318485778848L,1308750158016L,5335993098340L,21603437175288L,86912657626392L,347660876627944L,1383457374046444L,5479086968052912L,21604984733546336L,84850331177724944L,332001521469767940L,1294589169323791912L,5031934808360234760L,BigInteger.Parse("19500424806065865400"),BigInteger.Parse("75360646947991208396"),BigInteger.Parse("290478417300879735680"),BigInteger.Parse("1116919455364101145920"),BigInteger.Parse("4284817000807140094464"),BigInteger.Parse("16402243457215852326116"),BigInteger.Parse("62659647762404302956856"),BigInteger.Parse("238910441445219175239480") };
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
public class A000527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000527Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000527.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000527Inst Instance=new A000527Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000528
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,2L,17L,324L,842227L,57810418543L,104452188344901572L,BigInteger.Parse("6108088657705958932053657") };
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
public class A000528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000528Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000528.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000528Inst Instance=new A000528Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000529
{
public static readonly long[] Value={ 20L,74L,186L,388L,721L,1236L,1995L,3072L,4554L,6542L,9152L,12516L,16783L,22120L,28713L,36768L,46512L,58194L,72086L,88484L,107709L,130108L,156055L,185952L,220230L,259350L,303804L,354116L,410843L,474576L,545941L,625600L,714252L,812634L,921522L,1041732L,1174121L,1319588L,1479075L,1653568L,1844098L,2051742L,2277624L,2522916L,2788839L,3076664L,3387713L,3723360L,4085032L,4474210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000529Inst : IEnumerable<long>
{
public static readonly long[] Value=A000529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000529.Bytes);
public long this[int i]=>Value[i];

public static A000529Inst Instance=new A000529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000530
{
public static readonly long[] Value={ 1L,5L,28L,226L,2077L,20770L,222884L,2529541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000530Inst : IEnumerable<long>
{
public static readonly long[] Value=A000530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000530.Bytes);
public long this[int i]=>Value[i];

public static A000530Inst Instance=new A000530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000531
{
public static readonly long[] Value={ 1L,7L,38L,187L,874L,3958L,17548L,76627L,330818L,1415650L,6015316L,25413342L,106853668L,447472972L,1867450648L,7770342787L,32248174258L,133530264682L,551793690628L,2276098026922L,9373521044908L,38546133661492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000531Inst : IEnumerable<long>
{
public static readonly long[] Value=A000531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000531.Bytes);
public long this[int i]=>Value[i];

public static A000531Inst Instance=new A000531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000532
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,86L,1770L,88418L,8934966L,2087813834L,1013346943033L,1111598871478668L,2568944901392936854L,BigInteger.Parse("13251059359839620127088"),BigInteger.Parse("145194816279817259193401518"),BigInteger.Parse("3524171261632305641165676374930") };
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
public class A000532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000532Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000532.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000532Inst Instance=new A000532Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000533
{
public static readonly long[] Value={ 1L,11L,101L,1001L,10001L,100001L,1000001L,10000001L,100000001L,1000000001L,10000000001L,100000000001L,1000000000001L,10000000000001L,100000000000001L,1000000000000001L,10000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000533Inst : IEnumerable<long>
{
public static readonly long[] Value=A000533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000533.Bytes);
public long this[int i]=>Value[i];

public static A000533Inst Instance=new A000533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000534
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,8L,9L,11L,14L,17L,24L,29L,32L,41L,56L,96L,128L,224L,384L,512L,896L,1536L,2048L,3584L,6144L,8192L,14336L,24576L,32768L,57344L,98304L,131072L,229376L,393216L,524288L,917504L,1572864L,2097152L,3670016L,6291456L,8388608L,14680064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000534Inst : IEnumerable<long>
{
public static readonly long[] Value=A000534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000534.Bytes);
public long this[int i]=>Value[i];

public static A000534Inst Instance=new A000534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000535
{
public static readonly long[] Value={ 0L,27L,378L,4536L,48600L,489780L,4738104L,44535456L,409752432L,3708359550L,33125746500L,292779558720L,2565087894720L,22307854940280L,192788833482000L,1657111548654720L,14176605442521312L,120779466450505758L,1025230099571720676L,8674221270307971600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000535Inst : IEnumerable<long>
{
public static readonly long[] Value=A000535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000535.Bytes);
public long this[int i]=>Value[i];

public static A000535Inst Instance=new A000535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000536
{
public static readonly BigInteger[] Value={ 24L,240L,2520L,26880L,304080L,3671136L,47391120L,653463360L,9603708840L,150046937040L,2485510331304L,43536519673920L,804343214307360L,15636586027419840L,319143375070100640L,6824486562845878656L,BigInteger.Parse("152599994618389811640"),BigInteger.Parse("3561710724832153990320"),BigInteger.Parse("86627571138529803385080"),BigInteger.Parse("2192153071078356814538880"),BigInteger.Parse("57633178354598014299807984"),BigInteger.Parse("1572073330365520093029415200"),BigInteger.Parse("44434609885866805678475703600"),BigInteger.Parse("1299879247128621094998213278400"),BigInteger.Parse("39312834919322919649653205283400"),BigInteger.Parse("1227895179113516869799082638629776"),BigInteger.Parse("39569125440836907870479047149487560"),BigInteger.Parse("1314368274045259508166257769617810880"),BigInteger.Parse("44963797526832537006635800892057862720"),BigInteger.Parse("1582832153412276057834241761650127323520") };
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
public class A000536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000536Inst Instance=new A000536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000537
{
public static readonly long[] Value={ 0L,1L,9L,36L,100L,225L,441L,784L,1296L,2025L,3025L,4356L,6084L,8281L,11025L,14400L,18496L,23409L,29241L,36100L,44100L,53361L,64009L,76176L,90000L,105625L,123201L,142884L,164836L,189225L,216225L,246016L,278784L,314721L,354025L,396900L,443556L,494209L,549081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000537Inst : IEnumerable<long>
{
public static readonly long[] Value=A000537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000537.Bytes);
public long this[int i]=>Value[i];

public static A000537Inst Instance=new A000537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000538
{
public static readonly long[] Value={ 0L,1L,17L,98L,354L,979L,2275L,4676L,8772L,15333L,25333L,39974L,60710L,89271L,127687L,178312L,243848L,327369L,432345L,562666L,722666L,917147L,1151403L,1431244L,1763020L,2153645L,2610621L,3142062L,3756718L,4463999L,5273999L,6197520L,7246096L,8432017L,9768353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000538Inst : IEnumerable<long>
{
public static readonly long[] Value=A000538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000538.Bytes);
public long this[int i]=>Value[i];

public static A000538Inst Instance=new A000538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000539
{
public static readonly long[] Value={ 0L,1L,33L,276L,1300L,4425L,12201L,29008L,61776L,120825L,220825L,381876L,630708L,1002001L,1539825L,2299200L,3347776L,4767633L,6657201L,9133300L,12333300L,16417401L,21571033L,28007376L,35970000L,45735625L,57617001L,71965908L,89176276L,109687425L,133987425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000539Inst : IEnumerable<long>
{
public static readonly long[] Value=A000539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000539.Bytes);
public long this[int i]=>Value[i];

public static A000539Inst Instance=new A000539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000540
{
public static readonly long[] Value={ 0L,1L,65L,794L,4890L,20515L,67171L,184820L,446964L,978405L,1978405L,3749966L,6735950L,11562759L,19092295L,30482920L,47260136L,71397705L,105409929L,152455810L,216455810L,302221931L,415601835L,563637724L,754740700L,998881325L,1307797101L,1695217590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000540Inst : IEnumerable<long>
{
public static readonly long[] Value=A000540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000540.Bytes);
public long this[int i]=>Value[i];

public static A000540Inst Instance=new A000540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000541
{
public static readonly long[] Value={ 0L,1L,129L,2316L,18700L,96825L,376761L,1200304L,3297456L,8080425L,18080425L,37567596L,73399404L,136147921L,241561425L,412420800L,680856256L,1091194929L,1703414961L,2597286700L,3877286700L,5678375241L,8172733129L,11577558576L,16164030000L,22267545625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000541Inst : IEnumerable<long>
{
public static readonly long[] Value=A000541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000541.Bytes);
public long this[int i]=>Value[i];

public static A000541Inst Instance=new A000541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000558
{
public static readonly BigInteger[] Value={ 1L,6L,32L,175L,1012L,6230L,40819L,283944L,2090424L,16235417L,132609666L,1135846062L,10175352709L,95108406130L,925496853980L,9357279554071L,98118527430960L,1065259283215810L,11956366813630835L,138539436100687988L,1655071323662574756L,BigInteger.Parse("20361556640795422729") };
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
public class A000558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000558Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000558.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000558Inst Instance=new A000558Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000559
{
public static readonly BigInteger[] Value={ 1L,12L,110L,945L,8092L,70756L,638423L,5971350L,57996774L,585092607L,6128147610L,66579524648L,749542556193L,8733648533696L,105203108066962L,1308549777461505L,16787682400875456L,221901108871482760L,3018891886411332135L,BigInteger.Parse("42230736603244134242") };
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
public class A000559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000559Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000559.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000559Inst Instance=new A000559Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000560
{
public static readonly long[] Value={ 1L,2L,5L,12L,33L,87L,252L,703L,2105L,6099L,18689L,55639L,173423L,526937L,1664094L,5137233L,16393315L,51255709L,164951529L,521138861L,1688959630L,5382512216L,17547919924L,56335234064L,184596351277L,596362337295L,1962723402375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000560Inst : IEnumerable<long>
{
public static readonly long[] Value=A000560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000560.Bytes);
public long this[int i]=>Value[i];

public static A000560Inst Instance=new A000560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000561
{
public static readonly long[] Value={ 6L,44L,145L,336L,644L,1096L,1719L,2540L,3586L,4884L,6461L,8344L,10560L,13136L,16099L,19476L,23294L,27580L,32361L,37664L,43516L,49944L,56975L,64636L,72954L,81956L,91669L,102120L,113336L,125344L,138171L,151844L,166390L,181836L,198209L,215536L,233844L,253160L,273511L,294924L,317426L,341044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000561Inst : IEnumerable<long>
{
public static readonly long[] Value=A000561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000561.Bytes);
public long this[int i]=>Value[i];

public static A000561Inst Instance=new A000561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000562
{
public static readonly long[] Value={ 9L,95L,420L,1225L,2834L,5652L,10165L,16940L,26625L,39949L,57722L,80835L,110260L,147050L,192339L,247342L,313355L,391755L,484000L,591629L,716262L,859600L,1023425L,1209600L,1420069L,1656857L,1922070L,2217895L,2546600L,2910534L,3312127L,3753890L,4238415L,4768375L,5346524L,5975697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000562Inst : IEnumerable<long>
{
public static readonly long[] Value=A000562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000562.Bytes);
public long this[int i]=>Value[i];

public static A000562Inst Instance=new A000562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000563
{
public static readonly long[] Value={ 13L,192L,1085L,3880L,10656L,24626L,50380L,94128L,163943L,270004L,424839L,643568L,944146L,1347606L,1878302L,2564152L,3436881L,4532264L,5890369L,7555800L,9577940L,12011194L,14915232L,18355232L,22402123L,27132828L,32630507L,38984800L,46292070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000563Inst : IEnumerable<long>
{
public static readonly long[] Value=A000563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000563.Bytes);
public long this[int i]=>Value[i];

public static A000563Inst Instance=new A000563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000564
{
public static readonly long[] Value={ 20L,371L,2588L,11097L,35645L,94457L,218124L,454220L,872648L,1571715L,2684936L,4388567L,6909867L,10536089L,15624200L,22611330L,32025950L,44499779L,60780420L,81744725L,108412889L,141963273L,183747956L,235309016L,298395540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000564Inst : IEnumerable<long>
{
public static readonly long[] Value=A000564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000564.Bytes);
public long this[int i]=>Value[i];

public static A000564Inst Instance=new A000564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000565
{
public static readonly long[] Value={ 31L,696L,5823L,29380L,108933L,327840L,848380L,1958004L,4130895L,8107024L,14990889L,26372124L,44470165L,72305160L,113897310L,174496828L,260846703L,381480456L,547057075L,770735316L,1068589557L,1460069392L,1968505152L,2621661540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000565Inst : IEnumerable<long>
{
public static readonly long[] Value=A000565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000565.Bytes);
public long this[int i]=>Value[i];

public static A000565Inst Instance=new A000565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000566
{
public static readonly long[] Value={ 0L,1L,7L,18L,34L,55L,81L,112L,148L,189L,235L,286L,342L,403L,469L,540L,616L,697L,783L,874L,970L,1071L,1177L,1288L,1404L,1525L,1651L,1782L,1918L,2059L,2205L,2356L,2512L,2673L,2839L,3010L,3186L,3367L,3553L,3744L,3940L,4141L,4347L,4558L,4774L,4995L,5221L,5452L,5688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000566Inst : IEnumerable<long>
{
public static readonly long[] Value=A000566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000566.Bytes);
public long this[int i]=>Value[i];

public static A000566Inst Instance=new A000566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000567
{
public static readonly long[] Value={ 0L,1L,8L,21L,40L,65L,96L,133L,176L,225L,280L,341L,408L,481L,560L,645L,736L,833L,936L,1045L,1160L,1281L,1408L,1541L,1680L,1825L,1976L,2133L,2296L,2465L,2640L,2821L,3008L,3201L,3400L,3605L,3816L,4033L,4256L,4485L,4720L,4961L,5208L,5461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000567Inst : IEnumerable<long>
{
public static readonly long[] Value=A000567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000567.Bytes);
public long this[int i]=>Value[i];

public static A000567Inst Instance=new A000567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000568
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,4L,12L,56L,456L,6880L,191536L,9733056L,903753248L,154108311168L,48542114686912L,28401423719122304L,BigInteger.Parse("31021002160355166848"),BigInteger.Parse("63530415842308265100288"),BigInteger.Parse("244912778438520759443245824") };
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
public class A000568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000568Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000568.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000568Inst Instance=new A000568Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000569
{
public static readonly long[] Value={ 1L,2L,5L,9L,17L,31L,54L,90L,151L,244L,387L,607L,933L,1420L,2136L,3173L,4657L,6799L,9803L,14048L,19956L,28179L,39467L,54996L,76104L,104802L,143481L,195485L,264941L,357635L,480408L,642723L,856398L,1136715L,1503172L,1980785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000569Inst : IEnumerable<long>
{
public static readonly long[] Value=A000569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000569.Bytes);
public long this[int i]=>Value[i];

public static A000569Inst Instance=new A000569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000570
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,11L,18L,31L,53L,89L,149L,251L,424L,715L,1204L,2028L,3418L,5761L,9708L,16358L,27565L,46452L,78279L,131910L,222285L,374581L,631222L,1063696L,1792472L,3020560L,5090059L,8577449L,14454177L,24357268L,41045336L,69167021L,116555915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000570Inst : IEnumerable<long>
{
public static readonly long[] Value=A000570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000570.Bytes);
public long this[int i]=>Value[i];

public static A000570Inst Instance=new A000570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000571
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,9L,22L,59L,167L,490L,1486L,4639L,14805L,48107L,158808L,531469L,1799659L,6157068L,21258104L,73996100L,259451116L,915695102L,3251073303L,11605141649L,41631194766L,150021775417L,542875459724L,1972050156181L,7189259574618L,26295934251565L,96478910768821L,354998461378719L,1309755903513481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000571Inst : IEnumerable<long>
{
public static readonly long[] Value=A000571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000571.Bytes);
public long this[int i]=>Value[i];

public static A000571Inst Instance=new A000571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000572
{
public static readonly long[] Value={ 3L,7L,11L,14L,18L,22L,26L,29L,33L,37L,40L,44L,48L,52L,55L,59L,63L,66L,70L,74L,78L,81L,85L,89L,92L,96L,100L,104L,107L,111L,115L,118L,122L,126L,130L,133L,137L,141L,145L,148L,152L,156L,159L,163L,167L,171L,174L,178L,182L,185L,189L,193L,197L,200L,204L,208L,211L,215L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000572Inst : IEnumerable<long>
{
public static readonly long[] Value=A000572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000572.Bytes);
public long this[int i]=>Value[i];

public static A000572Inst Instance=new A000572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000573
{
public static readonly BigInteger[] Value={ 4L,56L,6552L,1293216L,420909504L,207624560256L,147174521059584L,143968880078466048L,BigInteger.Parse("188237563987982390784"),BigInteger.Parse("320510030393570671051776"),BigInteger.Parse("695457005987768649183581184"),BigInteger.Parse("1888143905499961681708381310976"),BigInteger.Parse("6314083806394358817244705266941952"),BigInteger.Parse("25655084790196439186603345691314159616") };
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
public class A000573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000573Inst Instance=new A000573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000574
{
public static readonly long[] Value={ 3L,16L,51L,126L,266L,504L,882L,1452L,2277L,3432L,5005L,7098L,9828L,13328L,17748L,23256L,30039L,38304L,48279L,60214L,74382L,91080L,110630L,133380L,159705L,190008L,224721L,264306L,309256L,360096L,417384L,481712L,553707L,634032L,723387L,822510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000574Inst : IEnumerable<long>
{
public static readonly long[] Value=A000574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000574.Bytes);
public long this[int i]=>Value[i];

public static A000574Inst Instance=new A000574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000575
{
public static readonly long[] Value={ 10L,80L,365L,1246L,3535L,8800L,19855L,41470L,81367L,151580L,270270L,464100L,771290L,1245488L,1960610L,3016820L,4547840L,6729800L,9791859L,14028850L,19816225L,27627600L,38055225L,51833730L,69867525L,93262260L,123360780L,161784040L,210477476L,271763360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000575Inst : IEnumerable<long>
{
public static readonly long[] Value=A000575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000575.Bytes);
public long this[int i]=>Value[i];

public static A000575Inst Instance=new A000575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000576
{
public static readonly BigInteger[] Value={ 1L,3L,46L,6552L,11270400L,335390189568L,224382967916691456L,BigInteger.Parse("4292039421591854273003520"),BigInteger.Parse("2905990310033882693113989027594240") };
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
public class A000576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000576Inst Instance=new A000576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000577
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,12L,24L,66L,160L,448L,1186L,3334L,9235L,26166L,73983L,211297L,604107L,1736328L,5000593L,14448984L,41835738L,121419260L,353045291L,1028452717L,3000800627L,8769216722L,25661961898L,75195166667L,220605519559L,647943626796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000577Inst : IEnumerable<long>
{
public static readonly long[] Value=A000577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000577.Bytes);
public long this[int i]=>Value[i];

public static A000577Inst Instance=new A000577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000578
{
public static readonly long[] Value={ 0L,1L,8L,27L,64L,125L,216L,343L,512L,729L,1000L,1331L,1728L,2197L,2744L,3375L,4096L,4913L,5832L,6859L,8000L,9261L,10648L,12167L,13824L,15625L,17576L,19683L,21952L,24389L,27000L,29791L,32768L,35937L,39304L,42875L,46656L,50653L,54872L,59319L,64000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000578Inst : IEnumerable<long>
{
public static readonly long[] Value=A000578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000578.Bytes);
public long this[int i]=>Value[i];

public static A000578Inst Instance=new A000578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000579
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,7L,28L,84L,210L,462L,924L,1716L,3003L,5005L,8008L,12376L,18564L,27132L,38760L,54264L,74613L,100947L,134596L,177100L,230230L,296010L,376740L,475020L,593775L,736281L,906192L,1107568L,1344904L,1623160L,1947792L,2324784L,2760681L,3262623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000579Inst : IEnumerable<long>
{
public static readonly long[] Value=A000579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000579.Bytes);
public long this[int i]=>Value[i];

public static A000579Inst Instance=new A000579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000580
{
public static readonly long[] Value={ 1L,8L,36L,120L,330L,792L,1716L,3432L,6435L,11440L,19448L,31824L,50388L,77520L,116280L,170544L,245157L,346104L,480700L,657800L,888030L,1184040L,1560780L,2035800L,2629575L,3365856L,4272048L,5379616L,6724520L,8347680L,10295472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000580Inst : IEnumerable<long>
{
public static readonly long[] Value=A000580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000580.Bytes);
public long this[int i]=>Value[i];

public static A000580Inst Instance=new A000580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000581
{
public static readonly long[] Value={ 1L,9L,45L,165L,495L,1287L,3003L,6435L,12870L,24310L,43758L,75582L,125970L,203490L,319770L,490314L,735471L,1081575L,1562275L,2220075L,3108105L,4292145L,5852925L,7888725L,10518300L,13884156L,18156204L,23535820L,30260340L,38608020L,48903492L,61523748L,76904685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000581Inst : IEnumerable<long>
{
public static readonly long[] Value=A000581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000581.Bytes);
public long this[int i]=>Value[i];

public static A000581Inst Instance=new A000581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000582
{
public static readonly long[] Value={ 1L,10L,55L,220L,715L,2002L,5005L,11440L,24310L,48620L,92378L,167960L,293930L,497420L,817190L,1307504L,2042975L,3124550L,4686825L,6906900L,10015005L,14307150L,20160075L,28048800L,38567100L,52451256L,70607460L,94143280L,124403620L,163011640L,211915132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000582Inst : IEnumerable<long>
{
public static readonly long[] Value=A000582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000582.Bytes);
public long this[int i]=>Value[i];

public static A000582Inst Instance=new A000582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000583
{
public static readonly long[] Value={ 0L,1L,16L,81L,256L,625L,1296L,2401L,4096L,6561L,10000L,14641L,20736L,28561L,38416L,50625L,65536L,83521L,104976L,130321L,160000L,194481L,234256L,279841L,331776L,390625L,456976L,531441L,614656L,707281L,810000L,923521L,1048576L,1185921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000583Inst : IEnumerable<long>
{
public static readonly long[] Value=A000583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000583.Bytes);
public long this[int i]=>Value[i];

public static A000583Inst Instance=new A000583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000584
{
public static readonly long[] Value={ 0L,1L,32L,243L,1024L,3125L,7776L,16807L,32768L,59049L,100000L,161051L,248832L,371293L,537824L,759375L,1048576L,1419857L,1889568L,2476099L,3200000L,4084101L,5153632L,6436343L,7962624L,9765625L,11881376L,14348907L,17210368L,20511149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000584Inst : IEnumerable<long>
{
public static readonly long[] Value=A000584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000584.Bytes);
public long this[int i]=>Value[i];

public static A000584Inst Instance=new A000584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000585
{
public static readonly BigInteger[] Value={ 4L,8L,20L,92L,2744L,950998216L,BigInteger.Parse("2076795963681989019155896"),BigInteger.Parse("21651217007530946175606768762255421159692845640522169779616") };
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
public class A000585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000585Inst Instance=new A000585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000586
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,2L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,4L,3L,4L,4L,4L,5L,5L,5L,6L,5L,6L,7L,6L,9L,7L,9L,9L,9L,11L,11L,11L,13L,12L,14L,15L,15L,17L,16L,18L,19L,20L,21L,23L,22L,25L,26L,27L,30L,29L,32L,32L,35L,37L,39L,40L,42L,44L,45L,50L,50L,53L,55L,57L,61L,64L,67L,70L,71L,76L,78L,83L,87L,89L,93L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000586Inst : IEnumerable<long>
{
public static readonly long[] Value=A000586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000586.Bytes);
public long this[int i]=>Value[i];

public static A000586Inst Instance=new A000586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000587
{
public static readonly long[] Value={ 1L,-1L,0L,1L,1L,-2L,-9L,-9L,50L,267L,413L,-2180L,-17731L,-50533L,110176L,1966797L,9938669L,8638718L,-278475061L,-2540956509L,-9816860358L,27172288399L,725503033401L,5592543175252L,15823587507881L,-168392610536153L,-2848115497132448L,-20819319685262839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000587Inst : IEnumerable<long>
{
public static readonly long[] Value=A000587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000587.Bytes);
public long this[int i]=>Value[i];

public static A000587Inst Instance=new A000587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000588
{
public static readonly long[] Value={ 0L,0L,0L,1L,7L,35L,154L,637L,2548L,9996L,38760L,149226L,572033L,2187185L,8351070L,31865925L,121580760L,463991880L,1771605360L,6768687870L,25880277150L,99035193894L,379300783092L,1453986335186L,5578559816632L,21422369201800L,82336410323440L,316729578421620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000588Inst : IEnumerable<long>
{
public static readonly long[] Value=A000588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000588.Bytes);
public long this[int i]=>Value[i];

public static A000588Inst Instance=new A000588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000589
{
public static readonly long[] Value={ 1L,11L,77L,440L,2244L,10659L,48279L,211508L,904475L,3798795L,15737865L,64512240L,262256280L,1059111900L,4254603804L,17018415216L,67837293986L,269638992062L,1069258071970L,4232010895376L,16723268860760L,65997186039785L,260170725132045L,1024713341952300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000589Inst : IEnumerable<long>
{
public static readonly long[] Value=A000589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000589.Bytes);
public long this[int i]=>Value[i];

public static A000589Inst Instance=new A000589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000670
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,541L,4683L,47293L,545835L,7087261L,102247563L,1622632573L,28091567595L,526858348381L,10641342970443L,230283190977853L,5315654681981355L,130370767029135901L,3385534663256845323L,BigInteger.Parse("92801587319328411133"),BigInteger.Parse("2677687796244384203115") };
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
public class A000670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000670Inst Instance=new A000670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000671
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,7L,14L,29L,60L,127L,275L,598L,1320L,2936L,6584L,14858L,33744L,76999L,176557L,406456L,939241L,2177573L,5064150L,11809632L,27610937L,64705623L,151966597L,357623905L,843176524L,1991439229L,4711115672L,11162025770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000671Inst : IEnumerable<long>
{
public static readonly long[] Value=A000671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000671.Bytes);
public long this[int i]=>Value[i];

public static A000671Inst Instance=new A000671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000672
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,4L,6L,11L,18L,37L,66L,135L,265L,552L,1132L,2410L,5098L,11020L,23846L,52233L,114796L,254371L,565734L,1265579L,2841632L,6408674L,14502229L,32935002L,75021750L,171404424L,392658842L,901842517L,2076217086L,4790669518L,11077270335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000672Inst : IEnumerable<long>
{
public static readonly long[] Value=A000672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000672.Bytes);
public long this[int i]=>Value[i];

public static A000672Inst Instance=new A000672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000673
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,2L,2L,6L,8L,18L,30L,67L,127L,275L,551L,1192L,2507L,5475L,11820L,26007L,57077L,126686L,281625L,630660L,1416116L,3195784L,7232624L,16430563L,37429146L,85528079L,195940960L,450074270L,1036226173L,2391193488L,5529420585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000673Inst : IEnumerable<long>
{
public static readonly long[] Value=A000673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000673.Bytes);
public long this[int i]=>Value[i];

public static A000673Inst Instance=new A000673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000674
{
public static readonly long[] Value={ 1L,3L,7L,16L,43L,138L,527L,2346L,11943L,68418L,435547L,3050026L,23300443L,192835698L,1718682167L,16412205306L,167173350543L,1809239622978L,20732358910387L,250773962554186L,3192953259262243L,42686640718266258L,597853508941160207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000674Inst : IEnumerable<long>
{
public static readonly long[] Value=A000674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000674.Bytes);
public long this[int i]=>Value[i];

public static A000674Inst Instance=new A000674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000675
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,2L,4L,5L,10L,19L,36L,68L,138L,277L,581L,1218L,2591L,5545L,12026L,26226L,57719L,127685L,284109L,634919L,1425516L,3212890L,7269605L,16504439L,37592604L,85876345L,196717882L,451768247L,1039990913L,2399476030L,5547849750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000675Inst : IEnumerable<long>
{
public static readonly long[] Value=A000675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000675.Bytes);
public long this[int i]=>Value[i];

public static A000675Inst Instance=new A000675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000676
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,2L,3L,7L,12L,27L,55L,127L,284L,682L,1618L,3979L,9823L,24722L,62651L,160744L,415146L,1081107L,2831730L,7462542L,19764010L,52599053L,140580206L,377244482L,1016022191L,2745783463L,7443742141L,20239038700L,55178647926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000676Inst : IEnumerable<long>
{
public static readonly long[] Value=A000676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000676.Bytes);
public long this[int i]=>Value[i];

public static A000676Inst Instance=new A000676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000677
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,3L,4L,11L,20L,51L,108L,267L,619L,1541L,3762L,9497L,23907L,61216L,157211L,407919L,1063398L,2792026L,7365532L,19535887L,52037837L,139213244L,373820978L,1007420841L,2723783122L,7387129661L,20091790330L,54793762295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000677Inst : IEnumerable<long>
{
public static readonly long[] Value=A000677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000677.Bytes);
public long this[int i]=>Value[i];

public static A000677Inst Instance=new A000677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000678
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,9L,18L,42L,96L,229L,549L,1347L,3326L,8330L,21000L,53407L,136639L,351757L,909962L,2365146L,6172068L,16166991L,42488077L,112004630L,296080425L,784688263L,2084521232L,5549613097L,14804572332L,39568107511L,105938822149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000678Inst : IEnumerable<long>
{
public static readonly long[] Value=A000678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000678.Bytes);
public long this[int i]=>Value[i];

public static A000678Inst Instance=new A000678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000679
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,51L,267L,2328L,56092L,10494213L,49487365422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000679Inst : IEnumerable<long>
{
public static readonly long[] Value=A000679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000679.Bytes);
public long this[int i]=>Value[i];

public static A000679Inst Instance=new A000679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000680
{
public static readonly BigInteger[] Value={ 1L,1L,6L,90L,2520L,113400L,7484400L,681080400L,81729648000L,12504636144000L,2375880867360000L,548828480360160000L,BigInteger.Parse("151476660579404160000"),BigInteger.Parse("49229914688306352000000"),BigInteger.Parse("18608907752179801056000000"),BigInteger.Parse("8094874872198213459360000000"),BigInteger.Parse("4015057936610313875842560000000") };
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
public class A000680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000680Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000680.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000680Inst Instance=new A000680Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000681
{
public static readonly BigInteger[] Value={ 1L,1L,3L,21L,282L,6210L,202410L,9135630L,545007960L,41514583320L,3930730108200L,452785322266200L,62347376347779600L,10112899541133589200UL,BigInteger.Parse("1908371363842760216400"),BigInteger.Parse("414517594539154672566000"),BigInteger.Parse("102681435747106627787376000"),BigInteger.Parse("28772944645196614863048048000") };
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
public class A000681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000681Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000681.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000681Inst Instance=new A000681Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000682
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,24L,66L,174L,504L,1406L,4210L,12198L,37378L,111278L,346846L,1053874L,3328188L,10274466L,32786630L,102511418L,329903058L,1042277722L,3377919260L,10765024432L,35095839848L,112670468128L,369192702554L,1192724674590L,3925446804750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000682Inst : IEnumerable<long>
{
public static readonly long[] Value=A000682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000682.Bytes);
public long this[int i]=>Value[i];

public static A000682Inst Instance=new A000682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000683
{
public static readonly BigInteger[] Value={ 0L,1L,6L,40L,360L,4576L,82656L,2122240L,77366400L,4002843136L,293717546496L,30558458490880L,4505780560619520L,941417163728674816L,BigInteger.Parse("278628902101315608576"),BigInteger.Parse("116805328001281573519360") };
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
public class A000683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000683Inst Instance=new A000683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000684
{
public static readonly BigInteger[] Value={ 1L,3L,13L,81L,721L,9153L,165313L,4244481L,154732801L,8005686273L,587435092993L,61116916981761L,9011561121239041L,1882834327457349633L,BigInteger.Parse("557257804202631217153"),BigInteger.Parse("233610656002563147038721"),BigInteger.Parse("138681207656726645785559041") };
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
public class A000684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000684Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000684.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000684Inst Instance=new A000684Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000685
{
public static readonly BigInteger[] Value={ 1L,5L,41L,545L,11681L,402305L,22207361L,1961396225L,276825510401L,62368881977345L,22413909724518401L,12840603873823473665UL,BigInteger.Parse("11720394922432296755201"),BigInteger.Parse("17037597932370037286600705") };
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
public class A000685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000685Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000685.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000685Inst Instance=new A000685Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000702
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,9L,14L,18L,24L,31L,43L,55L,72L,94L,123L,156L,200L,254L,324L,408L,513L,641L,804L,997L,1236L,1526L,1883L,2308L,2829L,3451L,4209L,5109L,6194L,7485L,9038L,10871L,13063L,15654L,18738L,22365L,26665L,31716L,37682L,44669L,52887L,62494L,73767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000702Inst : IEnumerable<long>
{
public static readonly long[] Value=A000702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000702.Bytes);
public long this[int i]=>Value[i];

public static A000702Inst Instance=new A000702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000703
{
public static readonly long[] Value={ 4L,6L,7L,7L,8L,9L,9L,10L,10L,10L,11L,11L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,19L,20L,20L,20L,20L,20L,21L,21L,21L,21L,21L,21L,22L,22L,22L,22L,22L,22L,22L,23L,23L,23L,23L,23L,23L,24L,24L,24L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000703Inst : IEnumerable<long>
{
public static readonly long[] Value=A000703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000703.Bytes);
public long this[int i]=>Value[i];

public static A000703Inst Instance=new A000703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000704
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,16L,46L,106L,316L,1324L,5356L,18316L,63856L,272416L,1264264L,5409496L,22302736L,101343376L,507711376L,2495918224L,11798364736L,58074029056L,309240315616L,1670570920096L,8792390355904L,46886941456576L,264381946998976L,1533013006902976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000704Inst : IEnumerable<long>
{
public static readonly long[] Value=A000704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000704.Bytes);
public long this[int i]=>Value[i];

public static A000704Inst Instance=new A000704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000705
{
public static readonly long[] Value={ 2L,3L,2L,5L,2L,3L,7L,2L,11L,13L,2L,3L,5L,17L,19L,2L,23L,7L,29L,3L,31L,2L,37L,41L,43L,47L,5L,53L,59L,2L,11L,61L,3L,67L,71L,73L,79L,13L,83L,89L,2L,97L,101L,103L,107L,7L,109L,113L,17L,127L,131L,137L,139L,3L,5L,149L,151L,19L,2L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000705Inst : IEnumerable<long>
{
public static readonly long[] Value=A000705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000705.Bytes);
public long this[int i]=>Value[i];

public static A000705Inst Instance=new A000705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000706
{
public static readonly BigInteger[] Value={ 1L,504L,270648L,144912096L,77599626552L,41553943041744L,22251789971649504L,11915647845248387520UL,BigInteger.Parse("6380729991419236488504"),BigInteger.Parse("3416827666558895485479576"),BigInteger.Parse("1829682703808504464920468048"),BigInteger.Parse("979779820147442370107345764512") };
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
public class A000706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000706Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A000706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000706.Bytes);
public BigInteger this[int i]=>Value[i];

public static A000706Inst Instance=new A000706Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000707
{
public static readonly long[] Value={ 1L,1L,2L,6L,20L,71L,259L,961L,3606L,13640L,51909L,198497L,762007L,2934764L,11333950L,43874857L,170193528L,661386105L,2574320659L,10034398370L,39163212165L,153027659730L,598577118991L,2343628878849L,9184197395425L,36020235035016L,141376666307608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000707Inst : IEnumerable<long>
{
public static readonly long[] Value=A000707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000707.Bytes);
public long this[int i]=>Value[i];

public static A000707Inst Instance=new A000707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000708
{
public static readonly long[] Value={ -1L,-1L,0L,1L,6L,29L,150L,841L,5166L,34649L,252750L,1995181L,16962726L,154624469L,1505035350L,15583997521L,171082318686L,1985148989489L,24279125761950L,312193418011861L,4210755676649046L,59445878286889709L,876726137720576550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000708Inst : IEnumerable<long>
{
public static readonly long[] Value=A000708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000708.Bytes);
public long this[int i]=>Value[i];

public static A000708Inst Instance=new A000708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000709
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,21L,38L,68L,124L,229L,428L,806L,1530L,2919L,5591L,10750L,20730L,40077L,77653L,150752L,293161L,570963L,1113524L,2174315L,4250367L,8317036L,16289636L,31931697L,62642861L,122980015L,241595101L,474910732L,934088141L,1838227618L,3619356631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000709Inst : IEnumerable<long>
{
public static readonly long[] Value=A000709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000709.Bytes);
public long this[int i]=>Value[i];

public static A000709Inst Instance=new A000709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000710
{
public static readonly long[] Value={ 1L,2L,5L,10L,20L,35L,62L,102L,167L,262L,407L,614L,919L,1345L,1952L,2788L,3950L,5524L,7671L,10540L,14388L,19470L,26190L,34968L,46439L,61275L,80455L,105047L,136541L,176593L,227460L,291673L,372605L,474085L,601105L,759380L,956249L,1200143L,1501749L,1873407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000710Inst : IEnumerable<long>
{
public static readonly long[] Value=A000710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000710.Bytes);
public long this[int i]=>Value[i];

public static A000710Inst Instance=new A000710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000711
{
public static readonly long[] Value={ 1L,3L,9L,22L,51L,107L,217L,416L,775L,1393L,2446L,4185L,7028L,11569L,18749L,29908L,47083L,73157L,112396L,170783L,256972L,383003L,565961L,829410L,1206282L,1741592L,2497425L,3557957L,5037936L,7091711L,9927583L,13823626L,19151731L,26404879L,36236988L,49509149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000711Inst : IEnumerable<long>
{
public static readonly long[] Value=A000711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000711.Bytes);
public long this[int i]=>Value[i];

public static A000711Inst Instance=new A000711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A000712
{
public static readonly long[] Value={ 1L,2L,5L,10L,20L,36L,65L,110L,185L,300L,481L,752L,1165L,1770L,2665L,3956L,5822L,8470L,12230L,17490L,24842L,35002L,49010L,68150L,94235L,129512L,177087L,240840L,326015L,439190L,589128L,786814L,1046705L,1386930L,1831065L,2408658L,3157789L,4126070L,5374390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A000712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A000712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A000712Inst : IEnumerable<long>
{
public static readonly long[] Value=A000712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A000712.Bytes);
public long this[int i]=>Value[i];

public static A000712Inst Instance=new A000712Inst();

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